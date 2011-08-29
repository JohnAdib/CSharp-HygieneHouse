using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HygieneHouse
{
    public partial class frmCustomer : Form
    {
        JDBConnection objDBC = new JDBConnection("Customer");
        JDBConnection objDBCType = new JDBConnection("CustomerType");
        CurrencyManager objCurrencyManager;
        public frmCustomer()
        {
            InitializeComponent();
            
            objCurrencyManager = (CurrencyManager)(this.BindingContext[objDBC.objDataView]);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindingContent();
        }
        private void BindingContent()
        {
            ClearBinding();
            txtCName.DataBindings.Add("Text", objDBC.objDataView, "CName");

            listBox1.DataSource = objDBCType.objDataSet;
            listBox1.DisplayMember = "CustomerType.TName";
            //listBox1.ValueMember = "Customer.CType";
            listBox1.DataBindings.Add("Text", objDBC.objDataView, "CType");

            cboCType.DataSource = objDBCType.objDataSet;
            cboCType.DisplayMember = "CustomerType.TName";

            //cboCType.ValueMember = "CustomerType.TypeID";
            //cboCType.DataBindings.Add("Text", objDBC.objDataView, "CType");

            txtCAddress.DataBindings.Add("Text", objDBC.objDataView, "CAddress");
            txtCTel.DataBindings.Add("Text", objDBC.objDataView, "CTel");
            //cboParent.DataBindings.Add("Text", objDBC.objDataView, "CParent");
            RewriteListView();
            Navigation(NavCmd.Nothing);

        }
        private void ClearBinding()
        {
            txtCName.DataBindings.Clear();
            txtCAddress.DataBindings.Clear();
            txtCTel.DataBindings.Clear();
        }
        private void RewriteListView()
        {
            lstData.Items.Clear();
            foreach (DataRow TargetRow in objDBC.objDataSet.Tables[objDBC._TableName].Rows)
            {
                lstData.Items.Add(TargetRow["CName"].ToString(), TargetRow["CustomerID"].ToString());
            }
        }

        enum NavCmd { First, Previous, Next, Last, Nothing }
        private void Navigation(NavCmd NavigationCommand)
        {
            switch (NavigationCommand)
            {
                case NavCmd.First:              // First
                    objCurrencyManager.Position = 0;
                    break;
                case NavCmd.Previous:          // Previous
                    objCurrencyManager.Position -= 1; break;
                case NavCmd.Next:               // Next
                    objCurrencyManager.Position += 1; break;
                case NavCmd.Last:               // Last
                    objCurrencyManager.Position = objCurrencyManager.Count - 1; break;
            }
            lstData.Items[objCurrencyManager.Position].Selected = true;
            NavigationValidation();
        }
        private void NavigationValidation()
        {
            if (objCurrencyManager.Position == 0)
            {
                btnMoveFirst.Enabled = false; btnMovePrevious.Enabled = false;
                btnMoveNext.Enabled = true; btnMoveLast.Enabled = true;
            }
            else if (objCurrencyManager.Position == objCurrencyManager.Count - 1)
            {
                btnMoveFirst.Enabled = true; btnMovePrevious.Enabled = true;
                btnMoveNext.Enabled = false; btnMoveLast.Enabled = false;
            }
            else
            {
                btnMoveFirst.Enabled = true; btnMovePrevious.Enabled = true;
                btnMoveNext.Enabled = true; btnMoveLast.Enabled = true;
            }
            txtCurrentPosition.Text = CurrentRecord();
            lblTotalNumber.Text = TotalRecord();

        }
        private string CurrentRecord() { return (objCurrencyManager.Position + 1).ToString(); }
        private string TotalRecord() { return (" از " + objCurrencyManager.Count); }
        private void btnMoveFirst_Click(object sender, EventArgs e) { Navigation(NavCmd.First); }
        private void btnMovePrevious_Click(object sender, EventArgs e) { Navigation(NavCmd.Previous); }
        private void btnMoveNext_Click(object sender, EventArgs e) { Navigation(NavCmd.Next); }
        private void btnMoveLast_Click(object sender, EventArgs e) { Navigation(NavCmd.Last); }
        private void txtCurrentPosition_MouseHover(object sender, EventArgs e)
        { pnlCurrentPosition.Visible = true; }
        private void txtCurrentPosition_MouseLeave(object sender, EventArgs e)
        { pnlCurrentPosition.Visible = false; }
        enum CmdType { Insert, Update, Delete }
        private void AddParams(CmdType CommandType)
        {   // Add each parameter to command

            objDBC.objCommand.Parameters.Clear();
            objDBC.objCommand.Parameters.AddWithValue("@CName", txtCName.Text);
            objDBC.objCommand.Parameters.AddWithValue("@CType", cboCType.Text);
            objDBC.objCommand.Parameters.AddWithValue("@CAddress", txtCAddress.Text);
            objDBC.objCommand.Parameters.AddWithValue("@CTel", txtCTel.Text);

            if (CommandType != CmdType.Insert)
                objDBC.objCommand.Parameters.AddWithValue("@CustomerID", this.BindingContext[objDBC.objDataView, "CustomerID"].Current);
        }

        private void RunCommand(CmdType CommandType, string PK, params string[] parameters)
        {
            string sqlcmd = "";

            switch (CommandType)
            {
                case CmdType.Insert:
                    sqlcmd = "insert into " + objDBC._TableName + " (";
                    foreach (string para in parameters) { sqlcmd += para + ", "; }
                    sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + ") values (";
                    foreach (string para in parameters) { sqlcmd += "@" + para + ", "; }
                    sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + ")";
                    objDBC.objCommand.CommandText = sqlcmd;
                    MessageBox.Show(sqlcmd);
                    AddParams(CmdType.Insert);
                    try
                    {
                        objDBC.objConnection.Open();
                        objDBC.objCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added!");
                    }
                    catch (System.Data.SqlClient.SqlException sqlExceptionErr)
                    {
                        MessageBox.Show(sqlExceptionErr.Message);
                    }
                    finally
                    {
                        objDBC.objConnection.Close();
                    }
                    break;

                case CmdType.Update:
                    sqlcmd = "update " + objDBC._TableName + " set ";
                    foreach (string para in parameters) { sqlcmd += para + " = @" + para + ", "; }
                    sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + " where " + PK + " = @" + PK;
                    objDBC.objCommand.CommandText = sqlcmd;
                    AddParams(CmdType.Update);
                    try
                    {
                        objDBC.objConnection.Open();
                        objDBC.objCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated!");
                    }
                    catch (System.Data.SqlClient.SqlException sqlExceptionErr)
                    {
                        MessageBox.Show(sqlExceptionErr.Message);
                    }
                    finally
                    {
                        objDBC.objConnection.Close();
                    }
                    break;

                case CmdType.Delete:
                    sqlcmd = "delete from " + objDBC._TableName + " where " + PK + " = @" + PK;
                    objDBC.objCommand.CommandText = sqlcmd;
                    AddParams(CmdType.Update);
                    try
                    {
                        objDBC.objConnection.Open();
                        objDBC.objCommand.ExecuteNonQuery();
                        MessageBox.Show("Successfully Updated!");
                    }
                    catch (System.Data.SqlClient.SqlException sqlExceptionErr)
                    {
                        MessageBox.Show(sqlExceptionErr.Message);
                    }
                    finally
                    {
                        objDBC.objConnection.Close();
                    }
                    break;
            }

            objDBC.JFillDataSetAndView();
            objCurrencyManager = (CurrencyManager)(this.BindingContext[objDBC.objDataView]);
            BindingContent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RunCommand(CmdType.Insert, "", "CName", "CAddress", "CTel");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RunCommand(CmdType.Update, "CustomerID", "CName", "CAddress", "CTel");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            RunCommand(CmdType.Delete, "CustomerID", "CName", "CAddress", "CTel");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearBinding();
            txtCName.Text = "";
            txtCAddress.Text = "";
            txtCTel.Text = "";
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objCurrencyManager.Position = lstData.SelectedItems[0].Index;
            }
            catch
            {
            }

            NavigationValidation();
        }
    }
}

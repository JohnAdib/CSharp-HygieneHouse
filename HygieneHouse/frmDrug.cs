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
    public partial class frmDrug : Form
    {
        JDBConnection objDBC = new JDBConnection("Drug");
        CurrencyManager objCurrencyManager;
        public frmDrug()
        {
            InitializeComponent();
            objCurrencyManager = (CurrencyManager)(this.BindingContext[objDBC.objDataView]);
        }

        private void AddDrug_Load(object sender, EventArgs e)
        {
            BindingContent();
        }

        private void BindingContent()
        {
            ClearBinding();
            txtDName.DataBindings.Add("Text", objDBC.objDataView, "DName");
            txtDValue.DataBindings.Add("Text", objDBC.objDataView, "DValue");
            txtDType.DataBindings.Add("Text", objDBC.objDataView, "DType");
            txtDPrice.DataBindings.Add("Text", objDBC.objDataView, "DPrice");
            txtExpDate.DataBindings.Add("Text", objDBC.objDataView, "ExpDate");
            RewriteListView();
            Navigation(NavCmd.Nothing);
            
        }

        private void ClearBinding()
        {
            txtDName.DataBindings.Clear();
            txtDValue.DataBindings.Clear();
            txtDType.DataBindings.Clear();
            txtDPrice.DataBindings.Clear();
            txtExpDate.DataBindings.Clear();
        }

        private void RewriteListView()
        {
            lstData.Items.Clear();
            foreach (DataRow TargetRow in objDBC.objDataSet.Tables[objDBC._TableName].Rows)
            { lstData.Items.Add(TargetRow["DName"] + "(" + TargetRow["DValue"].ToString() +" " +
                TargetRow["DType"].ToString() + ")", TargetRow["DrugID"].ToString()); }
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
            BindingDynamicContent();
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
        private void BindingDynamicContent()
        {
            DataRow TargetRow = objDBC.objDataSet.Tables[objDBC._TableName].Rows[objCurrencyManager.Position];
            
            if (!Convert.DBNull.Equals(TargetRow["ExpDate"])) txtExpDate.Value = (DateTime)(TargetRow["ExpDate"]);
            else txtExpDate.Value = DateTime.Now;


            if ((bool)TargetRow["Wodrugstore"]) lstdaro.SetItemChecked(0, true);
            else lstdaro.SetItemChecked(0, false);
            if ((bool)TargetRow["Village"]) lstdaro.SetItemChecked(1, true);
            else lstdaro.SetItemChecked(1, false);
            if ((bool)TargetRow["HHouse"]) lstdaro.SetItemChecked(2, true);
            else lstdaro.SetItemChecked(2, false);

            if ((bool)TargetRow["Sanitary"]) lsttype.SetItemChecked(0, true);
            else lsttype.SetItemChecked(0, false);
            if ((bool)TargetRow["Therapeutic"]) lsttype.SetItemChecked(1, true);
            else lsttype.SetItemChecked(1, false);
            if ((bool)TargetRow["Requirement"]) lsttype.SetItemChecked(2, true);
            else lsttype.SetItemChecked(2, false);


            if ((bool)TargetRow["Contraseptive"]) lstspec.SetItemChecked(0, true);
            else lstspec.SetItemChecked(0, false);
            if ((bool)TargetRow["Baby"]) lstspec.SetItemChecked(1, true);
            else lstspec.SetItemChecked(1, false);
        }

        enum CmdType { Insert, Update, Delete }
        private void AddParams(CmdType CommandType)
        {   // Add each parameter to command

            objDBC.objCommand.Parameters.Clear();
            objDBC.objCommand.Parameters.AddWithValue("@DName", txtDName.Text);
            objDBC.objCommand.Parameters.AddWithValue("@DValue", txtDValue.Text);
            objDBC.objCommand.Parameters.AddWithValue("@DType", txtDType.Text);
            objDBC.objCommand.Parameters.AddWithValue("@DPrice", txtDPrice.Text);
            objDBC.objCommand.Parameters.AddWithValue("@ExpDate", txtExpDate.Value);
            objDBC.objCommand.Parameters.AddWithValue("@Wodrugstore", lstdaro.GetItemCheckState(0));
            objDBC.objCommand.Parameters.AddWithValue("@Village", lstdaro.GetItemCheckState(1));
            objDBC.objCommand.Parameters.AddWithValue("@HHouse", lstdaro.GetItemCheckState(2));
            objDBC.objCommand.Parameters.AddWithValue("@Sanitary", lsttype.GetItemChecked(0));
            objDBC.objCommand.Parameters.AddWithValue("@Therapeutic", lsttype.GetItemChecked(1));
            objDBC.objCommand.Parameters.AddWithValue("@Requirement", lsttype.GetItemChecked(2));
            objDBC.objCommand.Parameters.AddWithValue("@Contraseptive", lstspec.GetItemChecked(0));
            objDBC.objCommand.Parameters.AddWithValue("@Baby", lstspec.GetItemChecked(1));
            
            if (CommandType != CmdType.Insert)
                objDBC.objCommand.Parameters.AddWithValue("@DrugID", this.BindingContext[objDBC.objDataView, "DrugID"].Current);
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
                    foreach (string para in parameters) { sqlcmd += "@"+ para + ", "; }
                    sqlcmd = sqlcmd.Substring(0, sqlcmd.Length - 2) + ")";
                    objDBC.objCommand.CommandText = sqlcmd;
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
        { RunCommand(CmdType.Insert, "", "DName", "DValue", "DType", "DPrice", "ExpDate", "Wodrugstore",
           "Village", "HHouse", "Sanitary", "Therapeutic", "Requirement", "Contraseptive","Baby"); }
        private void btnUpdate_Click(object sender, EventArgs e)
        { RunCommand(CmdType.Update, "DrugID", "DName", "DValue", "DType", "DPrice", "ExpDate", "Wodrugstore",
           "Village", "HHouse", "Sanitary", "Therapeutic", "Requirement", "Contraseptive", "Baby"); }
        private void btnDelete_Click(object sender, EventArgs e)
        { RunCommand(CmdType.Delete, "DrugID", "DName", "DValue", "DType", "DPrice", "ExpDate", "Wodrugstore",
           "Village", "HHouse", "Sanitary", "Therapeutic", "Requirement", "Contraseptive", "Baby"); }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearBinding();
            txtDName.Text = "";
            txtDValue.Text = "";
            txtDType.Text = "";
            txtDPrice.Text = "";
            txtExpDate.Value = DateTime.Today;
            foreach (int i in lstdaro.CheckedIndices) { lstdaro.SetItemChecked(i, false); }
            foreach (int i in lsttype.CheckedIndices) { lsttype.SetItemChecked(i, false); }
            foreach (int i in lstspec.CheckedIndices) { lstspec.SetItemChecked(i, false); }
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
            BindingDynamicContent();
        }

        private void lbDName_Click(object sender, EventArgs e)
        {
            lstdaro.SetItemChecked(0, true);
        }


    }
}

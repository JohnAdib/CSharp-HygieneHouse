using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HygieneHouse
{
    public partial class frmSupplierold : Form
    {
        // Constant Strings
        private const string _ConnectionString = 
            "server=.;database=HygieneHouse;user id=sa;password=2190053994";
        private const string _TableName = "Supplier";
        private const string _CommandText = "select * from dbo." + _TableName;
        
        // Declare global objects...
        SqlConnection objConnection;
        SqlDataAdapter objDataAdapter;
        DataSet objDataSet;
        DataView objDataView;
        CurrencyManager objCurrencyManager;
        SqlCommand objCommand;

        private void JFillDataSetAndView()
        {
            // initialize a new instance of the DataSet object...
            objDataSet = new DataSet();
            // Fill the DataSet object with data...
            objDataAdapter.Fill(objDataSet, _TableName);
            // Set the DataView object to the DataSet object...
            objDataView = new DataView(objDataSet.Tables[_TableName]);

            // Set our CurrencyManager object to the DataView object...
            objCurrencyManager = (CurrencyManager)(this.BindingContext[objDataView]);
        }
        private void JBindingFields()
        {
            // Clear any previous bindings...
            txtRecordPosition.DataBindings.Clear();
            txtSAddress.DataBindings.Clear();
            txtSName.DataBindings.Clear();
            txtSTel.DataBindings.Clear();

            // Add new bindings to ythe DataView object...
            txtSName.DataBindings.Add("Text",objDataView, "SName");
            txtSAddress.DataBindings.Add("Text", objDataView, "SAddress");
            txtSTel.DataBindings.Add("Text", objDataView, "STel");
        }

        private void JShowPosition()
        {
            // Always format the number in the txt price field //

            // Display the current position and the number of records...
            txtRecordPosition.Text = (objCurrencyManager.Position + 1) + " از " +
                objCurrencyManager.Count;
        }

        public frmSupplierold()
        {
            objConnection = new SqlConnection(_ConnectionString);
            objDataAdapter = new SqlDataAdapter(_CommandText, objConnection);
            objCommand = new SqlCommand();
            objCommand.Connection = objConnection;

            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            // Fill the DataSet and bind the fields...
            JFillDataSetAndView();
            JBindingFields();
            // Show the current record position...
            JShowPosition();

            grdSupplier.DataSource = objDataSet;
            grdSupplier.DataMember = "Supplier";
            
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            // Set the Record position to the first record...
            objCurrencyManager.Position = 0;

            //show the current record position...
            JShowPosition();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            // Move to the Previous record...
            objCurrencyManager.Position -= 1;

            //show the current record position...
            JShowPosition();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            // Move to the Next record...
            objCurrencyManager.Position += 1;

            //show the current record position...
            JShowPosition();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            // Move to the Last record...
            objCurrencyManager.Position = objCurrencyManager.Count-1;

            //show the current record position...
            JShowPosition();
        }

        private void lblSName_Click(object sender, EventArgs e)
        {
            objDataView.Sort = "SName";
            btnMoveFirst_Click(null, null);
        }

        private void lblSAddress_Click(object sender, EventArgs e)
        {
            objDataView.Sort = "SAddress";
            btnMoveFirst_Click(null, null);
        }

        private void lblSTel_Click(object sender, EventArgs e)
        {
            objDataView.Sort = "STel";
            btnMoveFirst_Click(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSAddress.Text = "";
            txtSName.Text = "";
            txtSTel.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objCommand.CommandText = "insert into Supplier " +
                "(SName, SAddress, STel) " +
                " values (@SName, @SAddress, @STel)";
            objCommand.Parameters.AddWithValue("@SName", txtSName.Text);
            objCommand.Parameters.AddWithValue("@SAddress", txtSAddress.Text);
            objCommand.Parameters.AddWithValue("@STel", txtSTel.Text);
           

            try
            {
                objConnection.Open();
                objCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Added!");
            }
            catch(SqlException sqlExceptionErr)
            {
                MessageBox.Show(sqlExceptionErr.Message);
            }
            objConnection.Close();
            JFillDataSetAndView();
            JBindingFields();
            JShowPosition();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Set the sqlCommand obect properties...
            objCommand.CommandText = "update Supplier " +
                "set SName = @SName, SAddress = @SAddress, STel = @STel " +
                "where SupplierID = @SupplierID";
            objCommand.CommandType = CommandType.Text;
            
            objCommand.Parameters.AddWithValue("@SupplierID", 
                this.BindingContext[objDataView,"SupplierID"].Current);
            objCommand.Parameters.AddWithValue("@SName", txtSName.Text);
            objCommand.Parameters.AddWithValue("@SAddress", txtSAddress.Text);
            objCommand.Parameters.AddWithValue("@STel", txtSTel.Text);

            try
            {
                objConnection.Open();
                objCommand.ExecuteNonQuery();
                //objCommand.Parameters.Remove("@SupplierID");
                MessageBox.Show("Successfully Updated!");
            }
            catch (SqlException sqlExceptionErr)
            {
                MessageBox.Show(sqlExceptionErr.Message);
            }
            objConnection.Close();
            JFillDataSetAndView();
            JBindingFields();
            JShowPosition();
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Set the sqlCommand obect properties...
            objCommand.CommandText = "delete from Supplier " +
                "where SupplierID = @SupplierID";
            objCommand.CommandType = CommandType.Text;
            objCommand.Parameters.AddWithValue("@SupplierID",
                this.BindingContext[objDataView, "SupplierID"].Current);
            try
            {
                objConnection.Open();
                objCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
            }
            catch (SqlException sqlExceptionErr)
            {
                MessageBox.Show(sqlExceptionErr.Message);
            }
            objConnection.Close();
            JFillDataSetAndView();
            JBindingFields();
            JShowPosition();
            
        }




    }
}

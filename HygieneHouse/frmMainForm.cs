using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HygieneHouse
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        public void ShowAboutBox()
        {
            frmAbout objAbout = new frmAbout();
            objAbout.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {            ShowAboutBox();        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            Application.Exit();        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {            undoToolStripMenuItem_Click(sender, e);        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {            cutToolStripMenuItem_Click(sender, e);        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {            copyToolStripMenuItem_Click(sender, e);        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {            pasteToolStripMenuItem_Click(sender, e);        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {            selectAllToolStripMenuItem_Click(sender, e);        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSupplierold objAddSupplier = new frmSupplierold();
            objAddSupplier.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDrug objdrug = new frmDrug();
            objdrug.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmSupplier objAddSupplier = new frmSupplier();
            objAddSupplier.ShowDialog(this);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCustomer objAddSupplier = new frmCustomer();
            objAddSupplier.ShowDialog(this);
        }
    }
}

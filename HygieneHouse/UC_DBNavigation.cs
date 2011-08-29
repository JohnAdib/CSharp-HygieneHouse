using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HygieneHouse
{
    public partial class UC_DBNavigation : UserControl
    {
        public UC_DBNavigation()
        {
            InitializeComponent();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ParentForm.Text);
        }
    }
}

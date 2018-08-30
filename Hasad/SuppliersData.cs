using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasad
{
    public partial class SuppliersData : Form
    {
        public SuppliersData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SupplierDataAddNew"] == null)
            {
                new SupplierDataAddNew().Show();
            }
        }
    }
}

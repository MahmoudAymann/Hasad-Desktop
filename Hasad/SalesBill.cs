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
    public partial class SalesBill : Form
    {
        public SalesBill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBillAddNew"] == null)
            {
                new SalesBillAddNew().Show();
            }
        }
    }
}

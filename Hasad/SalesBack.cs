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
    public partial class SalesBack : Form
    {
        public SalesBack()
        {
            InitializeComponent();
        }

        private void buttonSalesBackNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SalesBackAddNew"] == null)
            {
                new SalesBackAddNew().Show();
            }
        }
    }
}

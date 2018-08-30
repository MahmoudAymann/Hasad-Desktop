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
    public partial class AmountsFromTreasury : Form
    {
        public AmountsFromTreasury()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AmountsFromTreasuryAddNew"] == null)
            {
                new AmountsFromTreasuryAddNew().Show();
            }
        }
    }
}

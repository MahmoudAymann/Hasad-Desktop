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
    public partial class AmountsReceivedForTreasury : Form
    {
        public AmountsReceivedForTreasury()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AmountsReceivedForTreasuryAddNew"] == null)
            {
                new AmountsReceivedForTreasuryAddNew().Show();
            }
        }
    }
}

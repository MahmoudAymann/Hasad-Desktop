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
    public partial class ExpensesGroups : Form
    {
        public ExpensesGroups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ExpensesGroupsAddNew"] == null)
            {
                new ExpensesGroupsAddNew().Show();
            }
        }
    }
}

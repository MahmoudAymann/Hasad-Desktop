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
    public partial class ItemsInfo : Form
    {
        public ItemsInfo()
        {
            InitializeComponent();
        }

        private void buttonNewII_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ItemsInfoAddItem"] == null)
            {
                new ItemsInfoAddItem().Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Hasad
    
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

       

        private const string strconneciton = @"Data Source=Spectra5;Initial Catalog=Hasad;Integrated Security=True";        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strconneciton);
            string command = "SELECT COUNT(*) FROM login WHERE name='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(command, con);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                new MainPage().Show();
                Hide();
            }
            else
                MessageBox.Show("Invalid username or password");

        
        }//end button click

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }
    }//end class Form1
}//end loginForm

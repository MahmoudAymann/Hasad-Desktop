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


namespace Hasad
{
    public partial class AssetBalances : Form
    {
        private const string strconneciton = @"Data Source=PC;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();

        public AssetBalances()
        {
            InitializeComponent();
            fillComboBoxStoreInfoAS();

        }

        private void fillComboBoxStoreInfoAS()
        {

            string query = "select * from StoreInfo;";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sqlReader;
            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["store_name"].ToString();
                    comboBoxStoreInfoAS.Items.Add(col);

                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

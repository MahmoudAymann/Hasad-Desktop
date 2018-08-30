using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hasad
{
    public partial class ItemsInfoAddItem : Form
    {
        private const string strconneciton = @"Data Source=Spectra;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        string imgLoc = "";
        public ItemsInfoAddItem()
        {
            InitializeComponent();
            fillComboBoxCompanyInfo();
            fillComboBoxDataGroups();
        }

        void fillComboBoxCompanyInfo()
        {
            string query = "select * from CompanyInfo;";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sqlReader;
            try
            {
                con.Open();
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    string col = sqlReader["company_name"].ToString();
                    comboBoxCompanyInfo.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBoxCompanyInfo

        void fillComboBoxDataGroups()
        {
            string query = "select * from DataGroups;";
            cmd.CommandText = query;
            cmd.Connection = con;
            SqlDataReader sqlReaderDG;
            try
            {
                con.Open();
                sqlReaderDG = cmd.ExecuteReader();
                while (sqlReaderDG.Read())
                {
                    string col = sqlReaderDG["data_groups_name"].ToString();
                    comboBoxDataGroups.Items.Add(col);
                }
                con.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }//end fillComboBoxCompanyInfo



        private void buttonCancelIIAI_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Select product pic";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }
        }

        private void buttonEditIIAI_Click(object sender, EventArgs e)
        {

        }
    }
}

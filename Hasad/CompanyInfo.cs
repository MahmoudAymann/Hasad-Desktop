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
    public partial class CompanyInfo : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();

        public CompanyInfo(){
            InitializeComponent();
            con.Open();
            loadData();
            resizeGridView();
        }

        private void resizeGridView()
        {
            this.dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.Columns[0].HeaderText = "الكود";
            dataGridView2.Columns[1].HeaderText = "اسم الشركــة";
        }

        private void button1_Click(object sender, EventArgs e)
        {////////INSERT  btn/////////
            insertToDb();
            loadData();
        }//end insert button

        private void insertToDb()
        {
            try{
                cmd.CommandText = "INSERT INTO CompanyInfo VALUES(@code,@company_name)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", textBox_company_code.Text);
                cmd.Parameters.AddWithValue("@company_name", textBox_companyName.Text);
                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                   MessageBox.Show("فشل التسجيل فى قاعدة البيانات");
                                
            }//end try
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }//end insertToDb

        private void button2_Click(object sender, EventArgs e)
        {//////////DELETE  Btn///////////
            deleteCompanyInfoItems();
            loadData();
        }//end btn delete
        
        private void deleteCompanyInfoItems()
        {
            //delete multiple rows
            if (dataGridView2.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell oneCell in dataGridView2.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView2.Rows.RemoveAt(oneCell.RowIndex);
                }
            }//end if
            //THEN
             //////////////////////////////////////
            try
            {
                cmd.CommandText = "TRUNCATE TABLE CompanyInfo";
                cmd.ExecuteNonQuery();

                insertAfterDeleteIntoDb();

                MessageBox.Show("done");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }//end deleteCompnayInfoItems

        private void insertAfterDeleteIntoDb()
        {

            SqlCommand cmd2 = new SqlCommand("Insert into CompanyInfo(code,company_name) values(@code,@company_name)", con);

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++){
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@code", dataGridView2.Rows[i].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@company_name", dataGridView2.Rows[i].Cells[1].Value);
                cmd2.ExecuteNonQuery();
            }//end for
            
        }//end insertAfterDeleteIntoDb

        private void button3_Click(object sender, EventArgs e)
        {
            /////////////NEW Btn/////////////////
            textBox_companyName.Enabled = true;
            textBox_company_code.Enabled = true;
            buttonInsert_companyInfo.Enabled = true;
            buttonModify_companyInfo.Enabled = false;
            textBox_companyName.Clear();

            textBox_company_code.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ////LoadData Button////
            loadData();
        }

        private void loadData()
        {
            try
            {
                cmd.CommandText = "SELECT * from CompanyInfo;";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView2.DataSource = bSource;
                adapter.Update(dataTable);
            }
            catch (Exception ed){
                MessageBox.Show(ed.Message);
            }
        }//end loadData()

        private void button5_Click(object sender, EventArgs e)
        {/////////Button Edit//////////////

            SqlCommand cmd = new SqlCommand("Update CompanyInfo set code=@code,company_name=@name Where(code=@code)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", textBox_company_code.Text);
            cmd.Parameters.AddWithValue("@name", textBox_companyName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم تعديل البيانات");
            Bind();
            clearTextBoxes();

        }

        private void clearTextBoxes()
        {
            textBox_companyName.Clear();
            textBox_company_code.Clear();
        }

        private void Bind()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CompanyInfo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            textBox_company_code.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBox_company_code.Enabled = false;
            textBox_companyName.Enabled = true;
            buttonInsert_companyInfo.Enabled = false;
            buttonModify_companyInfo.Enabled = true;
        }

    }//end class
}//end namespace

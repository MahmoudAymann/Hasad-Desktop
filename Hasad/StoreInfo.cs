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

namespace Hasad
{
    public partial class StoreInfo : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();
        public StoreInfo()
        {
            InitializeComponent();
            con.Open();
            loadData();
            resizeGridView();
        }
        private void resizeGridView()
        {
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].HeaderText = "الكود";
            dataGridView1.Columns[1].HeaderText = "اسم المخزن";
            dataGridView1.Columns[2].HeaderText = "عنوان المخزن";

        }


        private void buttonInsert_Click(object sender, EventArgs e)
        {/////////////INSERT Btn//////////
            if (textBox_storeName.Text != null && textBox_store_address.Text != null)
            {
                insertData();
                loadData();
                resizeGridView();
                button_deleteStore.Enabled = false;
                button_modify_storeInfo.Enabled = false;
            }
            else
                MessageBox.Show("ادخل كل البيانات");
        }

        private void insertData()
        {
            try
            {
                cmd.CommandText = "INSERT INTO StoreInfo VALUES(@code,@store_name,@store_address)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", code_tb.Text);
                cmd.Parameters.AddWithValue("@store_name", textBox_storeName.Text);
                cmd.Parameters.AddWithValue("@store_address", textBox_store_address.Text);
                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                    MessageBox.Show("فشل التسجيل بقاعدة البيانات");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
         //Load data button
            loadData();
            resizeGridView();
        }//end button load data

        private void loadData()
        {
            try{
                cmd.CommandText = "SELECT * from StoreInfo;";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView1.DataSource = bSource;
                adapter.Update(dataTable);
            }
            catch (Exception ed){
                MessageBox.Show(ed.Message);
            }
        }//end loadData()

        private void button_deleteStore_Click(object sender, EventArgs e)
        {
            /////delete btn///////////

            deleteMultipleRowsFromGrid();
            
            try{
                cmd.CommandText = "TRUNCATE TABLE StoreInfo";
                cmd.ExecuteNonQuery();

                insertIntoDb();
                loadData();
                MessageBox.Show("تم المسح");
            }
            catch (Exception er){
                MessageBox.Show(er.Message);
            }
            resizeGridView();
        }//end btn delete

        private void deleteMultipleRowsFromGrid()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }
            }//end if
        }//end deleteMultiple

        private void insertIntoDb()
        {
            cmd.CommandText = "Insert into StoreInfo(code,store_name,store_address) values(@code,@store_name,@store_address)";
            cmd.Connection = con;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@store_name", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@store_address", dataGridView1.Rows[i].Cells[2].Value);
                cmd.ExecuteNonQuery();
            }//end for
        }//end insertIntoDb

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //////////EDIT BTN//////////
            cmd.CommandText = "Update StoreInfo set code=@code,store_name=@name, store_address=@address Where(code=@code)";
            cmd.Connection = con;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", code_tb.Text);
            cmd.Parameters.AddWithValue("@name", textBox_storeName.Text);
            cmd.Parameters.AddWithValue("@address", textBox_store_address.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("تم تعديل البيانات");
            Bind();
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            code_tb.Clear();
            textBox_storeName.Clear();
            textBox_store_address.Clear();
        }

        private void Bind()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from StoreInfo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ////////////NEW btn//////////////////
            code_tb.Enabled = true;
            textBox_storeName.Enabled = true;
            textBox_store_address.Enabled = true;
            resizeGridView();
            button_deleteStore.Enabled = false;
            button_modify_storeInfo.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ///////////// cancel ////////////////////
            code_tb.Enabled = false;
            textBox_storeName.Enabled = false;
            textBox_store_address.Enabled = false;
            clearTextBoxes();

            button_deleteStore.Enabled = false;
            button_modify_storeInfo.Enabled = false;
            resizeGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            code_tb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();


            code_tb.Enabled = false;
            textBox_storeName.Enabled = true;
            textBox_store_address.Enabled = true;
            buttonInsert_storeInfo.Enabled = false;
            button_modify_storeInfo.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button_deleteStore.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            code_tb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            code_tb.Enabled = false;
            textBox_storeName.Enabled = true;
            textBox_store_address.Enabled = true;
            buttonInsert_storeInfo.Enabled = false;
            button_modify_storeInfo.Enabled = true;
        }

        
    }//end class
}//end namespace

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
    public partial class DataGroups : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();

        public DataGroups(){
            InitializeComponent();
            con.Open();
            loadData();
            resizeGridView();
            buttonSearchDG.Text = "asdasd";
        }

        string Query;
       // DataSet dataset;
        DataTable dataTable;
        SqlDataAdapter sqladapter;

        private void resizeGridView()
        {
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].HeaderText = "الكــود";
            dataGridView1.Columns[1].HeaderText = "إســم الصــنف";
        }

        private void button6_Click(object sender, EventArgs e){
            //////////update btn///////////
            loadData();
            resizeGridView();
        }
        private void loadData()
        {
            try
            {
                cmd.CommandText = "SELECT * from DataGroups;";
                cmd.Connection = con;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                dataTable = new DataTable();
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

        private void clearTextBoxes() {
            add_code_tb.Clear();
            add_name_tb.Clear();
            code_search_tb.Clear();
            name_search_tb.Clear();
        }

        private void buttonNewDG_Click(object sender, EventArgs e)
        {///////NEW btn////////////
            add_name_tb.Enabled = true;
            add_code_tb.Enabled = true;
            
            code_search_tb.Enabled = false;
            name_search_tb.Enabled = false;
            clearTextBoxes();
            buttonInsert_dataGroups.Enabled = true;
            buttonModify_dataGroups.Enabled = false;
            buttonDelete_dataGroups.Enabled = false;
            buttonCancelDG.Enabled = true;
        }

        private void buttonInsertDG_Click(object sender, EventArgs e){
            ///////Insert btn////////////
            insertToDb();
            resizeGridView();
            clearTextBoxes();
            loadData();
        }

        private void insertToDb(){
            try
            {
                cmd.CommandText = "INSERT INTO DataGroups VALUES(@code,@data_groups_name)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", add_code_tb.Text);
                cmd.Parameters.AddWithValue("@data_groups_name", add_name_tb.Text);
                int i = cmd.ExecuteNonQuery();

                if (i == 0)
                    MessageBox.Show("فشل التسجيل فى قاعدة البيانات");
                clearTextBoxes();

            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("الرجاء إضفافة البيانات");
                clearTextBoxes();
            }
        }//end insertToDb

        private void buttonDeleteDG_Click(object sender, EventArgs e)
        {//////////delete btn///////////
            deleteCellsFromGrid();
            insertAfterDeleteIntoDb();
            loadData();
        
            //resizeGridView();
         }//end btn delete

        private void deleteCellsFromGrid() {
            //delete multiple rows
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }
            }//end if
             // else
             //////////////////////////////////////
              try{
                 cmd.CommandText = "TRUNCATE TABLE DataGroups";
                 cmd.ExecuteNonQuery();
                
              MessageBox.Show("تم المسح");
              }
             catch (Exception er){
                  MessageBox.Show(er.Message);
               }
        }//end delete cells

        private void insertAfterDeleteIntoDb()
        {
            // SqlCommand cmd2 = new SqlCommand("Insert into DataGroups(code,data_groups_name) values(@code,@data_groups_name)", con);
            cmd.CommandText = "Insert into DataGroups(code,data_groups_name) values(@code,@data_groups_name)";
            cmd.Connection = con;
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@data_groups_name", dataGridView1.Rows[i].Cells[1].Value);
                cmd.ExecuteNonQuery();
            }//end for
        }

        private void buttonEditDG_Click(object sender, EventArgs e)
        {/////////Edit Butoon/////////
           
            SqlCommand cmd = new SqlCommand("Update DataGroups set code=@code,data_groups_name=@name Where(code=@code)", con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", add_code_tb.Text);
            cmd.Parameters.AddWithValue("@name", add_name_tb.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم تعديل البيانات");
            Bind();
            clearTextBoxes();

        }//end edit button

        private void Bind()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from DataGroups", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void buttonSearchDG_Click(object sender, EventArgs e)
        {//////////search Btn///////////
            code_search_tb.Enabled = true;
            name_search_tb.Enabled = true;

            add_name_tb.Enabled = false;
            add_code_tb.Enabled = false;

            buttonInsert_dataGroups.Enabled = false;
            buttonModify_dataGroups.Enabled = false;
        }

        private void buttonCancelSearchDG_Click(object sender, EventArgs e){
            //////////////cancel search BTN////////////
            code_search_tb.Enabled = false;
            name_search_tb.Enabled = false;

            buttonDelete_dataGroups.Enabled = false;
        }

        private void buttonCancelDG_Click(object sender, EventArgs e)
        {/////cancel Btn/////////
            add_name_tb.Enabled = false;
            add_code_tb.Enabled = false;
            buttonModify_dataGroups.Enabled = false;
            buttonDelete_dataGroups.Enabled = false;
        }

        private void code_search_tb_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("Convert([code], System.String) LIKE '%{0}%'", code_search_tb.Text);
            dataGridView1.DataSource = DV;
        }

        private void name_search_tb_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dataTable);
            DV.RowFilter = string.Format("data_groups_name LIKE '%{0}%'", name_search_tb.Text);
            dataGridView1.DataSource = DV;
        }

        private void DataGroups_Load(object sender, EventArgs e)
        {
            //form load event here data will show in the data gridview
            Query = "select * from DataGroups";
            cmd.CommandText = Query;
            sqladapter = new SqlDataAdapter();
            dataTable = new DataTable();
            sqladapter.SelectCommand = cmd;
            sqladapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void buttonUpdateDG_Click(object sender, EventArgs e){
            loadData();
            resizeGridView();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){

            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            add_code_tb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            add_code_tb.Enabled = false;
            add_name_tb.Enabled = true;
            buttonModify_dataGroups.Enabled = true;
            buttonDelete_dataGroups.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            buttonDelete_dataGroups.Enabled = true;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            buttonModify_dataGroups.Enabled = false;
        }

        
    }//end class
}//end namespace

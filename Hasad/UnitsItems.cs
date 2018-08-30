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
    public partial class UnitsItems : Form
    {
        private const string strconneciton = @"Data Source=SPECTRA5;Initial Catalog=Hasad;Integrated Security=True";
        SqlConnection con = new SqlConnection(strconneciton);
        SqlCommand cmd = new SqlCommand();

        public UnitsItems()
        {
            InitializeComponent();
            con.Open();
            loadData();
            resizeGridView();
        }
        string Query;
        
        DataTable dataTable;
        SqlDataAdapter sqladapter;

        private void resizeGridView()
        {
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].HeaderText = "الكــود";
            dataGridView1.Columns[1].HeaderText = "إســم الصــنف";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //////////update btn///////////
            loadData();
            resizeGridView();
        }
        private void loadData()
        {
            try
            {
                cmd.CommandText = "SELECT * from UnitsItems;";
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
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
        }//end loadData()

        private void clearTextBoxes()
        {
            add_code_tb.Clear();
            add_name_tb.Clear();
            code_search_tb.Clear();
            name_search_tb.Clear();
        }

        private void buttonNewUI_Click(object sender, EventArgs e)
        {///////NEW btn////////////
            add_name_tb.Enabled = true;
            add_code_tb.Enabled = true;

            code_search_tb.Enabled = false;
            name_search_tb.Enabled = false;
            clearTextBoxes();
            buttonInsertUI.Enabled = true;
            buttonEditUI.Enabled = false;
            
        }

        private void buttonInsertUI_Click(object sender, EventArgs e)
        {
            ///////Insert btn////////////
            insertToDb();
            resizeGridView();
            clearTextBoxes();
            loadData();
        }

        private void insertToDb()
        {
            try
            {
                cmd.CommandText = "INSERT INTO UnitsItems VALUES(@code,@name)";
                cmd.Connection = con;
                cmd.Parameters.Clear(); //very important
                cmd.Parameters.AddWithValue("@code", add_code_tb.Text);
                cmd.Parameters.AddWithValue("@name", add_name_tb.Text);
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

        private void buttonDeleteUI_Click(object sender, EventArgs e)
        {//////////delete btn///////////
            deleteCellsFromGrid();
            insertAfterDeleteIntoDb();
            loadData();

            //resizeGridView();
        }//end btn delete

        private void deleteCellsFromGrid()
        {
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
            try
            {
                cmd.CommandText = "TRUNCATE TABLE UnitsItems";
                cmd.ExecuteNonQuery();

                MessageBox.Show("تم المسح");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }//end delete cells

        private void insertAfterDeleteIntoDb()
        {
            cmd.CommandText = "Insert into UnitsItems(code,name) values(@code,@name)";
            cmd.Connection = con;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value);
                cmd.ExecuteNonQuery();
            }//end for
        }

        private void buttonEditUI_Click(object sender, EventArgs e)
        {/////////Edit Butoon/////////

            SqlCommand cmd = new SqlCommand("Update UnitsItems set code=@code,name=@name Where(code=@code)", con);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from UnitsItems", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void buttonSearchUI_Click(object sender, EventArgs e)
        {//////////search Btn///////////
            code_search_tb.Enabled = true;
            name_search_tb.Enabled = true;

            add_name_tb.Enabled = false;
            add_code_tb.Enabled = false;

            buttonInsertUI.Enabled = false;
            buttonEditUI.Enabled = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //////////////cancel search BTN////////////
            code_search_tb.Enabled = false;
            name_search_tb.Enabled = false;

        }

        private void buttonCancelUI_Click(object sender, EventArgs e)
        {/////cancel Btn/////////
            add_name_tb.Enabled = false;
            add_code_tb.Enabled = false;
            buttonEditUI.Enabled = false;
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
            DV.RowFilter = string.Format("name LIKE '%{0}%'", name_search_tb.Text);
            dataGridView1.DataSource = DV;
        }

        private void DataGroups_Load(object sender, EventArgs e)
        {
            //form load event here data will show in the data gridview
            Query = "select * from UnitsItems";
            cmd.CommandText = Query;
            sqladapter = new SqlDataAdapter();
            dataTable = new DataTable();
            sqladapter.SelectCommand = cmd;
            sqladapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void buttonUpdateUI_Click(object sender, EventArgs e)
        {
            loadData();
            resizeGridView();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            add_code_tb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            add_code_tb.Enabled = false;
            add_name_tb.Enabled = true;
            buttonEditUI.Enabled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            buttonDeleteUI.Enabled = true;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditUI.Enabled = false;
        }

    }//end class
}//end namesapce

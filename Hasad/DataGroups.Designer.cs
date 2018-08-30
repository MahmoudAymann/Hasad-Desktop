namespace Hasad
{
    partial class DataGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1_dataGroups = new System.Windows.Forms.GroupBox();
            this.buttonCancelDG = new System.Windows.Forms.Button();
            this.buttonDelete_dataGroups = new System.Windows.Forms.Button();
            this.buttonModify_dataGroups = new System.Windows.Forms.Button();
            this.buttonInsert_dataGroups = new System.Windows.Forms.Button();
            this.buttonNewDG = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCancelSearchDG = new System.Windows.Forms.Button();
            this.buttonSearchDG = new System.Windows.Forms.Button();
            this.groupBox2_DataGroups = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.add_name_tb = new System.Windows.Forms.TextBox();
            this.add_code_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.name_search_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.code_search_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdateDG = new System.Windows.Forms.Button();
            this.groupBox1_dataGroups.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2_DataGroups.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_dataGroups
            // 
            this.groupBox1_dataGroups.Controls.Add(this.buttonCancelDG);
            this.groupBox1_dataGroups.Controls.Add(this.buttonDelete_dataGroups);
            this.groupBox1_dataGroups.Controls.Add(this.buttonModify_dataGroups);
            this.groupBox1_dataGroups.Controls.Add(this.buttonInsert_dataGroups);
            this.groupBox1_dataGroups.Controls.Add(this.buttonNewDG);
            this.groupBox1_dataGroups.Controls.Add(this.groupBox4);
            this.groupBox1_dataGroups.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1_dataGroups.Location = new System.Drawing.Point(0, 0);
            this.groupBox1_dataGroups.Name = "groupBox1_dataGroups";
            this.groupBox1_dataGroups.Size = new System.Drawing.Size(131, 783);
            this.groupBox1_dataGroups.TabIndex = 2;
            this.groupBox1_dataGroups.TabStop = false;
            this.groupBox1_dataGroups.Text = "وحدة التحكم";
            // 
            // buttonCancelDG
            // 
            this.buttonCancelDG.Location = new System.Drawing.Point(3, 313);
            this.buttonCancelDG.Name = "buttonCancelDG";
            this.buttonCancelDG.Size = new System.Drawing.Size(121, 61);
            this.buttonCancelDG.TabIndex = 11;
            this.buttonCancelDG.Text = "إلغاء";
            this.buttonCancelDG.UseVisualStyleBackColor = true;
            this.buttonCancelDG.Click += new System.EventHandler(this.buttonCancelDG_Click);
            // 
            // buttonDelete_dataGroups
            // 
            this.buttonDelete_dataGroups.Location = new System.Drawing.Point(3, 245);
            this.buttonDelete_dataGroups.Name = "buttonDelete_dataGroups";
            this.buttonDelete_dataGroups.Size = new System.Drawing.Size(121, 61);
            this.buttonDelete_dataGroups.TabIndex = 10;
            this.buttonDelete_dataGroups.Text = "حذف";
            this.buttonDelete_dataGroups.UseVisualStyleBackColor = true;
            this.buttonDelete_dataGroups.Click += new System.EventHandler(this.buttonDeleteDG_Click);
            // 
            // buttonModify_dataGroups
            // 
            this.buttonModify_dataGroups.Location = new System.Drawing.Point(3, 179);
            this.buttonModify_dataGroups.Name = "buttonModify_dataGroups";
            this.buttonModify_dataGroups.Size = new System.Drawing.Size(121, 59);
            this.buttonModify_dataGroups.TabIndex = 9;
            this.buttonModify_dataGroups.Text = "تعديل";
            this.buttonModify_dataGroups.UseVisualStyleBackColor = true;
            this.buttonModify_dataGroups.Click += new System.EventHandler(this.buttonEditDG_Click);
            // 
            // buttonInsert_dataGroups
            // 
            this.buttonInsert_dataGroups.Location = new System.Drawing.Point(3, 113);
            this.buttonInsert_dataGroups.Name = "buttonInsert_dataGroups";
            this.buttonInsert_dataGroups.Size = new System.Drawing.Size(121, 60);
            this.buttonInsert_dataGroups.TabIndex = 8;
            this.buttonInsert_dataGroups.Text = "إضافة";
            this.buttonInsert_dataGroups.UseVisualStyleBackColor = true;
            this.buttonInsert_dataGroups.Click += new System.EventHandler(this.buttonInsertDG_Click);
            // 
            // buttonNewDG
            // 
            this.buttonNewDG.Location = new System.Drawing.Point(3, 20);
            this.buttonNewDG.Name = "buttonNewDG";
            this.buttonNewDG.Size = new System.Drawing.Size(122, 87);
            this.buttonNewDG.TabIndex = 7;
            this.buttonNewDG.Text = "جــديد";
            this.buttonNewDG.UseVisualStyleBackColor = true;
            this.buttonNewDG.Click += new System.EventHandler(this.buttonNewDG_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUpdateDG);
            this.groupBox4.Controls.Add(this.buttonCancelSearchDG);
            this.groupBox4.Controls.Add(this.buttonSearchDG);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 400);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "البحــث";
            // 
            // buttonCancelSearchDG
            // 
            this.buttonCancelSearchDG.Location = new System.Drawing.Point(4, 95);
            this.buttonCancelSearchDG.Name = "buttonCancelSearchDG";
            this.buttonCancelSearchDG.Size = new System.Drawing.Size(115, 67);
            this.buttonCancelSearchDG.TabIndex = 9;
            this.buttonCancelSearchDG.Text = "إلغاء البحث";
            this.buttonCancelSearchDG.UseVisualStyleBackColor = true;
            this.buttonCancelSearchDG.Click += new System.EventHandler(this.buttonCancelSearchDG_Click);
            // 
            // buttonSearchDG
            // 
            this.buttonSearchDG.Location = new System.Drawing.Point(4, 19);
            this.buttonSearchDG.Name = "buttonSearchDG";
            this.buttonSearchDG.Size = new System.Drawing.Size(115, 69);
            this.buttonSearchDG.TabIndex = 8;
            this.buttonSearchDG.Text = "البحث";
            this.buttonSearchDG.UseVisualStyleBackColor = true;
            this.buttonSearchDG.Click += new System.EventHandler(this.buttonSearchDG_Click);
            // 
            // groupBox2_DataGroups
            // 
            this.groupBox2_DataGroups.Controls.Add(this.groupBox5);
            this.groupBox2_DataGroups.Controls.Add(this.dataGridView1);
            this.groupBox2_DataGroups.Controls.Add(this.groupBox3);
            this.groupBox2_DataGroups.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2_DataGroups.Location = new System.Drawing.Point(134, 0);
            this.groupBox2_DataGroups.Name = "groupBox2_DataGroups";
            this.groupBox2_DataGroups.Size = new System.Drawing.Size(490, 783);
            this.groupBox2_DataGroups.TabIndex = 0;
            this.groupBox2_DataGroups.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.add_name_tb);
            this.groupBox5.Controls.Add(this.add_code_tb);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 77);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "إضافة بيانات";
            // 
            // add_name_tb
            // 
            this.add_name_tb.Enabled = false;
            this.add_name_tb.Location = new System.Drawing.Point(6, 44);
            this.add_name_tb.Name = "add_name_tb";
            this.add_name_tb.Size = new System.Drawing.Size(394, 20);
            this.add_name_tb.TabIndex = 4;
            // 
            // add_code_tb
            // 
            this.add_code_tb.Enabled = false;
            this.add_code_tb.Location = new System.Drawing.Point(274, 18);
            this.add_code_tb.Name = "add_code_tb";
            this.add_code_tb.Size = new System.Drawing.Size(126, 20);
            this.add_code_tb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "إسم الصنف:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "كود التصنيف:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(484, 604);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.name_search_tb);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.code_search_tb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 74);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "البحث";
            // 
            // name_search_tb
            // 
            this.name_search_tb.Enabled = false;
            this.name_search_tb.Location = new System.Drawing.Point(6, 40);
            this.name_search_tb.Name = "name_search_tb";
            this.name_search_tb.Size = new System.Drawing.Size(391, 20);
            this.name_search_tb.TabIndex = 3;
            this.name_search_tb.TextChanged += new System.EventHandler(this.name_search_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "بحث بالاسم:";
            // 
            // code_search_tb
            // 
            this.code_search_tb.Enabled = false;
            this.code_search_tb.Location = new System.Drawing.Point(271, 14);
            this.code_search_tb.Name = "code_search_tb";
            this.code_search_tb.Size = new System.Drawing.Size(126, 20);
            this.code_search_tb.TabIndex = 1;
            this.code_search_tb.TextChanged += new System.EventHandler(this.code_search_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث بالكود :";
            // 
            // buttonUpdateDG
            // 
            this.buttonUpdateDG.Location = new System.Drawing.Point(4, 332);
            this.buttonUpdateDG.Name = "buttonUpdateDG";
            this.buttonUpdateDG.Size = new System.Drawing.Size(115, 62);
            this.buttonUpdateDG.TabIndex = 10;
            this.buttonUpdateDG.Text = "تحديث قاعدة البيانات";
            this.buttonUpdateDG.UseVisualStyleBackColor = true;
            this.buttonUpdateDG.Click += new System.EventHandler(this.buttonUpdateDG_Click);
            // 
            // DataGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 783);
            this.Controls.Add(this.groupBox2_DataGroups);
            this.Controls.Add(this.groupBox1_dataGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataGroups";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "DataGroups";
            this.Load += new System.EventHandler(this.DataGroups_Load);
            this.groupBox1_dataGroups.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2_DataGroups.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_dataGroups;
        private System.Windows.Forms.GroupBox groupBox2_DataGroups;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox name_search_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox code_search_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox add_name_tb;
        private System.Windows.Forms.TextBox add_code_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonNewDG;
        private System.Windows.Forms.Button buttonCancelDG;
        private System.Windows.Forms.Button buttonDelete_dataGroups;
        private System.Windows.Forms.Button buttonModify_dataGroups;
        private System.Windows.Forms.Button buttonInsert_dataGroups;
        private System.Windows.Forms.Button buttonCancelSearchDG;
        private System.Windows.Forms.Button buttonSearchDG;
        private System.Windows.Forms.Button buttonUpdateDG;
    }
}
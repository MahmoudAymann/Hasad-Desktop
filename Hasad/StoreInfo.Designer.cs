namespace Hasad
{
    partial class StoreInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate_storeInfo = new System.Windows.Forms.Button();
            this.button_modify_storeInfo = new System.Windows.Forms.Button();
            this.button_deleteStore = new System.Windows.Forms.Button();
            this.cancel_button_storeInfo = new System.Windows.Forms.Button();
            this.buttonInsert_storeInfo = new System.Windows.Forms.Button();
            this.new_button_storeInfo = new System.Windows.Forms.Button();
            this.textBox_store_address = new System.Windows.Forms.TextBox();
            this.textBox_storeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.code_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hasadDataSet = new Hasad.HasadDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(314, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(375, 380);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate_storeInfo);
            this.groupBox1.Controls.Add(this.button_modify_storeInfo);
            this.groupBox1.Controls.Add(this.button_deleteStore);
            this.groupBox1.Controls.Add(this.cancel_button_storeInfo);
            this.groupBox1.Controls.Add(this.buttonInsert_storeInfo);
            this.groupBox1.Controls.Add(this.new_button_storeInfo);
            this.groupBox1.Controls.Add(this.textBox_store_address);
            this.groupBox1.Controls.Add(this.textBox_storeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.code_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(310, 380);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonUpdate_storeInfo
            // 
            this.buttonUpdate_storeInfo.Location = new System.Drawing.Point(7, 328);
            this.buttonUpdate_storeInfo.Name = "buttonUpdate_storeInfo";
            this.buttonUpdate_storeInfo.Size = new System.Drawing.Size(297, 46);
            this.buttonUpdate_storeInfo.TabIndex = 32;
            this.buttonUpdate_storeInfo.Text = "تحديث";
            this.buttonUpdate_storeInfo.UseVisualStyleBackColor = true;
            this.buttonUpdate_storeInfo.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button_modify_storeInfo
            // 
            this.button_modify_storeInfo.Location = new System.Drawing.Point(7, 275);
            this.button_modify_storeInfo.Name = "button_modify_storeInfo";
            this.button_modify_storeInfo.Size = new System.Drawing.Size(197, 46);
            this.button_modify_storeInfo.TabIndex = 31;
            this.button_modify_storeInfo.Text = "تعديل";
            this.button_modify_storeInfo.UseVisualStyleBackColor = true;
            this.button_modify_storeInfo.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button_deleteStore
            // 
            this.button_deleteStore.Location = new System.Drawing.Point(7, 222);
            this.button_deleteStore.Name = "button_deleteStore";
            this.button_deleteStore.Size = new System.Drawing.Size(197, 46);
            this.button_deleteStore.TabIndex = 30;
            this.button_deleteStore.Text = "حــذف";
            this.button_deleteStore.UseVisualStyleBackColor = true;
            this.button_deleteStore.Click += new System.EventHandler(this.button_deleteStore_Click);
            // 
            // cancel_button_storeInfo
            // 
            this.cancel_button_storeInfo.Location = new System.Drawing.Point(7, 169);
            this.cancel_button_storeInfo.Name = "cancel_button_storeInfo";
            this.cancel_button_storeInfo.Size = new System.Drawing.Size(197, 46);
            this.cancel_button_storeInfo.TabIndex = 29;
            this.cancel_button_storeInfo.Text = "الغاء";
            this.cancel_button_storeInfo.UseVisualStyleBackColor = true;
            this.cancel_button_storeInfo.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonInsert_storeInfo
            // 
            this.buttonInsert_storeInfo.Location = new System.Drawing.Point(211, 169);
            this.buttonInsert_storeInfo.Name = "buttonInsert_storeInfo";
            this.buttonInsert_storeInfo.Size = new System.Drawing.Size(93, 152);
            this.buttonInsert_storeInfo.TabIndex = 28;
            this.buttonInsert_storeInfo.Text = "إضافـة";
            this.buttonInsert_storeInfo.UseVisualStyleBackColor = true;
            this.buttonInsert_storeInfo.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // new_button_storeInfo
            // 
            this.new_button_storeInfo.Location = new System.Drawing.Point(7, 113);
            this.new_button_storeInfo.Name = "new_button_storeInfo";
            this.new_button_storeInfo.Size = new System.Drawing.Size(297, 49);
            this.new_button_storeInfo.TabIndex = 27;
            this.new_button_storeInfo.Text = "جديد";
            this.new_button_storeInfo.UseVisualStyleBackColor = true;
            this.new_button_storeInfo.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textBox_store_address
            // 
            this.textBox_store_address.Enabled = false;
            this.textBox_store_address.Location = new System.Drawing.Point(18, 73);
            this.textBox_store_address.Name = "textBox_store_address";
            this.textBox_store_address.Size = new System.Drawing.Size(232, 20);
            this.textBox_store_address.TabIndex = 20;
            // 
            // textBox_storeName
            // 
            this.textBox_storeName.Enabled = false;
            this.textBox_storeName.Location = new System.Drawing.Point(18, 44);
            this.textBox_storeName.Name = "textBox_storeName";
            this.textBox_storeName.Size = new System.Drawing.Size(206, 20);
            this.textBox_storeName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 76);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "العــنوان:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 47);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "اسم المخــزن:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // code_tb
            // 
            this.code_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.code_tb.Enabled = false;
            this.code_tb.Location = new System.Drawing.Point(160, 13);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(106, 20);
            this.code_tb.TabIndex = 16;
            this.code_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "كــود:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hasadDataSetBindingSource
            // 
            this.hasadDataSetBindingSource.DataSource = this.hasadDataSet;
            this.hasadDataSetBindingSource.Position = 0;
            // 
            // hasadDataSet
            // 
            this.hasadDataSet.DataSetName = "HasadDataSet";
            this.hasadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StoreInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات المخزن";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasadDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hasadDataSetBindingSource;
        private HasadDataSet hasadDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_store_address;
        private System.Windows.Forms.TextBox textBox_storeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_button_storeInfo;
        private System.Windows.Forms.Button buttonUpdate_storeInfo;
        private System.Windows.Forms.Button button_modify_storeInfo;
        private System.Windows.Forms.Button button_deleteStore;
        private System.Windows.Forms.Button cancel_button_storeInfo;
        private System.Windows.Forms.Button buttonInsert_storeInfo;
    }
}
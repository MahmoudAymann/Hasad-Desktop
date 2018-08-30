namespace Hasad
{
    partial class CompanyInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_companyName = new System.Windows.Forms.TextBox();
            this.buttonInsert_companyInfo = new System.Windows.Forms.Button();
            this.buttonDelete_companyInfo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_company_code = new System.Windows.Forms.TextBox();
            this.buttonNew_CompanyInfo = new System.Windows.Forms.Button();
            this.buttonUpdate_companyInfo = new System.Windows.Forms.Button();
            this.buttonModify_companyInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيان الشركة:";
            // 
            // textBox_companyName
            // 
            this.textBox_companyName.Enabled = false;
            this.textBox_companyName.Location = new System.Drawing.Point(118, 14);
            this.textBox_companyName.MaximumSize = new System.Drawing.Size(250, 40);
            this.textBox_companyName.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBox_companyName.Name = "textBox_companyName";
            this.textBox_companyName.Size = new System.Drawing.Size(250, 20);
            this.textBox_companyName.TabIndex = 1;
            // 
            // buttonInsert_companyInfo
            // 
            this.buttonInsert_companyInfo.Enabled = false;
            this.buttonInsert_companyInfo.Location = new System.Drawing.Point(101, 85);
            this.buttonInsert_companyInfo.Name = "buttonInsert_companyInfo";
            this.buttonInsert_companyInfo.Size = new System.Drawing.Size(84, 34);
            this.buttonInsert_companyInfo.TabIndex = 2;
            this.buttonInsert_companyInfo.Text = "إضافة";
            this.buttonInsert_companyInfo.UseVisualStyleBackColor = true;
            this.buttonInsert_companyInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete_companyInfo
            // 
            this.buttonDelete_companyInfo.Enabled = false;
            this.buttonDelete_companyInfo.Location = new System.Drawing.Point(191, 85);
            this.buttonDelete_companyInfo.Name = "buttonDelete_companyInfo";
            this.buttonDelete_companyInfo.Size = new System.Drawing.Size(88, 34);
            this.buttonDelete_companyInfo.TabIndex = 3;
            this.buttonDelete_companyInfo.Text = "حذف";
            this.buttonDelete_companyInfo.UseVisualStyleBackColor = true;
            this.buttonDelete_companyInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.Size = new System.Drawing.Size(396, 392);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "الكود:";
            // 
            // textBox_company_code
            // 
            this.textBox_company_code.Enabled = false;
            this.textBox_company_code.Location = new System.Drawing.Point(62, 50);
            this.textBox_company_code.Name = "textBox_company_code";
            this.textBox_company_code.Size = new System.Drawing.Size(100, 20);
            this.textBox_company_code.TabIndex = 7;
            // 
            // buttonNew_CompanyInfo
            // 
            this.buttonNew_CompanyInfo.Location = new System.Drawing.Point(11, 85);
            this.buttonNew_CompanyInfo.Name = "buttonNew_CompanyInfo";
            this.buttonNew_CompanyInfo.Size = new System.Drawing.Size(84, 34);
            this.buttonNew_CompanyInfo.TabIndex = 8;
            this.buttonNew_CompanyInfo.Text = "جديد";
            this.buttonNew_CompanyInfo.UseVisualStyleBackColor = true;
            this.buttonNew_CompanyInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonUpdate_companyInfo
            // 
            this.buttonUpdate_companyInfo.Location = new System.Drawing.Point(285, 50);
            this.buttonUpdate_companyInfo.Name = "buttonUpdate_companyInfo";
            this.buttonUpdate_companyInfo.Size = new System.Drawing.Size(111, 29);
            this.buttonUpdate_companyInfo.TabIndex = 9;
            this.buttonUpdate_companyInfo.Text = "عرض البيانات";
            this.buttonUpdate_companyInfo.UseVisualStyleBackColor = true;
            this.buttonUpdate_companyInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonModify_companyInfo
            // 
            this.buttonModify_companyInfo.Enabled = false;
            this.buttonModify_companyInfo.Location = new System.Drawing.Point(285, 85);
            this.buttonModify_companyInfo.Name = "buttonModify_companyInfo";
            this.buttonModify_companyInfo.Size = new System.Drawing.Size(88, 34);
            this.buttonModify_companyInfo.TabIndex = 10;
            this.buttonModify_companyInfo.Text = "تعديل";
            this.buttonModify_companyInfo.UseVisualStyleBackColor = true;
            this.buttonModify_companyInfo.Click += new System.EventHandler(this.button5_Click);
            // 
            // CompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(396, 517);
            this.Controls.Add(this.buttonModify_companyInfo);
            this.Controls.Add(this.buttonUpdate_companyInfo);
            this.Controls.Add(this.buttonNew_CompanyInfo);
            this.Controls.Add(this.textBox_company_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonDelete_companyInfo);
            this.Controls.Add(this.buttonInsert_companyInfo);
            this.Controls.Add(this.textBox_companyName);
            this.Controls.Add(this.label1);
            this.Name = "CompanyInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_companyName;
        private System.Windows.Forms.Button buttonInsert_companyInfo;
        private System.Windows.Forms.Button buttonDelete_companyInfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_company_code;
        private System.Windows.Forms.Button buttonNew_CompanyInfo;
        private System.Windows.Forms.Button buttonUpdate_companyInfo;
        private System.Windows.Forms.Button buttonModify_companyInfo;
    }
}
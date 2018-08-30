namespace Hasad
{
    partial class ItemsInfo
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
            this.groupBoxII = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNewII = new System.Windows.Forms.Button();
            this.buttonDeleteII = new System.Windows.Forms.Button();
            this.buttonEditII = new System.Windows.Forms.Button();
            this.buttonInsertII = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUpdateII = new System.Windows.Forms.Button();
            this.groupBoxII.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxII
            // 
            this.groupBoxII.Controls.Add(this.buttonUpdateII);
            this.groupBoxII.Controls.Add(this.button2);
            this.groupBoxII.Controls.Add(this.button1);
            this.groupBoxII.Controls.Add(this.buttonInsertII);
            this.groupBoxII.Controls.Add(this.buttonEditII);
            this.groupBoxII.Controls.Add(this.buttonDeleteII);
            this.groupBoxII.Controls.Add(this.buttonNewII);
            this.groupBoxII.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxII.Location = new System.Drawing.Point(0, 0);
            this.groupBoxII.Name = "groupBoxII";
            this.groupBoxII.Size = new System.Drawing.Size(147, 601);
            this.groupBoxII.TabIndex = 0;
            this.groupBoxII.TabStop = false;
            this.groupBoxII.Text = "وحدة التحكم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(153, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 601);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 92);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "محرك البحث";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "بحــث عن:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث بواسطة:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(655, 488);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonNewII
            // 
            this.buttonNewII.Location = new System.Drawing.Point(7, 20);
            this.buttonNewII.Name = "buttonNewII";
            this.buttonNewII.Size = new System.Drawing.Size(128, 64);
            this.buttonNewII.TabIndex = 0;
            this.buttonNewII.Text = "جديد";
            this.buttonNewII.UseVisualStyleBackColor = true;
            this.buttonNewII.Click += new System.EventHandler(this.buttonNewII_Click);
            // 
            // buttonDeleteII
            // 
            this.buttonDeleteII.Location = new System.Drawing.Point(6, 146);
            this.buttonDeleteII.Name = "buttonDeleteII";
            this.buttonDeleteII.Size = new System.Drawing.Size(128, 50);
            this.buttonDeleteII.TabIndex = 1;
            this.buttonDeleteII.Text = "حذف";
            this.buttonDeleteII.UseVisualStyleBackColor = true;
            // 
            // buttonEditII
            // 
            this.buttonEditII.Location = new System.Drawing.Point(6, 202);
            this.buttonEditII.Name = "buttonEditII";
            this.buttonEditII.Size = new System.Drawing.Size(128, 50);
            this.buttonEditII.TabIndex = 2;
            this.buttonEditII.Text = "تعديل";
            this.buttonEditII.UseVisualStyleBackColor = true;
            // 
            // buttonInsertII
            // 
            this.buttonInsertII.Location = new System.Drawing.Point(6, 90);
            this.buttonInsertII.Name = "buttonInsertII";
            this.buttonInsertII.Size = new System.Drawing.Size(128, 50);
            this.buttonInsertII.TabIndex = 3;
            this.buttonInsertII.Text = "إضافة";
            this.buttonInsertII.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "إلغاء البحث";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateII
            // 
            this.buttonUpdateII.Location = new System.Drawing.Point(7, 547);
            this.buttonUpdateII.Name = "buttonUpdateII";
            this.buttonUpdateII.Size = new System.Drawing.Size(127, 42);
            this.buttonUpdateII.TabIndex = 6;
            this.buttonUpdateII.Text = "تحديث قاعدة البيانات";
            this.buttonUpdateII.UseVisualStyleBackColor = true;
            // 
            // ItemsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxII);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ItemsInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الاصناف";
            this.groupBoxII.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxII;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdateII;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInsertII;
        private System.Windows.Forms.Button buttonEditII;
        private System.Windows.Forms.Button buttonDeleteII;
        private System.Windows.Forms.Button buttonNewII;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
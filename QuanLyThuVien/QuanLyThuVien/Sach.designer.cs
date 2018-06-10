namespace Library1
{
    partial class Sach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sach));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaKS = new System.Windows.Forms.ComboBox();
            this.cbMaDS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMa,
            this.clMDS,
            this.clMKS});
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 241);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.Width = 50;
            // 
            // clMa
            // 
            this.clMa.DataPropertyName = "MaSach";
            this.clMa.HeaderText = "MaSach";
            this.clMa.Name = "clMa";
            this.clMa.Width = 200;
            // 
            // clMDS
            // 
            this.clMDS.DataPropertyName = "MaDS";
            this.clMDS.HeaderText = "MaDS";
            this.clMDS.Name = "clMDS";
            this.clMDS.Width = 200;
            // 
            // clMKS
            // 
            this.clMKS.DataPropertyName = "MaKS";
            this.clMKS.HeaderText = "MaKS";
            this.clMKS.Name = "clMKS";
            this.clMKS.Width = 200;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = ((System.Drawing.Image)(resources.GetObject("buttonXoa.Image")));
            this.buttonXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoa.Location = new System.Drawing.Point(434, 137);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(84, 32);
            this.buttonXoa.TabIndex = 22;
            this.buttonXoa.Text = "    Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(241, 137);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 32);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "    Sửa";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Enabled = false;
            this.buttonADD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Image = ((System.Drawing.Image)(resources.GetObject("buttonADD.Image")));
            this.buttonADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADD.Location = new System.Drawing.Point(619, 137);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(84, 32);
            this.buttonADD.TabIndex = 20;
            this.buttonADD.Text = "    Lưu";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = ((System.Drawing.Image)(resources.GetObject("buttonThem.Image")));
            this.buttonThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThem.Location = new System.Drawing.Point(41, 137);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(84, 32);
            this.buttonThem.TabIndex = 19;
            this.buttonThem.Text = "    Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaKS);
            this.groupBox1.Controls.Add(this.cbMaDS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 119);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbMaKS
            // 
            this.cbMaKS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKS.FormattingEnabled = true;
            this.cbMaKS.Items.AddRange(new object[] {
            "KS1101",
            "KS1102",
            "KS1103",
            "KS1104",
            "KS1105",
            "KS1106",
            "KS1107",
            "KS1108",
            "KS1109",
            "KS1110"});
            this.cbMaKS.Location = new System.Drawing.Point(502, 37);
            this.cbMaKS.Name = "cbMaKS";
            this.cbMaKS.Size = new System.Drawing.Size(171, 27);
            this.cbMaKS.TabIndex = 34;
            this.cbMaKS.Text = "KS1101";
            // 
            // cbMaDS
            // 
            this.cbMaDS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaDS.FormattingEnabled = true;
            this.cbMaDS.Items.AddRange(new object[] {
            "DS1101",
            "DS1102",
            "DS1103",
            "DS1104",
            "DS1105",
            "DS1106",
            "DS1107",
            "DS1108",
            "DS1109",
            "DS1110"});
            this.cbMaDS.Location = new System.Drawing.Point(133, 72);
            this.cbMaDS.Name = "cbMaDS";
            this.cbMaDS.Size = new System.Drawing.Size(171, 27);
            this.cbMaDS.TabIndex = 33;
            this.cbMaDS.Text = "DS1101";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Mã Kệ Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Đầu Sách";
            // 
            // MaSach
            // 
            this.MaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaSach.Location = new System.Drawing.Point(133, 37);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(171, 26);
            this.MaSach.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Sách";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sach";
            this.ShowIcon = false;
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Sach_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaKS;
        private System.Windows.Forms.ComboBox cbMaDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMKS;
    }
}


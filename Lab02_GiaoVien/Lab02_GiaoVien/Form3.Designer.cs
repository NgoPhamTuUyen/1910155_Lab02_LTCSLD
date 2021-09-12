namespace Lab02_GiaoVien
{
    partial class frmThongTinGiaoVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSoDT);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Location = new System.Drawing.Point(49, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(400, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Location = new System.Drawing.Point(273, 32);
            this.rdSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(112, 21);
            this.rdSoDT.TabIndex = 2;
            this.rdSoDT.Text = "Số điện thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            this.rdSoDT.CheckedChanged += new System.EventHandler(this.rdSoDT_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(145, 32);
            this.rdHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(76, 21);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Location = new System.Drawing.Point(9, 32);
            this.rdMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(72, 21);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdMaGV_CheckedChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(49, 146);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(51, 17);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Mã GV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 143);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Teal;
            this.btnOK.Location = new System.Drawing.Point(362, 132);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 44);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnSearchOK_Click);
            // 
            // frmThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(492, 197);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinGiaoVien";
            this.Text = "Tìm thông tin Giáo viên";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOK;
    }
}
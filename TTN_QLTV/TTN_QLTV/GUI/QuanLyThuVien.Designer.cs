﻿namespace TTN_QLTV
{
    partial class Form1
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
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.dataGridViewDauSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTacGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNhaXuatBan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonQuanLySach = new System.Windows.Forms.Button();
            this.buttonQuanLyPhieuMuon = new System.Windows.Forms.Button();
            this.buttonQuanLyDocGia = new System.Windows.Forms.Button();
            this.textBoxThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxLoaiThongTin = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxKeSach = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDauSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaXuatBan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(625, 112);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(160, 51);
            this.buttonTimKiem.TabIndex = 0;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // dataGridViewDauSach
            // 
            this.dataGridViewDauSach.AllowUserToAddRows = false;
            this.dataGridViewDauSach.AllowUserToDeleteRows = false;
            this.dataGridViewDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDauSach.Location = new System.Drawing.Point(4, 21);
            this.dataGridViewDauSach.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDauSach.Name = "dataGridViewDauSach";
            this.dataGridViewDauSach.RowHeadersVisible = false;
            this.dataGridViewDauSach.RowHeadersWidth = 51;
            this.dataGridViewDauSach.RowTemplate.Height = 24;
            this.dataGridViewDauSach.Size = new System.Drawing.Size(388, 243);
            this.dataGridViewDauSach.TabIndex = 3;
            this.dataGridViewDauSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDauSach_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDauSach);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 183);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(402, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đầu Sách";
            // 
            // dataGridViewTacGia
            // 
            this.dataGridViewTacGia.AllowUserToAddRows = false;
            this.dataGridViewTacGia.AllowUserToDeleteRows = false;
            this.dataGridViewTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTacGia.Location = new System.Drawing.Point(4, 21);
            this.dataGridViewTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTacGia.Name = "dataGridViewTacGia";
            this.dataGridViewTacGia.RowHeadersVisible = false;
            this.dataGridViewTacGia.RowHeadersWidth = 51;
            this.dataGridViewTacGia.RowTemplate.Height = 24;
            this.dataGridViewTacGia.Size = new System.Drawing.Size(160, 243);
            this.dataGridViewTacGia.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewTacGia);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(446, 183);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(170, 276);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Giả";
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.AllowUserToAddRows = false;
            this.dataGridViewTheLoai.AllowUserToDeleteRows = false;
            this.dataGridViewTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(4, 21);
            this.dataGridViewTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.RowHeadersVisible = false;
            this.dataGridViewTheLoai.RowHeadersWidth = 51;
            this.dataGridViewTheLoai.RowTemplate.Height = 24;
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(160, 243);
            this.dataGridViewTheLoai.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewTheLoai);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(620, 183);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(170, 276);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thể Loại";
            // 
            // dataGridViewNhaXuatBan
            // 
            this.dataGridViewNhaXuatBan.AllowUserToAddRows = false;
            this.dataGridViewNhaXuatBan.AllowUserToDeleteRows = false;
            this.dataGridViewNhaXuatBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhaXuatBan.Location = new System.Drawing.Point(4, 21);
            this.dataGridViewNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNhaXuatBan.Name = "dataGridViewNhaXuatBan";
            this.dataGridViewNhaXuatBan.RowHeadersVisible = false;
            this.dataGridViewNhaXuatBan.RowHeadersWidth = 51;
            this.dataGridViewNhaXuatBan.RowTemplate.Height = 24;
            this.dataGridViewNhaXuatBan.Size = new System.Drawing.Size(160, 243);
            this.dataGridViewNhaXuatBan.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewNhaXuatBan);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(795, 183);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(171, 276);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhà Xuất Bản";
            // 
            // buttonQuanLySach
            // 
            this.buttonQuanLySach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLySach.Location = new System.Drawing.Point(450, 464);
            this.buttonQuanLySach.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuanLySach.Name = "buttonQuanLySach";
            this.buttonQuanLySach.Size = new System.Drawing.Size(160, 49);
            this.buttonQuanLySach.TabIndex = 9;
            this.buttonQuanLySach.Text = "Quản Lý Sách";
            this.buttonQuanLySach.UseVisualStyleBackColor = true;
            // 
            // buttonQuanLyPhieuMuon
            // 
            this.buttonQuanLyPhieuMuon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyPhieuMuon.Location = new System.Drawing.Point(800, 464);
            this.buttonQuanLyPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuanLyPhieuMuon.Name = "buttonQuanLyPhieuMuon";
            this.buttonQuanLyPhieuMuon.Size = new System.Drawing.Size(160, 49);
            this.buttonQuanLyPhieuMuon.TabIndex = 10;
            this.buttonQuanLyPhieuMuon.Text = "Quản Lý Phiếu Mượn";
            this.buttonQuanLyPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // buttonQuanLyDocGia
            // 
            this.buttonQuanLyDocGia.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyDocGia.Location = new System.Drawing.Point(625, 464);
            this.buttonQuanLyDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuanLyDocGia.Name = "buttonQuanLyDocGia";
            this.buttonQuanLyDocGia.Size = new System.Drawing.Size(160, 49);
            this.buttonQuanLyDocGia.TabIndex = 11;
            this.buttonQuanLyDocGia.Text = "Quản Lý Độc Giả";
            this.buttonQuanLyDocGia.UseVisualStyleBackColor = true;
            // 
            // textBoxThongTinTimKiem
            // 
            this.textBoxThongTinTimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThongTinTimKiem.Location = new System.Drawing.Point(4, 17);
            this.textBoxThongTinTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxThongTinTimKiem.Name = "textBoxThongTinTimKiem";
            this.textBoxThongTinTimKiem.Size = new System.Drawing.Size(389, 23);
            this.textBoxThongTinTimKiem.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxThongTinTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(39, 112);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(402, 51);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin Tìm Kiếm";
            // 
            // comboBoxLoaiThongTin
            // 
            this.comboBoxLoaiThongTin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiThongTin.FormattingEnabled = true;
            this.comboBoxLoaiThongTin.Items.AddRange(new object[] {
            "Tên Tác Giả",
            "Tên Đầu Sách",
            "Thể Loại",
            "Tên Nhà Xuất Bản",
            "Kệ Sách"});
            this.comboBoxLoaiThongTin.Location = new System.Drawing.Point(4, 17);
            this.comboBoxLoaiThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiThongTin.Name = "comboBoxLoaiThongTin";
            this.comboBoxLoaiThongTin.Size = new System.Drawing.Size(161, 24);
            this.comboBoxLoaiThongTin.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxLoaiThongTin);
            this.groupBox6.Location = new System.Drawing.Point(446, 112);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(170, 51);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Loại Thông Tin";
            // 
            // textBoxKeSach
            // 
            this.textBoxKeSach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeSach.Location = new System.Drawing.Point(10, 17);
            this.textBoxKeSach.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKeSach.Name = "textBoxKeSach";
            this.textBoxKeSach.Size = new System.Drawing.Size(389, 23);
            this.textBoxKeSach.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxKeSach);
            this.groupBox7.Location = new System.Drawing.Point(39, 464);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(402, 49);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Kệ Sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonQuanLyDocGia);
            this.Controls.Add(this.buttonQuanLyPhieuMuon);
            this.Controls.Add(this.buttonQuanLySach);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDauSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaXuatBan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewDauSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTacGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewNhaXuatBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonQuanLySach;
        private System.Windows.Forms.Button buttonQuanLyPhieuMuon;
        private System.Windows.Forms.Button buttonQuanLyDocGia;
        private System.Windows.Forms.TextBox textBoxThongTinTimKiem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxLoaiThongTin;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxKeSach;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
    }
}


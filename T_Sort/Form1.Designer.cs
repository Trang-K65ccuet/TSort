namespace T_Sort
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
            this.grLuaChonThuatToan = new System.Windows.Forms.GroupBox();
            this.rbChen = new System.Windows.Forms.RadioButton();
            this.rbNoiBot = new System.Windows.Forms.RadioButton();
            this.rbLuaChon = new System.Windows.Forms.RadioButton();
            this.grThuTu = new System.Windows.Forms.GroupBox();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.grDauVao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTangToc = new System.Windows.Forms.Button();
            this.btnGiamToc = new System.Windows.Forms.Button();
            this.tbTocDo = new System.Windows.Forms.TextBox();
            this.lbTocDo = new System.Windows.Forms.Label();
            this.tbNhapMang = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbNhapMang = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.rbThuCong = new System.Windows.Forms.RadioButton();
            this.rbTuDong = new System.Windows.Forms.RadioButton();
            this.grThucHien = new System.Windows.Forms.GroupBox();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.grChinh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grLuaChonThuatToan.SuspendLayout();
            this.grThuTu.SuspendLayout();
            this.grDauVao.SuspendLayout();
            this.grThucHien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grLuaChonThuatToan
            // 
            this.grLuaChonThuatToan.BackColor = System.Drawing.Color.Black;
            this.grLuaChonThuatToan.Controls.Add(this.rbChen);
            this.grLuaChonThuatToan.Controls.Add(this.rbNoiBot);
            this.grLuaChonThuatToan.Controls.Add(this.rbLuaChon);
            this.grLuaChonThuatToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grLuaChonThuatToan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grLuaChonThuatToan.Location = new System.Drawing.Point(5, 6);
            this.grLuaChonThuatToan.Name = "grLuaChonThuatToan";
            this.grLuaChonThuatToan.Size = new System.Drawing.Size(277, 139);
            this.grLuaChonThuatToan.TabIndex = 0;
            this.grLuaChonThuatToan.TabStop = false;
            this.grLuaChonThuatToan.Text = "Lựa chọn thuật toán";
            // 
            // rbChen
            // 
            this.rbChen.AutoSize = true;
            this.rbChen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChen.ForeColor = System.Drawing.SystemColors.Control;
            this.rbChen.Location = new System.Drawing.Point(8, 98);
            this.rbChen.Name = "rbChen";
            this.rbChen.Size = new System.Drawing.Size(146, 28);
            this.rbChen.TabIndex = 3;
            this.rbChen.TabStop = true;
            this.rbChen.Text = "Sắp xếp chèn";
            this.rbChen.UseVisualStyleBackColor = true;
            // 
            // rbNoiBot
            // 
            this.rbNoiBot.AutoSize = true;
            this.rbNoiBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoiBot.ForeColor = System.Drawing.SystemColors.Control;
            this.rbNoiBot.Location = new System.Drawing.Point(8, 66);
            this.rbNoiBot.Name = "rbNoiBot";
            this.rbNoiBot.Size = new System.Drawing.Size(160, 28);
            this.rbNoiBot.TabIndex = 2;
            this.rbNoiBot.TabStop = true;
            this.rbNoiBot.Text = "Sắp xếp nổi bọt";
            this.rbNoiBot.UseVisualStyleBackColor = true;
            // 
            // rbLuaChon
            // 
            this.rbLuaChon.AutoSize = true;
            this.rbLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLuaChon.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLuaChon.Location = new System.Drawing.Point(8, 33);
            this.rbLuaChon.Name = "rbLuaChon";
            this.rbLuaChon.Size = new System.Drawing.Size(176, 28);
            this.rbLuaChon.TabIndex = 1;
            this.rbLuaChon.TabStop = true;
            this.rbLuaChon.Text = "Sắp xếp lựa chọn";
            this.rbLuaChon.UseVisualStyleBackColor = true;
            // 
            // grThuTu
            // 
            this.grThuTu.BackColor = System.Drawing.Color.Black;
            this.grThuTu.Controls.Add(this.rbGiam);
            this.grThuTu.Controls.Add(this.rbTang);
            this.grThuTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThuTu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grThuTu.Location = new System.Drawing.Point(5, 151);
            this.grThuTu.Name = "grThuTu";
            this.grThuTu.Size = new System.Drawing.Size(277, 63);
            this.grThuTu.TabIndex = 1;
            this.grThuTu.TabStop = false;
            this.grThuTu.Text = "Thứ tự sắp xếp";
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGiam.Location = new System.Drawing.Point(164, 23);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(72, 28);
            this.rbGiam.TabIndex = 3;
            this.rbGiam.TabStop = true;
            this.rbGiam.Text = "Giảm";
            this.rbGiam.UseVisualStyleBackColor = true;
            this.rbGiam.CheckedChanged += new System.EventHandler(this.rbGiam_CheckedChanged);
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTang.Location = new System.Drawing.Point(24, 23);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(72, 28);
            this.rbTang.TabIndex = 2;
            this.rbTang.TabStop = true;
            this.rbTang.Text = "Tăng";
            this.rbTang.UseVisualStyleBackColor = true;
            this.rbTang.CheckedChanged += new System.EventHandler(this.rbTang_CheckedChanged);
            // 
            // grDauVao
            // 
            this.grDauVao.BackColor = System.Drawing.Color.Black;
            this.grDauVao.Controls.Add(this.label2);
            this.grDauVao.Controls.Add(this.btnTangToc);
            this.grDauVao.Controls.Add(this.btnGiamToc);
            this.grDauVao.Controls.Add(this.tbTocDo);
            this.grDauVao.Controls.Add(this.lbTocDo);
            this.grDauVao.Controls.Add(this.tbNhapMang);
            this.grDauVao.Controls.Add(this.tbSoLuong);
            this.grDauVao.Controls.Add(this.btnThem);
            this.grDauVao.Controls.Add(this.lbNhapMang);
            this.grDauVao.Controls.Add(this.lbSoLuong);
            this.grDauVao.Controls.Add(this.rbThuCong);
            this.grDauVao.Controls.Add(this.rbTuDong);
            this.grDauVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDauVao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grDauVao.Location = new System.Drawing.Point(288, 6);
            this.grDauVao.Name = "grDauVao";
            this.grDauVao.Size = new System.Drawing.Size(838, 126);
            this.grDauVao.TabIndex = 4;
            this.grDauVao.TabStop = false;
            this.grDauVao.Text = "Thiết lập đầu vào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Chọn hình thức nhập";
            // 
            // btnTangToc
            // 
            this.btnTangToc.BackColor = System.Drawing.Color.Gray;
            this.btnTangToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangToc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTangToc.Location = new System.Drawing.Point(445, 87);
            this.btnTangToc.Name = "btnTangToc";
            this.btnTangToc.Size = new System.Drawing.Size(97, 28);
            this.btnTangToc.TabIndex = 11;
            this.btnTangToc.Text = " Tăng ( + )";
            this.btnTangToc.UseVisualStyleBackColor = false;
            this.btnTangToc.Click += new System.EventHandler(this.btnTangToc_Click);
            // 
            // btnGiamToc
            // 
            this.btnGiamToc.BackColor = System.Drawing.Color.Gray;
            this.btnGiamToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamToc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGiamToc.Location = new System.Drawing.Point(263, 87);
            this.btnGiamToc.Name = "btnGiamToc";
            this.btnGiamToc.Size = new System.Drawing.Size(101, 28);
            this.btnGiamToc.TabIndex = 10;
            this.btnGiamToc.Text = " Giảm ( - )";
            this.btnGiamToc.UseVisualStyleBackColor = false;
            this.btnGiamToc.Click += new System.EventHandler(this.btnGiamToc_Click);
            // 
            // tbTocDo
            // 
            this.tbTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTocDo.Location = new System.Drawing.Point(385, 85);
            this.tbTocDo.Name = "tbTocDo";
            this.tbTocDo.Size = new System.Drawing.Size(42, 29);
            this.tbTocDo.TabIndex = 9;
            this.tbTocDo.TextChanged += new System.EventHandler(this.tbTocDo_TextChanged);
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTocDo.Location = new System.Drawing.Point(15, 91);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(157, 24);
            this.lbTocDo.TabIndex = 8;
            this.lbTocDo.Text = "Tốc độ sắp xếp";
            this.lbTocDo.Click += new System.EventHandler(this.lbTocDo_Click);
            // 
            // tbNhapMang
            // 
            this.tbNhapMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNhapMang.Location = new System.Drawing.Point(636, 51);
            this.tbNhapMang.Name = "tbNhapMang";
            this.tbNhapMang.Size = new System.Drawing.Size(42, 29);
            this.tbNhapMang.TabIndex = 7;
            this.tbNhapMang.TextChanged += new System.EventHandler(this.tbNhapMang_TextChanged);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(636, 16);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(42, 29);
            this.tbSoLuong.TabIndex = 6;
            this.tbSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(695, 21);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 53);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbNhapMang
            // 
            this.lbNhapMang.AutoSize = true;
            this.lbNhapMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapMang.Location = new System.Drawing.Point(406, 54);
            this.lbNhapMang.Name = "lbNhapMang";
            this.lbNhapMang.Size = new System.Drawing.Size(225, 24);
            this.lbNhapMang.TabIndex = 4;
            this.lbNhapMang.Text = "Nhập phần tử muốn thêm";
            this.lbNhapMang.Click += new System.EventHandler(this.lbNhapMang_Click);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(406, 21);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(202, 24);
            this.lbSoLuong.TabIndex = 3;
            this.lbSoLuong.Text = "Nhập số lượng phần tử";
            this.lbSoLuong.Click += new System.EventHandler(this.lbSoLuong_Click);
            // 
            // rbThuCong
            // 
            this.rbThuCong.AutoSize = true;
            this.rbThuCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThuCong.Location = new System.Drawing.Point(260, 53);
            this.rbThuCong.Name = "rbThuCong";
            this.rbThuCong.Size = new System.Drawing.Size(110, 28);
            this.rbThuCong.TabIndex = 2;
            this.rbThuCong.TabStop = true;
            this.rbThuCong.Text = "Thủ công";
            this.rbThuCong.UseVisualStyleBackColor = true;
            this.rbThuCong.CheckedChanged += new System.EventHandler(this.rbThuCong_CheckedChanged);
            // 
            // rbTuDong
            // 
            this.rbTuDong.AutoSize = true;
            this.rbTuDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTuDong.Location = new System.Drawing.Point(260, 20);
            this.rbTuDong.Name = "rbTuDong";
            this.rbTuDong.Size = new System.Drawing.Size(101, 28);
            this.rbTuDong.TabIndex = 1;
            this.rbTuDong.TabStop = true;
            this.rbTuDong.Text = "Tự động";
            this.rbTuDong.UseVisualStyleBackColor = true;
            this.rbTuDong.CheckedChanged += new System.EventHandler(this.rbTuDong_CheckedChanged);
            // 
            // grThucHien
            // 
            this.grThucHien.BackColor = System.Drawing.Color.Black;
            this.grThucHien.Controls.Add(this.btnDatLai);
            this.grThucHien.Controls.Add(this.btnTamDung);
            this.grThucHien.Controls.Add(this.btnBatDau);
            this.grThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThucHien.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.grThucHien.Location = new System.Drawing.Point(288, 138);
            this.grThucHien.Name = "grThucHien";
            this.grThucHien.Size = new System.Drawing.Size(838, 76);
            this.grThucHien.TabIndex = 4;
            this.grThucHien.TabStop = false;
            this.grThucHien.Text = "Thực hiện";
            this.grThucHien.Enter += new System.EventHandler(this.grThucHien_Enter);
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDatLai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDatLai.Location = new System.Drawing.Point(626, 28);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(131, 32);
            this.btnDatLai.TabIndex = 14;
            this.btnDatLai.Text = "ĐẶT LẠI";
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTamDung.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTamDung.Location = new System.Drawing.Point(80, 28);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(139, 32);
            this.btnTamDung.TabIndex = 13;
            this.btnTamDung.Text = "TẠM DỪNG";
            this.btnTamDung.UseVisualStyleBackColor = false;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBatDau.Location = new System.Drawing.Point(357, 28);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(129, 32);
            this.btnBatDau.TabIndex = 12;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.UseVisualStyleBackColor = false;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // grChinh
            // 
            this.grChinh.BackColor = System.Drawing.Color.Black;
            this.grChinh.Location = new System.Drawing.Point(5, 220);
            this.grChinh.Name = "grChinh";
            this.grChinh.Size = new System.Drawing.Size(1121, 492);
            this.grChinh.TabIndex = 6;
            this.grChinh.TabStop = false;
            this.grChinh.Enter += new System.EventHandler(this.grChinh_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(230, 715);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực hiện bởi Nguyễn Hà Trang - 20020482 - Môn Cấu trúc dữ liệu và giải thuật INT" +
    "2210 3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1131, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grChinh);
            this.Controls.Add(this.grThucHien);
            this.Controls.Add(this.grDauVao);
            this.Controls.Add(this.grThuTu);
            this.Controls.Add(this.grLuaChonThuatToan);
            this.Name = "Form1";
            this.Text = "Mô phỏng thuật toán sắp xếp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grLuaChonThuatToan.ResumeLayout(false);
            this.grLuaChonThuatToan.PerformLayout();
            this.grThuTu.ResumeLayout(false);
            this.grThuTu.PerformLayout();
            this.grDauVao.ResumeLayout(false);
            this.grDauVao.PerformLayout();
            this.grThucHien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grLuaChonThuatToan;
        private System.Windows.Forms.RadioButton rbChen;
        private System.Windows.Forms.RadioButton rbNoiBot;
        private System.Windows.Forms.RadioButton rbLuaChon;
        private System.Windows.Forms.GroupBox grThuTu;
        private System.Windows.Forms.RadioButton rbGiam;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.GroupBox grDauVao;
        private System.Windows.Forms.Button btnTangToc;
        private System.Windows.Forms.Button btnGiamToc;
        private System.Windows.Forms.TextBox tbTocDo;
        private System.Windows.Forms.Label lbTocDo;
        private System.Windows.Forms.TextBox tbNhapMang;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbNhapMang;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.RadioButton rbThuCong;
        private System.Windows.Forms.RadioButton rbTuDong;
        private System.Windows.Forms.GroupBox grThucHien;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnBatDau;
        public System.Windows.Forms.GroupBox grChinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


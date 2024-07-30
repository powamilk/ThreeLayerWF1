namespace ThreeLayerWF.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_tensanpham = new TextBox();
            cb_giaban = new ComboBox();
            cb_soluongton = new ComboBox();
            txt_nhasanxuat = new TextBox();
            txt_xuatxu = new TextBox();
            txt_mota = new TextBox();
            cb_trangthai = new ComboBox();
            dgv_sanpham = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_reset = new Button();
            txt_timkiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(42, 10);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(42, 46);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Giá Bán";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(42, 86);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Số Lượng Tồn";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(42, 121);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 3;
            label4.Text = "Nhà Sản Xuất";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(42, 156);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Xuất Xứ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(42, 186);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 5;
            label6.Text = "Trạng Thái";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(42, 214);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 6;
            label7.Text = "Mô Tả";
            // 
            // txt_tensanpham
            // 
            txt_tensanpham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_tensanpham.Location = new Point(129, 7);
            txt_tensanpham.Name = "txt_tensanpham";
            txt_tensanpham.Size = new Size(345, 23);
            txt_tensanpham.TabIndex = 7;
            // 
            // cb_giaban
            // 
            cb_giaban.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_giaban.FormattingEnabled = true;
            cb_giaban.Location = new Point(129, 46);
            cb_giaban.Name = "cb_giaban";
            cb_giaban.Size = new Size(347, 23);
            cb_giaban.TabIndex = 8;
            // 
            // cb_soluongton
            // 
            cb_soluongton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_soluongton.FormattingEnabled = true;
            cb_soluongton.Location = new Point(129, 83);
            cb_soluongton.Name = "cb_soluongton";
            cb_soluongton.Size = new Size(347, 23);
            cb_soluongton.TabIndex = 9;
            // 
            // txt_nhasanxuat
            // 
            txt_nhasanxuat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_nhasanxuat.Location = new Point(131, 118);
            txt_nhasanxuat.Name = "txt_nhasanxuat";
            txt_nhasanxuat.Size = new Size(345, 23);
            txt_nhasanxuat.TabIndex = 10;
            // 
            // txt_xuatxu
            // 
            txt_xuatxu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_xuatxu.Location = new Point(131, 156);
            txt_xuatxu.Name = "txt_xuatxu";
            txt_xuatxu.Size = new Size(345, 23);
            txt_xuatxu.TabIndex = 11;
            // 
            // txt_mota
            // 
            txt_mota.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_mota.Location = new Point(129, 215);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(345, 23);
            txt_mota.TabIndex = 12;
            // 
            // cb_trangthai
            // 
            cb_trangthai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(129, 186);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(347, 23);
            cb_trangthai.TabIndex = 13;
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(12, 288);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.RowTemplate.Height = 25;
            dgv_sanpham.Size = new Size(776, 150);
            dgv_sanpham.TabIndex = 14;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            // 
            // btn_them
            // 
            btn_them.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_them.Location = new Point(573, 24);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(165, 45);
            btn_them.TabIndex = 15;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_sua.Location = new Point(573, 86);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(165, 45);
            btn_sua.TabIndex = 16;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_xoa.Location = new Point(573, 156);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(165, 45);
            btn_xoa.TabIndex = 17;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_reset
            // 
            btn_reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_reset.Location = new Point(573, 222);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(165, 45);
            btn_reset.TabIndex = 18;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_timkiem.Location = new Point(42, 244);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(434, 23);
            txt_timkiem.TabIndex = 19;
            txt_timkiem.Text = "Tìm Kiếm theo tên";
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_timkiem);
            Controls.Add(btn_reset);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(dgv_sanpham);
            Controls.Add(cb_trangthai);
            Controls.Add(txt_mota);
            Controls.Add(txt_xuatxu);
            Controls.Add(txt_nhasanxuat);
            Controls.Add(cb_soluongton);
            Controls.Add(cb_giaban);
            Controls.Add(txt_tensanpham);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_tensanpham;
        private ComboBox cb_giaban;
        private ComboBox cb_soluongton;
        private TextBox txt_nhasanxuat;
        private TextBox txt_xuatxu;
        private TextBox txt_mota;
        private ComboBox cb_trangthai;
        private DataGridView dgv_sanpham;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_reset;
        private TextBox txt_timkiem;
    }
}

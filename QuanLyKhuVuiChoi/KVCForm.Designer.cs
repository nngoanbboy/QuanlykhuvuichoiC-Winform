
namespace QuanLyKhuVuiChoi
{
    partial class KVCForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TenKhu = new System.Windows.Forms.TextBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_GiaNguoiLon = new System.Windows.Forms.TextBox();
            this.textBox_GiaTreEm = new System.Windows.Forms.TextBox();
            this.textBox_GioDongCua = new System.Windows.Forms.TextBox();
            this.textBox_GioMoCua = new System.Windows.Forms.TextBox();
            this.textBox_DienTich = new System.Windows.Forms.TextBox();
            this.textBox_ViTri = new System.Windows.Forms.TextBox();
            this.textBox_MaKhu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TimKiemID = new System.Windows.Forms.TextBox();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(534, 289);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_TenKhu);
            this.groupBox1.Controls.Add(this.button_Xoa);
            this.groupBox1.Controls.Add(this.button_Sua);
            this.groupBox1.Controls.Add(this.button_Them);
            this.groupBox1.Controls.Add(this.textBox_GiaNguoiLon);
            this.groupBox1.Controls.Add(this.textBox_GiaTreEm);
            this.groupBox1.Controls.Add(this.textBox_GioDongCua);
            this.groupBox1.Controls.Add(this.textBox_GioMoCua);
            this.groupBox1.Controls.Add(this.textBox_DienTich);
            this.groupBox1.Controls.Add(this.textBox_ViTri);
            this.groupBox1.Controls.Add(this.textBox_MaKhu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(543, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // textBox_TenKhu
            // 
            this.textBox_TenKhu.Location = new System.Drawing.Point(124, 68);
            this.textBox_TenKhu.Name = "textBox_TenKhu";
            this.textBox_TenKhu.Size = new System.Drawing.Size(100, 20);
            this.textBox_TenKhu.TabIndex = 19;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(170, 343);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(64, 37);
            this.button_Xoa.TabIndex = 18;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(90, 343);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(61, 37);
            this.button_Sua.TabIndex = 17;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(7, 343);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(65, 37);
            this.button_Them.TabIndex = 16;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_GiaNguoiLon
            // 
            this.textBox_GiaNguoiLon.Location = new System.Drawing.Point(124, 274);
            this.textBox_GiaNguoiLon.Name = "textBox_GiaNguoiLon";
            this.textBox_GiaNguoiLon.Size = new System.Drawing.Size(100, 20);
            this.textBox_GiaNguoiLon.TabIndex = 15;
            // 
            // textBox_GiaTreEm
            // 
            this.textBox_GiaTreEm.Location = new System.Drawing.Point(124, 239);
            this.textBox_GiaTreEm.Name = "textBox_GiaTreEm";
            this.textBox_GiaTreEm.Size = new System.Drawing.Size(100, 20);
            this.textBox_GiaTreEm.TabIndex = 14;
            // 
            // textBox_GioDongCua
            // 
            this.textBox_GioDongCua.Location = new System.Drawing.Point(124, 203);
            this.textBox_GioDongCua.Name = "textBox_GioDongCua";
            this.textBox_GioDongCua.Size = new System.Drawing.Size(100, 20);
            this.textBox_GioDongCua.TabIndex = 13;
            // 
            // textBox_GioMoCua
            // 
            this.textBox_GioMoCua.Location = new System.Drawing.Point(124, 167);
            this.textBox_GioMoCua.Name = "textBox_GioMoCua";
            this.textBox_GioMoCua.Size = new System.Drawing.Size(100, 20);
            this.textBox_GioMoCua.TabIndex = 12;
            // 
            // textBox_DienTich
            // 
            this.textBox_DienTich.Location = new System.Drawing.Point(124, 140);
            this.textBox_DienTich.Name = "textBox_DienTich";
            this.textBox_DienTich.Size = new System.Drawing.Size(100, 20);
            this.textBox_DienTich.TabIndex = 11;
            // 
            // textBox_ViTri
            // 
            this.textBox_ViTri.Location = new System.Drawing.Point(124, 103);
            this.textBox_ViTri.Name = "textBox_ViTri";
            this.textBox_ViTri.Size = new System.Drawing.Size(100, 20);
            this.textBox_ViTri.TabIndex = 10;
            // 
            // textBox_MaKhu
            // 
            this.textBox_MaKhu.Location = new System.Drawing.Point(124, 36);
            this.textBox_MaKhu.Name = "textBox_MaKhu";
            this.textBox_MaKhu.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaKhu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(21, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giá người lớn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(21, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá trẻ em";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(21, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giờ đóng cửa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(21, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giờ mở cửa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Diện tích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vị trí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_TimKiemID);
            this.groupBox2.Controls.Add(this.textBox_TimKiem);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khu";
            // 
            // textBox_TimKiemID
            // 
            this.textBox_TimKiemID.Location = new System.Drawing.Point(96, 59);
            this.textBox_TimKiemID.Name = "textBox_TimKiemID";
            this.textBox_TimKiemID.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimKiemID.TabIndex = 2;
            this.textBox_TimKiemID.TextChanged += new System.EventHandler(this.textBox_TimKiemID_TextChanged);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(96, 24);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(100, 20);
            this.textBox_TimKiem.TabIndex = 1;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Khu";
            // 
            // KVCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KVCForm";
            this.Text = "KVCForm";
            this.Load += new System.EventHandler(this.KVCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.TextBox textBox_GiaNguoiLon;
        private System.Windows.Forms.TextBox textBox_GiaTreEm;
        private System.Windows.Forms.TextBox textBox_GioDongCua;
        private System.Windows.Forms.TextBox textBox_GioMoCua;
        private System.Windows.Forms.TextBox textBox_DienTich;
        private System.Windows.Forms.TextBox textBox_ViTri;
        private System.Windows.Forms.TextBox textBox_MaKhu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_TenKhu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TimKiemID;
    }
}
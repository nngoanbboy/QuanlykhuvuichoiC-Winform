using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhuVuiChoi
{
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }
        ModifyNhanVien modify;
        QuanLyNhanVien quanLyNhanVien;
        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            modify = new ModifyNhanVien();
            try
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaNV.Text;
            string name = this.textBox_HoTen.Text;
            DateTime dateOfBirth = DateTime.Parse(this.dateTimePicker1.Text);
            string sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            string phone = this.textBox_SDT.Text;
            string role = this.textBox_ChucVu.Text;
            string address = this.textBox_DiaChi.Text;
            int salary = int.Parse(this.textBox_Luong.Text);
            string idKhu = this.textBox_MaKhu.Text;
            quanLyNhanVien = new QuanLyNhanVien(id, name, dateOfBirth, sex, phone, role, address, salary, idKhu);
            if (modify.insert(quanLyNhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaNV.Text;
            string name = this.textBox_HoTen.Text;
            DateTime dateOfBirth = DateTime.Parse(this.dateTimePicker1.Text);
            string sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            string phone = this.textBox_SDT.Text;
            string role = this.textBox_ChucVu.Text;
            string address = this.textBox_DiaChi.Text;
            int salary = int.Parse(this.textBox_Luong.Text);
            string idKhu = this.textBox_MaKhu.Text;
            quanLyNhanVien = new QuanLyNhanVien(id, name, dateOfBirth, sex, phone, role, address, salary, idKhu);
            if (modify.update(quanLyNhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị cột ID từ hàng đang được chọn
                string id = dataGridView1.SelectedRows[0].Cells["MaNV"].Value.ToString();

                // Tạo đối tượng QuanLyKhu với giá trị ID
                QuanLyNhanVien quanLyNhanViendelete = new QuanLyNhanVien() { Id = id };
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phần này?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã ấn nút "OK" hay không
                if (result == DialogResult.OK)
                { 
                // Thực hiện xóa
                if (modify.delete(quanLyNhanViendelete))
                {
                    // Cập nhật lại DataGridView
                    dataGridView1.DataSource = modify.getAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Loi: " + "Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaNV.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_HoTen.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_SDT.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox_ChucVu.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox_DiaChi.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox_Luong.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox_MaKhu.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = textBox1.Text.Trim();
                DataTable dataTable = modify.searchNhanVienByName(searchName);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchID = textBox2.Text.Trim();
                DataTable dataTable = modify.searchNhanVienByID(searchID);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

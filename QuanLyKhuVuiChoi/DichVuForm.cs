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
    public partial class DichVuForm : Form
    {
        public DichVuForm()
        {
            InitializeComponent();
        }
        ModifyDichVu modify;
        QuanLyDichVu quanLyDichVu;

        private void DichVuForm_Load(object sender, EventArgs e)
        {
            modify = new ModifyDichVu();
            try
            {
                dataGridView1.DataSource = modify.getAllDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaDichVu.Text;
            string name = this.textBox_TenDichVu.Text;
            string price = this.textBox_GiaTien.Text;
            string idKhu = this.textBox_MaKhu.Text;

            quanLyDichVu = new QuanLyDichVu(id, name, price , idKhu);
            if (modify.insert(quanLyDichVu))
            {
                dataGridView1.DataSource = modify.getAllDichVu();
            }
            else
            {
                MessageBox.Show("Loi: " + "Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaDichVu.Text;
            string name = this.textBox_TenDichVu.Text;
            string price = this.textBox_GiaTien.Text;
            string idKhu = this.textBox_MaKhu.Text;

            quanLyDichVu = new QuanLyDichVu(id, name, price, idKhu);
            if (modify.update(quanLyDichVu))
            {
                dataGridView1.DataSource = modify.getAllDichVu();
            }
            else
            {
                MessageBox.Show("Loi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy giá trị cột ID từ hàng đang được chọn
                string id = dataGridView1.SelectedRows[0].Cells["MaDichVu"].Value.ToString();

                // Tạo đối tượng QuanLyDichVu với giá trị ID
                QuanLyDichVu quanLyDichVudelete = new QuanLyDichVu() { Id = id };

                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phần này?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã ấn nút "OK" hay không
                if (result == DialogResult.OK)
                {
                    // Thực hiện xóa
                    if (modify.delete(quanLyDichVudelete))
                    {
                        // Cập nhật lại DataGridView
                        dataGridView1.DataSource = modify.getAllDichVu();
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
            textBox_MaDichVu.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_TenDichVu.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_GiaTien.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_MaKhu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = textBox5.Text.Trim();
                DataTable dataTable = modify.searchDichVuByName(searchName);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchID = textBox1.Text.Trim();
                DataTable dataTable = modify.searchDichVuByID(searchID);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

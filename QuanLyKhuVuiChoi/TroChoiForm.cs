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
    public partial class TroChoiForm : Form
    {
        public TroChoiForm()
        {
            InitializeComponent();
        }
        ModifyTroChoi modify;
        QuanLyTroChoi quanLyTroChoi;

        private void TroChoiForm_Load(object sender, EventArgs e)
        {
            modify = new ModifyTroChoi();
            try
            {
                dataGridView1.DataSource = modify.getAllTroChoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaTroChoi.Text;
            string name = this.textBox_TenTroChoi.Text;    
            string vitri = this.textBox_ViTri.Text;
            string idKhu = this.textBox_MaKhu.Text;


            quanLyTroChoi = new QuanLyTroChoi(id, name, vitri, idKhu);
            if (modify.insert(quanLyTroChoi))
            {
                dataGridView1.DataSource = modify.getAllTroChoi();
            }
            else
            {
                MessageBox.Show("Loi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaTroChoi.Text;
            string name = this.textBox_TenTroChoi.Text;
            string vitri = this.textBox_ViTri.Text;
            string idKhu = this.textBox_MaKhu.Text;


            quanLyTroChoi = new QuanLyTroChoi(id, name, vitri, idKhu);
            if (modify.update(quanLyTroChoi))
            {
                dataGridView1.DataSource = modify.getAllTroChoi();
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
                string id = dataGridView1.SelectedRows[0].Cells["MaTroChoi"].Value.ToString();

                // Tạo đối tượng QuanLyKhu với giá trị ID
                QuanLyTroChoi quanLyTroChoidelete = new QuanLyTroChoi() { Id = id };
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phần này?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã ấn nút "OK" hay không
                if (result == DialogResult.OK)
                { 
                // Thực hiện xóa
                if (modify.delete(quanLyTroChoidelete))
                {
                    // Cập nhật lại DataGridView
                    dataGridView1.DataSource = modify.getAllTroChoi();
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
            textBox_MaTroChoi.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_TenTroChoi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_ViTri.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_MaKhu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchName = textBox1.Text.Trim();
                DataTable dataTable = modify.searchTroChoiByName(searchName);
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
                DataTable dataTable = modify.searchTroChoiByID(searchID);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

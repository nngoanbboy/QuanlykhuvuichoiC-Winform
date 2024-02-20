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
    public partial class KVCForm : Form
    {
        public KVCForm()
        {
            InitializeComponent();
        }
        ModifyKhuVuiChoi modify = new ModifyKhuVuiChoi();  // Tạo một instance ModifyKhuVuiChoi để thực hiện các thao tác trên cơ sở dữ liệu
        QuanLyKhu quanLyKhu;
     
        private void KVCForm_Load(object sender, EventArgs e) 
        {
            try
            {
                dataGridView1.DataSource = modify.Table("SELECT * FROM Khuvuichoi");
                // Tải dữ liệu từ cơ sở dữ liệu và gán vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void button_Them_Click(object sender, EventArgs e) // Lấy thông tin từ các TextBox để thêm vào cơ sở dữ liệu
        {
            string id = this.textBox_MaKhu.Text;
            string name = this.textBox_TenKhu.Text;
            string vitri = this.textBox_ViTri.Text;
            int dientich = int.Parse(this.textBox_DienTich.Text);
            TimeSpan giomo = TimeSpan.Parse(this.textBox_GioMoCua.Text);
            TimeSpan giodong = TimeSpan.Parse(this.textBox_GioDongCua.Text);
            int giatreem = int.Parse(this.textBox_GiaTreEm.Text);
            int gianguoilon = int.Parse(this.textBox_GiaNguoiLon.Text);
            quanLyKhu = new QuanLyKhu(id,name,vitri,dientich,giomo,giodong,giatreem,gianguoilon);
            if(modify.insert(quanLyKhu))
            {
                dataGridView1.DataSource = modify.Table("SELECT * FROM Khuvuichoi");
            }
            else
            {
                MessageBox.Show("Loi: " + "Không thêm được","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string id = this.textBox_MaKhu.Text;
            string name = this.textBox_TenKhu.Text;
            string vitri = this.textBox_ViTri.Text;
            int dientich = int.Parse(this.textBox_DienTich.Text);
            TimeSpan giomo = TimeSpan.Parse(this.textBox_GioMoCua.Text);
            TimeSpan giodong = TimeSpan.Parse(this.textBox_GioDongCua.Text);
            int giatreem = int.Parse(this.textBox_GiaTreEm.Text);
            int gianguoilon = int.Parse(this.textBox_GiaNguoiLon.Text);
            quanLyKhu = new QuanLyKhu(id, name, vitri, dientich, giomo, giodong, giatreem, gianguoilon);
            if (modify.update(quanLyKhu))
            {
                dataGridView1.DataSource = modify.Table("SELECT * FROM Khuvuichoi");
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
                string id = dataGridView1.SelectedRows[0].Cells["MaKhu"].Value.ToString();

                // Tạo đối tượng QuanLyKhu với giá trị ID
                QuanLyKhu quanLyKhudelete = new QuanLyKhu() { Id = id };
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phần này?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã ấn nút "OK" hay không
                if (result == DialogResult.OK)
                {

                    // Thực hiện xóa
                    if (modify.delete(quanLyKhudelete))
                    {
                        // Cập nhật lại DataGridView
                        dataGridView1.DataSource = modify.Table("SELECT * FROM Khuvuichoi");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Lấy thông tin từ hàng được chọn trong DataGridView và hiển thị lên các TextBox
        {
            textBox_MaKhu.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox_TenKhu.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox_ViTri.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox_DienTich.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox_GioMoCua.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox_GioDongCua.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox_GiaTreEm.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox_GiaNguoiLon.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = textBox_TimKiem.Text.Trim();
            if(name == "")
            {
                KVCForm_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM KhuVuiChoi Where TenKhu like '%"+name+ "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
            
        }

        private void textBox_TimKiemID_TextChanged(object sender, EventArgs e)
        {
            string id = textBox_TimKiemID.Text.Trim();
            if (id == "")
            {
                KVCForm_Load(sender, e);

            }
            else
            {
                string query = "SELECT * FROM KhuVuiChoi Where MaKhu like '%" + id + "%'";
                dataGridView1.DataSource = modify.Table(query);
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi
{
    // Định nghĩa lớp QuanLyKhu để lưu trữ thông tin về các khu vui chơi
    class QuanLyKhu
    {
        // Các trường dữ liệu được khai báo là private để đảm bảo tính bảo mật và sử dụng thuộc tính để truy cập chúng
        private string _id;
        private string _name;
        private string _vitri;
        private int _dientich;
        private TimeSpan _giomo;
        private TimeSpan _giodong;
        private int _giatreem;
        private int _gianguoilon;

        public QuanLyKhu()         // Constructor mặc định không có tham số

        {
        }

        public QuanLyKhu(string id, string name, string vitri, int dientich, TimeSpan giomo, TimeSpan giodong, int giatreem, int gianguoilon)
        {
            // Constructor với tham số để khởi tạo các giá trị cho các trường dữ liệu
            _id = id;
            _name = name;
            _vitri = vitri;
            _dientich = dientich;
            _giomo = giomo;
            _giodong = giodong;
            _giatreem = giatreem;
            _gianguoilon = gianguoilon;
        }
        // Các thuộc tính để truy cập và thiết lập giá trị cho các trường dữ liệu
        public string Id { get => _id; set => _id = value; }
       
        public string Name { get => _name; set => _name = value; }
        public string Vitri { get => _vitri; set => _vitri = value; }
        public int Dientich { get => _dientich; set => _dientich = value; }
        public TimeSpan Giomo { get => _giomo; set => _giomo = value; }
        public TimeSpan Giodong { get => _giodong; set => _giodong = value; }
        public int Giatreem { get => _giatreem; set => _giatreem = value; }
        public int Gianguoilon { get => _gianguoilon; set => _gianguoilon = value; }
    }
}

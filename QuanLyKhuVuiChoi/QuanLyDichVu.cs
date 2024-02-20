using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi
{
    class QuanLyDichVu
    {
        private string _id;
        private string _name;
        private string _price;
        private string _idKhu;

        public QuanLyDichVu()
        {
        }

        public QuanLyDichVu(string id, string name, string price, string idKhu)
        {
            _id = id;
            _name = name;
            _price = price;
            _idKhu = idKhu;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Price { get => _price; set => _price = value; }
        public string IdKhu { get => _idKhu; set => _idKhu = value; }
    }
}

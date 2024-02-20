using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi
{
    class QuanLyTroChoi
    {
        private string _id;
        private string _name;
        private string _vitri;
        private string _idKhu;

        public QuanLyTroChoi()
        {
        }

        public QuanLyTroChoi(string id, string name, string vitri, string idKhu)
        {
            _id = id;
            _name = name;
            _vitri = vitri;
            _idKhu = idKhu;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Vitri { get => _vitri; set => _vitri = value; }
        public string IdKhu { get => _idKhu; set => _idKhu = value; }
    }
}

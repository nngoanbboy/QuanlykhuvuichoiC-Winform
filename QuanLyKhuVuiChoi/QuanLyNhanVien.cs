using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhuVuiChoi
{
    class QuanLyNhanVien
    {
        private string _id;
        private string _name;
        private DateTime _dateOfBirth;
        private string _sex;
        private string _phone;
        private string _role;
        private string address;
        private int _salary;
        private string _idKhu;

        public QuanLyNhanVien()
        {
        }

        public QuanLyNhanVien(string id, string name, DateTime dateOfBirth, string sex, string phone, string role, string address, int salary, string idKhu)
        {
            _id = id;
            _name = name;
            _dateOfBirth = dateOfBirth;
            _sex = sex;
            _phone = phone;
            _role = role;
            this.address = address;
            _salary = salary;
            _idKhu = idKhu;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Role { get => _role; set => _role = value; }
        public string Address { get => address; set => address = value; }
        public int Salary { get => _salary; set => _salary = value; }
        public string IdKhu { get => _idKhu; set => _idKhu = value; }
    }
}

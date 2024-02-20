using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhuVuiChoi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        } SqlConnection conn = new SqlConnection(@"Data Source=ANPHATPC\SQLEXPRESS;Initial Catalog=QLKVC;Integrated Security=True");
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String query = "SELECT * FROM [User] WHERE username = @username AND password = @password";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@username", txt_username.Text);
                sda.SelectCommand.Parameters.AddWithValue("@password", txt_password.Text);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count > 0 )
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    MenuForm form2 =new MenuForm();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Khong hop le");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }
      
    }
}

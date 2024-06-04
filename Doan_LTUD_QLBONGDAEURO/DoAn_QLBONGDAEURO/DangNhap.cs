using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_QLBONGDAEURO
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUser.Text;
            string Password = txtPass.Text ;
            if (Username == "admin" && Password == "admin123")
            {
                // Đăng nhập thành công, thực hiện các tác vụ cần thiết ở đây.
                Menu frmTrangchu = new Menu(); 
                frmTrangchu.ShowDialog();
                this.Hide();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu tên tài khoản hoặc mật khẩu không đúng.
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}

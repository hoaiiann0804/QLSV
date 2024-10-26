using System;
using System.Windows.Forms;

namespace DoAnBaoCaoi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "hoaian" && txtPassword.Text == "123456")
            {

                FormStudentManagement formStudentManagement = new FormStudentManagement();
                formStudentManagement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Chuyển sang form đăng ký
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Close(); // Đóng form đăng nhập khi chuyển sang form đăng ký
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Quay lại form đăng nhập
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}

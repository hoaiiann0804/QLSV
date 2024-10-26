using System;
using System.Windows.Forms;

namespace DoAnBaoCaoi
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        // Click event handler for the Register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return; // Stop further execution if any field is empty
            }

            // Check if passwords match
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                // Check for minimum password length
                if (txtPassword.Text.Length >= 6)
                {
                    // Simulate saving registration info to the database
                    MessageBox.Show("Đăng ký thành công!");

                    // Redirect to the login form
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 ký tự!");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
            }
        }

        // Click event handler for the Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to the previous form (presumably the login form)
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}

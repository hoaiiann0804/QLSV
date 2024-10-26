using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnBaoCaoi
{
    public partial class FormStudentManagement : Form
    {
        public FormStudentManagement()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra các điều kiện nhập liệu
        private bool ValidateInputs()
        {
            // Kiểm tra mã số sinh viên
            if (string.IsNullOrWhiteSpace(tbId.Text) || tbId.Text.Length != 10 || !tbId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mã số sinh viên phải là 10 số.");
                tbId.Focus();
                return false;
            }

            // Kiểm tra tên sinh viên
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Tên sinh viên không được để trống.");
                tbName.Focus();
                return false;
            }

            // Kiểm tra tuổi sinh viên
            if (string.IsNullOrWhiteSpace(tbAge.Text) || !int.TryParse(tbAge.Text, out int age) || age < 18 || age > 100)
            {
                MessageBox.Show("Tuổi phải là số hợp lệ trong khoảng từ 18 đến 100.");
                tbAge.Focus();
                return false;
            }

            // Kiểm tra giới tính
            if (!rbNam.Checked && !rbNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                return false;
            }

            return true; // Nếu tất cả các điều kiện đều hợp lệ
        }

        // Sự kiện khi bấm nút Thêm mới
        private void btNew_Click(object sender, EventArgs e)
        {
            // Kiểm tra các điều kiện nhập liệu
            if (!ValidateInputs())
            {
                return; // Nếu không hợp lệ, thoát hàm
            }

            // Lưu giới tính (Nam hoặc Nữ)
            string gender = rbNam.Checked ? "Nam" : "Nữ";

            // Nếu hợp lệ, thêm vào bảng
            dgvCustomer.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, gender);
            ClearInputs(); // Xóa trường nhập liệu
        }

        // Sự kiện khi bấm nút Xóa
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow != null) // Kiểm tra xem có hàng nào được chọn không
            {
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows.RemoveAt(idx); // Xóa hàng được chọn
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        // Sự kiện khi bấm nút Sửa
        private void btEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra các điều kiện nhập liệu
            if (!ValidateInputs())
            {
                return; // Nếu không hợp lệ, thoát hàm
            }

            // Nếu hợp lệ, chỉnh sửa thông tin sinh viên
            int idx = dgvCustomer.CurrentCell.RowIndex;

            // Giữ nguyên mã số sinh viên (Cells[0]), chỉ cập nhật các thông tin khác
            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            dgvCustomer.Rows[idx].Cells[2].Value = tbAge.Text;
            dgvCustomer.Rows[idx].Cells[3].Value = rbNam.Checked ? "Nam" : "Nữ";
        }

    

    // Sự kiện khi bấm nút Thoát
    private void btExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }

        // Sự kiện khi chọn một hàng trong DataGridView
        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                int idx = e.RowIndex;

                // Gán giá trị từ DataGridView vào các TextBox và RadioButton
                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value?.ToString() ?? string.Empty;
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value?.ToString() ?? string.Empty;
                tbAge.Text = dgvCustomer.Rows[idx].Cells[2].Value?.ToString() ?? string.Empty;

                // Kiểm tra giới tính
                string gender = dgvCustomer.Rows[idx].Cells[3].Value?.ToString() ?? string.Empty;
                rbNam.Checked = gender == "Nam";
                rbNu.Checked = gender == "Nữ";
            }
        }

        // Hàm xóa trường nhập liệu
        private void ClearInputs()
        {
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false; // Đặt lại chọn giới tính
        }
    }
}

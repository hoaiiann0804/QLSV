namespace DoAnBaoCaoi
{
    partial class FormStudentManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCustomer = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btNew = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btExit = new Button();
            label1 = new Label();
            label2 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            tbAge = new TextBox();
            rbNam = new RadioButton();
            rbNu = new RadioButton();

            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();

            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3 });
            dgvCustomer.Location = new Point(25, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.RowTemplate.Height = 29;
            dgvCustomer.Size = new Size(751, 205);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.RowEnter += dgvCustomer_RowEnter;

            // 
            // Column0
            // 
            Column0.HeaderText = "Mã sinh viên";
            Column0.MinimumWidth = 6;
            Column0.Name = "Column0";
            Column0.Width = 200;

            // 
            // Column1
            // 
            Column1.HeaderText = "Tên sinh viên";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;

            // 
            // Column2
            // 
            Column2.HeaderText = "Tuổi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;

            // 
            // Column3
            // 
            Column3.HeaderText = "Giới tính";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;

            // 
            // btNew
            // 
            btNew.BackColor = Color.Red;
            btNew.ForeColor = Color.Yellow;
            btNew.Location = new Point(529, 241);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 39);
            btNew.TabIndex = 2;
            btNew.Text = "Thêm";
            btNew.UseVisualStyleBackColor = false;
            btNew.Click += btNew_Click;

            // 
            // btDelete
            // 
            btDelete.BackColor = Color.Red;
            btDelete.ForeColor = Color.Yellow;
            btDelete.Location = new Point(529, 298);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 39);
            btDelete.TabIndex = 3;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;

            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Red;
            btEdit.ForeColor = Color.Yellow;
            btEdit.Location = new Point(657, 243);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 39);
            btEdit.TabIndex = 4;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;

            // 
            // btExit
            // 
            btExit.BackColor = Color.Red;
            btExit.ForeColor = Color.Yellow;
            btExit.Location = new Point(657, 298);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 39);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 243);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã sinh viên:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 287);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên sinh viên:";

            // 
            // tbId
            // 
            tbId.Location = new Point(132, 240);
            tbId.Name = "tbId";
            tbId.Size = new Size(348, 27);
            tbId.TabIndex = 8;

            // 
            // tbName
            // 
            tbName.Location = new Point(132, 284);
            tbName.Name = "tbName";
            tbName.Size = new Size(348, 27);
            tbName.TabIndex = 9;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 330);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 10;
            label3.Text = "Tuổi:";

            // 
            // tbAge
            // 
            tbAge.Location = new Point(132, 330);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(348, 27);
            tbAge.TabIndex = 11;

            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(88, 371);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(60, 24);
            rbNam.TabIndex = 12;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;

            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(182, 371);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 13;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;

            // 
            // FormStudentManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbNu);
            Controls.Add(rbNam);
            Controls.Add(tbAge);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbId);
            Controls.Add(label1);
            Controls.Add(btExit);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Controls.Add(btNew);
            Controls.Add(dgvCustomer);
            Name = "FormStudentManagement";
            Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btNew;
        private Button btDelete;
        private Button btEdit;
        private Button btExit;
        private Label label1;
        private Label label2;
        private TextBox tbId;
        private TextBox tbName;
        private Label label3;
        private TextBox tbAge;
        private RadioButton rbNam;
        private RadioButton rbNu;
    }
}

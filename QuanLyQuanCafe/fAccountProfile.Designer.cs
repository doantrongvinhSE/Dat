namespace QuanLyQuanCafe
{
    partial class fAccountProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAccountProfile));
            panel1 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txbDisplayName = new TextBox();
            label2 = new Label();
            txbPassWord = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            txbNewPass = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            txbReEnterPass = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txbUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 47);
            panel1.TabIndex = 0;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.Window;
            txbUserName.Location = new Point(125, 12);
            txbUserName.Name = "txbUserName";
            txbUserName.ReadOnly = true;
            txbUserName.Size = new Size(272, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbDisplayName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 47);
            panel2.TabIndex = 1;
            // 
            // txbDisplayName
            // 
            txbDisplayName.BackColor = SystemColors.Window;
            txbDisplayName.Location = new Point(125, 14);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(272, 23);
            txbDisplayName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 17);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị";
            // 
            // txbPassWord
            // 
            txbPassWord.BackColor = SystemColors.Window;
            txbPassWord.Location = new Point(125, 14);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(272, 23);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            txbPassWord.TextChanged += txbPassWord_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 47);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 17);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // txbNewPass
            // 
            txbNewPass.BackColor = SystemColors.Window;
            txbNewPass.Location = new Point(125, 14);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.Size = new Size(272, 23);
            txbNewPass.TabIndex = 2;
            txbNewPass.TextChanged += txbNewPass_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(txbNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 162);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 47);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 17);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu mới";
            // 
            // txbReEnterPass
            // 
            txbReEnterPass.BackColor = SystemColors.Window;
            txbReEnterPass.Location = new Point(125, 14);
            txbReEnterPass.Name = "txbReEnterPass";
            txbReEnterPass.Size = new Size(272, 23);
            txbReEnterPass.TabIndex = 2;
            txbReEnterPass.TextChanged += txbReEnterPass_TextChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbReEnterPass);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 215);
            panel5.Name = "panel5";
            panel5.Size = new Size(432, 47);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 17);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Nhập lại";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.OrangeRed;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(279, 268);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(360, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // fAccountProfile
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            CancelButton = btnExit;
            ClientSize = new Size(439, 298);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += fAccountProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel2;
        private TextBox txbDisplayName;
        private Label label2;
        private TextBox txbPassWord;
        private Panel panel3;
        private Label label3;
        private TextBox txbNewPass;
        private Panel panel4;
        private Label label4;
        private TextBox txbReEnterPass;
        private Panel panel5;
        private Label label5;
        private Button btnUpdate;
        private Button btnExit;
    }
}
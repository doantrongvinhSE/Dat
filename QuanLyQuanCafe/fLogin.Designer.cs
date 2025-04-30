namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            btnExit = new Button();
            btnLogin = new Button();
            panel3 = new Panel();
            txbPassWord = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txbUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(285, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 251);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Snow;
            btnExit.Location = new Point(336, 159);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(81, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Snow;
            btnLogin.Location = new Point(229, 159);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 72);
            panel3.TabIndex = 2;
            // 
            // txbPassWord
            // 
            txbPassWord.BackColor = Color.White;
            txbPassWord.ForeColor = Color.Black;
            txbPassWord.Location = new Point(154, 19);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(263, 23);
            txbPassWord.TabIndex = 2;
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 23);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.ForeColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(285, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 72);
            panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = Color.White;
            txbUserName.ForeColor = Color.Black;
            txbUserName.Location = new Point(154, 19);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(263, 23);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            CancelButton = btnExit;
            ClientSize = new Size(724, 275);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            TransparencyKey = SystemColors.HotTrack;
            FormClosing += fLogin_FormClosing;
            Load += fLogin_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txbUserName;
        private Label label1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Label label2;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}

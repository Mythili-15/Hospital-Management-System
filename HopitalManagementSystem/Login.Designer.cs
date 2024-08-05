namespace HopitalManagementSystem
{
    partial class Login
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel5 = new Panel();
            labelTitle = new Label();
            panel1 = new Panel();
            label3 = new Label();
            button1 = new Button();
            textBoxPass = new TextBox();
            textBoxUsername = new TextBox();
            textboxError = new Label();
            labelPassword = new Label();
            label2 = new Label();
            labelLoginTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(12, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(71, 96);
            panel5.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(0, 0, 5, 249);
            labelTitle.Font = new Font("Microsoft Sans Serif", 13.8F);
            labelTitle.ForeColor = Color.FromArgb(136, 146, 155);
            labelTitle.Location = new Point(90, 41);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(484, 32);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(textboxError);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelLoginTitle);
            panel1.Location = new Point(12, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 315);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 5, 249);
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(136, 146, 155);
            label3.Location = new Point(140, 196);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 5;
            label3.Text = "Login as doctor";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 171, 226);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 21, 41);
            button1.Location = new Point(23, 233);
            button1.Name = "button1";
            button1.Size = new Size(379, 44);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = Color.FromArgb(0, 21, 41);
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPass.ForeColor = Color.White;
            textBoxPass.Location = new Point(23, 149);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(379, 35);
            textBoxPass.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(0, 21, 41);
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(23, 88);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(379, 35);
            textBoxUsername.TabIndex = 1;
            // 
            // textboxError
            // 
            textboxError.AutoSize = true;
            textboxError.BackColor = Color.FromArgb(0, 0, 5, 249);
            textboxError.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textboxError.ForeColor = Color.FromArgb(192, 0, 0);
            textboxError.Location = new Point(60, 280);
            textboxError.Margin = new Padding(10, 0, 10, 0);
            textboxError.Name = "textboxError";
            textboxError.Size = new Size(373, 25);
            textboxError.TabIndex = 3;
            textboxError.Text = "Please Enter Required Information";
            textboxError.Visible = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.FromArgb(0, 0, 5, 249);
            labelPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(136, 146, 155);
            labelPassword.Location = new Point(12, 122);
            labelPassword.Margin = new Padding(10, 0, 10, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(121, 25);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 5, 249);
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(136, 146, 155);
            label2.Location = new Point(10, 50);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // labelLoginTitle
            // 
            labelLoginTitle.AutoSize = true;
            labelLoginTitle.BackColor = Color.FromArgb(0, 0, 5, 249);
            labelLoginTitle.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoginTitle.ForeColor = Color.FromArgb(136, 146, 155);
            labelLoginTitle.Location = new Point(117, 12);
            labelLoginTitle.Margin = new Padding(10, 0, 10, 0);
            labelLoginTitle.Name = "labelLoginTitle";
            labelLoginTitle.Size = new Size(264, 38);
            labelLoginTitle.TabIndex = 0;
            labelLoginTitle.Text = "Employee Login";
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 21, 41);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1115, 498);
            Controls.Add(panel1);
            Controls.Add(labelTitle);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBoxPass;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelLoginTitle;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label textboxError;
        public System.Windows.Forms.Label label3;
    }
}

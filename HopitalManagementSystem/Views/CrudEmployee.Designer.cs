namespace HopitalManagementSystem
{
    partial class CrudEmployee
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudEmployee));
            rolecbx = new ComboBox();
            depcbx = new ComboBox();
            dataGridView1 = new DataGridView();
            comboBoxSearchBy = new ComboBox();
            comboBoxGender = new ComboBox();
            buttonDisplay = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxSearch = new TextBox();
            textBoxEmail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            textBoxAddress = new TextBox();
            buttonInsert = new Button();
            dOCTORSBindingSource = new BindingSource(components);
            label7 = new Label();
            label5 = new Label();
            textBoxTel = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxid = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            Content = new Panel();
            password = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).BeginInit();
            Content.SuspendLayout();
            SuspendLayout();
            // 
            // rolecbx
            // 
            rolecbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            rolecbx.AutoCompleteSource = AutoCompleteSource.ListItems;
            rolecbx.BackColor = Color.FromArgb(41, 171, 226);
            rolecbx.FlatStyle = FlatStyle.Flat;
            rolecbx.Font = new Font("Segoe UI", 13.8F);
            rolecbx.FormattingEnabled = true;
            rolecbx.Location = new Point(742, 319);
            rolecbx.Margin = new Padding(4, 6, 4, 6);
            rolecbx.Name = "rolecbx";
            rolecbx.Size = new Size(199, 46);
            rolecbx.TabIndex = 14;
            // 
            // depcbx
            // 
            depcbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            depcbx.AutoCompleteSource = AutoCompleteSource.ListItems;
            depcbx.BackColor = Color.FromArgb(41, 171, 226);
            depcbx.FlatStyle = FlatStyle.Flat;
            depcbx.Font = new Font("Segoe UI", 13.8F);
            depcbx.FormattingEnabled = true;
            depcbx.Location = new Point(333, 313);
            depcbx.Margin = new Padding(4, 6, 4, 6);
            depcbx.Name = "depcbx";
            depcbx.Size = new Size(199, 46);
            depcbx.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(41, 171, 226);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 13);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(49, 600);
            dataGridView1.Margin = new Padding(4, 6, 4, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(2001, 415);
            dataGridView1.TabIndex = 12;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearchBy.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSearchBy.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.Font = new Font("Segoe UI", 13.8F);
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Name", "Number", "Email", "Role" });
            comboBoxSearchBy.Location = new Point(1200, 394);
            comboBoxSearchBy.Margin = new Padding(4, 6, 4, 6);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(610, 46);
            comboBoxSearchBy.TabIndex = 3;
            // 
            // comboBoxGender
            // 
            comboBoxGender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxGender.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Segoe UI", 13.8F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            comboBoxGender.Location = new Point(742, 171);
            comboBoxGender.Margin = new Padding(4, 6, 4, 6);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(199, 46);
            comboBoxGender.TabIndex = 3;
            // 
            // buttonDisplay
            // 
            buttonDisplay.BackColor = Color.FromArgb(41, 171, 226);
            buttonDisplay.FlatStyle = FlatStyle.Flat;
            buttonDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDisplay.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDisplay.Image = (Image)resources.GetObject("buttonDisplay.Image");
            buttonDisplay.Location = new Point(1383, 253);
            buttonDisplay.Margin = new Padding(4, 6, 4, 6);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(427, 74);
            buttonDisplay.TabIndex = 5;
            buttonDisplay.Text = " DISPLAY EMPLOYEE";
            buttonDisplay.TextAlign = ContentAlignment.MiddleRight;
            buttonDisplay.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDisplay.UseVisualStyleBackColor = false;
            buttonDisplay.Click += buttonDisplay_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(41, 171, 226);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.FromArgb(0, 7, 13);
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.Location = new Point(1008, 253);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(357, 74);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = " UPDATE EMPLOYEE";
            buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
            buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(41, 171, 226);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(1383, 153);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(427, 88);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = " DELETE EMPLOYEE";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(41, 171, 226);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 16F);
            textBoxSearch.Location = new Point(1274, 471);
            textBoxSearch.Margin = new Padding(4, 6, 4, 6);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(536, 37);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 13.8F);
            textBoxEmail.Location = new Point(333, 401);
            textBoxEmail.Margin = new Padding(4, 6, 4, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(609, 37);
            textBoxEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(40, 394);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 0;
            label6.Text = "EMAIL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(40, 321);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(226, 32);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(41, 171, 226);
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Segoe UI", 13.8F);
            textBoxAddress.Location = new Point(333, 471);
            textBoxAddress.Margin = new Padding(4, 6, 4, 6);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(609, 92);
            textBoxAddress.TabIndex = 7;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = Color.FromArgb(41, 171, 226);
            buttonInsert.FlatStyle = FlatStyle.Flat;
            buttonInsert.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonInsert.ForeColor = Color.FromArgb(0, 7, 13);
            buttonInsert.Image = (Image)resources.GetObject("buttonInsert.Image");
            buttonInsert.Location = new Point(1008, 153);
            buttonInsert.Margin = new Padding(4, 6, 4, 6);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(357, 88);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = " INSERT EMPLOYEE";
            buttonInsert.TextAlign = ContentAlignment.MiddleRight;
            buttonInsert.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(41, 171, 226);
            label7.Location = new Point(40, 456);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 32);
            label7.TabIndex = 0;
            label7.Text = "ADDRESS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(568, 330);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 0;
            label5.Text = "Role:";
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Segoe UI", 13.8F);
            textBoxTel.Location = new Point(742, 259);
            textBoxTel.Margin = new Padding(4, 6, 4, 6);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(200, 37);
            textBoxTel.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(568, 176);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 0;
            label4.Text = "GENDER:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(41, 171, 226);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 13.8F);
            textBoxName.Location = new Point(333, 259);
            textBoxName.Margin = new Padding(4, 6, 4, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 37);
            textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(40, 255);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.FromArgb(41, 171, 226);
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Font = new Font("Segoe UI", 13.8F);
            textBoxid.Location = new Point(333, 180);
            textBoxid.Margin = new Padding(4, 6, 4, 6);
            textBoxid.Name = "textBoxid";
            textBoxid.ReadOnly = true;
            textBoxid.Size = new Size(200, 37);
            textBoxid.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F);
            label11.ForeColor = Color.FromArgb(41, 171, 226);
            label11.Location = new Point(1001, 401);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(184, 32);
            label11.TabIndex = 0;
            label11.Text = "SEARCH BY:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F);
            label10.ForeColor = Color.FromArgb(41, 171, 226);
            label10.Location = new Point(1001, 487);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(239, 32);
            label10.TabIndex = 0;
            label10.Text = "SEARCH VALUE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(40, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(31, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(246, 55);
            label2.TabIndex = 1;
            label2.Text = "Employee";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(568, 255);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 32);
            label9.TabIndex = 0;
            label9.Text = "TEL NO:";
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.Controls.Add(password);
            Content.Controls.Add(label12);
            Content.Controls.Add(rolecbx);
            Content.Controls.Add(depcbx);
            Content.Controls.Add(dataGridView1);
            Content.Controls.Add(comboBoxSearchBy);
            Content.Controls.Add(comboBoxGender);
            Content.Controls.Add(buttonDisplay);
            Content.Controls.Add(buttonUpdate);
            Content.Controls.Add(buttonDelete);
            Content.Controls.Add(buttonInsert);
            Content.Controls.Add(textBoxSearch);
            Content.Controls.Add(textBoxEmail);
            Content.Controls.Add(label6);
            Content.Controls.Add(label8);
            Content.Controls.Add(textBoxAddress);
            Content.Controls.Add(label7);
            Content.Controls.Add(label5);
            Content.Controls.Add(textBoxTel);
            Content.Controls.Add(label9);
            Content.Controls.Add(label4);
            Content.Controls.Add(textBoxName);
            Content.Controls.Add(label3);
            Content.Controls.Add(textBoxid);
            Content.Controls.Add(label11);
            Content.Controls.Add(label10);
            Content.Controls.Add(label1);
            Content.Controls.Add(label2);
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Content.Location = new Point(0, 0);
            Content.Margin = new Padding(4, 6, 4, 6);
            Content.Name = "Content";
            Content.Size = new Size(2103, 1062);
            Content.TabIndex = 3;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(41, 171, 226);
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 13.8F);
            password.Location = new Point(742, 97);
            password.Margin = new Padding(4, 6, 4, 6);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(200, 37);
            password.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(41, 171, 226);
            label12.Location = new Point(568, 101);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(155, 32);
            label12.TabIndex = 15;
            label12.Text = "Password:";
            // 
            // CrudEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1946, 1058);
            Controls.Add(Content);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "CrudEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudEmployee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).EndInit();
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        //private HMS_DatabaseDataSet5 hMS_DatabaseDataSet5;
        public System.Windows.Forms.ComboBox rolecbx;
        public System.Windows.Forms.ComboBox depcbx;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.Button buttonDisplay;
        public System.Windows.Forms.Button buttonUpdate;
        //private HMS_DatabaseDataSetTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxAddress;
        //private HMS_DatabaseDataSet6 hMS_DatabaseDataSet6;
        public System.Windows.Forms.Button buttonInsert;
        public System.Windows.Forms.BindingSource dOCTORSBindingSource;
        //private HMS_DatabaseDataSet hMS_DatabaseDataSet;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxid;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.Label label12;
    }
}

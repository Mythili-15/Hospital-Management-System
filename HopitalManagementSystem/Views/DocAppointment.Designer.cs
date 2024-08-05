namespace HopitalManagementSystem
{
    partial class Docappointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docappointment));
            textBoxAddress = new TextBox();
            Content = new Panel();
            panel1 = new Panel();
            comboBoxSearchBy = new ComboBox();
            dataGridViewINP = new DataGridView();
            label17 = new Label();
            label20 = new Label();
            comboBoxGender = new ComboBox();
            button4 = new Button();
            buttonDisplay = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonInsert = new Button();
            textBoxEmail = new TextBox();
            label6 = new Label();
            textBoxDepartment = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBoxSearch = new TextBox();
            label5 = new Label();
            textBoxDesignation = new TextBox();
            textBoxTel = new TextBox();
            label9 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Content.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewINP).BeginInit();
            SuspendLayout();
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(41, 171, 226);
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxAddress.Location = new Point(270, 327);
            textBoxAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(521, 88);
            textBoxAddress.TabIndex = 7;
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.Controls.Add(panel1);
            Content.Controls.Add(comboBoxGender);
            Content.Controls.Add(button4);
            Content.Controls.Add(buttonDisplay);
            Content.Controls.Add(buttonUpdate);
            Content.Controls.Add(buttonDelete);
            Content.Controls.Add(buttonInsert);
            Content.Controls.Add(textBoxEmail);
            Content.Controls.Add(label6);
            Content.Controls.Add(textBoxDepartment);
            Content.Controls.Add(label8);
            Content.Controls.Add(textBoxAddress);
            Content.Controls.Add(label7);
            Content.Controls.Add(textBoxSearch);
            Content.Controls.Add(label5);
            Content.Controls.Add(textBoxDesignation);
            Content.Controls.Add(textBoxTel);
            Content.Controls.Add(label9);
            Content.Controls.Add(label4);
            Content.Controls.Add(textBoxName);
            Content.Controls.Add(label3);
            Content.Controls.Add(textBoxid);
            Content.Controls.Add(label1);
            Content.Controls.Add(label2);
            Content.Dock = DockStyle.Fill;
            Content.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Content.Location = new Point(0, 0);
            Content.Margin = new Padding(4, 5, 4, 5);
            Content.Name = "Content";
            Content.Size = new Size(1576, 858);
            Content.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 13);
            panel1.Controls.Add(comboBoxSearchBy);
            panel1.Controls.Add(dataGridViewINP);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label20);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1576, 858);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearchBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxSearchBy.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.Font = new Font("Microsoft Sans Serif", 14F);
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Current Appointments", "All Appointments" });
            comboBoxSearchBy.Location = new Point(351, 92);
            comboBoxSearchBy.Margin = new Padding(4, 5, 4, 5);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(170, 40);
            comboBoxSearchBy.TabIndex = 11;
            comboBoxSearchBy.SelectedIndexChanged += comboBoxSearchBy_SelectedIndexChanged_1;
            // 
            // dataGridViewINP
            // 
            dataGridViewINP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewINP.BackgroundColor = Color.FromArgb(41, 171, 226);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 7, 13);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewINP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewINP.ColumnHeadersHeight = 40;
            dataGridViewINP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewINP.Location = new Point(39, 155);
            dataGridViewINP.Margin = new Padding(4, 5, 4, 5);
            dataGridViewINP.Name = "dataGridViewINP";
            dataGridViewINP.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewINP.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewINP.RowHeadersWidth = 50;
            dataGridViewINP.RowTemplate.Height = 24;
            dataGridViewINP.Size = new Size(1499, 325);
            dataGridViewINP.TabIndex = 21;
            dataGridViewINP.CellContentClick += dataGridViewINP_CellContentClick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14F);
            label17.ForeColor = Color.FromArgb(41, 171, 226);
            label17.Location = new Point(193, 93);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(139, 32);
            label17.TabIndex = 10;
            label17.Text = "SELECT: ";
            label17.Click += label17_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(41, 171, 226);
            label20.Location = new Point(24, 32);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(414, 55);
            label20.TabIndex = 1;
            label20.Text = "APPOINTMENTS";
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Microsoft Sans Serif", 6F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            comboBoxGender.Location = new Point(639, 162);
            comboBoxGender.Margin = new Padding(4, 5, 4, 5);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(153, 23);
            comboBoxGender.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 171, 226);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 7, 13);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(1214, 408);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(324, 72);
            button4.TabIndex = 5;
            button4.Text = "Add New Patient";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonDisplay
            // 
            buttonDisplay.BackColor = Color.FromArgb(41, 171, 226);
            buttonDisplay.FlatStyle = FlatStyle.Flat;
            buttonDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDisplay.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDisplay.Image = (Image)resources.GetObject("buttonDisplay.Image");
            buttonDisplay.Location = new Point(1214, 245);
            buttonDisplay.Margin = new Padding(4, 5, 4, 5);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(324, 72);
            buttonDisplay.TabIndex = 5;
            buttonDisplay.Text = " Display Data";
            buttonDisplay.TextAlign = ContentAlignment.MiddleRight;
            buttonDisplay.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDisplay.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(41, 171, 226);
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.FromArgb(0, 7, 13);
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.Location = new Point(881, 245);
            buttonUpdate.Margin = new Padding(4, 5, 4, 5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(324, 72);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = " UPDATE DOCTOR";
            buttonUpdate.TextAlign = ContentAlignment.MiddleRight;
            buttonUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(41, 171, 226);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(1214, 163);
            buttonDelete.Margin = new Padding(4, 5, 4, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(324, 72);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = " DELETE DOCTOR";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = Color.FromArgb(41, 171, 226);
            buttonInsert.FlatStyle = FlatStyle.Flat;
            buttonInsert.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonInsert.ForeColor = Color.FromArgb(0, 7, 13);
            buttonInsert.Image = (Image)resources.GetObject("buttonInsert.Image");
            buttonInsert.Location = new Point(881, 163);
            buttonInsert.Margin = new Padding(4, 5, 4, 5);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(324, 72);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = " INSERT DOCTOR";
            buttonInsert.TextAlign = ContentAlignment.MiddleRight;
            buttonInsert.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInsert.UseVisualStyleBackColor = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxEmail.Location = new Point(270, 287);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(521, 24);
            textBoxEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(84, 280);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 0;
            label6.Text = "EMAIL:";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.BackColor = Color.FromArgb(41, 171, 226);
            textBoxDepartment.BorderStyle = BorderStyle.None;
            textBoxDepartment.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxDepartment.Location = new Point(270, 245);
            textBoxDepartment.Margin = new Padding(4, 5, 4, 5);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(154, 24);
            textBoxDepartment.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(84, 238);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(41, 171, 226);
            label7.Location = new Point(84, 320);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 0;
            label7.Text = "ADDRESS:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(41, 171, 226);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 22F);
            textBoxSearch.Location = new Point(881, 408);
            textBoxSearch.Margin = new Padding(4, 5, 4, 5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(324, 50);
            textBoxSearch.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(451, 238);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 0;
            label5.Text = "DESIGNATION:";
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BackColor = Color.FromArgb(41, 171, 226);
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxDesignation.Location = new Point(639, 245);
            textBoxDesignation.Margin = new Padding(4, 5, 4, 5);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(154, 24);
            textBoxDesignation.TabIndex = 5;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxTel.Location = new Point(639, 205);
            textBoxTel.Margin = new Padding(4, 5, 4, 5);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(154, 24);
            textBoxTel.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(451, 198);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 0;
            label9.Text = "TEL NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(451, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 0;
            label4.Text = "GENDER:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(41, 171, 226);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxName.Location = new Point(270, 205);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(154, 24);
            textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(84, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.FromArgb(41, 171, 226);
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxid.Location = new Point(270, 163);
            textBoxid.Margin = new Padding(4, 5, 4, 5);
            textBoxid.Name = "textBoxid";
            textBoxid.ReadOnly = true;
            textBoxid.Size = new Size(154, 24);
            textBoxid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(84, 158);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(24, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 55);
            label2.TabIndex = 1;
            label2.Text = "PATIENT";
            // 
            // Docappointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Content);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Docappointment";
            Size = new Size(1576, 858);
            Content.ResumeLayout(false);
            Content.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewINP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBoxpatient;
        public System.Windows.Forms.DateTimePicker dateTimePickerENDTIME;
        public System.Windows.Forms.Button buttonReschedule;
        public System.Windows.Forms.Button buttonCancelAppointment;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button buttonDisplay;
        public System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonInsert;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxDepartment;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxDesignation;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxid;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewINP;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.Label label17;
    }
}

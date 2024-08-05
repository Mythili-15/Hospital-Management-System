namespace HopitalManagementSystem
{
    partial class CRUDDoctor
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDDoctor));
            Content = new Panel();
            priceperappointment = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            rolecbx = new ComboBox();
            depcbx = new ComboBox();
            dataGridView1 = new DataGridView();
            comboBoxSearchBy = new ComboBox();
            comboBoxGender = new ComboBox();
            buttonDisplay = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonInsert = new Button();
            textBoxSearch = new TextBox();
            textBoxEmail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            textBoxAddress = new TextBox();
            label7 = new Label();
            label5 = new Label();
            textBoxTel = new TextBox();
            label9 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxid = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            dOCTORSBindingSource = new BindingSource(components);
            Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Content
            // 
            Content.AutoScroll = true;
            Content.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Content.BackColor = Color.FromArgb(0, 7, 13);
            Content.Controls.Add(priceperappointment);
            Content.Controls.Add(label14);
            Content.Controls.Add(label13);
            Content.Controls.Add(label12);
            Content.Controls.Add(dateTimePicker2);
            Content.Controls.Add(dateTimePicker1);
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
            Content.Dock = DockStyle.Fill;
            Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Content.Location = new Point(0, 0);
            Content.Name = "Content";
            Content.Size = new Size(1418, 664);
            Content.TabIndex = 2;
            Content.Paint += Content_Paint;
            // 
            // priceperappointment
            // 
            priceperappointment.BackColor = Color.FromArgb(41, 171, 226);
            priceperappointment.BorderStyle = BorderStyle.None;
            priceperappointment.Font = new Font("Segoe UI", 13.8F);
            priceperappointment.Location = new Point(1134, 35);
            priceperappointment.Name = "priceperappointment";
            priceperappointment.Size = new Size(179, 37);
            priceperappointment.TabIndex = 21;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(41, 171, 226);
            label14.Location = new Point(786, 35);
            label14.Name = "label14";
            label14.Size = new Size(325, 32);
            label14.TabIndex = 20;
            label14.Text = "Price per Appointment:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(41, 171, 226);
            label13.Location = new Point(369, 61);
            label13.Name = "label13";
            label13.Size = new Size(152, 32);
            label13.TabIndex = 18;
            label13.Text = "End Time:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(41, 171, 226);
            label12.Location = new Point(358, 20);
            label12.Name = "label12";
            label12.Size = new Size(163, 32);
            label12.TabIndex = 17;
            label12.Text = "Start Time:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(527, 61);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(165, 35);
            dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(527, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 35);
            dateTimePicker1.TabIndex = 15;
            // 
            // rolecbx
            // 
            rolecbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            rolecbx.AutoCompleteSource = AutoCompleteSource.ListItems;
            rolecbx.BackColor = Color.FromArgb(41, 171, 226);
            rolecbx.FlatStyle = FlatStyle.Flat;
            rolecbx.Font = new Font("Segoe UI", 13.8F);
            rolecbx.FormattingEnabled = true;
            rolecbx.Location = new Point(569, 198);
            rolecbx.Name = "rolecbx";
            rolecbx.Size = new Size(123, 46);
            rolecbx.TabIndex = 14;
            rolecbx.SelectedIndexChanged += rolecbx_SelectedIndexChanged;
            // 
            // depcbx
            // 
            depcbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            depcbx.AutoCompleteSource = AutoCompleteSource.ListItems;
            depcbx.BackColor = Color.FromArgb(41, 171, 226);
            depcbx.FlatStyle = FlatStyle.Flat;
            depcbx.Font = new Font("Segoe UI", 13.8F);
            depcbx.FormattingEnabled = true;
            depcbx.Location = new Point(243, 182);
            depcbx.Name = "depcbx";
            depcbx.Size = new Size(123, 46);
            depcbx.TabIndex = 13;
            depcbx.SelectedIndexChanged += depcbx_SelectedIndexChanged;
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
            dataGridView1.Location = new Point(42, 369);
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
            dataGridView1.Size = new Size(1350, 257);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            comboBoxSearchBy.Items.AddRange(new object[] { "Doctor ID", "Name", "Number", "" });
            comboBoxSearchBy.Location = new Point(1005, 226);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(370, 46);
            comboBoxSearchBy.TabIndex = 3;
            comboBoxSearchBy.SelectedIndexChanged += comboBoxSearchBy_SelectedIndexChanged;
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
            comboBoxGender.Location = new Point(569, 101);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(123, 46);
            comboBoxGender.TabIndex = 3;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // buttonDisplay
            // 
            buttonDisplay.BackColor = Color.FromArgb(41, 171, 226);
            buttonDisplay.FlatStyle = FlatStyle.Flat;
            buttonDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDisplay.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDisplay.Image = (Image)resources.GetObject("buttonDisplay.Image");
            buttonDisplay.Location = new Point(1102, 144);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(259, 46);
            buttonDisplay.TabIndex = 5;
            buttonDisplay.Text = " DISPLAY DOCTOR";
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
            buttonUpdate.Location = new Point(786, 144);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(259, 46);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = " UPDATE DOCTOR";
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
            buttonDelete.Location = new Point(1102, 87);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(259, 46);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = " DELETE DOCTOR";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.BackColor = Color.FromArgb(41, 171, 226);
            buttonInsert.FlatStyle = FlatStyle.Flat;
            buttonInsert.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonInsert.ForeColor = Color.FromArgb(0, 7, 13);
            buttonInsert.Image = (Image)resources.GetObject("buttonInsert.Image");
            buttonInsert.Location = new Point(786, 87);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(259, 46);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = " INSERT DOCTOR";
            buttonInsert.TextAlign = ContentAlignment.MiddleRight;
            buttonInsert.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonInsert.UseVisualStyleBackColor = false;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(41, 171, 226);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 16F);
            textBoxSearch.Location = new Point(1051, 290);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(324, 37);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 13.8F);
            textBoxEmail.Location = new Point(243, 250);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(449, 37);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(117, 250);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 0;
            label6.Text = "EMAIL:";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(3, 190);
            label8.Name = "label8";
            label8.Size = new Size(226, 32);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
            label8.Click += label8_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(41, 171, 226);
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Segoe UI", 13.8F);
            textBoxAddress.Location = new Point(243, 304);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(449, 48);
            textBoxAddress.TabIndex = 7;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(41, 171, 226);
            label7.Location = new Point(63, 309);
            label7.Name = "label7";
            label7.Size = new Size(166, 32);
            label7.TabIndex = 0;
            label7.Text = "ADDRESS:";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(435, 206);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 0;
            label5.Text = "Role:";
            label5.Click += label5_Click;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Segoe UI", 13.8F);
            textBoxTel.Location = new Point(569, 153);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(123, 37);
            textBoxTel.TabIndex = 4;
            textBoxTel.TextChanged += textBoxTel_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(391, 158);
            label9.Name = "label9";
            label9.Size = new Size(130, 32);
            label9.TabIndex = 0;
            label9.Text = "TEL NO:";
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(372, 115);
            label4.Name = "label4";
            label4.Size = new Size(149, 32);
            label4.TabIndex = 0;
            label4.Text = "GENDER:";
            label4.Click += label4_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(41, 171, 226);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Segoe UI", 13.8F);
            textBoxName.Location = new Point(243, 137);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(123, 37);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(121, 142);
            label3.Name = "label3";
            label3.Size = new Size(108, 32);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            label3.Click += label3_Click;
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.FromArgb(41, 171, 226);
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Font = new Font("Segoe UI", 13.8F);
            textBoxid.Location = new Point(243, 87);
            textBoxid.Name = "textBoxid";
            textBoxid.ReadOnly = true;
            textBoxid.Size = new Size(123, 37);
            textBoxid.TabIndex = 0;
            textBoxid.TextChanged += textBoxid_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F);
            label11.ForeColor = Color.FromArgb(41, 171, 226);
            label11.Location = new Point(781, 234);
            label11.Name = "label11";
            label11.Size = new Size(184, 32);
            label11.TabIndex = 0;
            label11.Text = "SEARCH BY:";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F);
            label10.ForeColor = Color.FromArgb(41, 171, 226);
            label10.Location = new Point(778, 293);
            label10.Name = "label10";
            label10.Size = new Size(239, 32);
            label10.TabIndex = 0;
            label10.Text = "SEARCH VALUE:";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(42, 92);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(238, 55);
            label2.TabIndex = 1;
            label2.Text = "DOCTOR";
            label2.Click += label2_Click;
            // 
            // dOCTORSBindingSource
            // 
            dOCTORSBindingSource.DataMember = "DOCTORS";
            dOCTORSBindingSource.CurrentChanged += dOCTORSBindingSource_CurrentChanged;
            // 
            // CRUDDoctor
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(Content);
            Name = "CRUDDoctor";
            Size = new Size(1418, 664);
            Content.ResumeLayout(false);
            Content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dOCTORSBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxid;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.Button buttonDisplay;
        public System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonInsert;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        //private HMS_DatabaseDataSet5 hMS_DatabaseDataSet5;
        //private HMS_DatabaseDataSet6 hMS_DatabaseDataSet6;
        //private HMS_DatabaseDataSetTableAdapters.DOCTORSTableAdapter dOCTORSTableAdapter;
        //private HMS_DatabaseDataSet hMS_DatabaseDataSet;
        public System.Windows.Forms.BindingSource dOCTORSBindingSource;
        public System.Windows.Forms.ComboBox rolecbx;
        public System.Windows.Forms.ComboBox depcbx;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox priceperappointment;
    }
}

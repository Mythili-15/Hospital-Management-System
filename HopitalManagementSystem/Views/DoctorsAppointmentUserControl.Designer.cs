namespace HopitalManagementSystem
{
    partial class DoctorsAppointmentUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsAppointmentUserControl));
            label5 = new Label();
            textBoxTel = new TextBox();
            label9 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxDesignation = new TextBox();
            label3 = new Label();
            textBoxid = new TextBox();
            textBox1 = new TextBox();
            dataGridViewINP = new DataGridView();
            label2 = new Label();
            comboBoxSearchBy = new ComboBox();
            buttonCancelAppointment = new Button();
            label15 = new Label();
            label11 = new Label();
            label16 = new Label();
            textBoxAppointmentID = new TextBox();
            label17 = new Label();
            label1 = new Label();
            label10 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBoxEmail = new TextBox();
            label6 = new Label();
            textBoxDepartment = new TextBox();
            label8 = new Label();
            textBoxAddress = new TextBox();
            label7 = new Label();
            label20 = new Label();
            Content = new Panel();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            comboBoxslots = new ComboBox();
            comboBoxpatient = new ComboBox();
            comboBoxDoctor = new ComboBox();
            button1 = new Button();
            buttonReschedule = new Button();
            comboBoxGender = new ComboBox();
            button4 = new Button();
            buttonDisplay = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonInsert = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewINP).BeginInit();
            Content.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(362, 153);
            label5.Name = "label5";
            label5.Size = new Size(106, 17);
            label5.TabIndex = 0;
            label5.Text = "DESIGNATION:";
            label5.Click += label5_Click;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxTel.Location = new Point(511, 131);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(123, 16);
            textBoxTel.TabIndex = 4;
            textBoxTel.TextChanged += textBoxTel_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(362, 127);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 0;
            label9.Text = "TEL NO:";
            label9.Click += label9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(41, 171, 226);
            label4.Location = new Point(362, 99);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 0;
            label4.Text = "GENDER:";
            label4.Click += label4_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(41, 171, 226);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxName.Location = new Point(216, 131);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(123, 16);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BackColor = Color.FromArgb(41, 171, 226);
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxDesignation.Location = new Point(511, 157);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(123, 16);
            textBoxDesignation.TabIndex = 5;
            textBoxDesignation.TextChanged += textBoxDesignation_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(67, 127);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            label3.Click += label3_Click;
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.FromArgb(41, 171, 226);
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxid.Location = new Point(216, 105);
            textBoxid.Name = "textBoxid";
            textBoxid.ReadOnly = true;
            textBoxid.Size = new Size(123, 16);
            textBoxid.TabIndex = 0;
            textBoxid.TextChanged += textBoxid_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(41, 171, 226);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            textBox1.Location = new Point(1069, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 22);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
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
            dataGridViewINP.Location = new Point(46, 149);
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
            dataGridViewINP.Size = new Size(1114, 318);
            dataGridViewINP.TabIndex = 13;
            dataGridViewINP.CellContentClick += dataGridViewINP_CellContentClick;
            dataGridViewINP.RowHeaderMouseClick += dataGridViewINP_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(160, 37);
            label2.TabIndex = 1;
            label2.Text = "PATIENT";
            label2.Click += label2_Click;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearchBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxSearchBy.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.Font = new Font("Microsoft Sans Serif", 14F);
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Appointment Id", "Patient Id", "Patient Name", "Doctor Name", "Pat Number" });
            comboBoxSearchBy.Location = new Point(682, 86);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(136, 32);
            comboBoxSearchBy.TabIndex = 3;
            comboBoxSearchBy.SelectedIndexChanged += comboBoxSearchBy_SelectedIndexChanged;
            // 
            // buttonCancelAppointment
            // 
            buttonCancelAppointment.BackColor = Color.FromArgb(41, 171, 226);
            buttonCancelAppointment.FlatStyle = FlatStyle.Flat;
            buttonCancelAppointment.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonCancelAppointment.ForeColor = Color.FromArgb(0, 7, 13);
            buttonCancelAppointment.Image = (Image)resources.GetObject("buttonCancelAppointment.Image");
            buttonCancelAppointment.Location = new Point(837, 559);
            buttonCancelAppointment.Name = "buttonCancelAppointment";
            buttonCancelAppointment.Size = new Size(330, 50);
            buttonCancelAppointment.TabIndex = 10;
            buttonCancelAppointment.Text = " CANCEL APPOINTMENT";
            buttonCancelAppointment.TextAlign = ContentAlignment.MiddleRight;
            buttonCancelAppointment.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancelAppointment.UseVisualStyleBackColor = false;
            buttonCancelAppointment.Click += buttonCancelAppointment_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(41, 171, 226);
            label15.Location = new Point(45, 546);
            label15.Name = "label15";
            label15.Size = new Size(58, 24);
            label15.TabIndex = 0;
            label15.Text = "Date:";
            label15.Click += label15_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(41, 171, 226);
            label11.Location = new Point(45, 509);
            label11.Name = "label11";
            label11.Size = new Size(61, 24);
            label11.TabIndex = 0;
            label11.Text = "Slots:";
            label11.Click += label11_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(41, 171, 226);
            label16.Location = new Point(45, 585);
            label16.Name = "label16";
            label16.Size = new Size(103, 24);
            label16.TabIndex = 0;
            label16.Text = "PATIENT:";
            label16.Click += label16_Click;
            // 
            // textBoxAppointmentID
            // 
            textBoxAppointmentID.BackColor = Color.FromArgb(41, 171, 226);
            textBoxAppointmentID.BorderStyle = BorderStyle.None;
            textBoxAppointmentID.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            textBoxAppointmentID.Location = new Point(294, 92);
            textBoxAppointmentID.Name = "textBoxAppointmentID";
            textBoxAppointmentID.ReadOnly = true;
            textBoxAppointmentID.Size = new Size(203, 22);
            textBoxAppointmentID.TabIndex = 0;
            textBoxAppointmentID.TextChanged += textBoxAppointmentID_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14F);
            label17.ForeColor = Color.FromArgb(41, 171, 226);
            label17.Location = new Point(505, 92);
            label17.Name = "label17";
            label17.Size = new Size(122, 24);
            label17.TabIndex = 0;
            label17.Text = "SEARCH BY:";
            label17.Click += label17_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(67, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID:";
            label1.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(41, 171, 226);
            label10.Location = new Point(45, 473);
            label10.Name = "label10";
            label10.Size = new Size(103, 24);
            label10.TabIndex = 0;
            label10.Text = "DOCTOR:";
            label10.Click += label10_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 14F);
            label18.ForeColor = Color.FromArgb(41, 171, 226);
            label18.Location = new Point(824, 89);
            label18.Name = "label18";
            label18.Size = new Size(160, 24);
            label18.TabIndex = 0;
            label18.Text = "SEARCH VALUE:";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(41, 171, 226);
            label19.Location = new Point(67, 89);
            label19.Name = "label19";
            label19.Size = new Size(189, 24);
            label19.TabIndex = 0;
            label19.Text = "APPOINTMENT ID:";
            label19.Click += label19_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxEmail.Location = new Point(216, 183);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(418, 16);
            textBoxEmail.TabIndex = 6;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(67, 179);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 0;
            label6.Text = "EMAIL:";
            label6.Click += label6_Click;
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.BackColor = Color.FromArgb(41, 171, 226);
            textBoxDepartment.BorderStyle = BorderStyle.None;
            textBoxDepartment.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxDepartment.Location = new Point(216, 157);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(123, 16);
            textBoxDepartment.TabIndex = 2;
            textBoxDepartment.TextChanged += textBoxDepartment_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(67, 153);
            label8.Name = "label8";
            label8.Size = new Size(107, 17);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
            label8.Click += label8_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(41, 171, 226);
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxAddress.Location = new Point(216, 209);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(418, 56);
            textBoxAddress.TabIndex = 7;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(41, 171, 226);
            label7.Location = new Point(67, 205);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 0;
            label7.Text = "ADDRESS:";
            label7.Click += label7_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(41, 171, 226);
            label20.Location = new Point(19, 20);
            label20.Name = "label20";
            label20.Size = new Size(282, 37);
            label20.TabIndex = 1;
            label20.Text = "APPOINTMENTS";
            label20.Click += label20_Click;
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
            Content.Name = "Content";
            Content.Size = new Size(1264, 626);
            Content.TabIndex = 8;
            Content.Paint += Content_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 13);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBoxslots);
            panel1.Controls.Add(comboBoxpatient);
            panel1.Controls.Add(comboBoxDoctor);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridViewINP);
            panel1.Controls.Add(comboBoxSearchBy);
            panel1.Controls.Add(buttonReschedule);
            panel1.Controls.Add(buttonCancelAppointment);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBoxAppointmentID);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 626);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(221, 549);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 26);
            dateTimePicker1.TabIndex = 22;
            // 
            // comboBoxslots
            // 
            comboBoxslots.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxslots.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxslots.FlatStyle = FlatStyle.Flat;
            comboBoxslots.Font = new Font("Segoe UI", 13.8F);
            comboBoxslots.FormattingEnabled = true;
            comboBoxslots.Items.AddRange(new object[] { "B", "G", "1", "2", "3", "4" });
            comboBoxslots.Location = new Point(221, 510);
            comboBoxslots.Name = "comboBoxslots";
            comboBoxslots.Size = new Size(254, 33);
            comboBoxslots.TabIndex = 21;
            comboBoxslots.SelectedIndexChanged += comboBoxslots_SelectedIndexChanged;
            // 
            // comboBoxpatient
            // 
            comboBoxpatient.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxpatient.FlatStyle = FlatStyle.Flat;
            comboBoxpatient.Font = new Font("Microsoft Sans Serif", 12F);
            comboBoxpatient.FormattingEnabled = true;
            comboBoxpatient.Location = new Point(221, 585);
            comboBoxpatient.Name = "comboBoxpatient";
            comboBoxpatient.Size = new Size(254, 28);
            comboBoxpatient.TabIndex = 20;
            comboBoxpatient.SelectedIndexChanged += comboBoxpatient_SelectedIndexChanged;
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDoctor.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxDoctor.FlatStyle = FlatStyle.Flat;
            comboBoxDoctor.Font = new Font("Segoe UI", 13.8F);
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Items.AddRange(new object[] { "B", "G", "1", "2", "3", "4" });
            comboBoxDoctor.Location = new Point(221, 469);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(254, 33);
            comboBoxDoctor.TabIndex = 19;
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            comboBoxDoctor.SelectionChangeCommitted += comboBoxDoctor_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 171, 226);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 7, 13);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(837, 502);
            button1.Name = "button1";
            button1.Size = new Size(330, 50);
            button1.TabIndex = 18;
            button1.Text = "Appoint";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonReschedule
            // 
            buttonReschedule.BackColor = Color.FromArgb(41, 171, 226);
            buttonReschedule.FlatStyle = FlatStyle.Flat;
            buttonReschedule.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonReschedule.ForeColor = Color.FromArgb(0, 7, 13);
            buttonReschedule.Image = (Image)resources.GetObject("buttonReschedule.Image");
            buttonReschedule.Location = new Point(494, 559);
            buttonReschedule.Name = "buttonReschedule";
            buttonReschedule.Size = new Size(330, 50);
            buttonReschedule.TabIndex = 10;
            buttonReschedule.Text = "RESCHEDULE APPOINTMENT";
            buttonReschedule.TextAlign = ContentAlignment.MiddleRight;
            buttonReschedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReschedule.UseVisualStyleBackColor = false;
            buttonReschedule.Click += buttonReschedule_Click;
            // 
            // comboBoxGender
            // 
            comboBoxGender.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxGender.FlatStyle = FlatStyle.Flat;
            comboBoxGender.Font = new Font("Microsoft Sans Serif", 6F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            comboBoxGender.Location = new Point(511, 103);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(123, 17);
            comboBoxGender.TabIndex = 3;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 171, 226);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 7, 13);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(971, 261);
            button4.Name = "button4";
            button4.Size = new Size(259, 46);
            button4.TabIndex = 5;
            button4.Text = "Add New Patient";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonDisplay
            // 
            buttonDisplay.BackColor = Color.FromArgb(41, 171, 226);
            buttonDisplay.FlatStyle = FlatStyle.Flat;
            buttonDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonDisplay.ForeColor = Color.FromArgb(0, 7, 13);
            buttonDisplay.Image = (Image)resources.GetObject("buttonDisplay.Image");
            buttonDisplay.Location = new Point(971, 157);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(259, 46);
            buttonDisplay.TabIndex = 5;
            buttonDisplay.Text = " Display Data";
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
            buttonUpdate.Location = new Point(706, 157);
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
            buttonDelete.Location = new Point(971, 105);
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
            buttonInsert.Location = new Point(706, 105);
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
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 22F);
            textBoxSearch.Location = new Point(706, 262);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(259, 34);
            textBoxSearch.TabIndex = 11;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // DoctorsAppointmentUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(Content);
            Name = "DoctorsAppointmentUserControl";
            Size = new Size(1264, 626);
            Load += DoctorsAppointmentUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewINP).EndInit();
            Content.ResumeLayout(false);
            Content.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxDesignation;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxid;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridViewINP;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.Button buttonCancelAppointment;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxAppointmentID;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxDepartment;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button buttonDisplay;
        public System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Button buttonInsert;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.Button buttonReschedule;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBoxDoctor;
        public System.Windows.Forms.ComboBox comboBoxslots;
        public System.Windows.Forms.ComboBox comboBoxpatient;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

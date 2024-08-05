namespace HopitalManagementSystem
{
    partial class RoomCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomCRUD));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBoxid = new TextBox();
            comboBoxSearchBy = new ComboBox();
            comboBoxType = new ComboBox();
            buttonRoomDisplay = new Button();
            buttonRoomUpdate = new Button();
            buttonRoomDelete = new Button();
            buttonRoomInsert = new Button();
            label10 = new Label();
            textBoxDesignation = new TextBox();
            textBoxTel = new TextBox();
            label9 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label11 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label16 = new Label();
            textBoxRoomID = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBoxSearch = new TextBox();
            label1 = new Label();
            Content = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            textBoxSearchValue = new TextBox();
            comboBoxFloorNo = new ComboBox();
            comboBoxStatus = new ComboBox();
            label12 = new Label();
            textBoxPrice = new TextBox();
            textBoxRoomNo = new TextBox();
            label13 = new Label();
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
            textBoxAddress = new TextBox();
            label2 = new Label();
            rOOMBindingSource = new BindingSource(components);
            Content.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rOOMBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.FromArgb(41, 171, 226);
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxid.Location = new Point(216, 105);
            textBoxid.Name = "textBoxid";
            textBoxid.ReadOnly = true;
            textBoxid.Size = new Size(123, 24);
            textBoxid.TabIndex = 0;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSearchBy.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxSearchBy.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxSearchBy.FlatStyle = FlatStyle.Flat;
            comboBoxSearchBy.Font = new Font("Segoe UI", 13.8F);
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Room No", "Type", "Floor No", "Price" });
            comboBoxSearchBy.Location = new Point(225, 440);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(272, 46);
            comboBoxSearchBy.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxType.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Segoe UI", 13.8F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Deluxe", "Private", "Ward" });
            comboBoxType.Location = new Point(243, 215);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(254, 46);
            comboBoxType.TabIndex = 3;
            // 
            // buttonRoomDisplay
            // 
            buttonRoomDisplay.BackColor = Color.FromArgb(41, 171, 226);
            buttonRoomDisplay.FlatStyle = FlatStyle.Flat;
            buttonRoomDisplay.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonRoomDisplay.ForeColor = Color.FromArgb(0, 7, 13);
            buttonRoomDisplay.Image = (Image)resources.GetObject("buttonRoomDisplay.Image");
            buttonRoomDisplay.Location = new Point(287, 391);
            buttonRoomDisplay.Name = "buttonRoomDisplay";
            buttonRoomDisplay.Size = new Size(210, 43);
            buttonRoomDisplay.TabIndex = 5;
            buttonRoomDisplay.Text = " DISPLAY ROOM";
            buttonRoomDisplay.TextAlign = ContentAlignment.MiddleRight;
            buttonRoomDisplay.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoomDisplay.UseVisualStyleBackColor = false;
            buttonRoomDisplay.Click += buttonRoomDisplay_Click;
            // 
            // buttonRoomUpdate
            // 
            buttonRoomUpdate.BackColor = Color.FromArgb(41, 171, 226);
            buttonRoomUpdate.FlatStyle = FlatStyle.Flat;
            buttonRoomUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonRoomUpdate.ForeColor = Color.FromArgb(0, 7, 13);
            buttonRoomUpdate.Image = (Image)resources.GetObject("buttonRoomUpdate.Image");
            buttonRoomUpdate.Location = new Point(71, 391);
            buttonRoomUpdate.Name = "buttonRoomUpdate";
            buttonRoomUpdate.Size = new Size(210, 43);
            buttonRoomUpdate.TabIndex = 9;
            buttonRoomUpdate.Text = " UPDATE ROOM";
            buttonRoomUpdate.TextAlign = ContentAlignment.MiddleRight;
            buttonRoomUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoomUpdate.UseVisualStyleBackColor = false;
            buttonRoomUpdate.Click += buttonRoomUpdate_Click;
            // 
            // buttonRoomDelete
            // 
            buttonRoomDelete.BackColor = Color.FromArgb(41, 171, 226);
            buttonRoomDelete.FlatStyle = FlatStyle.Flat;
            buttonRoomDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonRoomDelete.ForeColor = Color.FromArgb(0, 7, 13);
            buttonRoomDelete.Image = (Image)resources.GetObject("buttonRoomDelete.Image");
            buttonRoomDelete.Location = new Point(287, 342);
            buttonRoomDelete.Name = "buttonRoomDelete";
            buttonRoomDelete.Size = new Size(210, 43);
            buttonRoomDelete.TabIndex = 10;
            buttonRoomDelete.Text = " DELETE ROOM";
            buttonRoomDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonRoomDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoomDelete.UseVisualStyleBackColor = false;
            buttonRoomDelete.Click += buttonRoomDelete_Click;
            // 
            // buttonRoomInsert
            // 
            buttonRoomInsert.BackColor = Color.FromArgb(41, 171, 226);
            buttonRoomInsert.FlatStyle = FlatStyle.Flat;
            buttonRoomInsert.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonRoomInsert.ForeColor = Color.FromArgb(0, 7, 13);
            buttonRoomInsert.Image = (Image)resources.GetObject("buttonRoomInsert.Image");
            buttonRoomInsert.Location = new Point(71, 342);
            buttonRoomInsert.Name = "buttonRoomInsert";
            buttonRoomInsert.Size = new Size(210, 43);
            buttonRoomInsert.TabIndex = 8;
            buttonRoomInsert.Text = " INSERT ROOM";
            buttonRoomInsert.TextAlign = ContentAlignment.MiddleRight;
            buttonRoomInsert.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRoomInsert.UseVisualStyleBackColor = false;
            buttonRoomInsert.Click += buttonRoomInsert_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(41, 171, 226);
            label10.Location = new Point(67, 258);
            label10.Name = "label10";
            label10.Size = new Size(194, 32);
            label10.TabIndex = 0;
            label10.Text = "FLOOR NO. :";
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.BackColor = Color.FromArgb(41, 171, 226);
            textBoxDesignation.BorderStyle = BorderStyle.None;
            textBoxDesignation.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxDesignation.Location = new Point(511, 157);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(123, 24);
            textBoxDesignation.TabIndex = 5;
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.FromArgb(41, 171, 226);
            textBoxTel.BorderStyle = BorderStyle.None;
            textBoxTel.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxTel.Location = new Point(511, 131);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(123, 24);
            textBoxTel.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(41, 171, 226);
            label9.Location = new Point(362, 127);
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
            label4.Location = new Point(362, 99);
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
            textBoxName.Location = new Point(216, 131);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(123, 24);
            textBoxName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(41, 171, 226);
            label11.Location = new Point(67, 216);
            label11.Name = "label11";
            label11.Size = new Size(200, 32);
            label11.TabIndex = 0;
            label11.Text = "ROOM TYPE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(41, 171, 226);
            label7.Location = new Point(67, 205);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 0;
            label7.Text = "ADDRESS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(41, 171, 226);
            label5.Location = new Point(362, 153);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 0;
            label5.Text = "DESIGNATION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(41, 171, 226);
            label3.Location = new Point(67, 127);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "NAME:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(41, 171, 226);
            label16.Location = new Point(67, 171);
            label16.Name = "label16";
            label16.Size = new Size(140, 32);
            label16.TabIndex = 0;
            label16.Text = "STATUS:";
            // 
            // textBoxRoomID
            // 
            textBoxRoomID.BackColor = Color.FromArgb(41, 171, 226);
            textBoxRoomID.BorderStyle = BorderStyle.None;
            textBoxRoomID.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomID.Location = new Point(243, 96);
            textBoxRoomID.Name = "textBoxRoomID";
            textBoxRoomID.ReadOnly = true;
            textBoxRoomID.Size = new Size(254, 37);
            textBoxRoomID.TabIndex = 0;
            textBoxRoomID.TextChanged += textBoxRoomID_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 14F);
            label17.ForeColor = Color.FromArgb(41, 171, 226);
            label17.Location = new Point(67, 440);
            label17.Name = "label17";
            label17.Size = new Size(184, 32);
            label17.TabIndex = 0;
            label17.Text = "SEARCH BY:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 14F);
            label18.ForeColor = Color.FromArgb(41, 171, 226);
            label18.Location = new Point(67, 485);
            label18.Name = "label18";
            label18.Size = new Size(239, 32);
            label18.TabIndex = 0;
            label18.Text = "SEARCH VALUE:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(41, 171, 226);
            label19.Location = new Point(67, 93);
            label19.Name = "label19";
            label19.Size = new Size(151, 32);
            label19.TabIndex = 0;
            label19.Text = "ROOM ID:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.FromArgb(41, 171, 226);
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 22F);
            textBoxSearch.Location = new Point(706, 262);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(259, 50);
            textBoxSearch.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 171, 226);
            label1.Location = new Point(67, 101);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "DOCTOR ID:";
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
            Content.Size = new Size(1261, 550);
            Content.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 7, 13);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBoxSearchValue);
            panel1.Controls.Add(comboBoxSearchBy);
            panel1.Controls.Add(comboBoxFloorNo);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(comboBoxType);
            panel1.Controls.Add(buttonRoomDisplay);
            panel1.Controls.Add(buttonRoomUpdate);
            panel1.Controls.Add(buttonRoomDelete);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(buttonRoomInsert);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(textBoxRoomNo);
            panel1.Controls.Add(textBoxRoomID);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 550);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
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
            dataGridView1.Location = new Point(511, 93);
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
            dataGridView1.Size = new Size(625, 437);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // textBoxSearchValue
            // 
            textBoxSearchValue.BackColor = Color.FromArgb(41, 171, 226);
            textBoxSearchValue.BorderStyle = BorderStyle.None;
            textBoxSearchValue.Font = new Font("Segoe UI", 16F);
            textBoxSearchValue.Location = new Point(271, 487);
            textBoxSearchValue.Name = "textBoxSearchValue";
            textBoxSearchValue.Size = new Size(226, 43);
            textBoxSearchValue.TabIndex = 11;
            textBoxSearchValue.TextChanged += textBoxSearchValue_TextChanged;
            // 
            // comboBoxFloorNo
            // 
            comboBoxFloorNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFloorNo.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxFloorNo.FlatStyle = FlatStyle.Flat;
            comboBoxFloorNo.Font = new Font("Segoe UI", 13.8F);
            comboBoxFloorNo.FormattingEnabled = true;
            comboBoxFloorNo.Items.AddRange(new object[] { "B", "G", "1", "2", "3", "4" });
            comboBoxFloorNo.Location = new Point(243, 260);
            comboBoxFloorNo.Name = "comboBoxFloorNo";
            comboBoxFloorNo.Size = new Size(254, 46);
            comboBoxFloorNo.TabIndex = 3;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxStatus.BackColor = Color.FromArgb(41, 171, 226);
            comboBoxStatus.FlatStyle = FlatStyle.Flat;
            comboBoxStatus.Font = new Font("Segoe UI", 13.8F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Available", "Unavailable" });
            comboBoxStatus.Location = new Point(243, 170);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(254, 46);
            comboBoxStatus.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(41, 171, 226);
            label12.Location = new Point(67, 302);
            label12.Name = "label12";
            label12.Size = new Size(251, 32);
            label12.TabIndex = 0;
            label12.Text = "PRICE PER DAY:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.FromArgb(41, 171, 226);
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Font = new Font("Segoe UI", 13.8F);
            textBoxPrice.Location = new Point(288, 305);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(209, 37);
            textBoxPrice.TabIndex = 0;
            // 
            // textBoxRoomNo
            // 
            textBoxRoomNo.BackColor = Color.FromArgb(41, 171, 226);
            textBoxRoomNo.BorderStyle = BorderStyle.None;
            textBoxRoomNo.Font = new Font("Segoe UI", 13.8F);
            textBoxRoomNo.Location = new Point(243, 133);
            textBoxRoomNo.Name = "textBoxRoomNo";
            textBoxRoomNo.Size = new Size(254, 37);
            textBoxRoomNo.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(41, 171, 226);
            label13.Location = new Point(67, 130);
            label13.Name = "label13";
            label13.Size = new Size(166, 32);
            label13.TabIndex = 0;
            label13.Text = "ROOM NO:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(41, 171, 226);
            label20.Location = new Point(19, 20);
            label20.Name = "label20";
            label20.Size = new Size(210, 55);
            label20.TabIndex = 1;
            label20.Text = "ROOMS";
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
            comboBoxGender.Size = new Size(123, 23);
            comboBoxGender.TabIndex = 3;
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
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(41, 171, 226);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            textBoxEmail.Location = new Point(216, 183);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(418, 24);
            textBoxEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(41, 171, 226);
            label6.Location = new Point(67, 179);
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
            textBoxDepartment.Location = new Point(216, 157);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(123, 24);
            textBoxDepartment.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(41, 171, 226);
            label8.Location = new Point(67, 153);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 0;
            label8.Text = "DEPARTMENT:";
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 171, 226);
            label2.Location = new Point(19, 20);
            label2.Name = "label2";
            label2.Size = new Size(233, 55);
            label2.TabIndex = 1;
            label2.Text = "PATIENT";
            // 
            // rOOMBindingSource
            // 
            rOOMBindingSource.DataMember = "ROOM";
            // 
            // RoomCRUD
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(Content);
            Name = "RoomCRUD";
            Size = new Size(1261, 550);
            Content.ResumeLayout(false);
            Content.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rOOMBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.TextBox textBoxid;
        public System.Windows.Forms.ComboBox comboBoxSearchBy;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.Button buttonRoomDisplay;
        public System.Windows.Forms.Button buttonRoomUpdate;
        public System.Windows.Forms.Button buttonRoomDelete;
        public System.Windows.Forms.Button buttonRoomInsert;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBoxDesignation;
        public System.Windows.Forms.TextBox textBoxTel;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxRoomID;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel Content;
        public System.Windows.Forms.Panel panel1;
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
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxStatus;
        public System.Windows.Forms.ComboBox comboBoxFloorNo;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxRoomNo;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.BindingSource rOOMBindingSource;
        //private HMS_DatabaseDataSet3 hMS_DatabaseDataSet3;
        //private HMS_DatabaseDataSet3TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        public System.Windows.Forms.TextBox textBoxSearchValue;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

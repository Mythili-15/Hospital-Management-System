namespace HopitalManagementSystem
{
    partial class AdminSidebarUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSidebarUserControl));
            Content = new Panel();
            buttonDoctor = new Button();
            buttonBilling = new Button();
            buttonPatient = new Button();
            Content.SuspendLayout();
            SuspendLayout();
            // 
            // Content
            // 
            Content.BackColor = Color.FromArgb(0, 21, 41);
            Content.Controls.Add(buttonDoctor);
            Content.Controls.Add(buttonBilling);
            Content.Controls.Add(buttonPatient);
            Content.Dock = DockStyle.Left;
            Content.Location = new Point(0, 0);
            Content.Name = "Content";
            Content.Size = new Size(98, 349);
            Content.TabIndex = 4;
            // 
            // buttonDoctor
            // 
            buttonDoctor.Anchor = AnchorStyles.None;
            buttonDoctor.BackColor = Color.FromArgb(0, 21, 41);
            buttonDoctor.BackgroundImage = (Image)resources.GetObject("buttonDoctor.BackgroundImage");
            buttonDoctor.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDoctor.FlatAppearance.BorderSize = 0;
            buttonDoctor.FlatStyle = FlatStyle.Flat;
            buttonDoctor.Location = new Point(30, 57);
            buttonDoctor.Margin = new Padding(5);
            buttonDoctor.Name = "buttonDoctor";
            buttonDoctor.Padding = new Padding(5);
            buttonDoctor.Size = new Size(39, 37);
            buttonDoctor.TabIndex = 3;
            buttonDoctor.UseVisualStyleBackColor = false;
            buttonDoctor.Click += buttonDoctor_Click;
            // 
            // buttonBilling
            // 
            buttonBilling.Anchor = AnchorStyles.None;
            buttonBilling.BackColor = Color.FromArgb(0, 21, 41);
            buttonBilling.BackgroundImage = (Image)resources.GetObject("buttonBilling.BackgroundImage");
            buttonBilling.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBilling.FlatAppearance.BorderSize = 0;
            buttonBilling.FlatStyle = FlatStyle.Flat;
            buttonBilling.Location = new Point(30, 246);
            buttonBilling.Margin = new Padding(5);
            buttonBilling.Name = "buttonBilling";
            buttonBilling.Padding = new Padding(5);
            buttonBilling.Size = new Size(39, 37);
            buttonBilling.TabIndex = 4;
            buttonBilling.UseVisualStyleBackColor = false;
            buttonBilling.Click += buttonBilling_Click;
            // 
            // buttonPatient
            // 
            buttonPatient.Anchor = AnchorStyles.None;
            buttonPatient.BackColor = Color.FromArgb(0, 21, 41);
            buttonPatient.BackgroundImage = (Image)resources.GetObject("buttonPatient.BackgroundImage");
            buttonPatient.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPatient.FlatAppearance.BorderSize = 0;
            buttonPatient.FlatStyle = FlatStyle.Flat;
            buttonPatient.Location = new Point(30, 149);
            buttonPatient.Margin = new Padding(5);
            buttonPatient.Name = "buttonPatient";
            buttonPatient.Padding = new Padding(5);
            buttonPatient.Size = new Size(39, 37);
            buttonPatient.TabIndex = 4;
            buttonPatient.UseVisualStyleBackColor = false;
            buttonPatient.Click += buttonPatient_Click;
            // 
            // AdminSidebarUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(Content);
            Name = "AdminSidebarUserControl";
            Size = new Size(98, 349);
            Content.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button buttonDoctor;
        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Button buttonBilling;
    }
}

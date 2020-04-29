namespace AirplaneFinalProject
{
    partial class BetterBoarding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetterBoarding));
            this.exitButton = new System.Windows.Forms.Button();
            this.plane1PictureBox = new System.Windows.Forms.PictureBox();
            this.queue1ListBox = new System.Windows.Forms.ListBox();
            this.generatePassengersButton = new System.Windows.Forms.Button();
            this.steffenPerfRadio = new System.Windows.Forms.RadioButton();
            this.queueButton = new System.Windows.Forms.Button();
            this.passengerListBox = new System.Windows.Forms.ListBox();
            this.sortFirstNameButton = new System.Windows.Forms.Button();
            this.sortLastNameButton = new System.Windows.Forms.Button();
            this.sortSeatButton = new System.Windows.Forms.Button();
            this.steffenModRadio = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.planeTwoRadio = new System.Windows.Forms.RadioButton();
            this.planeOneRadio = new System.Windows.Forms.RadioButton();
            this.methodGroupBox = new System.Windows.Forms.GroupBox();
            this.planeGroupBox = new System.Windows.Forms.GroupBox();
            this.plane2PictureBox = new System.Windows.Forms.PictureBox();
            this.queue2ListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.plane1PictureBox)).BeginInit();
            this.methodGroupBox.SuspendLayout();
            this.planeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plane2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(772, 588);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // plane1PictureBox
            // 
            this.plane1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("plane1PictureBox.Image")));
            this.plane1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.plane1PictureBox.Name = "plane1PictureBox";
            this.plane1PictureBox.Size = new System.Drawing.Size(835, 185);
            this.plane1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plane1PictureBox.TabIndex = 1;
            this.plane1PictureBox.TabStop = false;
            // 
            // queue1ListBox
            // 
            this.queue1ListBox.FormattingEnabled = true;
            this.queue1ListBox.Location = new System.Drawing.Point(208, 203);
            this.queue1ListBox.Name = "queue1ListBox";
            this.queue1ListBox.Size = new System.Drawing.Size(190, 264);
            this.queue1ListBox.TabIndex = 2;
            // 
            // generatePassengersButton
            // 
            this.generatePassengersButton.BackColor = System.Drawing.Color.Aqua;
            this.generatePassengersButton.ForeColor = System.Drawing.Color.Black;
            this.generatePassengersButton.Location = new System.Drawing.Point(12, 473);
            this.generatePassengersButton.Name = "generatePassengersButton";
            this.generatePassengersButton.Size = new System.Drawing.Size(190, 23);
            this.generatePassengersButton.TabIndex = 3;
            this.generatePassengersButton.Text = "Generate Passengers";
            this.generatePassengersButton.UseVisualStyleBackColor = false;
            this.generatePassengersButton.Click += new System.EventHandler(this.generatePassengersButton_Click);
            // 
            // steffenPerfRadio
            // 
            this.steffenPerfRadio.AutoSize = true;
            this.steffenPerfRadio.Checked = true;
            this.steffenPerfRadio.Location = new System.Drawing.Point(6, 19);
            this.steffenPerfRadio.Name = "steffenPerfRadio";
            this.steffenPerfRadio.Size = new System.Drawing.Size(135, 17);
            this.steffenPerfRadio.TabIndex = 4;
            this.steffenPerfRadio.TabStop = true;
            this.steffenPerfRadio.Text = "Steffen Perfect Method";
            this.steffenPerfRadio.UseVisualStyleBackColor = true;
            // 
            // queueButton
            // 
            this.queueButton.BackColor = System.Drawing.Color.Lime;
            this.queueButton.Location = new System.Drawing.Point(208, 473);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(190, 23);
            this.queueButton.TabIndex = 5;
            this.queueButton.Text = "Queue up passengers";
            this.queueButton.UseVisualStyleBackColor = false;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // passengerListBox
            // 
            this.passengerListBox.FormattingEnabled = true;
            this.passengerListBox.Location = new System.Drawing.Point(12, 203);
            this.passengerListBox.Name = "passengerListBox";
            this.passengerListBox.Size = new System.Drawing.Size(190, 264);
            this.passengerListBox.TabIndex = 6;
            // 
            // sortFirstNameButton
            // 
            this.sortFirstNameButton.Location = new System.Drawing.Point(12, 502);
            this.sortFirstNameButton.Name = "sortFirstNameButton";
            this.sortFirstNameButton.Size = new System.Drawing.Size(190, 23);
            this.sortFirstNameButton.TabIndex = 7;
            this.sortFirstNameButton.Text = "Sort by First Name";
            this.sortFirstNameButton.UseVisualStyleBackColor = true;
            this.sortFirstNameButton.Click += new System.EventHandler(this.sortFirstNameButton_Click);
            // 
            // sortLastNameButton
            // 
            this.sortLastNameButton.Location = new System.Drawing.Point(12, 531);
            this.sortLastNameButton.Name = "sortLastNameButton";
            this.sortLastNameButton.Size = new System.Drawing.Size(190, 23);
            this.sortLastNameButton.TabIndex = 8;
            this.sortLastNameButton.Text = "Sort by Last Name";
            this.sortLastNameButton.UseVisualStyleBackColor = true;
            this.sortLastNameButton.Click += new System.EventHandler(this.sortLastNameButton_Click);
            // 
            // sortSeatButton
            // 
            this.sortSeatButton.Location = new System.Drawing.Point(12, 560);
            this.sortSeatButton.Name = "sortSeatButton";
            this.sortSeatButton.Size = new System.Drawing.Size(190, 23);
            this.sortSeatButton.TabIndex = 9;
            this.sortSeatButton.Text = "Sort by Seat";
            this.sortSeatButton.UseVisualStyleBackColor = true;
            this.sortSeatButton.Click += new System.EventHandler(this.sortSeatButton_Click);
            // 
            // steffenModRadio
            // 
            this.steffenModRadio.AutoSize = true;
            this.steffenModRadio.Location = new System.Drawing.Point(6, 42);
            this.steffenModRadio.Name = "steffenModRadio";
            this.steffenModRadio.Size = new System.Drawing.Size(141, 17);
            this.steffenModRadio.TabIndex = 10;
            this.steffenModRadio.TabStop = true;
            this.steffenModRadio.Text = "Steffen Modified Method";
            this.steffenModRadio.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 601);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(351, 13);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "To understand more: https://www.youtube.com/watch?v=oAHbLRjF0vo";
            // 
            // planeTwoRadio
            // 
            this.planeTwoRadio.AutoSize = true;
            this.planeTwoRadio.Location = new System.Drawing.Point(6, 42);
            this.planeTwoRadio.Name = "planeTwoRadio";
            this.planeTwoRadio.Size = new System.Drawing.Size(103, 17);
            this.planeTwoRadio.TabIndex = 13;
            this.planeTwoRadio.TabStop = true;
            this.planeTwoRadio.Text = "Two-Lane Plane";
            this.planeTwoRadio.UseVisualStyleBackColor = true;
            this.planeTwoRadio.CheckedChanged += new System.EventHandler(this.planeTwoRadio_CheckedChanged);
            // 
            // planeOneRadio
            // 
            this.planeOneRadio.AutoSize = true;
            this.planeOneRadio.Checked = true;
            this.planeOneRadio.Location = new System.Drawing.Point(6, 19);
            this.planeOneRadio.Name = "planeOneRadio";
            this.planeOneRadio.Size = new System.Drawing.Size(102, 17);
            this.planeOneRadio.TabIndex = 12;
            this.planeOneRadio.TabStop = true;
            this.planeOneRadio.Text = "One-Lane Plane";
            this.planeOneRadio.UseVisualStyleBackColor = true;
            this.planeOneRadio.CheckedChanged += new System.EventHandler(this.planeOneRadio_CheckedChanged);
            // 
            // methodGroupBox
            // 
            this.methodGroupBox.Controls.Add(this.steffenPerfRadio);
            this.methodGroupBox.Controls.Add(this.steffenModRadio);
            this.methodGroupBox.Location = new System.Drawing.Point(600, 203);
            this.methodGroupBox.Name = "methodGroupBox";
            this.methodGroupBox.Size = new System.Drawing.Size(146, 59);
            this.methodGroupBox.TabIndex = 14;
            this.methodGroupBox.TabStop = false;
            this.methodGroupBox.Text = "Boarding Method";
            // 
            // planeGroupBox
            // 
            this.planeGroupBox.Controls.Add(this.planeOneRadio);
            this.planeGroupBox.Controls.Add(this.planeTwoRadio);
            this.planeGroupBox.Location = new System.Drawing.Point(600, 268);
            this.planeGroupBox.Name = "planeGroupBox";
            this.planeGroupBox.Size = new System.Drawing.Size(113, 59);
            this.planeGroupBox.TabIndex = 15;
            this.planeGroupBox.TabStop = false;
            this.planeGroupBox.Text = "Airplane Model";
            // 
            // plane2PictureBox
            // 
            this.plane2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("plane2PictureBox.Image")));
            this.plane2PictureBox.Location = new System.Drawing.Point(12, 12);
            this.plane2PictureBox.Name = "plane2PictureBox";
            this.plane2PictureBox.Size = new System.Drawing.Size(835, 185);
            this.plane2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plane2PictureBox.TabIndex = 16;
            this.plane2PictureBox.TabStop = false;
            this.plane2PictureBox.Visible = false;
            // 
            // queue2ListBox
            // 
            this.queue2ListBox.FormattingEnabled = true;
            this.queue2ListBox.Location = new System.Drawing.Point(404, 203);
            this.queue2ListBox.Name = "queue2ListBox";
            this.queue2ListBox.Size = new System.Drawing.Size(190, 264);
            this.queue2ListBox.TabIndex = 17;
            // 
            // BetterBoarding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 623);
            this.Controls.Add(this.queue2ListBox);
            this.Controls.Add(this.plane2PictureBox);
            this.Controls.Add(this.planeGroupBox);
            this.Controls.Add(this.methodGroupBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.sortSeatButton);
            this.Controls.Add(this.sortLastNameButton);
            this.Controls.Add(this.sortFirstNameButton);
            this.Controls.Add(this.passengerListBox);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.generatePassengersButton);
            this.Controls.Add(this.queue1ListBox);
            this.Controls.Add(this.plane1PictureBox);
            this.Controls.Add(this.exitButton);
            this.Name = "BetterBoarding";
            this.Text = "Better Airplane Boarding";
            ((System.ComponentModel.ISupportInitialize)(this.plane1PictureBox)).EndInit();
            this.methodGroupBox.ResumeLayout(false);
            this.methodGroupBox.PerformLayout();
            this.planeGroupBox.ResumeLayout(false);
            this.planeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plane2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox plane1PictureBox;
        private System.Windows.Forms.ListBox queue1ListBox;
        private System.Windows.Forms.Button generatePassengersButton;
        private System.Windows.Forms.RadioButton steffenPerfRadio;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.ListBox passengerListBox;
        private System.Windows.Forms.Button sortFirstNameButton;
        private System.Windows.Forms.Button sortLastNameButton;
        private System.Windows.Forms.Button sortSeatButton;
        private System.Windows.Forms.RadioButton steffenModRadio;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.RadioButton planeTwoRadio;
        private System.Windows.Forms.RadioButton planeOneRadio;
        private System.Windows.Forms.GroupBox methodGroupBox;
        private System.Windows.Forms.GroupBox planeGroupBox;
        private System.Windows.Forms.PictureBox plane2PictureBox;
        private System.Windows.Forms.ListBox queue2ListBox;
    }
}


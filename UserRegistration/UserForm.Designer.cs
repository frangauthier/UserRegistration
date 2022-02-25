
namespace UserRegistration
{
    partial class UserForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EnterAddressButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(264, 287);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 44);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 37);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(74, 17);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(123, 37);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(120, 22);
            this.FirstNameTextbox.TabIndex = 2;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(123, 77);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(120, 22);
            this.LastNameTextbox.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(27, 77);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(74, 17);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last name";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(113, 124);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 6;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(205, 124);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(65, 21);
            this.otherRadioButton.TabIndex = 7;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddressLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 109);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // AddressLabel
            // 
            this.AddressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressLabel.Location = new System.Drawing.Point(7, 22);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(129, 29);
            this.AddressLabel.TabIndex = 0;
            // 
            // EnterAddressButton
            // 
            this.EnterAddressButton.Location = new System.Drawing.Point(298, 178);
            this.EnterAddressButton.Name = "EnterAddressButton";
            this.EnterAddressButton.Size = new System.Drawing.Size(75, 51);
            this.EnterAddressButton.TabIndex = 10;
            this.EnterAddressButton.Text = "Enter address";
            this.EnterAddressButton.UseVisualStyleBackColor = true;
            this.EnterAddressButton.Click += new System.EventHandler(this.EnterAddressButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 348);
            this.Controls.Add(this.EnterAddressButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.otherRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "User registration";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button EnterAddressButton;
    }
}


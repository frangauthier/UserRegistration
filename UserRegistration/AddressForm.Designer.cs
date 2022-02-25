
namespace UserRegistration
{
    partial class AddressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new address";
            // 
            // HelloLabel
            // 
            this.HelloLabel.Location = new System.Drawing.Point(16, 52);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(249, 47);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Hello";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(103, 85);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(125, 22);
            this.AddressTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(151, 196);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 40);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 277);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.TextBox AddressTextBox;
    }
}
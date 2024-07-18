namespace ACME_Web_App
{
    partial class AddCustomerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.isCapableOfLoadingLabel = new System.Windows.Forms.Label();
            this.deliveryHoursLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryHoursTextBox = new System.Windows.Forms.TextBox();
            this.isCapableOfLoadingCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(330, 146);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(320, 176);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address";
            // 
            // isCapableOfLoadingLabel
            // 
            this.isCapableOfLoadingLabel.AutoSize = true;
            this.isCapableOfLoadingLabel.Location = new System.Drawing.Point(254, 206);
            this.isCapableOfLoadingLabel.Name = "isCapableOfLoadingLabel";
            this.isCapableOfLoadingLabel.Size = new System.Drawing.Size(111, 13);
            this.isCapableOfLoadingLabel.TabIndex = 2;
            this.isCapableOfLoadingLabel.Text = "Is capable of loading?";
            // 
            // deliveryHoursLabel
            // 
            this.deliveryHoursLabel.AutoSize = true;
            this.deliveryHoursLabel.Location = new System.Drawing.Point(289, 235);
            this.deliveryHoursLabel.Name = "deliveryHoursLabel";
            this.deliveryHoursLabel.Size = new System.Drawing.Size(76, 13);
            this.deliveryHoursLabel.TabIndex = 3;
            this.deliveryHoursLabel.Text = "Delivery Hours";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(372, 146);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(371, 176);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // deliveryHoursTextBox
            // 
            this.deliveryHoursTextBox.Location = new System.Drawing.Point(372, 235);
            this.deliveryHoursTextBox.Name = "deliveryHoursTextBox";
            this.deliveryHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryHoursTextBox.TabIndex = 6;
            // 
            // isCapableOfLoadingCheckBox
            // 
            this.isCapableOfLoadingCheckBox.AutoSize = true;
            this.isCapableOfLoadingCheckBox.Location = new System.Drawing.Point(372, 206);
            this.isCapableOfLoadingCheckBox.Name = "isCapableOfLoadingCheckBox";
            this.isCapableOfLoadingCheckBox.Size = new System.Drawing.Size(107, 17);
            this.isCapableOfLoadingCheckBox.TabIndex = 7;
            this.isCapableOfLoadingCheckBox.Text = "Check box if yes.";
            this.isCapableOfLoadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isCapableOfLoadingCheckBox);
            this.Controls.Add(this.deliveryHoursTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deliveryHoursLabel);
            this.Controls.Add(this.isCapableOfLoadingLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label isCapableOfLoadingLabel;
        private System.Windows.Forms.Label deliveryHoursLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox deliveryHoursTextBox;
        private System.Windows.Forms.CheckBox isCapableOfLoadingCheckBox;
    }
}
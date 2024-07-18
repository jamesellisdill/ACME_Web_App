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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomerForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.isCapableOfLoadingLabel = new System.Windows.Forms.Label();
            this.deliveryHoursLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryHoursTextBox = new System.Windows.Forms.TextBox();
            this.isCapableOfLoadingCheckBox = new System.Windows.Forms.CheckBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(175, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(165, 142);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address";
            // 
            // isCapableOfLoadingLabel
            // 
            this.isCapableOfLoadingLabel.AutoSize = true;
            this.isCapableOfLoadingLabel.Location = new System.Drawing.Point(135, 186);
            this.isCapableOfLoadingLabel.Name = "isCapableOfLoadingLabel";
            this.isCapableOfLoadingLabel.Size = new System.Drawing.Size(111, 13);
            this.isCapableOfLoadingLabel.TabIndex = 2;
            this.isCapableOfLoadingLabel.Text = "Is capable of loading?";
            // 
            // deliveryHoursLabel
            // 
            this.deliveryHoursLabel.AutoSize = true;
            this.deliveryHoursLabel.Location = new System.Drawing.Point(165, 238);
            this.deliveryHoursLabel.Name = "deliveryHoursLabel";
            this.deliveryHoursLabel.Size = new System.Drawing.Size(76, 13);
            this.deliveryHoursLabel.TabIndex = 3;
            this.deliveryHoursLabel.Text = "Delivery Hours";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(315, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(315, 139);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // deliveryHoursTextBox
            // 
            this.deliveryHoursTextBox.Location = new System.Drawing.Point(308, 231);
            this.deliveryHoursTextBox.Name = "deliveryHoursTextBox";
            this.deliveryHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.deliveryHoursTextBox.TabIndex = 6;
            // 
            // isCapableOfLoadingCheckBox
            // 
            this.isCapableOfLoadingCheckBox.AutoSize = true;
            this.isCapableOfLoadingCheckBox.Location = new System.Drawing.Point(308, 186);
            this.isCapableOfLoadingCheckBox.Name = "isCapableOfLoadingCheckBox";
            this.isCapableOfLoadingCheckBox.Size = new System.Drawing.Size(107, 17);
            this.isCapableOfLoadingCheckBox.TabIndex = 7;
            this.isCapableOfLoadingCheckBox.Text = "Check box if yes.";
            this.isCapableOfLoadingCheckBox.UseVisualStyleBackColor = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(311, 273);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(97, 23);
            this.addCustomerButton.TabIndex = 8;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ACME_Web_App.Properties.Resources.reallysmallbackarrow2;
            this.button1.Location = new System.Drawing.Point(29, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 31);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.isCapableOfLoadingCheckBox);
            this.Controls.Add(this.deliveryHoursTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.deliveryHoursLabel);
            this.Controls.Add(this.isCapableOfLoadingLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button button1;
    }
}
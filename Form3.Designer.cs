namespace ACME_Web_App
{
    partial class PortalScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.orderButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderButton
            // 
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.Location = new System.Drawing.Point(275, 59);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(220, 66);
            this.orderButton.TabIndex = 1;
            this.orderButton.Text = "Order Portal";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // customerButton
            // 
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.Location = new System.Drawing.Point(275, 155);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(221, 67);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "Customer Portal";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.Location = new System.Drawing.Point(274, 247);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(220, 63);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin Portal";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::ACME_Web_App.Properties.Resources.reallysmallbackarrow;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(55, 32);
            this.backButton.TabIndex = 8;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::ACME_Web_App.Properties.Resources.blurlogo1;
            this.logoPictureBox.Location = new System.Drawing.Point(-8, 345);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(335, 109);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // PortalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "PortalScreen";
            this.Text = "Portal Screen";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button backButton;
    }
}

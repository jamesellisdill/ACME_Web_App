namespace ACME_Web_App
{
    partial class EditCustomerForm
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
            this.editCustomerView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editCustomerView
            // 
            this.editCustomerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.editCustomerView.HideSelection = false;
            this.editCustomerView.Location = new System.Drawing.Point(12, 47);
            this.editCustomerView.Name = "editCustomerView";
            this.editCustomerView.Size = new System.Drawing.Size(776, 392);
            this.editCustomerView.TabIndex = 0;
            this.editCustomerView.UseCompatibleStateImageBehavior = false;
            this.editCustomerView.View = System.Windows.Forms.View.Details;
            this.editCustomerView.SelectedIndexChanged += new System.EventHandler(this.editCustomerView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Is capable of loading?";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Delivery Hours";
            this.columnHeader4.Width = 120;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(693, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 29);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(309, 236);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(205, 13);
            this.refreshLabel.TabIndex = 2;
            this.refreshLabel.Text = "Click Refresh to update the Customer List!";
            // 
            // EditCustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editCustomerView);
            this.Name = "EditCustomerForm";
            this.Text = "Edit Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView editCustomerView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label refreshLabel;
    }
}
﻿namespace ACME_Web_App
{
    partial class ViewCustomerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.refreshLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(693, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 391);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // refreshLabel
            // 
            this.refreshLabel.AutoSize = true;
            this.refreshLabel.Location = new System.Drawing.Point(309, 236);
            this.refreshLabel.Name = "refreshLabel";
            this.refreshLabel.Size = new System.Drawing.Size(205, 13);
            this.refreshLabel.TabIndex = 4;
            this.refreshLabel.Text = "Click Refresh to update the Customer List!";
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
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "ViewCustomerForm";
            this.Text = "View Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label refreshLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
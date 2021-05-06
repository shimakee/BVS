
namespace Infosoft_technical
{
    partial class MainForm
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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.AddVideoButton = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(385, 96);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(251, 98);
            this.AddCustomerButton.TabIndex = 0;
            this.AddCustomerButton.Text = "Customers";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.Location = new System.Drawing.Point(85, 96);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(254, 98);
            this.AddVideoButton.TabIndex = 1;
            this.AddVideoButton.Text = "Videos";
            this.AddVideoButton.UseVisualStyleBackColor = true;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // Rent
            // 
            this.Rent.Location = new System.Drawing.Point(85, 255);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(254, 121);
            this.Rent.TabIndex = 3;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(385, 255);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(251, 121);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.AddVideoButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button AddVideoButton;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Button Return;
    }
}
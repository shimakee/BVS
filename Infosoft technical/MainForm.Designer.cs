
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
            this.videoList = new System.Windows.Forms.DataGridView();
            this.Rent = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(612, 24);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(133, 23);
            this.AddCustomerButton.TabIndex = 0;
            this.AddCustomerButton.Text = "Customers";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // AddVideoButton
            // 
            this.AddVideoButton.Location = new System.Drawing.Point(443, 25);
            this.AddVideoButton.Name = "AddVideoButton";
            this.AddVideoButton.Size = new System.Drawing.Size(130, 22);
            this.AddVideoButton.TabIndex = 1;
            this.AddVideoButton.Text = "Videos";
            this.AddVideoButton.UseVisualStyleBackColor = true;
            this.AddVideoButton.Click += new System.EventHandler(this.AddVideoButton_Click);
            // 
            // videoList
            // 
            this.videoList.AllowUserToAddRows = false;
            this.videoList.AllowUserToDeleteRows = false;
            this.videoList.AllowUserToResizeColumns = false;
            this.videoList.AllowUserToResizeRows = false;
            this.videoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoList.Location = new System.Drawing.Point(12, 24);
            this.videoList.Name = "videoList";
            this.videoList.RowTemplate.Height = 25;
            this.videoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.videoList.Size = new System.Drawing.Size(250, 395);
            this.videoList.TabIndex = 2;
            // 
            // Rent
            // 
            this.Rent.Location = new System.Drawing.Point(316, 361);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(159, 58);
            this.Rent.TabIndex = 3;
            this.Rent.Text = "Rent";
            this.Rent.UseVisualStyleBackColor = true;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(612, 361);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(159, 58);
            this.Return.TabIndex = 4;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.AddVideoButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button AddVideoButton;
        private System.Windows.Forms.DataGridView videoList;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Button Return;
    }
}
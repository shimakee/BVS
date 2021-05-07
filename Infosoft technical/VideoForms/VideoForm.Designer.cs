
namespace Infosoft_technical.VideoForms
{
    partial class VideoForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.videoList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.stockInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInput)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(148, 79);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(162, 23);
            this.title.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(148, 119);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(162, 23);
            this.category.TabIndex = 6;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(58, 196);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(78, 25);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(148, 196);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 25);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(235, 196);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 25);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // videoList
            // 
            this.videoList.AllowUserToAddRows = false;
            this.videoList.AllowUserToDeleteRows = false;
            this.videoList.AllowUserToOrderColumns = true;
            this.videoList.AllowUserToResizeColumns = false;
            this.videoList.AllowUserToResizeRows = false;
            this.videoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoList.Location = new System.Drawing.Point(371, 31);
            this.videoList.MultiSelect = false;
            this.videoList.Name = "videoList";
            this.videoList.RowTemplate.Height = 25;
            this.videoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.videoList.Size = new System.Drawing.Size(388, 376);
            this.videoList.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stock";
            // 
            // stockInput
            // 
            this.stockInput.Location = new System.Drawing.Point(148, 159);
            this.stockInput.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.stockInput.Name = "stockInput";
            this.stockInput.Size = new System.Drawing.Size(162, 23);
            this.stockInput.TabIndex = 13;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.videoList);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            ((System.ComponentModel.ISupportInitialize)(this.videoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView videoList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown stockInput;
    }
}
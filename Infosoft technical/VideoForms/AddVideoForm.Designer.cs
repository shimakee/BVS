
namespace Infosoft_technical.VideoForms
{
    partial class AddVideoForm
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
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.categoryInput = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockInput)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(208, 162);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 25);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(35, 162);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(78, 25);
            this.submit.TabIndex = 13;
            this.submit.Text = "Add";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // categoryInput
            // 
            this.categoryInput.FormattingEnabled = true;
            this.categoryInput.Location = new System.Drawing.Point(125, 65);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(162, 23);
            this.categoryInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(125, 25);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(162, 23);
            this.titleInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // stockInput
            // 
            this.stockInput.Location = new System.Drawing.Point(125, 109);
            this.stockInput.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.stockInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stockInput.Name = "stockInput";
            this.stockInput.Size = new System.Drawing.Size(162, 23);
            this.stockInput.TabIndex = 16;
            this.stockInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stock";
            // 
            // AddVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 208);
            this.Controls.Add(this.stockInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.categoryInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label1);
            this.Name = "AddVideoForm";
            this.Text = "AddVideoForm";
            ((System.ComponentModel.ISupportInitialize)(this.stockInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox categoryInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stockInput;
        private System.Windows.Forms.Label label3;
    }
}
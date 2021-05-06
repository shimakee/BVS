
namespace Infosoft_technical
{
    partial class CustomerForm
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
            this.InputFirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputBirthdate = new System.Windows.Forms.MonthCalendar();
            this.birthdate = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputFirstName
            // 
            this.InputFirstName.AutoSize = true;
            this.InputFirstName.Location = new System.Drawing.Point(40, 23);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(65, 15);
            this.InputFirstName.TabIndex = 0;
            this.InputFirstName.Text = "First name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 1;
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(40, 66);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(64, 15);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last name:";
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(111, 66);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(152, 23);
            this.InputLastName.TabIndex = 3;
            // 
            // InputBirthdate
            // 
            this.InputBirthdate.Location = new System.Drawing.Point(111, 117);
            this.InputBirthdate.MaxSelectionCount = 1;
            this.InputBirthdate.Name = "InputBirthdate";
            this.InputBirthdate.TabIndex = 4;
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(40, 117);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(61, 15);
            this.birthdate.TabIndex = 5;
            this.birthdate.Text = "Birth date:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Control;
            this.submit.Location = new System.Drawing.Point(111, 334);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            //this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(233, 334);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.InputBirthdate);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InputFirstName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputFirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.MonthCalendar InputBirthdate;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
    }
}

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
            this.firstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.birthdate = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(40, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(65, 15);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(111, 117);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
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
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.firstName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
    }
}
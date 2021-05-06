
namespace Infosoft_technical
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
            this.InputBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cancel = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.birthdate = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBirthdate
            // 
            this.InputBirthdate.Location = new System.Drawing.Point(100, 121);
            this.InputBirthdate.Name = "InputBirthdate";
            this.InputBirthdate.Size = new System.Drawing.Size(200, 23);
            this.InputBirthdate.TabIndex = 10;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(225, 172);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Control;
            this.submit.Location = new System.Drawing.Point(100, 172);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 11;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(29, 127);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(61, 15);
            this.birthdate.TabIndex = 13;
            this.birthdate.Text = "Birth date:";
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(100, 71);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(152, 23);
            this.InputLastName.TabIndex = 8;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(29, 74);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(64, 15);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "Last name:";
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(100, 27);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(152, 23);
            this.InputFirstName.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(29, 30);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(65, 15);
            this.firstName.TabIndex = 6;
            this.firstName.Text = "First name:";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 225);
            this.Controls.Add(this.InputBirthdate);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.firstName);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker InputBirthdate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label firstName;
    }
}
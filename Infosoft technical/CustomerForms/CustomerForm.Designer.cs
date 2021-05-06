
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
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.InputBirthdate = new System.Windows.Forms.DateTimePicker();
            this.ListOfCustomers = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(40, 90);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(65, 15);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First name:";
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(111, 87);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(152, 23);
            this.InputFirstName.TabIndex = 1;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(40, 134);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(64, 15);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last name:";
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(111, 131);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(152, 23);
            this.InputLastName.TabIndex = 2;
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(40, 187);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(61, 15);
            this.birthdate.TabIndex = 5;
            this.birthdate.Text = "Birth date:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.Control;
            this.submit.Location = new System.Drawing.Point(111, 232);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Save";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(236, 232);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // InputBirthdate
            // 
            this.InputBirthdate.Location = new System.Drawing.Point(111, 181);
            this.InputBirthdate.Name = "InputBirthdate";
            this.InputBirthdate.Size = new System.Drawing.Size(200, 23);
            this.InputBirthdate.TabIndex = 3;
            // 
            // ListOfCustomers
            // 
            this.ListOfCustomers.AllowUserToAddRows = false;
            this.ListOfCustomers.AllowUserToDeleteRows = false;
            this.ListOfCustomers.AllowUserToOrderColumns = true;
            this.ListOfCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfCustomers.Location = new System.Drawing.Point(342, 23);
            this.ListOfCustomers.MultiSelect = false;
            this.ListOfCustomers.Name = "ListOfCustomers";
            this.ListOfCustomers.ReadOnly = true;
            this.ListOfCustomers.RowTemplate.Height = 25;
            this.ListOfCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListOfCustomers.Size = new System.Drawing.Size(508, 481);
            this.ListOfCustomers.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(122, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 22);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListOfCustomers);
            this.Controls.Add(this.InputBirthdate);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.firstName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox InputFirstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DateTimePicker InputBirthdate;
        private System.Windows.Forms.DataGridView ListOfCustomers;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
    }
}
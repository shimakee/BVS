
namespace Infosoft_technical.Transaction
{
    partial class RentForm
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
            this.customersList = new System.Windows.Forms.DataGridView();
            this.rent = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.videosList = new System.Windows.Forms.DataGridView();
            this.rentalList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.daysRental = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysRental)).BeginInit();
            this.SuspendLayout();
            // 
            // customersList
            // 
            this.customersList.AllowDrop = true;
            this.customersList.AllowUserToAddRows = false;
            this.customersList.AllowUserToDeleteRows = false;
            this.customersList.AllowUserToOrderColumns = true;
            this.customersList.AllowUserToResizeColumns = false;
            this.customersList.AllowUserToResizeRows = false;
            this.customersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersList.Location = new System.Drawing.Point(12, 46);
            this.customersList.MultiSelect = false;
            this.customersList.Name = "customersList";
            this.customersList.RowTemplate.Height = 25;
            this.customersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersList.Size = new System.Drawing.Size(238, 172);
            this.customersList.TabIndex = 0;
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(588, 266);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(181, 73);
            this.rent.TabIndex = 1;
            this.rent.Text = "Rent";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(588, 365);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(181, 73);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // videosList
            // 
            this.videosList.AllowUserToAddRows = false;
            this.videosList.AllowUserToDeleteRows = false;
            this.videosList.AllowUserToOrderColumns = true;
            this.videosList.AllowUserToResizeColumns = false;
            this.videosList.AllowUserToResizeRows = false;
            this.videosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videosList.Location = new System.Drawing.Point(12, 266);
            this.videosList.MultiSelect = false;
            this.videosList.Name = "videosList";
            this.videosList.RowTemplate.Height = 25;
            this.videosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.videosList.Size = new System.Drawing.Size(238, 172);
            this.videosList.TabIndex = 3;
            // 
            // rentalList
            // 
            this.rentalList.AllowUserToAddRows = false;
            this.rentalList.AllowUserToDeleteRows = false;
            this.rentalList.AllowUserToOrderColumns = true;
            this.rentalList.AllowUserToResizeColumns = false;
            this.rentalList.AllowUserToResizeRows = false;
            this.rentalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalList.Location = new System.Drawing.Point(370, 266);
            this.rentalList.MultiSelect = false;
            this.rentalList.Name = "rentalList";
            this.rentalList.RowTemplate.Height = 25;
            this.rentalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalList.Size = new System.Drawing.Size(187, 172);
            this.rentalList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "FIrst name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(407, 38);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(141, 23);
            this.firstname.TabIndex = 8;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(407, 69);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(141, 23);
            this.lastname.TabIndex = 9;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(407, 101);
            this.age.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(141, 23);
            this.age.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(618, 195);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(141, 23);
            this.totalAmount.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(276, 291);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 28);
            this.add.TabIndex = 13;
            this.add.Text = ">>>";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(276, 384);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(71, 25);
            this.remove.TabIndex = 14;
            this.remove.Text = "<<<";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Videos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Customers";
            // 
            // daysRental
            // 
            this.daysRental.Location = new System.Drawing.Point(618, 154);
            this.daysRental.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.daysRental.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysRental.Name = "daysRental";
            this.daysRental.Size = new System.Drawing.Size(141, 23);
            this.daysRental.TabIndex = 17;
            this.daysRental.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Days";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.daysRental);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentalList);
            this.Controls.Add(this.videosList);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.customersList);
            this.Name = "RentForm";
            this.Text = "RentForm";
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersList;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView videosList;
        private System.Windows.Forms.DataGridView rentalList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ist;
        private System.Windows.Forms.NumericUpDown daysRental;
        private System.Windows.Forms.Label label7;
    }
}
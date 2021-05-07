
namespace Infosoft_technical.Transaction
{
    partial class ReturnForm
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
            this.das = new System.Windows.Forms.Label();
            this.daysPastDue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.videosList = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.returnVideo = new System.Windows.Forms.Button();
            this.customersList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.daysRented = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rentalPrice = new System.Windows.Forms.NumericUpDown();
            this.penaltyAmount = new System.Windows.Forms.NumericUpDown();
            this.totalAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.daysPastDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // das
            // 
            this.das.AutoSize = true;
            this.das.Location = new System.Drawing.Point(576, 117);
            this.das.Name = "das";
            this.das.Size = new System.Drawing.Size(81, 15);
            this.das.TabIndex = 34;
            this.das.Text = "Days Past Due";
            // 
            // daysPastDue
            // 
            this.daysPastDue.Location = new System.Drawing.Point(685, 115);
            this.daysPastDue.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.daysPastDue.Name = "daysPastDue";
            this.daysPastDue.Size = new System.Drawing.Size(94, 23);
            this.daysPastDue.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Customers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Videos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Penalty";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(417, 96);
            this.age.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(141, 23);
            this.age.TabIndex = 28;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(417, 64);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(141, 23);
            this.lastname.TabIndex = 27;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(417, 33);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(141, 23);
            this.firstname.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "FIrst name";
            // 
            // videosList
            // 
            this.videosList.AllowUserToAddRows = false;
            this.videosList.AllowUserToDeleteRows = false;
            this.videosList.AllowUserToOrderColumns = true;
            this.videosList.AllowUserToResizeColumns = false;
            this.videosList.AllowUserToResizeRows = false;
            this.videosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videosList.Location = new System.Drawing.Point(22, 261);
            this.videosList.MultiSelect = false;
            this.videosList.Name = "videosList";
            this.videosList.RowTemplate.Height = 25;
            this.videosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.videosList.Size = new System.Drawing.Size(238, 172);
            this.videosList.TabIndex = 22;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(598, 360);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(181, 73);
            this.cancel.TabIndex = 21;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // returnVideo
            // 
            this.returnVideo.Location = new System.Drawing.Point(598, 261);
            this.returnVideo.Name = "returnVideo";
            this.returnVideo.Size = new System.Drawing.Size(181, 73);
            this.returnVideo.TabIndex = 20;
            this.returnVideo.Text = "Return";
            this.returnVideo.UseVisualStyleBackColor = true;
            this.returnVideo.Click += new System.EventHandler(this.returnVideo_Click);
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
            this.customersList.Location = new System.Drawing.Point(22, 41);
            this.customersList.MultiSelect = false;
            this.customersList.Name = "customersList";
            this.customersList.RowTemplate.Height = 25;
            this.customersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersList.Size = new System.Drawing.Size(238, 172);
            this.customersList.TabIndex = 19;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(404, 261);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(141, 23);
            this.Title.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Title";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(404, 311);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(141, 23);
            this.category.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Total amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Days Rented";
            // 
            // daysRented
            // 
            this.daysRented.Location = new System.Drawing.Point(685, 67);
            this.daysRented.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.daysRented.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysRented.Name = "daysRented";
            this.daysRented.Size = new System.Drawing.Size(94, 23);
            this.daysRented.TabIndex = 41;
            this.daysRented.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Rental price";
            // 
            // rentalPrice
            // 
            this.rentalPrice.Location = new System.Drawing.Point(404, 360);
            this.rentalPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.rentalPrice.Name = "rentalPrice";
            this.rentalPrice.Size = new System.Drawing.Size(141, 23);
            this.rentalPrice.TabIndex = 44;
            // 
            // penaltyAmount
            // 
            this.penaltyAmount.Location = new System.Drawing.Point(685, 160);
            this.penaltyAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.penaltyAmount.Name = "penaltyAmount";
            this.penaltyAmount.Size = new System.Drawing.Size(94, 23);
            this.penaltyAmount.TabIndex = 45;
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(685, 204);
            this.totalAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(94, 23);
            this.totalAmount.TabIndex = 46;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.penaltyAmount);
            this.Controls.Add(this.rentalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.daysRented);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.category);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.das);
            this.Controls.Add(this.daysPastDue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.age);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videosList);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.returnVideo);
            this.Controls.Add(this.customersList);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.daysPastDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label das;
        private System.Windows.Forms.NumericUpDown daysPastDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView videosList;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button returnVideo;
        private System.Windows.Forms.DataGridView customersList;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown daysRented;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown rentalPrice;
        private System.Windows.Forms.NumericUpDown penaltyAmount;
        private System.Windows.Forms.NumericUpDown totalAmount;
    }
}
﻿namespace FinalSprintProject
{
    partial class patronProfile
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
            this.PatronProfileLabel = new System.Windows.Forms.Label();
            this.inputIDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.PatronProfileView = new System.Windows.Forms.DataGridView();
            this.loadtable_txt = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatronProfileLabel
            // 
            this.PatronProfileLabel.AutoSize = true;
            this.PatronProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatronProfileLabel.Location = new System.Drawing.Point(25, 23);
            this.PatronProfileLabel.Name = "PatronProfileLabel";
            this.PatronProfileLabel.Size = new System.Drawing.Size(173, 29);
            this.PatronProfileLabel.TabIndex = 0;
            this.PatronProfileLabel.Text = "Patron Profile";
            // 
            // inputIDLabel
            // 
            this.inputIDLabel.AutoSize = true;
            this.inputIDLabel.Location = new System.Drawing.Point(669, 171);
            this.inputIDLabel.Name = "inputIDLabel";
            this.inputIDLabel.Size = new System.Drawing.Size(70, 17);
            this.inputIDLabel.TabIndex = 1;
            this.inputIDLabel.Text = "Search ID";
            this.inputIDLabel.Click += new System.EventHandler(this.inputIDLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(392, 645);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(343, 53);
            this.ReturntoMainMenuButton.TabIndex = 5;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // PatronProfileView
            // 
            this.PatronProfileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatronProfileView.Location = new System.Drawing.Point(672, 203);
            this.PatronProfileView.Name = "PatronProfileView";
            this.PatronProfileView.RowTemplate.Height = 24;
            this.PatronProfileView.Size = new System.Drawing.Size(786, 290);
            this.PatronProfileView.TabIndex = 6;
            this.PatronProfileView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatronProfileView_CellContentClick);
            // 
            // loadtable_txt
            // 
            this.loadtable_txt.Location = new System.Drawing.Point(1150, 514);
            this.loadtable_txt.Name = "loadtable_txt";
            this.loadtable_txt.Size = new System.Drawing.Size(171, 53);
            this.loadtable_txt.TabIndex = 7;
            this.loadtable_txt.Text = "Load Table";
            this.loadtable_txt.UseVisualStyleBackColor = true;
            this.loadtable_txt.Click += new System.EventHandler(this.loadtable_txt_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(38, 110);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(38, 306);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 10;
            this.AgeLabel.Text = "Age";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(38, 261);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(56, 17);
            this.GenderLabel.TabIndex = 11;
            this.GenderLabel.Text = "Gender";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(38, 218);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(38, 176);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 13;
            this.FirstNameLabel.Text = "First Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(38, 348);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumberLabel.TabIndex = 14;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(38, 430);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 15;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(38, 389);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(154, 110);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(246, 22);
            this.ID.TabIndex = 19;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(154, 425);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(246, 22);
            this.Address.TabIndex = 21;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(154, 384);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(246, 22);
            this.Email.TabIndex = 22;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(154, 343);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(246, 22);
            this.PhoneNumber.TabIndex = 23;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(154, 301);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(246, 22);
            this.Age.TabIndex = 24;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(154, 261);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(246, 22);
            this.Gender.TabIndex = 25;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(154, 218);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(246, 22);
            this.LastName.TabIndex = 26;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(154, 176);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(246, 22);
            this.FirstName.TabIndex = 27;
            this.FirstName.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 22);
            this.textBox2.TabIndex = 31;
            // 
            // patronProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 733);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.loadtable_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputIDLabel);
            this.Controls.Add(this.PatronProfileView);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.PatronProfileLabel);
            this.Name = "patronProfile";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.loadtable_txt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatronProfileLabel;
        private System.Windows.Forms.Label inputIDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.DataGridView PatronProfileView;
        private System.Windows.Forms.Button loadtable_txt;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
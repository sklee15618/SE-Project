namespace FinalSprintProject
{
    partial class inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.searchIDTxt = new System.Windows.Forms.Label();
            this.searchIDTxtBox = new System.Windows.Forms.TextBox();
            this.equipTxt = new System.Windows.Forms.Label();
            this.equipDataView = new System.Windows.Forms.DataGridView();
            this.checkOutInv = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.equipmentTxt = new System.Windows.Forms.Label();
            this.equipTxtBox = new System.Windows.Forms.RichTextBox();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.equipDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Inventory";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(513, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 39);
            this.button6.TabIndex = 16;
            this.button6.Text = "Return to Main Menu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // searchIDTxt
            // 
            this.searchIDTxt.AutoSize = true;
            this.searchIDTxt.Location = new System.Drawing.Point(60, 111);
            this.searchIDTxt.Name = "searchIDTxt";
            this.searchIDTxt.Size = new System.Drawing.Size(70, 17);
            this.searchIDTxt.TabIndex = 17;
            this.searchIDTxt.Text = "Search ID";
            // 
            // searchIDTxtBox
            // 
            this.searchIDTxtBox.Location = new System.Drawing.Point(136, 106);
            this.searchIDTxtBox.Name = "searchIDTxtBox";
            this.searchIDTxtBox.Size = new System.Drawing.Size(166, 22);
            this.searchIDTxtBox.TabIndex = 18;
            // 
            // equipTxt
            // 
            this.equipTxt.AutoSize = true;
            this.equipTxt.Location = new System.Drawing.Point(60, 155);
            this.equipTxt.Name = "equipTxt";
            this.equipTxt.Size = new System.Drawing.Size(75, 17);
            this.equipTxt.TabIndex = 19;
            this.equipTxt.Text = "Equipment";
            // 
            // equipDataView
            // 
            this.equipDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipDataView.Location = new System.Drawing.Point(63, 196);
            this.equipDataView.Name = "equipDataView";
            this.equipDataView.RowTemplate.Height = 24;
            this.equipDataView.Size = new System.Drawing.Size(542, 234);
            this.equipDataView.TabIndex = 20;
            // 
            // checkOutInv
            // 
            this.checkOutInv.AutoSize = true;
            this.checkOutInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutInv.Location = new System.Drawing.Point(642, 43);
            this.checkOutInv.Name = "checkOutInv";
            this.checkOutInv.Size = new System.Drawing.Size(355, 29);
            this.checkOutInv.TabIndex = 21;
            this.checkOutInv.Text = "Check Out/Check In Inventory";
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Location = new System.Drawing.Point(644, 111);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(21, 17);
            this.idTxt.TabIndex = 22;
            this.idTxt.Text = "ID";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(757, 106);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(240, 22);
            this.idTxtBox.TabIndex = 23;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.Location = new System.Drawing.Point(644, 155);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(45, 17);
            this.nameTxt.TabIndex = 24;
            this.nameTxt.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(757, 155);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(240, 22);
            this.nameTxtBox.TabIndex = 25;
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.AutoSize = true;
            this.equipmentTxt.Location = new System.Drawing.Point(644, 199);
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.Size = new System.Drawing.Size(75, 17);
            this.equipmentTxt.TabIndex = 26;
            this.equipmentTxt.Text = "Equipment";
            // 
            // equipTxtBox
            // 
            this.equipTxtBox.Location = new System.Drawing.Point(757, 196);
            this.equipTxtBox.Name = "equipTxtBox";
            this.equipTxtBox.Size = new System.Drawing.Size(356, 168);
            this.equipTxtBox.TabIndex = 27;
            this.equipTxtBox.Text = "";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(757, 382);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(175, 48);
            this.checkOutButton.TabIndex = 28;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(938, 382);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(175, 48);
            this.checkInButton.TabIndex = 29;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 30;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.equipTxtBox);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.checkOutInv);
            this.Controls.Add(this.equipDataView);
            this.Controls.Add(this.equipTxt);
            this.Controls.Add(this.searchIDTxtBox);
            this.Controls.Add(this.searchIDTxt);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "inventory";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.equipDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label searchIDTxt;
        private System.Windows.Forms.TextBox searchIDTxtBox;
        private System.Windows.Forms.Label equipTxt;
        private System.Windows.Forms.DataGridView equipDataView;
        private System.Windows.Forms.Label checkOutInv;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label equipmentTxt;
        private System.Windows.Forms.RichTextBox equipTxtBox;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
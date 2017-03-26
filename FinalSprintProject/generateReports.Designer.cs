namespace FinalSprintProject
{
    partial class generateReports
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
            this.ReportsLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.GeneratePDFReportbutton = new System.Windows.Forms.Button();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.reportsGridView = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsLabel
            // 
            this.ReportsLabel.AutoSize = true;
            this.ReportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLabel.Location = new System.Drawing.Point(21, 49);
            this.ReportsLabel.Name = "ReportsLabel";
            this.ReportsLabel.Size = new System.Drawing.Size(105, 29);
            this.ReportsLabel.TabIndex = 1;
            this.ReportsLabel.Text = "Reports";
            this.ReportsLabel.Click += new System.EventHandler(this.ReportsLabel_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(26, 358);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(194, 34);
            this.ClearAllButton.TabIndex = 4;
            this.ClearAllButton.Text = "LoadTable";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            // 
            // GeneratePDFReportbutton
            // 
            this.GeneratePDFReportbutton.Location = new System.Drawing.Point(513, 358);
            this.GeneratePDFReportbutton.Name = "GeneratePDFReportbutton";
            this.GeneratePDFReportbutton.Size = new System.Drawing.Size(227, 34);
            this.GeneratePDFReportbutton.TabIndex = 5;
            this.GeneratePDFReportbutton.Text = "Generate Excel File";
            this.GeneratePDFReportbutton.UseVisualStyleBackColor = true;
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(298, 473);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(278, 59);
            this.ReturntoMainMenuButton.TabIndex = 10;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // reportsGridView
            // 
            this.reportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGridView.Location = new System.Drawing.Point(513, 122);
            this.reportsGridView.Name = "reportsGridView";
            this.reportsGridView.RowTemplate.Height = 24;
            this.reportsGridView.Size = new System.Drawing.Size(417, 211);
            this.reportsGridView.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "New Patrons (7 Days)",
            "New Patrons (30 Days)",
            "Repeat Climbers (7 Days)",
            "Repeat Climbers (30 Days)",
            "Total Patrons (Per Month)",
            "Total Patrons (Per Day, 30 Days)"});
            this.checkedListBox1.Location = new System.Drawing.Point(26, 125);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(377, 208);
            this.checkedListBox1.TabIndex = 12;
            // 
            // generateReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 580);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.reportsGridView);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.GeneratePDFReportbutton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ReportsLabel);
            this.Name = "generateReports";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReportsLabel;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button GeneratePDFReportbutton;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.DataGridView reportsGridView;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
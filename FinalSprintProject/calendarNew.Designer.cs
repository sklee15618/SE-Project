namespace FinalSprintProject
{
    partial class calendarNew
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
            this.EventsLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTxt = new System.Windows.Forms.Label();
            this.eventTxtBox = new System.Windows.Forms.RichTextBox();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.addEvents = new System.Windows.Forms.Label();
            this.eventTxt = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchEvenDate = new System.Windows.Forms.Label();
            this.searchEventDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEventName = new System.Windows.Forms.TextBox();
            this.addEventName = new System.Windows.Forms.Label();
            this.searchEventNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendar";
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsLabel.Location = new System.Drawing.Point(287, 35);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(180, 29);
            this.EventsLabel.TabIndex = 1;
            this.EventsLabel.Text = "Search Events";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(5, 173);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTxt
            // 
            this.dataTxt.AutoSize = true;
            this.dataTxt.Location = new System.Drawing.Point(797, 118);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(78, 17);
            this.dataTxt.TabIndex = 9;
            this.dataTxt.Text = "Event Date";
            // 
            // eventTxtBox
            // 
            this.eventTxtBox.Location = new System.Drawing.Point(922, 156);
            this.eventTxtBox.Name = "eventTxtBox";
            this.eventTxtBox.Size = new System.Drawing.Size(258, 173);
            this.eventTxtBox.TabIndex = 10;
            this.eventTxtBox.Text = "";
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(292, 173);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.RowTemplate.Height = 24;
            this.eventsDataGrid.Size = new System.Drawing.Size(478, 207);
            this.eventsDataGrid.TabIndex = 11;
            // 
            // addEvents
            // 
            this.addEvents.AutoSize = true;
            this.addEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvents.Location = new System.Drawing.Point(795, 35);
            this.addEvents.Name = "addEvents";
            this.addEvents.Size = new System.Drawing.Size(236, 29);
            this.addEvents.TabIndex = 16;
            this.addEvents.Text = "Add/Update Events";
            // 
            // eventTxt
            // 
            this.eventTxt.AutoSize = true;
            this.eventTxt.Location = new System.Drawing.Point(797, 159);
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(119, 17);
            this.eventTxt.TabIndex = 18;
            this.eventTxt.Text = "Event Description";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(899, 348);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 32);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // eventDate
            // 
            this.eventDate.CustomFormat = "yyyy-MM-dd";
            this.eventDate.Location = new System.Drawing.Point(922, 111);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(248, 22);
            this.eventDate.TabIndex = 20;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1067, 348);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 32);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // searchEvenDate
            // 
            this.searchEvenDate.AutoSize = true;
            this.searchEvenDate.Location = new System.Drawing.Point(289, 118);
            this.searchEvenDate.Name = "searchEvenDate";
            this.searchEvenDate.Size = new System.Drawing.Size(127, 17);
            this.searchEvenDate.TabIndex = 23;
            this.searchEvenDate.Text = "Search Event Date";
            // 
            // searchEventDate
            // 
            this.searchEventDate.Location = new System.Drawing.Point(443, 113);
            this.searchEventDate.Name = "searchEventDate";
            this.searchEventDate.Size = new System.Drawing.Size(167, 22);
            this.searchEventDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search Event Name";
            // 
            // searchEventName
            // 
            this.searchEventName.Location = new System.Drawing.Point(443, 78);
            this.searchEventName.Name = "searchEventName";
            this.searchEventName.Size = new System.Drawing.Size(167, 22);
            this.searchEventName.TabIndex = 27;
            // 
            // addEventName
            // 
            this.addEventName.AutoSize = true;
            this.addEventName.Location = new System.Drawing.Point(797, 83);
            this.addEventName.Name = "addEventName";
            this.addEventName.Size = new System.Drawing.Size(85, 17);
            this.addEventName.TabIndex = 28;
            this.addEventName.Text = "Event Name";
            // 
            // searchEventNameBox
            // 
            this.searchEventNameBox.Location = new System.Drawing.Point(922, 76);
            this.searchEventNameBox.Name = "searchEventNameBox";
            this.searchEventNameBox.Size = new System.Drawing.Size(248, 22);
            this.searchEventNameBox.TabIndex = 29;
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 524);
            this.Controls.Add(this.searchEventNameBox);
            this.Controls.Add(this.addEventName);
            this.Controls.Add(this.searchEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEventDate);
            this.Controls.Add(this.searchEvenDate);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.addEvents);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.eventTxtBox);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.label1);
            this.Name = "calendar";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dataTxt;
        private System.Windows.Forms.RichTextBox eventTxtBox;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.Label addEvents;
        private System.Windows.Forms.Label eventTxt;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label searchEvenDate;
        private System.Windows.Forms.TextBox searchEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchEventName;
        private System.Windows.Forms.Label addEventName;
        private System.Windows.Forms.TextBox searchEventNameBox;
    }
}
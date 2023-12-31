﻿namespace WinFormsApp1
{
    partial class ShiftSchedules
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
            buttonMainMenuSS = new Button();
            label1 = new Label();
            dateTimePickerSelectDate = new DateTimePicker();
            label3 = new Label();
            buttonSearch = new Button();
            label2 = new Label();
            dataGridViewSS = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSS).BeginInit();
            SuspendLayout();
            // 
            // buttonMainMenuSS
            // 
            buttonMainMenuSS.Location = new Point(1009, 12);
            buttonMainMenuSS.Name = "buttonMainMenuSS";
            buttonMainMenuSS.Size = new Size(112, 34);
            buttonMainMenuSS.TabIndex = 7;
            buttonMainMenuSS.Text = "MainMenu";
            buttonMainMenuSS.UseVisualStyleBackColor = true;
            buttonMainMenuSS.Click += buttonMainMenuSS_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(0, 68);
            label1.Name = "label1";
            label1.Size = new Size(1138, 10);
            label1.TabIndex = 8;
            // 
            // dateTimePickerSelectDate
            // 
            dateTimePickerSelectDate.CustomFormat = "DD-Mon-YY";
            dateTimePickerSelectDate.Format = DateTimePickerFormat.Short;
            dateTimePickerSelectDate.Location = new Point(214, 103);
            dateTimePickerSelectDate.Name = "dateTimePickerSelectDate";
            dateTimePickerSelectDate.Size = new Size(123, 31);
            dateTimePickerSelectDate.TabIndex = 16;
            dateTimePickerSelectDate.ValueChanged += dateTimePickerHireDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 109);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 17;
            label3.Text = "Please Select a Date";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(402, 100);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 18;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 165);
            label2.Name = "label2";
            label2.Size = new Size(1138, 10);
            label2.TabIndex = 19;
            // 
            // dataGridViewSS
            // 
            dataGridViewSS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSS.Location = new Point(12, 178);
            dataGridViewSS.Name = "dataGridViewSS";
            dataGridViewSS.RowHeadersWidth = 62;
            dataGridViewSS.RowTemplate.Height = 33;
            dataGridViewSS.Size = new Size(1086, 225);
            dataGridViewSS.TabIndex = 20;
            // 
            // ShiftSchedules
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 450);
            Controls.Add(dataGridViewSS);
            Controls.Add(label2);
            Controls.Add(buttonSearch);
            Controls.Add(label3);
            Controls.Add(dateTimePickerSelectDate);
            Controls.Add(label1);
            Controls.Add(buttonMainMenuSS);
            Name = "ShiftSchedules";
            Text = "EF&V ShiftSchedules";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenuSS;
        private Label label1;
        private DateTimePicker dateTimePickerSelectDate;
        private Label label3;
        private Button buttonSearch;
        private Label label2;
        private DataGridView dataGridViewSS;
    }
}
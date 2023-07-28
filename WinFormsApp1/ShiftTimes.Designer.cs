namespace WinFormsApp1
{
    partial class ShiftTimes
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
            label1 = new Label();
            buttonMainMenuST = new Button();
            buttonSaveSF = new Button();
            labelDayST = new Label();
            textDay = new TextBox();
            labelLocationID = new Label();
            textLocationId = new TextBox();
            textLocationName = new TextBox();
            label2 = new Label();
            textDayStartTime = new TextBox();
            textDayEndTime = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxWorkType = new ComboBox();
            comboBoxShift = new ComboBox();
            label5 = new Label();
            textBoxShiftStartTime = new TextBox();
            textEndTime = new TextBox();
            labelNumberOfStaff = new Label();
            textBoxNoOfEmployeesRequired = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(1, 79);
            label1.Name = "label1";
            label1.Size = new Size(975, 10);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // buttonMainMenuST
            // 
            buttonMainMenuST.Location = new Point(830, 27);
            buttonMainMenuST.Name = "buttonMainMenuST";
            buttonMainMenuST.Size = new Size(112, 34);
            buttonMainMenuST.TabIndex = 6;
            buttonMainMenuST.Text = "MainMenu";
            buttonMainMenuST.UseVisualStyleBackColor = true;
            buttonMainMenuST.Click += buttonMainMenuST_Click;
            // 
            // buttonSaveSF
            // 
            buttonSaveSF.Location = new Point(754, 460);
            buttonSaveSF.Name = "buttonSaveSF";
            buttonSaveSF.Size = new Size(112, 34);
            buttonSaveSF.TabIndex = 21;
            buttonSaveSF.Text = "Save";
            buttonSaveSF.UseVisualStyleBackColor = true;
            buttonSaveSF.Click += buttonSaveSF_Click;
            // 
            // labelDayST
            // 
            labelDayST.AutoSize = true;
            labelDayST.Location = new Point(59, 184);
            labelDayST.Name = "labelDayST";
            labelDayST.Size = new Size(43, 25);
            labelDayST.TabIndex = 23;
            labelDayST.Text = "Day";
            // 
            // textDay
            // 
            textDay.Location = new Point(186, 184);
            textDay.Name = "textDay";
            textDay.Size = new Size(252, 31);
            textDay.TabIndex = 3;
            textDay.TextChanged += textDay_TextChanged;
            textDay.Validated += textDay_Validated;
            // 
            // labelLocationID
            // 
            labelLocationID.AutoSize = true;
            labelLocationID.Location = new Point(59, 121);
            labelLocationID.Name = "labelLocationID";
            labelLocationID.Size = new Size(102, 25);
            labelLocationID.TabIndex = 25;
            labelLocationID.Text = "Location ID";
            // 
            // textLocationId
            // 
            textLocationId.Location = new Point(186, 118);
            textLocationId.Name = "textLocationId";
            textLocationId.Size = new Size(252, 31);
            textLocationId.TabIndex = 1;
            textLocationId.Validated += textLocationId_Validated;
            // 
            // textLocationName
            // 
            textLocationName.Enabled = false;
            textLocationName.Location = new Point(495, 121);
            textLocationName.Name = "textLocationName";
            textLocationName.Size = new Size(252, 31);
            textLocationName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 190);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 26;
            label2.Text = "Opening Hours";
            // 
            // textDayStartTime
            // 
            textDayStartTime.Enabled = false;
            textDayStartTime.Location = new Point(672, 187);
            textDayStartTime.Name = "textDayStartTime";
            textDayStartTime.Size = new Size(93, 31);
            textDayStartTime.TabIndex = 27;
            // 
            // textDayEndTime
            // 
            textDayEndTime.Enabled = false;
            textDayEndTime.Location = new Point(816, 190);
            textDayEndTime.Name = "textDayEndTime";
            textDayEndTime.Size = new Size(93, 31);
            textDayEndTime.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 252);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 29;
            label3.Text = "Shift";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 315);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 32;
            label4.Text = "WorkType";
            // 
            // comboBoxWorkType
            // 
            comboBoxWorkType.FormattingEnabled = true;
            comboBoxWorkType.Items.AddRange(new object[] { "Teller\t", "Stock Member" });
            comboBoxWorkType.Location = new Point(186, 315);
            comboBoxWorkType.Name = "comboBoxWorkType";
            comboBoxWorkType.Size = new Size(182, 33);
            comboBoxWorkType.TabIndex = 7;
            // 
            // comboBoxShift
            // 
            comboBoxShift.FormattingEnabled = true;
            comboBoxShift.Items.AddRange(new object[] { "Morning", "Afternoon" });
            comboBoxShift.Location = new Point(186, 244);
            comboBoxShift.Name = "comboBoxShift";
            comboBoxShift.Size = new Size(182, 33);
            comboBoxShift.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(495, 252);
            label5.Name = "label5";
            label5.Size = new Size(172, 25);
            label5.TabIndex = 34;
            label5.Text = "Shift Start & End Time";
            // 
            // textBoxShiftStartTime
            // 
            textBoxShiftStartTime.Location = new Point(673, 252);
            textBoxShiftStartTime.Name = "textBoxShiftStartTime";
            textBoxShiftStartTime.Size = new Size(92, 31);
            textBoxShiftStartTime.TabIndex = 5;
            // 
            // textEndTime
            // 
            textEndTime.Location = new Point(816, 252);
            textEndTime.Name = "textEndTime";
            textEndTime.Size = new Size(92, 31);
            textEndTime.TabIndex = 6;
            // 
            // labelNumberOfStaff
            // 
            labelNumberOfStaff.AutoSize = true;
            labelNumberOfStaff.Location = new Point(59, 390);
            labelNumberOfStaff.Name = "labelNumberOfStaff";
            labelNumberOfStaff.Size = new Size(228, 25);
            labelNumberOfStaff.TabIndex = 35;
            labelNumberOfStaff.Text = "No. of Employees Required";
            // 
            // textBoxNoOfEmployeesRequired
            // 
            textBoxNoOfEmployeesRequired.Location = new Point(320, 390);
            textBoxNoOfEmployeesRequired.Name = "textBoxNoOfEmployeesRequired";
            textBoxNoOfEmployeesRequired.Size = new Size(92, 31);
            textBoxNoOfEmployeesRequired.TabIndex = 8;
            // 
            // ShiftTimes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 506);
            Controls.Add(textBoxNoOfEmployeesRequired);
            Controls.Add(labelNumberOfStaff);
            Controls.Add(textEndTime);
            Controls.Add(textBoxShiftStartTime);
            Controls.Add(label5);
            Controls.Add(comboBoxShift);
            Controls.Add(comboBoxWorkType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textDayEndTime);
            Controls.Add(textDayStartTime);
            Controls.Add(label2);
            Controls.Add(textLocationName);
            Controls.Add(textLocationId);
            Controls.Add(labelLocationID);
            Controls.Add(textDay);
            Controls.Add(labelDayST);
            Controls.Add(buttonSaveSF);
            Controls.Add(buttonMainMenuST);
            Controls.Add(label1);
            Name = "ShiftTimes";
            Text = "EF&V Shift Times";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonMainMenuE;
        private Button buttonMainMenuST;
        private Button buttonSaveSF;
        private Label labelDayST;
        private TextBox textDay;
        private Label labelLocationID;
        private TextBox textLocationId;
        private TextBox textLocationName;
        private Label label2;
        private TextBox textDayStartTime;
        private TextBox textDayEndTime;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxWorkType;
        private ComboBox comboBoxShift;
        private Label label5;
        private TextBox textBoxShiftStartTime;
        private TextBox textEndTime;
        private Label labelNumberOfStaff;
        private TextBox textBoxNoOfEmployeesRequired;
    }
}
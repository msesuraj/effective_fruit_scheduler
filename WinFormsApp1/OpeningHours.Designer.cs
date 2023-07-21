namespace WinFormsApp1
{
    partial class OpeningHours
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
            buttonMainMenuOH = new Button();
            label1 = new Label();
            labelLocationID = new Label();
            textLocationName = new TextBox();
            labelDay = new Label();
            textDay = new TextBox();
            labelStartTime = new Label();
            textStartTime = new TextBox();
            labelEndTime = new Label();
            textEndTime = new TextBox();
            buttonSaveOH = new Button();
            textLocationId = new TextBox();
            SuspendLayout();
            // 
            // buttonMainMenuOH
            // 
            buttonMainMenuOH.Location = new Point(688, 22);
            buttonMainMenuOH.Name = "buttonMainMenuOH";
            buttonMainMenuOH.Size = new Size(112, 34);
            buttonMainMenuOH.TabIndex = 10;
            buttonMainMenuOH.Text = "Main Menu";
            buttonMainMenuOH.UseVisualStyleBackColor = true;
            buttonMainMenuOH.Click += buttonMainMenuOH_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(1, 69);
            label1.Name = "label1";
            label1.Size = new Size(799, 10);
            label1.TabIndex = 4;
            // 
            // labelLocationID
            // 
            labelLocationID.AutoSize = true;
            labelLocationID.Location = new Point(34, 114);
            labelLocationID.Name = "labelLocationID";
            labelLocationID.Size = new Size(102, 25);
            labelLocationID.TabIndex = 5;
            labelLocationID.Text = "Location ID";
            // 
            // textLocationName
            // 
            textLocationName.Enabled = false;
            textLocationName.Location = new Point(483, 114);
            textLocationName.Name = "textLocationName";
            textLocationName.Size = new Size(252, 31);
            textLocationName.TabIndex = 15;
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new Point(34, 185);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(43, 25);
            labelDay.TabIndex = 8;
            labelDay.Text = "Day";
            // 
            // textDay
            // 
            textDay.Location = new Point(177, 185);
            textDay.Name = "textDay";
            textDay.Size = new Size(252, 31);
            textDay.TabIndex = 2;
            textDay.Validated += textDay_Validated;
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Location = new Point(34, 261);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(86, 25);
            labelStartTime.TabIndex = 10;
            labelStartTime.Text = "StartTime";
            // 
            // textStartTime
            // 
            textStartTime.Location = new Point(173, 255);
            textStartTime.Name = "textStartTime";
            textStartTime.Size = new Size(252, 31);
            textStartTime.TabIndex = 3;
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Location = new Point(34, 340);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(80, 25);
            labelEndTime.TabIndex = 12;
            labelEndTime.Text = "EndTime";
            // 
            // textEndTime
            // 
            textEndTime.Location = new Point(173, 340);
            textEndTime.Name = "textEndTime";
            textEndTime.Size = new Size(252, 31);
            textEndTime.TabIndex = 4;
            // 
            // buttonSaveOH
            // 
            buttonSaveOH.Location = new Point(250, 462);
            buttonSaveOH.Name = "buttonSaveOH";
            buttonSaveOH.Size = new Size(112, 34);
            buttonSaveOH.TabIndex = 5;
            buttonSaveOH.Text = "Save";
            buttonSaveOH.UseVisualStyleBackColor = true;
            buttonSaveOH.Click += buttonSaveOH_Click;
            // 
            // textLocationId
            // 
            textLocationId.Location = new Point(177, 114);
            textLocationId.Name = "textLocationId";
            textLocationId.Size = new Size(252, 31);
            textLocationId.TabIndex = 1;
            textLocationId.TextChanged += textLocationId_TextChanged;
            textLocationId.Validated += textLocationId_Validated;
            // 
            // OpeningHours
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 613);
            Controls.Add(textLocationId);
            Controls.Add(buttonSaveOH);
            Controls.Add(textEndTime);
            Controls.Add(labelEndTime);
            Controls.Add(textStartTime);
            Controls.Add(labelStartTime);
            Controls.Add(textDay);
            Controls.Add(labelDay);
            Controls.Add(textLocationName);
            Controls.Add(labelLocationID);
            Controls.Add(label1);
            Controls.Add(buttonMainMenuOH);
            Name = "OpeningHours";
            Text = "EF&V OpeningHours";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenuOH;
        private Label label1;
        private Label labelLocationID;
        private TextBox textLocationName;
        private Label labelDay;
        private TextBox textBoxDay;
        private Label labelStartTime;
        private TextBox textBoxStartTime;
        private Label labelEndTime;
        private TextBox textBoxEndTime;
        private Button buttonSaveOH;
        private TextBox textLocationId;
        private TextBox textDay;
        private TextBox textStartTime;
        private TextBox textEndTime;
    }
}
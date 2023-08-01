namespace WinFormsApp1
{
    partial class Calendar
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
            buttonMainMenuE = new Button();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // buttonMainMenuE
            // 
            buttonMainMenuE.Location = new Point(969, 28);
            buttonMainMenuE.Name = "buttonMainMenuE";
            buttonMainMenuE.Size = new Size(112, 34);
            buttonMainMenuE.TabIndex = 1;
            buttonMainMenuE.Text = "MainMenu";
            buttonMainMenuE.UseVisualStyleBackColor = true;
            buttonMainMenuE.Click += buttonMainMenuE_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-6, 94);
            label1.Name = "label1";
            label1.Size = new Size(1248, 11);
            label1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(365, 162);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 683);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            Controls.Add(buttonMainMenuE);
            Name = "Calendar";
            Text = "Calendar";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMainMenuE;
        private Label label1;
        private MonthCalendar monthCalendar1;
    }
}
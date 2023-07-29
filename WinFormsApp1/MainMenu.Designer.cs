namespace WinFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonLogout = new Button();
            splitter1 = new Splitter();
            label1 = new Label();
            pictureBoxOpeningHours = new PictureBox();
            pictureBoxCalendar = new PictureBox();
            pictureShiftTime = new PictureBox();
            pictureShiftScheduler = new PictureBox();
            pictureReports = new PictureBox();
            pictureEmployees = new PictureBox();
            buttonPolicy = new Button();
            buttonOpeningHours = new Button();
            buttonEmployees = new Button();
            buttonShiftTimes = new Button();
            buttonShiftSchedule = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpeningHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCalendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiftTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiftScheduler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEmployees).BeginInit();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(948, 77);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(112, 34);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 519);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(11, 131);
            label1.Name = "label1";
            label1.Size = new Size(1127, 1);
            label1.TabIndex = 2;
            // 
            // pictureBoxOpeningHours
            // 
            pictureBoxOpeningHours.Image = (Image)resources.GetObject("pictureBoxOpeningHours.Image");
            pictureBoxOpeningHours.Location = new Point(25, 154);
            pictureBoxOpeningHours.Name = "pictureBoxOpeningHours";
            pictureBoxOpeningHours.Size = new Size(178, 142);
            pictureBoxOpeningHours.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOpeningHours.TabIndex = 3;
            pictureBoxOpeningHours.TabStop = false;
            pictureBoxOpeningHours.Click += pictureBoxOpeningHours_Click;
            // 
            // pictureBoxCalendar
            // 
            pictureBoxCalendar.Image = (Image)resources.GetObject("pictureBoxCalendar.Image");
            pictureBoxCalendar.Location = new Point(209, 154);
            pictureBoxCalendar.Name = "pictureBoxCalendar";
            pictureBoxCalendar.Size = new Size(181, 142);
            pictureBoxCalendar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCalendar.TabIndex = 4;
            pictureBoxCalendar.TabStop = false;
            // 
            // pictureShiftTime
            // 
            pictureShiftTime.Image = (Image)resources.GetObject("pictureShiftTime.Image");
            pictureShiftTime.Location = new Point(396, 154);
            pictureShiftTime.Name = "pictureShiftTime";
            pictureShiftTime.Size = new Size(151, 142);
            pictureShiftTime.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureShiftTime.TabIndex = 5;
            pictureShiftTime.TabStop = false;
            // 
            // pictureShiftScheduler
            // 
            pictureShiftScheduler.Image = (Image)resources.GetObject("pictureShiftScheduler.Image");
            pictureShiftScheduler.Location = new Point(739, 158);
            pictureShiftScheduler.Name = "pictureShiftScheduler";
            pictureShiftScheduler.Size = new Size(150, 138);
            pictureShiftScheduler.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureShiftScheduler.TabIndex = 6;
            pictureShiftScheduler.TabStop = false;
            // 
            // pictureReports
            // 
            pictureReports.Image = (Image)resources.GetObject("pictureReports.Image");
            pictureReports.Location = new Point(910, 161);
            pictureReports.Name = "pictureReports";
            pictureReports.Size = new Size(150, 135);
            pictureReports.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureReports.TabIndex = 7;
            pictureReports.TabStop = false;
            // 
            // pictureEmployees
            // 
            pictureEmployees.Image = (Image)resources.GetObject("pictureEmployees.Image");
            pictureEmployees.Location = new Point(566, 154);
            pictureEmployees.Name = "pictureEmployees";
            pictureEmployees.Size = new Size(150, 142);
            pictureEmployees.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEmployees.TabIndex = 8;
            pictureEmployees.TabStop = false;
            // 
            // buttonPolicy
            // 
            buttonPolicy.Location = new Point(25, 77);
            buttonPolicy.Name = "buttonPolicy";
            buttonPolicy.Size = new Size(112, 34);
            buttonPolicy.TabIndex = 9;
            buttonPolicy.Text = "Policies";
            buttonPolicy.UseVisualStyleBackColor = true;
            buttonPolicy.Click += buttonPolicy_Click;
            // 
            // buttonOpeningHours
            // 
            buttonOpeningHours.Location = new Point(39, 321);
            buttonOpeningHours.Name = "buttonOpeningHours";
            buttonOpeningHours.Size = new Size(152, 34);
            buttonOpeningHours.TabIndex = 10;
            buttonOpeningHours.Text = "OpeningHours";
            buttonOpeningHours.UseVisualStyleBackColor = true;
            buttonOpeningHours.Click += buttonOpeningHours_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Location = new Point(564, 321);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.RightToLeft = RightToLeft.Yes;
            buttonEmployees.Size = new Size(152, 34);
            buttonEmployees.TabIndex = 11;
            buttonEmployees.Text = "Employees";
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;
            // 
            // buttonShiftTimes
            // 
            buttonShiftTimes.Location = new Point(396, 321);
            buttonShiftTimes.Name = "buttonShiftTimes";
            buttonShiftTimes.RightToLeft = RightToLeft.Yes;
            buttonShiftTimes.Size = new Size(152, 34);
            buttonShiftTimes.TabIndex = 12;
            buttonShiftTimes.Text = "Shift Times";
            buttonShiftTimes.UseVisualStyleBackColor = true;
            buttonShiftTimes.Click += buttonShiftTimes_Click;
            // 
            // buttonShiftSchedule
            // 
            buttonShiftSchedule.Location = new Point(739, 321);
            buttonShiftSchedule.Name = "buttonShiftSchedule";
            buttonShiftSchedule.RightToLeft = RightToLeft.Yes;
            buttonShiftSchedule.Size = new Size(152, 34);
            buttonShiftSchedule.TabIndex = 13;
            buttonShiftSchedule.Text = "Shift Schedules";
            buttonShiftSchedule.UseVisualStyleBackColor = true;
            buttonShiftSchedule.Click += buttonShiftSchedule_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 519);
            Controls.Add(buttonShiftSchedule);
            Controls.Add(buttonShiftTimes);
            Controls.Add(buttonEmployees);
            Controls.Add(buttonOpeningHours);
            Controls.Add(buttonPolicy);
            Controls.Add(pictureEmployees);
            Controls.Add(pictureReports);
            Controls.Add(pictureShiftScheduler);
            Controls.Add(pictureShiftTime);
            Controls.Add(pictureBoxCalendar);
            Controls.Add(pictureBoxOpeningHours);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Controls.Add(buttonLogout);
            Name = "MainMenu";
            Text = "EF&Y - Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOpeningHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCalendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiftTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureShiftScheduler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Splitter splitter1;
        private Label label1;
        private PictureBox pictureBoxOpeningHours;
        private PictureBox pictureBoxCalendar;
        private PictureBox pictureShiftTime;
        private PictureBox pictureShiftScheduler;
        private PictureBox pictureReports;
        private PictureBox pictureEmployees;
        private Button button1;
        private Button buttonPolicy;
        private Button buttonOpeningHours;
        private Button buttonEmployees;
        private Button buttonShiftTimes;
        private Button buttonShiftSchedule;
    }
}
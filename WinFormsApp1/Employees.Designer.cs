namespace WinFormsApp1
{
    partial class Employees
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
            labelEmployeeNumber = new Label();
            textEmployeeNumber = new TextBox();
            labelEmployeeName = new Label();
            textEmployeeName = new TextBox();
            label2 = new Label();
            textPhoneNumber = new TextBox();
            label3 = new Label();
            textAddress = new TextBox();
            label4 = new Label();
            dateTimePickerHireDate = new DateTimePicker();
            label5 = new Label();
            dateTimePickerTerminationDate = new DateTimePicker();
            label6 = new Label();
            textTaxFileNumber = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonMainMenuE
            // 
            buttonMainMenuE.Location = new Point(920, 12);
            buttonMainMenuE.Name = "buttonMainMenuE";
            buttonMainMenuE.Size = new Size(112, 34);
            buttonMainMenuE.TabIndex = 0;
            buttonMainMenuE.Text = "MainMenu";
            buttonMainMenuE.UseVisualStyleBackColor = true;
            buttonMainMenuE.Click += buttonMainMenuE_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(1, 69);
            label1.Name = "label1";
            label1.Size = new Size(1063, 10);
            label1.TabIndex = 4;
            // 
            // labelEmployeeNumber
            // 
            labelEmployeeNumber.AutoSize = true;
            labelEmployeeNumber.Location = new Point(36, 96);
            labelEmployeeNumber.Name = "labelEmployeeNumber";
            labelEmployeeNumber.Size = new Size(160, 25);
            labelEmployeeNumber.TabIndex = 5;
            labelEmployeeNumber.Text = "Employee Number";
            // 
            // textEmployeeNumber
            // 
            textEmployeeNumber.Location = new Point(214, 93);
            textEmployeeNumber.Name = "textEmployeeNumber";
            textEmployeeNumber.Size = new Size(150, 31);
            textEmployeeNumber.TabIndex = 6;
            textEmployeeNumber.TextChanged += textEmployeeNumber_TextChanged;
            textEmployeeNumber.Validated += textEmployeeNumber_Validated;
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(479, 102);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(142, 25);
            labelEmployeeName.TabIndex = 7;
            labelEmployeeName.Text = "Employee Name";
            // 
            // textEmployeeName
            // 
            textEmployeeName.Location = new Point(647, 102);
            textEmployeeName.Name = "textEmployeeName";
            textEmployeeName.Size = new Size(366, 31);
            textEmployeeName.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 181);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 9;
            label2.Text = "Phone Number";
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(214, 181);
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.Size = new Size(150, 31);
            textPhoneNumber.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 187);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // textAddress
            // 
            textAddress.Location = new Point(647, 178);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(366, 31);
            textAddress.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 261);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 13;
            label4.Text = "Hire Date";
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.CustomFormat = "DD-Mon-YY";
            dateTimePickerHireDate.Format = DateTimePickerFormat.Short;
            dateTimePickerHireDate.Location = new Point(214, 261);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(123, 31);
            dateTimePickerHireDate.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 267);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 16;
            label5.Text = "Termination Date";
            // 
            // dateTimePickerTerminationDate
            // 
            dateTimePickerTerminationDate.CustomFormat = " ";
            dateTimePickerTerminationDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerTerminationDate.Location = new Point(647, 262);
            dateTimePickerTerminationDate.Name = "dateTimePickerTerminationDate";
            dateTimePickerTerminationDate.Size = new Size(123, 31);
            dateTimePickerTerminationDate.TabIndex = 17;
            dateTimePickerTerminationDate.Value = new DateTime(9998, 12, 30, 22, 25, 0, 0);
            dateTimePickerTerminationDate.ValueChanged += dateTimePickerTerminationDate_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 330);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 18;
            label6.Text = "TFN";
            label6.UseWaitCursor = true;
            // 
            // textTaxFileNumber
            // 
            textTaxFileNumber.Location = new Point(214, 324);
            textTaxFileNumber.Name = "textTaxFileNumber";
            textTaxFileNumber.Size = new Size(150, 31);
            textTaxFileNumber.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(513, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 20;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonSave_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
            Controls.Add(button1);
            Controls.Add(textTaxFileNumber);
            Controls.Add(label6);
            Controls.Add(dateTimePickerTerminationDate);
            Controls.Add(label5);
            Controls.Add(dateTimePickerHireDate);
            Controls.Add(label4);
            Controls.Add(textAddress);
            Controls.Add(label3);
            Controls.Add(textPhoneNumber);
            Controls.Add(label2);
            Controls.Add(textEmployeeName);
            Controls.Add(labelEmployeeName);
            Controls.Add(textEmployeeNumber);
            Controls.Add(labelEmployeeNumber);
            Controls.Add(label1);
            Controls.Add(buttonMainMenuE);
            Name = "Employees";
            Text = "FV&F Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMainMenuE;
        private Label label1;
        private Label labelEmployeeNumber;
        private TextBox textEmployeeNumber;
        private Label labelEmployeeName;
        private TextBox textEmployeeName;
        private Label label2;
        private TextBox textPhoneNumber;
        private Label label3;
        private TextBox textAddress;
        private Label label4;
        private DateTimePicker dateTimePickerHireDate;
        private Label label5;
        private DateTimePicker dateTimePickerTerminationDate;
        private Label label6;
        private TextBox textTaxFileNumber;
        private Button button1;
    }
}
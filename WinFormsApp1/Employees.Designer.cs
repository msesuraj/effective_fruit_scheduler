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
            textEmployeeNumber.Location = new Point(247, 96);
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
            // Employees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
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
    }
}
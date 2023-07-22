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
            label1.AutoSize = true;
            label1.Location = new Point(-1, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
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
    }
}
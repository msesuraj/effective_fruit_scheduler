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
            buttonLogout = new Button();
            splitter1 = new Splitter();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(676, 24);
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
            splitter1.Size = new Size(4, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(792, 1);
            label1.TabIndex = 2;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Controls.Add(buttonLogout);
            Name = "MainMenu";
            Text = "EF&Y - Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogout;
        private Splitter splitter1;
        private Label label1;
    }
}
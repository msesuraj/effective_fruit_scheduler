namespace WinFormsApp1
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            textLoginId = new TextBox();
            textPassword = new TextBox();
            buttonLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(163, 78);
            label1.Name = "label1";
            label1.Size = new Size(405, 47);
            label1.TabIndex = 0;
            label1.Text = "Enter UserId And Password";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 187);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "UserID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 240);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textLoginId
            // 
            textLoginId.Location = new Point(316, 181);
            textLoginId.Name = "textLoginId";
            textLoginId.Size = new Size(252, 31);
            textLoginId.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(316, 240);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(252, 31);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(355, 332);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(112, 34);
            buttonLogIn.TabIndex = 5;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 445);
            Controls.Add(buttonLogIn);
            Controls.Add(textPassword);
            Controls.Add(textLoginId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "EF&V Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textLoginId;
        private TextBox textPassword;
        private Button buttonLogIn;
    }
}
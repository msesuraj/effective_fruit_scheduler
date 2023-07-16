namespace WinFormsApp1
{
    partial class Policies
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Policies));
            RulesTitle = new TextBox();
            buttonMainMenu = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // RulesTitle
            // 
            RulesTitle.BackColor = SystemColors.Menu;
            RulesTitle.BorderStyle = BorderStyle.None;
            RulesTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            RulesTitle.Location = new Point(346, 123);
            RulesTitle.Name = "RulesTitle";
            RulesTitle.ReadOnly = true;
            RulesTitle.Size = new Size(178, 80);
            RulesTitle.TabIndex = 0;
            RulesTitle.Text = "Rules";
            RulesTitle.TextChanged += textBox1_TextChanged;
            // 
            // buttonMainMenu
            // 
            buttonMainMenu.Location = new Point(737, 12);
            buttonMainMenu.Name = "buttonMainMenu";
            buttonMainMenu.Size = new Size(112, 34);
            buttonMainMenu.TabIndex = 1;
            buttonMainMenu.Text = "Main Menu";
            buttonMainMenu.UseVisualStyleBackColor = true;
            buttonMainMenu.Click += buttonMainMenu_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-1, 114);
            label1.Name = "label1";
            label1.Size = new Size(865, 2);
            label1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(304, 209);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(274, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "When working at this shop";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(43, 255);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(789, 213);
            textBox2.TabIndex = 6;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Policies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 583);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonMainMenu);
            Controls.Add(RulesTitle);
            Name = "Policies";
            Text = "EF&V Policies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RulesTitle;
        private Button buttonMainMenu;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
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
            buttonSaveSF.Location = new Point(672, 422);
            buttonSaveSF.Name = "buttonSaveSF";
            buttonSaveSF.Size = new Size(112, 34);
            buttonSaveSF.TabIndex = 21;
            buttonSaveSF.Text = "Save";
            buttonSaveSF.UseVisualStyleBackColor = true;
            // 
            // ShiftTimes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 506);
            Controls.Add(buttonSaveSF);
            Controls.Add(buttonMainMenuST);
            Controls.Add(label1);
            Name = "ShiftTimes";
            Text = "EF&V Shift Times";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonMainMenuE;
        private Button buttonMainMenuST;
        private Button buttonSaveSF;
    }
}
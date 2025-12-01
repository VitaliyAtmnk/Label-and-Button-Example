namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl = new Label();
            btnText = new Button();
            btnFont = new Button();
            btnColor = new Button();
            btnBorder = new Button();
            btnAutoSize = new Button();
            btnMove = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(258, 98);
            lbl.Name = "lbl";
            lbl.Size = new Size(264, 25);
            lbl.TabIndex = 0;
            lbl.Text = "I am a Label";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnText
            // 
            btnText.Location = new Point(258, 144);
            btnText.Name = "btnText";
            btnText.Size = new Size(124, 38);
            btnText.TabIndex = 1;
            btnText.Text = "Text";
            btnText.UseVisualStyleBackColor = true;
            btnText.Click += btnText_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(398, 144);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(124, 38);
            btnFont.TabIndex = 1;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(258, 188);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(124, 38);
            btnColor.TabIndex = 1;
            btnColor.Text = "Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnBorder
            // 
            btnBorder.Location = new Point(398, 188);
            btnBorder.Name = "btnBorder";
            btnBorder.Size = new Size(124, 38);
            btnBorder.TabIndex = 1;
            btnBorder.Text = "Border";
            btnBorder.UseVisualStyleBackColor = true;
            btnBorder.Click += btnBorder_Click;
            // 
            // btnAutoSize
            // 
            btnAutoSize.Location = new Point(258, 232);
            btnAutoSize.Name = "btnAutoSize";
            btnAutoSize.Size = new Size(124, 38);
            btnAutoSize.TabIndex = 1;
            btnAutoSize.Text = "AutoSize";
            btnAutoSize.UseVisualStyleBackColor = true;
            btnAutoSize.Click += btnAutoSize_Click;
            // 
            // btnMove
            // 
            btnMove.Location = new Point(398, 232);
            btnMove.Name = "btnMove";
            btnMove.RightToLeft = RightToLeft.No;
            btnMove.Size = new Size(124, 38);
            btnMove.TabIndex = 1;
            btnMove.Text = "Move";
            btnMove.UseVisualStyleBackColor = true;
            btnMove.Click += btnMove_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(258, 276);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(264, 38);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset\r\n";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.MidnightBlue;
            CancelButton = btnReset;
            ClientSize = new Size(820, 466);
            Controls.Add(btnMove);
            Controls.Add(btnBorder);
            Controls.Add(btnFont);
            Controls.Add(btnReset);
            Controls.Add(btnAutoSize);
            Controls.Add(btnColor);
            Controls.Add(btnText);
            Controls.Add(lbl);
            Font = new Font("Segoe UI", 14F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private Label lbl;
        private Button btnText;
        private Button btnFont;
        private Button btnColor;
        private Button btnBorder;
        private Button btnAutoSize;
        private Button btnMove;
        private Button btnReset;
    }
}

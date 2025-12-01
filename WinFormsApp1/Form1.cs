namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Label copy;
        public Form1()
        {
            InitializeComponent();

            copy = new Label();
            copy.Size = lbl.Size;
            copy.AutoSize = lbl.AutoSize;
            copy.BackColor = lbl.BackColor;
            copy.ForeColor = lbl.ForeColor;
            copy.ForeColor = lbl.ForeColor;
            copy.BorderStyle = lbl.BorderStyle;
            copy.Left = lbl.Left;
            copy.Top = lbl.Top;
            copy.Font = lbl.Font;
        }


        private void btnText_Click(object sender, EventArgs e)
        {
            lbl.Text = "Text was changed";
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            float size = lbl.Font.Size;
            String fontName = lbl.Font.Name;

            if (size >= 24)
            {
                lbl.Enabled = false;
            }

            else
            {
                lbl.Font = new Font(fontName, size + 2);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            lbl.BackColor = lbl.BackColor == Color.Red ? Color.Blue : Color.Red;
        }

        private void btnBorder_Click(object sender, EventArgs e)
        {
            lbl.BorderStyle = lbl.BorderStyle == BorderStyle.None ? BorderStyle.FixedSingle : BorderStyle.None;
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            lbl.AutoSize = !lbl.AutoSize;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            lbl.Top -= lbl.Height;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbl.Size = copy.Size;
            lbl.AutoSize = copy.AutoSize;
            lbl.BackColor = copy.BackColor;
            lbl.ForeColor = copy.ForeColor;
            lbl.BorderStyle = copy.BorderStyle;
            lbl.Left = copy.Left;
            lbl.Top = copy.Top;
            lbl.Font = copy.Font;
            lbl.ForeColor = copy.ForeColor;
            lbl.Enabled = true;
        }
    }
}

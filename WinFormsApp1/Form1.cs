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
            // TODO: Zvìtšit pùvodní font o 2 body
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // TODO: Zmìnit barvu pozadí na modrou / èervenou.
            // Pokud je modrá, zmìnit na èervenou, pokud je èervená, zmìnit na modrou.
        }

        private void btnBorder_Click(object sender, EventArgs e)
        {
            // TODO: Pøepínat mezi BorderStyle.None a BorderStyle.FixedSingle
        }

        private void btnAutoSize_Click(object sender, EventArgs e)
        {
            // TODO: Pøepínat vlastnost AutoSize
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // TODO: Posunout label o velikost labelu nahoru + zajistit, aby zùstal viditelný v oknì formuláøe
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

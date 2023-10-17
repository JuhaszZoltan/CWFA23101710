namespace TotoGUI
{
    public partial class FrmToto : Form
    {
        public FrmToto()
        {
            InitializeComponent();
            txtEredmenyek.TextChanged += TxtEredmenyekTextChanged;
        }

        private void TxtEredmenyekTextChanged(object? sender, EventArgs e)
        {
            chbKarSzamHiba.Checked = txtEredmenyek.Text.Length != 14;
            chbKarSzamHiba.Text = $"Nem megfelelõ karakterszám({txtEredmenyek.Text.Length})";

            string invalid = string.Empty;
            foreach (char c in txtEredmenyek.Text)
                if (!"12X".Contains(c)) invalid += $"{c};";

            if (invalid.Length != 0) invalid = invalid[..^1];
            chbHelytelenKarHiba.Checked = invalid.Length != 0;
            chbHelytelenKarHiba.Text = $"Helytelen karakter az eredményekben ({invalid})";

            btnMentes.Enabled = !chbKarSzamHiba.Checked && !chbHelytelenKarHiba.Checked;
        }
    }
}
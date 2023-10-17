namespace TotoGUI
{
    public partial class FrmToto : Form
    {
        const string valid = "12X";

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
            foreach (char c in txtEredmenyek.Text) if (!valid.Contains(c)) invalid += $"{c};";
            chbHelytelenKarHiba.Checked = invalid.Length != 0;
            chbHelytelenKarHiba.Text = $"Helytelen karakter az eredményekben " +
                $"({(invalid.Length == 0 ? string.Empty : invalid[..^1])})";

            btnMentes.Enabled = !chbKarSzamHiba.Checked && !chbHelytelenKarHiba.Checked;
        }
    }
}
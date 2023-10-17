namespace TotoGUI
{
    partial class FrmToto
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
            lblUI01 = new Label();
            txtEredmenyek = new TextBox();
            btnMentes = new Button();
            chbKarSzamHiba = new CheckBox();
            chbHelytelenKarHiba = new CheckBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 20);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(419, 32);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Kérem a forduló eredményeit [1, 2, X]:";
            // 
            // tbxEredmenyek
            // 
            txtEredmenyek.Location = new Point(12, 74);
            txtEredmenyek.Name = "tbxEredmenyek";
            txtEredmenyek.Size = new Size(553, 39);
            txtEredmenyek.TabIndex = 1;
            txtEredmenyek.Text = "12X12X12X12X12";
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(12, 251);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(350, 50);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "Eredmények mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // chbKarSzamHiba
            // 
            chbKarSzamHiba.AutoSize = true;
            chbKarSzamHiba.Enabled = false;
            chbKarSzamHiba.Location = new Point(12, 135);
            chbKarSzamHiba.Name = "chbKarSzamHiba";
            chbKarSzamHiba.Size = new Size(396, 36);
            chbKarSzamHiba.TabIndex = 3;
            chbKarSzamHiba.Text = "Nem megfelelő karakterszám (14)";
            chbKarSzamHiba.UseVisualStyleBackColor = true;
            // 
            // chbHelytelenKarHiba
            // 
            chbHelytelenKarHiba.AutoSize = true;
            chbHelytelenKarHiba.Enabled = false;
            chbHelytelenKarHiba.Location = new Point(12, 193);
            chbHelytelenKarHiba.Name = "chbHelytelenKarHiba";
            chbHelytelenKarHiba.Size = new Size(462, 36);
            chbHelytelenKarHiba.TabIndex = 3;
            chbHelytelenKarHiba.Text = "Helytelen karakter az eredményekben ()";
            chbHelytelenKarHiba.UseVisualStyleBackColor = true;
            // 
            // FrmToto
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 332);
            Controls.Add(chbHelytelenKarHiba);
            Controls.Add(chbKarSzamHiba);
            Controls.Add(btnMentes);
            Controls.Add(txtEredmenyek);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmToto";
            Text = "Totó eredmény ellenőrző";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox txtEredmenyek;
        private Button btnMentes;
        private CheckBox chbKarSzamHiba;
        private CheckBox chbHelytelenKarHiba;
    }
}
namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Kort = new System.Windows.Forms.Panel();
            this.imieinazwisko = new System.Windows.Forms.Label();
            this.koniecgry_lbl = new System.Windows.Forms.Label();
            this.punkty_lbl = new System.Windows.Forms.Label();
            this.wynik_lbl = new System.Windows.Forms.Label();
            this.pilka = new System.Windows.Forms.PictureBox();
            this.rakieta = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Kort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieta)).BeginInit();
            this.SuspendLayout();
            // 
            // Kort
            // 
            this.Kort.Controls.Add(this.imieinazwisko);
            this.Kort.Controls.Add(this.koniecgry_lbl);
            this.Kort.Controls.Add(this.punkty_lbl);
            this.Kort.Controls.Add(this.wynik_lbl);
            this.Kort.Controls.Add(this.pilka);
            this.Kort.Controls.Add(this.rakieta);
            this.Kort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kort.Location = new System.Drawing.Point(0, 0);
            this.Kort.Name = "Kort";
            this.Kort.Size = new System.Drawing.Size(800, 450);
            this.Kort.TabIndex = 0;
            // 
            // imieinazwisko
            // 
            this.imieinazwisko.AllowDrop = true;
            this.imieinazwisko.AutoSize = true;
            this.imieinazwisko.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imieinazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieinazwisko.Location = new System.Drawing.Point(0, 430);
            this.imieinazwisko.Name = "imieinazwisko";
            this.imieinazwisko.Size = new System.Drawing.Size(224, 20);
            this.imieinazwisko.TabIndex = 6;
            this.imieinazwisko.Text = "Ping Pong by: Mateusz Strojek";
            this.imieinazwisko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // koniecgry_lbl
            // 
            this.koniecgry_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.koniecgry_lbl.AutoSize = true;
            this.koniecgry_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koniecgry_lbl.Location = new System.Drawing.Point(277, 33);
            this.koniecgry_lbl.Name = "koniecgry_lbl";
            this.koniecgry_lbl.Size = new System.Drawing.Size(383, 275);
            this.koniecgry_lbl.TabIndex = 5;
            this.koniecgry_lbl.Text = "Koniec Gry\r\n\r\nF1 - Restart\r\n\r\nEsc -Wyłącz gre ";
            this.koniecgry_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // punkty_lbl
            // 
            this.punkty_lbl.AutoSize = true;
            this.punkty_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punkty_lbl.Location = new System.Drawing.Point(159, 0);
            this.punkty_lbl.Name = "punkty_lbl";
            this.punkty_lbl.Size = new System.Drawing.Size(51, 55);
            this.punkty_lbl.TabIndex = 4;
            this.punkty_lbl.Text = "0";
            // 
            // wynik_lbl
            // 
            this.wynik_lbl.AutoSize = true;
            this.wynik_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik_lbl.Location = new System.Drawing.Point(3, 0);
            this.wynik_lbl.Name = "wynik_lbl";
            this.wynik_lbl.Size = new System.Drawing.Size(180, 55);
            this.wynik_lbl.TabIndex = 3;
            this.wynik_lbl.Text = "Wynik: ";
            // 
            // pilka
            // 
            this.pilka.BackColor = System.Drawing.Color.DarkRed;
            this.pilka.Location = new System.Drawing.Point(95, 95);
            this.pilka.Name = "pilka";
            this.pilka.Size = new System.Drawing.Size(30, 30);
            this.pilka.TabIndex = 2;
            this.pilka.TabStop = false;
            // 
            // rakieta
            // 
            this.rakieta.BackColor = System.Drawing.Color.Black;
            this.rakieta.Location = new System.Drawing.Point(287, 367);
            this.rakieta.Name = "rakieta";
            this.rakieta.Size = new System.Drawing.Size(200, 20);
            this.rakieta.TabIndex = 1;
            this.rakieta.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Kort.ResumeLayout(false);
            this.Kort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Kort;
        private System.Windows.Forms.PictureBox pilka;
        private System.Windows.Forms.PictureBox rakieta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punkty_lbl;
        private System.Windows.Forms.Label wynik_lbl;
        private System.Windows.Forms.Label koniecgry_lbl;
        private System.Windows.Forms.Label imieinazwisko;
    }
}


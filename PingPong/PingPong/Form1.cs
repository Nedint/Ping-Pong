using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            rakieta.Top = Kort.Bottom - (Kort.Bottom / 10);

            koniecgry_lbl.Left = (Kort.Width / 2) - (koniecgry_lbl.Width / 2);
            koniecgry_lbl.Top = (Kort.Height / 2) - (koniecgry_lbl.Height / 2);
            koniecgry_lbl.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rakieta.Left = Cursor.Position.X - (rakieta.Width / 2);

            pilka.Left += speed_left;
            pilka.Top += speed_top;

            if(pilka.Bottom >= rakieta.Top && pilka.Bottom <= rakieta.Bottom && pilka.Left >= rakieta.Left && pilka.Right <= rakieta.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                punkty_lbl.Text = points.ToString();

                Random r = new Random();
                Kort.BackColor = Color.FromArgb(r.Next(120, 255), r.Next(120, 255), r.Next(120, 255));
            }

            if(pilka.Left <= Kort.Left)
            {
                speed_left = -speed_left;
            }
            if(pilka.Right >= Kort.Right)
            {
                speed_left = -speed_left;
            }
            if(pilka.Top <= Kort.Top)
            {
                speed_top = -speed_top;
            }
            if(pilka.Bottom >= Kort.Bottom)
            {
                timer1.Enabled = false;

                koniecgry_lbl.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }

            if(e.KeyCode == Keys.F1)
            {
                pilka.Top = 50;
                pilka.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 4;
                punkty_lbl.Text = "0";
                timer1.Enabled = true;
                koniecgry_lbl.Visible = false;
                Kort.BackColor = Color.White;
            }
        }


    }
}

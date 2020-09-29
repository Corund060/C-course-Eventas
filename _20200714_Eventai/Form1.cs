using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200714_Eventai
{
    public partial class Form1 : Form
    {
        public class UzimtaZona
        {
            public Point XY1 { get; set; }
            public Point XY2 { get; set; }
        }

        List<UzimtaZona> uzimtuZonuSarasas;
        List<PictureBox> Kvadratai;
        public Form1()
        {
            uzimtuZonuSarasas = new List<UzimtaZona>();
            InitializeComponent();
            Kvadratai = new List<PictureBox>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pct = new PictureBox();
            pct.Location = new Point(30,30);
            foreach (var item in Kvadratai)
            {
                item.BackColor = Color.White;
            }
            pct.BackColor = Color.Red;
            pct.Width = 40;
            pct.Height=40;            
           
            pct.MouseClick += SelectBox;
            pct.BorderStyle = BorderStyle.FixedSingle;
            Kvadratai.Add(pct);
            Controls.Add(pct);
            
        }

        public void SelectBox(object sender, EventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            foreach (var item in Kvadratai)
            {
                item.BackColor = Color.White;
            }
            pct.BackColor = Color.Red;
        }

        public PictureBox RedCube()
        {
            return Kvadratai.Where(p=>p.BackColor==Color.Red).FirstOrDefault();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            PictureBox px=new PictureBox();
            switch (e.KeyChar)
            {
                case '8':
                    px = RedCube();
                    px.Location = new Point(px.Location.X, px.Location.Y-3);
                    break;
                case '6':
                    px = RedCube();
                    px.Location = new Point(px.Location.X+3, px.Location.Y);
                    break;
                case '4':
                    px = RedCube();
                    px.Location = new Point(px.Location.X - 3, px.Location.Y);
                    break;
                case '2':
                    px = RedCube();
                    px.Location = new Point(px.Location.X, px.Location.Y+3);
                    break;
                default:
                    break;
            }
        }
    }
}

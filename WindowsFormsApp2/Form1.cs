using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Bone> boneList;

        public Form1()
        {
            InitializeComponent();
            Data data = new Data();
            boneList = data.GetBonesPart("body");
            foreach(Bone bone in boneList)
            {
                Console.WriteLine(bone.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Console.WriteLine("X: " + e.X + "Y: " + e.Y);
           foreach(Bone bone in boneList)
            {
                if(IsInPolygon(bone.poly,new Point(e.X, e.Y)))
                {
                    Hand hand = new Hand(bone.name);
                    this.Hide();
                    hand.Show();
                }
            }
        }
        public static bool IsInPolygon(Point[] poly, Point p)
        {
            Point p1, p2;
            bool inside = false;

            if (poly.Length < 3)
            {
                return inside;
            }

            var oldPoint = new Point(
                poly[poly.Length - 1].X, poly[poly.Length - 1].Y);

            for (int i = 0; i < poly.Length; i++)
            {
                var newPoint = new Point(poly[i].X, poly[i].Y);

                if (newPoint.X > oldPoint.X)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
                    && (p.Y - (long)p1.Y) * (p2.X - p1.X)
                    < (p2.Y - (long)p1.Y) * (p.X - p1.X))
                {
                    inside = !inside;
                }

                oldPoint = newPoint;
            }

            return inside;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            foreach(Bone bone in boneList)
            {
                if(IsInPolygon(bone.poly,new Point(e.X, e.Y)))
                {
                    pictureBox1.Image = bone.imageBitmap;
                }
                else
                {
                    pictureBox1.Image = new Bitmap(WindowsFormsApp2.Properties.Resources.Squelette);
                }
            }
        }
        // pour dessiner les poly afin de vérifier
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {/*
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            foreach (Bone bone in boneList) {
                e.Graphics.FillPolygon(solidBrush, bone.poly);
                    }*/
        }
    }
}

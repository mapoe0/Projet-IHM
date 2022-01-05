using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Hand : Form
    {
        List<Bone> handList;

        Bitmap handBitmap;
        public Hand()
        {
            InitializeComponent();
            Data data = new Data("hand");
            handList = data.handList;
            foreach(Bone bone in handList)
            {
                Console.WriteLine(bone.name);
            }
        }
        private void Hand_Load(object sender, EventArgs e)
        {
            handBitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Main_originale);
            bonesPictureBox.Image = handBitmap;

        }
        public void ShowToolTip()
        {

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


        private void bonesPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("x= " + e.X + " Y= " + e.Y);
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 5000;
            foreach (Bone bone in handList)
            {
                if (IsInPolygon(bone.poly, new Point(e.X, e.Y)))
                {
                    Console.WriteLine("souris dans: " + bone.name);
                    int indexPoly = handList.IndexOf(bone);
             
                    tt.SetToolTip(bonesPictureBox, bone.name);
                    label1.Text = bone.name;
                    bonesPictureBox.Image = handList[indexPoly].imageBitmap;

                }//tes comit
                else
                {
                    bonesPictureBox.Image = handBitmap;
                }

            }

        }



        private void backImageBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

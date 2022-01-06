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
        String section;
        Bitmap handBitmap;
        Form1 master; // on demande à recevoir le master en paramètre pour pouvoir le fermer si l'utilisateur ferme le formulaire Hand
        bool btnClick = false; // technique de gitan pour revenir en arrière
        public Hand(String section, Form1 master)
        {
            InitializeComponent();
            this.section = section;
            this.master = master;
            Data data = new Data();
            handList = data.GetBonesPart("main");
            foreach(Bone bone in handList)
            {
                Console.WriteLine(bone.name);
            }
        }
        private void Hand_Load(object sender, EventArgs e)
        {
            if (section.Equals("main"))
            { handBitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Main_originale); }
            else if (section.Equals(""))
            {

            }
            bonesPictureBox.Image = handBitmap;
            

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

        }



        private void backImageBtn_Click(object sender, EventArgs e)
        {
            btnClick = true;
            this.Close();
            
        }

        private void bonesPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            foreach(Bone bone in handList)
            {
                if (IsInPolygon(bone.poly, new Point(e.X, e.Y)))
                {
                    
                    int indexPoly = handList.IndexOf(bone);
                    ChangeImage(true, bone.imageBitmap, bone.name);

                }
                else
                {
                    
                }
            }   
        }
        private void ChangeImage(bool b, Bitmap bitmap,String boneName)
        {
            if (b)
            {
                bonesPictureBox.Image = bitmap;
                label1.Text = boneName;
            }
        }

        private void Hand_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnClick == true)
            {
                master.Show(); // si on fait pas ça le Form 1 ne se ferme pas
            }
            else
            {            
                master.Close();
            }
        }
    }
}

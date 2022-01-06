using System;

using System.Drawing;


namespace WindowsFormsApp2
{
    /**
     * Classe pour initialiser les os et les manipulers plus facilement
     *  
     */
    class Bone
    {
        public String name; // nom de l'os
        public Point[] poly; // polygone associé sur l'image
        public Bitmap imageBitmap; // image associé
        public Bone(String name, Point[] poly, Bitmap imageBitmap)
        {
            this.name = name;
            this.poly = poly;
            this.imageBitmap = imageBitmap;
        }
    }
}

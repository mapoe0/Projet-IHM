using System;
using System.Collections.Generic;
using System.Drawing;


namespace WindowsFormsApp2
{
    /**Class pour éviter de surcharger les classes Form
     * 
     */
    class Data
    {
        public Data()
        {
   
        }
        /**
         * 
         */
        public List<Bone> GetBonesPart(String part)
        {
            Console.WriteLine("1");
            List<Bone> bonesList = new List<Bone> { };
            if (part == "main")
            {
                Bitmap bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_métacarpien_1);
                Bone bone;
                bone = new Bone("os métacarpien", new Point[] {
                new Point(94,183),
                new Point(113,182),
                new Point(138,257),
                new Point(119,270)
            }, bitmap
                );
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_4);
                bone = new Bone("phalange proximale", new Point[]
                {
                new Point(227,151),
                new Point(246,155),
                new Point(232,207),
                new Point(211,206)
                }, bitmap);

                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_3);
                bone = new Bone("phalange proximale", new Point[]
                {
                new Point(183,107),
                new Point(201,111),
                new Point(198,172),
                new Point(177,175)
                }, bitmap);

                bonesList.Add(bone);
            }
            else if(part.Equals("body"))
            {
                Console.WriteLine("2");
                Bitmap bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Squelette_main);
                Bone bone;
                bone = new Bone("main", new Point[]
                {
                    new Point(6,240),
                    new Point(40,241),
                    new Point(38,278),
                    new Point(5,276)
                }, bitmap) ;

                bonesList.Add(bone);
                bone = new Bone("main", new Point[]
                {
                    new Point(145,237),
                    new Point(191,234),
                    new Point(186,277),
                    new Point(153,276)
                }, bitmap);
                bonesList.Add(bone);
            }
            return bonesList;
        }
    }
}

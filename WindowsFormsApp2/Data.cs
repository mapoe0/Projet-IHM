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
         * test comit
         */
        public List<Bone> GetBonesPart(String part)
        {
            Console.WriteLine("1");
            List<Bone> bonesList = new List<Bone> { };
            if (part == "main")
            {
                

                Bitmap bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Capitatum);
                Bone bone = new Bone("Capitatum", new Point[]{
                    new Point(142,271),
                    new Point(165,272),
                    new Point(166,298),
                    new Point(145,297),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Hamatym);
                bone = new Bone("Hamatum", new Point[]
                {
                    new Point(170,272),
new Point(192,282),
new Point(191,294),
new Point(169,300),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Lunatum);
                bone = new Bone("Lunatum", new Point[]
                {
                    new Point(145,306),
new Point(162,305),
new Point(179,322),
new Point(161,325),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Scaphoide);
                bone = new Bone("Scaphoide", new Point[]
                {
                    new Point(121,308),
new Point(141,296),
new Point(159,329),
new Point(131,326),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Trapeze);
                bone = new Bone("Trapeze", new Point[]
                {
                    new Point(103,296),
new Point(110,282),
new Point(124,300),
new Point(120,314),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Trapezoide);
                bone = new Bone("Trapezoide", new Point[]
                {
                    new Point(114,281),
new Point(135,270),
new Point(141,295),
new Point(127,301),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Triquetum);
                bone = new Bone("Triquetum ", new Point[]
                {
                    new Point(171,307),
new Point(194,295),
new Point(200,307),
new Point(182,322),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_metacarpien_0);
                bone = new Bone("Os metacarpien 0", new Point[]
                {
                    new Point(44,245),
new Point(57,235),
new Point(110,275),
new Point(98,292),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_metacarpien_1);
                bone = new Bone("Os metacarpien 1", new Point[]
                {
                    new Point(94,183),
new Point(112,180),
new Point(140,264),
new Point(117,268),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_metacarpien_2);
                bone = new Bone("Os metacarpien 2", new Point[]
                {
                    new Point(132,181),
new Point(156,178),
new Point(164,265),
new Point(140,261),

                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_metacarpien_3);
                bone = new Bone("Os metacarpien 3", new Point[]
                {
                    new Point(173,179),
new Point(199,182),
new Point(181,266),
new Point(167,256),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_metacarpien_4);
                bone = new Bone("Os metacarpien 4", new Point[]
                {
                    new Point(206,209),
new Point(225,216),
new Point(198,281),
new Point(181,269),
                }, bitmap);
                bonesList.Add(bone);
                // phalanges distales
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_distale_0);
                bone = new Bone("Phalange distale 0 ", new Point[]
                {
                    new Point(9,144),
new Point(28,146),
new Point(32,180),
new Point(15,183),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_distale_1);
                bone = new Bone("Phalange distale 1 ", new Point[]
                {
                   new Point(67,34),
new Point(82,34),
new Point(86,64),
new Point(72,66),

                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_distale_2);
                bone = new Bone("Phalange distale 2 ", new Point[]
                {
                    new Point(129,11),
new Point(140,12),
new Point(143,45),
new Point(131,44),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_distale_3);
                bone = new Bone("Phalange distale 3 ", new Point[]
                {
                    new Point(193,22),
new Point(208,22),
new Point(207,56),
new Point(191,56),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_distale_4);
                bone = new Bone("Phalange distale 4 ", new Point[]
                {
                    new Point(243,71),
new Point(253,72),
new Point(252,101),
new Point(233,100),

                }, bitmap);
                bonesList.Add(bone);
                // PHALANGE PROXIMAL

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_0);
                bone = new Bone("Phalange proximal 0", new Point[]
                {
new Point(16,184),
new Point(37,183),
new Point(54,224),
new Point(38,241),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_1);
                bone = new Bone("phalange proximal 1", new Point[]
                {
                    new Point(82,116),
new Point(100,114),
new Point(117,174),
new Point(92,175),
                }, bitmap);
                bonesList.Add(bone);

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_2);
                bone = new Bone("phalange proximal 2", new Point[]
                {
                    new Point(132,103),
new Point(151,103),
new Point(156,170),
new Point(130,171),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_3);
                bone = new Bone("phalange proximal 3", new Point[]
                {
                    new Point(181,109),
new Point(202,108),
new Point(197,174),
new Point(174,174),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_4);
                bone = new Bone("Phalange proximal 4", new Point[]
                {
                    new Point(225,149),
new Point(247,154),
new Point(234,221),
new Point(208,202),
                }, bitmap);
                bonesList.Add(bone);

                // PHALANGE MOYENNE
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_moyenne_0);
                bone = new Bone("Phalange moyenne 1", new Point[]
                {
                    new Point(70,67),
new Point(88,64),
new Point(96,109),
new Point(82,111),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_moyenne_2);
                bone = new Bone("Phalange moyenne 2", new Point[]
                {
                new Point(132,49),
new Point(144,50),
new Point(149,99),
new Point(131,101),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_moyenne_3);
                bone = new Bone("Phalange moyenne 3", new Point[]
                {
                    new Point(189,59),
new Point(206,59),
new Point(201,107),
new Point(184,103),
                }, bitmap);
                bonesList.Add(bone);
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_moyenne_4);
                bone = new Bone("Phalange moyenne 4", new Point[]
                {
                    new Point(233,104),
new Point(251,104),
new Point(246,149),
new Point(229,141),

                }, bitmap);
                bonesList.Add(bone);
                /*
                 * 
                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources);
                bone = new Bone("title", new Point[]
                {

                }, bitmap);
                bonesList.Add(bone);

                */
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

                bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.Squelette_pied);
                bone = new Bone("pied", new Point[]
                {
                    new Point(63,422),
                    new Point(130,427),
                    new Point(132,447),
                    new Point(63,444)
                }, bitmap);
                
                bonesList.Add(bone);

                
            }
            return bonesList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /**Class pour éviter de surcharger les classes Form
     * 
     */
    class Data
    {
        public List<Bone> handList;
        public List<Bone> footList;
        public Data(String part)
        {
            if (part.Equals("hand"))
            {
                handList = GetBonesPart(part);
            }
            else
            {

            }
        }
        public List<Bone> GetBonesPart(String part)
        {
            List<Bone> bonesList = new List<Bone> { };
            Bitmap bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.os_métacarpien_1);
            Bone bone;
            bone = new Bone("os métacarpien", new Point[] {
                new Point(94,183),
                new Point(113,182),
                new Point(138,257),
                new Point(119,270)
            }, bitmap
            );
            bitmap = new Bitmap(WindowsFormsApp2.Properties.Resources.phalange_proximale_4);
            bonesList.Add(bone);
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
            },  bitmap);

            bonesList.Add(bone);
            return bonesList;
        }
    }
}

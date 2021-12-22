using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public class Htree
    {
        public static Label[] labels = new Label[7];
        public static Htree[] nodes = new Htree[7];

        public static Label getLabel(int index)
        {
            Label label = new Label();
            label.Size = new System.Drawing.Size(30, 30);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labels[index] = label;
            return label;
        }
        public static void HNode()
        {



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public class Bstree
    {
        public static treeNode rootNode = new treeNode();

        public static Label getLabel(string text)
        {
            Label label = new Label();
            label.Size = new System.Drawing.Size(30, 30);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label.Text = text;
            label.BackColor =System.Drawing.Color.White;

            if(treeNode.countNode == 0)
            {
                label.Location = new System.Drawing.Point(250, 0);
                rootNode.xPoint = 400;
                rootNode.data = label;
                treeNode.countNode++;
                return rootNode.data;
            }
            else
            {
                treeNode tNode = new treeNode(label);
                rootNode.inSertNode(tNode);
                return tNode.data;
            }
        }
    }
}

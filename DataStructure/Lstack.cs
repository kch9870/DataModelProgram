using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public class Lstack
    {

        public static Label[] labels = new Label[10];
        public static Label getLabel(int index)
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(30, 300 - index * 33);
            label.Name = "label" + index.ToString();
            label.Size = new System.Drawing.Size(80, 35);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labels[index] = label;
            return label;
        }
        public static void push(int index, string text)
        {
            labels[index].Text = text;
        }
        public static void pop(int index)
        {
            labels[index].Text = "";
        }
   
    } 
    
}

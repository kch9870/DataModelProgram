using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public static class LDequeue
    {
        public static Label[] labels = new Label[10];
        public static Label getLabel(int index)
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(35, 330 - index * 33);
            label.Name = "label" + index.ToString();
            label.Size = new System.Drawing.Size(80, 35);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labels[index] = label;
            return label;
        }
        public static void fEnqueue(int rearIndex, string text)     //삽입front정의 함수 
        {          
            for (int frontindex= rearIndex+1; -1 < frontindex; frontindex--)
            {
                labels[frontindex+1].Text = labels[frontindex].Text;
            }
            labels[0].Text = text;
        }
        public static void dEnqueue(int rearindex,string text)
        {
            labels[rearindex].Text = text;
        }
        public static void fDequeue(int frontindex)
        {
            for (frontindex = 0; frontindex < 9; frontindex++)
            {
                labels[frontindex].Text = labels[frontindex + 1].Text;
            }
            labels[9].Text = "";
        }
        public static void dDequeue(int rearindex)
        {
            labels[rearindex+1].Text = "";
        }
    }
   
}

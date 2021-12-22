using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public static class LQueue
    {
        public static Label[] labels = new Label[10];
        public static Label getLabel(int index)//i값이 필요하니까 매개변수로 받아오면 되겠지
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(35, 330 - index * 33);
            label.Name = "label" + index.ToString();
            label.Size = new System.Drawing.Size(80, 35);
            label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labels[index] = label;
            return label;
        }
        public static void enqueue(int rearindex,string text)       //삽입 함수
        {
            labels[rearindex].Text = text;      //text값을 label의 배열에 집어 넣어준다.
        }
        public static void dequeue(int frontindex)//삭제 함수 정의
        {
            for(frontindex=0;frontindex<9;frontindex++)
            {
                labels[frontindex].Text = labels[frontindex + 1].Text;
            }
            labels[9].Text = "";
        }
    }
}

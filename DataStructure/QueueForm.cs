using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class QueueForm : Form
    {
        int frontIndex = 0;
        int rearIndex = -1;

        public QueueForm()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(LQueue.getLabel(i));
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rearIndex < 9 && !textBox1.Text.Equals(""))
            {
                rearIndex++;//이때 rearIndex의 값은 증가한다,frontIndex 값은 그대로
                LQueue.enqueue(rearIndex, textBox1.Text);//삽입하는 함수를 쓴다.
                setTopIndex();
                textBox1.Text = "";            
            }
            else MessageBox.Show("큐 포화 상태 입니다");
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rearIndex > -1)
            {
                rearIndex--;//rear는 1빼주고 front는 그대로
                LQueue.dequeue(frontIndex);//삭제하는 함수 선언(frontIndex를 가지고 간다.)
                setTopIndex();
            }
            else MessageBox.Show("큐 공백 상태 입니다");
           
        }
        void setTopIndex()
        {
            textBox2.Text = (rearIndex + 1).ToString();
        }
    }
}

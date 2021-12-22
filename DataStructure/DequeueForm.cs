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
    public partial class DequeueForm : Form
    {
        int frontIndex = 0;
        int rearIndex = -1;

        public DequeueForm()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(LDequeue.getLabel(i));
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   //Front 삽입버튼
        {
            if (rearIndex < 9 && !textBox1.Text.Equals(""))
            {
                rearIndex++;
                LDequeue.fEnqueue(rearIndex, textBox1.Text);
                setTopIndex();
                textBox1.Text = "";
            }
            else MessageBox.Show("덱 포화 상태");
            
        }

        private void button2_Click(object sender, EventArgs e)  //Rear 삽입버튼
        {
            if (rearIndex < 9 && !textBox1.Text.Equals(""))
            {
                rearIndex++;
                LDequeue.dEnqueue(rearIndex, textBox1.Text);
                setTopIndex();
                textBox1.Text = "";
            }
            else MessageBox.Show("덱 포화 상태");
        }

        private void button3_Click(object sender, EventArgs e)  //Front 삭제버튼
        {
            if (rearIndex > -1)
            {
                rearIndex--;
                LDequeue.fDequeue(frontIndex);
                setTopIndex();
            }
            else MessageBox.Show("덱 공백 상태");
        }
             

        private void button4_Click(object sender, EventArgs e)  //Rear 삭제버튼
        {
            if (rearIndex > -1)
            {
                rearIndex--;
                LDequeue.dDequeue(rearIndex);
                setTopIndex();
            }
            else MessageBox.Show("덱 공백 상태");

        }

        void setTopIndex()
        {
            textBox2.Text = (rearIndex + 1).ToString();
        }
    }
}

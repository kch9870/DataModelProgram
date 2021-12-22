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
    public  partial class StackForm : Form
    {
        int topIndex = -1;
        public StackForm()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(Lstack.getLabel(i));
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (topIndex < 9 && !textBox1.Text.Equals(""))
            {
                topIndex++;
                Lstack.push(topIndex, textBox1.Text);
                setTopIndex();
                textBox1.Text = "";
            }
            else MessageBox.Show("스택이 포화 상태 입니다!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(topIndex > -1)
            {
                Lstack.pop(topIndex);
                topIndex--;
                setTopIndex();
            }
            else MessageBox.Show("스택이 공백 상태 입니다!");
        }
        void setTopIndex()
        {
            textBox2.Text = (topIndex+1).ToString();
        }
    }
}

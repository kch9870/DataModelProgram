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
    public partial class MaxHeap : Form
    {
        public MaxHeap()
        {
            for (int i = 0; i < 7; i++)
            {
                this.Controls.Add(LDequeue.getLabel(i));
            }
            InitializeComponent();
        }
        
    }
}

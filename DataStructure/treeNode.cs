using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public class treeNode
    {
        public static int countNode = 0;
        treeNode pNode, lNode, rNode;
        public Label data;
        public int xPoint = 0;
        int yPoint = 30;
        bool isRoot = false;
        int i=0;

        public treeNode()
        {
            isRoot = true;
        }
        public treeNode(Label data)
        {
            this.data = data;
            lNode = null;
            rNode = null;
            countNode++;
        }
        public void inSertNode(treeNode node)
        {
            node.yPoint += 30;
            if (int.Parse(this.data.Text) < int.Parse(node.data.Text))
            {
                if (this.rNode == null)
                {
                    this.rNode = node;
                    node.pNode = this;
                    //node.xPoint = node.pNode.xPoint;
                    if (this.data.Location.X >= 250)
                    {
                      
                        node.data.Location = new System.Drawing.Point((int)((this.data.Location.X + 500)/2), yPoint);
                    }
                    else
                    {
                        node.data.Location = new System.Drawing.Point((int)((this.data.Location.X + 250) /2), yPoint);
                    }
                    return ;
                }
                else
                {
                    rNode.inSertNode(node);
                }
            }
            else if (int.Parse(this.data.Text) > int.Parse(node.data.Text))
            {
                if (this.lNode == null)
                {
                    this.lNode = node;
                    node.pNode = this;
                    if (this.data.Location.X > 250)
                    {
                       
                        node.data.Location = new System.Drawing.Point((int)((this.data.Location.X + 250) /2), yPoint);
                    }
                    else
                    {
                        node.data.Location = new System.Drawing.Point((int)(this.data.Location.X /2), yPoint);

                    } 
                    return ;
                }
                else
                {
                   lNode.inSertNode(node);
                }
            }
            else if (int.Parse(this.data.Text) == int.Parse(node.data.Text)) { MessageBox.Show("중복됩니다!"); }//오류처리
        }
        public void deleteNode(treeNode node)
        {

        }
    }
}

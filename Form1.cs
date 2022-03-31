using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayToStackbtn_Click(object sender, EventArgs e)
        {
            ArrayTypeStack ats = new ArrayTypeStack(8);
            ats.Push(1);
            ats.Push(2);
            ats.Push(3);
            
            MessageBox.Show(ats.Pop().ToString());
            MessageBox.Show(ats.Pop().ToString());
            MessageBox.Show(ats.Peek().ToString());

            string stack = ats.Pop().ToString();
            MessageBox.Show(stack);

        }
    }
}

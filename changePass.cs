using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_ISA
{
    public partial class changePass : Form
    {
        Controller c;
        string Type;
        
        public changePass(string type)
        {
            InitializeComponent();
            c = new Controller();
            Type = type; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""))
            {
                if (c.changePass(Convert.ToInt32(textBox1.Text.ToString()), textBox2.Text.ToString(), textBox3.Text, Type) == 0)
                {
                    MessageBox.Show("faild");
                }
                else
                {
                    MessageBox.Show("password has been changed to \""+ textBox3.Text+"\"");
                }
            }
        }
    }
}

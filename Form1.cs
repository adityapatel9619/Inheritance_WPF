using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_WPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                label8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            AddInfo info = new AddInfo(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,int.Parse(textBox5.Text),int.Parse(textBox6.Text));

            Inherit inherit = new Inherit(textBox1.Text,textBox2.Text,textBox3.Text);
            label8.Text = inherit.processbasic() + info.processAdd();
        }

        
    }
}

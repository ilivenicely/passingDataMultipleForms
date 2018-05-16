using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();


        }

        public Form2(string f)
        {
            InitializeComponent();
            richTextBox1.AppendText(" Number of list items: " + f);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

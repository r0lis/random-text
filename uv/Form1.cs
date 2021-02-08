using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random ran = new Random();
        char[] letters = "irngniribfjkngiogturoafnngoti".ToArray();
        string output;

        void generate(int NoOFLetter)
            
        {
            output = null;
            for (int i=0; i< NoOFLetter; i++) {
                output += letters[ran.Next(0, letters.Length)];
            }
            textBox1.Text = output;
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            generate(4);
        }
    }
}

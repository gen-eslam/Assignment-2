using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Assignment_2
{
    public partial class Form1 : Form
    {
        string[] lines;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtbx1.Text = "";
            StreamReader streamReader = new StreamReader("Test.txt");
            string str = streamReader.ReadToEnd();
            lines = str.Split('\n');
            int f;
            if(lines.Length>=5)
            {
                f = 5;
            }
            else
            {
                f = lines.Length;
            }
            for (int i = 0; i < f; i++)
            {
                txtbx1.Text += lines[i]+Environment.NewLine;
            }
            streamReader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbx1.Text = "";
            StreamReader streamReader = new StreamReader("Test.txt");
            string str = streamReader.ReadToEnd();
            lines = str.Split('\n');
            int final;
            if (lines.Length >= 5)
            {
                final = (lines.Length - 5);
            }
            else
            {
                final = 0;
            }
            for (int i = final; i < lines.Length ; i++)
            {
                txtbx1.Text += lines[i] + Environment.NewLine;
            }
            streamReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 go = new Form2();
            go.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 go = new Form3();
            go.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 go = new Form4();
            go.Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 go = new Form6();
            go.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports go = new Reports(); 
            go.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go= new Form1();
            go.Show(); this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XMLProject go= new XMLProject();
            go.Show(); this.Hide();
        }
    }
}

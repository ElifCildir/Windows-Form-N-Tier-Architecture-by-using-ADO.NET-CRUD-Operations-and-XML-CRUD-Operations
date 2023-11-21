using BL;
using DAL;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 go=new Form5();
            go.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go=new Form1();   
            go.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle vehicle =new Vehicle();
            vehicle.VehicleType = textBox1.Text;
            vehicle.VehicleCapacity = textBox2.Text;
            vehicle.VehicleDriver= textBox3.Text;
            vehicle.VehicleExpense=Convert.ToDecimal(textBox4.Text);

            VECCRUD.Add(vehicle);
            dataGridView1.DataSource = VECCRUD.Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  VECCRUD.Listele();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form5 go =new Form5();
            go.Show(); this.Hide(); 
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form1 go= new Form1();
            go.Show(); this.Hide();
        }
    }
}

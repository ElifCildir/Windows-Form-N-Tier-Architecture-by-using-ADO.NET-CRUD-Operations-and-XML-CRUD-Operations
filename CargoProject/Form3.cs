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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.DeliveryName= textBox1.Text;
            delivery.DeliveryPickupPoint= textBox2.Text;
            delivery.DeliveryPoint= textBox3.Text;
            delivery.DeliveryDistance = Convert.ToDecimal(textBox4.Text);
            delivery.DeliveryPrice = Convert.ToDecimal(textBox5.Text);
            delivery.CustomerNumber = Convert.ToInt32(textBox6.Text);
            delivery.VehicleNo=Convert.ToInt32(textBox7.Text);
            delivery.StaffNumber= Convert.ToInt32(textBox8.Text);

            DELCRUD.Add(delivery);
            dataGridView1.DataSource = DELCRUD.Listele();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DELCRUD.Listele();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delivery delivery= new Delivery();
            delivery.DeliveryNumber= Convert.ToInt32(textBox1.Tag);
            delivery.DeliveryName = textBox1.Text;
            delivery.DeliveryPickupPoint = textBox2.Text;
            delivery.DeliveryPoint = textBox3.Text;
            delivery.DeliveryDistance = Convert.ToDecimal(textBox4.Text);
            delivery.DeliveryPrice = Convert.ToDecimal(textBox5.Text);
            delivery.CustomerNumber = Convert.ToInt32(textBox6.Text);
            delivery.VehicleNo = Convert.ToInt32(textBox7.Text);
            delivery.StaffNumber = Convert.ToInt32(textBox8.Text);

            DELCRUD.Update(delivery);
            dataGridView1.DataSource = DELCRUD.Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["DeliveryNumber"].Value.ToString();
            textBox1.Text = column.Cells["DeliveryName"].Value.ToString();
            textBox2.Text = column.Cells["DeliveryPickupPoint"].Value.ToString();
            textBox3.Text = column.Cells["DeliveryPoint"].Value.ToString();
            textBox4.Text = column.Cells["DeliveryDistance"].Value.ToString();
            textBox5.Text = column.Cells["DeliveryPrice"].Value.ToString();
            textBox6.Text = column.Cells["CustomerNumber"].Value.ToString();
            textBox7.Text = column.Cells["VehicleNo"].Value.ToString();
            textBox8.Text = column.Cells["StaffNumber"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.DeliveryNumber = Convert.ToInt32(textBox1.Tag);
            DELCRUD.Delete(delivery);
            dataGridView1.DataSource = DELCRUD.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.DeliveryPoint = textBox3.Text;

            DELCRUD.Search(delivery);

            dataGridView1.DataSource = DELCRUD.Search(delivery);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 go = new Form5();
            go.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show(); this.Hide();
        }
    }
    }
    


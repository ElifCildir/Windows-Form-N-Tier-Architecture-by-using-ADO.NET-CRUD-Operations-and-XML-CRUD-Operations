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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerPaymentStatus = textBox4.Text;
           CUSCRUD.SearchCus(customer);

            dataGridView1.DataSource = CUSCRUD.SearchCus(customer);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CUSCRUD.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            customer.CustomerNameSurname = textBox1.Text;
            customer.CustomerAddress = textBox2.Text;
            customer.CustomerMail = textBox3.Text;
            customer.CustomerPaymentStatus = textBox4.Text;

            CUSCRUD.Add(customer);
            dataGridView1.DataSource = CUSCRUD.Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();
            customer.CustomerNumber = Convert.ToInt32(textBox1.Tag);
            customer.CustomerNameSurname = textBox1.Text;
            customer.CustomerAddress = textBox2.Text;
            customer.CustomerMail = textBox3.Text;
            customer.CustomerPaymentStatus = textBox4.Text;

            CUSCRUD.Update(customer);
            dataGridView1.DataSource = CUSCRUD.Listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["CustomerNumber"].Value.ToString();
            textBox1.Text = satir.Cells["CustomerNameSurname"].Value.ToString();
            textBox2.Text = satir.Cells["CustomerAddress"].Value.ToString();
            textBox3.Text = satir.Cells["CustomerMail"].Value.ToString();
            textBox4.Text = satir.Cells["CustomerPaymentStatus"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        Customer customer = new Customer();
            customer.CustomerNumber = Convert.ToInt32(textBox1.Tag);
            CUSCRUD.Delete(customer);
     
            dataGridView1.DataSource = CUSCRUD.Listele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 go= new Form5();
            go.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go= new Form1();
            go.Show();
            this.Hide();
        }
    }

       
    }


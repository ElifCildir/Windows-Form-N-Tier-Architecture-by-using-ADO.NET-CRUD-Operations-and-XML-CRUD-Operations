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
using System.Windows.Forms.VisualStyles;

namespace CargoProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = STAFFCRUD.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.StaffNameSurname = textBox1.Text; 
            staff.StaffRole= textBox2.Text;
            staff.StaffTitle= textBox3.Text;
            staff.StaffPhone = textBox4.Text;
            staff.StaffMail= textBox5.Text;
            staff.StaffWage = Convert.ToDecimal(textBox6.Text);

            STAFFCRUD.Add(staff);
            dataGridView1.DataSource = STAFFCRUD.Listele();


        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow  column = dataGridView1.CurrentRow;
            textBox1.Tag = column.Cells["StaffNumber"].Value.ToString();
            textBox1.Text = column.Cells["StaffNameSurname"].Value.ToString();
            textBox2.Text = column.Cells["StaffRole"].Value.ToString();
            textBox3.Text = column.Cells["StaffTitle"].Value.ToString();
            textBox4.Text = column.Cells["StaffPhone"].Value.ToString();
            textBox5.Text = column.Cells["StaffMail"].Value.ToString();
            textBox6.Text = column.Cells["StaffWage"].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.StaffNumber = Convert.ToInt32(textBox1.Tag);
            staff.StaffNameSurname = textBox1.Text;
            staff.StaffRole = textBox2.Text;
            staff.StaffTitle = textBox3.Text;
            staff.StaffPhone = textBox4.Text;
            staff.StaffMail = textBox5.Text;
            staff.StaffWage = Convert.ToDecimal(textBox6.Text);

            STAFFCRUD.Update(staff);
            dataGridView1.DataSource = STAFFCRUD.Listele();



        }

        private void button4_Click(object sender, EventArgs e)
        {

            Staff staff= new Staff();
            staff.StaffNumber = Convert.ToInt32(textBox1.Tag);

            STAFFCRUD.Delete(staff);
            dataGridView1.DataSource=STAFFCRUD.Listele();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Staff staff=  new Staff();
            staff.StaffRole = textBox2.Text;

            STAFFCRUD.Search(staff);
            dataGridView1.DataSource = STAFFCRUD.Search(staff);


        }
    }

     
    }


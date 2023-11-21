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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CargoProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();

            REPCRUD.SumofDelivery(report);
            dataGridView1.DataSource = REPCRUD.SumofDelivery(report);

            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Report report = new Report();

            REPCRUD.SumofDelivery(report);
            dataGridView1.DataSource = REPCRUD.DeliveryOrder(report);




        }

        private void button3_Click(object sender, EventArgs e)
        {


            Report report = new Report();

            REPCRUD.SumofDelivery(report);
            dataGridView1.DataSource = REPCRUD.JoinedCustomer(report);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Report report = new Report();

            REPCRUD.AvgSalary(report);
            dataGridView1.DataSource = REPCRUD.AvgSalary(report);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report report = new Report();

            REPCRUD.JoinVecDelStaff(report);
            dataGridView1.DataSource = REPCRUD.JoinVecDelStaff(report);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report report = new Report();

            REPCRUD.StaffDelCus(report);
            dataGridView1.DataSource = REPCRUD.StaffDelCus(report);


        }

        private void button7_Click(object sender, EventArgs e)
        {

            Report report = new Report();

            REPCRUD.Vec2(report);
            dataGridView1.DataSource = REPCRUD.Vec2(report);

        }

        private void button8_Click(object sender, EventArgs e)
        {


            Report report = new Report();

            REPCRUD.Vec3(report);
            dataGridView1.DataSource = REPCRUD.Vec3(report);



        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 go = new Form5();
            go.Show(); this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 go    = new Form1();
            go.Show(); this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CargoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection coon = new SqlConnection("Server=.;Database=CargoAutomation;Integrated Security=true;");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = coon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AdminLogin";
            cmd.Parameters.AddWithValue("UserrName", textBox1.Text);
            cmd.Parameters.AddWithValue("UserrPassword", textBox2.Text);

            coon.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               Form5 go = new Form5();
                go.Show();
                this.Hide();

           

            }



            else
            {
                MessageBox.Show("Login Failed. Please try again.");
                textBox1.Clear();
                textBox2.Clear();
            }

            coon.Close();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

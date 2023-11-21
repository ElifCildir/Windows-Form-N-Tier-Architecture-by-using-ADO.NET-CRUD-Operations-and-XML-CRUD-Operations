using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Security;
using System.Runtime.InteropServices;

namespace CargoProject
{
    public partial class XMLProject : Form
    {
        public XMLProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Customers");

            SqlConnection con = new SqlConnection("Server=.;Database=CargoAutomation;Integrated Security=true;");

            SqlCommand cmd = new SqlCommand("select* from Customer", con);
            con.Open();
            SqlDataReader  reader = cmd.ExecuteReader();
            while (reader.Read())
            
            {
                XmlElement customer = xmlDoc.CreateElement("Customer");
                XmlAttribute name = xmlDoc.CreateAttribute("CustomerNameSurname");
                name.Value= reader["CustomerNameSurname"].ToString();

                XmlAttribute address = xmlDoc.CreateAttribute("CustomerAddress");
                address.Value = reader["CustomerAddress"].ToString();

                XmlAttribute mail = xmlDoc.CreateAttribute("CustomerMail");
                mail.Value= reader["CustomerMail"].ToString() ;


                XmlAttribute payment = xmlDoc.CreateAttribute("CustomerPaymentStatus");
                payment.Value = reader["CustomerPaymentStatus"].ToString();



                customer.Attributes.Append(name);
                customer.Attributes.Append(address);
                customer.Attributes.Append(mail);
                customer.Attributes.Append(payment);
                root.AppendChild(customer);


            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("vericustomer.xml");


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Deliveries");

            SqlConnection con = new SqlConnection("Server=.;Database=CargoAutomation;Integrated Security=true;");

            SqlCommand cmd = new SqlCommand("select* from Delivery", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())

            {
                XmlElement delivery = xmlDoc.CreateElement("Delivery");
                XmlAttribute name = xmlDoc.CreateAttribute("DeliveryName");
                name.Value = reader["DeliveryName"].ToString();

                XmlAttribute distance  = xmlDoc.CreateAttribute("DeliveryDistance");
                distance.Value = reader["DeliveryDistance"].ToString();

                XmlAttribute price = xmlDoc.CreateAttribute("DeliveryPrice");
                price.Value = reader["DeliveryPrice"].ToString();

                XmlAttribute deliverypoint = xmlDoc.CreateAttribute("DeliveryPoint");
                deliverypoint.Value = reader["DeliveryPoint"].ToString();

                delivery.Attributes.Append(name);
                delivery.Attributes.Append(distance);
                delivery.Attributes.Append(price);
                delivery.Attributes.Append(deliverypoint);
                root.AppendChild(delivery);


            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("veridelivery.xml");





        }

        private void XMLProject_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Staff");

            SqlConnection con = new SqlConnection("Server=.;Database=CargoAutomation;Integrated Security=true;");

            SqlCommand cmd = new SqlCommand("select* from Staff", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())

            {
                XmlElement staff = xmlDoc.CreateElement("Staff");
                XmlAttribute name = xmlDoc.CreateAttribute("StaffNameSurname");
                name.Value = reader["StaffNameSurname"].ToString();

                XmlAttribute role = xmlDoc.CreateAttribute("StaffRole");
                role.Value = reader["StaffRole"].ToString();

                XmlAttribute title = xmlDoc.CreateAttribute("StaffTitle");
                title.Value = reader["StaffTitle"].ToString();

                XmlAttribute phone = xmlDoc.CreateAttribute("StaffPhone");
                phone.Value = reader["StaffPhone"].ToString();


                XmlAttribute mail = xmlDoc.CreateAttribute("StaffMail");
                mail.Value = reader["StaffMail"].ToString();

                XmlAttribute wage = xmlDoc.CreateAttribute("StaffWage");
                wage.Value = reader["StaffWage"].ToString();


                staff.Attributes.Append(name);
                staff.Attributes.Append(role);
                staff.Attributes.Append(title);
                staff.Attributes.Append(phone);
                staff.Attributes.Append(mail);
                staff.Attributes.Append(wage);

                root.AppendChild(staff);


            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("veristaff.xml");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Vehicles");

            SqlConnection con = new SqlConnection("Server=.;Database=CargoAutomation;Integrated Security=true;");

            SqlCommand cmd = new SqlCommand("select* from Vehicle", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())

            {
                XmlElement vehicle = xmlDoc.CreateElement("Vehicle");
                XmlAttribute type = xmlDoc.CreateAttribute("VehicleType");
                type.Value = reader["VehicleType"].ToString();

                XmlAttribute cap = xmlDoc.CreateAttribute("VehicleCapacity");
                cap.Value = reader["VehicleCapacity"].ToString();

                XmlAttribute driver = xmlDoc.CreateAttribute("VehicleDriver");
                driver.Value = reader["VehicleDriver"].ToString();

                XmlAttribute expense = xmlDoc.CreateAttribute("VehicleExpense");
                expense.Value = reader["VehicleExpense"].ToString();




                vehicle.Attributes.Append(type);
                vehicle.Attributes.Append(cap);
                vehicle.Attributes.Append(driver);
                vehicle.Attributes.Append(expense);


                root.AppendChild(vehicle);


            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("verivehicle.xml");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomerXmlCRUD go = new CustomerXmlCRUD();
            go.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeliveryXMLCRUD go = new DeliveryXMLCRUD();
            go.Show(); this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 go = new Form5();
            go.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show(); this.Hide();
        }
    }
}

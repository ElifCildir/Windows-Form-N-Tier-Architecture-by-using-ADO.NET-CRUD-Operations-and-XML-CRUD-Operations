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

namespace CargoProject
{
    public partial class CustomerXmlCRUD : Form
    {
        public CustomerXmlCRUD()
        {
            InitializeComponent();
        }

        void CustomerList()
        {
            XmlDocument xmlDocument = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"Customerveri.xml", new XmlReaderSettings());
            ds.ReadXml(xmlfile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlfile.Close();



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)


        {
            CustomerList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load(@"Customerveri.xml");
            xmlDoc.Element("Customers").Add(new XElement("Customer", new XElement("CustomerNameSurname", textBox1.Text),
                new XElement("CustomerAddress", textBox2.Text),
                new XElement("CustomerMail", textBox3.Text),
               new XElement("CustomerPaymentStatus", textBox4.Text),
                 new XElement("CustomerNumber", textBox5.Text)

                ));


            xmlDoc.Save(@"Customerveri.xml");
            CustomerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument document = XDocument.Load(@"Customerveri.xml");
            document.Root.Elements().Where(a => a.Element("CustomerNumber").Value == textBox5.Text).Remove();

            document.Save(@"Customerveri.xml");
            CustomerList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load(@"Customerveri.xml");
            XElement node = xDocument.Element("Customers").Elements("Customer").FirstOrDefault(a => a.Element("CustomerNumber").Value == textBox5.Text);

            if (node != null)
            {
                node.SetElementValue("CustomerNameSurname", textBox1.Text);
                node.SetElementValue("CustomerAddress", textBox2.Text);
                node.SetElementValue("CustomerMail", textBox3.Text);
                node.SetElementValue("CustomerPaymentStatus", textBox4.Text);



                xDocument.Save(@"Customerveri.xml");
                CustomerList();


            }



        }

        private void button7_Click(object sender, EventArgs e)
        {
            XMLProject go= new XMLProject();
            go.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show(); this.Hide();
        }
    }

}

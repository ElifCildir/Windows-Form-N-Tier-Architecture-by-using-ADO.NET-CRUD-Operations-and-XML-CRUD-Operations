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
    public partial class DeliveryXMLCRUD : Form
    {
        public DeliveryXMLCRUD()
        {
            InitializeComponent();
        }

        private void DeliveryXMLCRUD_Load(object sender, EventArgs e)
        {

        }

        void DeliveryList()
        {
            XmlDocument xmlDocument = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"Deliveryveri.xml", new XmlReaderSettings());
            ds.ReadXml(xmlfile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlfile.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeliveryList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load(@"Deliveryveri.xml");
            xmlDoc.Element("Deliveries").Add(new XElement("Delivery", new XElement("DeliveryNumber", textBox1.Text),
                new XElement("DeliveryName", textBox2.Text),
               new XElement("DeliveryPoint", textBox3.Text),
                  new XElement("DeliveryDistance", textBox4.Text),
                 new XElement("DeliveryPrice", textBox5.Text)

                ));


            xmlDoc.Save(@"Deliveryveri.xml");
            DeliveryList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xdocument = XDocument.Load(@"Deliveryveri.xml");
            XElement node = xdocument.Element("Deliveries").Elements("Delivery").FirstOrDefault(a=> a.Element("DeliveryNumber").Value==textBox1.Text);

            if(node!= null)
            {

                node.SetElementValue("DeliveryName", textBox2.Text);
                node.SetElementValue("DeliveryPoint", textBox3.Text);
                node.SetElementValue("DeliveryDistance", textBox4.Text);
                node.SetElementValue("DeliveryPrice", textBox5.Text);

                xdocument.Save(@"Deliveryveri.xml");
                DeliveryList();


            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument document = XDocument.Load(@"Deliveryveri.xml");
            document.Root.Elements().Where(a=> a.Element("DeliveryNumber").Value == textBox1.Text).Remove();

            document.Save(@"Deliveryveri.xml");
            DeliveryList();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            XMLProject xmlProject = new XMLProject();
            xmlProject.Show(); this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 go= new Form1();
            go.Show(); this.Hide();
        }
    }
}

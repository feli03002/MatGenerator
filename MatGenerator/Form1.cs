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

namespace MatGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }
        private void PopulateItems()
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement veckan = (XmlElement)doc.SelectSingleNode("/root/veckan");
            XmlNodeList elemList = veckan.ChildNodes;

            if(elemList.Count > 0)
            {
                ListItem[] listItems = new ListItem[elemList.Count];
                for (int i = 0; i < elemList.Count; i++)
                {
                     string xpath = "/root/mat/recept[@id='" + elemList[i].InnerText + "']";


                    XmlElement recept = (XmlElement)doc.SelectSingleNode(xpath);
                    listItems[i] = new ListItem();

                    listItems[i].Title = recept.FirstChild.InnerText;

                    listItems[i].Description = recept.FirstChild.NextSibling.InnerText;

                    listItems[i].ID = Convert.ToInt32(elemList[i].InnerText);


                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                        flowLayoutPanel1.Controls.Add(listItems[i]);

                }
            }
            else
            {
                label2.Text = "Du har inga recept planerade";
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LäggTillRecept form = new LäggTillRecept();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

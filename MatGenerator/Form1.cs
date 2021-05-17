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

            XmlElement root = doc.DocumentElement;
            XmlNodeList elemList = root.GetElementsByTagName("recept");

            ListItem[] listItems = new ListItem[elemList.Count];
            for(int i = 0; i < elemList.Count; i++)
            {
                listItems[i] = new ListItem();
                //listItems[i].Title = elemList[i].InnerText;


                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                    flowLayoutPanel1.Controls.Add(listItems[i]);

            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LäggTillRecept form = new LäggTillRecept();
            form.Show();
        }
    }
}

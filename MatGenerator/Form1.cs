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
        public static Form1 Instance { get; private set; }

        List<ListItem> listItems = new List<ListItem>();


        public Form1()
        {
            Instance = this;
            InitializeComponent();
            LaddaVeckansRecept();
            Program.PopulateList(flowLayoutPanel1,listItems);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Fyller listan listItems med objekt av ListItem med data från veckans recept
        /// </summary>
        private void LaddaVeckansRecept()
        {
            listItems.Clear();

            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement veckan = (XmlElement)doc.SelectSingleNode("/root/veckan");
            XmlNodeList elemList = veckan.ChildNodes;

            if(elemList.Count > 0)
            {
                for (int i = 0; i < elemList.Count; i++)
                {
                     string xpath = "/root/mat/recept[@id='" + elemList[i].Attributes["id"].Value + "']";

                    listItems.Add(new ListItem());

                    XmlElement recept = (XmlElement)doc.SelectSingleNode(xpath);
                    listItems[i] = new ListItem();

                    listItems[i].Title = recept.FirstChild.InnerText;

                    listItems[i].Description = recept.FirstChild.NextSibling.InnerText;

                    listItems[i].ID = Convert.ToInt32(elemList[i].Attributes["id"].Value);

                    listItems[i].RaderaKnapp = false;

                    

                }
            }
            else
            {
                label2.Text = "Du har inga recept planerade";
            }
        }

        /// <summary>
        /// Uppdaterar flowlayoutpanel listan. Metod för icke-Form1 objekt.
        /// </summary>
        public static void UppdateraLista()
        {
            Instance.LaddaVeckansRecept();
            Program.PopulateList(Instance.flowLayoutPanel1, Instance.listItems);
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

        private void genereraVeckaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenereraVecka form = new GenereraVecka();
            form.Show();
        }

        private void inställningarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllaRecept form = new AllaRecept();
            form.Show();
        }

        private void tömListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}

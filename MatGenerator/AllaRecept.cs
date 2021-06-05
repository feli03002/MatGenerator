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
    public partial class AllaRecept : Form
    {

        public static AllaRecept Instance { get; private set; }


        private List<ListItem> listItems = new List<ListItem>();

        private string lastPath;

        public AllaRecept()
        {
            InitializeComponent();

            Instance = this;

            Skapalista("/root/mat/recept");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        /// <summary>
        /// Skapar en lista av ListItem med data från noder vid xpath och sparar senast använda xpath i variabeln SeanstAnvända
        /// </summary>
        /// <param name="xpath"></param>
        public void Skapalista(string xpath)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList Receptlista = doc.SelectNodes(xpath);
            lastPath = xpath;

            listItems.Clear();

            for (int i = 0; i < Receptlista.Count; i++)
            {
                listItems.Add(new ListItem());

                listItems[i].Title = Receptlista[i].FirstChild.InnerText;

                listItems[i].Description = Receptlista[i].FirstChild.NextSibling.InnerText;

                listItems[i].ID = Convert.ToInt32(Receptlista[i].Attributes["id"].Value);

                listItems[i].RaderaKnapp = true;

            }
        }

        /// <summary>
        /// Tar bort recept med specifikt id från Xml-filen. Om receptet finns med i veckans recept tas det också bort. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Om receptet med id fanns och tagits bort returneras true. Om receptet med id inte finns returneras false</returns>
        public static bool RaderaRecept(int id)
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement recept = (XmlElement)doc.SelectSingleNode("/root/mat/recept[@id='" + id + "']");
            if(recept != null)
            {
                recept.RemoveAll();
                recept.ParentNode.RemoveChild(recept);

                recept = (XmlElement)doc.SelectSingleNode("/root/veckan/receptID[id='" + id + "']");
                if (recept != null)
                {
                    recept.ParentNode.RemoveChild(recept);
                }

                doc.Save(path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UppdateraLista()
        {
            Instance.Skapalista(Instance.lastPath);
            Program.PopulateList(Instance.flowLayoutPanel1, Instance.listItems);
        }

        private void RBfavorit_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@favorit='J']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBnötkött_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@tag='nötkött']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBfläsk_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@tag='fläsk']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBkyckling_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@tag='kyckling']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBvegetarisk_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@tag='vegetarisk']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBfisk_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@tag='fisk']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void RBglutenfri_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept[@glutenfri='J']");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listItems.Clear();
            Skapalista("/root/mat/recept");
            Program.PopulateList(flowLayoutPanel1, listItems);
        }
    }
}

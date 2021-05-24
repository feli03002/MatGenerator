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
    public partial class ReceptFönster : Form
    {
        private int id;

        public ReceptFönster(int ID)
        {
            InitializeComponent();
            id = ID;
            LaddaRecept();
        }

        private void LaddaRecept()
        {
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlElement recept = (XmlElement)doc.SelectSingleNode("/root/mat/recept[@id='" + id + "']");
            XmlNodeList steg = recept.LastChild.ChildNodes;

            for(int i = 0 ; i < steg.Count ; i++)
            {
                string text = (i+1) + ". " + steg[i].InnerText + "\n\n";
                textBoxSteg.Text += text;
            }

            labelNamn.Text = recept.FirstChild.InnerText;

        }
    }
}

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

        string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
        XmlDocument doc = new XmlDocument();

        private int id;

        public ReceptFönster(int ID)
        {
            InitializeComponent();
            id = ID;
            LaddaRecept();
        }
        /// <summary>
        /// Laddar data från recept vid ID och placerar det i textrutan.
        /// </summary>
        private void LaddaRecept()
        {

            doc.Load(path);

            XmlElement recept = (XmlElement)doc.SelectSingleNode("/root/mat/recept[@id='" + id + "']");
            XmlNodeList steg = recept.LastChild.ChildNodes;

            for (int i = 0; i < steg.Count; i++)
            {
                string text = (i + 1) + ". " + steg[i].InnerText + "\n\n";
                textBoxSteg.Text += text;
            }

            labelNamn.Text = recept.FirstChild.InnerText;

            if (recept.Attributes["favorit"].Value == "J")
            {
                CBfavorit.Checked = true;
            } 


        }

        private void CBfavorit_CheckedChanged(object sender, EventArgs e)
        {
            doc.Load(path);

            XmlElement recept = (XmlElement)doc.SelectSingleNode("/root/mat/recept[@id='" + id + "']");

            if (CBfavorit.Checked)
                recept.Attributes["favorit"].Value = "J";
            else
                recept.Attributes["favorit"].Value = "N";

            doc.Save(path);

        }
    }
}

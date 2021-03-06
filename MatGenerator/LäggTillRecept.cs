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
    public partial class LäggTillRecept : Form
    {

        private List<StegRuta> Stegrutor = new List<StegRuta>();




        public LäggTillRecept()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           if(Stegrutor.Count < 10)
           {
                Stegrutor.Add(new StegRuta());
                Stegrutor[Stegrutor.Count - 1].Label = Convert.ToString(Stegrutor.Count);
                Program.PopulateList(flowLayoutPanel1,Stegrutor);
           }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Stegrutor.Count > 0)
            {
                Stegrutor.RemoveAt(Stegrutor.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(Stegrutor.Count);
            }

            flowLayoutPanel1.Controls.Clear();
            Program.PopulateList(flowLayoutPanel1,Stegrutor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namn = textBox1.Text;

            namn = namn.Trim();


            if (namn == "")
            {
                label5.Text = "Namnge receptet!";
            }
            else if (Stegrutor.Count == 0)
            {
                label5.Text = "Lägg till steg!";
            }
            else if (RBfisk.Checked == false && RBfläsk.Checked == false && RBkyckling.Checked == false && RBnötkött.Checked == false && RBvegetarisk.Checked == false)
            {
                label5.Text = "Välj proteinkälla!";
            }
            else
            {
                SaveToXML(namn);
                this.Close();
            }
                
            
           
            
        }
        /// <summary>
        ///     Lägger till nytt recept i xml-filen Recept.xml.
        /// </summary>
        /// <param name="namn"></param>
        private void SaveToXML(string namn)
        {
                string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlElement mat = (XmlElement)doc.SelectSingleNode("/root/mat");
                XmlElement lastID = (XmlElement)doc.SelectSingleNode("/root/info/lastID");

                int ant = Convert.ToInt32(lastID.InnerText);

                if (mat != null)
                {
                    ant++;

                    XmlElement recipeElement = doc.CreateElement("recept");

                    XmlAttribute attribute = doc.CreateAttribute("id");
                    attribute.Value = Convert.ToString(ant);
                    recipeElement.Attributes.Append(attribute);


                    attribute = doc.CreateAttribute("tag");

                    if (RBkyckling.Checked)
                        attribute.Value = "kyckling";
                    else if (RBfläsk.Checked)
                        attribute.Value = "fläsk";
                    else if (RBnötkött.Checked)
                        attribute.Value = "nötkött";
                    else if (RBvegetarisk.Checked)
                        attribute.Value = "vegetarisk";
                    else if (RBfisk.Checked)
                        attribute.Value = "fisk";
                    
                    recipeElement.Attributes.Append(attribute);


                    attribute = doc.CreateAttribute("glutenfri");
                    if (RBglutenfri.Checked)
                        attribute.Value = "J";
                    else
                        attribute.Value = "N";
                    
                    recipeElement.Attributes.Append(attribute);


                    XmlElement element = doc.CreateElement("namn");
                    element.InnerText = namn;
                    recipeElement.AppendChild(element);

                    element = doc.CreateElement("beskrivning");
                    element.InnerText = richTextBox1.Text;
                    recipeElement.AppendChild(element);

                    element = doc.CreateElement("steg");
                    for (int i = 0 ; i < Stegrutor.Count ; i++)
                    {
                        XmlElement steg = doc.CreateElement("s" + Convert.ToString(i + 1));
                        steg.InnerText = Stegrutor[i].Instruktion;
                        element.AppendChild(steg);
                    }
                    recipeElement.AppendChild(element);


                    mat.AppendChild(recipeElement);

                    lastID.InnerText = Convert.ToString(ant);
                }
                doc.Save("..\\..\\Recept.xml");



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LäggTillRecept_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

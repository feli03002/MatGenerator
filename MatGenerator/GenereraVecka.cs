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
    public partial class GenereraVecka : Form
    {



        private List<ReceptdagElement> receptdaglist = new List<ReceptdagElement>();



        string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
        XmlDocument doc = new XmlDocument();





        public GenereraVecka()
        {
            InitializeComponent();
            Program.PopulateList(flowLayoutPanel1, receptdaglist);
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(receptdaglist.Count < 7)
            {
                receptdaglist.Add(new ReceptdagElement());
                receptdaglist[receptdaglist.Count - 1].Dag = Convert.ToString(receptdaglist.Count);
                Program.PopulateList(flowLayoutPanel1, receptdaglist);
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (receptdaglist.Count > 0)
            {
                receptdaglist.RemoveAt(receptdaglist.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(receptdaglist.Count);
            }

            Program.PopulateList(flowLayoutPanel1, receptdaglist);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Recept> Receptlista = new List<Recept>();

            

            if (AllaValGjorda(Receptlista))
            {

                if (GenereraRecept(Receptlista))
                {
                    XmlElement veckansRecept = (XmlElement)doc.SelectSingleNode("/root/veckan");
                    veckansRecept.RemoveAll();

                    
                    
                    foreach(Recept recept in Receptlista)
                    {
                        XmlElement receptId = (XmlElement)doc.CreateElement("receptID");

                        XmlAttribute id = (XmlAttribute)doc.CreateAttribute("id");
                        id.Value = Convert.ToString(recept.Id);
                        receptId.Attributes.Append(id);

                        veckansRecept.AppendChild(receptId);
                    }
                    doc.Save(path);
                    Form1.UppdateraLista();
                    this.Close();
                }


            }
        }
        
        /// <summary>
        /// Kontrollerar att en kategori har valts i alla ReceptdagElement och sparar datan i en lista av Recept element
        /// </summary>
        /// <param name="Receptlista"></param>
        /// <returns>Returnerar true om en kategori har valts i alla ReceptdagElement. Annars returneras false.</returns>
        private bool AllaValGjorda(List<Recept> Receptlista)
        {
            foreach(ReceptdagElement elem in receptdaglist)
            {
                if (elem.CheckaVal())
                {
                    Receptlista.Add(new Recept(elem.Kategori, elem.Glutenfri));
                }
                else
                {
                    label2.Text = "Välj kategori!";
                    return false;
                }


            }
            return true;
        }
        /// <summary>
        /// Kontrollerar att recept med specifikationer i receptlista finns, slumpvis väljer recept med rätt specifikationer och lägger till dess ID i receptlista.
        /// </summary>
        /// <param name="receptlista"></param>
        /// <returns>Returnerar false om det inte fanns recept för en viss specifikation. Annars returneras true.</returns>
        private bool GenereraRecept(List<Recept> receptlista)
        {

            doc.Load(path);

            string xpath;

            for(int i = 0; i < receptlista.Count; i++)
            {
                if (receptlista[i].Glutenfri)
                    xpath = " /root/mat/recept[@tag='" + receptlista[i].Kategori + "' and @glutenfri='J']";
                else
                    xpath = "/root/mat/recept[@tag='" + receptlista[i].Kategori + "']";



                XmlNodeList ReceptXmlcheck = doc.SelectNodes(xpath);

                if (ReceptXmlcheck.Count > 0)
                {
                    Random rng = new Random();

                    int nr = rng.Next(0, ReceptXmlcheck.Count);

                    receptlista[i].Id = Convert.ToInt32(ReceptXmlcheck[nr].Attributes["id"].Value);
                    
                    for(int j = 0 ; j < receptlista.Count ; j++ )
                    {
                        if(i != j)
                        {
                            if (receptlista[i].Id == receptlista[j].Id)
                            {
                                label2.Text = "Fanns inte tillräckling många unika recept";
                                receptlista.Remove(receptlista[i]);
                                i--;
                            }
                        }
                       
                    }
                    

                }
                else
                {
                    if (receptlista[i].Glutenfri)
                        label2.Text = "Fanns inga matchande recept för: " + receptlista[i].Kategori + " glutenfri!";
                    else
                        label2.Text = "Fanns inga matchande recept för: " + receptlista[i].Kategori;


                    return false;
                }

            }

            return true;
        }
    }
}

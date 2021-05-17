using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
               // Stegrutor[Stegrutor.Count - 1].Instruction = richTextBox2.Text;
                populateList();
           }
           
        }
        private void populateList()
        {
            for (int i = 0; i < Stegrutor.Count; i++)
            {

                flowLayoutPanel1.Controls.Add(Stegrutor[i]);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Stegrutor.Count > 1)
            {
                Stegrutor.RemoveAt(Stegrutor.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(Stegrutor.Count - 1);
            }
             
            populateList();
        }
    }
}

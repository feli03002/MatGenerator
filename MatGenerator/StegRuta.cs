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
    public partial class StegRuta : UserControl
    {
        public StegRuta()
        {
            InitializeComponent();
        }




        #region Properties

        private string label;
        private string text;


        public StegRuta(string L, string T)
        {
            label = L;
            text = T;
        }


        [Category("Custom props")]
        public string Label
        {
            get { return label; }
            set { label = value; label1.Text = value; }
        }


        [Category("Custom props")]
        public string Instruction
        {
            get { return text; }
            set { text = value;  }
        }


        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        public StegRuta(string L)
        {
            label = L;
        }


        [Category("Custom props")]
        public string Label
        {
            get { return label; }
            set { label = value; label1.Text = value; }
        }


        [Category("Custom props")]
        public string Instruktion
        {
            get { return textBox1.Text; }
        }


        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

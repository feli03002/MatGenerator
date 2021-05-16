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



        [Category("Custom props")]
        public string Instruktion
        {
            get { return text; }
            set { text = value; }
        }



        [Category("Custom props")]
        public string Label
        {
            get { return label; }
            set { label = value; }
        }


        #endregion
    }
}

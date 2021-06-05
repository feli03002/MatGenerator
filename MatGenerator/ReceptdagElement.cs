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
    public partial class ReceptdagElement : UserControl
    {
        public ReceptdagElement()
        {
            InitializeComponent();
        }

        #region Properties

        private string dag;
        private string kategori;
        private bool glutenfri;

        [Category("Custom props")]
        public string Dag
        {
            set { dag = value; label1.Text = value; }
        }

        [Category("Custom props")]
        public string Kategori
        {
            set { kategori = value; }
            get { return kategori; }
        }

        [Category("Custom props")]
        public bool Glutenfri
        {
            set { glutenfri = value; }
            get { return glutenfri; }
        }
        /// <summary>
        /// Kollar att ett val har gjorts och sätter variablerna till värdet.
        /// </summary>
        /// <returns>Om en kategori är vald returneras true, om inte returneras false.</returns>
        public bool CheckaVal()
        {

            if (CBgluten.Checked)
                glutenfri = true;
            else
                glutenfri = false;

            if (RBkyckling.Checked)
                kategori = "kyckling";
            else if (RBfläsk.Checked)
                kategori = "fläsk";
            else if (RBnötkött.Checked)
                kategori = "nötkött";
            else if (RBvegetarisk.Checked)
                kategori = "vegetarisk";
            else if (RBfisk.Checked)
                kategori = "fisk";
            else
                return false;

            return true;
        }

        #endregion 
    }
}

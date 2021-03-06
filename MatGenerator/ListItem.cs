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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string title;
        private string description;
        private int id;

        [Category("Custom props")]
        public string Title
        {
            get { return title; }
            set { title = value; titel_label.Text = value; }
        }

        [Category("Custom props")]
        public string Description
        {
            get { return description; }
            set { description = value; desc_label.Text = value; }
        }
        [Category("Custom props")]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [Category("Custom props")]
        public bool RaderaKnapp
        {
            set { Raderaknapp.Enabled = value; Raderaknapp.Visible = value; }
        }


        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptFönster form = new ReceptFönster(id);
            form.Show();
        }

        private void Raderaknapp_Click(object sender, EventArgs e)
        {
            if (AllaRecept.RaderaRecept(id))
            {
                AllaRecept.UppdateraLista();
                Form1.UppdateraLista();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MatGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
        }

       /// <summary>
       /// Fyller flowlayoutpanel med objekt från ItemList
       /// </summary>
       /// <param name="flowLayoutPanel"></param>
       /// <param name="ItemList"></param>
        public static void PopulateList(FlowLayoutPanel flowLayoutPanel, List<ListItem> ItemList)
        {
            flowLayoutPanel.Controls.Clear();

            foreach(ListItem Item in ItemList)
            {
                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                    flowLayoutPanel.Controls.Add(Item);
            }
           
        }
        /// <summary>
        /// Fyller flowlayoutpanel med objekt från ItemList
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="ItemList"></param>
        public static void PopulateList(FlowLayoutPanel flowLayoutPanel, List<ReceptdagElement> ItemList)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (ReceptdagElement Item in ItemList)
            {
                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                    flowLayoutPanel.Controls.Add(Item);
            }

        }
        /// <summary>
        /// Fyller flowlayoutpanel med objekt från ItemList
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="ItemList"></param>
        public static void PopulateList(FlowLayoutPanel flowLayoutPanel, List<StegRuta> ItemList)
        {
            flowLayoutPanel.Controls.Clear();

            foreach (StegRuta Item in ItemList)
            {
                if (flowLayoutPanel.Controls.Count < 0)
                {
                    flowLayoutPanel.Controls.Clear();
                }
                else
                    flowLayoutPanel.Controls.Add(Item);
            }

        }
    }
}

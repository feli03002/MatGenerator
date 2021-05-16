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

            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "..\\..\\Recept.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            //XmlNodeList xnList = doc.SelectNodes("/mat/recept [@Type=");
        }
    }
}

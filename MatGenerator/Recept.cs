using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatGenerator
{
    class Recept
    {
        private string _kategori;
        private bool _glutenfri;
        private int _id;


        public Recept(string kategori, bool glutenfri)
        {
            _kategori = kategori;
            _glutenfri = glutenfri;
        }

        public string Kategori
        {
            get { return _kategori; }
            set { _kategori = value; }
        }

        public bool Glutenfri
        {
            get { return _glutenfri; }
            set { _glutenfri = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_Spielerei
{
    internal class Zutaten
    {
        private string name;
        private double alk;

        public string Name { get => name; set => name = value; }
        public double Alk { get => alk; set => alk = value; }

        public Zutaten(string _name, double _alk)
        {
            name = _name;
            alk = _alk;
        }
    }
}

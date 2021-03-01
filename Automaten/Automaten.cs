using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Automaten
    {
        public string vare { get; set; }

        public double varePris { get; set; }

        public int vareAntal { get; set; }

        public Automaten(string _vare, double _varePris, int _vareAntal)
        {
            vare = _vare;
            varePris = _varePris;
            vareAntal = _vareAntal;
        }
    }
}

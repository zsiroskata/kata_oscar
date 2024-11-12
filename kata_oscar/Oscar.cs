using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_oscar
{
    class Oscar
    {
        public string Azon { get; set; }
        public string Cim { get; set; }
        public int Ev { get; set; }
        public int Dij { get; set; }
        public int Jelol { get; set; }

        public Oscar(string sorok)
        {
            var s = sorok.Split("\t");
            Azon = s[0];
            Cim = s[1];
            Ev = int.Parse(s[2]);
            Dij = int.Parse(s[3]);
            Jelol = int.Parse(s[4]);
        }
    }
}

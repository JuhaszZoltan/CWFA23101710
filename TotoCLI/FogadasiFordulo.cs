using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TotoCLI
{
    internal class FogadasiFordulo
    {
        public int Ev { get; set; }
        public int Het { get; set; }
        public int Fordulo { get; set; }
        public int T13p1 { get; set; }
        public int Ny13p1 { get; set; }
        public string Eredmenyek { get; set; }
        public bool VanDontetlen => Eredmenyek.Contains('X');

        public FogadasiFordulo(string s)
        {
            string[] v = s.Split(';');
            Ev = int.Parse(v[0]);
            Het = int.Parse(v[1]);
            Fordulo = int.Parse(v[2]);
            T13p1 = int.Parse(v[3]);
            Ny13p1 = int.Parse(v[4]);
            Eredmenyek = v[5];
        }
    }
}

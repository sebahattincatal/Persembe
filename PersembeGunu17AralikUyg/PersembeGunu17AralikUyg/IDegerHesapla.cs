using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersembeGunu17AralikUyg
{
    public interface IDegerHesapla
    {
        string DaireDurumu { get; set; }
        int KatSayisi { get; set; }
        int OdaSayisi { get; set; }
        string Konum { get; set; }
        string EsyaDurumu { get; set; }

        double DaireDegerHesapla();
    }
}

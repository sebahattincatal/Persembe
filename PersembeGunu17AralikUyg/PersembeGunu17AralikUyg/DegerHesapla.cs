using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersembeGunu17AralikUyg
{
    class DegerHesapla : IDegerHesapla
    {
        public string DaireDurumu { get; set; }
        public int KatSayisi { get; set; }
        public int OdaSayisi { get; set; }
        public string Konum { get; set; }
        public string EsyaDurumu { get; set; }

        const double TemelFiyat = 100000;

        public double DaireDegerHesapla()
        {
            double toplam = TemelFiyat;

            toplam += DaireDurum() + KatSayisiDurum() + OdaSayisiDurum() + KonumDurumu() + EsyaDurum(); // Temel fiyat + daire durumu fiyatı 120000

            return toplam;
        }

        private double DaireDurum()
        {
            double DaireDurumSonuc = 0;

            if (DaireDurumu == "Sıfır")
                DaireDurumSonuc = TemelFiyat * 0.35;
            else
                DaireDurumSonuc = TemelFiyat * (int)0.2;

            return DaireDurumSonuc;
        }

        private double KatSayisiDurum()
        {
            double KatSayisiSonuc = 0;

            switch (KatSayisi)
            {
                case 1:
                    KatSayisiSonuc = TemelFiyat * 0.05;
                    break;
                case 2:
                case 3:
                case 4:
                    KatSayisiSonuc = TemelFiyat * 0.1;
                    break;
                case 5:
                    KatSayisiSonuc = TemelFiyat * 0.07;
                    break;
            }

            return KatSayisiSonuc;
        }

        private double OdaSayisiDurum()
        {
            double OdaSayisiSonuc = 0;

            switch (OdaSayisi)
            {
                case 0:
                    OdaSayisiSonuc = TemelFiyat * 0.01;
                    break;
                case 1:
                    OdaSayisiSonuc = TemelFiyat * 0.02;
                    break;
                case 2:
                    OdaSayisiSonuc = TemelFiyat * 0.03;
                    break;
                case 3:
                    OdaSayisiSonuc = TemelFiyat * 0.05;
                    break;
            }

            return OdaSayisiSonuc;
        }

        private double KonumDurumu()
        {
            double KonumDurumSonuc = 0;

            if (Konum == "Merkez")
                KonumDurumSonuc = TemelFiyat * 0.5;
            else
                KonumDurumSonuc = TemelFiyat * 0.15;

            return KonumDurumSonuc;
        }

        private double EsyaDurum()
        {
            double EsyaDurumSonuc = 0;

            if (EsyaDurumu == "Eşyalı")
                EsyaDurumSonuc = TemelFiyat * 0.3;
            else
                EsyaDurumSonuc = TemelFiyat * 0.0;

            return EsyaDurumSonuc;
        }
    }
}

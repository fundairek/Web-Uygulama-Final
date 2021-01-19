using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PojeFinal.Models
{
    public class OgrenciVeri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public long TcKimlik { get; set; }
        public short GirisYil { get; set; }

        public static List<OgrenciVeri> VeriListe = new List<OgrenciVeri>
        {
            new OgrenciVeri
            {
                Id=1,
                Ad ="Funda",
                Soyad="İrek",
                Bolum="Bilgisayar Programcılığı",
                TcKimlik=1111111,
                GirisYil=2019,

            },

             new OgrenciVeri
            {
                Id=2,
                Ad ="Emir",
                Soyad="Kılıç",
                Bolum="Yazılım",
                TcKimlik=222222,
                GirisYil=2019,

            },

              new OgrenciVeri
              {
                Id=3,
                Ad ="Aras ",
                Soyad="Cankurt",
                Bolum="Bilgisayar Mühendisliği",
                TcKimlik=333333,
                GirisYil=2019,
              },

               new OgrenciVeri
            {
                Id=4,
                Ad ="Defne",
                Soyad="Gül",
                Bolum="Bilgisayar Programcılığı",
                TcKimlik=4444444,
                GirisYil=2019,

               },


                new OgrenciVeri
            {
                Id=5,
                Ad ="Enes ",
                Soyad="Güneş",
                Bolum="Bilgisayar Programcılığı",
                TcKimlik=5555555,
                GirisYil=2019,

            },

        };

        /*
        public void Test()
        {
            var a = new Deneme();
            a.Uye = "ffff";

        }


    }

    public class Deneme
    {
        public string Uye { get; set; } = "ffff";

    }
        */
    }
}
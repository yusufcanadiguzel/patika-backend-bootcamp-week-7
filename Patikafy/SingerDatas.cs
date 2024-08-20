using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    internal class SingerDatas
    {
        public static List<Singer> Singers { get; set; }

        static SingerDatas()
        {
            Singers = new List<Singer>()
            {
                new Singer(fullName: "Ajda Pekkan", musicCategory: "Pop", debutYear: 1968, albumSolds: 15000000),
                new Singer(fullName: "Sezen Aksu", musicCategory: "Türk Halk Müziği / Pop", debutYear: 1971, albumSolds: 9500000),
                new Singer(fullName: "Funda Arar", musicCategory: "Pop", debutYear: 1999, albumSolds: 2500000),
                new Singer(fullName: "Sertap Erener", musicCategory: "Pop", debutYear: 1994, albumSolds: 4500000),
                new Singer(fullName: "Sıla", musicCategory: "Pop", debutYear: 2009, albumSolds: 2500000),
                new Singer(fullName: "Sertar Ortaç", musicCategory: "Pop", debutYear: 1994, albumSolds: 9500000),
                new Singer(fullName: "Tarkan", musicCategory: "Pop", debutYear: 1992, albumSolds: 35000000),
                new Singer(fullName: "Hande Yener", musicCategory: "Pop", debutYear: 1999, albumSolds: 6500000),
                new Singer(fullName: "Hadise", musicCategory: "Pop", debutYear: 2005, albumSolds: 4500000),
                new Singer(fullName: "Gülben Ergen", musicCategory: "Pop / Türk Halk Müziği", debutYear: 1997, albumSolds: 9500000),
                new Singer(fullName: "Neşet Ertaş", musicCategory: "Türk Halk Müziği / Türk Sanat Müziği", debutYear: 1960, albumSolds: 1500000),
            };
        }
    }
}

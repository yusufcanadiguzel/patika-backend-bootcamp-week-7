using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    // Dizi listesi
    internal class TvSeriesDatas
    {
        public static List<TvSeries> TvSerieses { get; set; }

        static TvSeriesDatas()
        {
            TvSerieses = new List<TvSeries>()
            {
                new TvSeries(name: "Avrupa Yakası", productionYear: 2004, category: "Komedi", releaseYear: 2004, director: "Yüksel Aksu", platform: "Kanal D"),
                new TvSeries(name: "Yalan Dünya", productionYear: 2012, category: "Komedi", releaseYear: 2012, director: "Gülseren Buda Başkaya", platform: "Fox"),
                new TvSeries(name: "Jet Sosyete", productionYear: 2018, category: "Komedi", releaseYear: 2018, director: "Gülseren Buda Başkaya", platform: "TV 8"),
                new TvSeries(name: "Dadı", productionYear: 2006, category: "Komedi", releaseYear: 2006, director: "Yusuf Pirhasan", platform: "Kanal D"),
                new TvSeries(name: "Belalı Baldız", productionYear: 2007, category: "Komedi", releaseYear: 2007, director: "Yüksel Aksu", platform: "Kanal D"),
                new TvSeries(name: "Arka Sokaklar", productionYear: 2004, category: "Polisiye, Dram", releaseYear: 2004, director: "Orhan Oğuz", platform: "Kanal D"),
                new TvSeries(name: "Aşk-ı Memnu", productionYear: 2008, category: "Dram, Romantik", releaseYear: 2008, director: "Hilal Saral", platform: "Kanal D"),
                new TvSeries(name: "Muhteşem Yüzyıl", productionYear: 2011, category: "Tarihi, Dram", releaseYear: 2011, director: "Mercan Çilingiroğlu", platform: "Star TV"),
                new TvSeries(name: "Yaprak Dökümü", productionYear: 2006, category: "Dram", releaseYear: 2006, director: "Serdar Akar", platform: "Kanal D")
            };
        }
    }
}

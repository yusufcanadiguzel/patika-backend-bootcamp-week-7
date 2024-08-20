using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    // Dizi sınıfı
    internal class TvSeries
    {
        public TvSeries(string name, int productionYear, string category, int releaseYear, string director, string platform)
        {
            Name = name;
            ProductionYear = productionYear;
            Category = category;
            ReleaseYear = releaseYear;
            Director = director;
            Platform = platform;
        }

        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public string Category { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }
    }
}

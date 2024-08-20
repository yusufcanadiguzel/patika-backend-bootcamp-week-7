using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix
{
    // İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın
    internal class TvSeriesDto
    {
        public static List<TvSeriesDto> TvSeriesesDto { get; set; }

        static TvSeriesDto()
        {
            TvSeriesesDto = new List<TvSeriesDto>();
        }

        public TvSeriesDto(string name, string category, string director)
        {
            Name = name;
            Category = category;
            Director = director;
        }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Director { get; set; }

        public static List<TvSeriesDto> CreateDtoList(List<TvSeries> tvSerieses)
        {
            foreach (var tvSeries in tvSerieses)
            {
                TvSeriesesDto.Add(new TvSeriesDto(name: tvSeries.Name, category: tvSeries.Category, director: tvSeries.Director));
            }

            return TvSeriesesDto;
        }

        public override string ToString()
        {
            return $"{Name} - {Director} - {Category}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    public class Singer
    {
        public string FullName { get; set; }
        public string MusicCategory { get; set; }
        public int DebutYear { get; set; }
        public int AlbumSolds { get; set; }

        public List<Singer> Singers { get; set; }

        public Singer(string fullName, string musicCategory, int debutYear, int albumSolds)
        {
            FullName = fullName;
            MusicCategory = musicCategory;
            DebutYear = debutYear;
            AlbumSolds = albumSolds;
        }

        public override string ToString()
        {
            return $"{FullName} - {MusicCategory} - {DebutYear} - {AlbumSolds}";
        }
    }
}

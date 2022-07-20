using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4
{
    public class ArtistSong
    {
        public int ArtistSongId { get; set; }
        public int ArtistId { get; set; }
        public List<Artist> Artist { get; set; }
        public int SongId { get; set; }
        public List<Song> Song { get; set; }
    }
}

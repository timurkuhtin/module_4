using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4.Configurations
{
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasData(new[]
            {
                new ArtistSong
                {
                    ArtistSongId = 1,
                    ArtistId = 1,
                    SongId = 1,                    
                },
                new ArtistSong
                {
                    ArtistSongId = 2,
                    ArtistId = 2,
                    SongId = 2,
                },
                new ArtistSong
                {
                    ArtistSongId = 3,
                    ArtistId = 3,
                    SongId = 3,
                }
            });
        }
    }
}

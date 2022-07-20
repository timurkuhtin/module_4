using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(new[]
            {
                new Song
                {
                    SongId = 1,
                    Title = "Trick Me",
                    Duration = "3:26",
                    ReleasedDate = new DateTime(2003, 7, 20, 0, 0, 0),
                    GenreId = 1
                },
                new Song
                {
                    SongId = 2,
                    Title = "Face Down",
                    Duration = "3:12",
                    ReleasedDate = new DateTime(2006, 5, 8, 0, 0, 0),
                    GenreId = 2
                },
                new Song
                {
                    SongId = 3,
                    Title = "Money long",
                    Duration = "2:15",
                    ReleasedDate = new DateTime(2019, 9, 16, 0, 0, 0),
                    GenreId = 3
                }
            });
        }
    }
}

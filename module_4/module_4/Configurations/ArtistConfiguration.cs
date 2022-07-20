using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(new[]
            {
                new Artist
                {
                    ArtistId = 1,
                    Name = "Kelis",
                    DateOfBirth = new DateTime(1979, 8, 21, 0, 0, 0),
                    Phone = 5553535,
                    Email = "Kelis@email",
                    InstagramUrl = "@Kelis"
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "The Red Jumpsuit Apparatus",
                    DateOfBirth = new DateTime(2003, 7, 15, 0, 0, 0),
                    Phone = 5553535,
                    Email = "TRJA@email",
                    InstagramUrl = "@TRJA"
                },
                new Artist
                {
                    ArtistId = 3,
                    Name = "Kizaru",
                    DateOfBirth = new DateTime(1989, 5, 21, 0, 0, 0),
                    Phone = 5553535,
                    Email = "Kizaru@email",
                    InstagramUrl = "@Kizaru"
                }
            });
        }
    }
}

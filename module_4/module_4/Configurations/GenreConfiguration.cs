using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            void Configure(EntityTypeBuilder<Genre> builder)
            {
                builder.HasData(new[]
                {
                    new Genre
                    {
                        GenreId = 1,
                        Title = "R&B"
                    },
                    new Genre
                    {
                        GenreId = 2,
                        Title = "Metal"
                    },
                    new Genre
                    {
                        GenreId = 3,
                        Title = "Hip-Hop"
                    }
                });
            }
        }
    }
}

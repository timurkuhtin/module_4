using Microsoft.EntityFrameworkCore;
using module_4.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_4
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=module_4;Integrated Security=True";

        public DbSet<Song> Songs { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<ArtistSong> ArtistSongs { get; set; }

        public ApplicationContext()
        {
        }

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfiguration());
        }
    }
}

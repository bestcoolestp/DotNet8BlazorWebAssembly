using BlazorWasmDotNetShared.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet8BlazorWebAssembly.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<VideoGame>().HasData(
					new VideoGame { Id = 1, Title = "Witcher 4", Publisher = "CD Project Red", ReleaseYear = 2025 },
					new VideoGame { Id = 2, Title = "Diablo 5", Publisher = "Blizzard", ReleaseYear = 2027 },
					new VideoGame { Id = 3, Title = "Elder Scroll 6", Publisher = "Bethesda", ReleaseYear = 2025 },
					new VideoGame { Id = 4, Title = "씨뻘건 사막", Publisher = "대한소프트", ReleaseYear = 2027 }
				);
		}

		public DbSet<VideoGame> VideoGames { get; set; }
    }
}

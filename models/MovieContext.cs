using System;
using Microsoft.EntityFrameworkCore;

namespace simple_microservice.models
{
	public class MovieContext : DbContext
	{
		public MovieContext(DbContextOptions<MovieContext> options) : base(options)
		{

		}

		DbSet<Movie> movies { get; set; } = null!;
	}
}


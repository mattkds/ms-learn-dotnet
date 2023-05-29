using System;
namespace simple_microservice.models
{
	public class Movie
	{
		public int id { get; set; }
		public string? title { get; set; }
		public string? genre { get; set; }
		public DateTime releaseDate { get; set; }
	}
}


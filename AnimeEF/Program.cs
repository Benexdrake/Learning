// See https://aka.ms/new-console-template for more information
using AnimeEF;
using AnimeEF.Models;

Console.WriteLine("Hello, World!");

var animes = Helper.LoadJson("Crunchyroll.json");

List<Anime_EF> Alist = new();
List<Season_EF> Slist = new();
List<Episode_EF> Elist = new();


if(animes != null)
{
	int animeId = 1;

	var db = new AnimeEF.Data.CrunchyrollDbContext();
	foreach (var anime in animes)
	{
		var a = new Anime_EF();
		a.Id = animeId.ToString();
		a.Name = anime.Name;
		a.Description = anime.Description;
		a.Episodes = anime.Episodes;
		a.Url = anime.Url;
		a.Image = anime.Image;
		a.Rating = anime.Rating;
		a.Tags = anime.Tags;
		a.Publisher = anime.Publisher;
		a.LastUpdate = DateTime.Now;

		Alist.Add(a);

		int seasonId = 1;
		foreach (var season in anime.Seasons)
		{
			var s = new Season_EF();
			s.Id = $"{animeId}-{seasonId}";
			s.Name = season.Name;
			s.AnimeId = animeId.ToString();
			Slist.Add(s);


			int episodeId = 1;

			foreach (var episode in season.Episodes)
			{
				var e = new Episode_EF();
				e.Id = $"{animeId}-{seasonId}-{episodeId}";
				e.Name = episode.Name;
				e.Story = episode.Story;
				e.Url = episode.Url;
				e.Image = episode.Image;
				e.SeasonId = $"{animeId}-{seasonId}";
				Elist.Add(e);


               episodeId++;
			}
			seasonId++;
		}
		animeId++;
	}
	//foreach (var item in Alist)
	//{
	//	Console.WriteLine(item.Id);
	//	
	//	db.Animes.Add(item);
	//}

	//foreach (var item in Slist)
	//{
    //    Console.WriteLine(item.Id);
	//
	//	db.Seasons.Add(item);
    //}
	//	db.SaveChanges();

	foreach (var item in Elist)
	{
        Console.WriteLine(item.Id);

		db.Episodes.Add(item);
    }
    db.SaveChanges();
}



using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace YoutubeApiConsole
{
    public class Program
    {
        public static async Task Main()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Youtube-Keys.JSON";
            YoutubeKeys keys = new YoutubeKeys(filePath);

            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = keys.APIKey
            });

            var request = service.Videos.List("snippet");
            request.Chart = VideosResource.ListRequest.ChartEnum.MostPopular;
            request.RegionCode = "de";
            
            var results = await request.ExecuteAsync();
            
            if(results.Items.Count <= 0)
                Console.WriteLine("No Videos");
            
            foreach (var video in results.Items)
            {
                Console.WriteLine($"{video.Snippet.Title} https://www.youtube.com/watch?v={video.Id}");
                //Console.WriteLine(video.FileDetails.FileType);
            }
        }
    }
}
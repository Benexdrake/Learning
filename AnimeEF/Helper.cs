using AnimeEF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeEF
{
    internal class Helper
    {
        public static Anime[] LoadJson(string filePath)
        {
            string strResult = File.ReadAllText(filePath);
            Anime[] animes = JsonConvert.DeserializeObject<Anime[]>(strResult);
            return animes;
        }
    }
}

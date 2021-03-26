
using FilmwerteChallenge.StorageSources.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilmwerteChallenge
{
    /// <summary>
    /// Represents the main program of the challenge.
    /// </summary>
    struct FileStruct
    {

    };
    class Program
    {
        /// <summary>
        /// Represents the main function of the program.
        /// </summary>
        static void Main()
        {
            Storage storage = new Storage();
            storage.AddVideo(new Movie
            {
                Title = "HAGER",
                Duration = 4781,
                VideoUri = "https://cdn.sample.com/nov_2019_hager_pro_res_1_1/nov_2019_hager_pro_res_1_1.mpd",
                ImdbId = "tt6698964"
            });
            storage.AddVideo(new Movie
            {
                Title = "Berlin 4 Lovers",
                Duration = 3480,
                VideoUri = "https://www.youtube.com/watch?v=K55o8_hrYtQ"
            });
            storage.AddVideo(new Movie
            {
                Title = "Resistance Fighters – The Global Antibiotics Crisis",
                Duration = 1682,
                VideoUri = "https://cdn.sample.com/master_bvp-_resistance_fighters_de-ins-ut_de-20_h264-high/youtube_source_bvp-_resistance_fighters_de-ins-ut_de-20_h264-high.mpd"
            });
            storage.AddVideo(new Movie
            {
                Title = "Following Habeck",
                Duration = 1095,
                VideoUri = "https://m.youtube.com/watch?v=vo8hxCLv4FU",
                ImdbId = "tt8014110"
            });
            storage.AddVideo(new Movie
            {
                Title = "Yves' Promise",
                Duration = 4738,
                VideoUri = "https://cdn.sample.de/yves-versprechen/yves-versprechen.mpd",
                ImdbId = "tt7842194"
            });

            // see #1
            IEnumerable<Movie> allMovies = storage.GetAllVideos();
            Console.WriteLine("All movies:");
            Console.WriteLine("-----------");
            Console.WriteLine();
            foreach (Movie movie in allMovies.ToArray())
            {
                Console.WriteLine($"Movie Id : {movie.Id}");
                Console.WriteLine($"Title : {movie.Title}");
                Console.WriteLine($"Duration : {movie.Duration} seconds");
                Console.WriteLine($"Video Uri : { movie.VideoUri}");
                Console.WriteLine();
            }

            // see #2
            int minimumDuration = 30 * 60; //duration in seconds.
            IEnumerable<Movie> query1 = storage.GetAllVideos().Where(movie => movie.Duration > minimumDuration); // TODO
            Console.WriteLine("Query 1:");
            Console.WriteLine("--------");
            Console.WriteLine();
            foreach (Movie movie in allMovies.ToArray())
            {
                Console.WriteLine($"Movie Id : {movie.Id}");
                Console.WriteLine($"Title : {movie.Title}");
                Console.WriteLine($"Duration : {movie.Duration} seconds");
                Console.WriteLine($"Video Uri : { movie.VideoUri}");
                Console.WriteLine();
            }

            var searchTerm = "youtube";
            IEnumerable<Movie> query2 = storage.GetAllVideos().Where(movie => movie.VideoUri.Contains(searchTerm)); // TODO
            Console.WriteLine("Query 2:");
            Console.WriteLine("--------");
            foreach (Movie movie in query2.ToArray())
            {
                Console.WriteLine($"Movie Id : {movie.Id}");
                Console.WriteLine($"Title : {movie.Title}");
                Console.WriteLine($"Duration : {movie.Duration} seconds");
                Console.WriteLine($"Video Uri : {movie.VideoUri}");
                Console.WriteLine();
            }

            //IEnumerable<Movie> query3 = storage.GetAllVideos().Any(a=>a.ImdbId); // TODO
            IEnumerable<Movie> query3 = storage.GetAllVideos().Where(a=>!(string.IsNullOrEmpty(a.ImdbId))); // TODO
            Console.WriteLine("Query 3:");
            Console.WriteLine("--------");
            foreach (Movie movie in query3.ToArray())
            {
                //What is the total runtime?
                Console.WriteLine($"Movie Id : {movie.Id}");
                Console.WriteLine($"Title : {movie.Title}");
                Console.WriteLine($"Duration : {movie.Duration} seconds");
                Console.WriteLine($"Imdb Id : {movie.ImdbId}");
                Console.WriteLine($"Video Uri : { movie.VideoUri}");
                Console.WriteLine();
            }

           

            //var storageContext = new Context<FileStruct>();
            //storageContext.SetStrategy(new FileStrategy());
            //Stream stream = new FileStream("");
            //storageContext.PerformRead(stream);




        }
    }
}
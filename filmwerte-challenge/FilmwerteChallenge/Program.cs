
using FilmwerteChallenge.Classes;
using FilmwerteChallenge.Interfaces;
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
            IStorageService storageService = new StorageService(new InMemoryStorage());
            storageService.InitVideos();

            // see #1
            IEnumerable<IVideo> allMovies = storageService.GetAllVideos();
            Console.WriteLine("All movies:");
            Console.WriteLine("-----------");
            Console.WriteLine();
            PrintMovies(allMovies);

            // see #2
            IEnumerable<IVideo> query1 = storageService.GetMoviesMoreThan30Minutes().ToArray();
            Console.WriteLine("Query 1:");
            Console.WriteLine("--------");
            Console.WriteLine();
            PrintMovies(query1);

            IEnumerable<IVideo> query2 = storageService.GetMoviesHostedOnYoutube().ToArray();
            Console.WriteLine("Query 2:");
            Console.WriteLine("--------");
            PrintMovies(query2);

            int query3 = storageService.GetMovieDurationWithImdbId(); // TODO
            Console.WriteLine("Query 3:");
            Console.WriteLine("--------");

            //What is the total runtime?
            Console.WriteLine($"Total Duration of Movies with IMDB Id : {query3} seconds");
            Console.WriteLine();
        }

        private static void PrintMovies(IEnumerable<IVideo> allMovies)
        {
            foreach (Movie movie in allMovies.ToArray())
            {
                Console.WriteLine($"Movie Id : {movie.Id}");
                Console.WriteLine($"Title : {movie.Title}");
                Console.WriteLine($"Duration : {movie.Duration} seconds");
                Console.WriteLine($"Video Uri : { movie.VideoUri}");
                Console.WriteLine();
            }
        }
    }
}
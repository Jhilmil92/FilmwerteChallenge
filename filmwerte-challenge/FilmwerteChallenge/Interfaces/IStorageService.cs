using System;
using System.Collections.Generic;
using System.Text;

namespace FilmwerteChallenge.Interfaces
{
    /// <summary>
    /// Represents service to store Videos.
    /// </summary>
    public interface IStorageService
    {
        /// <summary>
        /// Seeds videos to the Storage.
        /// </summary>
        void InitVideos();

        /// <summary>
        /// Gets all the Videos.
        /// </summary>
        /// <returns>list of Videos.</returns>
        IEnumerable<IVideo> GetAllVideos();

        /// <summary>
        /// Gets All movies that are longer than 30 minutes
        /// </summary>
        /// <returns>Lit of Movies</returns>
        IEnumerable<IVideo> GetMoviesMoreThan30Minutes();

        /// <summary>
        /// Gets All movies that are hosted on YouTube, ordered by title
        /// </summary>
        /// <returns>list of Movies.</returns>
        IEnumerable<IVideo> GetMoviesHostedOnYoutube();

        /// <summary>
        /// Gets Total runtime of all movies that have an IMDb ID
        /// </summary>
        /// <returns>duration in seconds.</returns>
        int GetMovieDurationWithImdbId(); 
    }
}

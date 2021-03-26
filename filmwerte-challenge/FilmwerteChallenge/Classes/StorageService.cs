using FilmwerteChallenge.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FilmwerteChallenge.Classes
{
    /// <summary>
    /// Represents Storage Service for the videos.
    /// </summary>
    public class StorageService : IStorageService
    {
        IStorage _storage;

        /// <summary>
        /// Creates an istance of <see cref="StorageService"/>
        /// </summary>
        /// <param name="storage"></param>
        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        /// <summary>
        /// Gets all the Videos.
        /// </summary>
        /// <returns>list of Videos.</returns>
        public IEnumerable<IVideo> GetAllVideos()
        {
            return _storage.GetAllVideos();
        }

        /// <summary>
        /// Gets Total runtime of all movies that have an IMDb ID
        /// </summary>
        /// <returns>duration in seconds.</returns>
        public int GetMovieDurationWithImdbId()
        {
            var videosWithImdbId = _storage.GetAllVideos().Where(x => x is Movie).Cast<Movie>()
                                   .Where(x => !string.IsNullOrEmpty(x.ImdbId));
            return videosWithImdbId.Sum(x => x.Duration);
        }

        /// <summary>
        /// Gets All movies that are hosted on YouTube, ordered by title
        /// </summary>
        /// <returns>list of Movies.</returns>
        public IEnumerable<IVideo> GetMoviesHostedOnYoutube()
        {
            var searchTerm = "youtube";
            return _storage.GetAllVideos().Where(x => x is Movie && x.VideoUri.Contains(searchTerm))
                                        .OrderBy(x => x.Title).ToArray();
        }

        /// <summary>
        /// Gets All movies that are longer than 30 minutes
        /// </summary>
        /// <returns>Lit of Movies</returns>
        public IEnumerable<IVideo> GetMoviesMoreThan30Minutes()
        {
            int minimumDuration = 30 * 60; //duration in seconds.
            return _storage.GetAllVideos()
                           .Where(x => x is Movie && x.Duration > minimumDuration);
        }

        /// <summary>
        /// seeds Videos to the Storage.
        /// </summary>
        public void InitVideos()
        {
            _storage.AddVideo(new Movie
            {
                Title = "HAGER",
                Duration = 4781,
                VideoUri = "https://cdn.sample.com/nov_2019_hager_pro_res_1_1/nov_2019_hager_pro_res_1_1.mpd",
                ImdbId = "tt6698964"
            });
            _storage.AddVideo(new Movie
            {
                Title = "Berlin 4 Lovers",
                Duration = 3480,
                VideoUri = "https://www.youtube.com/watch?v=K55o8_hrYtQ"
            });
            _storage.AddVideo(new Movie
            {
                Title = "Resistance Fighters – The Global Antibiotics Crisis",
                Duration = 1682,
                VideoUri = "https://cdn.sample.com/master_bvp-_resistance_fighters_de-ins-ut_de-20_h264-high/youtube_source_bvp-_resistance_fighters_de-ins-ut_de-20_h264-high.mpd"
            });
            _storage.AddVideo(new Movie
            {
                Title = "Following Habeck",
                Duration = 1095,
                VideoUri = "https://m.youtube.com/watch?v=vo8hxCLv4FU",
                ImdbId = "tt8014110"
            });
            _storage.AddVideo(new Movie
            {
                Title = "Yves' Promise",
                Duration = 4738,
                VideoUri = "https://cdn.sample.de/yves-versprechen/yves-versprechen.mpd",
                ImdbId = "tt7842194"
            });

        }
    }
}

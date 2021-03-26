
using FilmwerteChallenge.Interfaces;
using System.Collections.Generic;

namespace FilmwerteChallenge
{
    /// <summary>
    /// Represents an in-memory storage for a list of movies.
    /// </summary>
    public class InMemoryStorage: IStorage
    {
        /// <summary>
        /// Contains the in-memory storage for all Videos.
        /// </summary>
        private List<IVideo> videos = new List<IVideo>();

        /// <summary>
        /// Adds a new video to the storage.
        /// </summary>
        /// <param name="video">The video that is to be stored.</param>
        public void AddVideo(IVideo video)
        {
            this.videos.Add(video);
        }

        /// <summary>
        /// Remove a video from the storage.
        /// </summary>
        /// <param name="video">The video that is to be removed from storage.</param>
        public void RemoveVideo(IVideo video)
        {
            this.videos.Remove(video);
        }

        /// <summary>
        /// Gets a list of all stored movies.
        /// </summary>
        /// <returns>Returns a list of all stored movies.</returns>
        public IEnumerable<IVideo> GetAllVideos()
        {
            return this.videos;
        }
    }
}

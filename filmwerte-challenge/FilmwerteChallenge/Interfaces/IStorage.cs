using System.Collections.Generic;

namespace FilmwerteChallenge.Interfaces
{
    /// <summary>
    /// Represents a type which stores <see cref="IVideo"/>
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Adds a new video to the storage.
        /// </summary>
        /// <param name="video">The video that is to be stored.</param>
        void AddVideo(IVideo video);

        /// <summary>
        /// Remove a video from the storage.
        /// </summary>
        /// <param name="video">The video that is to be removed from storage.</param>
        void RemoveVideo(IVideo video);

        /// <summary>
        /// Gets a list of all stored movies.
        /// </summary>
        /// <returns>Returns a list of all stored movies.</returns>
        IEnumerable<IVideo> GetAllVideos();
    }
}

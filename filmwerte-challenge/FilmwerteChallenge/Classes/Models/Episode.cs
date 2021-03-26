using FilmwerteChallenge.Interfaces;
using System;

namespace FilmwerteChallenge.Classes.Models
{
    /// <summary>
    /// Represents a Episode of a Series.
    /// </summary>
    public class Episode : IVideo
    {
        /// <summary>
        /// Gets or sets the ID of the episode, which is globally unique.
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the official Episode title in English.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the episode in seconds.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the URI that points to the web storage where the Episode file is located.
        /// </summary>
        public string VideoUri { get; set; }

        /// <summary>
        /// Gets or Sets the title of the Series for the Episode.
        /// </summary>
        public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or Sets the Series Number for the Episode.
        /// </summary>
        public int SeasonNumber { get; set; }
    }
}

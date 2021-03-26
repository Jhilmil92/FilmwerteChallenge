namespace FilmwerteChallenge.Interfaces
{
    /// <summary>
    /// Represents a Video type.
    /// </summary>
    public interface IVideo
    {
        /// <summary>
        /// Gets or sets the ID of the Video, which is globally unique.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the official Video title in English.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the duration of the Video in seconds.
        /// </summary>
        int Duration { get; set; }

        /// <summary>
        /// Gets or sets the URI that points to the web storage where the Video file is located.
        /// </summary>
        string VideoUri { get; set; }
    }
}

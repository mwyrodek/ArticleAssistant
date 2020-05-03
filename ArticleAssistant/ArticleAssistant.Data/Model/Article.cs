namespace ArticleAssistant.Data.Model
{
    using System;

    /// <summary>
    /// Article data model
    /// </summary>
    public class Article
    {
        /// <summary>
        /// gets or sets unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// gets or sets article url
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// gets or sets article title
        /// </summary>
        public string Title { get; set; }
    }
}
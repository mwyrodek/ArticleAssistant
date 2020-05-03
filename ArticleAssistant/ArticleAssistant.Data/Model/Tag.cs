namespace ArticleAssistant.Data.Model
{
    /// <summary>
    /// Tags connected to article
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// gets or sets unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// gets or sets Tag Name.
        /// </summary>
        public string Name { get; set; }
    }
}
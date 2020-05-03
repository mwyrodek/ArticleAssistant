namespace ArticleAssistant.Data
{
    using ArticleAssistant.Data.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Article Assistant Database context
    /// </summary>
    public class ArticleAssistantContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleEpisodeMap> ArticleEpisodeMaps { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryArticleMap> CategoryArticleMaps { get; set; }

        public DbSet<Episode> Episodes { get; set; }

        public DbSet<EpisodeWeekAggregateMap> EpisodeWeekAggagateMaps { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<TagArticleMap> TagArticleMaps { get; set; }

        public DbSet<WeekAggregate> WeekAggragates { get; set; }

        // todo move this to config
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ArticleAssistant.db");
    }
}
namespace ArticleAssistant.Data
{
    using System.Collections.Generic;
    using ArticleAssistant.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public class ArticleAssistantContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleEpisodeMap> ArticleEpisodeMaps { get; set; }

        public DbSet<Category> Categories  { get; set; }

        public DbSet<CategoryArticleMap> CategoryArticleMaps { get; set; }

        public DbSet<Episode> Episodes { get; set; }

        public DbSet<EpisodeWeekAggagateMap> EpisodeWeekAggagateMaps { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<TagArticleMap> TagArticleMaps { get; set; }

        public DbSet<WeekAggragate> WeekAggragates { get; set; }

        // todo move this to config
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ArticleAssistant.db");
    }
}
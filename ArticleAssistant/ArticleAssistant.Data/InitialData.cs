namespace ArticleAssistant.Data
{
    using System;
    using ArticleAssistant.Data.Model;
    using Microsoft.EntityFrameworkCore.Internal;

    /// <summary>
    /// Creates intial data to strat application
    /// </summary>
    public static class InitialData
    {
        /// <summary>
        /// seed data base with data
        /// </summary>
        /// <param name="dbContext">database context</param>
        public static void Seed(this ArticleAssistantContext dbContext)
        {
            // ReSharper disable once SA1503
            if (dbContext == null) throw new ArgumentNullException($"dbcontext is null");

            AddExampleTags(dbContext);
            AddExampleCategories(dbContext);
            AddExampleArticles(dbContext);
            AddExampleCategoryArticleMap(dbContext);
            AddExampleTagArticleMap(dbContext);
            AddEpisodeExample(dbContext);
            AddWeekAggregate(dbContext);
            AddEpiosdeWeekAggregate(dbContext);
        }

        private static void AddWeekAggregate(ArticleAssistantContext dbContext)
        {
            if (dbContext.WeekAggragates.Any()) return;

            dbContext.WeekAggragates.Add(new WeekAggregate()
            {
                WeekNumber = 18,
            });
        }

        private static void AddEpiosdeWeekAggregate(ArticleAssistantContext dbContext)
        {
            if (dbContext.EpisodeWeekAggagateMaps.Any()) return;

            dbContext.EpisodeWeekAggagateMaps.Add(new EpisodeWeekAggregateMap
            {
                EpisodeId = 1,
                WeekAggregateId = 1,
            });
        }

        private static void AddEpisodeExample(ArticleAssistantContext dbContext)
        {
            if (dbContext.Episodes.Any()) return;

            dbContext.Episodes.Add(new Episode()
            {
                Number = 22,
                ReleaseDate = new DateTime(2020, 5, 4),
            });
        }

        private static void AddExampleArticles(ArticleAssistantContext dbContext)
        {
            if (dbContext.Articles.Any()) return;

            dbContext.Articles.Add(new Article
            {
                Title = "TestFest",
                Url = new Uri("http://testfest.pl/poprzednie-edycje/rok-2020/"),
            });

            dbContext.Articles.Add(new Article
            {
                Title = "Humble Bundle C#",
                Url = new Uri("https://www.humblebundle.com/books/c-net-core-packt-books"),
            });
            dbContext.Articles.Add(new Article
            {
                Title = "Machine Learning Engineers will not exist in 10 years",
                Url = new Uri("https://towardsdatascience.com/machine-learning-engineers-will-not-exist-in-10-years-c9cbbf4472f3"),
            });
            dbContext.Articles.Add(new Article
            {
                Title = "Pipelines Game",
                Url = new Uri("https://www.praqma.com/stories/pipeline-card-game/"),
            });
        }

        private static void AddExampleCategoryArticleMap(ArticleAssistantContext dbContext)
        {
            if (dbContext.CategoryArticleMaps.Any()) return;

            dbContext.CategoryArticleMaps.Add(new CategoryArticleMap
            {
                CategoryId = 1,
                ArticleId = 1,
            });

            dbContext.CategoryArticleMaps.Add(new CategoryArticleMap
            {
                CategoryId = 2,
                ArticleId = 2,
            });

            dbContext.CategoryArticleMaps.Add(new CategoryArticleMap
            {
                CategoryId = 3,
                ArticleId = 3,
            });

            dbContext.CategoryArticleMaps.Add(new CategoryArticleMap
            {
                CategoryId = 4,
                ArticleId = 4,
            });
        }

        private static void AddExampleTagArticleMap(ArticleAssistantContext dbContext)
        {
            if (dbContext.TagArticleMaps.Any()) return;

            dbContext.TagArticleMaps.Add(new TagArticleMap()
            {
                TagId = 1,
                ArticleId = 1,
            });

            dbContext.TagArticleMaps.Add(new TagArticleMap()
            {
                TagId = 2,
                ArticleId = 2,
            });

            dbContext.TagArticleMaps.Add(new TagArticleMap()
            {
                TagId = 3,
                ArticleId = 3,
            });

            dbContext.TagArticleMaps.Add(new TagArticleMap()
            {
                TagId = 4,
                ArticleId = 4,
            });
        }

        private static void AddExampleCategories(ArticleAssistantContext dbContext)
        {
            if (dbContext.Categories.Any()) return;

            dbContext.Categories.Add(new Category
            {
                Name = "Testing",
            });

            dbContext.Categories.Add(new Category
            {
                Name = "Programming",
            });

            dbContext.Categories.Add(new Category
            {
                Name = "Soft",
            });

            dbContext.Categories.Add(new Category
            {
                Name = "Other",
            });
        }

        private static void AddExampleTags(ArticleAssistantContext dbContext)
        {
            if (dbContext.Tags.Any()) return;

            dbContext.Tags.Add(new Tag
            {
                Name = "Selenium",
            });

            dbContext.Tags.Add(new Tag
            {
                Name = "CSharp",
            });

            dbContext.Tags.Add(new Tag
            {
                Name = "AI",
            });

            dbContext.Tags.Add(new Tag
            {
                Name = "Games",
            });
        }
    }
}
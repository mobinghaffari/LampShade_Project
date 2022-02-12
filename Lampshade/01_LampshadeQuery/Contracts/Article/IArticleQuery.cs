using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> LatestArticles();

    }
}

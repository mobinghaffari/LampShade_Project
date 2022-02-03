using System.Collections.Generic;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.EntityFrameworkCore;

namespace BlogManagement.Application.Contracts.Article
{
    public class ArticleSearchModel
    {
        public string Title { get; set; }
        public long CategoryId { get; set; }
    }
}

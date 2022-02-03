using System;
using _0_Framework.Domain;
using BlogManagement.Domain.ArticleCategoryAgg;

namespace BlogManagement.Domain.ArticleAgg
{
    public class Article : EntityBase
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string CanonicalAddress { get; private set; }
        public string Description { get; private set; }
        public DateTime PublishDate { get; private set; }
        public long CategoryId { get; private set; }
        public ArticleCategory Category { get; private set; }

        public Article(string title, string shortDescription, string picture, string pictureAlt,
            string pictureTitle, string slug, string keywords, string metaDescription, string canonicalAddress
            , string description, long categoryId, DateTime publishDate)
        {
            Title = title;
            ShortDescription = shortDescription;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CanonicalAddress = canonicalAddress;
            Description = description;
            CategoryId = categoryId;
            PublishDate = publishDate;
        }
        public void Edit(string title, string shortDescription, string picture, string pictureAlt,
            string pictureTitle, string slug, string keywordsI, string metaDescription, string canonicalAddress
            , string description, long categoryId, DateTime publishDate)
        {
            Title = title;
            ShortDescription = shortDescription;
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywordsI;
            MetaDescription = metaDescription;
            CanonicalAddress = canonicalAddress;
            Description = description;
            CategoryId = categoryId;
            PublishDate = publishDate;
        }
    }
}

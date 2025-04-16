using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IArticle
    {
        IEnumerable<Article> GetArticle();
        Article GetArticleById(int id);
        bool InsertArticle(Article article);
        bool UpdateArticle(Article article);
        bool DeleteArticle(Article article);
        bool DeleteArticle(int id);
        void Save();

    }
}

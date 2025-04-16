using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IArticleComment
    {
        IEnumerable<ArticleComment> GetComments();
        ArticleComment GetByArticleCommentId(int id);
        bool InsertArticleComment(ArticleComment comment);
        bool UpdateArticleComment(ArticleComment comment);
        bool DeleteArticleComment(ArticleComment comment);
        bool DeleteArticleComment(int id);
        void Save();

    }
}

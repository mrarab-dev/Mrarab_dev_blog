using DataLayer.Model;
using DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class ArticleCommentServices : IArticleComment

    {
        private readonly BlogContext _blogContext;
        public IEnumerable<ArticleComment> GetComments()
        {
            return _blogContext.ArticleComments;
        }
        public ArticleComment GetByArticleCommentId(int id)
        {
            return _blogContext.ArticleComments.Find(id);
        }

        public bool InsertArticleComment(ArticleComment comment)
        {
            try
            {
                _blogContext.ArticleComments.Add(comment);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool UpdateArticleComment(ArticleComment comment)
        {
            try
            {
                _blogContext.Entry(comment).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteArticleComment(ArticleComment comment)
        {
            try
            {
                _blogContext.Entry(comment).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteArticleComment(int id)
        {
            try
            {
                var DeleteId= GetByArticleCommentId(id);
                DeleteArticleComment(DeleteId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
        public void Save()
        {
            _blogContext.SaveChanges();
        }

      
    }
}

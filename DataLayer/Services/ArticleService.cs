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
    public class ArticleService : IArticle
    {
        private readonly BlogContext _blogContext;
        public IEnumerable<Article> GetArticle()
        {
            return _blogContext.Articles;
        }

        public Article GetArticleById(int id)
        {
            return _blogContext.Articles.Find(id);
        }

        public bool InsertArticle(Article article)
        {
            try
            {
                _blogContext.Articles.Add(article);
                return true;
            }   
            catch 
            {
                return false;
            }
        }
        public bool UpdateArticle(Article article)
        {
            try
            {
                _blogContext.Entry(article).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteArticle(Article article)
        {
            try
            {
                _blogContext.Entry(article).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteArticle(int id)
        {
            try
            {
                var DeleteId = GetArticleById(id);
                DeleteArticle(DeleteId);
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

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
    public class ArticleCategoryService : IArticleCatgory
    {
        private readonly BlogContext _blogContext;
        public IEnumerable<ArticleCategory> GetCategories()
        {
            return _blogContext.ArticleCategories;
        }

        public ArticleCategory GetCategoryById(int id)
        {
            return _blogContext.ArticleCategories.Find(id);
        }

        public bool InsertCategory(ArticleCategory category)
        {

            try
            {
                _blogContext.ArticleCategories.Add(category);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCategory(ArticleCategory category)
        {
            try
            {
                _blogContext.Entry(category).State =EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCategory(ArticleCategory category)
        {
            try
            {
                _blogContext.Entry(category).State=EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCategory(int id)
        {
            try
            {
                var DeleteId = GetCategoryById(id);
                DeleteCategory(DeleteId);
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

using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IArticleCatgory
    {
        IEnumerable<ArticleCategory> GetCategories();
        ArticleCategory GetCategoryById(int id);
        bool InsertCategory(ArticleCategory category);
        bool UpdateCategory(ArticleCategory category);
        bool DeleteCategory(ArticleCategory category);
        bool DeleteCategory(int id);
        void Save();

    }
}

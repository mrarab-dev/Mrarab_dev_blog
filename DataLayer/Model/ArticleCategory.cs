using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class ArticleCategory
    {
        [Key]
        public int ArticleCategoryId { get; set; }
        [Display(Name = "عنوان دسته بندی")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "عنوان تایتل")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string MetaTitle { get; set; }
        [Display(Name = "دیسکریپشن")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string MetaDescription { get; set; }
        List<Article> articles { get; set; }
    }
}

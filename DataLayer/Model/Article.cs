using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public int ArticleCategoryId { get; set; }
        [Display(Name = "عنوان مقاله")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "عنوان تایتل")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string MetaTitle { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "دیسکریپشن")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string MetaDescription { get; set; }
        [Display(Name = "url")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Url { get; set; }
        [Display(Name = "توضیحات کوتاه")]
        public string ShortText { get; set; }
        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Img { get; set; }
        [Display(Name = "عکس Alt")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string ImgAlt {  get; set; }
        [Display(Name = " تایتل عکس ")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string ImgTitle { get; set; }
        [Display(Name = "ویدئو")]
        public string Video { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime DateTime { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        List<ArticleComment> ArticleComments { get; set; }
    }
}
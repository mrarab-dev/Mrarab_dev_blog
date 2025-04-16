using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class ArticleComment
    {
        [Key]
        public int ArticleCommentId { get; set; }

        public int ArticleId { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime DateTime { get; set; }       
        public Article Article  { get; set; }

    }
}

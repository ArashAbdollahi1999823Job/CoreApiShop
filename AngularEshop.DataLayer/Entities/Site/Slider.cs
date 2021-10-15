using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Site
{
    public  class Slider:BaseEntity
    {
        #region Properties


        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(150, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 150 باشد")]
        public string ImageName { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(500, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 500 باشد")]
        public string Description { get; set; }
        [Display(Name = "لینک")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string Link { get; set; }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public  class Product:BaseEntity
    {
        #region Properties
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string ProductName { get; set; }

        [Display(Name = "قیمت")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public int Price { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string ShortDescription { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string Description { get; set; }

        [Display(Name = "نام تصویر")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string ImageName { get; set; }

        [Display(Name = "موجودی")]

        public bool IsExists { get; set; }


        [Display(Name = "ویژه")]
        public bool IsSpecial { get; set; }

        #endregion


        #region relation

        public ICollection<ProductGallery> ProductGalleries { get; set; }
        public ICollection<ProductVisit> ProductVisits { get; set; }

        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }


        #endregion
    }
}

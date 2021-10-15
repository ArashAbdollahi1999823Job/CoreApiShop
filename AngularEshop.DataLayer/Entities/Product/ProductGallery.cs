using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class ProductGallery : BaseEntity
    {
        #region Properties

        public long ProductId { set; get; }

        [Display(Name = "نام تصویر")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string ImageName { set; get; }


        #endregion

        #region relation
        public Product Product { set; get; }
        #endregion
    }

}

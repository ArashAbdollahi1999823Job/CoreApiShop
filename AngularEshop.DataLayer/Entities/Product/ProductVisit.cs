using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class ProductVisit:BaseEntity
    {
        #region Properties

        public long ProductId { get; set; }

        [Display(Name = "اپی)")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string  UserIp { get; set; }


        #endregion

        #region relation

        public Product Product { get; set; }


        #endregion
    }
}

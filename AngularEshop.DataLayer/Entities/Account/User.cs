using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Access;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Account
{
   public  class User:BaseEntity
    {
        #region Properties
        [Display(Name="ایمیل")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100,ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string Email { get; set; }
        [Display(Name="نام")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]

        public string FirstName { get; set; }

        [Display(Name = "نام خوانوادگی ")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]

        public string LastName { get; set; }
        [Display(Name="ادرس")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(500, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از500 باشد")]

        public string Address { get; set; }

        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]
        public string EmailActiveCode { get; set; }
        public bool IsActivated { get; set; }

        #endregion

        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Access
{
    public class Role:BaseEntity
    {
        #region Properties
        [Display (Name= "نام سیستمی")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]

        public string Name { get; set; }
        [Display(Name="عنوان")]
        [Required(ErrorMessage = "  را وارد کنید{0} لطفا ")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر ها نمی تواند بیشتر از 100 باشد")]

        public string Title { get; set; }

        #endregion


        #region Relations

        public ICollection<UserRole> UserRoles { get; set; }


        #endregion
    }
}

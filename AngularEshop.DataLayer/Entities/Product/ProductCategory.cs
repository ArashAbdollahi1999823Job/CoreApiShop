using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Common;

namespace AngularEshop.DataLayer.Entities.Product
{
    public class ProductCategory:BaseEntity
    {
        #region Properties

        public string Title { get; set; }
        public long? ParentId { get; set; }

        #endregion

        #region relation
        [ForeignKey("ParentId")]
        public ProductCategory Parents { get; set; }
        public ICollection<ProductSelectedCategory> ProductSelectedCategories { get; set; }


        #endregion
    }
}

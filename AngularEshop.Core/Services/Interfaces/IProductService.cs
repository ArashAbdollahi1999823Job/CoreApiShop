using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.DataLayer.Entities.Product;

namespace AngularEshop.Core.Services.Interfaces
{
   public interface IProductService:IDisposable
   {
       Task AddProduct(Product product);

       Task UpdateProduct(Product product);

   }
}

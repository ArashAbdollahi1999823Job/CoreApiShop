using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Product;
using AngularEshop.DataLayer.Repository;

namespace AngularEshop.Core.Services.Inplementation
{
    public class ProductService : IProductService
    {
        #region ctor

        private IGenericRepository<Product> _productRepository;
        private IGenericRepository<ProductGallery> _productGalleryRepository;
        private IGenericRepository<ProductCategory> _productCategoryRepository;
        private IGenericRepository<ProductVisit> _productVisitRepository;
        private IGenericRepository<ProductSelectedCategory> _productSelectedRepository;


        public ProductService(IGenericRepository<Product> productRepository, IGenericRepository<ProductGallery> productGalleryRepository, IGenericRepository<ProductCategory> productCategoryRepository, IGenericRepository<ProductVisit> productVisitRepository, IGenericRepository<ProductSelectedCategory> productSelectedRepository)
        {
            _productRepository = productRepository;
            _productGalleryRepository = productGalleryRepository;
            _productCategoryRepository = productCategoryRepository;
            _productVisitRepository = productVisitRepository;
            _productSelectedRepository = productSelectedRepository;
        }

        #endregion


        #region Product


        public async Task AddProduct(Product product)
        {
            await _productRepository.AddEntity(product);
            await _productRepository.SaveChange();

        }

        public async Task UpdateProduct(Product product)
        {
            _productRepository.UpdateEntity(product);
            await _productRepository.SaveChange();
        }


        #endregion


        #region Dispose



        public void Dispose()
        {
            _productRepository?.Dispose();
            _productGalleryRepository?.Dispose();
            _productCategoryRepository?.Dispose();
            _productVisitRepository?.Dispose();
            _productSelectedRepository?.Dispose();
        }
        #endregion
    }
}

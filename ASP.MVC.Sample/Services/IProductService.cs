using DellChallenge.D2.Web.Models;
using System;
using System.Collections.Generic;

namespace DellChallenge.D2.Web.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(Guid id);
        ProductModel Add(ProductDetailsModel product);
        void Update(Guid id, ProductDetailsModel product);
        void Delete(Guid id);
    }
}
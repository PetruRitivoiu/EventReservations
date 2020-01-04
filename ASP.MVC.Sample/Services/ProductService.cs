using System;
using System.Collections.Generic;
using DellChallenge.D2.Web.Models;
using RestSharp;

namespace DellChallenge.D2.Web.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<ProductModel> GetAll()
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest("products", Method.GET, DataFormat.Json);
            var apiResponse = apiClient.Execute<List<ProductModel>>(apiRequest);
            return apiResponse.Data;
        }

        public ProductModel GetById(Guid id)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{id}", Method.GET, DataFormat.Json);
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }

        public ProductModel Add(ProductDetailsModel product)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest("products", Method.POST, DataFormat.Json);
            apiRequest.AddJsonBody(product);
            var apiResponse = apiClient.Execute<ProductModel>(apiRequest);
            return apiResponse.Data;
        }

        public void Update(Guid id, ProductDetailsModel product)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{id}", Method.PUT, DataFormat.Json);
            apiRequest.AddJsonBody(product);
            apiClient.Execute(apiRequest);
        }

        public void Delete(Guid id)
        {
            var apiClient = new RestClient("http://localhost:5000/api");
            var apiRequest = new RestRequest($"products/{id}", Method.DELETE, DataFormat.Json);
            apiClient.Execute(apiRequest);
        }
    }
}

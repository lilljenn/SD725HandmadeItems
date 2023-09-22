using Handmade_Items_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Handmade_Items_API.API
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public Products Get()
        {
            List<Product> _productList = new List <Product>();
            // This would come from a data source or data provider!!!!
            _productList.Add(new Product("Headband", "A carefully made headband that comes in a variety of colors"));
            _productList.Add(new Product("Hat", "A warm hat made to keep you warm"));
            Products _products = new Products(_productList.ToArray());
            return _products;
        }
        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
       public void Post([FromBody] string value) 
        { 
        
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody] string value)
        {

        }

        // Delete api/Product/5
        public void Delete(int id) { }
    }
}

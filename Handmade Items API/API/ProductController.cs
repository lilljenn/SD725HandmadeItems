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
        // print list of products
        // GET: api/Product
        public List<Product> Get()
        {
            List<Product> _productList = new List <Product>();
            // This would come from a data source or data provider!!!!
            _productList.Add(new Product(1001, "Headband", "A carefully made headband that comes in a variety of colors", "Small", "Black"));
            _productList.Add(new Product(1002, "Hat", "A warm hat made to keep you warm", "Medium", "White"));
            
            return _productList;
        }
        // print product, according to id
        // GET: api/Product/5
     public Product GetProduct(int id)
        {
            Product product;
            product = new Product(id, "name", "description", "size", "color");
      
            if (id == 1001)
            {
                product = new Product(1001, "Headband", "A carefully made headband that comes in a variety of colors", "Small", "Black");
                          
            }
            if (id == 1002)
            {
                product = new Product(1002, "Hat", "A warm hat made to keep you warm", "Medium", "White");
            }

            return product;
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

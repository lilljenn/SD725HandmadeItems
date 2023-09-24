using Handmade_Items_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Handmade_Items_API.Models
{
    [Serializable]
    public class Product
    {
        // initialize variables
        public string name;
        public string description;
        public int id;
        public string size;
        public string color;
 
        // create a class (Product) that takes in the id, name, description, size, and color for every product
        public Product(int inId, string inName, string inDescription, string inSize, string inColor)
        {
            id = inId;
            name = inName;
            description = inDescription;
            size = inSize;
            color = inColor;
        }
    }
}
using Handmade_Items_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Handmade_Items_API.Models
{
    [Serializable]
    public class Product
    {
        public string name;
        public string description;

        public Product(string inName, string inDescription)
        {
            name = inName;
            description = inDescription;

        }
    }
}
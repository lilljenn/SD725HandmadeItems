using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace Handmade_Items_API.Models
{
    [Serializable]
    public class Products //: IEnumerable
    {
        private Product[] _products;
        public Products(Product[] productArray)
        {
            _products = new Product[productArray.Length];

            for (int i = 0; i < productArray.Length; i++)
            {
                _products[i] = productArray[i];
            }
        }




        /*   // Implementation for the GetEnumerator method.
           IEnumerator IEnumerable.GetEnumerator()
           {
               return (IEnumerator)GetEnumerator();
           }

           public PeopleEnum GetEnumerator()
           {
               return new PeopleEnum(_products);
           }
       }
       public class PeopleEnum : IEnumerator
           {
               public Product[] _products;

               // Enumerators are positioned before the first element
               // until the first MoveNext() call.
               int position = -1;

               public PeopleEnum(Product[] list)
               {
                   _products = list;
               }

               public bool MoveNext()
               {
                   position++;
                   return (position < _products.Length);
               }

               public void Reset()
               {
                   position = -1;
               }

               object IEnumerator.Current
               {
                   get
                   {
                       return Current;
                   }
               }

               public Product Current
               {
                   get
                   {
                       try
                       {
                           return _products[position];
                       }
                       catch (IndexOutOfRangeException)
                       {
                           throw new InvalidOperationException();
                       }
                   }
               }*/
    }
    }


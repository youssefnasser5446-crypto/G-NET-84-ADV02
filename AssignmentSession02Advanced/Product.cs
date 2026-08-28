using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession02Advanced
{
     public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }//"Electronics","Clothing","Food","Books"
        public double Price { get; set; }
        public int Stock { get; set; }
    

    public List<Product> SearchProducts(List<Product> productList, Func<Product, bool> filter)
        {
            List<Product> products = new List<Product>();
            foreach (Product item in productList)
            {
                if (filter(item))
                    products.Add(item);
            }
            return products;
       }
       public void PrintReport (List<Product>products ,Action<Product> refAction )
        {
            foreach (Product product in products)
            {
                refAction(product);
            }      
        }

        public List<TResult> TransformProducts<TResult>(List<Product> products , Func<Product, TResult> funcProduct)
        {
            List<TResult> productsAdd = new List<TResult>();
            foreach (Product item in products)
            {
                productsAdd.Add(funcProduct(item));
            
            }
            return productsAdd;
        }
    }
} 



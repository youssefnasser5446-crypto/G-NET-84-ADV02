using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading.Channels;

namespace AssignmentSession02Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
                     {
                        new Product {Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},

                        new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
                        new Product{Id=3,Name="T-Shirt",Category="Clothing",Price=30,Stock=100},
                        new Product{Id=4,Name="Jeans",Category="Clothing",Price=60,Stock=50},
                        new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
                        new Product{Id=6,Name="CoffeeBeans",Category="Food",Price=15,Stock=80},
                        new Product{Id=7,Name="C#Book",Category="Books",Price=45,Stock=30},
                        new Product{Id=8,Name="Novel",Category="Books",Price=20,Stock=60},
                        new Product{Id=9,Name="Headphones",Category="Electronics",Price=150}
                    };

            #region Question01
            //Product product = new Product();

            //// Using Func<Product, bool> because it accepts a Product object and returns a boolean condition for filtering.

            //Console.WriteLine("Electronics ====================================");

            //Func<Product, bool> all = product => product.Category is "Electronics";

            //List<Product> products = product.SearchProducts(catalog, all);
            //foreach (Product prod in products)
            //{
            //    Console.WriteLine($"{prod.Name} - {prod.Price}$ ( stock : {prod.Stock})");
            //}

            //Console.WriteLine("under 50$ =====================================================");

            //Func<Product, bool> chap = product => product.Price < 50;

            //List<Product> productschap = product.SearchProducts(catalog, chap);

            //foreach (Product prod in productschap)
            //{
            //    Console.WriteLine($"{prod.Name} - {prod.Price}$ ( stock : {prod.Stock})");
            //}

            //Console.WriteLine(" stock > 0 ===================================================");

            //Func<Product, bool> stock = product => product.Stock > 0;

            //List<Product> productsStock = product.SearchProducts(catalog, stock);

            //foreach (Product prod in productsStock)
            //{
            //    Console.WriteLine($"{prod.Name} - {prod.Price}$ ( stock : {prod.Stock})");

            //}

            //Console.WriteLine(" under $100 ===============================================  ");
            //Func<Product, bool> chap2 = product => product.Price < 100 && product.Category == "Clothing";

            //List<Product> productschap2 = product.SearchProducts(catalog, chap2);

            //foreach (Product prod in productschap2)
            //{
            //    Console.WriteLine($"{prod.Name} - {prod.Price}$ ( stock : {prod.Stock})");
            //}

            //Console.WriteLine("===============================================================");

            #endregion

            #region Question02

            Product product = new Product();
            Action<Product> actionShort = productShort => Console.WriteLine($"{productShort.Name} - {productShort.Price:c}");
            Console.WriteLine("======================================================");
            Console.WriteLine("---ShortReport---");
            Console.WriteLine("======================================================");

            product.PrintReport(catalog, actionShort);



            
            Action<Product> actionDetials = productDetials => Console.WriteLine($"[{productDetials.Category}]{productDetials.Name} |" +
                $"price : {productDetials.Price:c} | Stock {productDetials.Stock}");
            Console.WriteLine("======================================================");
            Console.WriteLine("--DetailedReport--");
            Console.WriteLine("======================================================");
            product.PrintReport(catalog, actionDetials);

            Console.WriteLine("======================================================");
            Console.WriteLine("--- Summary List---");
            Console.WriteLine("======================================================");

            Func<Product, string> productSummary = productSummary => $"{productSummary.Name} ({productSummary.Price:c}) ";

            List<string> products= product.TransformProducts(catalog, productSummary);

            foreach (string item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("======================================================");
            Console.WriteLine("--- Price Labels---");
            Console.WriteLine("======================================================");

            Func<Product, string> productLabel = productLabel => $"{productLabel.Name} {(productLabel.Price > 100 ? ": Expensive! ":" : Affordable")}";

            List<string> productListLabel = product.TransformProducts(catalog, productLabel);

           foreach (string item in productListLabel)
            { 
                Console.WriteLine(item);
            }


            #endregion

            #region Question03
           // Console.WriteLine("======================================================");
           // Console.WriteLine("--- Low-Stock Alert---");
           // Console.WriteLine("======================================================");
           // Predicate<Product> pred = productPredicate => productPredicate.Stock < 20;
           //List<Product> listFilter = product.FilterProducts(catalog, pred);

           // foreach(Product filter in listFilter)
           // {
           //     Console.WriteLine($"[LOW STOCK] {filter.Name} : only {filter.Stock} left!");
           // }


            #endregion
        }
    }
}

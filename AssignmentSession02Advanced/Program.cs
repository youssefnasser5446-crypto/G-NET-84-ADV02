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
        }
    }
}

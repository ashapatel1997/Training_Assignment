using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product() { Name = "lettuce", Price = 10.5f, Quantity = 50, Type = "Leafy green" });
            ProductList.Add(new Product() { Name = "cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" });

            ProductList.Add(new Product() { Name = "pumpkin", Price = 30, Quantity = 30, Type = "Marrow" });

            ProductList.Add(new Product() { Name = "cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" });
            ProductList.Add(new Product() { Name = "zucchini", Price = 20.5f, Quantity = 50, Type = "Marrow" });
            ProductList.Add(new Product() { Name = "yam", Price = 30, Quantity = 50, Type = "Root" });
            ProductList.Add(new Product() { Name = "spinach", Price = 10, Quantity = 100, Type = "Leafy green" });
            ProductList.Add(new Product() { Name = "broccoli", Price = 20, Quantity = 75, Type = "Cruciferous" });
            ProductList.Add(new Product() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy green" });
            ProductList.Add(new Product() { Name = "silverbeet", Price = 10, Quantity = 50, Type = "Marrow" });


            Console.WriteLine("Total number of  Products in List:" + ProductList.Count+"\n");

            


            ProductList.Add(new Product() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" });
            Console.WriteLine("\nList of Product after adding new product....\n");
            foreach (Product product in ProductList)
            {
                Console.WriteLine(product);
                
            }
            Console.WriteLine("\n");
            Console.WriteLine("Total number of  Products in List:" + ProductList.Count + "\n");

            Console.WriteLine("Products of which have the type 'Leafy green'...\n");

          
            for (int i = 0; i < ProductList.Count; i++) // Loop through List with for
            {
                if(ProductList[i].Type == "Leafy green")
                    Console.WriteLine(ProductList[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < ProductList.Count; i++) 
            {
                if (ProductList[i].Name == "Garlic")
                    ProductList.Remove(ProductList[i]);
            }
            Console.WriteLine("Products after removing 'Gralic'...\n");
            foreach (Product product in ProductList)
            {
                Console.WriteLine(product);

            }

            Console.WriteLine("\nFinal quantity of cabbage in the inventory...\n"); 
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].Name == "cabbage")
                {
                    int x =ProductList[i].Quantity;
                    x += 50;
                    ProductList[i].Quantity = x;
                    Console.WriteLine(ProductList[i].Quantity);
                }
                
            }
            float totalPrice = 0;
            for (int i = 0; i < ProductList.Count; i++)
            {
                int lettuce = 1, broccoli=1, zucchini = 2;
               
                if (ProductList[i].Name == "lettuce")
                    totalPrice += (lettuce * ProductList[i].Price);
                else if (ProductList[i].Name == "broccoli")
                    totalPrice += (broccoli * ProductList[i].Price);
                else if (ProductList[i].Name == "zucchini")
                    totalPrice += (zucchini * ProductList[i].Price);
            }
            Console.WriteLine("\nTotal price (lettuce = 1 kg, broccoli=1kg, zucchini = 2 kg): "+totalPrice+" kg\n");

        }

    }
}

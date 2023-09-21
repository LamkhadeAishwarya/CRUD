using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   /** public class ProductCRUD
    {
        private Product[] products;
        private int productCount = 0;
        // = new Product[3];

        private int nextId = 1;

        public ProductCRUD()
        {
            products = new Product[]
               {
                new Product { Id = 1, Name = "Pen", Price = 100, Company = "Belly" },
                new Product { Id = 2, Name = "Pencil", Price = 200, Company = "Apsara" }
               };

        }

        public Product[] DisplayProduct()
        {
            return products;
        }
        public Product GetProduct(int id)
        {
            foreach (Product item in products)
            {
                if (products != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;

        }
        

        public void UpdateProduct(Product p)
        {
            foreach (Product item in products)
            {
                if (item.Id == p.Id)
                {
                    item.Price = p.Price;
                    item.Company = p.Company;
                    item.Name = p.Name;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Id == id)
                {
                    products[i] = null;
                    Array.Copy(products, i + 1, products, i, productCount - i + 1);
                    productCount--;
                    break;
                }
            }
        }




    }**/



   /** internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCRUD productCRUD = new ProductCRUD();

            do
            {

                Console.WriteLine("1: Display Products: ");
                Console.WriteLine("2: GetProduct: ");
                Console.WriteLine("3. update product: ");
                Console.WriteLine("4: Deleted sucessfully: ");
                Console.WriteLine("Enter your choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {

                    case 1:
                        Product[] result = productCRUD.DisplayProduct();
                        Console.WriteLine("Id\t  Name\t Price\t Company\t");
                        foreach (Product item in result)
                        {
                            Console.WriteLine($"{item.Id},  {item.Name}, {item.Price}, {item.Company}");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = productCRUD.GetProduct(id);
                        Console.WriteLine("Id\t  Name\t Price\t Company\t");
                        Console.WriteLine($"{p.Id},     {p.Name},    {p.Price},    {p.Company}");

                        break;

                    case 3:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Id: ");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name: ");
                        p2.Name = (Console.ReadLine());
                        Console.WriteLine("Enter Price: ");
                        p2.Price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company: ");
                        p2.Company = (Console.ReadLine());
                        productCRUD.UpdateProduct(p2);
                        Console.WriteLine("Updated sucessfully.....................");
                        break;

                    case 4:
                        Console.WriteLine("Enter id: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        productCRUD.DeleteProduct(id2);
                        Console.WriteLine($"{id2} - Deleted sucessfully.............");
                        break;


                }








                Console.WriteLine("press 1 if continue...................");
                no = Convert.ToInt32(Console.ReadLine());

            } while (no == 1);

        }
    }**/
}


    


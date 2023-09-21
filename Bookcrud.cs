using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   /** internal class crud
    {
        List<Book> l1;
        public crud()
        {
            l1 = new List<Book>()
            {
                new Book{ ID=2,Name="Chem",Price=34},
                new Book{ ID=3,Name="Bio",Price=67},
                new Book{ ID=4,Name="Phy",Price=78}
            };

        }
        public List<Book> GetList()
        {
            return l1;
        }

        public Book GetID(int id)
        {
            Book c1 =new Book();
            foreach (Book b7 in l1)
            {
                if (b7.ID == id)
                {
                    c1 = b7; 
                    break;
                 
                }
             
           
            }
            return c1;


        }
        public void Add(Book b1)
        {
            l1.Add(b1);
        }

        public void update(Book b1)
        {
            foreach (Book k in l1)
            {
                if (k.ID == b1.ID)
                {
                    k.Name = b1.Name;
                    k.Price = b1.Price;
                    break;
                }
            }
        }

        public void Delete(int id)
        {
            foreach (Book b in l1)
            {
                if (b.ID == id)
                {
                    l1.Remove(b);
                    break;
                }
            }
        }
    }
    public class main
    {
        static void Main(string[] args)
        {
            int no;
            crud b1= new crud();
            do {
                Console.WriteLine( "Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        List<Book>b2=b1.GetList();
                      //  Console.WriteLine("Id", "Name", "Price");
                        foreach (Book b in b2)
                        { 
                            Console.WriteLine($"{b.ID} {b.Name} {b.Price}");
                        }

                        break;
                        case 2:

                        Book b6= new Book();
                        Console.WriteLine( "Enter id");
                        int id=Convert.ToInt32(Console.ReadLine());
                        b6=b1.GetID(id);
                        Console.WriteLine( $"{b6.ID}{b6.Name}{b6.Price}");
                        break;
                        case 3:
                        Book b8=new Book();
                        Console.WriteLine("Enter id");
                        b8.ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine( "Enter name");
                        b8.Name=Console.ReadLine();
                        Console.WriteLine( "Enter price");
                        b8.Price=Convert.ToInt32(Console.ReadLine());
                        b1.Add(b8);
                        break;
                        case 4:
                        Book b7=new Book();
                        Console.WriteLine( "Enter id");
                        b7.ID= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        b7.Name=Console.ReadLine();
                        Console.WriteLine("Enter price");
                        b7.Price=Convert.ToInt32(Console.ReadLine());
                       b1.update(b7);
                        break;
                        case 5:
                        Console.WriteLine( "Enter id Delete");
                        int Id5 = Convert.ToInt32(Console.ReadLine());
                        b1.Delete(Id5);

                        break;
                }








                Console.WriteLine( "Enter 1 for continue");
                no=Convert.ToInt32(Console.ReadLine());
            } while (no==1);
        }
    }**/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   public class Player
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
    }
    public class PlayerCrud
    {
        List<Player> li;
        public PlayerCrud()
        {
            li = new List<Player>()
            {
            new Player { Id = 1, Name = "Sachin", City = "Pune" },
            new Player { Id = 2, Name = "Virat", City = "Mumbai" },
            new Player { Id = 3, Name = "Jayant", City = "Khodad" }
            };

            
        }
       public  List<Player> ReturnList()
        {
            return li;
        }

        public Player GetID(int id)
        {
            Player n1 = new Player();
            foreach (Player z in li)
            {
                if (z.Id == id)
                {
                    n1= z;
                    break;

                }
            }
            return n1;
        }
        public void Add(Player p1)

        {
            li.Add(p1);
        }


        public void Update(Player p)
        {
            //Player t =new Player();
            foreach (Player x in li)
            {
                if (x.Id ==p.Id)
                {
                    x.Name=p.Name; 
                    x.City=p.City;
                    break;
                }
            }
        }
        public void Delete(int id1)
        {
            foreach (Player r in li)
            {
                if (r.Id == id1)
                {
                    li.Remove(r);
                    break;
                }
            }
        }
    }
    public class main
    {
        static void Main(string[] args)
        {
            string yes = "";
            PlayerCrud c4 = new PlayerCrud();
            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("If you wat to changes the students details then follw the following operations ");
                Console.WriteLine("1:Get Student Deatils List");
                Console.WriteLine("2:Perticular ID Details");
                Console.WriteLine("3:Add More Students Details");
                Console.WriteLine("4:Update Students Details");
                Console.WriteLine("5:Delete perticular Student Details");
                Console.WriteLine("Enter your Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                       List<Player>n= c4.ReturnList();
                        foreach (Player t in n)
                        {
                            Console.WriteLine($"{t.Id} {t.Name} {t.City}");
                        }

                        break;

                    case 2:
                        Player m = new Player();
                        Console.WriteLine( "Enter id");
                        int id= Convert.ToInt32(Console.ReadLine());    
                       m= c4.GetID(id);
                        Console.WriteLine($"{m.Id}{m.Name}{m.City}");


                        break;

                    case 3:
                        Player y = new Player();
                        Console.WriteLine( "Enter id");
                        y.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name=");
                        y.Name=Console.ReadLine();
                        Console.WriteLine("Enter city");
                        y.City=Console.ReadLine();
                        c4.Add(y);

                        break;

                    case 4:
                        Player z = new Player();
                        Console.WriteLine("Enter id");
                        z.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name");
                        z.Name=Console.ReadLine();
                        Console.WriteLine("City");
                        z.City=Console.ReadLine();
                        c4.Update(z);
                        //Console.WriteLine($"{z9.Id}{z9.Name}{z9.City}");

                       
                        break;

                    case 5:
                        Console.WriteLine( "Enter id");
                        int id1=Convert.ToInt32(Console.ReadLine());
                        c4.Delete(id1);

                        break;

                    default:
                        Console.WriteLine("Invalid Case");
                        break;
                }
                Console.WriteLine("press yes for continue");
                yes = Console.ReadLine();
            } while (yes == "yes");
        }

    }
    }


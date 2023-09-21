using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   /** internal class studentMain
    {
        static void Main(string[] args)
        {
            string yes = "";
            crud c1 = new crud();
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
                        List<Student> s1 = c1.GetList();
                        Console.WriteLine("Id  Name      Contact      Email");
                        foreach (Student s2 in s1)
                        {
                            Console.WriteLine($"{s2.Id} {s2.Name}  {s2.Contact}  {s2.Email}");
                        }

                        break;

                    case 2:

                        Console.WriteLine("Enter id that you have required");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Student s5 = c1.GetId(id);
                        Console.WriteLine($"{s5.Id} {s5.Name} {s5.Contact} {s5.Email}");
                        break;

                    case 3:
                        Student s9 = new Student();
                        Console.WriteLine("Enter  Student id");
                        s9.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter  Student Name");
                        s9.Name = Console.ReadLine();
                        Console.WriteLine("Enter  Student Contact");
                        s9.Contact = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter Student Email");
                        s9.Email = Console.ReadLine();
                        c1.AddDetails(s9);
                        break;

                    case 4:
                        Student s10 = new Student();
                        Console.WriteLine("Enter Student new Id");
                        s10.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student New name");
                        s10.Name = Console.ReadLine();
                        Console.WriteLine("Enter student new Contact no");
                        s10.Contact = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student new Email id");
                        s10.Email = Console.ReadLine();
                        c1.Update(s10);
                        break;

                    case 5:
                        Console.WriteLine("Enter Student id that you want to Delete");
                        int id6 = Convert.ToInt32(Console.ReadLine());
                        c1.Delete(id6);

                        break;

                    default:
                        Console.WriteLine("Invalid Case");
                        break;
                }
                Console.WriteLine("press yes for continue");
                yes = Console.ReadLine();
            }   while (yes == "yes");
        }

    }**/
}

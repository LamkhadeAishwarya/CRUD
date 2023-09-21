using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
  /* public class empmain
    {
        static void Main(string[] args)
        {
            string s1 = "";
            Empcrud empcrud = new Empcrud();
            do
            {
                Console.WriteLine("############################");
                Console.WriteLine("If you wat to changes the Employee details then follow the following operations ");
                Console.WriteLine("1:Get Employee Deatils List");
                Console.WriteLine("2:Perticular Employee ID Details");
                Console.WriteLine("3:Add More Employee Details");
                Console.WriteLine("4:Update Employee Details");
                Console.WriteLine("5:Delete perticular Employee Details");
                Console.WriteLine("Enter your Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                       
                        List<Employee> l1 = empcrud.GetList();
                        Console.WriteLine($"Empid  EmpName  Empsalary  EmpAddress");
                        foreach (Employee e1 in l1)
                        {
                            Console.WriteLine($"{e1.Empid}   {e1.EmpName}      {e1.Salary}       {e1.Address}");
                        }
                        break;

                    case 2:
                       // Employee e2 = new Employee();
                        Console.WriteLine("Enter Employee id that u want to required");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee e6 = empcrud.GetId(id);
                        Console.WriteLine($"Empid EmpName EmpSalary EmpAddress");
                        Console.WriteLine($"{e6.Empid}  {e6.EmpName}  {e6.Salary}  {e6.Address}");

                        break;

                    case 3:
                        Employee e7 = new Employee();
                        Console.WriteLine("Add Employee Details");
                        Console.WriteLine("Enter Employee ID");
                        e7.Empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        e7.EmpName = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary");
                        e7.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Address");
                        e7.Address = Console.ReadLine();
                        empcrud.AddEmpDetails(e7);
                        break;

                    case 4:
                        Employee ei = new Employee();
                        Console.WriteLine("Enter Empid that u want to update");
                        ei.Empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter  new EmpName");
                        ei.EmpName = Console.ReadLine();
                        Console.WriteLine("Enter  new Salary");
                        ei.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new Address");
                        ei.Address = Console.ReadLine();
                        empcrud.Update(ei);


                        break;

                    case 5:
                        Console.WriteLine("Enter Empid That u want to Delete");
                        Console.WriteLine("Enter id");

                        int id6 = Convert.ToInt32(Console.ReadLine());
                        empcrud.Delete(id6);
                        break;


                }
                  Console.WriteLine("Enter y for Continue");
                s1 = Console.ReadLine();
            } while (s1 == "y");
        }

    }*/
}

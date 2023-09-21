using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
   public class Empcrud
    {
        List<Employee> list1;
        public Empcrud()
        {
            list1 = new List<Employee>()
             {

              new Employee { Empid = 1, EmpName = "Aishwarya",Salary=40000,Address ="Junnar" },
              new Employee { Empid = 2, EmpName = "Tanuja",Salary=44000,Address ="Nagar" },
              new Employee { Empid = 3, EmpName = "Alisha",Salary=48000,Address ="Pune" }

             };
        }
        public List<Employee> GetList()
        {
         
           
            return list1;
        }

        public Employee GetId(int id)
        {
            Employee em=new Employee();
           

            foreach (Employee emp in list1)
            {
                


                if (emp.Empid == id)
                {
                    em=emp;
                    break;
                }

            }
            return em;
            
        }

        public void AddEmpDetails(Employee emp)
        {
           list1.Add(emp);
         
        }

        public void Update(Employee e3)
        {
            foreach (Employee empp in list1)
            {
                if (empp.Empid == e3.Empid)
                {
                    empp.EmpName = e3.EmpName;
                    empp.Salary = e3.Salary;
                    empp.Address = e3.Address;
                    break;

                }
              

            }
        }

        public void Delete(int id6) 
        {
         
                

                foreach (Employee i in list1)
                {

                    if (i.Empid == id6)
                    {
                        list1.Remove(i);
                        break;
                    }

                }
            
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class crud
    {
         private List<Student> list;
        public crud()
        {
           list= new List<Student>()
           {
               new Student{Id=1, Name="Aishwarya", Contact=9657489835, Email="aishwaryalamkhade@gmail.com" },
               new Student{Id=2, Name="Ashwini",   Contact=7821822088, Email="ashwinilamkhade2020@gmail.com" },
               new Student{ Id=3,Name="Swara",     Contact=8805278923, Email="swara01lamkhade@gmail.com"}
           };

        }
        public List<Student> GetList()
        {
            return list;
        }

        public Student GetId(int id)
        {
            Student student= new Student();
            foreach (Student s3 in list)
            {
                if(s3.Id==id)
                {
                    student = s3;
                    break;
                }
            }
            return student;
            
        }

        public void AddDetails(Student p)
        {
            list.Add(p);
        }

        public void Update(Student s1)
        {
            foreach (Student item in list)
            {
                if (item.Id == s1.Id)
                {
                    item.Name = s1.Name;
                    item.Contact = s1.Contact;
                    item.Email = s1.Email;
                    break;
                }

            }

            
        }

        public void Delete(int id)
        {
            foreach(Student item1 in list)
            {
                if (item1.Id == id)
                {
                    list.Remove(item1);
                    break;
                }

            }
        }


    }

    

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class FirstP
    {
        public static void Main(string[] args){
            M1();
          
        
            }
       static void M1()
        {
            int a = 10;
            Person p = new Person();
            p.SetAge(20);
            int aa= p.getAge();
            Console.WriteLine(aa);
        }
    }
    class Person
    {
        //fields, methods
        //cons, dest

        //Console.WriteLine("Hi From P");
        int personId;
        string personName;
        public string MobileNumber;
        int age;

        public int getAge()
        {
            return age;
        }
        public void SetAge(int a)
        {
            if(a >= 18 && a <= 60 )
            {
                age = a;
            }
            age = 1;
        }
    }
}

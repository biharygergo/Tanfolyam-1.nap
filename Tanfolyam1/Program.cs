using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanfolyam1;

namespace Tanfolyam1
{

    class Person
    {
        // TRÜKK propfull, propf +TABTAB

        //8 sor helyett csak két sort használ így
        public int Age { get; set; }
        public string Name { get; set; }


        

    }
    class Program
    {
        static void Main(string[] args)
        {
            //var i = 1;
            //var s = "Béla";

            //TRÜKK
            // var tomb = new { Name = "Aladár", Age = 5 };
            //Console.WriteLine(tomb.Age);
            // Console.WriteLine(tomb.GetType());
            //Console.ReadKey();

            //Person p = new Person();
            //p.Age = 12;
            //p.Name = "aladár";

            //TRÜKK
            //Person p2 = new Person() { Name = "Aladár", Age = 12 };


            //TRÜKK
            //List<Person> list = new List<Person>()
            //{

            //    new Person {Name="Youda", Age =563 },
            //    new Person {Name="Luke", Age =32 },
            //    new Person {Name="Obi-Wan", Age =56 }, //Lehet itt vesszőt használni :)
            //};

            //foreach (var person in PersonHelper.Filter(list, "a"))
            //{
            //    Console.WriteLine(person.Name);

            //    //TRÜKK így lehet beleírni egyből, rövidebb
            //    Console.WriteLine($"Person: {person.Name} ({person.Age})");
            //}

            Nullable<int> i;
            i = 5;
            Console.WriteLine(i);
         
        }
    }
}

using System;

namespace class_pg
{
    class Program
    {
        class People {
            public string FName { get; set; }
            public string LName { get; set; }
            public DateTime DOB { get; set; }

            public People(string fn, string ln, DateTime dob) {

                FName = fn;
                LName = ln;
                DOB = dob;
            }

            public string SayHello(){
                return $"Hi my name is {FName} {LName} and I am {CalcAge()} years old ";

            }
            private int CalcAge(){

                var age = DateTime.Now.Year - DOB.Year;

                if(DateTime.Now.DayOfYear < DOB.DayOfYear){
                    age -= 1;
                }
                return age;

                
            }
        }
        static void Main(string[] args)
        {

            var bob = new People("John", "Doe", new DateTime(1982, 10, 23 ));
            Console.WriteLine(bob.SayHello());

            var person = new People("Jane", "Doe", new DateTime(1999, 2, 23 ));

            Console.WriteLine(person.SayHello());


        }
    }
}

using System;

namespace Variables
{
    public class Variables
    {
            static void Main(string[] args)
        {
           /*Firstly, What are Variables?
           A: Variables represent storage locations. 
           Every variable has a type that determines what values can be stored
           in the variable. Source: Microsoft

           We use a variable to wil determine information for our program. 
           We will use it in every work that we need to work. 
           But each Variable are diferent from each other. 

           A litle Brief:
           Int - Whole Numbers 
           Bool - True or False
           Double - Floating Point (2.3, 4.5, etc)

           More at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables
            */
           
                    
            int x = 540; 
            /* you can write like this 
            int = x; (What is int?)
            x = 540; (What is x?)
            It will do the same thing. */
            int y = 100;
            int z = x + y;
            Console.WriteLine(z);
            //or
            Console.WriteLine("X is "+ x);
            Console.WriteLine("y is "+ y);

            string name = "Rebeca"; 
            int age = 25; 
            double height = 1.65; 
            bool Pa = true; 
           

            Console.WriteLine("My name is" + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height " + height + "cm");
            Console.WriteLine("Needs Physical activity? " + Pa);
            

            Console.ReadKey();
        }
    }
}
    

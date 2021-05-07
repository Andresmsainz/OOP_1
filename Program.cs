using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Object Oriented Programming... I'm Not Scared of You!");

            bool bMethods3 = true;

            if (bMethods3 == true) fnMethods3();

        }

        static void fnMethods3()
        {
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Watson";

            Console.WriteLine($"Inside Methods 3 Method before changes\n--------\nFirst Employee = {firstEmployee}\nSecond Employee = {secondEmployee}\n\n");

            ChangeNames(firstEmployee, secondEmployee);

            Console.WriteLine($"Inside Methods 3 Method after copy values \n--------\nFirst Employee = {firstEmployee}\nSecond Employee = {secondEmployee}\n\n");

            ChangeNames_Ref(ref firstEmployee, ref secondEmployee);
            Console.WriteLine($"Inside Methods 3 Method after ref \n--------\nFirst Employee = {firstEmployee}\nSecond Employee = {secondEmployee}\n\n");

            

            ChangeNames_Out(out string firstEmployee_out, out string secondEmployee_out);
            Console.WriteLine($"Inside Methods 3 Method after out \n--------\nFirst Employee = {firstEmployee_out}\nSecond Employee = {secondEmployee_out}\n\n");


        }

        static void ChangeNames(string firstEmp, string secondEmp)
        {
            //passing by value
            firstEmp = "Olivia Newton John";
            secondEmp = "John Travolta";

            Console.WriteLine($"Inside Change Names Method\n--------\nFirst Employee = {firstEmp}\nSecond Employee = {secondEmp}\n\n");

        }

        static void ChangeNames_Ref(ref string firstEmp, ref string secondEmp)
        {
            //passing by value
            firstEmp = "Olivia Newton John";
            secondEmp = "John Travolta";

            Console.WriteLine($"Inside Change Names Ref Method\n--------\nFirst Employee = {firstEmp}\nSecond Employee = {secondEmp}\n\n");

        }

        static void ChangeNames_Out(out string firstEmp, out string secondEmp)
        {
            //passing by value
            firstEmp = "Elton John";
            secondEmp = "Freddy Mercury";

            Console.WriteLine($"Inside Change Names Out Method\n--------\nFirst Employee = {firstEmp}\nSecond Employee = {secondEmp}\n\n");

        }
    }
}

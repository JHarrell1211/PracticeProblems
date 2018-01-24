using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string firstName;
            string middleName;
            string lastName;

            firstName = "Julian";
            middleName = "Lamont";
            lastName = "Harrell";

            string car;

            car = "72 Chavelle";

            string comicBookCharacter;

            comicBookCharacter = "Wolverine";

            Console.WriteLine("My full name is " + firstName + " " + middleName + " " + lastName);
            Console.WriteLine("My favorite car is a " + car);
            Console.WriteLine("My favorite comic book character is " + comicBookCharacter);

            firstName = "John";
            Console.WriteLine(firstName);*/

            //HOMEWORK 2
            /*
            - Lisa is cooking muffins. The recipe calls for 7 cups of sugar. She has already put in 2 cups. How
            many more cups does she need to put in
            - At a restaurant, Mike and his three friends decided to divide the bill evenly.If each person paid 
            $13 then what was the total bill?
            - How many packages of diapers can you buy with $40 if one package costs $8?
            -Last Friday Trevon had $29.Over the weekend he received some money for cleaning the attic.
            He now has $41.How much money did he receive ?
            - Last week Julia ran 30 miles more than Pranav.Julia ran 47 miles.How many miles did Pranav run ?
            - How many boxes of envelopes can you buy with $12 if one box costs $3 ?
            - After paying $5.12 for a salad, Norachai has $27.10.How much money did he have before buying the salad ?*/

            //double x = 7;
            //double y = 2;
            //Console.WriteLine("How many more cups does she need to put in? " + (x - y) + " cups");

            //x = 4;
            //y = 13;
            //Console.WriteLine("What was the total bill? " + (x * y) + " dollars");

            //x = 8;
            //y = 40;
            //Console.WriteLine("How many packages of diapers can you buy with 40 dollars? " + (y / x) + " packs");

            //x = 47;
            //Console.WriteLine("How many miles did Pranav run? " + (x + 30) + " miles");

            //x = 12;
            //y = 3;
            //Console.WriteLine("How many boxes of envelopes can you buy with 12 dollars? " + (x / y) + " boxes");

            //x = 27.10;
            //y = 5.12;
            //Console.WriteLine("How much money did Norachai have before buying the salad? " + (x + y) + " dollars");

            //Homework 1/18/18
            //double valueOne = 7;
            //double valueTwo = 2;
            //string name;

            //Console.WriteLine("What name are we using? ");
            //name = Console.ReadLine();
            //Console.WriteLine(name.ToUpper() + " needs " + (valueOne - valueTwo) + " more cups of sugar. \n");


            //valueOne = 13;
            //valueTwo = 4;

            //double total = (valueOne * valueTwo);
            //Console.WriteLine("What are Mike's three friends' names? ");
            //name = Console.ReadLine();
            //Console.WriteLine("The total bill for Mike, {0} is {1} dollars.\n", name, total );

            //valueOne = 40;
            //valueTwo = 8;
            //total = valueOne / valueTwo;

            //Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine(name + " can buy " + total + " packages of diapers.");


            /*valueOne = 41;
            valueTwo = 29;
            Console.WriteLine(valueOne - valueTwo);
            valueOne = 47;
            valueTwo = 30;
            Console.WriteLine(valueOne - valueTwo);
            valueOne = 12;
            valueTwo = 3;
            Console.WriteLine(valueOne / valueTwo);
            valueOne = 27.10;
            valueTwo = 5.12;
            Console.WriteLine(valueOne + valueTwo);*/

            //Homework 1/23/18    Loops

            int[] numbers = new int[25];
            string pick = "";

            int i = 0;

            for (i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                //Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Display even or odd numbers?" );
            pick = Console.ReadLine().ToLower();

            if (pick == "odd")
            {

                for (i = 0; i <= numbers.Length; i = i + 2)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else if (pick == "even")
            {
                for (i = 1; i < numbers.Length; i = i + 2)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string phrase = "Jared\nMartin";
            string anotherPhrase = "jared\"martin";
            char grade = 'A';
            int age = 35;
            double gpa = 4.0;
            bool isMale = true;
            string yetAnotherPhrase = phrase + "\nis cool\n" + anotherPhrase;*/
            /*Learning C# concatination, variables, working with strings*/

            /*Console.WriteLine(phrase);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(grade);
            Console.WriteLine(isMale);
            Console.WriteLine(anotherPhrase);
            Console.WriteLine(yetAnotherPhrase);*/

            /*string myPhrase = "Jared Martin";
            Console.WriteLine(myPhrase.ToUpper());
            Console.WriteLine(myPhrase.ToLower());
            Console.WriteLine(myPhrase.Contains("Jared"));
            Console.WriteLine(myPhrase[0]);
            Console.WriteLine(myPhrase[1]);
            Console.WriteLine(myPhrase[2]);
            Console.WriteLine(myPhrase[3]);
            Console.WriteLine(myPhrase[4]);
            Console.WriteLine(myPhrase.IndexOf("d"));
            Console.WriteLine(myPhrase.Substring(6, 4));*/
            /*testing dot notation properties for strings*/

            /*int firstNum = 1;
            int secondNum = 2;
            int thirdNum = 3;
            int fourthNum = 37;
            int fifthNum = 64;
            firstNum++;
            firstNum--;*/


            /*Console.WriteLine(0351);
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);
            Console.WriteLine(firstNum + "\n" + secondNum + "\n" + thirdNum);
            Console.WriteLine(secondNum * thirdNum);
            Console.WriteLine(6 / 2);
            Console.WriteLine(25 % 78);
            Console.WriteLine(6 + 10 * 2);
            Console.WriteLine((6 + 10) * 2);
            Console.WriteLine(10.2 + 3.5);
            Console.WriteLine(fifthNum % fourthNum);
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(1, 2));
            Console.WriteLine(Math.Min(3, 10));*/
            /*learning numbers in C#*/



            /*Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("What is your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " You are " + age);
            Console.WriteLine("Hello");*/
            /*learning user input*/

            /*string num1 = "0351";
            int stringToNum = Convert.ToInt32(num1);
            Console.WriteLine(stringToNum.GetType());
            Console.WriteLine(stringToNum);
            Console.WriteLine(stringToNum + 1);

            Console.Write("Enter a number: ");
            int numInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int numInput2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a decimal number: ");
            double numInput10 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another decimal number: ");
            double numInput20 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(numInput1 + numInput2);
            Console.WriteLine(numInput10 + numInput20);*/
            /*converting string to int*/


            /*string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter the name of a celebrity: ");
            celebrity = Console.ReadLine();
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are Blue");
            Console.WriteLine("I Love " + celebrity);*/
            /*building a mad libs game*/


            /*int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine( luckyNumbers[7]);
            luckyNumbers[0] = 100;
            Console.WriteLine( luckyNumbers[0]);
            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Dwight";
            friends[2] = "Michael";
            friends[3] = "Pam";
            Console.WriteLine(friends[3]);
            foreach (string friend in friends)
            { Console.WriteLine(friend); }*/
            /*Array's in C#*/

            /*bool isMale = false;
            bool isTall = true;


            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");

            } else if ( !isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");

            } else { 
                Console.WriteLine("You are not a tall male");
            }/*
            if statements in c#
            

            /*int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            *//*calling methods in C#
            parameters in C#*//*
            SayHello("Jared", 35);

            Console.ReadLine();*/
            /*methods in C# outside of static void main*/

            //Console.WriteLine(GetMax(20, 30, 40));

            //a better calculator
            /*Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }*/


            Console.WriteLine(GetDay(0));




            Console.ReadLine();
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
        /*returning info from methods*/
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } 
            else if (num2 >= num1 && num2 >= num3 )
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
            }

            return dayName;
        }
    }
}

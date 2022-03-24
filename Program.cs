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
            //methods in C# outside of static void main

            /*Console.WriteLine(GetMax(20, 30, 40));*/

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


            //Console.WriteLine(GetDay(5));

            /*&int index = 1;
            do
            {
                Console.WriteLine("this is a while loop");
                index ++;
            } while (index <= 5);*/

            /*int index = 1;
            while (index <= 5)
            {
                Console.WriteLine("this is a while loop");
                index ++;
            }*/

            /*string secretWord = "Martin";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount ++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You are out of guesses");
            }
            else
            {
                Console.WriteLine("You guessed the word");
            }*/


            //for loops

            /*int i =1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }*/
            //same loop, smaller structure v

            /*for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine(x);
            }*/
            /*int[] numbersArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int x = 0; x < numbersArray.Length; x++)
            {
                Console.WriteLine(numbersArray[x]);
            }*/

            //exponent function

            /*Console.WriteLine(GetPow(9, 3));*/

            //2 dimentional arrays in c#

            /*int [,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[2, 0]);*/

            //comments
            // this is a comment
            //block comments
            /*this is a block comment
             it comments blocks of code*/

            //exception handling in c#
            //user enters a string instead of an integer



            /*try
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally WriteLine");
            }*/

            //classes and objects

            /*Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("The Hobbit", "Tolkein", 475);
            

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);    
            Console.WriteLine(book2.pages); 


            Phone phone1 = new Phone
            {
                model = "iphone 13 pro",
                carrier = "Verizon",
                number = 6414361917,
            };

            Computer pc1 = new Computer
            {
                motherboard = "ROG",
                videocard = "MSI",
                cpu = "AMD",
                keyboard = "Corsair",
                mouse = "Corsair",
                monitor = "MSI",
            };*/

            /*Student student1 = new Student("Jared", "C#", 4.0);
            Student student2 = new Student("Cassandra", "Python", 3.8);
            Student student3 = new Student("Alex", "Django", 2.3);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student3.HasHonors());*/

            //external classes and methods, calling in main


            /*Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "Wrong Rating");

            //getters and setters
            
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);*/

            /*Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());*/

            //static attributes on classes


            //static methods and classes
            // creating static methods and classes

            //UsefullTools.SayHi("Jared");


            Chef chef = new Chef();
            chef.MakeChicken();


            //inheritance, super classes and subclasses

            
            Console.ReadLine(); 
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result =1;
            
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }


            return result;
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
                    break;
            }

            return dayName;
        }
    }
}

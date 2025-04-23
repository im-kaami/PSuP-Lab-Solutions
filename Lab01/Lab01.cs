using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PSuP_Lab_Practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 4

            //Console.WriteLine("Enter your year of birth: ");
            //int userYearOfBirth = int.Parse(Console.ReadLine());
            //DateTime currentDate = DateTime.Now;
            //int age = currentDate.Year - userYearOfBirth;
            //int ageNextYear = age + 1;

            //Console.WriteLine("Your age is: {0} and you'll be {1} years old next year", age,ageNextYear);

            #endregion
            #region Task 5

            //Console.WriteLine("Choose the unit for your body mass. \n1. g \n2. kg");

            //int userMassChoice = int.Parse(Console.ReadLine());
            //Console.Write("Please enter your mass:");
            //double userMass = double.Parse(Console.ReadLine());
            //if (userMassChoice == 1)
            //{ userMass = userMass / 1000; }

            //Console.Write("Please choose the unit inn which you want to provide the height: \n1. cm \n2. m \n3. ft \n4. in \n");

            //int userChoice = int.Parse(Console.ReadLine());
            //double userHeight = 0;

            //if (userChoice == 1)
            //{
            //    Console.Write("Please enter your height in cm: ");
            //    userHeight = double.Parse(Console.ReadLine());
            //    userHeight = userHeight / 100;


            //}
            //else if (userChoice == 2)
            //{
            //    Console.Write("Please enter your height in m: ");
            //    userHeight = double.Parse(Console.ReadLine());

            //}
            //else if (userChoice == 3)
            //{
            //    Console.WriteLine("Please enter your height in ft: ");
            //    userHeight = double.Parse(Console.ReadLine());
            //    userHeight = userHeight / 3.28084;
            //}
            //else if (userChoice == 4)
            //{
            //    Console.WriteLine("Please enter your height in in: ");
            //    userHeight = double.Parse(Console.ReadLine());
            //    userHeight = userHeight * 0.0254;

            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice. Please choose a valid unit.");
            //}
            //double userBMI = userMass / Math.Pow(userHeight, 2);
            //Console.WriteLine("Your Body Mass Index BMI is: {0}", userBMI.ToString("0.00"));


            #endregion
            #region Task 6

            //Console.Write("Enter time in seconds: ");
            //int timeInSec;
            //if (int.TryParse(Console.ReadLine(), out timeInSec))
            //{
            //    TimeSpan time = TimeSpan.FromSeconds(timeInSec);
            //    //  :D2 is used to format the seconds with leading zero if needed
            //    Console.WriteLine("Time in min:sec format {0}:{1:D2}", time.Minutes, time.Seconds);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}


            #endregion
            #region Task 7

            //Console.Write("Enter your password:");
            //string password = Console.ReadLine();
            //Console.Write("Reenter your password:");
            //if (password != Console.ReadLine()) 
            //{
            //    Console.WriteLine("Password does not match");
            //}
            //else
            //{
            //    Console.WriteLine("Password is correct.");
            //}

            #endregion
            #region Task 8

            //Console.Write("Enter your password: ");
            //string password = "";
            //string rePassword = "";
            //ConsoleKeyInfo keyInfo;

            //do
            //{
            //    keyInfo = Console.ReadKey(true);  // true prevents the character from being shown

            //    if (keyInfo.Key == ConsoleKey.Backspace)
            //    {
            //        if (password.Length > 0)
            //        {
            //            password = password.Remove(password.Length - 1);  // Remove the last character
            //            Console.Write("\b \b");  // Erase the last * and move the cursor back
            //        }
            //    }
            //    else if (keyInfo.Key != ConsoleKey.Enter)  // Handle all keys except Enter
            //    {
            //        password += keyInfo.KeyChar;  // Add the typed character to the password
            //        Console.Write("*");  // Display * instead of the character
            //    }

            //} while (keyInfo.Key != ConsoleKey.Enter);  // Continue until Enter is pressed

            //Console.Write("\nReenter your password: ");
            //do
            //{
            //    keyInfo = Console.ReadKey(true);  // true prevents the character from being shown

            //    if (keyInfo.Key == ConsoleKey.Backspace)
            //    {
            //        if (rePassword.Length > 0)
            //        {
            //            rePassword = rePassword.Remove(rePassword.Length - 1);  // Remove the last character
            //            Console.Write("\b \b");  // Erase the last * and move the cursor back
            //        }
            //    }
            //    else if (keyInfo.Key != ConsoleKey.Enter)  // Handle all keys except Enter
            //    {
            //        rePassword += keyInfo.KeyChar;  // Add the typed character to the password
            //        Console.Write("*");  // Display * instead of the character
            //    }

            //} while (keyInfo.Key != ConsoleKey.Enter); // Continue until Enter is pressed

            //if (password == rePassword)
            //{
            //    Console.WriteLine("\nYour password is correct");

            //}
            //else
            //{
            //    Console.WriteLine("\nYour password is incorrect");
            //}

            #endregion
            #region Task 9

            //Console.Write("Enter first number: ");
            //int firstNum = int.Parse(Console.ReadLine());
            //Console.Write("Enter sec num: ");
            //int secNum = int.Parse(Console.ReadLine());
            //Console.Write("Enter your operator, the valid operators are (/,%,+,-,*): ");
            //char operation = Console.ReadKey(true).KeyChar;
            //bool isValidOperation = true;
            //int result = 0;

            //switch(operation)
            //{
            //    case '+':
            //       result =firstNum+secNum;
            //        break;
            //    case '-':
            //        result = firstNum-secNum;
            //        break;
            //    case '*':
            //        result = firstNum*secNum;
            //        break;

            //    case '/':

            //        if (secNum == 0)
            //        {
            //            Console.WriteLine("Division by zero is not allowed");
            //            isValidOperation = false;
            //        }
            //        else
            //        {
            //            result = firstNum / secNum;

            //        }
            //        break;

            //    case '%':
            //        result = firstNum%secNum;
            //        break;

            //    default:
            //        Console.WriteLine("This is not a valid operation");
            //        isValidOperation = false;
            //        break;

            //} 
            //if (isValidOperation)
            //{ Console.WriteLine("The result of the operation {0} is: {1}", operation, result); }


            #endregion
            #region Task 10

            //double firstNum;  //Solution needs further investigations how to deal with error if user does not puta after each part
            //double secNum;
            //char operation;
            //double result = 0;
            //bool isValidOperation = true;
            //Console.WriteLine("Please enter your expression i.e. 18 / 4: ");
            //String[] input = Console.ReadLine().Split(' '); // Array method 
            //firstNum = double.Parse(input[0]);
            //secNum = double.Parse(input[2]);
            //operation = char.Parse(input[1]);

            //switch (operation)

            //{
            //    case '+':
            //        result = firstNum + secNum;
            //        break;
            //    case '-':
            //        result = firstNum - secNum;
            //        break;
            //    case '*':
            //        result = firstNum * secNum;
            //        break;
            //    case '/':
            //        if (secNum == 0)
            //        {
            //            Console.WriteLine("Division by zero is not allowed");
            //            isValidOperation = false;
            //        }
            //        else
            //        {
            //            result = firstNum / secNum;
            //        }
            //        break;
            //    case '%':
            //        result = firstNum % secNum;
            //        break;
            //    default:
            //        Console.WriteLine("This is not a valid operation");
            //        isValidOperation = false;
            //        break;
            //}
            //if (isValidOperation)

            //{
            //    Console.WriteLine("The result of the operation {0} is: {1}", operation, result);
            //}

            #endregion
            #region Task 11

            //string numInText = "";
            //Console.Write("Enter number between 0-9: ");
            //string num = Console.ReadLine();

            //switch (num)
            //{
            //    case "0":
            //        numInText = "Zero";
            //        break;
            //    case "1":
            //        numInText = "One";
            //        break;
            //    case "2":
            //        numInText = "Two";
            //        break;
            //    case "3":
            //        numInText = "Three";
            //        break;
            //    case "4":
            //        numInText = "Four";
            //        break;
            //    case "5":
            //        numInText = "Five";
            //        break;
            //    case "6":
            //        numInText = "Six";
            //        break;
            //    case "7":
            //        numInText = "Seven";
            //        break;
            //    case "8":
            //        numInText = "Eight";
            //        break;
            //    case "9":
            //        numInText = "Nine";
            //        break;
            //    default:
            //        numInText = "Invalid Input";
            //        break;

            //}

            //Console.WriteLine("Your number in text is: {0}", numInText);

            #endregion
            #region 12

            //string alphabet;
            //List<string> list = new List<string> { "a", "e", "i", "o", "u" };
            //Console.Write("Enter an English alphabet: ");
            //string input = Console.ReadLine().ToLower();
            //alphabet = input.ToLower();
            //if (list.Contains(alphabet))
            //{
            //    Console.WriteLine("This English alphabet {0} is vowel.", input);
            //}
            //else { Console.WriteLine("This is a consonant English Alphabet. "); }


            #endregion
        }
    }
}

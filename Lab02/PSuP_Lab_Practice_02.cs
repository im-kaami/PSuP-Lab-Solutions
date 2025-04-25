using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PSuP_Lab_Practice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Random rnd = new Random();
            //Console.Write("Enter a postive integer N: ");
            //int pst = int.Parse(Console.ReadLine());
            //for (int i = 1; i < pst; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Even Numbers:");
            //for (int i = 1; i < pst; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion
            #region Task 2

            //string userpassword = "kaami";
            //string userinput;
            //int count = 0;
            //do
            //{

            //    Console.WriteLine("Enter your password: ");
            //    userinput = Console.ReadLine();
            //    if (userinput == userpassword)
            //    {
            //        Console.WriteLine("Login successful ...");
            //        break;
            //    }
            //    else
            //    {
            //        count++;

            //        if (count <= 2)
            //        {
            //            Console.WriteLine("Login failed. Try again");                                           
            //        }
            //        else if (count == 3)
            //        {
            //            Console.WriteLine("You attempted 3 times wrong password, account will be blocked after 4 wrong attempts...");                     
            //        }
            //        else
            //        {
            //            Console.WriteLine("Account blocked. Please contact your administrator.");
            //            break;
            //        }
            //    }
            //} while (userinput != "kaami");



            #endregion
            #region Task 3

            //Random rnd = new Random();
            //int rndnum = rnd.Next(1, 1000);
            //Console.Write("enter an integer between 1-1000: ");
            //int num = int.Parse(Console.ReadLine());

            //while (num != rndnum)
            //{
            //    num++;
            //    Console.WriteLine("Try again....");
            //}
            //Console.WriteLine("congratulations! you guessed the number in {0} attempts.", num);

            #endregion
            #region Task 4
            //int players;
            //Console.Write("Enter the number of the players: ");
            //while (!int.TryParse(Console.ReadLine(), out players) || players < 2)
            //{
            //    Console.WriteLine("Please enter a valid number. Minimum players must be 2.");
            //}
            //Random rnd = new Random();
            //bool sixer = false;
            //int runs;
            //while(true)
            //{

            //    for (int i = 1; i <= players; i++)
            //    {
            //        runs = rnd.Next(0, 7);
            //        Console.WriteLine("Player {0} press enter to roll the dice.",i);
            //        Console.ReadLine(); //wait for user until they press enter
            //        if (runs == 6)
            //        {
            //            sixer = true;
            //            Console.WriteLine("Player {0} hit six. Congratulation! You'll start the game.", i);
            //            return; // Exit the program
            //        }
            //    }
            //    if (sixer==false)
            //    {
            //        Console.WriteLine("No player rolled six. Restarting the game...");   
            //    }
            //}

            #endregion
            #region Task 5
            //Random guess = new Random();
            //int guessNum = guess.Next();
            //int input;
            //int count = 0;
            //do
            //{
            //    Console.Write("Enter an integer number: ");
            //    input = int.Parse(Console.ReadLine());
            //    count++;
            //    if (input == guessNum)
            //    {
            //        Console.WriteLine("You guessed the secret number correctly in {0} attempts. ", count);

            //    }
            //    else if (input != guessNum && input < guessNum) { Console.WriteLine("Your guess is incorrect and less than the guessnumber"); }
            //    else if (input != guessNum && input > guessNum) { Console.WriteLine("Your guess is incorrect and greater than the guessnumber"); }
            //    else { Console.WriteLine("Please enter a valid number."); }
            //} while (input != guessNum);

            #endregion
            #region Task 6

            //Console.Write("Enter a positive integer: ");
            //int num;
            //List<int> divisors = new List<int>();
            //while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //}
            //if(num% 2 == 0)
            //{
            //    Console.WriteLine("{0} is an even number.", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is an odd number.", num);
            //}
            //Console.Write("Divisors of {0}: ", num);
            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    { Console.Write(i + ", ");
            //        divisors.Add(i);
            //    }
            //}
            //Console.WriteLine();
            //if (divisors.Count < 2)
            //{
            //    Console.WriteLine("{0} is a prime number.", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is a composite number.", num);
            //}

            #endregion
            #region Task 7

            //Console.Write("Enter an positive integer: ");
            //int n = int.Parse(Console.ReadLine());
            //int factorial=1;
            //for (int i = 1; i <= n; i++)
            //{
            //   factorial *= i;
            //}
            //Console.WriteLine(factorial);

            #endregion
            #region Task 8

            //// Need to understand the logic of the code
            //// Print the header row (1 to 9) 
            //Console.Write("   ");  // Starting space for formatting
            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.Write("{0,3}", i);  // Print the numbers 1 to 9 with a width of 3
            //}
            //Console.WriteLine();  // Move to the next line

            //// Print the table rows
            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.Write("{0,3}", i);  // Print the row number at the start

            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write("{0,3}", i * j);  // Print the multiplication result with a width of 3
            //    }

            //    Console.WriteLine();  // Move to the next line after each row

            //}

            #endregion
            #region Task 9

            //Console.Write("Enter time in Seconds: ");
            //string timeInSec = Console.ReadLine();
            //int duration;
            //if (int.TryParse(timeInSec, out duration) && duration > 0)
            //{
            //    while (duration >= 0)
            //    {
            //        Console.Clear();
            //        TimeSpan time = TimeSpan.FromSeconds(duration);
            //        Console.WriteLine("Time in min:sec format {0}:{1:D2}", time.Minutes, time.Seconds);
            //        duration--;
            //        Thread.Sleep(1000); // Sleep for 1 second

            //    }
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Time is up!");
            //    Console.Beep();
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            #endregion
            #region Task 10

            //uint value;
            //Console.Write("Enter a 32-bit unsigned integer (0 to 4294967295): ");
            //while (!uint.TryParse(Console.ReadLine(), out value))
            //{
            //    Console.Write("Invalid input. Please enter a valid 32-bit unsigned integer: ");
            //}

            //Console.Write("Binary (8-bit blocks): ");

            //// Print bit 31 down to bit 0
            //for (int i = 31; i >= 0; i--)
            //{
            //    // Extract the i-th bit
            //    uint bit = (value >> i) & 1;
            //    Console.Write(bit);

            //    // After printing each 8-bit block, insert a space
            //    if (i % 8 == 0 && i != 0)
            //        Console.Write(' ');
            //}

            //Console.WriteLine();

            #endregion
            #region Task 11

            //Random random = new Random();
            //int credits = 100; // Player starts with 100 credits
            //int bet = 1;       // Default bet is 1 credit
            //int maxBet = 10;   // Max allowed bet (optional limit)
            //ConsoleKeyInfo keyInfo;

            //while (credits > 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Credits: {0} | Bet: {1}", credits, bet);
            //    Console.WriteLine("Press Spacebar to spin, Up/Down arrows to adjust bet, or Esc to exit.");

            //    keyInfo = Console.ReadKey(true);  // Wait for key press

            //    if (keyInfo.Key == ConsoleKey.Escape)  // Exit game on Escape key press
            //    {
            //        Console.WriteLine("Thanks for playing! Final credits: {0}", credits);
            //        break;
            //    }

            //    // Adjust the bet using Up and Down arrow keys
            //    if (keyInfo.Key == ConsoleKey.UpArrow && bet < credits && bet < maxBet)
            //    {
            //        bet++;  // Increase bet
            //    }
            //    else if (keyInfo.Key == ConsoleKey.DownArrow && bet > 1)
            //    {
            //        bet--;  // Decrease bet
            //    }

            //    // Spin the slot machine on Spacebar press
            //    if (keyInfo.Key == ConsoleKey.Spacebar)
            //    {
            //        int digit1 = random.Next(1, 10);  // Random digit between 1 and 9
            //        int digit2 = random.Next(1, 10);
            //        int digit3 = random.Next(1, 10);

            //        Console.WriteLine("Spinning... You got: {0} {1} {2}", digit1, digit2, digit3);

            //        // Check if the player won
            //        if (digit1 == digit2 && digit2 == digit3)  // All three digits match
            //        {
            //            int winCredits = bet * 50;
            //            credits += winCredits;
            //            Console.WriteLine("Jackpot! All three match! You won {0} credits.", winCredits);
            //        }
            //        else if (digit1 == digit2 || digit2 == digit3 || digit1 == digit3)  // Two digits match
            //        {
            //            int winCredits = bet * 10;
            //            credits += winCredits;
            //            Console.WriteLine("You won! Two digits match! You won {0} credits.", winCredits);
            //        }
            //        else  // No match
            //        {
            //            credits -= bet;
            //            Console.WriteLine("No match. You lost {0} credits.", bet);
            //        }

            //        if (credits <= 0)
            //        {
            //            Console.WriteLine("You're out of credits. Game Over!");
            //            break;
            //        }

            //        Console.WriteLine("Press any key to continue...");
            //        Console.ReadKey(true);  // Wait for a key press before continuing
            //    }
            //}

            #endregion
        }
    }
}

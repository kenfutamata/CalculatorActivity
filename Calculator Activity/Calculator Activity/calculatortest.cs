using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Activity
{
    public class calculatortest
    {
 
        public static void Main(string[] args)
        {
          //calling the main part of the calculator
            calculatormain();
        }
        public static void calculatormain()
        {
            double num1;
            double num2;
            String opera;//operation
           
            //continous looping of data until user will input exit to exit the program.
            while(true)
            {
                
                //input functions to allow user to input any numerical number       
                Console.WriteLine("Enter num1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter num2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                //function call to call from the caluclator.cs
                calculator cal = new calculator(num1, num2);
                //the user will input which operator the user wants to compute both numbers
                Console.WriteLine("+ for addition \n - for subtraction \n * for multiplcation \n / for division \n and exit for exiting the program ");
                Console.WriteLine("Enter a opperation");
                opera = Console.ReadLine();
                switch (opera)
                {
                    case "+":
                        //addition function call and display
                        Console.WriteLine("Sum is :"+ cal.sum());
                       
                        break;
                    case "-":
                        //subtraction function call and display
                      Console.WriteLine("Sub is "+ cal.sub());
                       
                        break;
                    case "*":
                        //multiplcation function call and display
                        Console.WriteLine("Multi is "+cal.multi());
                        break;

                    case "/":
                        //division function call and display
                        Console.WriteLine("Divide is "+cal.divide());
                        break;
                        
                    case "exit": 
                        //the program will exit if the user inputs exit on the console
                            Environment.Exit(0); 
                          break; 
                }
                //user will be questioned if the user wants to continue the program or will exit the program by typing yes or no
                Console.WriteLine("Do you want to continue yes or no?");
                String choosesum = Console.ReadLine();

                if (choosesum.Equals("yes"))//if yes, the program will continue
                {
                    continue;
                }
                else if (choosesum.Equals("no"))//if no, the program will stop 
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumpstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            //This is a label
            Console.WriteLine("Enter The First Number");
            // Here User Eneter firt number
            int num1 = Convert.ToInt32(Console.ReadLine());
            //Here num1 store value enter by user first time
            Console.WriteLine("Enter the Second Number");
           // Here user Eneter Second number
            int num2 = Convert.ToInt32(Console.ReadLine());
            //it store under num2
            choice:
            Console.WriteLine("Enter A=Addition S=Subtraction M= multiplication D=Division");
            //here We providig an option.
            string choice = Console.ReadLine().ToUpper();
            //Returns a copy of this string converted to uppercase.
            int result = 0;
            // can not convert null to int becoz it is a non nullable value type; 
            switch (choice)
                //Swich case statement:-Switch case is faster because ,it not check all the condition 
                //it check only those condition which is meet within  the body(in the block)
                //or which satsify the condition
                              
            {
                case "A":
                    result = num1 + num2;
                    break;
                case "S":
                    result = num1 - num2;
                    break;
                case "M":
                    result = num1 * num2;
                    break;
                case "D":
                    break;
                default:
                    Console.WriteLine("Please Enter correct choice");
                    //If any of the expression passed to switch case does not match
                    //with case statement the control will go to default:statement.
                    break;
            }
            Console.WriteLine("Result is{0}"  + result);
            wantToContiue:
            //This is Label
            Console.WriteLine("Do you want  to Continue ? press Y to yes and N  to No.");
            string wantToContiue = Console.ReadLine().ToUpper();
            switch (wantToContiue)
            {
                case "Y":
                    goto start;
                //If any of the expression passed to switch case does not match with case statement the control will go to default: statement
                case "N":
                   break;
                default:
                    Console.WriteLine("Please enter correct choice..");
                    goto wantToContiue;
                    //Goto logic 
            }
            Console.ReadLine();

           
                    }
        
           
        }
    }


using System;

namespace Program_Check_If_Number_Is_Lower_Or_Higher_Than_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberChecker numberChecker = new NumberChecker();
            numberChecker.Reader();
            numberChecker.Cheker();
            numberChecker.Printer();
        }

        public class NumberChecker
        {
            public string newNumber; 
            string result;
            public void Reader()
            {
                int i;
                Console.Clear();
                Console.WriteLine("Program checkes if the entered number is lower or higher than 0.");
                Console.WriteLine("Enter any valid NUMBER and press Enter...");
                newNumber = Console.ReadLine();
                int.TryParse(newNumber, out i);
                while(i == null)
                {
                    Console.Clear();
                    Console.WriteLine("Program checkes if the entered number is lower or higher than 0.");
                    Console.WriteLine("Enter any valid NUMBER and press Enter...");
                    newNumber = Console.ReadLine();
                }
      
                
                    
                    
                
                

            }

            public void Cheker()
            {
                if (Convert.ToBoolean(Convert.ToInt32(newNumber) == 0) == true)
                {
                    result = "You entered 0";
                }
                else if (Convert.ToBoolean(Convert.ToInt32(newNumber) > 0) == true)
                {

                    result = "There number is higher than 0";
                } else
                {
                    result = "There number is lower than 0";
                }
            }

            public void Printer()
            {
                Console.Clear();
                Console.WriteLine("Program checkes if the entered string is empty or no.");
                Console.WriteLine($"The result is : {result}");
                Console.ReadLine();
            }
        }
    }
}

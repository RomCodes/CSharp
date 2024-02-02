using System.Dynamic;
using System.Numerics;

namespace OperatorExpressionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            x = 1;
            y = 2;
            z = 3000232;

            Console.WriteLine("Choose a variable x, y, z: ");
            string userChoice = Console.ReadLine();


            Console.WriteLine("Choose a multiplier: ");
            string  userMultiplier = Console.ReadLine();

            if(!BigInteger.TryParse(userMultiplier, out BigInteger  userMultiplierInt))
            {
                Console.WriteLine("Invalid multiplier chosen. Please choose an integer value for the multiplier!!!");
                return;
            }



            BigInteger result = 0;
            bool validChoice = true;


            switch(userChoice)
            {
                case "x": result = x * userMultiplierInt;
                    break;

                case "y":
                    result = y * userMultiplierInt; 
                    break;

                case "z":
                    result = z * userMultiplierInt;
                    break;

                default:
                    Console.WriteLine("Invalid Choice!!");
                    validChoice = false;
                    break;

            }

            if (validChoice)
            {

                Console.WriteLine($"Your chosen variable {userChoice} and multiplier {userMultiplierInt}");
            }   Console.WriteLine($"The answer is {result}");
    }
    }
}

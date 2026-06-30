namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //claculate the BMI and display the result
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("hello, " + name + "! You are " + age + " years old, weigh " + weight + " kg, and height " + height + " cm");

            double BMIResult = weight / (height * height);
            Console.WriteLine("Your BMI is: " + BMIResult);


            if (BMIResult < 18.5)
            {
                Console.WriteLine("underweight");
            }

            else if (BMIResult >= 18.5 && BMIResult < 25)
            {
                Console.WriteLine("Noraml");
            }

            else if (BMIResult >= 25 && BMIResult < 30)
            {
                Console.WriteLine("Overweight");
            }

            else
            {
                Console.WriteLine("dangerS");
            }
            ////////////////////////////////////////////////////

            //Arithmatic operations example:
            //Console.WriteLine("enter first number: ");
            //float firstNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number: ");
            //float secondNumber = float.Parse(Console.ReadLine());

            //float additionResult = firstNumber + secondNumber;
            //float subtractionResult = firstNumber - secondNumber;
            //float multiplicationResult = firstNumber * secondNumber;
            //float divisionResult = firstNumber / secondNumber;
            //float reminderResult = firstNumber % secondNumber;
            //bool comparisonResult = firstNumber == secondNumber;

            //Console.WriteLine("Addition result: " + additionResult);
            //Console.WriteLine("Subtraction result: " + subtractionResult);
            //Console.WriteLine("multiplication result: " + multiplicationResult);
            //Console.WriteLine("Division result: " + divisionResult);
            //Console.WriteLine("Reminder result: " + reminderResult);
            //Console.WriteLine("Comparison result: " + comparisonResult);
            /////////////////////////////////////////////////////////////////

            //Console.WriteLine("welcome to main menu:");
            //Console.WriteLine("1.Deposite");
            //Console.WriteLine("2.Withdraw");

            //Console.WriteLine("please choose an option: ");
            //int option = int.Parse(Console.ReadLine());

            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("deposited");
            //        break;


            //    case 2:
            //        Console.WriteLine("withdrawed");
            //        break;

            //    default:
            //        Console.WriteLine("please choose a correct option");
            //        break;
            //}
            /////////////////////////////////////////////////////////////
        }
    }
}

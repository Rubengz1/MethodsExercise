namespace MethodsExercise
{
    public class Program
    {
        // create story - 4 items for story: Name, color, animal, city
        public static void StoryTime()
        {
            Console.WriteLine("Hey, whats your name?");
            string nombre = Console.ReadLine();
            Console.WriteLine($"{nombre}, whats your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"So {nombre}, your favorite color is {color}. What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("And what city do you live in?");
            string cuidad = Console.ReadLine();
            Console.WriteLine(
                $"Makes sense...People from {cuidad} who are named {nombre}, look just like a {animal}! What was your favorite color again? {color}..lame..");
        }

        // Math Methods - prt 2
        public static int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public static int Sub(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        public static int Mult(int Num1, int Num2)
        {
            return Num1 * Num2;
        }

        public static int Div(int Num1, int Num2)
        {
            return Num1 / Num2;
        }

        static void Main(string[] args)
        {
            StoryTime();
            Console.WriteLine(Add(3, 3));
            Console.WriteLine(Sub(3, 3));
            Console.WriteLine(Mult(3, 3));
            Console.WriteLine(Div(3, 3));
        }
    }
}
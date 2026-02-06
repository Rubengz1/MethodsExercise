namespace MethodsExercise
{
    public class Program
    {
        // 4 items for story: Name, color, animal, city

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

        static void Main(string[] args)
        {
            StoryTime();
        }
    }
    }


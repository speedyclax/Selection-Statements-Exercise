namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {         

            
            var random = new Random();
            var number = random.Next(1,10);

            Console.WriteLine("Try to guess a number between 1 and 10.");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > number)
            {
                Console.WriteLine("Too high");
                
            }
            else if (userInput < number)
            {
                Console.WriteLine("Too low");
                
            }
            else { Console.WriteLine("That's correct!"); }
        }
    }
}

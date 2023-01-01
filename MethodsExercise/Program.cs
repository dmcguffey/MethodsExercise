namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's put together a story! Give me a name.");
            var Name = Console.ReadLine();
            Console.WriteLine("Excellent. Now give me a color. Any color will do!");
            var color = Console.ReadLine();
            Console.WriteLine("Great choice. Now what about your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine("Now for the place! Where would you like to be right now?");
            var place = Console.ReadLine();
            Console.WriteLine("Lastly, who was your childhood hero?");
            var hero = Console.ReadLine();
            Console.WriteLine("Let's start the Story!");
            Console.WriteLine($"All hope seemed lost for our hero, {Name}. His great enemy Elon Tusk towered over him laughing.");
            Console.WriteLine($"'You are beaten,' says Tusk. 'Even your {color} {animal} cowers in fear before me!'");
            Console.WriteLine($"All Hope seemed lost for {Name}.");
            Console.WriteLine($"The people of {place} were desperate for victory, so they played one last trump card.");
            Console.WriteLine($"Suddenly, an explosion rang out above {place}. {Name}'s {color} {animal} sprung up and jumped for joy!");
            Console.WriteLine($"For out of the smoke arouse a champion! 'Tis I,' shouted the voice, 'the great {hero}!'");
            Console.WriteLine($"Suddenly, a renewed vitality hit {Name}, and he sprang to action.");
            Console.WriteLine($"Tusk looked on in dismay as {Name} and {hero} banded together for the ultimate attack.");
            Console.WriteLine($"'Everyone in {place}, lend me your energy! In an instant, {Name} and {hero} unleased a spiri bomb like no other."); 
            Console.WriteLine($"'Curses! I wanted to write one more tweet!' And with that, he was defeated by the great heroes {Name} and {hero}");
            Console.WriteLine("The End!");

        }
    }
}

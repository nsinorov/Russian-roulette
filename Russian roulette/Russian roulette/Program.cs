namespace RussianRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int pulltriger = rnd.Next(1, 7); // Choose a random number from 1 to 6
            int chamber = rnd.Next(1, 7); 
            
            if (chamber == pulltriger)
            {
                Console.WriteLine("Bang! You are dead.");
            }
            else
            {
                Console.WriteLine("Click. You live, for now");
            }
        }
    }
}
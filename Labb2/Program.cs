namespace Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //◼︎◻︎
            Console.Write("Number: ");
            int num = Int32.Parse(Console.ReadLine());
            int max = num * num;
            int rutor = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (rutor % 2 == 1)
                    {
                        Console.Write("◻︎ ");
                    }
                    else
                    {
                        Console.Write("◼︎ ");
                    }
                    rutor++;
                }
                Console.WriteLine("");
            }
        }
    }
}

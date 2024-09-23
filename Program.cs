class Program
{
    static void Main()
    {
        System.Console.WriteLine("Skriv in 1,2 eller valfri siffra");
        int input = int.Parse(Console.ReadLine());
        bool running = true;
        while (running)
        if (input == 1)
        {
            System.Console.WriteLine("Du tryckte på 1");
            break;

        }
        else if (input == 2)
        {
            System.Console.WriteLine("Du tryckte på 2");
            break;
        }
        else if (input == 3)
            System.Console.WriteLine("Du tryckte på 3 och nu spammar vi 3");
        else 
        {
            running = false;
        }

    }
}

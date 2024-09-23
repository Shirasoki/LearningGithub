class Program
{
    static void Main()
    {
        System.Console.WriteLine("Skriv in 1,2, 3, 4 eller valfri siffra");
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
        {
            System.Console.WriteLine("Du tryckte på 3 och nu spammar vi 3");
        }
        else if (input == 4)
        {
            System.Console.WriteLine("Du tryckte på 4 och vi stoppar där tycker jag");
            break;
        }
        else if (input == 5)
        {
            System.Console.WriteLine("Du tryckte på 5 men det var inte så bra eller hur");
        }
        else if (input == 6)
        {
            System.Console.WriteLine("Jasså varför den siffran");
            break;
        }
        else 
        {
            running = false;
        }

    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartBreathingActivity();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.StartReflectingActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Have a great day....");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.ReadKey();
        }

    }
    static int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }

    static void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\rPausing for {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }
    }
    
}


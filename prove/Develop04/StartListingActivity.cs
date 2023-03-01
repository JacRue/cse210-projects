public class ListingActivity
{

    public void StartListingActivity()
    {
        Console.WriteLine("LISTING");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Please enter the duration of the activity (in seconds): ");
        int duration = int.Parse(Console.ReadLine());

        string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You have 10 seconds to start thinking about the prompt...");
        Countdown(10);

        Console.WriteLine("Start listing items!");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"{count + 1}. ");
            string item = Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");

        Console.WriteLine("Great job! You have completed the Listing Activity!");
        Console.WriteLine($"You listed {count} items in {duration} seconds.");
        Console.WriteLine("Take a moment to reflect on what you wrote.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
        }
    }
}
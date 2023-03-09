public class ReflectingActivity
{

    public void StartReflectingActivity()
    {
        Console.WriteLine("REFLECTION");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        int duration = GetDuration();
        Console.WriteLine($"Get ready to reflect for {duration} seconds...");
        Pause(3);
        string[] prompts = new string[] {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
        Random rand = new Random();
        while (duration > 0)
        {
            string prompt = prompts[rand.Next(prompts.Length)];
            Console.WriteLine(prompt);
            //PauseWithAnimation(3);
            ShowAnimation(3);
            List<string> questions = new List<string>() {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
            while (questions.Count > 0 && duration > 0)
            {
                string question = questions[rand.Next(questions.Count)];
                Console.WriteLine(question);
                ShowAnimation(3);
                questions.Remove(question);
                duration -= 6;
            }
        }
        Console.WriteLine("Good job! You have completed the reflection activity.");
        Console.WriteLine($"Duration: {GetDuration() - duration} seconds");
        Pause(3);
    }

    static int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        int.Parse(Console.ReadLine());
        return 10;
    }

    static void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\rPausing for {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }
    }

    static void ShowAnimation(int duration)
    {
        for (int i = 1; i <= duration; i++)
        {
            Console.Write("\b|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(500);
        }
    }
}
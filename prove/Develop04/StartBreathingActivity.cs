public class BreathingActivity
{

    public void StartBreathingActivity()
    {
        Console.WriteLine("BREATHING");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        int duration = GetDuration();
        Console.WriteLine($"Get ready to breathe for {duration} seconds...");
        Pause(3);
        for (int i = 0; i < duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }
        Console.WriteLine("Good job! You have completed the breathing activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        Pause(3);
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
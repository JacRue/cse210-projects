using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // create activites
            RunningActivity running = new RunningActivity(new DateTime(2023, 11, 3), 30, 3.0);
            CyclingActivity cycling = new CyclingActivity(new DateTime(2023, 11, 3), 30, 20.0);
            SwimmingActivity swimming = new SwimmingActivity(new DateTime(2023, 11, 3), 30, 30);


            // add activities to list
            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // display summary for each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }

            Console.ReadLine();
        }
    }
}
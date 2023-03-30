using System;

namespace ExerciseTracking
{
    public class RunningActivity : Activity
    {
        private double _distance;

        public RunningActivity(DateTime date, int length, double distance)
                : base(date, length)
            {
                _distance = distance;
            }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return _distance / (_length) / 60.0;
        }

        public override double GetPace()
        {
            return (_length / _distance) / 60.0;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {_distance:F1} miles, speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
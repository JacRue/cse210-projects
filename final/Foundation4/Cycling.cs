using System;

namespace ExerciseTracking
{
    public class CyclingActivity : Activity
    {
        private double _speed;

        public CyclingActivity(DateTime date, int length, double speed)
                : base(date, length)
            {
                _speed = speed;
            }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetDistance()
        {
            return _speed * (_length / 60.0);
        }

        public override double GetPace()
        {
            return 60.0 / (_speed * 0.621371);
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {GetDistance():F1} km, Speed: {_speed:F1} kph, Pace: {GetPace():F1} min per km";
        }
    }
}
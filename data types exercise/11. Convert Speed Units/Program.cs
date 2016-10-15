using System;


namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float sumSeconds = (hours * 3600) + (minutes * 60) + seconds; 
            float sumHours = (sumSeconds / 3600f);
            float metersPerSecond = (distanceInMeters / sumSeconds);
            float kilometersPerHour = ((distanceInMeters / 1000) / sumHours);
            float milesPerHour = ((distanceInMeters / 1609f) / sumHours);
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}

using System;


namespace _19.Thea_the_Photographer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int FT = int.Parse(Console.ReadLine());
            int FF = int.Parse(Console.ReadLine());
            int UT = int.Parse(Console.ReadLine());
            long filteredPhotos = (long)N * FT;
            long goodPhotos = (long)Math.Ceiling((double)N * FF / 100);
            long uploadTime = goodPhotos*UT;
            long totalTime = uploadTime + filteredPhotos;
            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",timeSpan.Days, timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds);

        }
    }
}

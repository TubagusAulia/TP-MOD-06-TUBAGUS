using System;

namespace tpmodul6_103022300141
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [TUBAGUS]");

                video.PrintVideoDetails();

                video.IncreasePlayCount(5000000);
                video.PrintVideoDetails();

                SayaTubeVideo invalidTitleVideo = new SayaTubeVideo(new string('a', 101)); 

                video.IncreasePlayCount(10000001); 

                for (int i = 0; i < 10; i++)
                {
                    video.IncreasePlayCount(2000000000);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
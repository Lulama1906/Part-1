using System;
using System.Media;

namespace Part_1
{
    public class Greeting
    {
        // Play a voice greeting at startup
        public void PlayVoiceGreeting()
        {


            string paths = AppDomain.CurrentDomain.BaseDirectory;
            try
            {
                using (SoundPlayer player = new SoundPlayer(paths.Replace(@"\bin\Debug\",@"\voice_greeting.wav")))
                {
                    player.Play();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voice greeting could not be played. Please check the file path.");
                Console.ResetColor();
            }
        }
    }
}
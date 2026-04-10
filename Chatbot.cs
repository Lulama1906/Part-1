using System;
using System.Threading;

namespace Part_1
    {
    class Chatbot
        {
       
        public Chatbot()
        {

            // Display ASCII art logo
            Greeting greet = new Greeting();
            greet.PlayVoiceGreeting();
                DisplayAsciiArt();

                // Greet the user and personalize interaction
                string userName = GreetUser();

                // Main menu loop
                bool isRunning = true;

                while (isRunning)
                {
                    // Display menu
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nWhat would you like to ask about?");
                    Console.WriteLine("1. How are you?");
                    Console.WriteLine("2. What’s your purpose?");
                    Console.WriteLine("3. What can I ask you about?");
                    Console.WriteLine("4. Learn about Phishing Emails");
                    Console.WriteLine("5. Learn about Password Safety");
                    Console.WriteLine("6. Learn about Recognizing Suspicious Links");
                    Console.WriteLine("7. Exit");
                    Console.ResetColor();

                    Console.Write("\nEnter your choice (1-7): ");
                    string userInput = Console.ReadLine();

                    // Handle input using IF-ELSE
                    if (userInput == "1")
                    {
                        Respond($"I’m just a chatbot, {userName}, but I’m functioning perfectly and here to help you!");
                    }
                    else if (userInput == "2")
                    {
                        Respond("My purpose is to guide you, support you and keep your experience smooth and secure.");
                    }
                    else if (userInput == "3")
                    {
                        Respond($"You can ask me about phishing emails, {userName}, creating strong passwords, or recognizing suspicious links.");
                    }
                    else if (userInput == "4")
                    {
                        DisplayPhishingInfo();
                    }
                    else if (userInput == "5")
                    {
                        DisplayPasswordInfo();
                    }
                    else if (userInput == "6")
                    {
                        DisplayLinkInfo();
                    }
                    else if (userInput == "7")
                    {
                        Respond($"Thank you for chatting with me, {userName}. Stay safe online, and have a great day!");
                        isRunning = false;
                    }
                    else
                    {
                        Respond("I didn’t quite understand that. Could you rephrase?");
                    }
                }
            }

            // Display ASCII art logo
            static void DisplayAsciiArt()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
   _____            _                       _   _             
  / ____|          | |                     | | (_)            
 | |     ___  _ __ | |_ ___  _ __ ___   ___| |_ _  ___  _ __  
 | |    / _ \| '_ \| __/ _ \| '_ ` _ \ / _ \ __| |/ _ \| '_ \ 
 | |___| (_) | | | | || (_) | | | | | |  __/ |_| | (_) | | | |
  \_____\___/|_| |_|\__\___/|_| |_| |_|\___|\__|_|\___/|_| |_|
");
                Console.ResetColor();
            }

            // Greet the user
            static string GreetUser()
            {
                Console.Write("\nWhat’s your name? ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    name = "User";
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nHello, {name}! Welcome to your chatbot assistant.");
                Console.WriteLine("I’m here to guide you, support you and keep your experience smooth and secure.");
                Console.ResetColor();

                return name;
            }

            // Typing effect response
            static void Respond(string message)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }

                Console.WriteLine();
                Console.ResetColor();
            }

            // Phishing info
            static void DisplayPhishingInfo()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nPhishing Emails:");
                Console.WriteLine("Phishing emails try to trick you into sharing sensitive information.");
                Console.WriteLine("Tips:");
                Console.WriteLine("- Verify the sender's email address carefully.");
                Console.WriteLine("- Avoid clicking on links or downloading attachments from unknown sources.");
                Console.WriteLine("- Look out for urgent or suspicious language in emails.");
                Console.ResetColor();
            }

            // Password info
            static void DisplayPasswordInfo()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPassword Safety:");
                Console.WriteLine("Strong passwords help protect your online accounts.");
                Console.WriteLine("Tips:");
                Console.WriteLine("- Use uppercase, lowercase, numbers, and symbols.");
                Console.WriteLine("- Avoid personal information.");
                Console.WriteLine("- Enable two-factor authentication.");
                Console.ResetColor();
            }

            // Link safety info
            static void DisplayLinkInfo()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nRecognizing Suspicious Links:");
                Console.WriteLine("Cybercriminals use deceptive links.");
                Console.WriteLine("Tips:");
                Console.WriteLine("- Hover over links before clicking.");
                Console.WriteLine("- Be cautious of shortened URLs.");
                Console.WriteLine("- Avoid links from unknown sources.");
                Console.ResetColor();
            }
        }
    }


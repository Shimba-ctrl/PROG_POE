using System;

class Program
{
    static void Main()
    {
        try
        {
            // the voice greeting 
            AudioPlayer.PlayGreeting();

            // show logo 
            UIHelper.ShowLogo();

            // ask for details from user 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter your name : ");
            Console.ResetColor();

            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "User";

            // first heading that will show
            Console.WriteLine($"\nHello {name}! 👋 Welcome to the Cybersecurity Awareness Bot! 🎉 Great to have you here.");
            Console.WriteLine("Type 'exit' anytime to quit.");

            // divider lines
            Console.WriteLine("======================================================");
            Console.WriteLine("💬 Start chatting below");
            Console.WriteLine("======================================================");

            // Chat Loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine();

                // checking if input is valid
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bot: Don’t be shy 😊 please enter something.");
                    Console.ResetColor();
                    continue;
                }

                // exit option for the user
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Bot: Stay safe online! Goodbye 👋");
                    break;
                }

                // generate response
                string response = Chatbot.GetResponse(input, name);

                // chatbot reply or reponse
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Bot: ");
                UIHelper.TypeText(response);
                Console.ResetColor();
            }
        }
        // error handling in case something goes wrong
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Oops, something went wrong! " + ex.Message);
            Console.ResetColor();
        }
    }
}
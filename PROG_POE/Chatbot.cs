using System;

// creating a class 
public class Chatbot
{
    public static string GetResponse(string input, string userName)
    // handles all the replies of the student/user
    {
        input = input.ToLower();
        // puts all words to lower case

        if (input.Contains("how are you"))
        {
            return $"I'm doing great, {userName}! Ready to help you stay safe online.";
            // $ - sign allows variables inside texts
        }
        else if (input.Contains("purpose") || input.Contains("what do you do"))
        // the || symbolises OR
        {
            return $"I'm your Cybersecurity Awareness Assistant, {userName}. I help you understand online threats and how to avoid them.";
        }
        else if (input.Contains("what can i ask"))
        // Gives the user options
        {
            return $"You can ask me anything about password, phishing scams, and safe browsing techniques, {userName}.";
        }
        else if (input.Contains("password"))
        {
            return $"Great question {userName}!\n- Use at least 12 characters\n- Include symbols & numbers\n- Avoid personal info";
        }
        else if (input.Contains("phishing"))
        {
            return $"OH! Be very careful {userName} 😟\nPhishing scams try to trick you into giving personal details.\n\n🚩 Warning signs:\n• Urgent messages\n• Fake email addresses\n• Suspicious links\n\nAlways verify before clicking!";
        }
        else if (input.Contains("safe browsing") || input.Contains("links"))
        {
            return $"Smart thinking {userName} 🌐\n- Only visit secure sites (https://)\n- Avoid unknown links\n- Look for the padlock icon";
        }
        else if (input.Contains("thank"))
        {
            return $"You are always welcome, {userName}! Remember to stay safe!";
        }
        else
        {
            // this runs if user input is not recognised
            return $"Hmm {userName}, I didn’t quite get that. Try asking about passwords, phishing, or browsing safety.";
        }
    }
}
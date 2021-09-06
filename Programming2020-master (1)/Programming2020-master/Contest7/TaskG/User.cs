using System;
using System.Collections.Generic;

public class User
{
    private List<string> messages;
    private string name;

    public User(string username)
    {
        name = username;
        messages = new List<string>();
    }

    public override string ToString()
    {
        string result = $"-{name}-\n";
        List<string> oldNotifications = messages.GetRange(0, messages.Count - 1);
        string messagesString = "";
        if (oldNotifications.Count > 0)
            messagesString = $"Received notifications:\n{String.Join("\n", oldNotifications)}\n";
        string newMsg = "";
        if (messages.Count > 0)
            newMsg = $"New notification: {messages[messages.Count - 1]}";
        return result + messagesString + newMsg;
    }

    public void SendMessage(string text)
    {
        messages.Add(text);
        Console.WriteLine(this);
    }

    public override bool Equals(object obj)
    {
        if (obj is User)
        {
            User user2 = (User)obj;
            return name.Equals(user2.name);
        }
        return false;
    }
}
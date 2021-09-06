using System;
using System.Collections.Generic;

public partial class TestSystem
{
    public List<User> users = new List<User>();

    User user ;
    public void Add(string username)
    {
        user = new User(username);
        if (!users.Contains(user))
        {
            users.Add(user);
            Notifications += user.SendMessage;
        }
        else
            throw new ArgumentException("User already exists");
    }

    public void Remove(string username)
    {
        user = new User(username);
        if (users.Contains(user))
        {
            users.Remove(user);
        }
        else
            throw new ArgumentException("User does not exist");
    }
}
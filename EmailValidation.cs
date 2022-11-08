using System;
using System.Text.RegularExpressions;
public class Email
{
    public static void Main()
    {
        Console.Write("Enter a Email : ");
        var Email = Console.ReadLine();

        string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

        
        if (Regex.IsMatch(Email, pattern))
        {
            
            Console.WriteLine(Email + " is a valid Email address.");
        }
        else
        {
            Console.WriteLine(Email + " is not a valid Email address.");
        }

    }
}
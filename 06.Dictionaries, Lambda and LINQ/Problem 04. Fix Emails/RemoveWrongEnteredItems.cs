using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveWrongEnteredItems
{
    public static void Main()
    {
        //Input
        var contactBook = new Dictionary<string, string>();

        while (true)
        {
            string contactName = Console.ReadLine();

            if (contactName.Equals("stop"))
            {
                break;
            }
            string contactMail = Console.ReadLine();
            if (!contactMail.Contains(".us") && !contactMail.Contains(".uk"))
            {
                contactBook[contactName] = contactMail;
            }
        }

        foreach (var contact in contactBook)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }
}

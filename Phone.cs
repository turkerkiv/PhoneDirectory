using System;

class Phone : IAdd, ISearch, IUpdate, IDelete
{
    Dictionary<string, string> phoneBook = new Dictionary<string, string>();

    public void AddNumber(string name, string number)
    {
        phoneBook.Add(name, number);
        Console.WriteLine("Added " + name + " with number " + number);
    }

    public void UpdateNumber(string nameToUpdate, string newNumber)
    {
        if (phoneBook.ContainsKey(nameToUpdate))
        {
            phoneBook[nameToUpdate] = newNumber;
            Console.WriteLine("Updated " + nameToUpdate + " with number " + newNumber);
        }
        else
        {
            Console.WriteLine("Could not find " + nameToUpdate);
        }
    }

    public void DeleteNumber(string nameToDelete)
    {
        if (phoneBook.ContainsKey(nameToDelete))
        {
            phoneBook.Remove(nameToDelete);
            Console.WriteLine("Deleted " + nameToDelete);
        }
        else
        {
            Console.WriteLine("Could not find " + nameToDelete);
        }
    }

    public void ListAllNumbers()
    {
        foreach (KeyValuePair<string, string> entry in phoneBook)
        {
            Console.WriteLine("Name: " + entry.Key + " Number: " + entry.Value);
        }
    }

    public string SearchNumber(string nameToSearch)
    {
        if (!phoneBook.ContainsKey(nameToSearch))
        {
            return "Could not find " + nameToSearch;
        }

        Console.WriteLine("Searching for " + nameToSearch);
        return " Number of " + nameToSearch + " is: " + phoneBook[nameToSearch];
    }

}
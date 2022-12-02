using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("\n|| Main Menu || \nPlease make your selection:\n[1] Add new contact\n[2] Lookup a contact");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
      Console.WriteLine("\nEnter new contact details below:");
      addContact();
    }
    else if (answer == "2")
    {
      LookUpContact();
    }
  }

  static void addContact()
  {
    Console.WriteLine("Contact First Name: ");
    string newName = Console.ReadLine();
    Console.WriteLine("Contact Phone Number: ");
    string newNumber = Console.ReadLine();

    phoneNumbers.Add(newName, newNumber);

    Console.WriteLine("\nAdd another contact to the dictionary? \nType 'Y' for yes and 'N' for no");
    string anotherContact = Console.ReadLine();
    if (anotherContact == "Y" || anotherContact == "y")
    {
      addContact();
    }
    else
    {
      Main();
    }
  }

  static void LookUpContact()
  {
    if (phoneNumbers.Count == 0)
    {
      Console.WriteLine("\n!!!ERROR!!! Dictionary is empty. \nPlease add a contact to the dictionary before continuing.");
      Console.WriteLine("*Redirecting to Main Menu*. . .");
      Main();
    }
    Console.WriteLine("\nPlease enter the contacts first name: ");
    string personInput = Console.ReadLine();
    string findPersonValue = phoneNumbers[personInput];

    Console.WriteLine(personInput + "\'s phone number is " + findPersonValue);

    Console.WriteLine("\nLookup another contact in the dictionary? \nType 'Y' for yes and 'N' for no");
    string anotherContact = Console.ReadLine();
    if (anotherContact == "Y" || anotherContact == "y")
    {
      LookUpContact();
    }
    else
    {
      Main();
    }
  }

}
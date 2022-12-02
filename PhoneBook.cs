using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();


  static void Main()
  {
    Console.WriteLine("\n|| Main Menu || \nPlease make your selection:\n[1] Add new contact\n[2] Lookup a contact new contact");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
      addContact();
    }
    else if (answer == "2")
    {
      Console.WriteLine("\nWould you like to lookup a contact in the dictionary? Type 'Y' for yes and 'N' for no");
      string lookUpAnswer = Console.ReadLine();
      if (lookUpAnswer == "Y" || lookUpAnswer == "y")
      {
        LookUpContact();
      }

    }



  }


  static void addContact()
  {
    
    Console.WriteLine("Please enter their name: ");
    string newName = Console.ReadLine();
    Console.WriteLine("Please enter their phone number: ");
    string newNumber = Console.ReadLine();

    phoneNumbers.Add(newName, newNumber);

    Console.WriteLine("\nWould you like to add another person to the dictionary? Type 'Y' for yes and 'N' for no");
    string anotherContact = Console.ReadLine();
    if(anotherContact == "Y" || anotherContact == "y"){
      addContact();
    }else{
    Main();
    }
  }

  static void LookUpContact()
  {
    if (phoneNumbers.Count == 0)
    {
      Console.WriteLine("\n!!!ERROR!!! Dictionary is empty Please add a contact to the dictionary before continuing.");
      Console.WriteLine("*Redirecting to Main Menu*. . .");
      Main();
    }
    Console.WriteLine("Who would you like to look up in the dictionary?");
    string personInput = Console.ReadLine();
    string findPersonValue = phoneNumbers[personInput];

    Console.WriteLine(personInput + "\'s phone number is " + findPersonValue);

    Main();
  }

}
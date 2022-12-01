using System;
using System.Collections.Generic;

class PhoneBook{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();


static void Main()
{
  Console.WriteLine("Would you like to enter a new contact to the dictionary? Type 'Y' for yes and 'N' for no");
  string answer = Console.ReadLine();
  if(answer == "Y" || answer == "y"){
    addContact();
  }

  Console.WriteLine("Would you like to lookup a contact in the dictionary?");
  string newAnswer = Console.ReadLine();
  if(newAnswer == "Y" || newAnswer == "y"){
    LookUpContact();
  }


}
static void addContact(){
  Console.WriteLine("Please enter their name: ");
  string newName = Console.ReadLine();
  Console.WriteLine("Please enter their phone number: ");
  string newNumber = Console.ReadLine();
  
  phoneNumbers.Add(newName, newNumber);
}

static void LookUpContact(){
  Console.WriteLine("Who would you like to look up in the dictionary?");
  string personInput = Console.ReadLine();
  string findPersonValue = phoneNumbers[personInput];

  Console.WriteLine(personInput + "\'s phone number is " + findPersonValue);
}

}
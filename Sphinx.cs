using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("Here is a riddle from the sphinx. Answer it correctly or u dead:");

    Dictionary<string, string> riddles = new Dictionary<string, string>() { {"Q1", "A1"}, {"Q2", "A2"} };

    Random randy = new Random();

    List<string> riddleList = new List<string>(riddles.Keys)[randy.Next(2)];


    // List<string> randomRiddles = new List<string>(riddleList[randy.Next(2)]);

    foreach(List<string> entry in riddleList)
    {
      Console.WriteLine(entry);
      string answer = Console.ReadLine();
      if ((entry == "Q1") && (answer == "A1")) 
      {
        Console.WriteLine("nice job. u did good");
      } else 
      {
        Console.WriteLine("you've been eaten");
        break;
      }
    }
  }

}

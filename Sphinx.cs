using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("Here is a riddle from the sphinx. Answer it correctly or u dead:");

    Dictionary<string, string> riddles = new Dictionary<string, string>() { {"Q1", "A1"}, {"Q2", "A2"}, {"Q3", "A3"} };

    Random randy = new Random();

    List<string> riddleList = new List<string>(riddles.Keys);

    foreach(var entry in riddleList)
    {
      string randomRiddle = riddleList[randy.Next(riddleList.Count)];
      Console.WriteLine(randomRiddle);
      string answer = Console.ReadLine();
      if ((randomRiddle == "Q1") && (answer == "A1")) 
      {
        Console.WriteLine("nice job. u did good");
      } else if ((randomRiddle == "Q2") && (answer == "A2"))
      {
        Console.WriteLine("nice job. u did good");
      }
      else if ((randomRiddle == "Q3") && (answer == "A3"))
      {
        Console.WriteLine("nice job. u pass");
      }
      else
      {
        Console.WriteLine("you've been eaten");
        break;
      }
    }
  }

}

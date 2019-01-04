using System;

namespace firstTry
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Which do you choose? Rock, Paper, or Scissors?");
      string userChoices = Console.ReadLine();
      Random random = new Random();
      int randomNumber = random.Next(0, 3);
      bool playing = true;
      while (playing)
      {
        if (randomNumber == 1)
        {
          if (userChoices == "rock")
            Console.WriteLine("The user chose rock");
          Console.WriteLine("It is a tie ");
        }
        else if (userChoices == "paper")
        {
          Console.WriteLine("The user chose paper");
          Console.WriteLine("It is a tie");
        }
        else if (userChoices == "scissors")
        {
          Console.WriteLine("The user chose scissors");
          Console.WriteLine("It is a tie");
        }
        else if (randomNumber == 2)
        {
          if (userChoices == "rock")
            Console.WriteLine("The user chose rock");
          Console.WriteLine("The User Wins!");
        }
        else if (userChoices == "paper")
        {
          Console.WriteLine("The user chose paper");
          Console.WriteLine("The User Wins!");
        }
        else if (userChoices == "scissors")
        {
          Console.WriteLine("The user chose scissors");
          Console.WriteLine("The User Wins!");
        }
        else if (randomNumber == 3)
        {
          if (userChoices == "rock")
            Console.WriteLine("The user chose rock");
          Console.WriteLine("The Computer Wins");
        }
        else if (userChoices == "paper")
        {
          Console.WriteLine("The user chose paper");
          Console.WriteLine("The Computer Wins");
        }
        else if (userChoices == "scissors")
        {
          Console.WriteLine("The user chose scissors");
          Console.WriteLine("The Computer Wins");
        }
        playing = false;
      }
      else 
    }
  }
}

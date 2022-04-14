using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"şu doğru mudur?" , "bu doğru mudur?" , "o doğru mudur?" , "bu da mı doğrudur?" , "şu da mı doğrudur?" , "o da mı doğrudur?" };
      bool[] answers = {true, false , true, false, true, false};

      RunQuiz(questions,answers);
      
    }


    static bool[] RunQuiz(string[] questions, bool[] answers)
    {
      bool[] responses = new bool[questions.Length];
      
      if(questions.Length != answers.Length)
      {
        Console.WriteLine("Soru ve cevapların sayısında hata var lütfen düzeltin");
      }

      int askingIndex = 0;
      
      foreach(string item in questions)
      {
        Console.WriteLine(item);
        string input = Console.ReadLine();
        bool inputBool;
        bool isBool = Boolean.TryParse(input, out inputBool);
        
        while(isBool == false)
        {
        Console.WriteLine("Please respond with 'true' or 'false'");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        }

        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      foreach(bool item in responses)
      {
        Console.WriteLine(item);
      }

      int scoringIndex = 0;
      int score = 0;
      
      for(int i = 0; i < responses.Length ; i++)
      {
        
        if(responses[i] == answers[i])
        {
          score++;
        }

        Console.WriteLine($"{i+1}. Input: {responses[i]} | Answer: {answers[i]}");
      }
        Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        return answers;
      }
    }
  }


using System;
using System.IO;

namespace TrueOrFalse
{
  public class Tools
  {
    public static void SetUpInputStream(string sample)
    {
			if (sample == null)
			{
				Console.SetIn(new StreamReader("true.txt"));
			}      
    }
  }
}

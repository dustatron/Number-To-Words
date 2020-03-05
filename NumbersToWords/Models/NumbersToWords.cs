using System;
using System.Collections.Generic;

namespace Words.Models
{
  //change name of class.
  public class Numeronym
  {
    enum Higher { Hundred, Thousand, Million, Billion, Trillion }
    private static Dictionary<string, string> Ones = new Dictionary<string, string>
    {
      {"1", "One"},
      {"2", "Two"},
      {"3", "Three"},
      {"4", "Four"},
      {"5", "Five"},
      {"6", "Six"},
      {"7", "Seven"},
      {"8", "Eight"},
      {"9", "Nine"},

    };

    private static Dictionary<string, string> Teens = new Dictionary<string, string>
    {
      {"0", "Ten"},
      {"1", "Eleven"},
      {"2", "Twelve"},
      {"3", "Thirteen"},
      {"4", "Fourteen"},
      {"5", "Fifteen"},
      {"6", "Sixteen"},
      {"7", "Seventeen"},
      {"8", "Eighteen"},
      {"9", "Nineteen"},
    };
    private static Dictionary<string, string> Deca = new Dictionary<string, string>
    {
      {"2", "Twenty"},
      {"3", "Thirty"},
      {"4", "Forty"},
      {"5", "Fifty"},
      {"6", "Sixty"},
      {"7", "Seventy"},
      {"8", "Eighty"},
      {"9", "Ninty"}
    };


    public static string MakeNumeronym(string input)
    {
      string result = "";
      if (input.Length % 3 == 2)
      {
        if (input.Length == 2)
        {
          result += GetTeens(input);
        }
      }
      else if (input.Length == 1)
      {
        result += GetOnes(input);
      }
      else
      {
        result = "error";
      }

      // else if ()
      // {

      // }

      return result;
    }

    //Change the name of the method.
    public static string GetOnes(string number)
    {
      string result = Ones[number];
      return result;
    }
    public static string GetTeens(string number)
    {
      char lastDigit = number[number.Length - 1];
      string result = Teens[lastDigit.ToString()];
      return result;
    }
    public static string GetDeca(string number)
    {
      char decaDigit = number[number.Length - 2];
      string result = Deca[decaDigit.ToString()];
      return result;
    }

  }

}
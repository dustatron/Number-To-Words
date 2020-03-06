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
      // int remaining = 0;

      for (int i = 0; i < input.Length; i++)
      {


        if (i == 1 && input[i - 1] == '1')
        {
          result += GetTeens(input[i]);
        }
        else if (i == 1 && input[i - 1] != '0')
        {
          result += GetDeca(input[i - 1]);
        }
        else if (i == 0 && input[i] != '0')
        {
          result += GetOnes(input[i]);
        }
        // else if (i == 2 && input[i] != '0')
        // {
        //   result += GetOnes(input);
        // }
        else
        {
          result = "error";
        }
      }





      // else if ()
      // {

      // }

      return result;
    }

    //Change the name of the method.
    public static string GetOnes(char number)
    {
      string result = Ones[number.ToString()];
      return result;
    }
    public static string GetTeens(char number)
    {
      char lastDigit = number;
      string result = Teens[lastDigit.ToString()];
      return result;
    }
    public static string GetDeca(char number)
    {
      char decaDigit = number;
      string result = Deca[decaDigit.ToString()];
      return result;
    }

  }

}
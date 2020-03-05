using System;
using System.Collections.Generic;

namespace Words.Models
{
  //change name of class.
  public class Numeronym
  {
    private static Dictionary<int, string> Ones = new Dictionary<int, string>
    {
      {1, "One"},
      {2, "Two"},
      {3, "Three"},
      {4, "Four"},
      {5, "Five"},
      {6, "Six"},
      {7, "Seven"},
      {8, "Eight"},
      {9, "Nine"},
      {10, "Ten"},
    };
    //Change the name of the method.
    public static string GetOnes(int number)
    {
      string result = Ones[number];
      return result;
    }
    public static string GetTeens(int number)
    {
      string result = "Wrong answer";
      return result;
    }
  }

}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Words.Models;
using System;

namespace Words.Tests
{
  //change name of test class.
  [TestClass]
  public class NumeronymTests
  {
    [TestMethod]
    public void GetOnes_returnsOnesAsWord_string()
    {
      Assert.AreEqual("One", Numeronym.GetOnes('1'));
    }
    [TestMethod]
    public void GetTeens_returnsTensAsWord_string()
    {
      Assert.AreEqual("Twelve", Numeronym.GetTeens('2'));
    }
    [TestMethod]
    public void GetDeca_returnsDecasAsWord_string()
    {
      Assert.AreEqual("Thirty", Numeronym.GetDeca("30"));
    }

    [TestMethod]
    public void LastTwo_ReturnStringEleven_String()
    {

      Assert.AreEqual("Eleven", Numeronym.LastTwo("11"));
    }
    [TestMethod]
    public void LastTwo_ReturnStringTwentyTwo_String()
    {

      Assert.AreEqual("Twenty Two", Numeronym.LastTwo("22"));
    }
    [TestMethod]
    public void LastTwo_ReturnStringThirtyThree_String()
    {

      Assert.AreEqual("Thirty Three", Numeronym.LastTwo("33"));
    }
    public void LastTwo_ReturnStringNintyNine_String()
    {

      Assert.AreEqual("Ninty Nine", Numeronym.LastTwo("99"));
    }

    [TestMethod]
    public void LastTwo_ReturnTwelve_String()
    {
      Assert.AreEqual("Twelve", Numeronym.LastTwo("12"));
    }

    [TestMethod]
    public void LastTwo_ReturnOne_String()
    {
      Assert.AreEqual("One", Numeronym.LastTwo("01"));
    }
    [TestMethod]
    public void MakeNumeronym_returnTeen_string()
    {
      Assert.AreEqual("Fourteen", Numeronym.MakeNumeronym("14"));
    }

    [TestMethod]
    public void MakeNumeronym_returnDeca_string()
    {
      string input = "41";
      Assert.AreEqual("Forty One", Numeronym.MakeNumeronym(input));
    }

    [TestMethod]
    public void MakeNumeronym_returnOneHundred_string()
    {
      string input = "100";
      Assert.AreEqual("One Hundred", Numeronym.MakeNumeronym(input));
    }
    [TestMethod]
    public void MakeNumeronym_returnTwoHundredTwelve_string()
    {
      string input = "212";
      Assert.AreEqual("Two HundredTwelve", Numeronym.MakeNumeronym(input));
    }
    [TestMethod]
    public void MakeNumeronym_returnTwoHundred_string()
    {
      string input = "200";
      Assert.AreEqual("Two Hundred", Numeronym.MakeNumeronym(input));
    }
    [TestMethod]
    public void MakeNumeronym_returnOneThousand_string()
    {
      string input = "1000";
      Assert.AreEqual("One Thousand", Numeronym.MakeNumeronym(input));
    }
    [TestMethod]
    public void MakeNumeronym_returnTenThousand_string()
    {
      string input = "10000";
      Assert.AreEqual("Ten Thousand", Numeronym.MakeNumeronym(input));
    }


  }
}
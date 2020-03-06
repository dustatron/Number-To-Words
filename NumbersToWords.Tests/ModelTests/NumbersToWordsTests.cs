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
      Assert.AreEqual("Thirty", Numeronym.GetDeca('3'));
    }

    [TestMethod]
    public void MakeNumeronym_returnTeen_string()
    {
      string input = "14";
      Assert.AreEqual("Fourteen", Numeronym.MakeNumeronym(input));
    }

    [TestMethod]
    public void MakeNumeronym_returnDeca_string()
    {
      string input = "41";
      Assert.AreEqual("FourtyOne", Numeronym.MakeNumeronym(input));
    }

    // [TestMethod]
    // public void MakeNumeronym_returnOnes_string()
    // {
    //   string input = "4";
    //   Assert.AreEqual("Four", Numeronym.MakeNumeronym(input));
    // }



  }
}
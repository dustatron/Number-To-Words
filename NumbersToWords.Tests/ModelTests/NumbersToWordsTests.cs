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
      Assert.AreEqual("One", Numeronym.GetOnes("1"));
    }
    [TestMethod]
    public void GetTeens_returnsTensAsWord_string()
    {
      Assert.AreEqual("Twelve", Numeronym.GetTeens("12"));
    }
    [TestMethod]
    public void GetDeca_returnsDecasAsWord_string()
    {
      Assert.AreEqual("Thirty", Numeronym.GetDeca("30"));
    }

    [TestMethod]
    public void MakeNumeronym_returnBigWord_string()
    {
      string input = "1000";
      Assert.AreEqual("One Thounsand", Numeronym.MakeNumeronym(input));
    }

  }
}
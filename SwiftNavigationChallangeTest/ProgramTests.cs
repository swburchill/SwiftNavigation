using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using SwiftNavigationChallange;

namespace SwiftNavigationChallangeTest
{
   [TestClass]
   public class ProgramTests
   {
      [TestMethod]
      public void chooseStringForNumberDivisibleBy3()
      {
         //arrange
         Program p = new Program();
         string expected = "Buzz";

         //act
         string actual = p.chooseString(6);

         //assert
         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 3");
      }

      [TestMethod]
      public void chooseStringForNumberDivisibleBy5()
      {
         //arrange
         Program p = new Program();
         string expected = "Fizz";

         //act
         string actual = p.chooseString(10);

         //assert
         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 5");
      }

      [TestMethod]
      public void chooseStringForNumberDivisibleBy3And5()
      {
         //arrange
         Program p = new Program();
         string expected = "FizzBuzz";

         //act
         string actual = p.chooseString(15);

         //assert
         Assert.AreEqual(expected, actual, "Wrong output for numbers divisible by 3 and 5");
      }

      [TestMethod]
      public void chooseStringForPrimeNumber()
      {
         //arrange
         Program p = new Program();
         string expected = "BuzzFizz";

         //act
         string actual = p.chooseString(17);

         //assert
         Assert.AreEqual(expected, actual, "Wrong output for prime numbers");
      }

      [TestMethod]
      public void verifyIsPrimeNumber()
      {
         //arrange
         Program p = new Program();
         bool expected = true;

         //act
         bool actual = p.isNumberPrime(17);

         //assert
         Assert.AreEqual(expected, actual, "Incorrect verify for prime numbers");
      }

      [TestMethod]
      public void verifyIsNotPrimeNumber()
      {
         //arrange
         Program p = new Program();
         bool expected = false;

         //act
         bool actual = p.isNumberPrime(21);

         //assert
         Assert.AreEqual(expected, actual, "Incorrect verify for prime numbers");
      }

      [TestMethod]
      public void verifyNextFibonacci()
      {
         //arrange
         Program p = new Program();
         int current = 2;
         int next = 3;
         int expected = 5;

         //act
         p.updateFibonacciNumbers(ref current, ref next);

         //assert
         Assert.AreEqual(expected, next, "Incorrect next fibonacci number");
      }

      [TestMethod]
      public void verifyFibonacciCount()
      {
         //arrange
         Program p = new Program();
         int expected = 11;

         //act
         int actual = p.fibonacci(11);

         //assert
         Assert.AreEqual(expected, actual, "Incorrect amount fibonacci numbers");
      }
   }
}

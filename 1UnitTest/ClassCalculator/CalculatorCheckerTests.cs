using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests
{
    [TestClass()]
    public class CalculatorCheckerTests
    {
        [TestMethod()]
        public void ValidateCalculatorTest_plus_ReturnTrue()
        {
            double a = 2;
            double b = 4;
            string operation = "+";
            double result = 6;
            bool expected = true;
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation,result);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ValidateCalculatorTest_Plus_ReturnFalse()
        {
            double a = 2;
            double b = 4;
            double result = 10;
            bool expected = false;
            string operation = "+";
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.IsFalse(expected);
        }
        [TestMethod]
        public void ValidateCalculatorTest_Minus_ReturnTrue()
        {
            double a = 10;
            double b = 5;
            string operation = "-";
            double result = 5;
            bool expected = true;
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateCalculatorTest_Minus_ReturnFalse()
        {
            double a = 10;
            double b = 2;
            double result = 9;
            bool expected = false;
            string operation = "-";
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.IsFalse(expected);
        }
        [TestMethod]
        public void ValidateCalculatorTest_multiply_ReturnTrue()
        {
            double a = 5;
            double b = 5;
            string operation = "*";
            double result = 25;
            bool expected = true;
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateCalculatorTest_multiply_ReturnFalse()
        {
            double a = 5;
            double b = 5;
            double result = 25;
            bool expected = false;
            string operation = "*";
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.IsFalse(expected);
        }
        [TestMethod]
        public void ValidateCalculatorTest_divide_ReturnTrue()
        {
            double a = 25;
            double b = 5;
            string operation = "/";
            double result = 5;
            bool expected = true;
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ValidateCalculatorTest_divide_ReturnFalse()
        {
            double a = 25;
            double b = 5;
            double result = 5;
            bool expected = false;
            string operation = "/";
            bool actual = CalculatorChecker.ValidateCalculator(a, b, operation, result);
            Assert.IsFalse(expected);
        }




    }
}
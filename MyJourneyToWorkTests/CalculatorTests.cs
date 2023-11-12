using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void ConvertDistance_KmToMilesConversion_CorrectConversion()
        {
            // Arrange
            Calculator calculator = new Calculator()
            {
                distance = 10,
                milesOrKms = DistanceMeasurement.kms
            };
            double expected_result = (10/1.60934);

            // Act
            double actual_result = calculator.convertDistance();

            // Assert
            Assert.AreEqual(expected_result, actual_result); 
        }

        [TestMethod]
        public void ConvertDistance_MilesToKmConversion_CorrectConversion()
        {
            // Arrange
            Calculator calculator = new Calculator()
            {
                distance = 10,
                milesOrKms = DistanceMeasurement.miles
            };

            // Act
            double actual_result = calculator.convertDistance();

            // Assert
            Assert.AreEqual(10, actual_result); 
        }

        
    }
}
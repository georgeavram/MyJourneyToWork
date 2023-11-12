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
            double expected_result = (10 / 1.60934);

            // Act
            double actual_result = calculator.convertDistance();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void ConvertDistance_MilesStayAsOriginalInput_CorrectConversion()
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

        [TestMethod]
        public void sustainabilityWeighting_IsPetrol_returnsvalid()
        {
            //arrange
            Calculator calculator = new Calculator()
            {
                transportMode = TransportModes.petrol,
                distance = 100, 
                milesOrKms = DistanceMeasurement.miles,
                numDays = 6 
            };

            //act
            double expected_result = calculator.transportModeWeighting[(int)TransportModes.petrol] * calculator.convertDistance() * (calculator.numDays * 2);
            double actual_result = 9600;

            //Assert
            Assert.AreEqual(actual_result, expected_result);
        }



        [TestMethod]
        public void sustainabilityWeighting_ValidInput_ReturnsTrueValue()
        {
            // Arrange
            Calculator calculator = new Calculator()
            {
                transportMode = TransportModes.petrol,
                distance = 100, // Set a distance value
                milesOrKms = DistanceMeasurement.miles,
                numDays = 6 // Set a number of days value
            };

            // Act
            double expected_result = calculator.transportModeWeighting[(int)TransportModes.petrol] * calculator.convertDistance() * (calculator.numDays * 2);
            double actual_result = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            Console.WriteLine($"Expected Result: {expected_result}");
            Console.WriteLine($"Actual Result: {actual_result}");

        }

    }
}
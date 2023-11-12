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
        public void sustainabilityWeighting_TransportModePetrol_CorrectCalculation()
        {
            // Arrange
            Calculator calculator = new Calculator()
            {
                transportMode = TransportModes.petrol, // transport mode
                distance = 100, // Set a distance value
                milesOrKms = DistanceMeasurement.miles, // calculated in miles
                numDays = 5 // number of days working
            };

            // Act
            double actual_result = calculator.transportModeWeighting[(int)TransportModes.petrol] * calculator.convertDistance() * (calculator.numDays * 2);
            double expected_result = 8000;

            // Assert
            Assert.AreEqual(actual_result,expected_result);
            Console.WriteLine($"Expected Result: {expected_result}"); //shows expected result in test
            Console.WriteLine($"Actual Result: {actual_result}"); // shows actual result in test

        }


        [TestMethod]
        public void sustainabilityWeighting_TransportModedeisel_CorrectCalculation()
        {
            // Arrange
            Calculator calculator = new Calculator()
            {
                transportMode = TransportModes.petrol, // transport mode
                distance = 100, // Set a distance value
                milesOrKms = DistanceMeasurement.miles, // calculated in miles
                numDays = 5 // number of days working
            };

            // Act
            double expected_result = calculator.transportModeWeighting[(int)TransportModes.deisel] * calculator.convertDistance() * (calculator.numDays * 2);
            double actual_result = 10000;

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            Console.WriteLine($"Expected Result: {expected_result}"); //shows expected result in test
            Console.WriteLine($"Actual Result: {actual_result}"); // shows actual result in test

        }







    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PicoYPlacaPredictor;

namespace UnitTestProjectPicoyPlacaPredictor
{
    [TestClass]
    public class UnitTest1
    {
        //DayOfLastDigitPlate Test
        //For the DateTime.DayOfWeek Property Monday 1/Tuesday 2/Wednesday 3/Thursday 4/Friday 5
        //Evaluates the Last Digit 1  for Monday = 1
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc1AndReturn1()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 1241;
            int expected = 1;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 2 for Monday = 1
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc2AndReturn1()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 0082;
            int expected = 1;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 3 for Tuesday = 2
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc3AndReturn2()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 1473;
            int expected = 2;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 4 for Tuesday = 2
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc4AndReturn2()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 1474;
            int expected = 2;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 5 for Tuesday = 3
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc5AndReturn3()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 9865;
            int expected = 3;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 6 for Tuesday = 3
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc6AndReturn3()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 4796;
            int expected = 3;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 7 for Tuesday = 4
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc7AndReturn4()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 5487;
            int expected = 4;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 8 for Tuesday = 4
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc8AndReturn4()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 1268;
            int expected = 4;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 9 for Tuesday = 5
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc9AndReturn5()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 0019;
            int expected = 5;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the Last Digit 0 for Tuesday = 5
        [TestMethod]
        public void DayOfLastDigitPlate_ShouldCalc0AndReturn5()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 3850;
            int expected = 5;
            //Act
            int actual = Methods.DayOfLastDigitPlate(picoPlacaobj.NumberPlate);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //VerifyDayOnDate Test
        //For the DateTime.DayOfWeek Property Monday 1/Tuesday 2/Wednesday 3/Thursday 4/Friday 5/Saturday 6/Sunday 0
        //Evaluates the day of the date as a Monday = 1 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcMondayAndReturn1()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/04";
            int expected = 1;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Tuesday = 2 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcTuesdayAndReturn2()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/05";
            int expected = 2;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Wednesday = 3 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcWednesdayAndReturn3()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/06";
            int expected = 3;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Thursday = 4 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcThursdayAndReturn4()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/07";
            int expected = 4;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Friday = 5 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcFridayAndReturn5()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/08";
            int expected = 5;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Saturday = 6 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcSaturdayAndReturn6()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/09";
            int expected = 6;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates the day of the date as a Sunday = 0 
        [TestMethod]
        public void VerifyDayOnDate_ShouldCalcSundayAndReturn0()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedDate = "2021/01/10";
            int expected = 0;
            //Act
            int actual = Methods.VerifyDayOnDate(picoPlacaobj.FormattedDate);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //VerifyTime Test
        //Evaluates if the time is between the PicoYPlaca restrictions range
        [TestMethod]
        public void VerifyTime_IsInRangeAndReturnTrue()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedTime = "8:25";
            bool expected = true;
            //Act
            bool actual = Methods.VerifyTime(picoPlacaobj.FormattedTime);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates if the time is not between the PicoYPlaca restrictions range
        [TestMethod]
        public void VerifyTime_IsNotInRangeAndReturnFalse()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.FormattedTime = "12:25";
            bool expected = false;
            //Act
            bool actual = Methods.VerifyTime(picoPlacaobj.FormattedTime);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //CanRoad Test
        //Evaluates if the car can road in PicoYPlaca restriction
        [TestMethod]
        public void CanRoad_IsTrueAndReturnTrue()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 0599;
            picoPlacaobj.FormattedDate = "2021/01/11";
            picoPlacaobj.FormattedTime = "12:30";
            bool expected = true;
            //Act
            bool actual = Methods.CanRoad(picoPlacaobj);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Evaluates if the car cannot road in PicoYPlaca restriction
        [TestMethod]
        public void CanRoad_IsFalseAndReturnFalse()
        {
            //Arrange
            PicoPlaca picoPlacaobj = new PicoPlaca();
            picoPlacaobj.NumberPlate = 0591;
            picoPlacaobj.FormattedDate = "2021/01/11";
            picoPlacaobj.FormattedTime = "08:30";
            bool expected = false;
            //Act
            bool actual = Methods.CanRoad(picoPlacaobj);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

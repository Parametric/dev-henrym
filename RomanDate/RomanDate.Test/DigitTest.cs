using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace RomanDate.Test
{
    [TestClass]
    public class DigitTest
    {
        [DataTestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        public void OnesPlaceConvertsCorrectly(int toConvert, string expectedResult)
        {
            // arrange
            // act
            var romanNumeralString = Program.ConvertToRomanNumeral(toConvert);

            // assert
            romanNumeralString.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow(10, "X")]
        [DataRow(20, "XX")]
        [DataRow(30, "XXX")]
        [DataRow(40, "XL")]
        [DataRow(50, "L")]
        [DataRow(60, "LX")]
        [DataRow(70, "LXX")]
        [DataRow(80, "LXXX")]
        [DataRow(90, "XC")]
        public void TensPlaceConvertsCorrectly(int toConvert, string expectedResult)
        {
            // arrange
            // act
            var romanNumeralString = Program.ConvertToRomanNumeral(toConvert);

            // assert
            romanNumeralString.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow(100, "C")]
        [DataRow(200, "CC")]
        [DataRow(300, "CCC")]
        [DataRow(400, "CD")]
        [DataRow(500, "D")]
        [DataRow(600, "DC")]
        [DataRow(700, "DCC")]
        [DataRow(800, "DCCC")]
        [DataRow(900, "CM")]
        public void HundredsPlaceConvertsCorrectly(int toConvert, string expectedResult)
        {
            // arrange
            // act
            var romanNumeralString = Program.ConvertToRomanNumeral(toConvert);

            // assert
            romanNumeralString.ShouldBe(expectedResult);
        }

        [DataTestMethod]
        [DataRow(123, "CXXIII")]
        [DataRow(547, "DXLVII")]
        [DataRow(3999, "MMMCMXCIX")]
        [DataRow(2019, "MMXIX")]
        [DataRow(4000, "M\u0305V")]
        [DataRow(10000, "\u0305X")]
        [DataRow(20000, "\u0305X\u0305X")]
        [DataRow(9999, "M\u0305XCMXCIX")]
        [DataRow(90000, "\u0305X\u0305C")]
        //[DataRow(900, "CM")]
        public void AdHocConvertsCorrectly(int toConvert, string expectedResult)
        {
            // arrange
            // act
            var romanNumeralString = Program.ConvertToRomanNumeral(toConvert);

            // assert
            romanNumeralString.ShouldBe(expectedResult);
        }
    }
}

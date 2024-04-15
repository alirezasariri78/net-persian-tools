using PersianTools.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace PersianToolsTests
{

    [ExcludeFromCodeCoverage]
    public class GetBankNameFromCardNumberTests
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", "")]

        public void Null_Empty_Input_Test(string input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }


        [Theory]
        [InlineData("1", "")]
        [InlineData("12345678901234567", "")]

        public void Check_Invalid_Digit_String_Test(string input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }


        [Theory]
        [InlineData(1, "")]
        [InlineData(12345678901234567, "")]

        public void Check_Invalid_Digit_uLong_Test(ulong input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }



        [Theory]
        [InlineData("123456", "")]
        [InlineData("alphabet", "")]
        public void Check_None_Exists_String_Card(string input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }

        [Theory]
        [InlineData(123456, "")]
        public void Check_None_Exists_uLong_Card(ulong input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }



        [Theory]
        [InlineData("505801", "موسسه کوثر")]
        [InlineData("903769", "بانک صادرات ایران")]
        [InlineData("603769", "بانک صادرات ایران")]
        [InlineData("5058013456765432", "موسسه کوثر")]
        [InlineData("9037693456765432", "بانک صادرات ایران")]
        [InlineData("6037693456765432", "بانک صادرات ایران")]
        public void Check_Exists_String_Card(string input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }

        [Theory]
        [InlineData(5058013456765432, "موسسه کوثر")]
        [InlineData(9037693456765432, "بانک صادرات ایران")]
        [InlineData(6037693456765432, "بانک صادرات ایران")]
        public void Check_Exists_uLong_Card(ulong input, string expected)
        {
            Assert.Equal(expected, GetBankNameFromCardNumber.Find(input));
        }

    }
}

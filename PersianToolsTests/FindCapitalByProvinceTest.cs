using PersianTools.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace PersianToolsTests
{


    [ExcludeFromCodeCoverage]
    public class FindCapitalByProvinceTest
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", "")]

        public void Null_Empty_Input_Test(string input, string expected)
        {
            Assert.Equal(expected, FindCapitalByProvince.Find(input));
        }


        [Theory]
        [InlineData("قم", "قم")]
        [InlineData("چهارمحال و بختیاری", "شهرکرد")]

        public void Check_Exists_Province(string input, string expected)
        {
            Assert.Equal(expected, FindCapitalByProvince.Find(input));
        }


        [Theory]
        [InlineData("لندن", "")]
        [InlineData("London", "")]
        public void Check_None_Exists_Province(string input, string expected)
        {
            Assert.Equal(expected, FindCapitalByProvince.Find(input));
        }

    }
}

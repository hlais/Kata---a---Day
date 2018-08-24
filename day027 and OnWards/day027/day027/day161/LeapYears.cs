using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWards7Kata
{
    class LeapYears
    {
        public static bool IsLeapYear(int year)
        {
           return DateTime.IsLeapYear(year);
        }
    }
}


//In this kata you should simply determine, whether a given year 
// is a leap year or not.In case you don't know the rules, here they are:

//years divisible by 4 are leap years
//but years divisible by 100 are no leap years
//but years divisible by 400 are leap years
//Additional Notes:

//Only valid years (positive integers) will be tested, so you don't have to validate them
//Examples can be found in the test fixture.


    //Assert.AreEqual(false, Kata.IsLeapYear(1234), "Year 1234");

    //Assert.AreEqual(true, Kata.IsLeapYear(1984), "Year 1984");

    //Assert.AreEqual(true, Kata.IsLeapYear(2000), "Year 2000");
    //Assert.AreEqual(false, Kata.IsLeapYear(2010), "Year 2010");

    //Assert.AreEqual(false, Kata.IsLeapYear(2013), "Year 2013");


using System;
using RestSharp;
using testautomation.RestApiUtilities;

namespace testautomation.TestCases.Sampletest1
{
    public class Sampletest1
    {
        static void Main(string[] args)
        {   //sample line of code to call other method 
            Console.WriteLine("Hi All , This is a sample test case");
            Console.WriteLine("*******Test case Name - sample test 1 ********");
            //Console.WriteLine("We are trying to call another method from here");
            RestUtilities p1 = new RestUtilities();//created object of class here
            p1.ReturnResponseCode("http://restapi.demoqa.com/utilities/weather/city/", "London");
            p1.ValidatePresenceOfText("London");
            p1.ReturnResponseCode("http://restapi.demoqa.com/utilities/weather/city/", "Zurich");
            p1.ValidatePresenceOfText("London");
        }
    }
}

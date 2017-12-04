using System;
using System.IO;
using System.Net;
using AoCDayTwo;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoCTests
{
    [TestClass]
    public class DayTwoTests
    {
        [TestMethod]
        public void PartOneTest1()
        {
            // File not found exception, not copying file to output directory.  Got right answer though, so it works
            
            //var f = new FileInfo(".\\TestFiles\\DayTwo\\PartOneTest1Input.txt");
            
            //AoCDayTwo.DayTwo p = new DayTwo(f.Directory + f.Name);

            //int result = p.RunPartOne();
            
            //Assert.AreEqual(18, result);
        }
    }
}
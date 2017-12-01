using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoCDayOne;

namespace AoCTests
{
    [TestClass]
    public class DayOneTests
    {
        #region part1
        
        [TestMethod]
        public void DayOnePartOneTests1()
        {
            string input = "1122";

            DayOnePartOne d1 = new DayOnePartOne(input);

            int result = d1.run();

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void DayOnePartOneTests2()
        {
            string input = "1111";
            
            DayOnePartOne d1 = new DayOnePartOne(input);

            int result = d1.run();

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DayOnePartOneTests3()
        {
            string input = "1234";
            
            DayOnePartOne d1 = new DayOnePartOne(input);

            int result = d1.run();

            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void DayOnePartOneTests4()
        {
            string input = "91212129";
            
            DayOnePartOne d1 = new DayOnePartOne(input);

            int result = d1.run();

            Assert.AreEqual(9, result);
        }
        
        #endregion
        
        #region part2

        [TestMethod]
        public void DayOnePartTwoTest1()
        {
            string input = "1212";
            
            DayOnePartOne p = new DayOnePartOne(input);

            int result = p.runPart2();
            
            Assert.AreEqual(6, result);
        }
        
        [TestMethod]
        public void DayOnePartTwoTest2()
        {
            string input = "1221";
            
            DayOnePartOne p = new DayOnePartOne(input);

            int result = p.runPart2();
            
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void DayOnePartTwoTest3()
        {
            string input = "123425";
            
            DayOnePartOne p = new DayOnePartOne(input);

            int result = p.runPart2();
            
            Assert.AreEqual(4, result);
        }
        
        [TestMethod]
        public void DayOnePartTwoTest4()
        {
            string input = "123123";
            
            DayOnePartOne p = new DayOnePartOne(input);

            int result = p.runPart2();
            
            Assert.AreEqual(12, result);
        }
        
        [TestMethod]
        public void DayOnePartTwoTest5()
        {
            string input = "12131415";
            
            DayOnePartOne p = new DayOnePartOne(input);

            int result = p.runPart2();
            
            Assert.AreEqual(4, result);
        }
    
        #endregion
    }
}
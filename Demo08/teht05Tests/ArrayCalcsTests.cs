using Microsoft.VisualStudio.TestTools.UnitTesting;
using teht05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // arrange
            double[] taul = { 4.0, 5,};
            double expected = 9;
            //double[] taul = { };
            //double expected = 0;
            //act
            double actual = ArrayCalcs.Sum(taul);
            // assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void AverageTest()
        {

            double[] taul = { 4.0, 5, };
            double expected = 4.5;
            //double[] taul = { };
            //double expected = 0;
            //act
            double actual = ArrayCalcs.Average(taul);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] taul = { 4.0, 5,};
            double expected = 5;
            //double[] taul = { };
            //double expected = 0;
            //act
            double actual = ArrayCalcs.Max(taul);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] taul = { 4.0, 5, };
            double expected = 4.0;
            //double[] taul = { };
            //double expected = 0;
            //act
            double actual = ArrayCalcs.Min(taul);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
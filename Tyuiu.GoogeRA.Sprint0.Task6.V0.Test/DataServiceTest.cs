using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.GoogeRA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubtracitionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtracitionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultipliitionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultipliitionArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}

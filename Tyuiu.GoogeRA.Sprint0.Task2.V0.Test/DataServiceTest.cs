using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GoogeRA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GoogeRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassegeValid ()
        {
            var name = "Роберт";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Роберт", res);
        }
    }
}

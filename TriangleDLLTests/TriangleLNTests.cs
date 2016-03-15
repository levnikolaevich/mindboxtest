using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDLL.Tests
{
    [TestClass]
    public class TriangleLNTests
    {
        [TestMethod]
        public void TriangleSQTest()
        {
            
            //Act

            double result = TriangleLN.TriangleSQ(3,4,5);

            //Assert
            Assert.AreEqual(6, result);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfThronesII.tests
{
    [TestClass]
    public class CommonSubstringFindingTests
    {
        [TestMethod]
        public void have_common_string()
        {
            var intP = 2;
            var line1 = "hello";
            var line2 = "world";
            var line3 = "hi";
            var line4 = "world";

            var res1 = GameOfThronesII.Program.haveCommon(intP, line1, line2);

            var res2 = GameOfThronesII.Program.haveCommon(intP, line3, line4);

            Assert.AreEqual("YES", res1);
            Assert.AreEqual("NO", res2);

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HowJenkinsWorksTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HowJenkinsWorks.Program.Main(null);
                Assert.AreEqual(Expected, sw.ToString().Trim());

            }
        }
    }
}

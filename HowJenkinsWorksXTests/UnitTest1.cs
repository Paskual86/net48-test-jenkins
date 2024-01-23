using System;
using System.IO;
using Xunit;

namespace HowJenkinsWorksXTests
{
    public class UnitTest1
    {
        private const string Expected = "Hello Jenkins";
        [Fact]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HowJenkinsWorks.Program.Main(null);
                Assert.Equal(Expected, sw.ToString().Trim());
            }
        }
    }
}

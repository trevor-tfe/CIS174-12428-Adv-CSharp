using FirstResponsiveWebAppStewart.Models;
using FirstResponsiveWebAppStewart.Controllers;

namespace FirstResponsiveWebAppStewart.test
{
    public class Tests
    {

        private WebAppStewart testClass;
        [SetUp]
        public void Setup()
        {
            testClass = new WebAppStewart();
            testClass.Name = "Test";
        }

        [TestCase(1990)]
        public void AgeThisYearTest(int value)
        {
            testClass.BirthYear = value;
            var result = testClass.AgeThisYear();
            Assert.AreEqual(result, "Test will be 33 on December 31st");
        }

        [TestCase("Trevor")]
        public void TestName(string value) 
        { 
            testClass.Name = value;
            var result = testClass.Name;
            Assert.AreEqual(value, result);
        }
    }
}
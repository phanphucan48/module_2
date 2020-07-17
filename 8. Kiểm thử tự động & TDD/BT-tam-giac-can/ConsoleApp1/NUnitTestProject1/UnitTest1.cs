using NUnit.Framework;
using ConsoleApp1.Service;

namespace NUnitTestProject1
{
    public class Tests
    {
        private TamGiac _tamgiac;
        [SetUp]
        public void Setup()
        {
            _tamgiac = new TamGiac(); 
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Tam Giác Đều",_tamgiac.LoaiTamGiac(7,7,7));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalcLibTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //переменные готовим
            int x = 10;
            int y = 20;
            int expected = 30; //ожидаемое значение

            //выполняем код
            CalcLib c = new CalcLib();
            int actual = c.Sum(x, y); //значение по факту

            //сравнение значений ожидаемого и фактического
            Assert.AreEqual(expected, actual);
        }
    }
}

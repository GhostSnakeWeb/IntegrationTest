using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalcLibTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //���������� �������
            int x = 10;
            int y = 20;
            int expected = 30; //��������� ��������

            //��������� ���
            CalcLib c = new CalcLib();
            int actual = c.Sum(x, y); //�������� �� �����

            //��������� �������� ���������� � ������������
            Assert.AreEqual(expected, actual);
        }
    }
}

using Tyuiu.RomashkinaPB.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RomashkinaPB.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки 
            var name = "Полина";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Полина", res);

        }
    }
}

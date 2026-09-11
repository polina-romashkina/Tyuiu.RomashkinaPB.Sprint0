using Tyuiu.RomashkinaPB.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RomashkinaPB.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса dataService и метода GetMessage
            //из библиотеки Tyuiu.RomashkinaPB.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Полина"));
            Console.ReadKey();
        }
    }
}

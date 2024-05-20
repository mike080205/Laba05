using System;
using Lab05Lib;

namespace Lab05App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дані планшета:");
            Console.Write("Модель: ");
            string model = Console.ReadLine();
            Console.Write("Виробник: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Розмір екрану (в дюймах): ");
            double screenSize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Об'єм пам'яті (в ГБ): ");
            int memorySize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ємність акумулятора (мАг): ");
            int batteryCapacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Має Wi-Fi (true/false): ");
            bool hasWiFi = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Має 4G (true/false): ");
            bool has4G = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Ціна: грн");
            double price = Convert.ToDouble(Console.ReadLine());

            Tablet tablet = new Tablet(model, manufacturer, screenSize, memorySize, batteryCapacity, hasWiFi, has4G, price);

            Console.WriteLine("\nДеталі планшета:");
            Console.WriteLine($"Модель: {tablet.Model}");
            Console.WriteLine($"Виробник: {tablet.Manufacturer}");
            Console.WriteLine($"Розмір екрану: {tablet.ScreenSize} дюймів");
            Console.WriteLine($"Розмір пам'яті: {tablet.MemorySize} GB");
            Console.WriteLine($"Ємність батареї: {tablet.BatteryCapacity} mAh");
            Console.WriteLine($"Є WiFi: {tablet.HasWiFi}");
            Console.WriteLine($"Має 4G: {tablet.Has4G}");
            Console.WriteLine($"Ціна: {tablet.Price} грн");
            Console.WriteLine($"Ціна за мАг: ${tablet.CalculatePricePermAh():0.00}");

            Console.WriteLine("\nЩоб вийти, натисніть будь-яку клавішу.");
            Console.ReadKey();
        }
    }
}

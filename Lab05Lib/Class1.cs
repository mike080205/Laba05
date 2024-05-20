namespace Lab05Lib
{
    public class Tablet
    {
        // Поля класу
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double ScreenSize { get; set; }
        public int MemorySize { get; set; }
        public int BatteryCapacity { get; set; }
        public bool HasWiFi { get; set; }
        public bool Has4G { get; set; }
        public double Price { get; set; }

        // Конструктор класу
        public Tablet(string model, string manufacturer, double screenSize, int memorySize, int batteryCapacity, bool hasWiFi, bool has4G, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            ScreenSize = screenSize;
            MemorySize = memorySize;
            BatteryCapacity = batteryCapacity;
            HasWiFi = hasWiFi;
            Has4G = has4G;
            Price = price;
        }

        // Метод класу для обчислення ціни за 1 мАг батареї
        public double CalculatePricePermAh()
        {
            if (BatteryCapacity != 0)
                return Price / BatteryCapacity;
            else
                return 0;
        }
    }
}

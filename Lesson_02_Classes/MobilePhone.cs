using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_02_Classes
{
    public class MoblilePhone
    {
        public string model = null;
        public string manufacturer = null;
        public decimal price = 0;
        public string owner = null;

        public static int nokiaN95 = 0;

        public MoblilePhone(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        public void NokiaCreated()
        {
            if (model == "Nokia N95")
            {
                nokiaN95++;
            }

            Console.WriteLine($"Nokia N95 created: {nokiaN95}");
        }
        public class Battery
        {
            public string model = null;
            public int idleTime = 0;
            public int hourTalk = 0;
            public List<string> batteryType = new List<string>() { "Li-lon", "NiMH", "NiCd" };

            public Battery(string model, int idleTime, int hourTalk)
            {
                this.model = model;
                this.idleTime = idleTime;
                this.hourTalk = hourTalk;
            }
        }

        public class Screen
        {
            public int size = 0;
            public string color = null;

            public Screen(int size, string color)
            {
                this.size = size;
                this.color = color;
            }
        }

        public class GSM
        {
            MoblilePhone nokia = new MoblilePhone("Nokia N95", "Nokia", 95, "Jhon Smith");
            Battery superBattery = new Battery("G5", 100, 90);
            Screen bigScreen = new Screen(8, "Black");
            public override string ToString()
            {
                nokia.NokiaCreated();
                return $"Mobile phone. Model: {nokia.model}, Manufacturer: {nokia.manufacturer}, Price: {nokia.price}, \nOwner: {nokia.owner}" +
                    $"\nBattery. Model: {superBattery.model}, Idle time: {superBattery.idleTime}, Hour Talk: {superBattery.hourTalk}" +
                    $"\nScreen. Size: {bigScreen.size}, Color: {bigScreen.color}";
            }
        }
    }
}

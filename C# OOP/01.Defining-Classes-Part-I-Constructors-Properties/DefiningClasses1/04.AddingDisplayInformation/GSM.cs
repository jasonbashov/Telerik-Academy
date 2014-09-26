//Add a method in the GSM class for displaying all information about it. Try to override ToString().
namespace _04.AddingDisplayInformation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum BatteryType
    {
        LiIon, NiMH, NiCd, LiPoly
    }

    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }

    class Display
    {
        private double size;
        private int numberOfColors;

        public Display()
        {

        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        Battery battery = new Battery();
        Display disp = new Display();

        static void Main(string[] args)
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine("====PHONE=INFORMATION====");
            Console.WriteLine("Phone model: {0}", this.model);
            Console.WriteLine("Manufacturer: {0}",this.manufacturer);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("Owner: {0}", this.owner);
            Console.WriteLine("====BATTERY=INFORMATION===");
            Console.WriteLine("Battery's model: {0}", this.battery.Model);
            Console.WriteLine("Type: {0}", this.battery.BatteryType);
            Console.WriteLine("Hours Idle: {0}", this.battery.HoursIdle);
            Console.WriteLine("Hours Talk: {0}", this.battery.HoursTalk);
            Console.WriteLine("====DISPLAY=INFORMATION===");
            Console.WriteLine("Size: {0}", this.disp.Size);
            Console.WriteLine("NumberOfColors: {0}", this.disp.NumberOfColors);
        }
        #region Constructors

        public GSM()
        {

        }
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, string owner, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
        }

        public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display disp)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.disp = disp;
        }
        #endregion

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

    }
}


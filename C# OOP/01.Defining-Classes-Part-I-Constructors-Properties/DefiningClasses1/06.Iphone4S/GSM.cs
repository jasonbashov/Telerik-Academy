//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
namespace _06.AddingIphone4S
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
        #region PreviousTasks
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public Battery()
        {

        }
        #endregion

        #region Properties
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid hours to talk! Must be greater than 0!");
                }
                this.hoursTalk = value;
            }
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid idle hours! Must be greater than 0!");
                }
                this.hoursIdle = value;
            }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (value != this.batteryType)
                {
                    throw new ArgumentException("Invalid type of battery entered!");
                }
                this.batteryType = value;
            }
        }
        #endregion
    }

    class Display
    {
        #region PreviousTasks
        private double size;
        private int numberOfColors;

        public Display()
        {

        }
        #endregion

        #region Properties
        public double Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid size! Must be greater than 0!");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of colours! Must be greater than 0!");
                }
                this.numberOfColors = value;
            }
        }
        #endregion
    }
    class GSM
    {
        #region PreviousTasks
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery = new Battery();
        private Display disp = new Display();
        private static GSM iPhone4S;

        static void Main(string[] args)
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine("====PHONE=INFORMATION====");
            Console.WriteLine("Phone model: {0}", this.model);
            Console.WriteLine("Manufacturer: {0}", this.manufacturer);
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

        public GSM(string model, int price)
        {
            this.model = model;
            this.price = price;
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

        #endregion

        #region Properties
        public GSM IPhone4S
        {
            get { return iPhone4S = new GSM("Iphone 4S", 1300); }
        }
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
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid price! Must be greater than 0!");
                }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Disp
        {
            get { return this.disp; }
            set { this.disp = value; }
        }
        
        #endregion
    }
}


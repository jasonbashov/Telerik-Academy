//Create a class Call to hold a call performed through a GSM. It should contain date,
//time, dialed phone number and duration (in seconds).

namespace _08.AddingCallMethod
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

    class Call
    {
        private int dialedNumber;
        private int duration;
        private DateTime date;
        private int time;

        #region Constructors
        public Call()
            :this(0887544444)
        {
        }

        public Call(int dialedNumber)
            : this(dialedNumber, DateTime.Now)
        {

        }
        public Call(int dialedNumber,DateTime date)
            : this(dialedNumber, date, DateTime.Now.Hour)
        {

        }
        public Call(int dialedNumber, DateTime date, int time)
            :this (dialedNumber , date, time , (date.Hour - time))
        {
        }
        public Call(int dialedNumber, DateTime date, int time, int duration)
        {
            this.dialedNumber = dialedNumber;
            this.duration = duration;
            this.date = date.Date;
            this.time = time;
        }
        #endregion

        #region Properties
        public int DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }
        public int Time
        {
            get { return this.time; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public int Duration
        {
            get { return this.duration; }
        }


        #endregion
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

    class GSMTest
    {
        static void Main()
        {
            GSM[] mobilePhones = new GSM[5];
            string[] models = { "n50", "galaxy", "phone3", "e34", "somemodel" };
            string[] manufacturers = { "nokia", "samsung", "apple", "nokia", "mobikom" };
            double price = 600;
            BatteryType batteryType = BatteryType.LiIon;
            //"filling" the GSMs
            int i = 0;
            foreach (var phone in mobilePhones)
            {
                mobilePhones[i] = new GSM();
                i++;
            }
            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine("Enter Owner:");
                string owner = Console.ReadLine();
                mobilePhones[index].Owner = owner;
                mobilePhones[index].Model = models[index];
                mobilePhones[index].Manufacturer = manufacturers[index];
                mobilePhones[index].Price = price;
                price += 150;
                mobilePhones[index].Battery.BatteryType = batteryType;
                mobilePhones[index].Battery.Model = "MadeInChina";
                mobilePhones[index].Disp.NumberOfColors = 999959992;
            }

            foreach (var phone in mobilePhones)
            {
                Console.WriteLine();
                Console.WriteLine("{0} information", phone.Model);
                phone.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Information about the static property IPhone4S");
            Console.WriteLine("Model: {0}", mobilePhones[0].IPhone4S.Model);
            Console.WriteLine("Price: {0}", mobilePhones[0].IPhone4S.Price);
            Console.ReadLine();
        }

    }
}


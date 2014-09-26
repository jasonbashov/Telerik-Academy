//********************************************************************************************
//I have added empty Main method in some tasks so I can build the solution to check for errors
//********************************************************************************************
//Define several constructors for the defined classes that take different sets of arguments 
//(the full information for the class or part of it). Assume that model and manufacturer are mandatory 
//    (the others are optional). All unknown data fill with null.
namespace _02.DefiningConstructors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;

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

        #region Constructors

        public GSM()
        {

        }
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model,string manufacturer, string owner, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
        }

        public GSM(string model,string manufacturer, string owner, double price, Battery battery, Display disp)
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

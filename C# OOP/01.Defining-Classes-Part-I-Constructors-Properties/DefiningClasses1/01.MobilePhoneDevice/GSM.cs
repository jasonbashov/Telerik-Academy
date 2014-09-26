//********************************************************************************************
//I have added empty Main method in some tasks so I can build the solution to check for errors
//********************************************************************************************
//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics 
//(model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
namespace _01.MobilePhoneDevice
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
    }

}

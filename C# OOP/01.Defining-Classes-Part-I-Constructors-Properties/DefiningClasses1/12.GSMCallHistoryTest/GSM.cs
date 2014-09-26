//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.
namespace _12.GSMCallHistoryTest
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
        private TimeSpan duration;
        private DateTime date;
        private DateTime time;

        #region Constructors
        public Call()
            : this(0887544444)
        {
        }

        public Call(int dialedNumber)
            : this(dialedNumber, DateTime.Now)
        {

        }
        public Call(int dialedNumber, DateTime date)
            : this(dialedNumber, date, DateTime.Now)
        {

        }
        public Call(int dialedNumber, DateTime date, DateTime time)
            : this(dialedNumber, date, time, TimeSpan.MinValue)
        {
        }
        public Call(int dialedNumber, DateTime date, DateTime time, TimeSpan duration)
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
        public DateTime Time
        {
            get { return this.time; }
        }
        public DateTime Date
        {
            get { return this.date; }
        }
        public TimeSpan Duration
        {
            get { return this.duration; }
            set
            {
                this.duration = value;
            }
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
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery = new Battery();
        private Display disp = new Display();
        private static GSM iPhone4S;
        public List<Call> callHistory = new List<Call>();



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


        #region Properties
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }
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

        public void AddCall(Call callToAdd)
        {
            this.callHistory.Add(callToAdd);
        }

        public void RemoveCall(int indexOfCall)
        {
            this.callHistory.RemoveAt(indexOfCall);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalPrice(float pricePerMin)
        {
            int totalSecondsCalls = 0;

            foreach (var call in callHistory)
            {
                int dur = (int)call.Duration.TotalSeconds;
                totalSecondsCalls += dur;
            }

            decimal result = (decimal)(pricePerMin * ((totalSecondsCalls / 60) + 1));

            return result;
        }
    }

    class GSMCallHistoryTest
    {
        static Call FindLongestCall(List<Call> callHistory)
        {
            int biggest = 0;
            int index = 0;
            int searchedIndex = 0;
            foreach (var call in callHistory)
            {
                int current = call.Duration.Seconds;
                if (current > biggest)
                {
                    biggest = current;
                    searchedIndex = index;
                }
                index++;
            }
            return callHistory[searchedIndex];
        }

        static void DeleteLongestCall(List<Call> callHistory)
        {
            Call callToDelete = FindLongestCall(callHistory);

            callHistory.Remove(callToDelete);
        }

        static void ClearCallHistory(List<Call> callHistory)
        {
            callHistory.Clear();
        }

        static void PrintInfo(List<Call> callHistory)
        {
            bool isEmpty = !callHistory.Any();
            if (isEmpty)
            {
                Console.WriteLine("Sorry! Call history is empty");
            }
            else
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine("Dialed number: +359 {0}", call.DialedNumber);
                    Console.WriteLine("Date: {0}", call.Date.ToString("d"));
                    Console.WriteLine("Time: {0}", call.Time.ToString("T"));
                    Console.WriteLine("Duration: {0:D2}:{1:D2}", call.Duration.Minutes, call.Duration.Seconds);
                }
            }
        }
        static void Main()
        {
            float pricePerMinute = 0.37f;
            GSM testingGSM = new GSM("Iphone", "Apple", "James Bond", 1599);

            //adding calls
            Call call1 = new Call(0888888888, DateTime.Now, DateTime.Now);
            testingGSM.AddCall(call1);

            DateTime startTime = DateTime.Now;
            Console.WriteLine("Please wait a few seconds for the duration to evaluate and press any key to continue");
            Console.ReadLine();

            TimeSpan duration1 = DateTime.Now.Subtract(startTime);
            Call call2 = new Call(0999999992, DateTime.Now, (DateTime.Now));
            testingGSM.AddCall(call2);
            startTime = DateTime.Now;

            Console.WriteLine("Please wait a few seconds for the duration to evaluate and press any key to continue");
            Console.ReadLine();
            TimeSpan duration2 = DateTime.Now.Subtract(startTime);

            //TimeSpan duration3 = DateTime.Now.Subtract(startTime);
            Call call3 = new Call(0997897992, DateTime.Now, (DateTime.Now));
            testingGSM.AddCall(call3);

            startTime = DateTime.Now;
            Console.WriteLine("Please wait a few seconds for the duration to evaluate and press any key to continue");
            Console.ReadLine();

            TimeSpan duration3 = DateTime.Now.Subtract(startTime);

            call1.Duration = duration1;
            call2.Duration = duration2;
            call3.Duration = duration3;

            //displaying calls information
            PrintInfo(testingGSM.callHistory);


            //showing the tottal price
            decimal totalPrice = testingGSM.TotalPrice(pricePerMinute);
            Console.WriteLine("Total price: {0}", totalPrice);

            //deleting the longest call
            DeleteLongestCall(testingGSM.callHistory);

            //displaying calls information
            PrintInfo(testingGSM.callHistory);

            //showing the tottal price
            totalPrice = testingGSM.TotalPrice(pricePerMinute);
            Console.WriteLine("Total price: {0}", totalPrice);

            //clear all call history
            ClearCallHistory(testingGSM.callHistory);

            //displaying calls information
            PrintInfo(testingGSM.callHistory);

            Console.WriteLine("THE END");
        }

    }
}


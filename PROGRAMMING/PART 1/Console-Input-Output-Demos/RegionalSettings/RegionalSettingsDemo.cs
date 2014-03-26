using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace RegionalSettings
{
    class RegionalSettingsDemo
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            //CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            //CultureInfo usCulture = new CultureInfo("en-US");
            //CultureInfo bgCulture = new CultureInfo("bg-BG");
            //CultureInfo configCulture = new CultureInfo(Properties.Settings.Default.DefaultCulture); //get a setting from the app.config file


            //Thread.CurrentThread.CurrentCulture = usCulture;

            double value = 3.54;
            Console.WriteLine("The value is: {0}", value);

            // Two possible outputs:
            //  - The value is 3.54
            //  - The value is 3,54

            decimal money = 100.5M;
            Console.WriteLine("I have {0:C} in my wallet.", money);


            Console.Write("Please enter a value: ");
            // Try entering "1.56" and also "1,2,3,4,5"
            decimal d = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(d);

            // Change the decimal separator to "."

            Console.WriteLine("The value in InvariantCulture is: {0}", d.ToString(CultureInfo.InvariantCulture));
            // The value is 3.54

        }
    }
}

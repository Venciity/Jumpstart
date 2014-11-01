namespace LaptopShop
{
    using System;

    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;
    class LaptopShop
    {
        static void Main()
        {
            // for writing unicode chars to console
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Battery battery = new Battery("4-клетъчна", 4.5f);

            Laptop AsusROGG550 = new Laptop(
                "ASUS ROG G550JK-XO265D",
                1869m,
                "ASUS",
                "Intel Core i5-4200H (2-ядрен, 2.80 - 3.40 GHz, 3MB кеш)",
                "8GB (2x 4096MB) - DDR3, 1600Mhz",
                "NVIDIA GeForce GTX 850M (2GB DDR3)",
                "870GB (120GB SSD + 750GB SSHD (5400 оборота/минута)",
                "15.6-инчов (39.62 см.) - 1366x768, матов",
                battery);

            Console.WriteLine(AsusROGG550);
        }
    }
}

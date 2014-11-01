namespace LaptopShop
{
    using System;
    class LaptopShop
    {
        static void Main()
        {
            // for writing unicode chars to console
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Battery batteryModel1 = new Battery("4-клетъчна", 4.5f);
            Battery batteryModel2 = new Battery("8-клетъчна", 6f);

            Laptop AsusROGG550 = new Laptop(
                "ASUS ROG G550JK-XO265D",
                1869m,
                "ASUS",
                "Intel Core i5-4200H (2-ядрен, 2.80 - 3.40 GHz, 3MB кеш)",
                "8GB (2x 4096MB) - DDR3, 1600Mhz",
                "NVIDIA GeForce GTX 850M (2GB DDR3)",
                "870GB (120GB SSD + 750GB SSHD (5400 оборота/минута)",
                "15.6-инчов (39.62 см.) - 1366x768, матов",
                batteryModel1);

            Laptop AsusK551LN = new Laptop("ASUS K551LN-DM064D", 1349m);

            Laptop AsusG750JS = new Laptop("ASUS G750JS-T4046D", 2769m, "Asus", "Intel Core i7-4700HQ (4-ядрен, 2.40 - 3.40 GHz, 6MB кеш)");

            Console.WriteLine(AsusROGG550);
            Console.WriteLine(AsusK551LN);
            Console.WriteLine(AsusG750JS);
        }
    }
}

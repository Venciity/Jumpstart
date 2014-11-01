namespace LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null,
            string graphicsCard = null, string hdd = null, string screen = null, Battery battery = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model", "Model cannot be empty or null!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Manufacturer", "Manufacturer cannot be empty or null!");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Processor", "Processor cannot be empty or null!");
                }

                this.processor = value;
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ram", "Ram cannot be empty or null!");
                }

                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GraphicsCard", "GraphicsCard cannot be empty or null!");
                }

                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Hdd", "Hdd cannot be empty or null!");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Screen", "Screen cannot be empty or null!");
                }

                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be negative!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder laptopInfo = new StringBuilder();
            laptopInfo.AppendLine("Model: " + this.Model);
            if (this.Manufacturer != null)
            {
                laptopInfo.AppendLine("Manufacturer: " + this.Manufacturer);
            }

            if (this.Processor != null)
            {
                laptopInfo.AppendLine("Processor: " + this.Processor);
            }

            if (this.Ram != null)
            {
                laptopInfo.AppendLine("RAM: " + this.Ram);
            }

            if (this.GraphicsCard != null)
            {
                laptopInfo.AppendLine("Graphics card: " + this.GraphicsCard);
            }

            if (this.Hdd != null)
            {
                laptopInfo.AppendLine("HDD: " + this.Hdd);
            }

            if (this.Screen != null)
            {
                laptopInfo.AppendLine("Screen: " + this.Screen);
            }

            if (this.Battery != null)
            {
                laptopInfo.Append(this.Battery.ToString());
            }

            laptopInfo.AppendLine(string.Format("Price: {0:F2} lv.", this.price));

            return laptopInfo.ToString();
        }
    }
}

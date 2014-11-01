namespace LaptopShop
{
    using System;
    using System.Text;

    public class Battery
    {
        private string type;
        private float liveInHours;

        public Battery(string type, float liveInHours)
        {
            this.Type = type;
            this.LiveInHours = liveInHours;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Type", "Type cannot be empty!");
                }

                this.type = value;
            }
        }

        public float LiveInHours
        {
            get
            {
                return this.liveInHours;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("LiveInHours", "LiveInHours cannot be negative!");
                }

                this.liveInHours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder battertyInfo = new StringBuilder();
            battertyInfo.AppendLine("Battery: " + this.Type);
            battertyInfo.AppendLine("Battery life: " + this.LiveInHours + " hours");
            return battertyInfo.ToString();
        }
    }
}

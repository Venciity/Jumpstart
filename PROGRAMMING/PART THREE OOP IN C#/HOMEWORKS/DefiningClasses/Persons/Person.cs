namespace Persons
{
    using System;
    class Person
    {
        private string name;
        private byte age;
        private string address;

        public Person(string name, byte age, string address = null)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name caanot be empty or null");
                }

                this.name = value;
            }
        }

        public byte Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 1 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age must be in range: [1...120]");
                }

                this.age = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (value != null && !value.Contains("Town"))
                {
                    throw new ArgumentException("Address", "Address must contains \"Town\"");
                }

                this.address = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name:{0}, Age:{1}", this.Name, this.Age) +
                (this.Address == null ? "" : ", Address:" + this.Address);
        }
    }
}

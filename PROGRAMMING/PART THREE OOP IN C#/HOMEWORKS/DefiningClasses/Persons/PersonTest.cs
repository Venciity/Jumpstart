namespace Persons
{
    using System;
    class PersonTest
    {
        static void Main(string[] args)
        {
            Person mitko = new Person("Dimitar", 18, "Town - Ruse");
            Person rado = new Person("Radostin", 22);
            Console.WriteLine(mitko);
            Console.WriteLine(rado);
        }
    }
}

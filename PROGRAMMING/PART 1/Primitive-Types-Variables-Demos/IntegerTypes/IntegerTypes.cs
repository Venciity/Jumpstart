using System;

class IntegerTypes
{
	static void Main()
	{
        byte students = 180;
        ushort citiesInTheUnitedStates = 19355;
        uint color = 0xFF87CEEB; //sky blue in ARGB format
        ulong facebookUsers = 1500000000; //1.5 billion

		Console.WriteLine("There are {0} students in this classroom who know that the USA has {1} cities",
			students, citiesInTheUnitedStates);

        Console.WriteLine("The color of the sky in decimal looks like this {0}", color);

        Console.WriteLine("The members of Facebook are over {0}", facebookUsers);
	}
}

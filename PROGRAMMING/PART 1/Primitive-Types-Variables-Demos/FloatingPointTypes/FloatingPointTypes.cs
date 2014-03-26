using System;

class FloatingPointTypes
{
	static void Main()
	{
		float floatPI = 3.141592653589793238f;
		double doublePI = 3.141592653589793238;
		Console.WriteLine("Float PI is: {0}", floatPI);
		Console.WriteLine("Double PI is: {0}", doublePI);

		// Example of comparison abnormality
        Console.WriteLine();

        float v1 = 1111000001532f;
        float v2 = 1111000009354f;
	    bool equal = v1 == v2;

        Console.WriteLine("1111000001532f == 1111000009354f ? Answer={0}", equal);  //True

        Console.WriteLine();

	    float aFloat = 1.0f;
        float bFloat = 0.33f;
	    float sumFloat = 1.33f;
	    bool equalFloat = (aFloat + bFloat == sumFloat);

        Console.WriteLine("1.0f + 0.33f == 1.33f ? Answer={0}", equalFloat); //False --Whaaaat The F?!?!?!?

		// Decimal numbers do not have comparison abnormalities
        Console.WriteLine();

		decimal aDecimal = 1.0M;
		decimal bDecimal = 0.33M;
		decimal sumDecimal = 1.33M;
		bool equalDecimal = (aDecimal + bDecimal == sumDecimal);

        Console.WriteLine("1.0M + 0.33M == 1.33M ? Answer={0}", equalDecimal);
	}
}

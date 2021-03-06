using System;

class Characters
{
	static void Main()
	{
        Console.OutputEncoding = System.Text.Encoding.UTF8;

		char symbol = 'a';
		Console.WriteLine("The code of '{0}' is: {1}",
			symbol, (ushort) symbol);

        symbol = '\u0061'; //0x0061 is 97 in decimal which is the code of the latin letter 'a'
        Console.WriteLine("This also writes the letter '{0}'", symbol);

		symbol = 'b';
		Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (ushort)symbol);

		symbol = 'A';
		Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (ushort)symbol);

        symbol = 'Щ';
        Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (ushort)symbol);

	    symbol = 'Ѫ'; // '\u046A'; // Cyrillic letter big Yus. Must use Consolas font in order to appear properly in the console
		Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (ushort)symbol);

	    symbol = '생'; // '\0c0dd' // Hangul syllable meaning student. Don't work with the standard console fonts
        Console.WriteLine("The code of '{0}' is: {1}",
            symbol, (ushort)symbol);
	}
}

using System;

class StringLiterals
{
	static void Main()
	{
		// Here is a string literal using escape sequences
		string quotation = "I am a really big fan of \"Back To The Future\" movie!";
		string path = "C:\\WINNT\\Darts\\Darts.exe";
		Console.WriteLine(quotation);
		Console.WriteLine(path);
		
		// Here is an example of the usage of @
		quotation = @"Yeah, me too. So I bet you would like ""Terminator"" as well.";
		path = @"C:\WINNT\Darts\Darts.exe";
		Console.WriteLine(quotation);
		Console.WriteLine(path);

        string someString = @"some

424234


text";
        Console.WriteLine(someString);
	}
}

string input = Console.ReadLine();

Console.WriteLine(string.Join("", input.Where(char.IsDigit)));
Console.WriteLine(string.Join("", input.Where(char.IsLetter)));
Console.WriteLine(string.Join("", input.Where(x => !char.IsDigit(x) && !char.IsLetter(x))));


//string input = Console.ReadLine();

//string numbers = string.Empty;
//string letters = string.Empty;
//string symbols = string.Empty;

//foreach (var ch in input)
//{
//	if (char.IsDigit(ch))
//	{
//		numbers += ch;
//	}
//	else if (char.IsLetter(ch))
//	{
//		letters += ch;
//	}
//	else
//	{
//		symbols += ch;
//	}
//}

//Console.WriteLine(numbers);
//Console.WriteLine(letters);
//Console.WriteLine(symbols);
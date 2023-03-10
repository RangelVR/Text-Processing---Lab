string input = Console.ReadLine();
string secondInput = Console.ReadLine();

while (secondInput.Contains(input))
{
    secondInput = secondInput.Replace(input, "");
}

Console.WriteLine(secondInput);

//string input = Console.ReadLine();
//string secondInput = Console.ReadLine();

//while (secondInput.Contains(input))
//{
//    int startIndex = secondInput.IndexOf(input);
//    secondInput = secondInput.Remove(startIndex, input.Length);
//}

//Console.WriteLine(secondInput);
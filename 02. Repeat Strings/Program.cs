using System.Text;

string[] input = Console.ReadLine().Split();

StringBuilder sb = new StringBuilder();

foreach (var word in input)
{
	for (int i = 0; i < word.Length; i++)
	{
        sb.Append(word);
    }
}

Console.WriteLine(sb);
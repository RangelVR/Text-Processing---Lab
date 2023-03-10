

string input = Console.ReadLine();

while (input != "end")
{
    char[] revInput = input.Reverse().ToArray();
    Console.WriteLine($"{input} = {string.Join("", revInput)}");

    input = Console.ReadLine();
}

//using System.Text;

//string input = Console.ReadLine();


//while (input != "end")
//{
//    StringBuilder sb = new StringBuilder();

//    for (int i = input.Length - 1; i >= 0; i--)
//    {
//        sb.Append(input[i]);
//    }

//    Console.WriteLine($"{input} = {sb}");

//    input = Console.ReadLine();
//}

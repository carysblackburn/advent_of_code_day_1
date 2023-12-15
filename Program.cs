//**Part 1**
//
//long total = 0;

//while(Console.ReadLine() is { } line)
//{
//    int firstDigit = int.Parse(line.First(line => char.IsDigit(line)).ToString());
//    int lastDigit = int.Parse(line.Last(line => char.IsDigit(line)).ToString());

//    string newNum = firstDigit + "" + lastDigit;

//    total += int.Parse(newNum);
//}

//Console.WriteLine("total is: " + total);
//****************************************************************************************************

long total = 0;
string convertedLine = "";

while (Console.ReadLine() is { } line)
{
    convertedLine = line
       .Replace("one", "o1e")
       .Replace("two", "t2o")
       .Replace("three", "t3e")
       .Replace("four", "f4r")
       .Replace("five", "f5e")
       .Replace("six", "s6x")
       .Replace("seven", "s7n")
       .Replace("eight", "e8t")
       .Replace("nine", "n9e");

    int firstDigit = int.Parse(convertedLine.First(convertedLine => char.IsDigit(convertedLine)).ToString());
    int lastDigit = int.Parse(convertedLine.Last(convertedLine => char.IsDigit(convertedLine)).ToString());

    string newNum = firstDigit + "" + lastDigit;

    total += int.Parse(newNum);
}

Console.WriteLine("total is: " + total);
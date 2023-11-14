int GetNumber(string message)
{
    System.Console.WriteLine($"Введите число {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int M = GetNumber("Введите число M");
int N = GetNumber("Введите число N");
int sum = 0;

while (M<=N)
{
    sum = sum + M;
    M++;
}

System.Console.WriteLine(sum);
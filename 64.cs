int GetNumber(string message)
{
    System.Console.WriteLine($"Введите число {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}


int RecMetod(int N)
        {
            if (N != 1)
            {
                System.Console.WriteLine(N);
                N--;
                return RecMetod(N);
            }
            return N;
        }

int N = GetNumber("Введите число N");
System.Console.WriteLine( RecMetod(N));
//Напишите программу 
//вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(M,N);
void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N)); 
}
int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}

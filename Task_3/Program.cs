// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N=Promt("Введите число больше 0: ");
System.Console.Write($"{N}-> ");
for(int i=1; i<N; i++)
{
     System.Console.Write($"{Math.Pow(i,3)}, ");
}
if (N>0)
{
    System.Console.Write($"{Math.Pow(N,3)}");
}
else
{
    System.Console.Write($"Число {N} меньше 0");
}
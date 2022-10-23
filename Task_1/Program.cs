// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Promt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return number;
}
string number = Promt("Введите целое положительное число: ");
int length = number.Length;
int num = Convert.ToInt32(number);
int temp = num;
int sum = 0;
for (int i = 1; i <= length; i++)
{
    int ost = temp % 10;
    temp = temp / 10;
    sum = sum * 10 + ost;
}
if (num == sum)
{
    System.Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {num} не является палиндромом");
}
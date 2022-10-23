// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number >= 100000)
    {
        System.Console.WriteLine($"Число {number} не пятизначное");
        return false;
    }
    return true;
}

int number = Promt("Введите пятизначное число: ");

bool ValidatePal(int a, int b)
{
    if (a != b)
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
        return false;
    }
    return true;
}

if (ValidateNumber(number))
{
    int a = number / 10000;
    int b = number % 10;
    if (ValidatePal(a, b))
    {
        a = number / 1000 % 10;
        b = number / 10 % 10;
        if (ValidatePal(a, b))
        {
            System.Console.WriteLine($"Число {number} является палиндромом");
        }

    }
}
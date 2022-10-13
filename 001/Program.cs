// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validatenumber(int A)
{
    if (A < 10000 || A > 99999)
    {
        Console.WriteLine("Число не соответствует условию задачи");
        return false;
    }
    return true;
}

int A = Prompt("Введите пятизначное число:   ");
int RightNumber = A;
int LeftNumber = 0;
if (!Validatenumber(A))
{
    return;
}
while (A > 0)
{
    int EndNumber = A % 10;
    LeftNumber = LeftNumber * 10 + EndNumber;
    A = A / 10;
}
if (LeftNumber == RightNumber)
{
    Console.WriteLine($"Ваше число: - палиндром.");
}
else
{
    Console.WriteLine($"Ваше число: - НЕ палиндром.");
}

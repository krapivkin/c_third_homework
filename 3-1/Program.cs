//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите любое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999)
{
    Console.WriteLine("Вы ввели некорректное число, введите пятизначное число");
}
if (number > 99999)
{
    Console.WriteLine("Вы ввели некорректное число, введите пятизначное число");
}

int firstDigit = number / 10000;
int secondDigit = (number / 1000) % 10;
int thirdDigit = (number / 100) % 10;
int fourthDigit = (number / 10) % 10;
int fifthDigit = number % 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.WriteLine($"{number} является палиндромом");
}
if (firstDigit != fifthDigit || secondDigit != fourthDigit)

{
    Console.WriteLine($"{number} не является палиндромом");
}
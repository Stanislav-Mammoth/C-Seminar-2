// Программа принимает на вход трехзначное число и возращает вторую цифру этого числа

int SecondNumber(int number)
{
    int result = (number/10)%10;
    return result;
}
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(number);
Console.WriteLine($"Вторая цифра:{result}");
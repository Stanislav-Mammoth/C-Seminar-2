// Программа выводит третью цифру числа или сообщает что третьей цифры нет

int ThirdNumber(int number)
{
        while (number > 1000)
    {
            number = number / 10;
    }
            int result = number % 10;         
            return result;           
}
Console.WriteLine("Введите число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 99) Console.WriteLine("Нет третьей цифры");
else{
int result = ThirdNumber(number);
Console.WriteLine($"Третья цифра:{result}");
}
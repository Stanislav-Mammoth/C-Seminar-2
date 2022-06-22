// Программа принимает на вход цифру обозначающую день недели и проверяет является ли день выходным

void WeekNumber(int number)
{   
    if(number == 6 || number == 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий день");      
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7) Console.WriteLine("Число не должно быть больше 7");
else WeekNumber(number);

int AckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (firstNumber > 0 && secondNumber == 0)
    {
        return AckermannFunction(firstNumber - 1, 1);
    }
    else
    {
        return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
    }
}
Console.Write("Введите первый параметр функции Аккермана: ");
int firstParameter = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй параметр функции Аккермана: ");
int secondParameter = Convert.ToInt32(Console.ReadLine());

if (firstParameter < 0 && secondParameter < 0)
{
    Console.WriteLine("При отрицательных значениях параметра функция Аккермана не имеет значений.");
}
else
{
    int function = AckermannFunction(firstParameter, secondParameter);
    Console.WriteLine($"Значение функции Аккермана при параметрах {firstParameter} и {secondParameter} равно {function}");
}
Console.ReadLine();
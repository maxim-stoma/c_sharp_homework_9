void NaturalNumbersMN(int firstNumber, int secondNumber)
{
    if (firstNumber + 1 == secondNumber)
    {
        return;
    }
    else
    {
        Console.Write(firstNumber);
        if (firstNumber > secondNumber)
        {
            Console.Write(", ");
        }
        NaturalNumbersMN(firstNumber - 1, secondNumber);
    }
}
Console.Write("Введите первое число: ");
int leftBorder = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int rightBorder = Convert.ToInt32(Console.ReadLine());
NaturalNumbersMN(leftBorder, rightBorder);
Console.ReadLine();
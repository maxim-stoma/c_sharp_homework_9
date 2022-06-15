int SumBetweenMN(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    return firstNumber + SumBetweenMN(firstNumber + 1, secondNumber);
}
Console.Write("Введите первое число: ");
int leftBorder = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int rightBorder = Convert.ToInt32(Console.ReadLine());
int sum = SumBetweenMN(leftBorder, rightBorder);
Console.WriteLine(sum);
Console.ReadLine();
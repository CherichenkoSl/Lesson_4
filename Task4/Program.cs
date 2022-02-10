static int GetFibonacci(int number)
{
    if (number == 0 || number == 1)
    {
        return number;
    }
    return GetFibonacci(number - 1) + GetFibonacci(number - 2);
}
int number = 7;
Console.WriteLine(GetFibonacci(number));
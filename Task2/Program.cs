static int Summary (string numbers)
{
    int sum=0;
    int spaceCount = 0;
    for(int count=0; count<numbers.Length; count++)
    {
        if(numbers[count]==' ')
        {
            spaceCount++;
        }
    }
    string[] number = new string[spaceCount+1];
    int start = 0;
    string subString ="";
    int wordCounter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
       if (numbers[i] == ' ')
        {
        for(int j= start; j <i;j++)
            {
                subString = subString+ numbers[j]; 
            }
            number[wordCounter] = subString;
            subString = "";
            wordCounter++;
            start = i + 1;
        }
       if(i== numbers.Length-1)
        {
            for (int a = start; a <= i; a++)
            {
                subString = subString + numbers[a];
            }
            number[wordCounter] = subString;
        }
    }
    for (int b = 0; b < number.Length; b++)
    {
        sum = sum + Convert.ToInt32(number[b]);
    }
    return sum;
}
Console.WriteLine("Введите ряд чисел:");
string num = Console.ReadLine();
Console.WriteLine($"Сумма: {Summary(num)}");

static string GetFullName(string firstName, string lastName, string patronymic)
{
    string FullName = $"{lastName} {firstName} {patronymic}";
    return FullName;
}
Console.WriteLine($"ФИО пользователя: {GetFullName("Владислав", "Суворов", "Валерьевич")}");
Console.WriteLine($"ФИО пользователя: {GetFullName("Вячеслав", "Чериченко", "Владимирович")}");
Console.WriteLine($"ФИО пользователя: {GetFullName("Иван","Иванов","Иванович")}");
Console.WriteLine($"ФИО пользователя: {GetFullName("Дмитрий", "Тимофеев", "Юрьевич")}");
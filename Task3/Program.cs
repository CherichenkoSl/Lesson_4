Console.WriteLine("Введите номер месяца:");
int month =Convert.ToInt32(Console.ReadLine());
if (month <1 || month >12)
{
    Console.WriteLine("Ошибка: введите число от 1 до 12");
}
else
{
    Seasons seasons = Season(month);
    string name = NameOfSeason(seasons);
    Console.WriteLine(name);
}
static Seasons Season(int month)
{
    switch (month)
    {
        case 1:
        case 2:
        case 12:
            return Seasons.Winter;
        case 3:
        case 4:
        case 5:
            return Seasons.Spring;
        case 6:
        case 7:
        case 8:
            return Seasons.Summer;
        default:
            return Seasons.Autumn;
    }
}
static string NameOfSeason (Seasons season)
{
    switch (season)
    {
       case Seasons.Winter:
            return "Зима";
       case Seasons.Spring:
            return "Весна";
       case Seasons.Summer:
            return "Лето";
       default:
            return "Осень";
    }
}
enum Seasons
{
    Winter,
    Spring,
    Summer,
    Autumn
}


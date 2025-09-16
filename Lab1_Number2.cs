public class Lab2
{
    // 2. Безопасное деление
    public double SafeDiv(int x, int y)
    {
        if (y == 0)
            return 0;
        return (double)x / y;
    }

    // 4. Строка сравнения
    public string MakeDecision(int x, int y)
    {
        if (x > y)
            return $"{x} > {y}";
        else if (x < y)
            return $"{x} < {y}";
        else
            return $"{x} == {y}";
    }

    // 6. Тройная сумма
    public bool Sum3(int x, int y, int z)
    {
        if (x + y == z) return true;
        if (x + z == y) return true;
        if (y + z == x) return true;
        return false;
    }

    // 8. Возраст
    public string Age(int x)
    {
        int lastDigit = x % 10;
        int lastTwoDigits = x % 100;

        if (lastDigit == 1 && lastTwoDigits != 11)
            return $"{x} год";
        else if ((lastDigit >= 2 && lastDigit <= 4) && !(lastTwoDigits >= 12 && lastTwoDigits <= 14))
            return $"{x} года";
        else
            return $"{x} лет";
    }

    // 10. Вывод дней недели
    public void PrintDays(string x)
    {
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }

    public static void Main(string[] args)
    {
        Lab2 lab = new Lab2();

        Console.WriteLine("Задание 2: Безопасное деление");
        Console.Write("Введите x -> ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y -> ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {lab.SafeDiv(x2, y2)}");

        Console.WriteLine("\nЗадание 4: Строка сравнения");
        Console.Write("Введите x -> ");
        int x4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y -> ");
        int y4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {lab.MakeDecision(x4, y4)}");

        Console.WriteLine("\nЗадание 6: Тройная сумма");
        Console.Write("Введите x -> ");
        int x6 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите y -> ");
        int y6 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите z -> ");
        int z6 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {lab.Sum3(x6, y6, z6)}");

        Console.WriteLine("\nЗадание 8: Возраст");
        Console.Write("Введите возраст -> ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(lab.Age(age));

        Console.WriteLine("\nЗадание 10: Дни недели");
        Console.Write("Введите день недели -> ");
        string day = Console.ReadLine()!;
        lab.PrintDays(day);
    }
}
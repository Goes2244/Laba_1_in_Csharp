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

    // 8. Возраст (с проверкой)
    public string Age(int x)
    {
        if (x < 0)
            return "Возраст не может быть отрицательным!";
        
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
}
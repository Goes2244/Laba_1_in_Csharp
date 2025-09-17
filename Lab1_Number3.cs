class Lab3
{
    // Задание 2. Числа наоборот
    public static string reverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    // Задание 4. Степень числа
    public static int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    // Задание 6. Одинаковость
    public static bool equalNum(int x)
    {
        int lastDigit = x % 10;
        while (x > 0)
        {
            if (x % 10 != lastDigit)
                return false;
            x /= 10;
        }
        return true;
    }

    // Задание 8. Левый треугольник
    public static void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Задание 10. Угадайка (с проверкой ввода)
    public static void guessGame()
    {
        Random rnd = new Random();
        int secret = rnd.Next(0, 10);
        int attempts = 0;
        int guess = -1;

        while (guess != secret)
        {
            Console.Write("Введите число от 0 до 9: ");
            string input = Console.ReadLine()!;
            
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Ошибка! Введите целое число.");
                continue;
            }
            
            if (guess < 0 || guess > 9)
            {
                Console.WriteLine("Число должно быть от 0 до 9!");
                continue;
            }

            attempts++;

            if (guess == secret)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine($"Вы отгадали число за {attempts} попытку(ки)");
            }
            else
            {
                Console.WriteLine("Вы не угадали, попробуйте снова.");
            }
        }
    }
}
class Program
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

    // Задание 10. Угадайка
    public static void guessGame()
    {
        Random rnd = new Random();
        int secret = rnd.Next(0, 10);
        int attempts = 0;
        int guess = -1;

        while (guess != secret)
        {
            Console.Write("Введите число от 0 до 9: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess == secret)
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine($"Вы отгадали число за {attempts} попытки");
            }
            else
            {
                Console.WriteLine("Вы не угадали, попробуйте снова.");
            }
        }
    }

    public static void Main(string[] args)
    {
        // Задание 2
        Console.WriteLine("Задание 2: Числа наоборот");
        Console.Write("Введите число -> ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(reverseListNums(n1));

        // Задание 4
        Console.WriteLine("\nЗадание 4: Степень числа");
        Console.Write("Введите число -> ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень -> ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(pow(x, y));

        // Задание 6
        Console.WriteLine("\nЗадание 6: Одинаковость");
        Console.Write("Введите число -> ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(equalNum(n2));

        // Задание 8
        Console.WriteLine("\nЗадание 8: Левый треугольник");
        Console.Write("Введите число -> ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        leftTriangle(n3);

        // Задание 10
        Console.WriteLine("\nЗадание 10: Угадайка");
        guessGame();
    }
}
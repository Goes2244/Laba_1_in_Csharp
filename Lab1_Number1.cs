public class Lab1
{
    // 2. Сумма знаков
    public int sumLastNums(int x)
    {
        int last = x % 10;
        int prelast = (x / 10) % 10;
        return last + prelast;
    }

    // 4. Есть ли позитив
    public bool isPositive(int x)
    {
        return x > 0;
    }

    // 6. Большая буква
    public bool isUpperCase(char x)
    {
        if (x >= 'A' && x <= 'Z')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 8. Делитель
    public bool isDivisor(int a, int b)
    {
        if ((a != 0 && b % a == 0) || (b != 0 && a % b == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // 10. Многократный вызов
    public int lastNumSum(int a, int b)
    {
        int LastA = a % 10;
        int LastB = b % 10;
        return LastA + LastB;
    }

    public static void Main(string[] args)
    {
        Lab1 lab = new Lab1();

        Console.WriteLine("Задание 2: Введите число -> ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма двух последних цифр = " + lab.sumLastNums(num2));

        Console.WriteLine("\nЗадание 4: Введите число -> ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Позитивненько ?) -> " + lab.isPositive(num4));

        Console.WriteLine("\nЗадание 6: Введите символ -> ");
        char ch6 = Convert.ToChar(Console.ReadLine()!);
        Console.WriteLine("Заглавная ли буква ? " + lab.isUpperCase(ch6));

        Console.WriteLine("\nЗадание 8: Введите число a -> ");
        int a8 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b -> ");
        int b8 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Одно число делит другое ? " + lab.isDivisor(a8, b8));

        Console.WriteLine("\nЗадание 10: Введите первое число -> ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число -> ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int result = lab.lastNumSum(n1, n2);

        Console.WriteLine("Введите третье число -> ");
        int n3 = Convert.ToInt32(Console.ReadLine());
        result = lab.lastNumSum(result, n3);

        Console.WriteLine("Введите четвертое число -> ");
        int n4 = Convert.ToInt32(Console.ReadLine());
        result = lab.lastNumSum(result, n4);

        Console.WriteLine("Введитн пятое число -> ");
        int n5 = Convert.ToInt32(Console.ReadLine());
        result = lab.lastNumSum(result, n5);

        Console.WriteLine("Результат: " + result);
    }
}
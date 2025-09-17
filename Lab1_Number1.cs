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
}
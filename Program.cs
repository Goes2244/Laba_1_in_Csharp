namespace Labs_C_;

public class Program
{
    static int ReadInt(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out result))
                return result;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static char ReadChar(string prompt)
    {
        char result;
        while (true)
        {
            Console.Write(prompt);
            if (char.TryParse(Console.ReadLine(), out result))
                return result;
            Console.WriteLine("Ошибка! Введите один символ.");
        }
    }

    static string ReadString(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine() ?? "";
    }

    static int[] ReadIntArray(string sizePrompt, string elementPrompt)
    {
        int size = ReadInt(sizePrompt);
        int[] array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            array[i] = ReadInt($"{elementPrompt}[{i}] = ");
        }
        
        return array;
    }

    static void Main(string[] args)
    {
        Lab1 lab1 = new Lab1();
        Lab2 lab2 = new Lab2();
        Lab4 lab4 = new Lab4();

        Console.WriteLine("=== Лабораторная работа 1 ===");
        
        // Lab1 - Задание 2
        int num2 = ReadInt("\nЗадание 2: Введите число -> ");
        Console.WriteLine("Сумма двух последних цифр = " + lab1.sumLastNums(num2));

        // Lab1 - Задание 4
        int num4 = ReadInt("\nЗадание 4: Введите число -> ");
        Console.WriteLine("Позитивненько ?) -> " + lab1.isPositive(num4));

        // Lab1 - Задание 6
        char ch6 = ReadChar("\nЗадание 6: Введите символ -> ");
        Console.WriteLine("Заглавная ли буква ? " + lab1.isUpperCase(ch6));

        // Lab1 - Задание 8
        int a8 = ReadInt("\nЗадание 8: Введите число a -> ");
        int b8 = ReadInt("Введите число b -> ");
        Console.WriteLine("Одно число делит другое ? " + lab1.isDivisor(a8, b8));

        // Lab1 - Задание 10
        Console.WriteLine("\nЗадание 10:");
        int n1 = ReadInt("Введите первое число -> ");
        int n2 = ReadInt("Введите второе число -> ");
        int result = lab1.lastNumSum(n1, n2);

        int n3 = ReadInt("Введите третье число -> ");
        result = lab1.lastNumSum(result, n3);

        int n4 = ReadInt("Введите четвертое число -> ");
        result = lab1.lastNumSum(result, n4);

        int n5 = ReadInt("Введите пятое число -> ");
        result = lab1.lastNumSum(result, n5);

        Console.WriteLine("Результат: " + result);

        Console.WriteLine("\n\n=== Лабораторная работа 2 ===");
        
        // Lab2 - Задание 2
        Console.WriteLine("Задание 2: Безопасное деление");
        int x2 = ReadInt("Введите x -> ");
        int y2 = ReadInt("Введите y -> ");
        Console.WriteLine($"Результат: {lab2.SafeDiv(x2, y2)}");

        // Lab2 - Задание 4
        Console.WriteLine("\nЗадание 4: Строка сравнения");
        int x4 = ReadInt("Введите x -> ");
        int y4 = ReadInt("Введите y -> ");
        Console.WriteLine($"Результат: {lab2.MakeDecision(x4, y4)}");

        // Lab2 - Задание 6
        Console.WriteLine("\nЗадание 6: Тройная сумма");
        int x6 = ReadInt("Введите x -> ");
        int y6 = ReadInt("Введите y -> ");
        int z6 = ReadInt("Введите z -> ");
        Console.WriteLine($"Результат: {lab2.Sum3(x6, y6, z6)}");

        // Lab2 - Задание 8
        Console.WriteLine("\nЗадание 8: Возраст");
        int age = ReadInt("Введите возраст -> ");
        if (age < 0)
        {
            Console.WriteLine("Возраст не может быть отрицательным!");
        }
        else
        {
            Console.WriteLine(lab2.Age(age));
        }

        // Lab2 - Задание 10
        Console.WriteLine("\nЗадание 10: Дни недели");
        string day = ReadString("Введите день недели -> ");
        lab2.PrintDays(day);

        Console.WriteLine("\n\n=== Лабораторная работа 3 ===");
        
        // Lab3 - Задание 2
        Console.WriteLine("Задание 2: Числа наоборот");
        int n1_lab3 = ReadInt("Введите число -> ");
        if (n1_lab3 < 0)
        {
            Console.WriteLine("Число должно быть неотрицательным!");
        }
        else
        {
            Console.WriteLine(Lab3.reverseListNums(n1_lab3));
        }

        // Lab3 - Задание 4
        Console.WriteLine("\nЗадание 4: Степень числа");
        int x_lab3 = ReadInt("Введите число -> ");
        int y_lab3 = ReadInt("Введите степень -> ");
        if (y_lab3 < 0)
        {
            Console.WriteLine("Степень должна быть неотрицательной!");
        }
        else
        {
            Console.WriteLine(Lab3.pow(x_lab3, y_lab3));
        }

        // Lab3 - Задание 6
        Console.WriteLine("\nЗадание 6: Одинаковость");
        int n2_lab3 = ReadInt("Введите число -> ");
        Console.WriteLine(Lab3.equalNum(n2_lab3));

        // Lab3 - Задание 8
        Console.WriteLine("\nЗадание 8: Левый треугольник");
        int n3_lab3 = ReadInt("Введите число -> ");
        if (n3_lab3 < 1 || n3_lab3 > 20)
        {
            Console.WriteLine("Число должно быть от 1 до 20!");
        }
        else
        {
            Lab3.leftTriangle(n3_lab3);
        }

        // Lab3 - Задание 10
        Console.WriteLine("\nЗадание 10: Угадайка");
        Lab3.guessGame();

        Console.WriteLine("\n\n=== Лабораторная работа 4 ===");
        
        // Ввод основного массива
        int[] arr = ReadIntArray("Введите длину массива -> ", "arr");

        // Lab4 - Задание 2
        Console.WriteLine("\nЗадание 2: Поиск последнего значения");
        int x_lab4 = ReadInt("Введите число для поиска -> ");
        int lastIndex = lab4.findLast(arr, x_lab4);
        Console.WriteLine($"Индекс последнего вхождения: {lastIndex}");

        // Lab4 - Задание 4
        Console.WriteLine("\nЗадание 4: Добавление в массив");
        int val = ReadInt("Введите число для вставки -> ");
        int pos = ReadInt("Введите позицию вставки -> ");
        
        if (pos < 0 || pos > arr.Length)
        {
            Console.WriteLine("Неверная позиция вставки!");
        }
        else
        {
            int[] arrAdded = lab4.add(arr, val, pos);
            lab4.PrintArray(arrAdded);
        }

        // Lab4 - Задание 6
        Console.WriteLine("\nЗадание 6: Реверс массива");
        int[] arrCopy = (int[])arr.Clone(); // создаем копию для реверса
        lab4.reverse(arrCopy);
        lab4.PrintArray(arrCopy);

        // Lab4 - Задание 8
        Console.WriteLine("\nЗадание 8: Объединение массивов");
        int[] arr2 = ReadIntArray("Введите длину второго массива -> ", "arr2");
        int[] arrConcat = lab4.concat(arr, arr2);
        lab4.PrintArray(arrConcat);

        // Lab4 - Задание 10
        Console.WriteLine("\nЗадание 10: Удалить негативные элементы");
        int[] arrNoNeg = lab4.deleteNegative(arrConcat);
        lab4.PrintArray(arrNoNeg);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
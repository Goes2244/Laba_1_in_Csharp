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
        AllLabs labs = new AllLabs();

        Console.WriteLine("=== Лабораторная работа 1 ===");
        
        // 2. Сумма знаков
        int num2 = ReadInt("\nЗадание 2: Введите число -> ");
        Console.WriteLine("Сумма двух последних цифр = " + labs.SumLastNums(num2));

        // 4. Есть ли позитив
        int num4 = ReadInt("\nЗадание 4: Введите число -> ");
        Console.WriteLine("Позитивненько ?) -> " + labs.IsPositive(num4));

        // 6. Большая буква
        char ch6 = ReadChar("\nЗадание 6: Введите символ -> ");
        Console.WriteLine("Заглавная ли буква ? " + labs.IsUpperCase(ch6));

        // 8. Делитель
        int a8 = ReadInt("\nЗадание 8: Введите число a -> ");
        int b8 = ReadInt("Введите число b -> ");
        Console.WriteLine("Одно число делит другое ? " + labs.IsDivisor(a8, b8));

        // 10. Многократный вызов
        Console.WriteLine("\nЗадание 10:");
        int n1 = ReadInt("Введите первое число -> ");
        int n2 = ReadInt("Введите второе число -> ");
        int result = labs.LastNumSum(n1, n2);

        result = labs.LastNumSum(result, ReadInt("Введите третье число -> "));
        result = labs.LastNumSum(result, ReadInt("Введите четвертое число -> "));
        result = labs.LastNumSum(result, ReadInt("Введите пятое число -> "));

        Console.WriteLine("Результат: " + result);

        Console.WriteLine("\n\n=== Лабораторная работа 2 ===");
        
        // 2. Безопасное деление
        Console.WriteLine("Задание 2: Безопасное деление");
        int x2 = ReadInt("Введите x -> ");
        int y2 = ReadInt("Введите y -> ");
        Console.WriteLine($"Результат: {labs.SafeDiv(x2, y2)}");

        // 4. Строка сравнения
        Console.WriteLine("\nЗадание 4: Строка сравнения");
        int x4 = ReadInt("Введите x -> ");
        int y4 = ReadInt("Введите y -> ");
        Console.WriteLine($"Результат: {labs.MakeDecision(x4, y4)}");

        // 6. Тройная сумма
        Console.WriteLine("\nЗадание 6: Тройная сумма");
        int x6 = ReadInt("Введите x -> ");
        int y6 = ReadInt("Введите y -> ");
        int z6 = ReadInt("Введите z -> ");
        Console.WriteLine($"Результат: {labs.Sum3(x6, y6, z6)}");

        // 8. Возраст
        Console.WriteLine("\nЗадание 8: Возраст");
        int age = ReadInt("Введите возраст -> ");
        Console.WriteLine(labs.Age(age));

        // 10. Дни недели
        Console.WriteLine("\nЗадание 10: Дни недели");
        string day = ReadString("Введите день недели -> ");
        labs.PrintDays(day);

        Console.WriteLine("\n\n=== Лабораторная работа 3 ===");
        
        // 2. Числа наоборот
        Console.WriteLine("Задание 2: Числа наоборот");
        int n1_lab3 = ReadInt("Введите число -> ");
        if (n1_lab3 < 0)
            Console.WriteLine("Число должно быть неотрицательным!");
        else
            Console.WriteLine(labs.ReverseListNums(n1_lab3));

        // 4. Степень числа
        Console.WriteLine("\nЗадание 4: Степень числа");
        int x_lab3 = ReadInt("Введите число -> ");
        int y_lab3 = ReadInt("Введите степень -> ");
        if (y_lab3 < 0)
            Console.WriteLine("Степень должна быть неотрицательной!");
        else
            Console.WriteLine(labs.Pow(x_lab3, y_lab3));

        // 6. Одинаковость
        Console.WriteLine("\nЗадание 6: Одинаковость");
        int n2_lab3 = ReadInt("Введите число -> ");
        Console.WriteLine(labs.EqualNum(n2_lab3));

        // 8. Левый треугольник
        Console.WriteLine("\nЗадание 8: Левый треугольник");
        int n3_lab3 = ReadInt("Введите число -> ");
        if (n3_lab3 < 1 || n3_lab3 > 20)
            Console.WriteLine("Число должно быть от 1 до 20!");
        else
            labs.LeftTriangle(n3_lab3);

        // 10. Угадайка
        Console.WriteLine("\nЗадание 10: Угадайка");
        labs.GuessGame();

        Console.WriteLine("\n\n=== Лабораторная работа 4 ===");
        
        int[] arr = ReadIntArray("Введите длину массива -> ", "arr");

        // 2. Поиск последнего значения
        Console.WriteLine("\nЗадание 2: Поиск последнего значения");
        int x_lab4 = ReadInt("Введите число для поиска -> ");
        int lastIndex = labs.FindLast(arr, x_lab4);
        Console.WriteLine($"Индекс последнего вхождения: {lastIndex}");

        // 4. Добавление в массив
        Console.WriteLine("\nЗадание 4: Добавление в массив");
        int val = ReadInt("Введите число для вставки -> ");
        int pos = ReadInt("Введите позицию вставки -> ");
        
        if (pos < 0 || pos > arr.Length)
            Console.WriteLine("Неверная позиция вставки!");
        else
            labs.PrintArray(labs.AddToArray(arr, val, pos));

        // 6. Реверс массива
        Console.WriteLine("\nЗадание 6: Реверс массива");
        int[] arrCopy = (int[])arr.Clone();
        labs.ReverseArray(arrCopy);
        labs.PrintArray(arrCopy);

        // 8. Объединение массивов
        Console.WriteLine("\nЗадание 8: Объединение массивов");
        int[] arr2 = ReadIntArray("Введите длину второго массива -> ", "arr2");
        int[] arrConcat = labs.ConcatArrays(arr, arr2);
        labs.PrintArray(arrConcat);

        // 10. Удалить негативные элементы
        Console.WriteLine("\nЗадание 10: Удалить негативные элементы");
        labs.PrintArray(labs.DeleteNegative(arrConcat));

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
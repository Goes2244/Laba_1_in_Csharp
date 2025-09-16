class Lab4
{
    // 2. Поиск последнего значения
    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    // 4. Добавление в массив
    public int[] add(int[] arr, int x, int pos)
    {
        int[] result = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < result.Length; i++)
        {
            if (i == pos)
                result[i] = x;
            else
                result[i] = arr[j++];
        }
        return result;
    }

    // 6. Реверс
    public void reverse(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
    }

    // 8. Объединение
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
            result[i] = arr1[i];
        for (int i = 0; i < arr2.Length; i++)
            result[arr1.Length + i] = arr2[i];
        return result;
    }

    // 10. Удалить негатив
    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        foreach (int v in arr)
        {
            if (v >= 0)
                count++;
        }

        int[] result = new int[count];
        int index = 0;
        foreach (int v in arr)
        {
            if (v >= 0)
                result[index++] = v;
        }
        return result;
    }

    public void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }

    public static void Main(string[] args)
    {
        Lab4 lab = new Lab4();

        // Ввод массива
        Console.WriteLine("Введите длину массива ->");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Задание 2: Поиск последнего значения
        Console.WriteLine("\nЗадание 2: Поиск последнего значения");
        Console.Write("Введите число для поиска -> ");
        int x = Convert.ToInt32(Console.ReadLine());
        int lastIndex = lab.findLast(arr, x);
        Console.WriteLine($"Индекс последнего вхождения: {lastIndex}");

        // Задание 4: Добавление в массив
        Console.WriteLine("\nЗадание 4: Добавление в массив");
        Console.Write("Введите число для вставки -> ");
        int val = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите позицию вставки -> ");
        int pos = Convert.ToInt32(Console.ReadLine());
        int[] arrAdded = lab.add(arr, val, pos);
        lab.PrintArray(arrAdded);

        // Задание 6: Реверс
        Console.WriteLine("\nЗадание 6: Реверс массива");
        lab.reverse(arr);
        lab.PrintArray(arr);

        // Задание 8: Объединение
        Console.WriteLine("\nЗадание 8: Объединение массивов");
        Console.Write("Введите длину второго массива -> ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];
        for (int i = 0; i < n2; i++)
        {
            Console.Write($"arr2[{i}] = ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] arrConcat = lab.concat(arr, arr2);
        lab.PrintArray(arrConcat);

        // Задание 10: Удалить негатив
        Console.WriteLine("\nЗадание 10: Удалить негативные элементы");
        int[] arrNoNeg = lab.deleteNegative(arrConcat);
        lab.PrintArray(arrNoNeg);
    }
}
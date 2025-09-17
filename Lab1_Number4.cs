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
}
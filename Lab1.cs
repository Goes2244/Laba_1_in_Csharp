using System;

namespace Labs_C_
{
    public class AllLabs
    {
        // ==================== Lab1 ====================
        
        // 2. Сумма знаков - возвращает сумму двух последних цифр числа
        public int SumLastNums(int x)
        {
            int last = x % 10;
            int prelast = (x / 10) % 10;
            return last + prelast;
        }

        // 4. Есть ли позитив - проверяет, является ли число положительным
        public bool IsPositive(int x)
        {
            return x > 0;
        }

        // 6. Большая буква - проверяет, является ли символ заглавной буквой
        public bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        // 8. Делитель - проверяет, делится ли одно число на другое
        public bool IsDivisor(int a, int b)
        {
            return (a != 0 && b % a == 0) || (b != 0 && a % b == 0);
        }

        // 10. Многократный вызов - возвращает сумму последних цифр двух чисел
        public int LastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }

        // ==================== Lab2 ====================
        
        // 2. Безопасное деление - выполняет деление с проверкой деления на ноль
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
                return 0;
            return (double)x / y;
        }

        // 4. Строка сравнения - возвращает строку с результатом сравнения двух чисел
        public string MakeDecision(int x, int y)
        {
            if (x > y)
                return $"{x} > {y}";
            else if (x < y)
                return $"{x} < {y}";
            else
                return $"{x} == {y}";
        }

        // 6. Тройная сумма - проверяет, равна ли сумма двух чисел третьему
        public bool Sum3(int x, int y, int z)
        {
            return x + y == z || x + z == y || y + z == x;
        }

        // 8. Возраст - возвращает возраст с правильным окончанием
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

        // 10. Вывод дней недели - выводит дни недели начиная с заданного
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

        // ==================== Lab3 ====================
        
        // 2. Числа наоборот - возвращает строку с числами от x до 0
        public string ReverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i + " ";
            }
            return result.Trim();
        }

        // 4. Степень числа - возводит x в степень y
        public int Pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        // 6. Одинаковость - проверяет, все ли цифры в числе одинаковы
        public bool EqualNum(int x)
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

        // 8. Левый треугольник - рисует треугольник из звездочек
        public void LeftTriangle(int x)
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

        // 10. Угадайка - игра в угадывание числа
        public void GuessGame()
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

        // ==================== Lab4 ====================
        
        // 2. Поиск последнего значения - находит последнее вхождение элемента в массиве
        public int FindLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        // 4. Добавление в массив - вставляет элемент в указанную позицию
        public int[] AddToArray(int[] arr, int x, int pos)
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

        // 6. Реверс - переворачивает массив
        public void ReverseArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }

        // 8. Объединение - соединяет два массива в один
        public int[] ConcatArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
                result[i] = arr1[i];
            for (int i = 0; i < arr2.Length; i++)
                result[arr1.Length + i] = arr2[i];
            return result;
        }

        // 10. Удалить негатив - возвращает массив без отрицательных элементов
        public int[] DeleteNegative(int[] arr)
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

        // Вспомогательный метод для вывода массива
        public void PrintArray(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }
}
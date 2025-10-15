namespace Labs_C_
{
    // ==================== Lab1 - Базовые операции ====================
    public class Lab1
    {
        // 2. Сумма знаков - возвращает сумму двух последних цифр числа
        public int sumLastNums(int x)
        {
            int last = x % 10;        // Получаем последнюю цифру
            int prelast = (x / 10) % 10; // Получаем предпоследнюю цифру
            return last + prelast;     // Возвращаем их сумму
        }

        // 4. Есть ли позитив - проверяет, является ли число положительным
        public bool isPositive(int x)
        {
            return x > 0; // Простая проверка на положительность
        }

        // 6. Большая буква - проверяет, является ли символ заглавной буквой
        public bool isUpperCase(char x)
        {
            if (x >= 'A' && x <= 'Z') // Проверяем входит ли символ в диапазон A-Z
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 8. Делитель - проверяет, делится ли одно число на другое
        public bool isDivisor(int a, int b)
        {
            // Проверяем: a делит b ИЛИ b делит a (с проверкой деления на ноль)
            if ((a != 0 && b % a == 0) || (b != 0 && a % b == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 10. Многократный вызов - возвращает сумму последних цифр двух чисел
        public int lastNumSum(int a, int b)
        {
            int LastA = a % 10; // Последняя цифра первого числа
            int LastB = b % 10; // Последняя цифра второго числа
            return LastA + LastB; // Сумма последних цифр
        }
    }

    // ==================== Lab2 - Условия и ветвления ====================
    public class Lab2
    {
        // 2. Безопасное деление - выполняет деление с проверкой деления на ноль
        public double SafeDiv(int x, int y)
        {
            if (y == 0)    // Если делитель равен нулю
                return 0;  // Возвращаем 0 вместо ошибки
            return (double)x / y; // Иначе возвращаем результат деления
        }

        // 4. Строка сравнения - возвращает строку с результатом сравнения двух чисел
        public string MakeDecision(int x, int y)
        {
            if (x > y)
                return $"{x} > {y}";    // Первое больше
            else if (x < y)
                return $"{x} < {y}";    // Первое меньше
            else
                return $"{x} == {y}";   // Числа равны
        }

        // 6. Тройная сумма - проверяет, равна ли сумма двух чисел третьему
        public bool Sum3(int x, int y, int z)
        {
            if (x + y == z) return true;  // x+y=z
            if (x + z == y) return true;  // x+z=y
            if (y + z == x) return true;  // y+z=x
            return false; // Ни одно условие не выполнилось
        }

        // 8. Возраст (с проверкой) - возвращает возраст с правильным окончанием
        public string Age(int x)
        {
            if (x < 0) // Проверка на отрицательный возраст
                return "Возраст не может быть отрицательным!";
            
            int lastDigit = x % 10;       // Последняя цифра
            int lastTwoDigits = x % 100;  // Последние две цифры

            // Правила русского языка для окончаний:
            if (lastDigit == 1 && lastTwoDigits != 11) // 1, 21, 31... но не 11
                return $"{x} год";
            else if ((lastDigit >= 2 && lastDigit <= 4) && !(lastTwoDigits >= 12 && lastTwoDigits <= 14)) // 2-4, 22-24... но не 12-14
                return $"{x} года";
            else // все остальные случаи
                return $"{x} лет";
        }

        // 10. Вывод дней недели - выводит дни недели начиная с заданного
        public void PrintDays(string x)
        {
            switch (x.ToLower()) // Приводим к нижнему регистру для унификации
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник"; // Переход к следующему дню
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
                    break; // Конец цепочки
                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }
    }

    // ==================== Lab3 - Циклы и логика ====================
    public class Lab3
    {
        // Задание 2. Числа наоборот - возвращает строку с числами от x до 0
        public static string reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--) // Цикл от x до 0 включительно
            {
                result += i + " "; // Добавляем число и пробел в строку
            }
            return result.Trim(); // Убираем лишний пробел в конце
        }

        // Задание 4. Степень числа - возводит x в степень y
        public static int pow(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++) // Повторяем y раз
            {
                result *= x; // Умножаем результат на x
            }
            return result;
        }

        // Задание 6. Одинаковость - проверяет, все ли цифры в числе одинаковы
        public static bool equalNum(int x)
        {
            int lastDigit = x % 10; // Запоминаем последнюю цифру
            while (x > 0) // Пока есть цифры
            {
                if (x % 10 != lastDigit) // Если текущая цифра отличается от последней
                    return false; // Число не состоит из одинаковых цифр
                x /= 10; // Убираем последнюю цифру
            }
            return true; // Все цифры одинаковы
        }

        // Задание 8. Левый треугольник - рисует треугольник из звездочек
        public static void leftTriangle(int x)
        {
            for (int i = 1; i <= x; i++) // Для каждой строки
            {
                for (int j = 1; j <= i; j++) // Для каждой позиции в строке
                {
                    Console.Write("*"); // Выводим звездочку
                }
                Console.WriteLine(); // Переход на новую строку
            }
        }

        // Задание 10. Угадайка (с проверкой ввода) - игра в угадывание числа
        public static void guessGame()
        {
            Random rnd = new Random();
            int secret = rnd.Next(0, 10); // Случайное число от 0 до 9
            int attempts = 0; // Счетчик попыток
            int guess = -1;   // Текущая догадка

            while (guess != secret) // Пока не угадали
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine()!;
                
                // Проверка корректности ввода
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                    continue; // Повторяем запрос
                }
                
                // Проверка диапазона
                if (guess < 0 || guess > 9)
                {
                    Console.WriteLine("Число должно быть от 0 до 9!");
                    continue; // Повторяем запрос
                }

                attempts++; // Увеличиваем счетчик попыток

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

    // ==================== Lab4 - Работа с массивами ====================
    public class Lab4
    {
        // 2. Поиск последнего значения - находит последнее вхождение элемента в массиве
        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--) // Идем с конца массива
            {
                if (arr[i] == x)
                    return i; // Возвращаем индекс найденного элемента
            }
            return -1; // Элемент не найден
        }

        // 4. Добавление в массив - вставляет элемент в указанную позицию
        public int[] add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1]; // Новый массив на 1 элемент больше
            for (int i = 0, j = 0; i < result.Length; i++)
            {
                if (i == pos)
                    result[i] = x; // Вставляем новый элемент
                else
                    result[i] = arr[j++]; // Копируем старые элементы
            }
            return result;
        }

        // 6. Реверс - переворачивает массив (изменяет исходный)
        public void reverse(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n / 2; i++) // Доходим до середины массива
            {
                // Меняем местами симметричные элементы
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }
        }

        // 8. Объединение - соединяет два массива в один
        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++) // Копируем первый массив
                result[i] = arr1[i];
            for (int i = 0; i < arr2.Length; i++) // Копируем второй массив
                result[arr1.Length + i] = arr2[i];
            return result;
        }

        // 10. Удалить негатив - возвращает массив без отрицательных элементов
        public int[] deleteNegative(int[] arr)
        {
            int count = 0;
            // Сначала считаем количество неотрицательных элементов
            foreach (int v in arr)
            {
                if (v >= 0)
                    count++;
            }

            // Создаем массив нужного размера
            int[] result = new int[count];
            int index = 0;
            // Заполняем новый массив
            foreach (int v in arr)
            {
                if (v >= 0)
                    result[index++] = v;
            }
            return result;
        }

        // Вспомогательный метод для красивого вывода массива
        public void PrintArray(int[] arr)
        {
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }
    }
}
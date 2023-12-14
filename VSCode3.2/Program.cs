// Задаем массив из 10 целых чисел
        int[] array = { 2, 7, 14, 5, 10, 18, 25, 30, 8, 3 };


        // Находим количество чётных чисел в массиве
        int evenCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
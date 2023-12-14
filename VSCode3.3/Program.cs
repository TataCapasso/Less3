// Задаем массив из вещественных чисел с ненулевой дробной частью
double[] array = { 3.14, 2.71, 6.66, 4.25, 9.87, 5.55, 7.32, 8.91, 1.23, 0.99 };

// Находим максимальный и минимальный элементы массива
double maxElement = array[0];
double minElement = array[0];

 foreach (double number in array)
{
    if (number > maxElement)
    {
        maxElement = number;
    }

    if (number < minElement)
    {
        minElement = number;
    }
}

// Находим разницу между максимальным и минимальным элементами
 double difference = maxElement - minElement;

// Выводим результат
Console.WriteLine($"Максимальный элемент: {maxElement}");
Console.WriteLine($"Минимальный элемент: {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

﻿using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод строки
        Console.WriteLine("Введите строку: ");
        string put = Console.ReadLine(); // Читаем строку из ввода
        string input = put.ToLower(); // Приводим строку к нижнему регистру

        // Запрашиваем первый элемент для подсчета его вхождений
        Console.WriteLine("Введите первый элемент для подсчета его вхождений: ");
        char x = char.Parse(Console.ReadLine().ToLower()); // Читаем символ и приводим его к нижнему регистру

        // Запрашиваем второй элемент для подсчета его вхождений
        Console.WriteLine("Введите второй элемент для подсчета его вхождений: ");
        char y = char.Parse(Console.ReadLine().ToLower()); // Читаем символ и приводим его к нижнему регистру

        int countX = 0; // Переменная для хранения количества вхождений первого символа
        int countY = 0; // Переменная для хранения количества вхождений второго символа

        // Подсчет вхождений символов x и y с помощью цикла
        foreach (char c in input) // Перебираем каждый символ в строке input
        {
            if (c == x) // Проверяем, равен ли текущий символ x
            {
                countX++; // Увеличиваем счетчик для x
            }
            else if (c == y) // Проверяем, равен ли текущий символ y
            {
                countY++; // Увеличиваем счетчик для y
            }
        }

        // Выводим количество вхождений каждого символа
        Console.WriteLine("Количество вхождений {0}: {1}", x, countX);
        Console.WriteLine("Количество вхождений {0}: {1}", y, countY);
        Console.WriteLine("Нажмите любую клавишу..."); // Инструкция для завершения программы
        Console.ReadKey(); // Ожидаем нажатия клавиши
    }
}

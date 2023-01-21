// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Пример:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1. Ввод данных c проверкой
// 2. Функция вычисления и вывода на экран
// 3. Демонстрация работы функции

// 1. Ввод данных c проверкой, что введено число
int checkInput(String input) {
    int result;
    while(true) {
        if(!int.TryParse(input, out result)) {
            Console.WriteLine("Введите число.");
            input = Console.ReadLine();
        } else break;
    }
    return result;
}

Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.WriteLine("Введите целое число.");
int number = checkInput(Console.ReadLine());

// 2. Функция вычисления и вывода на экран
void printNumberQubeTable(int number) {
    while(!(number > 0)) {
        Console.WriteLine("Введите положительное число.");
        number = int.Parse(Console.ReadLine());
    }
    int count = 1;
    Console.Write(Math.Pow(count, 3));
    count++;
    while(count <= number) {
        Console.Write(", " + Math.Pow(count, 3));
        count++;
    }
}

// 3. Демонстрация работы функции
printNumberQubeTable(number);

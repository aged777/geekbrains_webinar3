// Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точук и находит расстояние между ними в 3D пространстве.
// A(3, 6, 8); B(2, 1, -7) -> 15.84
// A(7, -5, 0); B(1, -1, -9) -> 11.53

// 1. Реализация логики функции вычисления расстояния
// 2. Ввод данных
// 3. Демонстрация работы функции и вывод результата в нужном формате

// 1. Реализация логики функции вычисления расстояния
double distanceBetween2DotsIn3D(double Xa, double Ya, double Za, double Xb, double Yb, double Zb) {
    return Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2));
}

// 2. Ввод данных
// 2.1 Реализация функции проверки вводимых данных
double checkInput(String input) {
    double result;
    while(true) {
        if(!double.TryParse(input, out result)) {
            Console.WriteLine("Введите число.");
            input = Console.ReadLine();
        } else break;
    }
    return result;
}
Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
string exit_condition = null;
while(exit_condition != "n") {
    Console.WriteLine("Введите координату X точки А:");
    double Xa = checkInput(Console.ReadLine());
    Console.WriteLine("Введите координату Y точки А:");
    double Ya = checkInput(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки А:");
    double Za = checkInput(Console.ReadLine());
    Console.WriteLine("Введите координату X точки B:");
    double Xb = checkInput(Console.ReadLine());
    Console.WriteLine("Введите координату Y точки B:");
    double Yb = checkInput(Console.ReadLine());
    Console.WriteLine("Введите координату Z точки B:");
    double Zb = checkInput(Console.ReadLine());

    // 3. Демонстрация работы функции и вывод результата в нужном формате
    double distance = distanceBetween2DotsIn3D(Xa, Ya, Za, Xb, Yb, Zb);
    Console.WriteLine($"Расстояние между точками А({Xa.ToString("#.##")}; {Ya.ToString("#.##")}; {Za.ToString("#.##")}) и B({Xb.ToString("#.##")}; {Yb.ToString("#.##")}; {Zb.ToString("#.##")}) равно: {Math.Round(distance, 2)}");

    Console.WriteLine("Хотите ещё раз? (y/n): ");
    exit_condition = Console.ReadLine();
}

Console.WriteLine("Спасибо за использование программы))");

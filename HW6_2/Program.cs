//  Задача 2. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    double answer = double.Parse(strInput);
    return answer;
}
double k1 = Prompt("Введите число k1 => ");
double k2 = Prompt("Введите число k2 => ");
double b1 = Prompt("Введите число b1 => ");
double b2 = Prompt("Введите число b2 => ");
double x; 
double y;
x=(b2-b1)/(k1-k2); 
y=k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Координаты точки пересечения N({x}; {y})" );

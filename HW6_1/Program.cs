//  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите конечное число чисел М в массиве => ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа по одному, нажимая в конце ввода клавишу ЕNТЕR");
int count = 0;
int[] arr = new int[number];
for (int i = 0; i < number; i++)
{
    int numer = Convert.ToInt32(Console.ReadLine());
    arr[i] = numer;
    if (numer > 0)
    {
        count++;
    }
}
PrintArray(arr);
void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ", ");

    }
    Console.Write(collect[collect.Length - 1] + "]");
    Console.WriteLine();
}
Console.WriteLine($"Введенное количество цифр больше нуля равно {count}");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
//я использую код для ввода и печати массива из 4-й домашней работы (из задачи 29)
Console.WriteLine("Введи количество эллементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array_new = new int[n]; //мы создаем массив на n элементов
int i = 0;
while (i < n)
{ //заполняем массив рандомными трехзначными числами
    array_new[i] = new Random().Next(-100, 100);
    i++;
}
//выводим массив на экран:
Console.WriteLine();
Console.WriteLine("Рандомно сформированный массив имеет вид:");
for (i = 0; i < n; i = i + 1)
    //Console.Write($"[{array_new[i]}]");
    Console.Write($"{array_new[i]}, ");
Console.WriteLine();

int sum = 0;
for (i = 0; i < n; i = i + 1)
{
if (i % 2 != 0) //остаток от деления не равен 0 - т.е. нечетный номер элемента
{
    sum = sum + array_new[i];
}
}
//return sum;
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
//я использую код для ввода и печати массива из 4-й домашней работы (из задачи 29)
Console.WriteLine("Найдем количество четных чисел в массиве из 3х-значных чисел");
Console.WriteLine("Введи количество эллементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
int[] array_new = new int[n]; //мы создаем массив на n элементов
int i=0;
while (i<n)
    { //заполняем массив рандомными трехзначными числами
      array_new[i]=new Random().Next(100, 1000);   
    i++;
    }
    //выводим массив на экран:
    Console.WriteLine();
Console.WriteLine("Рандомно сформированный массив имеет вид:");
for (i = 0; i < n; i = i + 1)
//Console.Write($"[{array_new[i]}]");
Console.Write($"{array_new[i]}, ");
Console.WriteLine();

int kol_vo=0;
for (i = 0; i < n; i = i + 1)

if (array_new[i]%2==0)
kol_vo++;

//Console.WriteLine();
Console.WriteLine($"В выведенном на экран массиве количество четных элементов = {kol_vo}");



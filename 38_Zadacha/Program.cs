// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//снова беру код и прошлых задач
//double - вещественные числа
Console.Clear();
Console.WriteLine("Введи количество эллементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());

double[] array_new = new double[n]; //мы создаем массив на n элементов

int i=0;
while (i<n)
    { //заполняем массив рандомными трехзначными числами
      array_new[i]=new Random().Next(-50, 50);   
    i++;
    }
    //выводим массив на экран:
    Console.WriteLine();
Console.WriteLine("Рандомно сформированный массив имеет вид:");
for (i = 0; i < n; i = i + 1)

Console.Write($"{array_new[i]}, ");
Console.WriteLine();

Console.WriteLine("Теперь найдем максимальный и минимальный элемент массива и разницу между ними");

double min= array_new[0]; // считаем, что мин и макс принимают значение 1-го элемента
double max= array_new[0];

for (i = 1; i < n; i = i + 1)
  {
    if (array_new[i]>max)
    {
      max = array_new[i];
    }
        if (array_new[i]<min)
    {
      min = array_new[i];
    }
  }
Console.WriteLine ($"Минимальный элемент массива = {min}");
Console.WriteLine ($"Максимальный элемент массива = {max}");

double raznitca=max-min;
Console.WriteLine ($"({max}) - ({min}) = {raznitca}");
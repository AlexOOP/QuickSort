using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
  class Program
  {
    static void Main(string[] args)
    {
        int[] arr = { 255, 457, 34564, 1442, 4795, 4422, 1, 22, 123, 10, 0, 1124, 3424 };
        //вывод элемонтов массива
        foreach (int ar in arr)
          Console.WriteLine(ar + " ");
        Console.WriteLine("Сортировка");
        Sort(arr, 0, arr.Length - 1);
        foreach (int ar in arr)
          Console.WriteLine(ar + " ");
        Console.ReadLine();
    }

    static void Sort(int[] arr, int l, int r)
    {
      //i и j нужны для цикла
      int i = l;
      int j = r;
      int x = arr[(l + r) / 2]; //Опорная
                                //Цикл сортировка
      while (i <= j)
      {
        //Деление на меньше и больше опорного
        while (arr[i] < x) i++;
        while (arr[j] > x) j--;
        //Если i<=j:
        if (i <= j)
        {
          //меняем значение элементов
          int temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
          i++;
          j--;
        }
      }
      //Рекурсия
      if (l < j) Sort(arr, l, j);
      if (i < r) Sort(arr, i, r);
    }
  }
}

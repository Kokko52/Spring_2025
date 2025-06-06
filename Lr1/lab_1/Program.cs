using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Program
    {
        static int[] RemoveDuplicates(int[] arr)
        {
            //проверяем длину массива
            if (arr.Length <= 1)
                //если true
                return arr;

            int j = 0;

            //основной цикл
            for (int i = 1; i < arr.Length; i++)
            {
                //если элементы не равны
                if (arr[i] != arr[j])
                { 
                   //увеличиваем счетчик
                    j++;
                    //текущий элемент записывается на новую позицию
                    arr[j] = arr[i];
                }
            }

            //создаем новый массив
            int[] result = new int[j + 1];
            //икопируем уникальные элементы
            Array.Copy(arr, result, j + 1);

            return result;
        }

        static void Main()
        {
            //массив чисел
            int[] arr = { 1, 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 5 };
            //передаем в функцию 
            int[] uniqueArr = RemoveDuplicates(arr);

            //вывод нового массива
            Console.WriteLine("Массив без дубликатов:");
            foreach (int num in uniqueArr)
            {
                Console.Write(num + " ");
            }
            ////
        }
    }
}

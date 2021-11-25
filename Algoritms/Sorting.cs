using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms
{
    public class Sorting
    {   
        public static void BubbleSort(int[] array)
        {
            for(int wall = array.Length - 1; wall > 0; wall--)
            {
                for(int item = 0; item < wall; item++)
                {
                    // Если элемент item больше чем item + 1
                    if(array[item] > array[item + 1])
                    {
                        // Меняем их местами!
                        Swap(array, item, item + 1);
                    }
                }
            }
        }
        // Это метдом для замены элентов 
        // Метод принимает 3 аргумента|Первый сам массив|первый элемент|второй элемент массива
        private static void Swap(int[] array, int i, int j)
        {
            // Если i равне j просто возвращяем метод
            if(i == j)
            {
                return;
            }
            //[1, 2]
            // в противном случаем меняем местами i и j
            // Созданим переменную для хранения элемента оно равно array[i]
            int template = array[i]; // template = 1
            // сохраняем элемент j по индексу i
            array[i] = array[j]; // array[i]"1" = array[j]"2" result = array[i]"2"
            array[j] = template; // array[j]"2" = template"1" result = array[j]"1"
            // В перменную template сохранили элемент array[i]
            // в массиве[i] перезаписали элемент массива[j]
            // так как в template было уже сохранено элемент массива[i] в array[j] перезаписали template
        }
    }
}

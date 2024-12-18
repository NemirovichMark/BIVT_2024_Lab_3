using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_5(double[] vector1, double[] vector2);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double summary = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summary += array[i];
            //Console.WriteLine(array[i] + " " + summary);
        }
        for ( int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / summary;
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summary = 0, mean = 0;   // сумма и среднее арифметическое положительных чисел
        int count = 0;  // счётчик положительных чисел

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
                summary += array[i];
                mean = summary / count;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if ( array[i] > 0)
            {
                array[i] = mean;
            }
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0, mean = 0;   // сумма и среднее арифметическое элементов массива
        int count = 0;  // счётчик элементов массива

        for (int i = 0; i < array.Length; i++)
        {
            count++;
            sum += array[i];
            mean = sum / count;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - mean;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];        // суммируем квадратов всех элементов
        }
        length = Math.Sqrt(length);                 // высчитываем квадрат суммы
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0, mean = 0;   // сумма и среднее арифметическое элементов массива
        int count = 0;  // счётчик элементов массива

        for (int i = 0; i < array.Length; i++)      // вычисление среднего арифметического
        {
            count++;
            sum += array[i];
            mean = sum / count;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mean)
            {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)   // количество отрицательных элементов
            {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0, mean = 0;   // сумма и среднее арифметическое элементов массива

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            mean = sum / (i+1);
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mean)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)      // считаем количество положительных чисел чтобы определить размер будущего массива
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        
        output = new double[count];
        int n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
            }
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int e = 0, o = 0;           // индексы массивов
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[e] = array[i];
                e++;
            }
            else
            {
                odd[o] = array[i];
                o++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        int yIndex = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                y[yIndex] = (0.5 * Math.Log(x[i]));
            }
            else
            {
                y[yIndex] = double.NaN;
            }
            yIndex++;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = 100;
        for (int i = 0; i < array.Length; i++)      // вычисление минимального элемента массива
        {
            if (array[i] <= min)
            {
                min = array[i];
            }
        }

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == min)
            {
                if (array[i] >= 0)               // если элемент положительный, умножаем
                {
                    array[i] = array[i] * 2;
                }
                else if (array[i] < 0)          // если элемент отрицательный, делим
                {
                    array[i] = array[i] / 2;
                }
            }
        }
        Console.WriteLine(min);
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = -10000;
        for (int i = 0; i < array.Length; i++)      // поиск максимума
        {
            if (array[i] >= max)
            {
                max = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)      // суммируем. обрываем цикл, если встречаем максимум
        {
            if (array[i] == max)
            {
                break;
            }
            else
            {
                sum+= array[i];
            }
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double sum = 0, mean = 0, max = -10000;
        for (int i = 0; i < array.Length; i++)  // поиск среднего арифметического и максимума
        {
            sum += array[i];
            mean = sum/(i+1);

            if (array[i] >= max)
            {
                max = array[i];
            }
        }
        bool maxWasFound = false;
        for (int i = 0; i < array.Length; i++)              // меняем элементы массива, стоящие ПОСЛЕ максимального элемента
        {
            if (array[i] == max && maxWasFound == false)
            {
                maxWasFound = true;
                continue;
            }
            if (maxWasFound == true)
            {
                array[i] = mean;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here
        double sum = 0, mean = 0;
        for ( int i = 0; i < array.Length; i++)     // поиск среднего арифметического
        {
            sum += array[i];
            mean = sum/(i+1);
        }

        double mostClose = 10000, minDiff = 10000;
        for (int i = 0; i < array.Length; i++)      // поиск наиболее близкого элемента к среднему арифметическому
        {
            if (Math.Abs(array[i] - mean) <= minDiff)
            {
                minDiff = Math.Abs(array[i] - mean);
                mostClose = array[i];
            }
        }

        double[] array1 = new double [array.Length+1];      // создаем новый массив, включающий в себя на 1 элемент больше

        bool condition = false;
        for (int i = 0; i < array.Length; i++)              // переписываем значения старого массива в новый, продолжая после встречи mostClose
        {
            if (condition == false)
            {
                array1[i] = array[i];
            }
            else
            {
                array1[i + 1] = array[i];                   // [i+1] т.к. после вставки P мы берем на одну итерацию старого массива вперед
            }

            if (array[i] == mostClose)
            {
                array1[i + 1] = P;
                condition = true;
                continue;
            }
        }
        array = array1;                                     // переназначаем старый массив на новый, с внедрённым элементом P
        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here
        double max = -10000;
        for (int i = 0; i < array.Length; i++)      // поиск максимума
        {
            if (array[i] >= max)
            {
                max = array[i];
            }
        }

        bool maxIsBehind = false;
        double minAfterMax = 100000;
        for (int i = 0; i < array.Length; i++)      // поиск минимума, идущего после максимума
        {
            if (array[i] == max)
            {
                maxIsBehind = true;
                continue;
            }
            if (maxIsBehind is true && array[i] <= minAfterMax)
            {
                minAfterMax = array[i];
            }
        }

        bool maxIsBehind1 = false;
        for (int i = 0; i < array.Length; i++)      // взаимозаменяем максимум и минимум после максимума
        {
            if (minAfterMax == 100000)
            {
                break;
            }
            else if (array[i] == max)
            {
                array[i] = minAfterMax;
                maxIsBehind1 = true;
            }
            else if (array[i] == minAfterMax && maxIsBehind1 == true)
            {
                array[i] = max;
            }
        }
        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here
        double minPos = 100000;
        for (int i = 0; i < array.Length; i++)      // поиск минимума среди положительных элементов
        {
            if (array[i] <= minPos && array[i] > 0)
            {
                minPos = array[i];
            }
        }
        double[] array1 = new double[array.Length-1];     // создаем массив в котором на один элемент меньше
        bool wasDeleted = false;

        for (int i = 0; i < array.Length; i++)      // включаем в новый массив все числа, пропуская минимальное положительное
        {
            if (minPos == 100000)           // если все числа отрицательные
            {
                array1 = array;
            }

            if (array[i] == minPos && wasDeleted == false)
            {
                wasDeleted = true;
                continue;
            }
            if (wasDeleted == false)
            {
                array1[i] = array[i];
            }
            else if (wasDeleted == true)
            {
                array1[i-1] = array[i];

            }
        }
        array = array1;
        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here
        double max = array[0];
        for (int i = 0; i < array.Length; i++)     // поиск максимального элемента
        {
            if (array [i] >= max)
            {
                max = array [i];
            }
        }

        double sumAfterMax = 0;
        bool wasMax = false;

        for (int i = 0; i < array.Length; i++)     // сумма после максимального элемента
        {
            if (array [i] == max && wasMax == false)
            {
                wasMax = true;
                continue;
            }
            if (wasMax == true)
            {
                sumAfterMax += array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)     // замена первого отрицательного элемента в массиве на sumAfterMax
        {
            if (array[i] < 0)
            {
                array[i] = sumAfterMax;
                break;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here
        double max = array[0];
        for (int i = 0; i < array.Length; i++)     // поиск максимального элемента
        {
            if (array[i] >= max)
            {
                max = array[i];
            }
        }

        double firstNegative = 0;
        for (int i = 0; i < array.Length; i++)     // поиск первого отрицательного элемента
        {
            if (array[i] < 0)
            {
                firstNegative = array[i];
                break;
            }
        }

        bool maxWasUpdated = false, firstNegativeWasUpdated = false;
        for (int i = 0; i < array.Length; i++)      // заменяем максимальный элемент на первый отрицательный и наоборот
        {
            if (firstNegative == 0)     // если в массиве нет отрицательных элементов, то значение firstNegative остается неизменно(0).
            {                           // в таком случае мы ничего не делаем с массивом
                break;
            }

            if (array[i] == firstNegative && firstNegativeWasUpdated == false)
            {
                array[i] = max;
                firstNegativeWasUpdated = true;
                continue;
            }
            if (array[i] == max && maxWasUpdated == false)
            {
                array[i] = firstNegative;
                maxWasUpdated = true;
                continue;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here

        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here
        double sum = 0, mean = 0;
        for ( int i = 0; i < array.Length; i++)     // поиск среднего арифметического в массиве
        {
            sum += array[i];
            mean = sum / (i+1);
        }

        int n = 0;
        for (int i = 0; i < array.Length; i++)     // ищем количество элементов меньших среднего арифметического, чтобы определить размер будущего массива
        {
            if (array[i] < mean)
            {
                n++;
            }
        }

        output = new int[n];                    // создаем массив размером количества элементов меньше среднего арифметического

        for (int i = 0, j = 0; i < array.Length; i++)     // задаем значение каждой ячейки массива
        {
            if (array[i] < mean)
            {
                output[j] = i;
                j++;
            }
        }
        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here
        double maxAmongEven = array[0], maxAmongOdd = array[1];

        for (int i = 0; i < array.Length; i++)      // находим максимальный элемент отдельно для четных и нечетных элементов
        {
            if (i % 2 == 0)
            {
                if (array[i] >= maxAmongEven)
                {
                    maxAmongEven = array[i];
                }
            }
            else if (i % 2 == 1)
            {
                if (array[i] >= maxAmongOdd)
                {
                    maxAmongOdd = array[i];
                }
            }
        }

        if (maxAmongEven > maxAmongOdd)                     // если максимальный среди чётных больше,
        {
            for (int i = 0; i < (array.Length / 2); i++)    // то меняем всё ДО середины массива (первую половину)
            {
                array[i] = 0;
            }
        }
        else if (maxAmongOdd > maxAmongEven)                        // если максимальный среди НЕчётных больше,
        {
            for (int i = (array.Length/2); i < array.Length; i++)   // то меняем всё НАЧИНАЯ с середины массива (вторую половину)
            {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        double min = array[0];
        for (int i = 0; i < array.Length; i++)      // поиск минимально элемента массива
        {
            if(array[i] <= min)
            {
                min = array[i];
            }
        }

        bool minIsBehind = false;
        double firstNegative = 0;
        for (int i = 0; i < array.Length; i++)      // поиск первого отрицательного
        {
            if(array[i] == min)     // проверяем, встречался ли нам минимум или нет
            {
                minIsBehind = true;
            }
            if (array[i] < 0)
            {
                firstNegative = array[i];
                break;
            }
        }

        double sumOfEven = 0, sumOfOdd = 0;
        for(int i = 0; i < array.Length; i++)           // находим сумму элементов с чётными и нечётными индексами
        {
            if (i % 2 == 0)
            {
                sumOfEven += array[i];
            }
            else if (i % 2 == 1)
            {
                sumOfOdd += array[i];
            }
        }

        if (minIsBehind == false)       // если 1-й отрицательный элемент массива расположен ДО минимального (минимум НЕ позади. minIsBehind == false)
        {
            sum = sumOfEven;
        }
        else if (minIsBehind == true)   // eсли 1-й отрицательный элемент массива расположен ПОСЛЕ минимального (минимум позади. minIsBehind == true)
        {
            sum = sumOfOdd;
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here
        double max = array[0];
        for (int i = 0; i < array.Length; i++)      // поиск максимума
        {
           if (array[i] >= max)
            {
                max = array[i];
            }
        }

        for (int i = 0; i < array.Length-1; i+=2)       // берем по 2 элемента и переназначаем их друг на друга
        {
            if (array[i] == max || array[i+1] == max)   // если один из элементов пары равен максимуму, то сбрасываем цикл
            {
                break;
            }
            double save = array[i];                     // переменная save нужна чтобы сохранить элемент перед его переназначением
            array[i] = array[i+1];
            array[i+1] = save;
        }
        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
        // code here

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here
        int maxStreak = 1;     // по умолчанию такой элемент будет 1
        int streak = 1;

        for (int i = 1; i < array.Length; i++)    // начинаем с i = 1, чтобы сравнивать текущий элемент с предыдущим
        {
            if (array[i-1] > array[i])        // если предыдущий элемент больше текущего, то серия увеличивается
            {
                streak += 1;
            }
            else
            {                                 // если нет, то снова сбрасывается до 1
                streak = 1;
            }
            if (streak >= maxStreak)          // серия сравнивается с максимальной и перезаписывается. если она больше, макс. серия перезаписывается
            {
                maxStreak = streak;
            }
        }
        count = maxStreak;
        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here

        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0;

        // code here
        int maxStreak = 1;     // по умолчанию такой элемент будет 1
        int streakOfIncrease = 1, streakOfDecrease = 1;

        for (int i = 1; i < array.Length; i++)      // начинаем с i = 1, чтобы сравнивать текущий элемент с предыдущим
        {
            if (array[i - 1] > array[i])        // если предыдущий элемент больше текущего, то streakOfDecrease увеличивается (серия убывания)
            {
                streakOfDecrease += 1;
            }
            else
            {
                streakOfDecrease = 1;
            }

            if (array[i-1] < array[i])     // если предыдущий элемент меньше текущего, то streakOfIncrease увеличивается (серия возрастания)
            {
                streakOfIncrease += 1;
            }
            else
            {
                streakOfIncrease = 1;
            }


            if (streakOfIncrease >= maxStreak)
            {
                maxStreak = streakOfIncrease;
            }
            if (streakOfDecrease >= maxStreak)
            {
                maxStreak = streakOfDecrease;
            }
        }
        count = maxStreak;
        Console.WriteLine(count);
        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

        // end

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)  // считаем количество неотрицательных элементов массива
        {
            if (array[i] >= 0)
            {
                n++;
            }
        }

        double[] array1 = new double[n];        // создаем новый массив размером количества неотрицательных элементов

        for (int i = 0, j = 0; i < array.Length; i++)   // добавляем в новый массив все неотрицательные элементы
        {
            if (array[i] >= 0)
            {
                array1[j] = array[i];
                j++;
            }
        }

        array = array1;     // меняем старый массив на новый, не включающий отрицательные числа
        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here

        // end

        return normalizedArray;
    }
    #endregion
}
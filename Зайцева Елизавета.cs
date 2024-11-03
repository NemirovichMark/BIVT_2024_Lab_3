using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        program.Task_2_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;

        // end
        for (int i=0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s,2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double avg = 0;
        double s = 0;
        double k = 0;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k += 1;
            }
        }
        avg = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = avg;
            }
        }

            // end

            return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here

        for (int i=0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double avg = 0;
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - avg,2);
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
            
        // code here
        for (int i=0; i< vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double s = 0;
        // code here
        for (int i=0; i< vector.Length; i++)
        {
            s += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(s),2);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double avg = 0;
        for (int i=0; i < array.Length; i++)
        {
            s += array[i];
        }
        avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
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
        foreach (double x in array)
        {
            if (x < 0) count += 1;
            
        }
        //for (int i=0; i<array.Length; i++)
        //{
        //    if (array[i] < 0) count += 1;
        //}
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
            {
                count +=1;
            }
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count += 1;
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here

        int j = 0;
        int k = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                k += 1;
            }
        }
        output = new double[k];
        foreach (double x in array) { 
            if (x > 0)
            {
                output[j] = x;
                j += 1;
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
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] ch = new double[array.Length / 2];
        double[] nch = new double[array.Length/2];

        // code here
        int index_ch = 0;
        int index_nch = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (i%2 == 0)
            {
                ch[index_ch] = array[i];
                index_ch += 1;
            }
            else
            {
                nch[index_nch]  = array[i];
                index_nch += 1;
            }

        }
        // end

        return (ch, nch);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i=0; i < x.Length; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
        }

        for (int i = 0; i < x.Length; i++) Console.WriteLine($"{x[i]}\t\t{y[i]}\n");
        // end

        return y;
    }
    #endregion

    #region Level 2
    //10 номер по списку => четные номера
    public double[] Task_2_1(double[] array)
    {
        // code here

        int k = 0;
        double min_el = 1000;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_el) 
            { 
                min_el = array[i];
                k = i;
            }
        }
        array[k] = array[k] * 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int k = 0;
        double max_el = 0;
        int i = 0;

        foreach(double el in array)
        {
            if (el > max_el)
            {
                max_el = el;
                k = i;
            }
            i += 1;
        }
        for (int j = 0; j < k; j++)
        {
            sum += array[j];
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
        double s = 0;
        double avg = 0;
        int k = 0;
        double max_el = 0; 
        for (int i = 0; i<array.Length; i++)
        {
            s += array[i];
            if (array[i] > max_el)
            {
                max_el = array[i];
                k = i;
            }
        }
        avg = Math.Round(s/array.Length,2);
        for(int i = k+1; i<array.Length; i++)
        {
            array[i] = avg;
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
        double avg = 0;
        double sum = 0;
        double min_raznitsa = Math.Abs(array[0] - avg); // по модулю вычесть из среднего значения элемент и потом если это значение меньше предыдущего то минимальная разница у тэтого элмента будет
        int index = 0;
        for (int i = 0; i< array.Length; i++)
        {
            sum += array[i];
        }
        avg = Math.Round(sum/array.Length,2);
        for (int i = 1; i< array.Length; i++)
        {
            if (Math.Abs(avg - array[i]) < min_raznitsa)
            {
                min_raznitsa = Math.Abs(avg - array[i]);
                index = i;
            }
        }
        double [] new_array = new double[array.Length + 1];
        for (int i=0; i<=index; i++)
        {
            new_array[i] = array[i];
        }
        new_array[index + 1] = P;
        for(int i = index + 2; i<new_array.Length; i++)
        {
            new_array[i] = array[i-1];
        }
        array = new_array;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{i}\t{array[i]}");
        }

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
        double max_el = -1;
        int max_index = 0;
        double min_el = 100;
        int min_index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                max_index = i;
            }
            else if (array[i] == max_el) break;
        }
        Console.WriteLine($"максимальный элемент и его индекс: {max_el} {max_index}");
        for (int i = max_index + 1; i < array.Length; i++)
        {
            if (array[i] < min_el)
            {
                min_el = array[i];
                min_index = i;
            }
            else if (array[i] == min_el) break;
        }
        Console.WriteLine($"мин элемент и его индекс: {min_el} {min_index}");
        if (min_index != -1)
        {
            double c = array[min_index];
            array[min_index] = array[max_index];
            array[max_index] = c;
            Console.WriteLine($"Максимальный элемент в переменной минимального {array[min_index]} и наоборот {array[max_index]}");
        } else
        {
            Console.WriteLine("Массив не поменялся");
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{i}\t{array[i]}");
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
        double min_el = 100;
        int min_index = -1;
        for (int i=0; i< array.Length; i++)
        {
            if (array[i]>0 && array[i] < min_el)
            {
                min_el = array[i];
                min_index = i;
            }
        }
        Console.WriteLine($"миним положительный элемент и его индекс {min_el} / {min_index}");
        if (min_index == -1) return array;
        int n = array.Length-1;
        for (int i = min_index; i < n; i++)
        {
            array[i] = array[i + 1];
        }
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
        double max_el = -20;
        int max_index = 0;
        double sum = 0;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
                max_index = i;
            }
        }
        Console.WriteLine($"max element i ego index {max_el} / {max_index}");
        for (int i = max_index+1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum,2);
        Console.WriteLine($"summa: {sum}");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
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
        double max_el = -20;
        int max_index = 0;
        double otr = 0;
        int otr_index = -1;
        for(int i = 0; i< array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array [i]; 
                max_index = i;
            }
        }
        Console.WriteLine($"Max el: {max_el} / {max_index}");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array [i];
                otr_index = i;
                break;
            }
        }
        Console.WriteLine($"Otr el: {otr} / {otr_index}");
        if (otr_index == -1) return array;
        else
        {
            double c = array[max_index];
            array[max_index] = array[otr_index];
            array[otr_index] = c;
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
        double sum = 0;
        double avg = 0;
        int k = 0;
        for (int i=0; i < array.Length; i++)
        {
            sum += array[i];
        }
        avg = Math.Round(sum/array.Length,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                k += 1;
            }
        }
        output = new int[k];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
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
        double max_el_chet = 0;
        double max_el_nechet = 0;
        for (int i=0; i< array.Length; i += 2)
        {
            if (array[i]>max_el_chet) max_el_chet=array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max_el_nechet) max_el_nechet = array[i];
        }
        if (max_el_chet > max_el_nechet)
        {
            //заменить 0 первую половину массива
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for(int i = array.Length/2; i < array.Length; i++)
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
        double otr = -1;
        int otr_index = 0;
        double min = 100;
        int min_index = 0;
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                otr_index = i;
                break;
            }
        }
        if (otr == -1) return 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_index = i;
            }
        }
        if (otr_index < min_index)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }

        // end

        return sum;
    }
    #endregion
    #region Level 3
    //10 % 3 + 1 = 2 => 2,5,8,11,14
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
        double max_el = -20;
        int k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max_el)
            {
                max_el = array[i];
            }
        }
        Console.WriteLine($"Max el: {max_el}");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max_el)
            {
                array[i]+=k;
                k += 1;
            }
        }


        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here

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
        double[] for_chet = new double[(array.Length + 1) / 2];
        int index_for_chet = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            for_chet[index_for_chet] = array[i];
            index_for_chet += 1;
        }
        //Вывод массива для проверки
        Console.WriteLine("Массив:");
        for (int i = 0; i < for_chet.Length; i++)
        {
            Console.WriteLine(for_chet[i] + " ");
        }

        for (int i = 0; i < for_chet.Length-1; i += 1)
        {
            for (int j = 0; j < for_chet.Length-1-i; j += 1)
            {
                if (for_chet[j]> for_chet[j+1])
                {
                    double t = for_chet[j];
                    for_chet[j] = for_chet[j+1];
                    for_chet[j+1] = t;
                }
            }
        }

        //Для проверки
        Console.WriteLine("Отсортированный:");
        for (int i = 0; i < for_chet.Length; i++)
        {
            Console.WriteLine(for_chet[i] + " ");
        }

        //Замена четных индексов отсортированными элементами
        index_for_chet = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = for_chet[index_for_chet];
            index_for_chet += 1;

        }

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here

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

        //Количество отрицательных элементов
        int k = 0;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0) k += 1;
        }
        Console.WriteLine($"k= {k}");
        //Добавление их в новый массив
        double[] otr = new double[k];
        int index_otr = 0;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                otr[index_otr] = array[i];
                index_otr += 1;
            }
        }
        //Вывод массива для проверки
        Console.WriteLine("Массив:");
        for (int i = 0; i < otr.Length; i++)
        {
            Console.WriteLine(otr[i]);
        }

        for (int i = 0; i < otr.Length - 1; i += 1)
        {
            for (int j = 0; j < otr.Length - 1 - i; j += 1)
            {
                if (otr[j] < otr[j+1])
                {
                    double t = otr[j];
                    otr[j] = otr[j+1];
                    otr[j+1] = t;
                }
            }
        }

        //Для проверки
        Console.WriteLine("Отсортированный:");
        for (int i = 0; i < otr.Length; i++)
        {
            Console.WriteLine(otr[i] + " ");
        }

        //Замена отсортированными элементами
        index_otr = 0;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                array[i] = otr[index_otr];
                index_otr += 1;
            } 

        }

        // end

        return array;
    }
    public int Task_3_9(double[] array)
    {
        int count = 0;

        // code here

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
        X = new double[n];
        Y = new double[n];
        double p = (b - a) / (n - 1); //шаг
        double max_zn = -1000;
        double min_zn = 1000;
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = Math.Round(a + i * p, 2);
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 2);
        }
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > max_zn) max_zn = Y[i];
            if (Y[i] < min_zn) min_zn = Y[i];
        }
        globalMax = max_zn;
        globalMin = min_zn;
        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine($"X: {X[i]} , Y: {Y[i]}");
        }
        Console.WriteLine($"Максимум функции: {globalMax}");
        Console.WriteLine($"Минимум функции: {globalMin}");

        //end

        return (X, Y, globalMax,globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here

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
        normalizedArray = new double[array.Length];

        double max_el = -1000;
        double min_el = 1000;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > max_el) max_el = array[i];
            if (array[i] < min_el) min_el = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min_el) / (max_el - min_el) - 1,2);
        }


        // end

        return normalizedArray;
    }
    #endregion
}
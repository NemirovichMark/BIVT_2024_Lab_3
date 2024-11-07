using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr, s = 0;
        double news;
        int n = 0;
        foreach (double i in array)
        {
            if (i > 0)
            {
                s += i;
                n++;
            }
        }
        sr = s / n;
        sr = Math.Round(sr, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = sr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double s = 0, r = 0, k = 0;
        for (int i = 0; i < 4; i++)
        {
            sum[i] = first[i] + second[i];
            sum[i] = Math.Round(sum[i], 2);
            dif[i] = first[i] - second[i];
            dif[i] = Math.Round(dif[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0, s = 0;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
        }
        sr = s / 5;
        for (int i = 0; i < 5; i ++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
            product = Math.Round(product, 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        sr = s / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
            {
                array[i] = 0;
            }
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i ++)
        {
            if (array[i] < 0)
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
        double s = 0, sr = 0;
        for (int i = 0; i < 8; i ++)
        {
            s += array[i];
        }
        sr = s / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
            {
                count ++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int  i = 0; i < 10; i++)
        {
            if (array[i] < Q && array[i] > P)
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
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n]; //n - длина нового массива
        n = 0;
        for (int i = 0; i < 10; i ++)
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
        for (int i = 0; i < 8; i++)
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
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[n] = array[i];
                n++;
            }
        }
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 != 0)
            {
                odd[k] = array[i];
                k++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11 && array[i] >= 0; i ++)
        {
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            y[i] = 0.5 * Math.Log(x[i]);
            if (y[i] < 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(y[i], 2);
            }
            Console.WriteLine($"{x[i]} {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double arraymax = array[0];
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
            sum += array[i];
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
        double sum = 0;
        double arraymax = array[0];
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
            sum += array[i];
        }
        double sr = sum / array.Length;
        for (int i = imax + 1; i < array.Length; i++)
        {
            array[i] = sr;
            array[i] = Math.Round(array[i], 2);
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
        double sum = 0;
        double min = 99999;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sr = sum / array.Length;
        sr = Math.Round(sr, 2);
        //среднее значение массива
        double m = 88888;
        int im = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(sr - array[i]) < m)
            {
                m = Math.Abs(sr - array[i]);
                im = i;
            }
        }
        //индекс приблиз. элемента
        double[] a = new double[array.Length + 1]; //новый массив
        for (int i = 0; i <= im; i++)
        {
            a[i] = array[i];
        } //перекопир в новый массив до im включительно
        a[im + 1] = P; // вставила новый элемент
        for (int i = im + 2, j = im + 1; i < a.Length; i++, j++)
        {
            a[i] = array[j];
        } //i = a; j = array
        array = a;

        foreach(double x in array)
            Console.Write(x + " ");
        Console.WriteLine();
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
        double arraymax = -99999;
        int imax = 0;
        double arraymin = 99999;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        //нашл индекс макс и его значение
        for (int i = imax + 1;  i < array.Length; i++)
        {
            if (array[i] < arraymin)
            {
                arraymin = array[i];
                imin = i;
            }
        }

        Console.WriteLine(arraymax);
        Console.WriteLine(arraymin);
        Console.WriteLine(" ");

        // нашла миним и его индекс, если значение массива == максимальному
        double a = 0;
        if (imax < imin)
        {
            a = array[imax];
            array[imax] = array[imin];
            array[imin] = a;
        }
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
        Console.WriteLine(" ");
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
        double[] array_2 = new double[array.Length - 1];
        int k = 0;
        double min = 99999;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }

        Console.WriteLine(min);
        Console.WriteLine(" ");

        if (min == 99999)
        {
            return array;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i == imin)
            {
                continue;
            }
            else
            {
                array_2[k] = array[i];
                k++;
            }
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
        // end

        return array_2;
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
        double otr = 0;
        double max = -9999;
        int imax = 0;
        double sum = 0;
        Console.WriteLine(" ");
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        Console.WriteLine(max);

        // нашла максимальное значение и его индекс
        for (int i = imax + 1; i < array.Length; i ++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);

        Console.WriteLine(sum);
        Console.WriteLine(" ");

        // нашла сумму элементов после максим
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
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
        double max = -999;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] > max)
            {
                max = array [i];
                imax = i;
            }
        }
        Console.WriteLine(max);
        double otr = 0;
        int iotr = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                otr = array [i];
                iotr = i;
                break;
            }
        }
        Console.WriteLine(otr);
        
        if (otr == 0)
        {
            return array;
        }

        double a = 0;
        a = array[imax];
        array[imax] = array[iotr];
        array[iotr] = a;


        foreach (double x in array)
        {
            Console.WriteLine(x);
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
        int k = 0;
        double sum = 0, sr = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
        }
        sr = Math.Round(sum / array.Length, 2);
        //нашла среднее значение
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                k++;
            }
        }
        // длину массива (нового) по условию
        output = new int[k];
        int n = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < sr)
            {
                output[n] = i;
                n++;
            }
        }
        for (int i = 0; i < output.Length; i++)
            Console.WriteLine(output[i]);
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
        double maxch = -999;
        for (int i = 0; i < array.Length; i+=2)
        {
            if ( array[i] > maxch)
            {
                maxch = array[i];
            }
        }
        Console.WriteLine(maxch);
        double maxnch = -999;
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > maxnch)
            {
                maxnch = array[i];
            }
        }
        Console.WriteLine(maxnch);
        if (maxch > maxnch)
        {
            for (int i = 0; i < (array.Length / 2); i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        foreach (double x in array)
            Console.WriteLine(x);
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
        double min = 9999;
        int imin = 0;
        int iotr = 0;
        double otr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                iotr = i;
                break;
            } // нашла 1-й отриц элемент массива и его индекс
        }
        if (iotr == 0) return 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            } // нашла минимальное число массива и его индекс
        }

        if (iotr < imin)
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
        double max = -9999;
        int imax = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        double a = 0;
        for (int i = 0; i < imax; i += 2)
        {
            if ((i + 1) != imax)
            {
                a = array[i];
                array[i] = array[i + 1];
                array[i + 1] = a;
            }
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
        count = 1; //потому что первое число также должно быть включено
        int maxcount = 1; // аналогично count
        for (int i = 1; i < array.Length; i ++)
        {
            if (array[i] < array[i - 1]) //по убыванию
            {
                count++;
            }
            else
            {
                if (count > maxcount)
                {
                    maxcount = count;
                }
                count = 1;
            }
        }
        count = maxcount;
        Console.WriteLine(count);
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
        count = 1; // потому что первое число также должно быть включено
        int maxcount = 1; //аналогично count
        for (int i = 0; i < (array.Length - 1); i++)
        {
            if (array[i] > array[i + 1])
            {
                count++;
            }
            else
            {
                if (maxcount < count)
                {
                    maxcount = count;
                }
                count = 1; //возвращаю
            }
        }
        //max = 2; count = 1
        count = 1;
        for (int i = 0; i < (array.Length - 1); i++)
        {
            if (array[i] < array[i + 1])
            {
                count++;
            }
            else
            {
                if (maxcount < count)
                {
                    maxcount = count;
                }
                count = 1;
            }
        }

        Console.WriteLine(maxcount);
        Console.WriteLine(count);
        Console.WriteLine(' ');

        if (maxcount < count)
        {
            maxcount = count;
        }
        count = maxcount;
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
        for (int i = 0; i < array.Length; i ++)
            if (array[i] < 0)
            {
                n++;
            }
        double[] a = new double[array.Length - n];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a[j] = array[i];
                j++;
            }
        }
        array = a;
        foreach (double x in array)
            Console.WriteLine(x);
        Console.WriteLine(' ');
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
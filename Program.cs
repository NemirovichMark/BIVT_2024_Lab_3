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
        //program.Task_1_1(new double[] { 1, 2, 3, 4, 5, 6 });
        //program.Task_1_2(new double[] { 1, 2, 3, 4, -5, -6, -7, -8 });
        //program.Task_1_3(new double[] { 1, -2, 3, -4 }, new double[] { -1, 2, -3, 4 });
        //program.Task_1_4(new double[] { 1, 2, 3, 4, 5 });
        //program.Task_1_5(new double[] { 1, -2, 3, -4 }, new double[] { -1, 2, -3, 4 });
        //program.Task_1_6(new double[] { 1, 2, 3, 4, 5 });
        //program.Task_1_7(new double[] { 1, 2, 3, 4, 5, 6, 7 });
        //program.Task_1_8(new double[] { 1, 2, 3, 4, 5, 6 });
        //program.Task_1_9(new double[] { 1, 2, 3, 4, -5, -6, -7, -8 });
        //program.Task_1_10(new double[] { 2, 1, 3, 3, 5, 6, 3, 4, 5, 0 }, 3, 4);
        //program.Task_1_11(new double[] { 2, -1, 3, -3, 5, 6, -3, 4, 5, 10 });
        //program.Task_1_12(new double[] { 1, 2, 3, 4, -5, -6, -7, 8 });
        //program.Task_1_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1.9, 3.9, -0.1 });
        //program.Task_1_14(new double[] { 1, 2, 3, 4, 5, -6, 1, 2, 3, 4, 5 });
        //program.Task_1_15(new double[] { 2, -1, 3, -3, 5, 6, -3, 4, 5, 10 });
        //program.Task_2_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_2_4(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
            Console.WriteLine(array[i]);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, m = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s = s + array[i];
                m += 1;
            }
        }
        double sr = s / m;
        sr = Math.Round(sr, 2);
        
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
            Console.WriteLine(sum[i] + "  " + dif[i]);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);        

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
            Console.WriteLine(array[i]);
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
        product = Math.Round(product, 2);
        Console.WriteLine(product);

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        Console.WriteLine(length);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);

        for (int i = 0; i < array.Length; i++)
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
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }            
        }
        Console.WriteLine(count);

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);

        foreach (double i in array)
        {
            if (i > sr)
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

        foreach (double i in array)
        {
            if ((i > P) && (i < Q))
            {
                count++;
            }
        }
        Console.WriteLine(count);

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];

        // code here
        int j = 0;

        foreach (double i in array)
        {
            if (i > 0)
            {
                output[j] = i;
                Console.WriteLine(output[j]);
                j++;                
            }
            
        }

        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1, k = 0;

        // code here

        foreach (double i in array)
        {
            if (i < 0)
            {
                value = i;
                index = k;
            }
            k++;
        }
        Console.WriteLine(value + " " + index);

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        int j = 0, k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i % 2) == 1)
            {
                odd[j] = array[i];
                Console.WriteLine($"\t {odd[j]}");
                j++;
            }
            else
            {
                even[k] = array[i];
                Console.WriteLine(even[k]);
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

        for (int i = 0; ((array.Length > i) && (array[i] >= 0)); i++)
        {
            sum += array[i] * array[i];
        }
        Console.WriteLine(sum);

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here

        for (int i = 0; i < x.Length; i++)
        {
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            if (x[i] <= 0)
                y[i] = double.NaN;
            Console.WriteLine($"{x[i]}\t  {y[i]}");
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
        double elemax = array[0];
        int indexmax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
        }

        for (int i = 0; i < indexmax; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма элементов = " + sum + " до элемента " + elemax + " под индексом " + indexmax);
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
        double sum = 0, elemax = array[0], sr = 0;
        int indexmax = 0;

        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            sum += array[i];            
            Console.Write(array[i] + "  ");
            
        }
        Console.WriteLine();
        sr = Math.Round(sum / array.Length, 2);

        for (int i = indexmax + 1; i < array.Length; i++)
        {
            array[i] = sr;
        }

        Console.Write(" Новый массив: ");
        for (int i = 0; i < array.Length; i++)
        {            
            Console.Write(array[i] + "  ");
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
        double sum = 0, elemax = array[0], sr = 0, blizost = 999;
        int indexmax = 0, indexbliz = 0;
        double[] a = new double[array.Length + 1];

        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            sum += array[i];
            Console.Write(array[i] + "  ");

        }
        Console.WriteLine();
        sr = Math.Round(sum / array.Length, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(sr - array[i]) < blizost)
            {
                blizost = Math.Abs(sr - array[i]);
                indexbliz = i;
            }
        }

        Console.Write(" Новый массив: ");
        for (int i = 0; i <= indexbliz; i++)
        {
            a[i] = array[i];
            Console.Write(a[i] + "  ");
        } // первая часть нового массива

        a[indexbliz + 1] = P; // новый элемент
        Console.Write(P + "  ");

        for (int i = indexbliz + 2, j = indexbliz + 1; i < a.Length; i++, j++)
        {
            a[i] = array[j];
            Console.Write(a[i] + "  ");
        } // вторая часть нового массива
        Console.WriteLine();
        Console.WriteLine();
        array = a;

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
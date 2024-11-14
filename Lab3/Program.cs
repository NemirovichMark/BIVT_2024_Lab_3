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
        double[] first = { 0, 1.5, -1, -3, -2.2, -0.5, 6 };
        program.Task_2_5(first);
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
        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for(int i = 0; i < array.Length; i++ )
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s / k, 2);
            }
        }
        Console.WriteLine(array);

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double s, d;
        for(int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
        }
        for (int i = 0; i < 4; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s / k, 2);
        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double  a, s = 0;
        for(int i = 0; i < vector1.Length; i++)
        {
            a = Math.Round(vector1[i] * vector2[i], 2);
            s += a;
        }
        product = Math.Round(s, 2);
        Console.WriteLine(product);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double l = 0, v;
        for(int i = 0; i < 5; i++)
        {
            l += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(l), 2);
        Console.WriteLine(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s / array.Length)
            {
                array[i] = 0;
            }

        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int k = 0;
        for(int i = 0; i < array.Length; i++)
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
        double s = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s / array.Length)
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
        for (int i = 0; i < 10; i++)
        {
            if (P < array[i] && array[i] < Q)
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
        double[] output = null;

        // code here
        int n = 0;
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        n = 0;
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n++] = array[i];
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
        int k=0, n = 0;
        for(int i = 0; i < 8; i++)
        {
            n++;
            if (array[i] < 0)
            {
                value = array[i];
                k = n;
            }
        }
        index += k;
        Console.WriteLine($"{value}   {index}");

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int n = 0, k = 0;
        for(int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[n] = array[i];
                n++;
            }
            else 
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
        for(int i = 0; i < 11; i++)
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
        double yz;
        for(int i = 0; i < 10; i++)
        {
            if (x[i] < 0 || x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                yz = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(yz, 2);
                Console.WriteLine(y[i]);
            }
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double n = 100, m = 0;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < n)
            {
                n = array[i];
                k = i;
            }
        }
        array[k] = n * 2;
        Console.WriteLine(array[k]);
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = 100;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                k = i;
            }
        }
        for(int i = 0; i < k; i++)
        {
            array[i] = array[i] * 2;
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double min = double.MinValue, max = double.MaxValue;
        int n = 0, k = 0, t = 0, c = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < max)
            {
                max = array[i];
                k = i;
            }
            if (array[i] > min)
            {
                min = array[i];
                t = i;
            }

        }
        for(int v = Math.Min(k, t); v < Math.Max(k,t); v++)
        {
            if (array[v] < 0)
            {
                n++;
            }
        }
        double[] b = new double[n];
        for(int i = Math.Min(k, t) + 1; i < Math.Max(k, t); i++)
        {
            if (array[i] < 0)
            {
                b[c] = array[i];
                c++;
            }
        }
        // end

        return b;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

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
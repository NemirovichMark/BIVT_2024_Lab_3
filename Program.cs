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
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i] / sum, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0; double c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sr += array[i];
                c++;
            }
        }
        sr = Math.Round(sr / c, 2);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = sr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
            sr += array[i];
        sr = Math.Round(sr / array.Length, 2);
        for(int i = 0; i < array.Length; i++)
            array[i] -= sr;
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
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
        for(int i = 0; i < vector.Length; i++)
            length += vector[i] * vector[i];
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
            sr += array[i];
        sr = Math.Round(sr / array.Length, 2);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                count++;
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
            sr += array[i];
        sr = Math.Round(sr / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
                count++;
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        // code here
        int c = 0; int s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                c++;
        }
        double[] output = new double[c];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[s] = array[i];
                s++;
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
                value = array[i];
                index = i;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length/2];
        double[] odd = new double[array.Length/2];

        // code here
        int p = 0; int o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[p] = array[i];
                p++;
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
                sum += array[i] * array[i];
            else
                break;
        }
        // end

            return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < x.Length; i++)
        {
            x[i] = 0.5 * (Math.Log(x[i]));
            if (x[i] >= 0)
                y[i] = Math.Round(x[i], 2);
            else
                y[i] = double.NaN;
        }
        for (int i = 0; i < x.Length; i++)
            Console.WriteLine($"{x[i]} + {y[i]}");
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
        int m = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[m])
                m = i;
        }
        for (int i = 0; i < m; i++)
            sum += array[i];
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
        double sr = 0; int max = 0; int o = 0;
        for (int i  = 0; i < array.Length; i++)
        {
            sr += array[i];
            if (array[i] > array[max]) 
                max = i;
        }
        sr = Math.Round(sr / array.Length, 2);
        for (int i = max + 1; i < array.Length; i++)
            array[i] = sr;
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
        double[] array2 = new double[array.Length + 1];
        double sr = 0; double m = 123456; double n = 0; int o = 0;
        for (int i = 0; i < array.Length; i++)
            sr += array[i];
        sr = Math.Round(sr / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                if (array[i] - sr < m)
                {
                    n = array[i];
                    m = array[i] - sr;
                }
            }
            else
            {
                if (sr - array[i] < m)
                {
                    n = array[i];
                    m = sr - array[i];
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                array2[o] = array[i];
                array2[o + 1] = P;
                o = o + 2;
            }
            else
            {
                array2[o] = array[i];
                o++;
            }
        }
        // end

        return array2;
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
        double max = -123456; double min = 123456; double p = 0;  int m = 0; int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                m = i;
            }
        }
        for (int i = m + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }
        if (m > n)
            return array;
        else
        {
            p = array[m];
            array[m] = array[n];
            array[n] = p;
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
        double[] array2 = new double[array.Length - 1];
        double min = 123456;
        int m = 0; int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min && array[i] > 0)
                min = array[i];
        }
        if (min == 123456)
            return array;
        for (int i = 0; i < array.Length; i++)
        {
            if (min != array[i])
            {
                array2[n] = array[i];
                n++;
            }
        }
        // end

        return array2;
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
        double max = -123456; double sum = 0;  int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                m = i;
            }
        }
        for (int i = m + 1; i < array.Length; i++)
            sum += array[i];
        sum = Math.Round(sum, 2);
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
        double max = -123456; double min = 0; double o = 0; int m = 0; int n = 0; 
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                m = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min = array[i];
                n = i;
                break;
            }
        }
        if (min == 0 || max == -123456)
            return array;
        o = array[m];
        array[m] = array[n];
        array[n] = o;
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

        // code here
        double sr = 0; int count = 0; int m = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                count++;
            }
        }
        int[] output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[m] = i;
                m++;
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
        double max1 = -123456; double max2 = 0; int m = array.Length / 2;
        for ( int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 || i == 0)
            {
                if (array[i] > max1)
                    max1 = array[i];
            }
            if (i % 2 != 0)
            {
                if (array[i] > max2)
                    max2 = array[i];
            }

        }
        if (max1 > max2)
        {
            for (int i = 0; i < m; i++)
                array[i] = 0;
        }
        else
        {
            for (; m < array.Length; m++)
                array[m] = 0;
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
        double min = 123456; double n = 0;
        int m = 0; int o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                m = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                n = array[i];
                o = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (n == 0)
            {
                if (i % 2 != 0)
                    sum += array[i];
            }
            else if (o < m)
            {
                if (i % 2 == 0)
                    sum += array[i];
            }
            else
            {
                if (i % 2 != 0)
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
        double max = -123456; double t = 0; int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                m = i;
            }
        }
        for (int i = 1; i < m; i += 2)
        {
            t = array[i];
            array[i] = array[i - 1];
            array[i - 1] = t;
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
        int max = -123456;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                count++;
            else
                count = 0;
            if (count > max)
                max = count;
        }
        count = max + 1;
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
        int m = 1, n = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
                m += 1;
            else
                m = 1;
            if (array[i] < array[i + 1])
                n += 1;
            else
                n = 1;
            if (count < m)
                count = m;
            if (count < n)
                count = n;
        }
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
        int c = 0, m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                c++;
        }
        double[] array2 = new double[c];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array2[m] = array[i];
                m++;
            }
        }
        // end

        return array2;
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
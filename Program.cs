using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        double s = 0;
        for (int i = 0; i < 6; i++)
            s += array[i];
        for (int j = 0; j < 6; j++)
        {
            array[j] = array[j] / s;
            array[j] = Math.Round(array[j], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double k = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        for (int j = 0; j < 8; j ++)
        {
            if (array[j] > 0)
            {
                array[j] = s / k;
                array[j] = Math.Round(array[j], 2);
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
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
        double s = 0;
        double k = 0;
        double a = 0;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
            k++;
        }
        a = Math.Round(s / k, 2);
        for (int j = 0; j < 5; j ++)
        {
            array[j] -= Math.Round(a, 2);
            array[j] = Math.Round(array[j], 2);
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
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double s = 0;
        for (int i = 0; i < 5; i++)
        {
            s += vector[i] * vector[i];
        }
        length = Math.Sqrt(s);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double a = 0;
        double s = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        a = s / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > a)
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
        for (int i = 0; i < 6; i++)
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
        double a = 0;
        double s = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
        }
        a = s / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > a)
            {
                count++;
            }
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 10; i++)
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
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                k++;
            }
               
        }
        output = new double[k];
        k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
                k++;
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
        int k = 0;
        int a = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[a] = array[i];
                a++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                sum += Math.Round(array[i] * array[i], 2);
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
        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(y[i], 2);
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
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
        double maxi = -1;
        double s = 0;
        double sr = 0;
        int index = -1;

       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
            s += array[i];
        }
        sr = s / array.Length;
        for (int i = index + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(sr, 2);
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
        double sr = array.Sum() / array.Length; //среднее значение
        int index = -1;
        double min = 10000000;


        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < min)
            {
                min = Math.Abs(array[i] - sr);
                index = i;
            }
        }
        double[] b = new double[array.Length + 1];
        for (int i = 0; i <= index; i++)
        {
            b[i] = array[i];
        }
        b[index + 1] = P;
        for (int i = index + 1; i < array.Length; i++)
        {
            b[i + 1] = array[i];
        }
        array = b;
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
        double max = -10000000;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        double min = 100000000;
        int indexmin = 0;
        for (int i = indexmax; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        array[indexmin] = max;
        array[indexmax] = min;
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
        double min = 10000000;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        if (index != -1)
        {
            double[] b = new double[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    b[j++] = array[i];
                }
            }
            array = b;
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
        int index = -1;
        double max = -10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        double s = 0;
        for (int i = index + 1; i < array.Length; i++)
        {
            s += array[i];
        }
        s = Math.Round(s, 1);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = s;
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
        int index1 = -1;
        int index2 = -1;
        double max = -10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index2 = i;
                break;
            }
        }
        if (index1 != -1 && index2 != -1)
        {
            double temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
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
        double s = 0;
        double a = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        a = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < a)
            {
                k++;
            }
        }
        output = new int[k]; // инициализируем output
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] < a)
            {
                output[j++] = i;
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
        double max1 = -1; // максимум среди элементов с чётными индексами
        double max2 = -1; // максимум среди элементов с нечётными индексами
        int h = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                }
            }
            else 
            {
                if (array[i] > max2)
                {
                    max2 = array[i];
                }
            }
        }
        h = array.Length / 2;
        if (max1 > max2)
        {
            for (int i = 0; i < h; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = h; i < array.Length; i++)
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
        double min = 1000000; 
        int indexmin = -1; 
        int index1 = -1;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k == 0)
        {
            sum = 0;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index1 = i;
                    break;
                }
            }
            if (index1 < indexmin)
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
        double max = array[0];
        int k = 0; 
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += k + 1; 
                k++; 
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
        double k = 0;
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) 
            {
                k = array[i];
                a = i - 2;
                while (a >= 0 && array[a] > k)
                {
                    array[a + 2] = array[a];
                    a -= 2;
                }
                array[a + 2] = k; 
            }
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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k <= 1)
        {
            return array;
        }
        double[] mas = new double[k];
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                mas[a] = array[i];
                a++;
            }
        }
        for (int i = 0; i < mas.Length - 1; i++)
        {
            for (int j = i + 1; j < mas.Length; j++)
            {
                if (mas[i] < mas[j]) 
                {
                    double t = mas[i];
                    mas[i] = mas[j];
                    mas[j] = t; 
                }
            }
        }
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = mas[l];
                l++;
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

        // code he..re
        X = new double[n];
        Y = new double[n];
        double x;
        globalMax = Y[0];
        globalMin = Y[0];
        double step = (b - a) / (n - 1);  // вычисление шага
        for (int i = 0; i < n; i++)
        {
            x = a + i * step;
            X[i] = x;
            Y[i] = Math.Cos(x) + x * Math.Sin(x);
        }
        globalMax = Y[0];
        globalMin = Y[0];
        for (int i = 1; i < n; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];
        }
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
        normalizedArray = new double[array.Length];
        int indexmax = 0, indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[indexmax])
            {
                indexmax = i;
            }
            if (array[i] < array[indexmin])
            {
                indexmin = i;
            }
        }
        double f = 2 / (array[indexmax] - array[indexmin]);
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = (array[i] - array[indexmin]) * f - 1;
        }

        // end

        return normalizedArray;
    }
    #endregion
}
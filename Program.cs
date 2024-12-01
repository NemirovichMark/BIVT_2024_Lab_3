using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        {
            sum += array[i];
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (sum != 0)
            {
                array[j] = Math.Round(array[j] / sum, 2);
            }
            else
            {
                array[j] = 0;
            }
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0, qty = 0; double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                qty++; sum += array[i];
            }
        }
        sr = sum / qty; for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
            {
                array[j] = sr;
            }
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
        double sum = 0, sr = 0; for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sr = sum / 5;
        for (int j = 0; j < array.Length; j++)
        {
            array[j] -= sr;
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
        double a = vector[0] * vector[0]; double b = vector[1] * vector[1];
        double c = vector[2] * vector[2]; double d = vector[3] * vector[3];
        double e = vector[4] * vector[4]; length = Math.Sqrt(a + b + c + d + e);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0, sum = 0; for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sr = sum / 7;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > sr)
            {
                array[j] = 0;
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
            if (array[i] < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sr = sum / 8;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > sr)
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
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > P) && (array[i] < Q))
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
        int index = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
            {
                output[index] = array[j];
                index++;
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
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int index1 = 0, index2 = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            even[index1] = array[i];
            index1++;
        }
        for (int j = 1; j < array.Length; j += 2)
        {
            odd[index2] = array[j];
            index2++;
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
        for (int i = 0; i < x.Length; i++)
        {
            if (0.5 * Math.Log(x[i]) >= 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
            }
        }
        for (int j = 0; j < x.Length; j++)
        {

            Console.WriteLine($"{x[j] + y[j]}");
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
        for (int j = 0; j < index; j++)
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
        double max = 0, sr = 0;
        int index = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                max = array[i];
                index = i;
            }
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int j = index + 1; j < array.Length; j++)
        {
            array[j] = sr;
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
        double sr = 0, min = 100;
        int index = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int j = 0; j < array.Length; j++)
        {
            if (Math.Abs(array[j] - sr) < min)
            {
                min = Math.Abs(array[j] - sr);
                index = j;
            }
        }
        double[] b = new double[array.Length + 1];
        for (int k = 0; k <= index; k++)
        {
            b[k] = array[k];
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
        double max = -100, min = 100;
        int maxi = 0, mini = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
        }
        for (int j = maxi; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                mini = j;
            }
        }
        array[mini] = max;
        array[maxi] = min;
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
        double min = 100;
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
        double max = -100, sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int j = index + 1; j < array.Length; j++)
        {
            sum += array[j];
        }
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
            {
                array[k] = sum;
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
        double max = -100, swap = 0;
        int maxi = 0, index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxi = i;
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                index = j;
                break;
            }
        }
        if (maxi != -1 && index != -1)
        {
            swap = array[maxi];
            array[maxi] = array[index];
            array[index] = swap;
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
        double sr = 0;
        int count = 0;
        int length = 0; // длина нового массива
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
            count++;
        }
        sr /= count;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < sr)
            {
                length++;
            }
        }
        output = new int[length];
        for (int g = 0, k = 0; g < array.Length; g++)
        {
            if (array[g] < sr)
            {
                output[k++] = g;
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
        double maxeven = -1, maxodd = -1; 
        int middle = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxeven)
                {
                    maxeven = array[i];
                }
            }
            else
            {
                if (array[i] > maxodd)
                {
                    maxodd = array[i];
                }
            }
        }
        middle = array.Length / 2;
        if (maxeven > maxodd)
        {
            for (int j = 0; j < middle; j++)
            {
                array[j] = 0;
            }
        }
        else
        {
            for (int k = middle; k < array.Length; k++)
            {
                array[k] = 0;
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
        double min = 100, n = 0;
        int mini = 0, indexodd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                mini = i;
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                n = array[j];
                indexodd = j;
                break;
            }
        }
        for (int k = 0; k < array.Length; k++)
        {
            if (n == 0)
            {
                if (k % 2 != 0)
                    sum += array[k];
            }
            else if (indexodd < mini)
            {
                if (k % 2 == 0)
                    sum += array[k];
            }
            else
            {
                if (k % 2 != 0)
                    sum += array[k];
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
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int j = 0, k = 0; j < array.Length; j++)
        {
            if (array[j] == max)
            {
                array[j] += k + 1;
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
        double num = 0;
        int prev = 0; //предыдущее чётное число
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                num = array[i];
                for (prev = i - 2; prev >= 0 && array[prev] > num; prev -= 2)
                {
                    array[prev + 2] = array[prev];
                }
                array[prev + 2] = num;
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
        int length = 0; //длина из отрицательных чисел
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                length++;
            }
        }
        if (length <= 1)
        {
            return array;
        }
        double[] mas = new double[length];
        int index = 0; //индекс отрицательных чисел из нового массива
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                mas[index] = array[j];
                index++;
            }
        }
        for (int i = 0; i < mas.Length; i++)
        {
            for (int j = i + 1; j < mas.Length; j++)
            {
                if (mas[i] < mas[j])
                {
                    double zamena = mas[i];
                    mas[i] = mas[j];
                    mas[j] = zamena;
                }
            }
        }
        int l = 0;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
            {
                array[k] = mas[l];
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

        // code here
        X = new double[n];
        Y = new double[n];
        double x;
        globalMax = Y[0];
        globalMin = Y[0];
        double step = (b - a) / (n - 1); 
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
        int maxi = 0, mini = 0;
        double x = 0;
        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxi])
            {
                maxi = i;
            }
            if (array[i] < array[mini])
            {
                mini = i;
            }
        }
        x = 2 / (array[maxi] - array[mini]);
        for (int j = 0; j < array.Length; j++)
        {
            normalizedArray[j] = (array[j] - array[mini]) * x - 1;
        }
        // end

        return normalizedArray;
    }
    #endregion
}

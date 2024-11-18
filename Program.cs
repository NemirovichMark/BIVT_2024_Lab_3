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
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) { s += array[i]; count++; }
        }
        s = Math.Round(s / count, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = s;
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
        double s = 0, count = 0;
        for (int i = 0; i < 5; i++) { s += array[i]; }
        count = s / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= count;
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

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, count = 0;
        for (int i = 0; i < 7; i++) { s += array[i]; }
        count = s / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > count) { array[i] = 0; }
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
            if (array[i] < 0) { count++; }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < 8; i++) { s += array[i]; }
        sr = s / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) { count ++; }
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
            if (array[i] < Q && array[i] > P) { count++; }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int s = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0) { s++; }
        }
        output = new double[s];
        s = 0;
        for (int i = 0; i < 10; i++)
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
        int s = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[s] = array[i];
                s++;
            }
        }
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 != 0)
            {
                odd[n] = array[i];
                n++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11 && array[i] >= 0; i++) { sum += array[i] * array[i]; }
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
            if (y[i] < 0) { y[i] = double.NaN; }
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
        double min = 1000;
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                s = i;
            }
        }
        if (array[s] > 0) { array[s] *= 2; }
        else { array[s] /= 2; }
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
        double min = 1000;
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                s = i;
            }
        }
        for (int i = 0; i < s; i++)
        {
            if (array[i] >= 0) { array[i] *= 2; }
            else { array[i] /= 2; }
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
        int imax = 0, imin = 0;
        int s = 0;
        double max = -1000, min = 1000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        if (imin > imax)
        {
            var p = imin;
            imin = imax;
            imax = p;
        }
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0) { s++; }
        }
        double[] n = new double[s];
        s = 0;
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                n[s] = array[i];
                s++;
            }
        }
        array = n;
        // end

        return array;
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
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max]) { max = i; }
        }
        if (max + 1 < array.Length)
        {
            if (array[max + 1] > 0) { array[max + 1] *= 2; }
            else { array[max + 1] /= 2; }
        }
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
        double s = 0;
        int count = 0;
        double max = -1000, min = 1000;
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        int imin2 = Math.Min(imax, imin);
        int imax2 = Math.Max(imin, imax);
        for (int i = imin2 + 1; i < imax2; i++)
        {
            s += array[i];
            count++;
        }
        if (imin2 + 1 == imax2) { return 0; }
        else { average = s / count; }
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
        int s = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { s = i; }
        }
        if (s != -1)
        {
            double[] answer = new double[array.Length + 1];
            for (int i = 0, n = 0; i < answer.Length; i++)
            {
                if (s + 1 != i)
                {
                    answer[i] = array[n];
                    n++;
                }
                else { answer[i] = P; }
            }
            return answer;
        }
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
        double max = -1000;
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    s = i;
                }
            }
        }
        array[s] = s;
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
        output = new double[A.Length + B.Length];
        if (k >= A.Length) { return A; }
        for (int i = 0; i < B.Length; i++) { output[k + i + 1] = B[i]; }
        for (int i = k + 1; i < A.Length; i++) { output[B.Length + i] = A[i]; }
        for (int i = 0; i <= k; i++) { output[i] = A[i]; }
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
        int imax = 0, imin = 0, a = 0, b = 0;
        double s1 = 0, s2 = 0;
        double max = -1000, min = 1000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s1 += array[i];
                a++;
            }
            if (array[i] < 0)
            {
                s2 += array[i];
                b++;
            }
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            if (a == 0) { return 0; }
            average = s1 / a;
        }
        if (imin < imax)
        {
            if (b == 0) { return 0; }
            average = s2 / b;
        }
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
        int k = 0;
        double max = -1000, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        if (max > s) { array[k] = 0; }
        if (max <= s) { array[k] = array[k] * 2; }
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
        double max = -1000;
        int maxin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxin = i;
            }
        }
        double s = 0;
        for (int i = 1; i < maxin; i += 2)
        {
            s = array[i];
            array[i] = array[i - 1];
            array[i - 1] = s;
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
        int maxcount = -1000;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < (array[i - 1])) { count++; }
            else count = 0;
            if (count > maxcount) { maxcount = count; }
        }
        count = maxcount + 1;
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
        int k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1]) { k++; }
            else
            {
                count = Math.Max(count, k);
                k = 1;
            }
        }
        count = Math.Max(count, k);
        k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1]) { k++; }
            else
            {
                count = Math.Max(count, k);
                k = 1;
            }
        }
        count = Math.Max(count, k);
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { count++; }
        }
        double[] k = new double[array.Length - count];
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                k[s] = array[i];
                s++;
            }
        }
        array = k;
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
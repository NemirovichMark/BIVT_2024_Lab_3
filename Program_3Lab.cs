using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        foreach (double x in array) s += x;
        for (int i = 0; i < array.Length; i++)
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
        double s = 0, k = 0;
        foreach (double x in array) if (x > 0)
            {
                s += x;
                k++;
            }
        double sr = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0) array[i] = sr;
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
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, sr, k = 0;
        foreach (double x in array)
        {
            s += x;
            k++;
        }
        sr = s / k;
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i<vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0, sq = 0;

        // code here
        foreach(double x in vector)
        {
            sq += x* x;
        }
        length = Math.Round(Math.Sqrt(sq), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, k = 0;
        foreach (double x in array) {s += x;
            k++; }
        double sr = s / k;
        for (int i = 0; i < array.Length; i++) if (array[i] > sr) array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array) if (x < 0) count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, k = 0;
        foreach (double x in array)
        {
            s += x;
            k++;
        }
        double sr = s / k;
        foreach (double y in array) if (y > sr) count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k = 0;
        foreach (double x in array) if (x > 0) k++;
        output = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0, j = 0, k = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { even[j] = array[i]; j++; }
            else { odd[k] = array[i]; k++; }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array)
        {
            if (x >= 0) sum += x * x;
            else break;
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
            if (x[i] <= 0) y[i] = double.NaN;  
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length; i++)
        {
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
        double min = double.MaxValue;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) {min = array[i]; index = i; }
        }

        if (array[index] > 0) array[index] *= 2;
        else array[index] /= 2;
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
        int index_min = 0;
        double min = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; index_min = i; }
        }
        for (int i = 0; i < index_min; i++)
        {
            if (array[i] > 0) array[i] *= 2;
            else array[i] /= 2;
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
        

        int index_min = 0, index_max = 0, k = 0;
        double min = 9999, max = -9999;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; index_min = i; } //находим индексы
            else if (array[i] > max) { max = array[i]; index_max = i; }
        }
        for (int i = index_min + 1; i < index_max; i++) if (array[i] < 0) k++;

        double[] new_massive = new double[k]; // k = длина массива

        for (int i = index_min + 1, j = 0; i < index_max; i++, j++)
        {
            if (array[i] < 0) new_massive[j] = array[i]; 
        }
        array = new_massive;

        //foreach (double x in array) Console.WriteLine(x);
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
        double max = -9999;
        int index = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; index = i; }
        }

        if (index + 1 != array.Length)
            if (array[index + 1] > 0) array[index + 1] *= 2;
            else array[index + 1] /= 2;

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
        double sum = 0;
        int count = 0;

        // code here
        double max = -10000; int indexmax = 0;
        double min = 10000; int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        int indexmins = Math.Min(indexmax, indexmin);
        int indexmaxe = Math.Max(indexmin, indexmax);
        for (int i = indexmins + 1; i < indexmaxe; i++)
        {
            sum += array[i];
            count++;
        }
        if (indexmins + 1 == indexmaxe)
            return 0;
        else

            average = sum / count;
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
        int j = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) j = i;
  
        if (j != -1)
        {
            double[] vr = new double[array.Length + 1];
            for (int i = 0; i <= j; i++) vr[i] = array[i];
            vr[j + 1] = P;
            for (int i = j + 1; i < array.Length; i++) vr[i + 1] = array[i];
            array = vr;
        }
        else return array;

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
        double max = -100000;
        int imax = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max) { max = array[i]; imax = i; }
        }
        array[imax] = imax;
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
        if (k >= A.Length) return A;
        output = new double[A.Length + B.Length];
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = k + 1, c = 0; i < k + B.Length + 1; i++, c++)
        {
            output[i] = B[c];
        }
        for (int i = B.Length + k + 1, c = k + 1; i < B.Length + A.Length; i++, c++)
        {
            output[i] = A[c];
        }
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
        double average = 0, max = array[0], min = array[0], sum = 0;
        double imax = 0, imin = 0, cnt = 0;

        // code here
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; imax = i; }
            else if (array[i] < min) { min = array[i]; imin = i; }
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { sum += array[i]; cnt++; }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { sum += array[i]; cnt++; }
                if (cnt == 0) return 0;
            }
        }
        average = sum / cnt;
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
        double max = array[0], sum = 0;
        int imax = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; imax = i; }
            sum += array[i];
        }
        if (max > sum) array[imax] = 0;
        else array[imax] *= 2;
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
        
        double max = -100000000;
        int imax = -1;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; imax = i; }
        }
        for (int i = 0; i < imax - 1; i += 2)
        {
            double t = array[i];
            array[i] = array[i + 1];
            array[i + 1] = t;
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
        int cnt = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1]) cnt++;
            else
            {
                if (cnt > count) { count = cnt; }
                cnt = 1;
            }
        }
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
        int index = 1; 
        // code here

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1]) index++;
            else { count = Math.Max(count, index); index = 1; }
        }
        count = Math.Max(count, index);
        index = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1]) index++;
            else { count = Math.Max(count, index); index = 1; }
        }
        count = Math.Max(count, index);
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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) k++;
        }
        double[] a = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) { a[k] = array[i]; k++; }
        }
        array = a;
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
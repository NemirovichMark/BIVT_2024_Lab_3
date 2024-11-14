using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
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
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
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
        double s = 0, k = 0, sr;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        sr = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
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

        double s = 0, k = 0, sr;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        sr = Math.Round(s / k, 2);
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

        double s = 0, k = 0, sr;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
            k++;
        }
        sr = Math.Round(s / k, 2);
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr) array[i] = 0;
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
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, k = 0, sr;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
            k++;
        }
        sr = Math.Round(s / k, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) count++;
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
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here

        int k = 0, m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) k++;
        }
        double[] a = new double[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                a[m] = array[i];
                m++;
            }

        }
        output = a;
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
        double[] odd = new double[array.Length / 2];

        // code here

        int c = 0, nc = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[c] = array[i];
                c++;
            }
            else
            {
                odd[nc] = array[i];
                nc++;
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
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        sum = Math.Round(sum, 2);
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
        double max = 0, num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                num = i;
            }
        }
        for (int i = 0; i < num; i++)
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

        double max = 0, sum = 0, sr;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                num = i;
            }
            sum += array[i];
        }
        if (num == array.Length) return default(double[]);
        sr = sum / array.Length;
        for (int i = num + 1; i < array.Length; i++)
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

        double sum = 0, sr, min;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sr = sum / array.Length;
        min = Math.Abs(array[0] - sr);
        for (int i = 0; i < array.Length; i++)
        {
            if ((Math.Abs(array[i] - sr)) < min)
            {
                min = Math.Abs(array[i] - sr);
                num = i;
            }
        }
        double[] arr = new double[array.Length + 1];
        for (int i = 0; i <= num; i++)
        {
            arr[i] = array[i];
        }
        arr[num + 1] = P;
        for (int i = num + 2, j = num + 1; i < arr.Length; i++, j++)
        {
            arr[i] = array[j];
        }
        array = arr;
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

        double max = 0, min = 10000;
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        for (int i = imax + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            array[imax] = min;
            array[imin] = max;
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

        double min = 100;
        int imin = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] < min) && (array[i] > 0))
            {
                min = array[i];
                imin = i;
            }
        }
        if (min == 100) return array;
        double[] a = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == imin)
            {
                continue;
            }
            else
            {
                a[j] = array[i];
                j++;
            }
        }
        array = a;
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

        double max = -1000, sum = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        for (int i = imax + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
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

        double max = -1000, otr = 0;
        int imax = 0, iotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                iotr = i;
                break;
            }
        }
        if (otr < 0)
        {
            array[imax] = otr;
            array[iotr] = max;
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

        double sum = 0, sr;
        int k = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                k++;
            }
        }
        output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
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

        double max1 = 0, max2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1 && array[i] > max1) max1 = array[i];
            if (i % 2 == 0 && array[i] > max2) max2 = array[i];
        }
        if (max2 > max1)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
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

        double min = 1000;
        int imin = 0, iotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                iotr = i;
                break;
            }
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

        double max = double.MinValue;
        int k = 0, j = 0;
        int[] a = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) 
            { 
                k++; 
                a[k] = i; 
            }
            if (array[i] > max) 
            { 
                max = array[i]; 
                k = 0; 
                a[k] = i; 
            }
        }
        output = new int[k+1];
        for (int i = 0; i < k+1; i++)
        {
            output[i] = a[i];
        }
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

        double max = array[0];
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (max <= array[i]) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (max == array[i])
            {
                double sum = 0;
                for (int j = 0; j < i; j++) sum += array[j];
                a[i] = sum;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (max == array[i]) array[i] = a[i];
        }
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

        int k = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                for (int j = i; j < array.Length - k - 1; j++)
                {
                    double t = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;
                }
                k++;
            }
        }
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

        double[] a = new double[array.Length];
        for (int i = 0; i < a.Length / 2; i++)
        {
            a[2 * i] = array[i];
            a[2 * i + 1] = array[i];
        }
        array = a;
        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

        // end

        return (X, Y, globalMax, globalMin);
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
        int nepovt = 0, n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int k = 0;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    k = 1;
                    break;
                }

            }
            if (k == 0) nepovt++;
        }
        double[] a = new double[nepovt];
        for (int i = 0; i < array.Length; i++)
        {
            int k = 0;
            for (int j = 0; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    k = 1;
                    break;
                }

            }
            if (k == 0)
            {
                a[n++] = array[i];
            }
        }
        array = a;
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
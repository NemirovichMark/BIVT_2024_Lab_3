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
        double s = 0;
        for(int i = 0;i<array.Length;i++) s += array[i];
        for(int j = 0;j<array.Length;j++)
        {
            if (s == 0) array[j] = 0;
            else array[j] = array[j]/s;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] > 0)
            {
                s+= array[i];
                k++;
            }
        }
        for(int j=0;j<array.Length;j++)
        {
            if (array[j] > 0) array[j] = s / k;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0;i<sum.Length;i++) sum[i] = first[i] + second[i];
        for(int j = 0;j<dif.Length;j++) dif[j] = first[j] - second[j];
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for(int i = 0;i<array.Length;i++)
        {
            s += array[i];
            k++;
        }
        for (int j = 0; j < array.Length; j++) array[j] = array[j] - s / k;
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        double s = 0;
        // code here
        for (int i = 0; i < vector1.Length; i++) s += vector1[i] * vector2[i];
        product = Math.Round(s,2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double s = 0;
        // code here
        for (int i = 0; i < vector.Length; i++) s += Math.Pow(vector[i], 2);
        length = Math.Sqrt(s);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for (int i = 0;i<array.Length;i++)
        {
            s += array[i];
            k++;
        }
        for(int j = 0; j < array.Length;j++)
        {
            if (array[j] > (s / k)) array[j] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i]<0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;
        int k = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            s += array[i];
            k++;
        }
        for(int j = 0;j<array.Length;j++)
        {
            if (array[j] > (s / k)) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if (P < 0 && Q > array.Length) return 0;
        for(int i = P;i<array.Length;i++)
        {
            if (array[i] > P && array[i] < Q) count++;

        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int n = 0;
        // code here
        for (int i = 0;i < array.Length;i++)
        {
            if (array[i] > 0) n++;
        }
        output = new double[n];
        int k = 0;
        for(int j = 0;j < array.Length;j++)
        {
            if (array[j] > 0)
            {
                output[k] = array[j];
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
        for(int i = array.Length - 1;i>=0;i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int k = 0, n = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            if (i%2==0 || i==0)
            {
                even[k] = array[i];
                k++;
            }
            else
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
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] < 0) break;
            sum += Math.Pow(array[i],2);
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        int k = 0;
        // code here
        for (int i = 0;i<x.Length;i++)
        {
            if (x[i] != 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = Double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double m = array[0];
        int k = 0;
        // code here
        for (int i = 1;i<array.Length;i++)
        {
            if (m > array[i])
            {
                m = array[i];
                k = i;
            }
        }
        if (array[k] > 0) array[k] = m * 2;
        else array[k] = m / 2;
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
        double m = array[0];
        int k = 0;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (m > array[i])
            {
                m = array[i];
                k = i;
            }
        }
        for(int j = 0;j<k;j++)
        {
            if (array[j] > 0) array[j] = Math.Round(array[j] * 2, 2);
            else array[j] = Math.Round(array[j] / 2, 2);
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
        double ma = array[0], mi = array[0];
        int k = 0, n = 0,b = 0,h = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            if (ma < array[i])
            {
                ma = array[i];
                k = i;
            }
            if (mi > array[i])
            {
                mi = array[i];
                n = i;
            }
        }
        for (int j = Math.Min(k, n) + 1; j < Math.Max(k, n); j++)
        {
            if (array[j] < 0) b++;
        }
        double[] a = new double[b];
        for(int l = Math.Min(k,n)+1;l<Math.Max(k,n);l++)
        {
            if (array[l] < 0)
            {
                a[h] = array[l];
                h++;
            }
        }
        // end

        return a;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double s = array[0];
        int k = 0;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (s < array[i])
            {
                s = array[i];
                k = i;
            }
        }
        if (k == array.Length - 1) return array;
        else if (array[k + 1] > 0) array[k + 1] *= 2;
        else array[k + 1] = array[k + 1] / 2;
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
        double mi = array[0], ma = array[0],s = 0;
        int k1 = 0, k2 = 0,k = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            if(ma<array[i])
            {
                ma = array[i];
                k1 = i;
            }
            if (mi > array[i])
            {
                mi = array[i];
                k2 = i;
            }
        }
        for(int j = Math.Min(k1,k2)+1;j < Math.Max(k1,k2);j++)
        {
            s += array[j];
            k++;
        }
        if (k == 0) return 0;
        average = Math.Round(s / k, 4);
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
        double s = 0;
        int k = 0;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] > 0) k = i;
        }
        if (k == 0) return array;
        double[] a = new double[array.Length+1];
        for (int j = 0; j < array.Length + 1; j++)
        {
            if (j < k + 1) a[j] = array[j];
            else if (j == k + 1) a[j] = P;
            else a[j] = array[j - 1];
        }
        // end

        return a;
    }
    public double[] Task_2_12(double[] array)
    {
        
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        double m = array[0];
        int k = 0;
        // code here
        for(int i = 0;i< array.Length;i+=2)
        {
            if (m < array[i])
            {
                m = array[i];
                k = i;
            }
        }
        array[k] = k;
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
        output = new double[A.Length+B.Length];
        if (k == A.Length || k > A.Length) return A;
        if (k < 0) k = 0;
        k++;
        for(int i = 0;i<A.Length;i++)
        {
            if (i < k) output[i] = A[i];
            else if (i == k)
            {
                for(int j = 0;j<B.Length;j++) output[k+j] = B[j];
            }
            output[i+B.Length] = A[i];
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
        double average = 0;
        double ma = array[0], mi = array[0];
        int k1 = 0, k2 = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            if (ma < array[i])
            {
                ma = array[i];
                k1 = i;
            }
            if (mi > array[i])
            {
                mi = array[i];
                k2 = i;
            }
        }
        if (k1 < k2)
        {
            double s1 = 0;
            int k3 = 0;
            for (int j = 0;j<array.Length;j++)
            {
                if (array[j] > 0)
                {
                    s1 += array[j];
                    k3++;
                }
            }
            if (k3 == 0) return 0;
            average = Math.Round(s1 / k3, 3);
        }
        else
        {
            double s2 = 0;
            int k4 = 0;
            for(int l = 0;l<array.Length;l++)
            {
                if (array[l] < 0)
                {
                    s2 += array[l];
                    k4++;
                }
            }
            if (k4 == 0) return 0;
            average = Math.Round(s2/k4, 2);
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
        double s = 0, m = array[0];
        int k = 0;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (m < array[i])
            {
                m = array[i];
                k = i;
            }
            s += array[i];
        }
        if (array[k] > s) array[k] = 0;
        else array[k] *= 2;
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
        double ma = array[0];
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            if (ma < array[i]) ma = array[i];
        }
        int k = 1;
        for (int j = 0;j<array.Length;j++)
        {
            if (array[j] == ma)
            {
                array[j] = ma + k;
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
        for (int i = 0;i<array.Length;)
        {
            if (i == 0 || array[i] >= array[i - 2]) i += 2;
            else
            {
                var p = array[i];
                array[i] = array[i - 2];
                array[i - 2] = p;
                i -= 2;
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
        int k = 0,h = 0;
        // code here
        for (int i = 0; i<array.Length;i++)
        {
            if (array[i] < 0) k++;
        }
        double[] a = new double[k];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                a[h] = array[j];
                h++;
            }
        }
        for (int l = 1;l < a.Length;l++)
        {
            double key = a[l];
            int n = l - 1;
            while (n >= 0 && a[n] < key)
            {
                a[n + 1] = a[n];
                n--;
            }
            a[n+1] = key;
        }
        h = 0;
        for (int x = 0; x < array.Length;x++)
        {
            if (array[x] < 0)
            {
                array[x] = a[h];
                h++;
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
        X = new double[n]; Y = new double[n];
        double s = Math.Round((b - a) / (n - 1),2);
        int k = 0;
        for (double i = a; i <= b; i += s)
        {
            double m = Math.Cos(i) + i * Math.Sin(i);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(m, 2);
            k++;
            if (m > globalMax) globalMax = m;
            if (m < globalMin) globalMin = m;
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
        double ma = array[0], mi = array[0];
        for (int i = 0;i<array.Length;i++)
        {
            if (array[i] < mi) mi = array[i];
            if (array[i] > ma) ma = array[i];
        }
        normalizedArray = new double[array.Length];
        for (int j = 0;j < array.Length;j++)
        {
            normalizedArray[j] = Math.Round(2 * (array[j] - mi) / (ma - mi) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
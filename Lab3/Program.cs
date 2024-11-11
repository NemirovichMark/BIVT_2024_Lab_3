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
        foreach(double x in array)
        {
            s += x;
        }
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, k = 0 ;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s += x;
                k++;
            }
        }
        s=Math.Round(s/k, 2);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = s;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < sum.Length; i++)
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
        foreach(double x in array)
        {
            s += x;
        }
        s=Math.Round(s/array.Length, 2);
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-s, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
        {
            product += Math.Round(vector1[i] * vector2[i], 2);
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach(double x in vector)
        {
            length += x*x;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach(double x in array)
        {
            s += x;
        }
        s = Math.Round(s / array.Length, 2);
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > s) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach(double x in array)
        {
            if(x<0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        foreach (double x in array) s += x;
        s=Math.Round(s / array.Length,2);
        foreach(double x in array)
        {
            if (x > s) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double x in array)
        {
            if((x>P)&&(x<Q)) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach(double x in array)
        {
            if (x > 0) count++;
        }
        output = new double[count];
        count = 0;
        foreach(double x in array)
        {
            if(x>0) output[count++] = x;
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < array.Length; i++)
        {
            if(i%2==0) even[i/2] = array[i];
            else odd[i/2] = array[i];
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach(double x in array)
        {
            if (x < 0) break;
            else sum += x*x;
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
            if (x[i] == 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        //double min=array[0];
        //int n=0;
        //for(int i=1; i < array.Length; i++)
        //{
        //    if (array[i] < min)
        //    {
        //        min= array[i];
        //        n = i;
        //    }
        //}
        //array[n] *=2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int n = 0;
        double max = array[0];
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                n = i;
            }
        }
        for (int i = 0; i < n; i++) sum += array[i];
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
        int n=0;
        double max = array[0], sr=array[0];
        for(int i = 1; i < array.Length; i++)
        {
            sr += array[i];
            if (array[i] > max)
            {
                max = array[i];
                n = i;
            }
        }
        sr /= array.Length;
        for(int i=array.Length-1; i > n; i--)
        {
            array[i] = Math.Round(sr,2);
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
        double diff = 0, sr = 0;
        double[] x= new double[array.Length+1];
        int n = 0;
        foreach (double y in array) sr += y;
        sr /= array.Length;
        diff = Math.Abs(array[0] - sr);
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < diff)
            {
                n = i;
                diff = Math.Abs(array[i] - sr);
            }
        }
        for (int i = 0; i <= n; i++)
        {
            x[i] = array[i];
        }
        x[n + 1] = P;
        for(int i = n + 2; i < x.Length; i++)
        {
            x[i] = array[i - 1];
        }
        array = x;
        Console.WriteLine(array);
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
        double max = array[0], min = array[0], t;
        int n_max = 0, n_min = 0;
        for(int i=1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                n_max = i;
                max=array[i];
            }
        }
        if (n_max < array.Length - 1)
        {
            min = array[n_max + 1];
            n_min = n_max + 1;
        }
        else n_min = n_max;
        for(int i=n_max+1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                n_min = i;
                min = array[i];
            }
        }
        t=array[n_max];
        array[n_max] = array[n_min];
        array[n_min] = t;
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
        double[] x= new double[array.Length-1];
        double min=0;
        int n = 0;
        foreach (double d in array)
        {
            if(d>0)
            {
                min = d;
                break;
            }
        }
        if (min != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] <= min) && (array[i]>0))
                {
                    n = i;
                    min = array[i];
                }
            }
            for (int i = 0; i < n; i++) x[i] = array[i];
            for (int i = n; i < array.Length-1; i++) x[i] = array[i+1];
            array = x;
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
        double max = array[0], sum=0;
        int n = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                n = i;
                max = array[i];
            }
        }
        for(int i = n+1; i < array.Length; i++) sum+= array[i];
        for(int i=0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = Math.Round(sum,2);
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
        double max = array[0];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                n = i;
                max = array[i];
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                double t = array[i];
                array[i] = array[n];
                array[n] = t;
                break;
            }
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
        int[] x = new int[array.Length];
        double sr = 0;
        int count = 0;
        foreach (double d in array) sr += d;
        sr/= array.Length;
        for(int i=0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                x[count] = i;
                count++;
            }
        }
        int[] y = new int[count];
        for (int i = 0; i < y.Length; i++) y[i] = x[i];
        output = y;
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
        double max_ch = array[0], max_ne = array[1];
        //int ch = 0, ne = 1;
        for(int i = 1; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max_ch)
                {
                    max_ch = array[i];
                }
            }
            else
            {
                if (array[i] > max_ne)
                {
                    max_ne = array[i];
                }
            }
        }
        if (max_ch > max_ne)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;
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
        int count = 0, m=1;
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                m = i;
            }
        }
        foreach(double x in array)
        {
            if (x < 0)
            {
                break;
            }
            count++;
        }
        if (count < m)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                sum += array[2 * i];
            }
        }
        else
        {
            for (int i = 0; i <= array.Length / 2-1; i++)
            {
                sum += array[2 * i+1];
            }
        }
        if (count == array.Length) sum = 0;
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double max=array[0];
        int count = 0;
        int[] x=new int[array.Length];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                count = 0;
                max = array[i];
            }
            if (array[i] == max)
            {
                x[count] = i;
                count++;
            }
        }
        int[] y = new int[count];
        for(int i=0; i < count; i++)
        {
            y[i] = x[i];
        }
        output = y;
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
        double max = array[0], s=0;
        int count = 0;
        int[] x = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                count = 0;
                max = array[i];
            }
            if (array[i] == max)
            {
                x[count] = i;
                count++;
            }
        }
        int[] y = new int[count];
        for (int i = 0; i < count; i++)
        {
            y[i] = x[i];
        }
        for(int i=y.Length-1; i>=0; i--)
        {
            s = 0;
            for(int j = 0; j < y[i]; j++)
            {
                s += array[j];
            }
            array[y[i]] = s;
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
        //double[] x = new double[array.Length];
        //int count = 0, n=0;
        //for(int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        x[count] = i;
        //        count++;
        //    }
        //}
        //n = count;
        //count = 0;
        //double[] y = new double[n];
        //for(int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] < 0)
        //    {
        //        y[count] = array[i];
        //        count++;
        //    }
        //}
        int count = 0;
        for(int i=array.Length-1; i >=0; i--)
        {
            if (array[i] < 0)
            {
                for(int j = i; j < array.Length-count-1; j++)
                {
                    double t=array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = t;
                }
                count++;
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
        double[]x = new double[array.Length];
        for(int i=0; i < array.Length/2; i++)
        {
            x[2*i]=array[i];
            x[2*i+1]=array[i];
        }
        array = x;
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
        double[]x=new double[array.Length];
        int count = 0, s, count_0=0;
        for(int i = 0; i < array.Length; i++)
        {
            if((array[i] == 0)&&(count_0==0))
            {
                x[count] = 0;
                count_0++;
                count++;
            }
            s = 0;
            foreach(double d in x)
            {
                if (d == array[i]) s++;
            }
            if (s == 0)
            {
                x[count] = array[i];
                count++;
            }
        }
        double[] y= new double[count];
        for(int i = 0;i < count; i++)
        {
            y[i] = x[i];
        }
        array = y;
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
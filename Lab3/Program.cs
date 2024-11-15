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
        //program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
        //program.Task_1_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 1.8, 2.4 }, 2, 10);
        //program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_2_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 },2.3);
        //program.Task_2_10(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_18(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_7(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_10(new double[] { 5, 2, 8, 1, 9, 0, 0, 0, 0, 0 });
        //program.Task_3_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double answer = 0;
        for (int i = 0; i< array.Length; i++)
        {
            answer += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/answer,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0;
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { sr += array[i]; a++; }
        }
        sr = Math.Round(sr /a,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { array[i] = sr; }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; i++)
            {
                sum[i] = Math.Round(first[i] + second[i],2);
                dif[i] = Math.Round(first[i] - second[i], 2);
            }

        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            a += array[i];
        }
        a /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i]= Math.Round(array[i] - a, 2);
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
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += Math.Pow(vector[i],2);
        }
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum)
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
        for (int i = 0; i < array.Length; i++)
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum) { count++; }
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
            if (array[i] > P && array[i] < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = [];

        // code here
        int n = 0;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
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
        for (int i = 0; i< array.Length; i++)
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
        int o = 0, e = 0;
        for (int i = 1; i< array.Length+1; i++)
        {
            if (i % 2 == 0)
            {
                odd[o] = array[i-1];
                o++;
            }
            else
            {
                even[e] = array[i-1];
                e++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < 0) { break; }
            sum += Math.Pow(array[i],2);
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i< x.Length; i++)
        {
            if (x[i] <= 0) { y[i] = double.NaN; continue; }
            y[i] = Math.Round (0.5* Math.Log(x[i], Math.E));
        }
        Console.WriteLine(string.Join("\n",x));
        Console.WriteLine(string.Join("\n", y));
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
        double m = 0, d = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                sum += d;
                d = 0;
            }
            d += array[i];
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
        double m = 0, d = 0;
        bool flag = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];

            }
            d += array[i];
        }
        d /= array.Length;
        d = Math.Round(d,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (flag == true)
            {
                array[i] = d;
            }
            if (array[i] == m)
            {
                flag = true;
            }   
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
        double m = 999999, d = 0;
        int sd = 0;
        int u = 0;
        double[] l = new double[array.Length+1];
        for (int i = 0; i < array.Length; i++)
        {
            d += array[i];
        }
        d /= array.Length;
        Console.WriteLine(d);
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - d) < m)
            {
                m = Math.Abs(array[i] - d);
                sd = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i == sd) 
            { 
                u = 1; 
                l[i + 1] = P; 
                l[i] = array[i];
            }
            else { l[i + u] = array[i]; }
        }
        array = l;
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
        double  ma = -999999, mi = 999999;
        int mae = 0, mie = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ma)
            {
                ma=array[i];
                mae = i;
                mi = 9999999999;
            }
            if (array[i] < mi)
            {
                mi = array[i];
                mie = i;
            }
        }
        array[mie] = ma;
        array[mae] = mi;
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
        double mi = 99999;
        int flag = 0;
        double[] j= new double[array.Length-1];
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (mi > array[i] && array[i]>0)
            {
                mi = array[i];
            }
        }
        if (mi == 99999)
        {
            return array;
        }
        Console.WriteLine(mi);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mi) 
            {
                Console.WriteLine(i);
                flag = 1; 
            }
            else
            {
                j[i-flag] = array[i];
            }
        }
        array = j;
        Console.WriteLine(string.Join(" ", array));
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
        int op = -1;
        double su = 0, m =-99999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && op == -1) { op = i; }
            su += array[i];
            if (array[i] > m) { m = array[i]; su = 0; }
        }
        if (op == -1){ return array; }
        su = Math.Round(su,2);
        array[op] = su;
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
        double m = -9999, p=0;
        int y = 0, op = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && op == -1) { op = i; }
            if (array[i] > m) { m = array[i]; y = i; }
        }
        if (op == -1){ return array; }
        p = array[op];
        array[op] = array[y];
        array[y] = p;
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
        double sum = 0;
        int k = 0, l =0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
        for(int i = 0; i < array.Length; i++)
        {
            if (sum > array[i]) { k++; }
        }
        output = new int[k];
        for(int i = 0; i < array.Length; i++)
        {
            if (sum > array[i]) { output[l] = i; l++; }
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
        double m = -9999;
        int n = 0, f = 1, b = array.Length/2;
        for(int i = 0; i < array.Length; i++)
        {
            if ((double)array[i] > m) { m = array[i]; n = i % 2; }
        }
        Console.WriteLine(n);
        b = b * n;
        if (array.Length %2 == 0) { f = 0; }
        for (int i = b; i< array.Length/2+b+f; i++)
        {
            array[i] = 0;
        }
        Console.WriteLine(string.Join(" ",array));
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
        int y = 0, op = -1, l=0;
        double mi = 9999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && op == -1) { op = i; }
            if (array[i] < mi) { mi = array[i]; y = i; }
        }
        if (op >= y) { l=1; }
        for (int i = l; i < array.Length; i += 2)
        {
            sum +=array[i];
        }
        if(op == -1) {sum = 0; }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double ma = -99999;
        int count = 0;
        int[] s = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > ma)
            {
                count = 0;
                ma= array[i];
            }
            if (array[i] == ma)
            {
                s[count] = i;
                count++;
            }
        }
        output = new int[count];
        for (int i = 0; i < count; i++)
        {
            output[i] = s[i];
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
        int[] s = new int[array.Length];
        double max = -9999, su = 0,d=0;
        for (int i = 0; i < array.Length; i++)
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
                d= su;
                su += array[i];
                array[i] = d;
            }
            else
            {
                su += array[i];
            }
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
        int ko = 0, m = 0;
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ko++;
            }
        }
        Console.WriteLine(ko);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a[i - m] = array[i];
            }
            else
            {
                a[a.Length - ko] = array[i];
                ko--;
                m++;
            }
        }
        array = a;
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine(string.Join(" ", a));
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
        double [] a = new double[array.Length];
        for (int i = 1;i< array.Length; i+=2)
        {
            a[i - 1] = array[(i - 1) / 2];
            a[i] = array[(i - 1) / 2];
        }
        Console.WriteLine(string.Join(" ", a));
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
        bool flag = false;
        int kn = 0;
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            flag = false;
            for(int c = 0; c<kn; c++)
            {
                if (Math.Abs(array[i] - a[c]) < 0.005)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                a[kn] = array[i];
                Console.WriteLine(a[kn]);
                kn++;
            }
        }
        array = new double[kn];
        for (int i = 0; i < kn; i++)
        {
            array[i] = a[i];
        }
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
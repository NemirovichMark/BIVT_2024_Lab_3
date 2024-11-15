using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        for (int i = 0; i < 6; i++) s += array[i];
        for (int i = 0; i < 6; i++) array[i] = Math.Round(array[i] / s, 2);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, n=0;
        for (int i =0; i<8; i++)
        {
            if (array[i]>0)
            {
                s += array[i];
                n++;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(array[i] = s / n, 2);
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end


        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 5; i++) s += array[i];
        for (int i = 0; i < 5; i++) array[i] = Math.Round(array[i] - (s / 5), 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++) product += vector1[i] * vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++) length += vector[i] * vector[i];
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 7; i++) s += array[i];
        for (int i=0; i<7; i++)
        {
            if (array[i]>(s / 7)) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i =0; i<6; i++)
        {
            if (array[i] < 0) count += 1;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        for(int i =0; i<8; i++) s += array[i];
        for (int i =0; i<8; i++)
        {
            if (array[i] > s / 8) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i=0; i<10; i++)
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
        int n = 0;
        for (int i=0; i<10; i++)
        {
            if (array[i] > 0) n++;
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
            }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i =0; i<8; i++)
        {
            if (array[i]<0)
            {
                index = i;
                value = array[i];
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
        int nE = 0, nO = 0;
        for (int i =0; i<10; i++)
        {
            if (i % 2 == 0)
            {
                even[nE] = array[i];
                nE++;
            }
            else
            {
                odd[nO] = array[i];
                nO++;
            }

        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int q = 0;
        for (int i=0; i<11; i++)
        {
            if (array[i]<0)
            {
                q = i;
                break;
            }
            else q = 11;
        }
        for (int i = 0; i < q; i++)
        {
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i=0; i<x.Length; i++)
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double mx = 0;
        int n = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]>mx)
            {
                mx = array[i];
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
        double mx = 0, s = 0;
        int n = 0;
        for(int i=0; i<array.Length;i++)
        {
            if (array[i]>mx)
            {
                mx = array[i];
                n = i;
            }
            s += array[i];
        }
        double sr = Math.Round(s / array.Length, 2);
        for (int i = n + 1; i < array.Length; i++) array[i] = sr;
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
        double s = 0, rz = 1000000;
        int n = 0;
        for (int i = 0; i < array.Length; i++) s += array[i];
        double sr = Math.Round(s / array.Length, 2);
        for( int i =0; i<array.Length; i++)
        {
            if (Math.Abs(array[i]-sr)<rz)
            {
                rz = Math.Abs(array[i] - sr);
                n = i;
            }
        }
        double[] array0 = new double[array.Length + 1];
        int k = n + 1;
        for (int i = 0; i <= n; i++) array0[i] = array[i];
        array0[n + 1] = P;
        for (int i=n+2; i<array.Length+1; i++)
        {
            array0[i] = array[k];
            k++;
        }
        array = array0;
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
        double mx = 0, mn = 100000000;
        int n1 = 0, n2 = 0;
        for(int i =0; i<array.Length; i++)
        {
            if (array[i]>mx)
            {
                mx = array[i];
                n1 = i;
            }
        }
        for (int i=n1; i<array.Length; i++)
        {
            if (array[i]>mx)
            {
                mx = array[i];
                n1 = i;
            }
        }
        for (int i=n1; i<array.Length; i++)
        {
            if (array[i]<mn)
            {
                mn = array[i];
                n2 = i;
            }
        }
        array[n1] = mn;
        array[n2] = mx;
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
        double mn = 1000000;
        int n = 0, q=0;
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > 0) q++;
        }
        if (q == 0) return array;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]<mn && array[i]>0)
            {
                n = i;
                mn = array[i];
            }
        }
        double[] array1 = new double[array.Length - 1];
        int k = 0;
        for (int i =0; i<array.Length; i++)
        {
            if (i!= n)
            {
                array1[k] = array[i];
                k++;
            }
        }
        array = array1;
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
        double s = 0, mx = -1000000;
        int n = 0;
        for ( int i =0; i<array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                n = i;
            }
        }
        for (int i = n + 1; i < array.Length; i++) s += array[i];
        s = Math.Round(s, 2);
        for ( int i=0; i< array.Length; i++)
        {
            if (array[i]<0)
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
        double mx = -100000000, q = 0;
        int n1 = 0, n2 = 0, k=0;
        for ( int i = 0; i<array.Length; i++)
        {
            if (array[i] < 0) k++;
        }
        if (k == 0) return array;
        for ( int i=0; i< array.Length; i++)
            if (array[i]>mx)
            {
                mx = array[i];
                n1 = i;
            }
        for (int i = 0; i < array.Length; i++)
            if (array[i] < 0)
            {
                q = array[i];
                n2 = i;
                break;
            }
        array[n1] = q;
        array[n2] = mx;
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
        int n = 0;
        for (int i = 0; i < array.Length; i++) sr += array[i];
        sr /= array.Length;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < sr) n++;
        int[] nw = new int[n];
        int k = 0;
        for ( int i=0; i<array.Length; i++)
            if (array[i]<sr)
            {
                nw[k] = i;
                k++;
            }
        output = nw;
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
        double mx1 = 0, mx2 = 0;
        for ( int i =0; i<array.Length; i++)
        {
            if (i % 2 == 0)
                if (array[i] > mx1) mx1 = array[i];
            if (i % 2 != 0)
                if (array[i] > mx2) mx2 = array[i];
        }
        if (mx1>mx2)
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
        int n1 = 0, n2 = 0;
        double mn = 1000000000;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < mn) n1 = i;
        for (int i = 0; i< array.Length; i++)
            if (array[i]<0)
            {
                n2 = i;
                break;
            }
        int k = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < 0) k++;
        if (k == 0) return 0;
        if (n1>n2)
        {
            for (int i=0; i<array.Length; i+=2) sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
                sum += array[i];
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
        int[] w = new int[array.Length];
        int n = 0;
        double q = array[0];
        for (int i =0; i<array.Length; i++)
        {
            if (array[i]>q)
            {
                q = array[i];
                n=0;
            }
            if (array[i] == q)
            {
                w[n]=i;
                n++;
            }
        }
        int[] z = new int[n];
        for (int i = 0; i < n; i++) z[i] = w[i];
        output = z;
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
        double mx = -100000000, s = 0;
        int m = 0;
        double[] q = new double[array.Length];
        for (int i = 0; i < array.Length; i++) q[i] = array[i];
        for (int i =0; i<array.Length; i++)
        {
            if (array[i] > mx) mx = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==mx)
            {
                for (int j =0; j<i; j++) s += q[j];
            array[i] = s;
            s = 0;
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
        int c = 0;
        double[] q = new double[array.Length];
        for( int i = 0; i<array.Length; i++)
        {
            if (array[i]>=0)
            {
                q[c] = array[i];
                c++;
            }
        }
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]<0)
            {
                q[c] = array[i];
                c++;
            }
        }
        array = q;
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
        int c = 0;
        double[] q = new double[array.Length];
        for (int i = 0; i < array.Length/2; i++)
        {
            q[c] = array[i];
            q[c+1] = array[i];
            c+=2;
        }
        array=q;
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
        int n1 = 0, n2 = 0;
        double[] q = new double[array.Length];
        for (int i=0; i<array.Length; i++)
        {
            bool ck = true;
            for (int j=0; j<q.Length; j++)
            {
                if (array[i] == q[j]) ck = false;
            }
            if (ck == true) q[i] = array[i];
        }
        for (int i = 0; i<q.Length; i++)
        {
            if (q[i] == 0 && q[i] != array[i]) n1++;
        }
        double[] qq = new double[q.Length - n1];
        for (int i =0; i<q.Length; i++)
        {
            if (q[i] == array[i])
            {
                qq[n2] = q[i];
                n2++;
            }
        }
        array = qq;
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
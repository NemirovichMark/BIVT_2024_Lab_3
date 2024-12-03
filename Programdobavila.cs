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
        double elementic = 0;
        for (int i = 0; i < 6; i++)
        {
            elementic += array[i];  // не удивляйтесь названиям переменных, у меня просто хорошее настроение :)
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / elementic, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sred = 0;
        double bu = 0;
        double l = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                bu += array[i];
                l++;
            }
        }
        if (l > 0)
        {
            sred = bu / l;
        }
        for (int j = 0; j < 8; j++)
        {
            if (array[j] > 0)
                array[j] = Math.Round(sred, 2);
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
        // code heredouble s = 0;
        double element = 0;
        for (int i = 0; i < 5; i++)
        {
            element += array[i];
        }
        for (int i = 0; i < 5; i++)
        { 
        array[i] = Math.Round(array[i] - (element / 5), 2);
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
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double tytyty = 0;
        for (int i = 0; i < 7; i++)
        {
            tytyty += array[i];
        }
            for (int i = 0; i < 7; i++)
        {
            if (array[i] > (tytyty / 7)) array[i] = 0;
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
        double bebebe = 0;
        for (int i = 0; i < 8; i++)
        {
            bebebe += array[i];
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > bebebe / 8) count++;
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
        double[] output = null;

        // code here
        int bum = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0) bum++;
        }
        output = new double[bum];
        bum = 0;
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
            {
                output[bum] = array[i];
                bum++;
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
        int yla = 0;
        int kukareky = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[yla] = array[i];
                yla++;
            }
            else
            {
                odd[kukareky] = array[i];
                kukareky++;
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
            if (array[i] < 0)
            {
                break;
                    }
            else 
             { 
                sum += array[i] * array[i]; 
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
            if (x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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
        int marsh = 0;
        double x = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                x = array[i];
                marsh = i;
            }
        }
        if (array[marsh] < 0)
        {
            array[marsh] = x / 2;
        }
        else
        {
            array[marsh] = x * 2;
        }

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
        int sharichek = 0;
        double x = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                x = array[i];
                sharichek = i;
            }
        }
        for (int l = 0; l < sharichek; l++)
        {
            if (array[l] > 0)
            {
                array[l] *= 2;
            }
            else if (array[l] < 0)
            {
                array[l] /= 2;
            }
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
        double m = array[0];
        double min = array[0];
        int l = 0, gig = 0;
        int bam = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                l = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                gig = i;
            }
        }
        if (gig > l)
        {
            bam = gig;
            gig = l;
            l = bam;
        }
        int k = 0;
        for (int i = gig + 1; i < l; i++)
        {
            if (array[i] < 0) k++;
        }
        double[] arrayy = new double[k];
        k = 0;
        for (int i = gig + 1; i < l; i++)
        {
            if (array[i] < 0)
            {
                arrayy[k] = array[i];
                k++;
            }
        }
        // end

        return arrayy;
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
        double max = array[0];
        int mama = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                mama = i;
            }
        }
        if (mama + 1 < array.Length)
        {
            if (array[mama + 1] >= 0)
            {
                array[mama + 1] = array[mama + 1] * 2;
            }

            else
            {
                array[mama + 1] = array[mama + 1] / 2;
            }
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
        int sr = 0;
        double min = array[0], max = array[0];
        int l = 0, x = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                l = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                x = i;
            }
        }
        
        if (l > x)
        {
            int c = x;
            x = l;
            l = c;
        }
        for (int i = l + 1; i < x; i++)
        {
            s += array[i];
            sr++;
        }
        if (sr == 0)
        { 
            average = 0; 
        }
        else
        {
            average = s / sr;
        }
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
        int l = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                l = i;
        }
        double[] a = new double[array.Length + 1];
        if (l != -1)
        {
            for (int i = 0; i <= l; i++)
            { 
            a[i] = array[i];
            a[l + 1] = P;
            }
            if (l + 2 < a.Length)
            {
                for (int i = l + 2; i <= a.Length; i++)
                    a[i] = array[i - 1];
            }
            array = a;
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
        double l = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > l)
            {
                l = array[i];
                k = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (i == k)
            {
                array[i] = k;
            }
        }
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

        if (k >= A.Length || k < 0) return A;


        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }

        for (int i = 0; i < B.Length; i++)
        {
            output[k + 1 + i] = B[i];
        }

        for (int i = k + 1; i < A.Length; i++)
        {
            output[B.Length + i] = A[i];
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

        // code here
        double n = double.MaxValue, x = double.MinValue, s = 0, l = 0;
        int nl = 0, spas = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < n)
            {
                n = array[i];
                nl = i;
            }
            if (array[i] > x)
            {
                x = array[i];
                spas = i;
            }
        }
        if (spas < nl)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    l++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    s += array[i];
                    l++;
                }
            }
        }
        if (l != 0)
        {
            average = Math.Round(s / l, 3);
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
        double m = array[0], s = 0;
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > m)
            {
                m = array[i];
                l = i;
            }
        }
        if (m > s)
        {
            array[l] = 0;
        }
        else
        {
            array[l] = m * 2;
        }
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
        int[] baraban = new int[array.Length];
        int bits = 0;
        double l = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > l)
            {
                l = array[i];
                bits = 0;
            }
            if (array[i] == l)
            {
                baraban[bits] = i;
                bits++;
            }
        }
        int[] bit = new int[bits];
        for (int i = 0; i < bits; i++)
        {
            bit[i] = baraban[i];
            output = bit;
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
        double m = array[0], s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == m)
            {
                array[i] = s;
                s += m;
            }
            else
            {
                s += array[i];
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
        int snow = 0;
        double[] l = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                l[snow] = array[i];
                snow++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                l[snow] = array[i];
                snow++;
            }
        }
        array = l;
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
        int l = 0;
        double[] kuku = new double[array.Length];
        double k = array.Length / 2;
        for (int i = 0; i < k; i++)
        {
            kuku[l] = array[i];
            kuku[l + 1] = array[i];
            l += 2;
        }
        array = kuku;
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
        int l = 0, m = 0;
        for (int i = array.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 999999;
                    l++;
                }
            }
        }
        double[] b = new double[array.Length - l];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 999999) b[i - m] = array[i];
            else m++;
        }
        array = b;
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
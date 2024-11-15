using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;
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

        double sm = 0;
        foreach (double current in array)
        {
            sm += current;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= sm;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        double sm = 0, klv = 0, k;
        foreach (double current in array) 
        {
            if (current > 0)
            {
                sm += current;
                klv++;
            }
        }
        if (klv == 0) return array;
        k = Math.Round(sm / klv, 2);
        for (int i = 0; i < array.Length; i ++ )
        {
            if (array[i] > 0) array[i] = k;
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

        double sm = 0, n;
        foreach (double current in array)
        {
            sm += current;
        }
        n = sm / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= n;
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

        foreach (double current in vector)
        {
            length += current * current;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        double sm = 0, n;
        foreach(double current in array)
        {
            sm += current;
        }
        n = sm / 7;
        for (int i = 0; i < 7; i ++)
        {
            if (array[i] > n) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here

        foreach (double current in array)
        {
            if (current < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        double sm = 0, n;
        foreach (double current in array)
        {
            sm += current;
        }
        n = sm / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > n) count ++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here

        for (int i = 0; i < 10; i ++)
        {
            if (array[i] < Q && array[i] > P) count ++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here

        int klv = 0;
        foreach (double current in array)
        {
            if (current > 0) klv += 1;
        }
        double[] output2 = new double[klv];
        for (int i = 0, j = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output2[j] = array[i];
                j++;
            }
        }
        output = output2;
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here

        for (int i = 0; i < 8; i ++)
        {
            if (array[i] < 0)
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

        for (int i = 0, j = 0, k = 0; i < 10; i ++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[k] = array[i];
                k++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        for (int i = 0; i < 11; i ++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here

        for (int i = 0; i < 10; i ++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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

        double mn = 1, mni = -1;
        for (int i = 0; i < array.Length; i ++) // я случайно сделал нечётные номера тоже, а мой номер в списке чётный, и это печально
        {
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        if (array[(int)mni] > 0) array[(int)mni] *= 2;
        else array[(int)mni] /= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        double mx = 0;
        int mxi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        for (int i = 0; i < mxi; i++) sum += array[i];
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here

        double mn = 0;
        int mni = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        for (int i = 0; i < mni; i++)
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

        double sm = 0, mx = 0;
        int mxi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        double n = Math.Round(sm / array.Length, 2);
        for (int i = mxi + 1; i < array.Length; i++)
        {
            array[i] = n;
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here

        double mn = 0, mx = 0, mni = -1, mxi = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        int start = 0, stop = 0, klv = 0;
        if (mni < mxi)
        {
            start = (int)mni;
            stop = (int)mxi;
        }
        else
        {
            start = (int)mxi;
            stop = (int)mni;
        }
        for (int i = start + 1; i < stop; i++)
        {
            if (array[i] < 0) klv++;
        }
        double[] array1 = new double[klv];
        for (int i = start + 1, j = 0; i < stop; i++)
        {
            if (array[i] < 0)
            {
                array1[j] = array[i];
                j++;
            }
        }
        array = array1;
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        double sm = 0, sr, Md = -1, Mi = 0;
        foreach (double current  in array)
        {
            sm += current;
        }
        sr = sm / array.Length;
        for (int i = 0; i < array.Length; i ++)
        {
            if (Math.Abs(sr - array[i]) < Md || Md == -1)
            {
                Md = Math.Abs(sr - array[i]);
                Mi = i;
            }
        }
        double[] array1 = new double[array.Length + 1];
        for (int i = 0, j = 0; i < array1.Length; i ++)
        {
            if (i != Mi + 1)
            {
                array1[i] = array[j];
                j++;
            }
            else array1[i] = P;
        }
        array = array1;
        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        double mx = 0, mxi =-1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        if (mxi < array.Length - 1)
        {
            if (array[(int)mxi + 1] > 0) array[(int)mxi + 1] *= 2;
            else array[(int)mxi + 1] /= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here

        double mx = 0, mxi = -1, mn = 0, mni = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        for (int i = (int)mxi; i < array.Length; i ++)
        {
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        double c = array[(int)mxi];
        array[(int)mxi] = array[(int)mni];
        array[(int)mni] = c;
        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here

        double mx = 0, mxi = -1, mn = 0, mni = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        double sm = 0;
        int start = 0, stop = 0, klv = (int)Math.Abs(mxi - mni) - 1;
        if (klv == 0) return 0;
        if (mni < mxi)
        {
            start = (int)mni;
            stop = (int)mxi;
        }
        else
        {
            start = (int)mxi;
            stop = (int)mni;
        }
        for (int i = start + 1; i < stop; i ++)
        {
            sm += array[i];
        }
        average = Math.Round(sm / klv, 2);
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        double mn = -1, mni = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0 && (array[i] < mn || mn == -1))
            {
                mn = array[i];
                mni = i;
            }
        }
        if (mni == 0 && mn <= 0) return array;
        double[] array1 = new double[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i ++)
        {
            if (i != mni)
            { 
                array1[j] = array[i];
                j++;
            }
        }
        array = array1;
        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        int lasti = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0) lasti = i;
        }
        if (array[lasti] <= 0) return array;
        double[] array1 = new double[array.Length + 1];
        for (int i = 0, j = 0; i < array1.Length; i ++)
        {
            if (j < array.Length && j != lasti + 1)
            {
                array1[i] = array[j];
                j++;
            }
            else array1[i] = P;
        }
        array = array1;
        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        double mx = 0, mxi = -1, Si = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[(int)Si] >= 0 && array[i] < 0) Si = i;
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        if (array[(int)Si] >= 0) return array;
        double sm = 0;
        for (int i = (int)mxi + 1; i < array.Length; i++)
        {
            sm += array[i];
        }
        array[(int)Si] = Math.Round(sm, 2);
        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        double mx = 0, mxi = -1;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        array[(int)mxi] = mxi;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        double mx = 0, mxi = -1, Si = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (Si == -1 && array[i] < 0) Si = i;
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        if (Si == -1) return array;
        double c = array[(int)Si];
        array[(int)Si] = array[(int)mxi];
        array[(int)mxi] = c;
        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k)
    {
        double[] output = null;

        // code here

        double[] output1 = [A.Length + B.Length];
        int i = 0, j = 0;
        Console.WriteLine($"{A.Length + B.Length} {k}");
        while (i + j + 1 < output1.Length)
        {
            if (i < k - 1)
            {
                output1[i] = A[i];
                Console.WriteLine($"{i} in A {A[i]} for element {i}");
                i++;
            }
            else if (i == k - 1 && j < B.Length)
            {
                output1[i + j] = B[j];
                Console.WriteLine($"{j} in B {B[j]} for element {i + j}");
                j++;
            }
            else
            {
                output1[i + j] = A[i];
                Console.WriteLine($"{i} in A {A[i]} for element {i + j}");
                i++;
            }
        }
        output = output1;
        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here

        double sm = 0;
        foreach (double current in array)
        {
            sm += current;
        }
        sm /= array.Length;
        int klv = 0;
        foreach (double current in array)
        {
            if (current < sm) klv ++;
        }
        int[] output1 = new int[klv];
        for (int i = 0, j = 0; i < array.Length; i ++)
        {
            if (array[i] < sm)
            {
                output1[j] = i;
                j++;
            }
        }
        output = output1;
        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here

        double mx = 0, mxi = -1, mn = 0, mni = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        double klv = 0;
        foreach (double current in array)
        {
            if (mxi < mni)
            {
                if (current > 0)
                {
                    klv += 1;
                    average += current;
                }
            }
            else
            {
                if (current < 0)
                {
                    klv += 1;
                    average += current;
                }
            }

        }
        if (klv == 0) return 0;
        average /= klv;
        average = Math.Round(average, 2);
        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        double mx1 = 0, mx1i = -1, mx2 = 0, mx2i = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (i % 2 == 1)
            {
                if (array[i] > mx1 || mx1i == -1)
                {
                    mx1 = array[i];
                    mx1i = i;
                }
            }
            else if (array[i] > mx2 || mx2i == -1)
            {
                mx2 = array[i];
                mx2i = i;
            }
        }
        if (mx2 > mx1)
        {
            for (int i = 0; i < array.Length / 2; i ++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i  < array.Length; i ++)
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

        double mx = 0, mxi = -1, sm = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i]; 
                mxi = i;
            }
            sm += array[i];
        }
        if (mx > sm) array[(int)mxi] = 0;
        else array[(int)mxi] *= 2;
        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here

        double mn = 0, mni = -1, Si = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0 && Si == -1) Si = i;
            if (array[i] < mn || mni == -1)
            {
                mn = array[i];
                mni = i;
            }
        }
        if (Si == -1) return 0;
        int start = 0;
        if (Si >= mni) start = 1;
        for (int i = start; i < array.Length; i += 2)
        {
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

        double mx = 0, mxi = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        for (int i = 0; i < mxi - 1; i += 2)
        {
            double c = array[i + 1];
            if (i + 1 == array.Length) break;
            array[i + 1] = array[i];
            array[i] = c;
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

        int current = 1;
        for (int i = 0; i < array.Length - 1; i ++)
        {
            if (array[i + 1] < array[i]) current++;
            else
            {
                if (current > count) count = current;
                current = 1;
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

        // code here

        int current = 2, type = 0, previosType = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i]) type = 1;
            else if (array[i + 1] < array[i]) type = 0;
            else type = 3;
            if (previosType == type) current++;
            else
            {
                if (current > count) count = current;
                current = 2;
            }
            previosType = type;
        }
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

        int klv = 0;
        foreach (double current  in array)
        {
            if (current < 0) klv++;
        }
        double[] array1 = new double[array.Length - klv];
        for (int i = 0, j = 0; i < array.Length; i ++)
        {
            if (array[i] >= 0)
            {
                array1[j] = array[i];
                j++;
            }
        }
        array = array1;
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
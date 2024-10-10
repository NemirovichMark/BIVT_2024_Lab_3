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
        //hey
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        for (int i =0; i<array.Length; i++) 
        {
            array[i] = Math.Round(array[i]/array.Sum(),2);
        }
        Console.WriteLine($"\nSum: {array.Sum()}");
        // end

        return array;
    }
    public double[] Task_1_2(double[] array) // problem: srArif doesn't seem to be right in the second input of the test
    {
        // code here
        double amount=0, srArif=0;
        foreach (double n in array) { if (n > 0) { srArif += n;  amount++; } }
        srArif /= amount;

        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > 0) { array[i] = srArif; }
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double srArif = array.Sum() / (double) array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - srArif, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0; i<vector1.Length; i++)
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
        foreach (double n in vector) { length += n*n; }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double srArif = array.Sum() / (double)array.Length;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > srArif)
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
        foreach (double n in array) { if (n<0) count++; }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double srArif = array.Sum() / array.Length;
        foreach (double n in array) { if (n > srArif) count++; }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double n in array)
        {
            if (n>P && n<Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        output = new double[0];
        foreach (double n in array) 
        {
            if (n > 0)
            {
                Array.Resize(ref output, output.Length + 1);
                output[output.Length - 1] = n;
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
        index = array.Length - 1;
        for (;index>=0;index--)
        {
            if (array[index] < 0) {  value = array[index]; break; }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code 
        int i=0, k=0;
        foreach (double n in array)
        {
            if (k%2!=0) { odd[i] = n; i++; } // when index is odd, we increment the even/odd arrays index
            else even[i] = n;
            k++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double n in array)
        {
            if (n < 0) break;
            else sum += n * n;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        Console.WriteLine($"x | y\n_____");

        for (int i = 0; i < y.Length; i++)
        {
            y[i] = 0.5 * Math.Log10(x[i]);
            Console.WriteLine($"{x[i]} | {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == array.Min()) { array[i] *= 2; break; }
        }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        for (int i =0; i<array.Length;i++)
        {
            if (array[i] == array.Max()) break;
            else sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array) // problem: probably an error in test? -1 * 2 is not suppsed to be -0.5  
    {
        // code here
        int k = Array.FindIndex(array, (x) => x == array.Min());
        for (int i=0;i<k;i++)
        {
            array[i] *= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        int i = Array.FindIndex(array, (x) => x == array.Max()) + 1;
        double srArif = Math.Round(array.Sum() / array.Length,2);
        for (; i < array.Length; i++)
        {
            array[i] = srArif;
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

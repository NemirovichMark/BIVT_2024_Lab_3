using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        double S = 0;
        foreach (double x in array)
        {
            S += x;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= S;
            array[i] = Math.Round(array[i], 2);
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double S = 0, k = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                k++;
                S += x;
            }
        }
        S = Math.Round(S / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = S;
            }
            Console.WriteLine(array[i]);
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double S = 0, k = 0;
        foreach (double x in array)
        {
            S += x;
            k++;
        }
        S = Math.Round(S / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - S, 2);
            Console.WriteLine(array[i]);
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
        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);
        Console.WriteLine(Math.Round(length, 2));
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double S = 0, k = 0;
        foreach (double x in array)
        {
            S += x;
            k++;
        }
        S /= k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > S)
            {
                array[i] = 0;
            }
            Console.WriteLine(array[i]);
        }
        // end

            return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (x < 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double S = 0, k = 0;
        foreach (double x in array)
        {
            S += x;
            k++;
        }
        S /= k;
        foreach (double x in array)
        {
            if (x > S)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (x > P && x < Q)
            { 
                count++;
            }
        }
        Console.WriteLine(count);
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int j = 0, k = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                k++;
            }
        }
        output = new double[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
            }
            foreach (double x in output)
            {
                Console.WriteLine(x);
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
                index = i;
                value = array[i];
            }
        }
        Console.WriteLine(value + index);
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        
        for (int i = 0, j = 0, k = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
                Console.WriteLine(array[i]);
            }
            else
            {
                odd[k] = array[i];
                k++;
                Console.WriteLine(array[i]);
            }
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
            if (x >= 0)
            {
                sum += x * x;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(sum);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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

        double k = 1, min_i = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < k || min_i == -1)
            {
                k = array[i];
                min_i = i;
            }
        }
        if (array[(int)min_i] > 0) array[(int)min_i] *= 2;
        else array[(int)min_i] /= 2;
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
        double k = 0, imin = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < k || imin == -1)
            {
                k = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < imin; i++)
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
        int iMax = -1, iMin = -1, count = 0;
        double amax = -100000, amin = 100000;
        double[] numbers = new double[array.Length];
        numbers = array;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                iMax = i;

            }
            if (array[i] < amin)
            {
                amin = array[i];
                iMin = i;

            }
        }
        if (iMax < iMin)
        {
            array = new double[0];
            return array;
        }
        for (int i = iMin+1; i < iMax; i++)
        {
            if (array[i] < 0) count++;
        }
        array = new double[count];
        for (int i = iMin+1, j = 0; i < iMax; i++)
        {
            if (numbers[i] < 0)
            {
                array[j] = numbers[i];
                j++;
            }
        }
        foreach (double x in array) Console.Write(x);
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
        double amax = -100000;
        int imax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        if (imax+1 != array.Length)
        { 
            if (array[imax+1] > 0)
            {
                array[imax+1] *= 2;
            }
            else
            {
                array[imax+1] /= 2;
            }
        }
        foreach (double x in array) Console.Write(x);
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
        double amax = -100000, amin = 100000;
        int imax = -1, imin = -1, count = 0, newi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            { 
                amax = array[i];
                imax = i;
            }
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            newi = imax;
            imax = imin;
            imin = newi;
        }
        for (int i = imin+1; i < imax; i++)
        {
            average += array[i];
            count++;
        }
        if (count == 0) return 0.0;
        average = average / count;
        
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
        int last_imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                last_imax = i;
            }
        }
        if (array[last_imax] <= 0) return array;
        double[] array_new = new double[array.Length + 1];
        for (int i = 0, j = 0; i < array_new.Length; i++)
        {
            if (j < array.Length && j != last_imax+1)
            {
                array_new[i] = array[j];
                j++;
            }
            else
            {
                array_new[i] = P;
            }
        }
        array = array_new;
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
        double amax = 0, imax = -1;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > amax || imax == -1)
            {
                amax = array[i];
                imax = i;
            }
        }
        array[(int)imax] = imax;
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
        
        // code here
        if (k > A.Length - 1) return A;
        double[] output = new double[A.Length + B.Length];
        for (int i = 0; i < k + 1 && i < A.Length; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[i + k + 1] = B[i];
        }
        for (int i = k + 1; i < A.Length; i++)
        {
            output[i + B.Length] = A[i];
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
        int imax = -1, imin = -1;
        double amax = -999999, amin = 999999, sum = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                {
                    sum += array[i];
                    count++;
                }
            if (count == 0) return 0.0;
        }
        
        average = sum / count;
        Console.WriteLine(average);
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
        int imax = -1;
        double amax = -999999, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            sum += array[i];
        }
        if (array[imax] > sum)
        {
            array[imax] = 0;
        }
        else
        {
            array[imax] *= 2;
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        int k = 1;
        double amax = -999999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == amax)
            {
                array[i] += k;
                k += 1;
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
        int k = 0;
        if (array.Length % 2 == 0)
        {
            k = array.Length / 2;
        }
        else
        {
            k = array.Length / 2 + 1;
        }
        double[] newarray = new double[k];
        int a = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            newarray[a] = array[i];
            a++;
        }
        for (int i = 0; i < newarray.Length; i++)
        {
            for (int j = 0; j < newarray.Length - i - 1; j++)
            {
                if (newarray[j] > newarray[j + 1])
                {
                    double temp = newarray[j];
                    newarray[j] = newarray[j + 1];
                    newarray[j + 1] = temp;
                }
            }
        }
        a = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = newarray[a];
            a++;
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
        // code here
        double[] newarray = new double[array.Length];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                newarray[k] = array[i];
                k++;
            }
        }
        for (int i = 0; i < k - 1; i++)
        {
            for (int j = i + 1; j < k; j++)
            {
                if (newarray[i] < newarray[j])
                {
                    double temp = newarray[i];
                    newarray[i] = newarray[j];
                    newarray[j] = temp;
                }
            }
        }
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = newarray[index];
                index++;
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
        X = new double[n];
        Y = new double[n];
        double p = (b - a) / (n - 1);
        double zn_max = -9999;
        double zn_min = 9999;
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = Math.Round(a + i * p, 3);
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 3);
        }
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > zn_max)
            {
                zn_max = Y[i];
            }
            if (Y[i] < zn_min)
            {
                zn_min = Y[i];
            }
        }
        globalMax = zn_max;
        globalMin = zn_min;
        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine($"X: {X[i]}, Y: {Y[i]}");
        }
        Console.WriteLine($"Максимум функции: {globalMax}");
        Console.WriteLine($"Максимум функции: {globalMin}");
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
        normalizedArray = new double[array.Length];
        double amax = -9999;
        double amin = 9999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
            }
            if (array[i] < amin)
            {
                amin = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - amin) / (amax - amin) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
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
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                c++;
            }
        }
        double sr = Math.Round(s / c, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
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
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            n += array[i];
        }
        n = Math.Round(n / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - n, 2);
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
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            n += array[i];
        }
        n = Math.Round(n / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > n)
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
        double n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            n += array[i];
        }
        n = Math.Round(n / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > n)
            {
                count++;
            }
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
            if (array[i] > P & array[i] < Q)
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
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) n++;
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n++] = array[i];
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
        int ieven = 0;
        int iodd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[ieven] = array[i];
                ieven++;
            }
            else
            {
                odd[iodd] = array[i];
                iodd++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
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
        /*for (int i = 0; i<x.Length; i++)
        {
            Console.WriteLine($"{x[i]}\t\t{y[i]}\n");
        }*/
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double arraymin = array[0];
        int imin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < arraymin)
            {
                arraymin = array[i];
                imin = i;
            }
        }
        if (array[imin] > 0)
        {
            array[imin] *= 2;
        }
        else
        {
            array[imin] /= 2;
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
        double arraymin = array[0];
        int imin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < arraymin)
            {
                arraymin = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < imin; i++)
        {
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] *= 0.5;
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
        double arraymin = array[0];
        int imin = 0;
        double arraymax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < arraymin)
            {
                arraymin = array[i];
                imin = i;
            }
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        if (imin > imax)
        {
            int t = imax;
            imax = imin;
            imin = t;
        }
        int n = 0;
        int c = 0;
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                c++;
            }
        }
        double[] b = new double[c];
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0) b[n++] = array[i];
        }
        array = b;
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
        double arraymax = array[0];
        int imax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        if (imax + 1 < array.Length)
        {
            if (array[imax + 1] > 0)
            {
                array[imax + 1] *= 2;
            }
            else
            {
                array[imax + 1] /= 2;
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
        int imin = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[imin])
            {
                imin = i;
            }
            if (array[i] > array[imax])
            {
                imax = i;
            }
        }
        if (imin > imax)
        {
            int t = imax;
            imax = imin;
            imin = t;
        }
        for (int i = imin + 1; i < imax; i++)
        {
            average += array[i];
        }
        if (imax - imin - 1 <= 0)
        {
            average = 0;
        }
        else
        {
            average = average / (imax - imin - 1);
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
        int ilast = -1;
        for (int i = array.Length - 1; i>=0; i--)
        {
            if (array[i] > 0)
            {
                ilast = i;
                break;
            }
        }
        if (ilast == -1)
        {
            return array;
        }
        double[] b = new double[array.Length+1];
        for (int i = 0; i<=ilast; i++)
        {
            b[i] = array[i];
        }
        b[ilast+1] = P;
        for (int i = ilast + 1; i<array.Length; i++)
        {
            b[i+1] = array[i];
        }
        array = b;
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
        double max = 0;
        int imax = 0;
        for (int i = 0; i<array.Length; i += 2)
        {
            if ( array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        max = imax;
        array[imax] = max;
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
        if (k >= A.Length)
        {
            return A;
        }
        for (int i = 0; i<=k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + 1 + i] = B[i];
        }
        for (int i = k + 1; i<A.Length; i++)
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
        double arraymin = array[0];
        int imin = 0;
        double arraymax = array[0];
        int imax = 0;
        int c1 = 0;
        int c2 = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < arraymin)
            {
                arraymin = array[i];
                imin = i;
            }
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    c1++;
                }
            }
        }
        if (imax > imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    average += array[i];
                    c2++;
                }
            }
        }
        if (c1 > 0)
        {
            average = average / c1;
        }
        if (c2 > 0)
        {
            average = average / c2;
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
        double arraymax = array[0];
        int imax = 0;
        double sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
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
        double arraymax = array[0];
        int imax = 0;
        double c = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > arraymax)
            {
                arraymax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] == arraymax)
            {
                array[i] += c;
                c++;
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
        for (int i = 0; i<array.Length; i++)
        {
            if (i % 2 == 0)
            {
                int imin = i;
                for (int j = i + 1; j<array.Length; j++)
                {
                    if (j%2==0 & array[j] < array[imin])
                    {
                        imin = j;
                    }
                }
                double temp = array[imin];
                array[imin] = array[i];
                array[i] = temp;
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
        // code here
        for (int i = 0; i<array.Length-1; i++)
        {
            if (array[i] < 0)
            {
                int imax = i;
                for (int j = i+1; j<array.Length; j++)
                {
                    if (array[j] > array[imax] & array[j]<0)
                    {
                        imax = j;
                    }
                }
                double temp = array[imax];
                array[imax] = array[i];
                array[i] = temp;
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
        globalMax = -10000;
        globalMin = 10000;

        double step = (b - a) / (n - 1);

        //filling
        for (int i = 0; i < n; i++)
        {
            X[i] = a + i * step;
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }

        //global
        for (int i = 0; i<n; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];
        }

        //outout
        for (int i = 0; i < X.Length; i++)
        {
            Console.WriteLine($"X: {X[i]} , Y: {Y[i]}");
        }
        Console.WriteLine($"Максимум функции: {globalMax}");
        Console.WriteLine($"Минимум функции: {globalMin}");
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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here
        normalizedArray = new double[array.Length];

        double max = -1000;
        double min = 1000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round((array[i] - min) / (max - min) * 2 - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
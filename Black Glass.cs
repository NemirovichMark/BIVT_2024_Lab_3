using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Xml.Schema;
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
        double sumi = 0;
        for (int i = 0; i < 6; i++)
        {
            sumi += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / sumi, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sred = 0, k = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                k++;
                sred += array[i];
            }
        }
        sred /= k;
        sred = Math.Round(sred, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sred;
            }
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
        double sred = 0, k = 0;
        for (int i = 0; i < 5; i++)
        {
            k++;
            sred += array[i];
        }
        sred /= k;
        sred = Math.Round(sred, 2);
        for (int i = 0; i < 5; i++)
        {

            array[i] = Math.Round(array[i] - sred, 2);
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
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0, k = 0;
        for (int i = 0; i < 7; i++)
        {
            k++;
            sred += array[i];
        }
        sred /= k;
        sred = Math.Round(sred, 2);
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sred)
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
        int k = 0;
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
        double sred = 0, k = 0;
        for (int i = 0; i < 8; i++)
        {
            k++;
            sred += array[i];
        }
        sred /= k;
        sred = Math.Round(sred, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sred)
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
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                k++;
            }
        }
        double[] a = new double[k];
        k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                a[k] = array[i];
                k++;
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
        double[] odd = new double[array.Length / 2];

        // code here
        int k1 = 0, k2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[k1] = array[i];
                k1++;
            }
            else
            {
                odd[k2] = array[i];
                k2++;
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
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double maxi = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (maxi < array[i])
            {
                maxi = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi) break;
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
        double maxi = array[0], sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (maxi < array[i])
            {
                maxi = array[i];
            }
            sred += array[i];
        }
        sred /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    array[j] = Math.Round(sred, 2);
                }
                break;
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
        double[] b = new double[array.Length + 1];
        double sred = 0, razn = 0;
        int k = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred /= array.Length;
        razn = Math.Abs(sred);
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sred) <= razn)
            {
                k = 1 + i;
                razn = Math.Abs(array[i] - sred);
            }
        }
        for (int i = 0; count < array.Length; i++, count++)
        {
            if (i == k)
            {
                b[i] = P;
                count--;
            }
            else
            {
                b[i] = array[count];
            }
        }
        array = b;
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
        double maxi = array[0], mini = array[0];
        int k = 0, k2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                k = i;
            }
        }
        if (k != array.Length - 1)
        {
            for (int i = k + 1; i < array.Length; i++)
            {
                if (array[i] < mini)
                {
                    mini = array[i];
                    k2 = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i == k)
                {
                    array[i] = mini;
                }
                if (i == k2)
                {
                    array[i] = maxi;
                }
            }
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
        double[] b = new double[array.Length - 1];
        int k = -1, k2 = 0;
        double mini = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                mini = array[i];
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < mini)
            {
                k = i;
                mini = array[i];
            }
        }
        if (k != -1)
        {
            for (int i = 0; i < b.Length; i++, k2++)
            {
                if (i == k)
                {
                    k2++;
                }
                b[i] = array[k2];
            }
            array = b;
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
        double maxi = array[0], sum = 0, otr;
        int k = -1, k2 = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                k = i;
            }
            if (k2 == -1)
            {
                if (array[i] < 0)
                {
                    k2 = i;
                }
            }
        }
        for (int i = k + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        if (k2 != -1)
        {
            array[k2] = Math.Round(sum, 2);
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
        double maxi = array[0], otr = array[0];
        int k = -1, k2 = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                k = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k2 = i;
                otr = array[i];
                break;
            }
        }
        if (k2 != -1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == k)
                {
                    array[i] = otr;
                }
                if (i == k2)
                {
                    array[i] = maxi;
                }
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
        int[] di = new int[array.Length];
        double sred = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
        }
        sred /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sred)
            {

                di[k] = i;
                k++;
            }
        }
        output = new int[k];
        for (int i = 0; i < k; i++)
        {
            output[i] = di[i];
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
        double maxi1 = array[0], maxi2 = array[1];
        int dlin = array.Length / 2;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxi1)
            {
                maxi1 = array[i];
            }
            if (i % 2 != 0 && array[i] > maxi2)
            {
                maxi2 = array[i];
            }
        }
        if (maxi1 > maxi2)
        {
            for (int i = 0; i < dlin; i++)
            {
                array[i] = 0;
            }

        }
        else if (maxi1 < maxi2)
        {
            for (int i = dlin; i < array.Length; i++)
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

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        int k1 = -1, k2 = -1;
        double mini = array[0], otr = array[array.Length - 1];
        for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                k1 = i;
            }
            if (array[j] < 0)
            {
                otr = array[j];
                k2 = j;
            }
        }
        //Console.WriteLine(k2);
        if (k1 <= k2 || k2 == -1)
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
                //Console.WriteLine(sum);
            }
        }
        else if (k2 < k1)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
                //Console.WriteLine(sum);
            }
        }

        //Console.WriteLine(sum);
        sum = Math.Round(sum, 2);
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
        double maxi = array[0];
        double count = 1;
        double[] da = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi)
            {
                da[i] = count;
                count++;
            }
            else
            {
                da[i] = -1;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (da[i] != -1)
            {
                array[i] += da[i];
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
        int count = 0;
        double[] da = new double[array.Length / 2 + array.Length % 2];
        for (int i = 0; i < array.Length; i += 2)
        {
            da[count] = array[i];
            count++;
        }
        count = 0;
        for (int i = 0; i < da.Length; i++)
        {
            for (int j = 0; j < da.Length - i - 1; j++)
            {
                if (da[j] > da[j + 1])
                {
                    double meow = da[j];
                    da[j] = da[j + 1];
                    da[j + 1] = meow;
                }
            }
        }
        for (int i = 0; i < array.Length; i += 2, count++)
        {
            array[i] = da[count];
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
        int count = 0;
        double[] da = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                da[count] = array[i];
                count++;
            }
        }
        for (int i = 0; i < da.Length; i++)
        {
            for (int j = 0; j < da.Length - i - 1; j++)
            {
                if (da[j] < da[j + 1])
                {
                    double meow = da[j];
                    da[j] = da[j + 1];
                    da[j + 1] = meow;
                }
            }
        }

        for (int i = 0, k = da.Length - count; i < array.Length; i++)
        {
            //Console.WriteLine(k);
            if (array[i] < 0)
            {
                array[i] = da[k];
                k++;
            }
            //Console.WriteLine(array[i]);
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
        double delta = (b - a) / (n - 1);
        X = new double[n];
        Y = new double[n];
        for (int i = 0; a <= b; a += delta, i++)
        {
            X[i] = a;
            //Console.WriteLine(X[i]);
        }
        for (int i = 0; i < n; i++)
        {
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            Y[i] = Math.Round(Y[i], 2);
            X[i] = Math.Round(X[i], 2);
            //Console.WriteLine(Y[i]);
        }
        double mini = Y[0], maxi = Y[0];
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] < mini)
            {
                mini = Y[i];
            }
            if (Y[i] > maxi)
            {
                maxi = Y[i];
            }
        }
        globalMax = maxi;
        globalMin = mini;

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
        double mini = array[0], maxi = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
            }
            if (array[i] > maxi)
            {
                maxi = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = 2 * (array[i] - mini) / (maxi - mini) - 1;
            normalizedArray[i] = Math.Round(normalizedArray[i], 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
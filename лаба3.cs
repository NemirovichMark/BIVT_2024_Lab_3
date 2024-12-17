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
        int l = array.Length;
        for (int i = 0; i < l; i++)
            s += array[i];
        for (int j = 0; j < l; j++)
        {
            if (s != 0)
                array[j] = Math.Round(array[j] / s, 2);
            else
                array[j] = 0;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int l = array.Length;
        double ch = 0;
        int zn = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > 0)
            {
                zn++;
                ch += array[i];
            }
        }
        for (int j = 0; j < l; j++)
        {
            if (array[j] > 0)
                array[j] = Math.Round(ch / zn, 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        int l = first.Length;
        for (int i = 0; i < l; i++)
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
        int l = array.Length;
        for (int i = 0; i < l; i++)
            s += array[i];
        for (int j = 0; j < l; j++)
        {
            array[j] = Math.Round(array[j] - s/l, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double answer = 0;

        // code here
        int l = vector1.Length;
        double s = 0;
        for (int i = 0; i < l; i++)
        {
            s += vector1[i] * vector2[i];
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_6(double[] vector)
    {
        double a = 0;

        // code here
        int l = vector.Length;
        for (int i = 0; i < l; i++)
        {
            a += vector[i] * vector[i];
        }
        // end

        return Math.Round(Math.Sqrt(a), 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        int l = array.Length;
        double x = 0, s = 0;
        for (int i = 0; i < l; i++)
        {
            s += array[i];
        }
        x = s / l;
        for (int j = 0; j < l; j++)
        {
            if (array[j] > x)
                array[j] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int c = 0;

        // code here
        int l = array.Length;

        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
                c++;
        }
        // end

        return c;
    }
    public int Task_1_9(double[] array)
    {
        int c = 0;

        // code here
        int l = array.Length;
        double a = 0, s = 0;
        for (int i = 0; i < l; i++)
        {
            s += array[i];
        }
        a = s / l;
        for (int j = 0; j < l; j++)
        {
            if (array[j] > a)
                c++;
        }
        // end

        return c;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int c = 0;

        // code here
        int l = array.Length;

        if (P < 0 && Q > l)
            return 0;
        for (int i = P; i < l; i++)
        {
            if (array[i] > P && array[i] < Q)
                c++;
        }
        // end

        return c;
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
        int l = array.Length;
        for (int i = 0; i < l; i++)
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
        double s = 0;

        // code here
        int l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
                break;
            else
            {
                s += array[i] * array[i];
            }
        }
        // end

        return s;
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double s = 0;

        // code here
        int l = array.Length, z = 0;
        double m = double.MinValue;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                z = i;
            }
        }
        for (int j = 0; j < z; j++)
        {
            s += array[j];
        }
        // end

        return s;
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
        int l = array.Length, z = 0;
        double m = array[0], s = 0, a = 0;
        for (int i = 0; i < l; i++)
        {
            s += array[i];
            if (array[i] > m)
            {
                m = array[i];
                z = i;
            }
        }
        a = Math.Round(s / l, 2);
        for (int j = z + 1; j < l; j++)
        {
            array[j] = a;
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
        double a = 0, bliz = double.MaxValue;
        int n = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            a += array[i];
        }
        a = Math.Round(a / l, 2);
        double d1 = double.MaxValue;
        for (int i = 0; i < l; i++)
        {
            double d2 = Math.Abs(a - array[i]);
            if (d2 < d1)
            {
                d1 = d2;
                bliz = array[i];
                n = i;
            }
        }
        double[] answer = new double[l + 1];
        for (int i = 0; i <= n; i++)
        {
            answer[i] = array[i];
        }
        answer[n + 1] = P;
        for (int i = n + 1; i < l; i++)
        {
            answer[i + 1] = array[i];
        }
        // end

        return answer;
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
        double maxe = 0, mine = 999;
        int l = array.Length, maxi = 0, mini = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > maxe)
            {
                maxe = array[i];
                maxi = i;
            }
        }
        for (int j = maxi; j < l; j++)
        {
            if (array[j] < mine)
            {
                mine = array[j];
                mini = j;
            }
        }
        array[maxi] = mine;
        array[mini] = maxe;
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
        double m = 10000;
        int x = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] < m && array[i] > 0)
            {
                m = array[i];
                x = i;
            }
        }
        if (m != 10000)
        {
            double[] newarray = new double[l - 1];
            for (int i = 0; i < l - 1; i++)
            {
                if (i < x)
                    newarray[i] = array[i];
                else
                    newarray[i] = array[i + 1];
            }
            array = newarray;
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
        double maxe = -999, s = 0;
        int x = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > maxe)
            {
                maxe = array[i];
                x = i;
            }
        }
        for (int i = x + 1; i < l; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
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
        double maxe = -999, o = 0;
        int x = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > maxe)
            {
                maxe = array[i];
                x = i;
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                o = array[i];
                array[i] = maxe;
                array[x] = o;
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
        double sum = 0, sr = 0;
        int k = 0, j = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            sum += array[i];
        }
        sr = sum / l;
        for (int i = 0; i < l; i++)
        {
            if (array[i] < sr)
                k++;
        }
        output = new int[k];
        for (int i = 0; i < l; i++)
        {
            if (array[i] < sr)
            {
                output[j] = i;
                j++;
            }
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
        double ch = -100, nech = 0, l = array.Length;
        int ich = 0, inech = 0;
        for (int i = 0; i < l; i += 2) 
        {
            if (array[i] > ch)
            {
                ch = array[i];
                ich = i;
            }
        }
        for (int i = 1; i < l; i += 2)
        {
            if (array[i] > nech)
            {
                nech = array[i];
                inech = i;
            }
        }
        if (ch > nech)
        {
            for (int i = 0; i < l / 2; i++)
                array[i] = 0;
        }
        if (ch < nech)
        {
            for (int j = array.Length / 2; j < l; j++)
                array[j] = 0;
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
        double a1 = 0, a2 = 0, l = array.Length;
        int imin = 0, iotr = 0;
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                a2 = array[i];
                iotr = i;
                break;
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] < a1)
            {
                a1 = array[i];
                imin = i;
            }
        }
        if (iotr < imin)
        {
            for (int i = 0; i < l; i++)
            {
                if (i % 2 == 0) 
                    sum += array[i];
            }
        }
        else
        {
            for (int i = 0; i < l; i++)
            {
                if (i % 2 != 0) 
                    sum += array[i];
            }
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
        double max = array[0];
        int c = 0, n = 0, l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                c = 0;
            }
            if (array[i] == max)
            {
                c++;
            }
        }
        int[] array2 = new int[c];
        for (int i = 0; i < l; i++)
        {
            if (array[i] == max)
            {
                array2[n] = i;
                n++;
            }
        }
        output = array2;
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
        double max = array[0], sum = 0;
        int l = array.Length;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] == max)
            {
                array[i] = sum;
                sum += max;
            }
            else
            {
                sum += array[i];
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
        int x = 0, l = array.Length;
        double[] array2 = new double[l];
        for (int i = 0; i < l; i++)
        {
            if (array[i] >= 0)
            {
                array2[x] = array[i];
                x++;
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (array[i] < 0)
            {
                array2[x] = array[i];
                x++;
            }
        }
        array = array2;
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
        int x = 0, l2 = array.Length;
        double[] array2 = new double[l2];
        double l = l2 / 2;
        for (int i = 0; i < l; i++)
        {
            array2[x] = array[i];
            array2[x + 1] = array[i];
            x += 2;
        }
        array = array2;
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
        int povt = 0, x = 0, l = array.Length;
        for (int i = l - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < l; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 999999;
                    povt++;
                }
            }
        }
        double[] array2 = new double[l - povt];
        for (int i = 0; i < l; i++)
        {
            if (array[i] != 999999)
                array2[i - x] = array[i];
            else
                x++;
        }
        array = array2;
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
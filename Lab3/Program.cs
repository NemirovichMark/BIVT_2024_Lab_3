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
        double[] first = { 0, 1.5, 1, 3, -2.2, -0.5, 2 };
        program.Task_2_1(first);
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
        Console.WriteLine(array);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for(int i = 0; i < array.Length; i++ )
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(s / k, 2);
            }
        }
        Console.WriteLine(array);

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double s, d;
        for(int i = 0; i < 4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
        }
        for (int i = 0; i < 4; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - s / k, 2);
        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double  a, s = 0;
        for(int i = 0; i < vector1.Length; i++)
        {
            a = Math.Round(vector1[i] * vector2[i], 2);
            s += a;
        }
        product = Math.Round(s, 2);
        Console.WriteLine(product);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double l = 0, v;
        for(int i = 0; i < 5; i++)
        {
            l += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(l), 2);
        Console.WriteLine(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s / array.Length)
            {
                array[i] = 0;
            }

        }
        Console.WriteLine(array);
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
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
        double s = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s / array.Length)
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
        for (int i = 0; i < 10; i++)
        {
            if (P < array[i] && array[i] < Q)
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
        int n = 0;
        for(int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        n = 0;
        for(int i = 0; i < 10; i++)
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
        int k=0, n = 0;
        for(int i = 0; i < 8; i++)
        {
            n++;
            if (array[i] < 0)
            {
                value = array[i];
                k = n;
            }
        }
        index += k;
        Console.WriteLine($"{value}   {index}");

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int n = 0, k = 0;
        for(int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[n] = array[i];
                n++;
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
        for(int i = 0; i < 11; i++)
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
        double yz;
        for(int i = 0; i < 10; i++)
        {
            if (x[i] < 0 || x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                yz = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(yz, 2);
                Console.WriteLine(y[i]);
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
        double n = 100, m = 0;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < n)
            {
                n = array[i];
                k = i;
            }

        }
        if(n > 0)
        {
            array[k] = n * 2;
        }
        else
        {
            array[k] = Math.Round(n / 2, 2);
        }
        Console.WriteLine(array[k]);
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
        double min = 100;
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                k = i;
            }
        }
        for(int i = 0; i < k; i++)
        {
            if (array[i] > 0)
            {
                array[i] = array[i] * 2;
            }
            else
            {
                array[i] = Math.Round(array[i] / 2, 2);
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
        double min = double.MinValue, max = double.MaxValue;
        int n = 0, k = 0, t = 0, c = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < max)
            {
                max = array[i];
                k = i;
            }
            if (array[i] > min)
            {
                min = array[i];
                t = i;
            }

        }
        for(int v = Math.Min(k, t) + 1; v < Math.Max(k,t); v++)
        {
            if (array[v] < 0 && array[v] != 0)
            {
                n++;
            }
        }
        double[] b = new double[n];
        for(int i = Math.Min(k, t) + 1; i < Math.Max(k, t); i++)
        {
            if (array[i] < 0 && array[i] != 0)
            {
                b[c] = array[i];
                c++;
            }
        }
        array = b;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
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
        int l = array.Length, ind = 0;
        double max = array[0];
        for (int i = 0; i < l; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
        for (int i = 0; i < l; i++)
        {
            if (i + 2 > l)
            {
                return array;
            }
            if (array[i] == max && array[i + 1] > 0 )
            {
                array[i + 1] = array[i + 1] * 2;
                Console.WriteLine(array[i + 1]);

            }
            if (array[i] == max && array[i + 1] < 0)
            {
                array[i + 1] = Math.Round(array[i + 1] / 2, 2);
                Console.WriteLine(array[i + 1]);
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
        double min = array[0];
        double max = array[0], s = 0;
        int indmax = 0, indmin = 0, count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indmax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                indmin = i;
            }
        }
        for(int i = Math.Min(indmax, indmin) + 1; i < Math.Max(indmax, indmin); i++)
        {
            s += array[i];
            count++;
        }
        if(count == 0)
        {
            return 0;
        }
        average = s / count;
        Console.WriteLine(average);

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
        double n;
        int indp = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                n = array[i];
                indp = i;
                count++;
            }
        }
        if(count == 0)
        {
            return array;
        }
        double[] b = new double[array.Length + 1];
        for(int i = 0; i <= indp; i++)
        {
            b[i] = array[i];
        }
        for (int i = indp + 2; i < indp; i++)
        {
            b[i] = array[i];
        }
        b[indp + 1] = P;
        array = b;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
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
        int indmax = 0;
        double max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max && i % 2 == 0)
            {
                indmax = i;
                max = array[i];
            }
        }
        array[indmax] = indmax;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        int LA = A.Length, LB = B.Length;
        double[] b = new double[LA + LB];
        if (k >= LA) return A;
        for (int i = 0; i <= k; i++)
        {
            b[i] = A[i];
            //Console.WriteLine(b[i]);
        }
        for (int i = k + 1; i < k + 1 + LB; i++)
        {
            b[i] = B[i - k - 1];
            //Console.WriteLine(b[i]);
        }
        for (int i = k + 1 + B.Length; i < A.Length + B.Length; i++)
        {
            b[i] = A[i - B.Length];
            //Console.WriteLine(b[i]);
        }
        output = b;
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
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
        double max = array[0], min = array[0], imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        int count = 0;
        double s = 0;
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    count++;
                }
            }
            if (count == 0)
                return 0;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    s += array[i];
                    count++;
                }
            }
            if (count == 0)
                return 0;
        }
        average = s / count;
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
        double max = array[0], s = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        if (max > s)
        {
            array[imax] = 0;
        }
        else
        {
            array[imax] = max * 2;
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
        double max = array[0];
        int imax = 0, n = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                count = 0;
            }
            if (array[i] == max)
            {
                count++;
            }
        }
        int[] b = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                b[n] = i;
                n++;
            }
        }
        output = b;

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
        double max = array[0], s = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = s;
                s += max;
            }
            else
            {
                s += array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        int p = 0, neg = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 || array[i]==0)
            {
                p++;
            }
            if (array[i] < 0)
            {
                neg++;
            }
        }
        double[] a = new double[p];
        double[] b = new double[neg];
        double[] d = new double[array.Length];
        int c = 0, n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 || array[i] == 0)
            {
                a[c] = array[i];
                c++;
            }
            if (array[i] < 0)
            {
                b[n] = array[i];
                n++;
            }
        }
        int y = 0;
        for (int i = 0; i < a.Length; i++)
        {
            d[y] = a[i];
            y++;
        }
        for (int i = 0; i < b.Length; i++)
        {
            d[y] = b[i];
            y++;
        }


        array = d;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        double[] a = new double[array.Length];
        for(int i = 1; i < array.Length; i++)
        {
            a[i-1] = array[(i - 1)/ 2];
            a[i] = array[(i - 1)/ 2];
        }
        array = a;
        for(int i = 0; i < array.Length; i++)
        {
           Console.WriteLine(array[i]);
        }
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
        bool prove = false;
        int k = 0, l = array.Length;
        double[] a = new double[l];
        for (int i = 0; i < l; i++)
        {
            prove = false;
            for (int j = 0; j < k; j++)
            {
                if (Math.Abs(array[i] - a[j]) < 0.005)
                {
                    prove = true;
                }
            }
            if (!prove)
            {
                a[k] = array[i];
                Console.WriteLine(a[k]);
                k++;
            }
        }
        array = new double[k];
        for (int i = 0; i < k; i++)
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
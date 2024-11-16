using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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
            array[i] /= s;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        s /= k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = s;
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
            // end

            return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] / array.Length;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= s;
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
            // end

            return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] / array.Length;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
                array[i] = 0;
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
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i] / array.Length;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
                count++;
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
            if (array[i] > P && array[i] < Q )
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                n++;
        }
        double[] output = new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                output[n++] = array[i]; 
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
        int e = 0, o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2 == 0)
                even[e++] = array[i];
            else
                odd[o++] = array[i];
        }
        // end

            return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int index = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                break;
            }
        }
        
        for (int i = 0; i < index; i++)
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

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
                continue;
            }
            y[i] = 0.5 * Math.Log(x[i]);
            Console.WriteLine($"{x[i]}  {y[i]}");
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
        double lmax = -10000, imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= lmax)
            {
                lmax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < imax; i++)
        {
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
        double lmax = -10000, s = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= lmax)
            {
                lmax = array[i];
                imax = i;
            }
            s += array[i] / array.Length;
        }

        for (int i = imax+1; i < array.Length; i++)
        {
            array[i] = s;
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
        double s = 0, length = 1000;
        int k = 0;
        for (int i = 0; i < array.Length; i++)//находим среднее значение
        {
            s += array[i] / array.Length;
        }
        double[] b = new double[array.Length+1];
        s = Math.Round(s,2);
        for (int i = 0; i < array.Length; i++)//Вычисляем самый приблеженный элемент
        {
            if (Math.Abs(array[i] - s) < length)
            {
                length = Math.Abs(array[i] - s);
                k = i;
            }
        }
        k++;
        for (int i = 0; i < k; i++)
        {
            if (i<k)
                b[i] = array[i];
        }
        b[k] = P;
        for (int i = k; i < array.Length; i++)
        {
            b[i+1] = array[i];
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
        double lmax = -10000000, lmin = 10000000;
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] >= lmax)
            {
                lmax = array[i];
                imax = i;
            }
        }
        for (int i = imax; i < array.Length; i++)
        {
            if (array[i] <= lmin)
            {
                lmin = array[i];
                imin = i;
            }
        }
        double c = lmax;
        array[imax] = lmin;
        array[imin] = c;
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
        double lmin = 10000000;
        int imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < lmin && array[i]>0)
            {
                lmin = array[i];
                imin = i;
            }
        }
        if (lmin != 10000000)
        {
            double[] b = new double[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < imin)
                    b[i] = array[i];
                else
                    b[i] = array[i + 1];
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
        double lmax = -100000000, s = 0;
        int imin = -1, imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                imin = i;
                break;
            }
        }
        if (imin != -1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= lmax)
                {
                    lmax = array[i];
                    imax = i;
                }
            }
            for (int i = imax + 1; i < array.Length; i++)
            {
                s += array[i];
            }
            array[imin] = s;
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
        double lmax = -100000000, s = 0, lmin = 0;
        int imin = -1, imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > lmax)
            {
                lmax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                lmin = array[i];
                imin = i;
                break;
            }
        }
        if (lmin != 0 && imax!=imin)
        {
            double c = lmax;
            array[imax] = lmin;
            array[imin] = c;
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
        

        // code here
        double s = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i]/array.Length;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < s)
                n++;
        }
        int[] output = new int[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < s)
                output[n++] = i;
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
        double chmax = -100000000, nchmax = -10000000;
        int nch = 0, ch = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (i % 2 != 0)
                nch++;
            else
                ch++;
            if (array[i] > chmax && i%2 == 0)
            {
                chmax = array[i];

            }
            else if (array[i] > nchmax && i%2 != 0)
            {
                nchmax = array[i];
            }
        }
        if (chmax > nchmax)
        {
            for (int i = 0; i < ch; i++)
            {
                array[i] = 0;
            }
        }
        else
        { 
            for (int i = nch; i < array.Length; i++)
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
        double lmin = 10000000, lneg = 0;
        int imin = -1, ineg = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ineg = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < lmin)
            {
                lmin = array[i];
                imin = i;
            }
        }
        if (ineg < imin)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double lmax = -10000000000, n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > lmax)
            {
                lmax = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (lmax == array[i])
            {
                n++;
                array[i] += n;
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
        for (int i = 0; i < array.Length-1; i++)
        {
            if (i % 2 == 0)
            {
                double amin = array[i];
                int imin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < amin && j%2 == 0)
                    {
                        amin = array[j];
                        imin = j;
                    }
                }
                array[imin] = array[i];
                array[i] = amin;
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
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                double amax = array[i];
                int imax = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > amax && array[j] < 0)
                    {
                        amax = array[j];
                        imax = j;
                    }
                }
                array[imax] = array[i];
                array[i] = amax;
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
        double[] X = new double[n], Y = new double[n];
        double globalMax = -10000000000, globalMin = 100000000000;

        // code here
        double h = (b-a) / (n-1);//шаг
        int c = 0, imax = 0, imin = 0;
        for (double x = a; x <= b; x += h) //Составляем таблицу функции
        {
            X[c] = Math.Round(x,2);
            double y = Math.Cos(x) + x * Math.Sin(x);
            Y[c] = Math.Round(y, 2);
            c++;

            if (y > globalMax)
                globalMax = y;

            if (y < globalMin)
                globalMin = y;
        }

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
        double[] normalizedArray = new double[array.Length];

        // code here
        double lmax = -100000000, lmin = 100000000;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > lmax) 
                lmax = array[i];
            if (array[i] < lmin)
                lmin = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            double v = ((array[i] - lmin)*2/ (lmax - lmin)) - 1;
            normalizedArray[n] = Math.Round(v,2);
            n++;
        }
        // end

        return normalizedArray;
    }
    #endregion
}
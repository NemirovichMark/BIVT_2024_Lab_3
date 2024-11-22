using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_3_4(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
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
        double s = 0; int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s = s + array[i];
                m += 1;
            }
        }
        double sr = s / m;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sr, 2);
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
            sum[i] = Math.Round(first[i] + second[i], 2);
        for (int i = 0; i < 4; i++)
            dif[i] = Math.Round(first[i] - second[i], 2);

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        sr = s / 5;
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i] - sr, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
            product = Math.Round(product + vector1[i] * vector2[i], 2);
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
        double s = 0, k = 0, sr = 0;
        for (int i = 0; i < 7; i++)
        {
            s = s + array[i];
            k += 1;
        }
        sr = s / k;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
        double s = 0, sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        sr = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
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
        int count = 0, g = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[g] = array[i];
                g++;
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
        double[] odd = new double[array.Length / 2];

        // code here
        int x = 0, y = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[x] = array[i];
                x++;
            }
            else
            {
                odd[y] = array[i];
                y++;
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
            if (array[i] < 0)
                break;
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
            if (x[i] == 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double amin = array[0];
        int g = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                g = i;
            }
        }
        if (array[g] >= 0)
            array[g] *= 2;
        else
            array[g] /= 2;

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
        double amin = array[0];
        int g = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                g = i;
            }
        }
        for (int i = 0; i < g; i++)
            if (array[i] >= 0)
                array[i] *= 2;
            else
                array[i] /= 2;
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
        int mini = -1, maxi = -1, count = 0;
        double emin = 100000000000, emax = -10000000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= emin)
            {
                emin = array[i];
                mini = i;
            }
            if (array[i] >= emax)
            {
                emax = array[i];
                maxi = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && i < maxi && i > mini)
            {
                count++;
            }
        }
        double[] b = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && i < maxi && i > mini)
            {
                b[count] = array[i];
                count++;
            }
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
        double amax = array[0];
        int g = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                g = i;
            }
        }
        if (array.Length - 1 != g)
        {
            if (array[g + 1] >= 0)
            {
                array[g + 1] *= 2;
            }
            else
            {
                array[g + 1] /= 2;
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
        int mini = -1, maxi = -1, count = 0;
        double emin = 100000000000, emax = -10000000000;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= emin)
            {
                emin = array[i];
                mini = i;
            }
            if (array[i] >= emax)
            {
                emax = array[i];
                maxi = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if ((i < maxi && i > mini) || (i > maxi && i < mini))
            {
                s += array[i];
                count++;
            }
        }
        if (count != 0)
            average = s / count;
        else average = 0;
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
        int iel = 0, count = 0;
        double[] b = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                iel = i;
                count++;
            }
        }
        if (count == 0)
            return array;
        else
        {
            for (int i = 0; i <= iel; i++)
            {
                b[i] = array[i];
            }
            b[iel + 1] = P;
            for (int i = iel + 2; i < array.Length + 1; i++)
                b[i] = array[i];
            array = b;
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
        int maxi = 0;
        double emax = -1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= emax && i % 2 == 0)
            {
                emax = array[i];
                maxi = i;
            }
        }
        array[maxi] = maxi;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}
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
        double[] output = new double[A.Length + B.Length];

        // code here
        int j = 0, g = 0;
        if (k >= A.Length)
            return A;
        else
        {
            for (int i = 0; i <= k; i++)
                output[i] = A[i];
            for (int i = k + 1; i <= k + B.Length; i++)
            {
                output[i] = B[j];
                j++;
            }
            g = k + 1;
            for (int i = k + B.Length + 1; i < A.Length + B.Length; i++)
            {
                output[i] = A[g];
                g++;
            }
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
        int maxi = 0, mini = 0, k = 0, g = 0;
        double emax = -1000000000, srmaxi = 0, srmini = 0, emin = 1000000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= emax)
            {
                emax = array[i];
                maxi = i;
            }
            if (array[i] <= emin)
            {
                emin = array[i];
                mini = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (maxi < mini && array[i] > 0)
            {
                srmaxi += array[i];
                k++;
            }
            if (maxi > mini && array[i] < 0)
            {
                srmini += array[i];
                g++;
            }
        }
        if (k != 0)
            average = srmaxi / k;
        if (g != 0)
            average = srmini / g;


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
        int maxi = 0;
        double emax = -100000000, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > emax)
            {
                emax = array[i];
                maxi = i;
            }
        }
        if (emax > s)
            array[maxi] = 0;
        else
            array[maxi] *= 2;


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
        int maxi = 0, count = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxi])
            {
                maxi = i;
                count = 1;
            }
            else if (array[i] == array[maxi])
                count++;
        }
        output = new int[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == array[maxi])
            {
                output[count++] = i;
            }
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
        double sum = 0, emax = -10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > emax)
            {
                emax = array[i];
            }
        }
        sum = -emax;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != emax)
            {
                sum += array[i];
            }
            else if (array[i] == emax)
            {
                sum += array[i];
                array[i] = sum;
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
        double[] result = new double[array.Length];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                result[index++] = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                result[index++] = array[i];
            }
        }
        array = result;
        //Console.WriteLine("Массив после перестановки отрицательных элементов в конец:");
        //foreach (var number in array)
        //{
        //    Console.Write(number + " ");
        //}
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
        double е=0;
        for (int i = array.Length-1; i >=0; i-=2)
        {
            array[i] = array[i/2];
            array[i-1] = array[i];
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
        int count = 0, k=0;
        int[] a = new int[array.Length];
        double[] arr = null;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j] && array[j] != 1.123456789)
                {
                    a[k++] = j;
                    array[j] = 1.123456789;
                    count++;
                }

            }
        }
        arr = new double[array.Length - count];
        int h = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 1.123456789)
            {
                arr[h++] = array[i];
            }
        }
        array = arr;

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
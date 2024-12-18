using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
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
        program.Task_1_1(new double[] { 1, 2, 3, 4, 5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double su = 0;
        for (int i = 0; i < 6; i++)
        {
            su += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = array[i] / su;
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int k = 0;
        double su = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                k++;
                su += array[i];
            }
        }
        su = su / k;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) { array[i] = su; }


        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i < 4; i++)
        {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // code here

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double su = 0;
        for (int i = 0; i < 5; i++)
        {
            su += array[i];
        }
        su = su / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] = array[i] - su;
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        for (int i = 0; i < 5; i++)
        {
            length += Math.Pow(vector[i], 2);
        }
        length = Math.Pow(length, 0.5);

        // code here

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        sum = sum / 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sum)
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
        for (int i = 0; i < 6; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        // code here

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        sum = sum / 7;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sum)
            {
                count++;
            }
        }
        // code here

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {

            if ((Q > array[i]) && (P < array[i]))
            {
                count++;
            }
        }
        // code here

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[i] = array[i];
            }
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        for (int i = 7; i < 8; i--)
        {
            if (array[i] < 0)
            {
                index += i;
                value = array[i];
                break;
            }
        }

        // code here

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        for (int i = 0; i < 10; i = i + 2)
        {
            even[i / 2] = array[i];
            odd[i / 2] = array[i + 1];

        }
        // code here

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0)
            {
                break;
            }
            sum += array[i] * array[i];
        }
        // code here

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i = 0; i < 10; i++)
        {
            y[i] = 0.5 * Math.Log(x[i]);
            Console.WriteLine((Convert.ToString(x[i])) + " " + Convert.ToString(y[i]));
        }

        // code here

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        int len = array.Length;
        double p = 1000000;
        int ind = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < p)
            {
                ind = i;
                p = array[i];
            }
        }
        array[ind] *= 2;


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
        int len = array.Length;
        double p = 1000000;
        int ind = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < p)
            {
                ind = i;
                p = array[i];
            }
        }
        for (int i = 0; i < ind; i++)
        {
            array[i] *= 2;
        }


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
        int len = array.Length;
        double p = 1000000;
        int ind1 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < p)
            {
                ind1 = i;
                p = array[i];
            }
        }
        p = 0;
        int ind2 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] > p)
            {
                ind2 = i;
                p = array[i];
            }
        }
        int indmin = Math.Min(ind1, ind2);
        int indmax = Math.Max(ind1, ind2);
        //double[] array1 = new double[indmax];
        int k = 0;
        for (int i = indmin; i <= indmax; i++)
        {
            if ((array[i] < 0))
            {
                k++;
            }
        }
        double[] array1 = new double[k];
        k = 0;
        for (int i = indmin; i <= indmax; i++)
        {
            if ((array[i] < 0))
            {
                array1[k] = array[i];
                k++;
            }

        }

        return array1;
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
        int le = array.Length;
        double ma = 0;
        int ind = 0;
        for (int i = 0; i < le; i++)
        {
            if (array[i] > ma)
            {
                ma = array[i];
                ind = i;
            }
        }
        array[ind + 1] *= 2;
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
        int len = array.Length;
        double p = 1000000;
        int ind1 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < p)
            {
                ind1 = i;
                p = array[i];
            }
        }
        p = 0;
        int ind2 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] > p)
            {
                ind2 = i;
                p = array[i];
            }
        }
        int indmin = Math.Min(ind1, ind2);
        int indmax = Math.Max(ind1, ind2);
        p = 0;
        for (int i = indmin; i <= indmax; i++)
        {
            p += array[i];
        }
        average = p / (indmax - indmin + 1);

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
        int len = array.Length;
        int ind = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] > 0)
            {
                ind = i;
            }
        }
        double[] array1 = new double[len + 1];
        int i1 = 0;
        int i2 = 0;
        while (i1 <= len)
        {
            if (i1 == ind)
            {
                array1[i1] = P;
                i1++;
            }
            array[i1] = array[i2];
            i1++;
            i2++;
        }

        // end

        return array1;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        int len = array.Length;
        int ind = 0;
        double ma = 0;
        for (int i = 0; i < len; i = i + 2)
        {
            if (array[i] > ma)
            {
                ma = array[i];
                ind = i;
            }
        }
        array[ind] = ind;
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
        int n = A.Length;
        int m = B.Length;
        double[] output = new double[n + m];
        int p = 0;
        for (int j = 0; j <= k; j++)
        {
            output[p] = A[j];
            p++;
        }
        int i = k + 1;
        m = m + k + 1;
        while (i < m)
        {
            output[p] = B[i - k - 1];
            p++;
            i++;

        }
        m = m - k - 1;
        while (i < (n + m))
        {
            output[p] = A[i - m];
            p++;
        }

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
        int len = array.Length;
        double p = 1000000;
        int ind1 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] < p)
            {
                ind1 = i;
                p = array[i];
            }
        }
        p = 0;
        int ind2 = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] > p)
            {
                ind2 = i;
                p = array[i];
            }
        }
        p = 0;
        if (ind2 < ind1)
        {
            for (int i = 0; i < len; i++)
            {
                if ((array[i] > 0)) {
                    p++;
                    average += array[i];
                }
            }
            average /= p;
        }
        else
        {
            for (int i = 0; i < len; i++)
            {
                if (array[i] < 0)
                {
                    p++;

                    average += array[i];
                }

            }
            average /= p;
        }
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
        int tf = 0;
        int len = array.Length;
        int ind = 0;
        double ma = 0;
        double su = 0;
        for (int i = 0; i < len; i++)
        {
            if ((array[i] > ma)) {
                ind = i;
                ma = array[i];
            }
            su += array[i];
        }
        if (ma > su)
        {
            array[ind] = 0;
        }
        else
        {
            array[ind] *= 2;
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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        int ind = 0;
        double ma = 0;
        double n = array.Length;
        for (int i = 0; i < n; i++)
        {
            if ((array[i] > ma))
            {
                ind = i;
                ma = array[i];
            }
        }
            double p = 0;
            for (int i = 0; i < (ind - 1); i = i + 2)
            {
                p = array[i];
                array[i] = array[i + 1];
                array[i + 1] = p;
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
            int count = 0; int k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > array[i + 1]))
                {
                    k++;
                    count = Math.Max(k, count);
                }
                else
                {
                    k = 1;
                }
            }







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
            int count = 0; int k = 0; int pred = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > array[i + 1]))
                {
                    k++;
                    count = Math.Max(k, count);
                }
                else
                {
                    k = 1;
                }
            }
            pred = count;
            k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > array[i + 1]))
                {
                    k++;
                    count = Math.Max(k, count);
                }
                else
                {
                    k = 1;
                }
            }
            // code here
            count = Math.Max(count, pred);
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

            return (X, Y, globalMax, globalMin);
        }
        public double[] Task_3_12(double[] array)
        {
            int len = array.Length;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }
            double[] array1 = new double[count];
            int i1 = 0;
            int i2 = 0;
            while ((i1 < len) && (i2 < count))
            {
                if ((array1[i1] >= 0))
                {
                    array1[i2] = array[i1];
                    i2++;
                }
                i1++;
            }




            // end

            return array1;
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


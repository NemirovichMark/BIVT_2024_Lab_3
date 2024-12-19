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
        double sum = 0;
        foreach (double x in array)
        {
            sum += x;
        }
        if (sum != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] /= sum;
                array[i] = Math.Round(array[i], 2);
            }
        }
        else
            return array;
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double cnt = 0;
        double sr_znach = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                sum += x;
                cnt += 1;
            }
        }

        sr_znach = sum / cnt;
        sr_znach = Math.Round(sr_znach, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = sr_znach;
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
        for (int i = 0; i < 5; i++)
            s += array[i];
        for (int j = 0; j < 5; j++)
        {
            array[j] -= (s / 5);
            array[j] = Math.Round(array[j], 2);
        }
        // end


        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        if (vector1.Length == vector2.Length)
        {
            for (int i = 0; i < vector2.Length; i++)
            {
                product += vector1[i] * vector2[i];
            }
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average)
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
            if ((array[i] < 0))
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        double sr = s / (array.Length - 1);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count++] = array[i];
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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
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
        for (int i = 0; i < array.Length / 2; i++)
        {
            even[i] = array[i * 2];
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            odd[i] = array[i * 2 + 1];
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
            else break;

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
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
            }
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]}\t {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double k_min = 100000000;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < k_min)
            {
                k_min = array[i];
                k = i;
            }
        }
        if (array[k] > 0)
            array[k] *= 2;
        else array[k] /= 2;
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
        double min = 9999;
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                ind = i;
            }

        }
        for (int n = 0; n < ind; n++)
        {
            if (array[n] > 0)
                array[n] *= 2;
            else array[n] /= 2;
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
        double max = -100000000;
        double min = 10000000;
        int id_max = 0;
        int id_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                id_min = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                id_max = i;
            }
        }
        int a = 0;
        int b = 0;
        if (id_max > id_min)
        {
            a = id_min;
            b = id_max;
        }
        else { a =  id_max; b = id_min; }

        int c = 0;

        for (int i = a + 1; i < b; i++)
            if (array[i] < 0)
            {
                c++;
            }

        int d = 0;
        double[] array_new = new double[c];

        for (int i = a + 1; i < b; i++)
            if (array[i] < 0)
            {
                array_new[d] = array[i];
                d++;
            }

        // end

        return array_new;
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
        double max = -10000000;
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
        if (ind != array.Length - 1)
        {
            if (array[ind + 1] > 0)
                array[ind + 1] *= 2;
            else array[ind + 1] /= 2;
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
        double max = 0;
        double min = array[0];
        int indexmin = 0;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                indexmin = i;
                min = array[i];
            }
            if (array[i] > max)
            {
                indexmax = i;
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if ((i > indexmin && i < indexmax) || (i > indexmax && i < indexmin))
            { 
                average += array[i]; 
            }
        }

        if ((Math.Abs(indexmax - indexmin) - 1) == 0) 
            average = 0;

        else 
            average = average / (Math.Abs(indexmax - indexmin) - 1);
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
        double[] array1 = new double[array.Length + 1];
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) index = i;
        }
        if 
            (index == -1) return array;

        index++;
        for (int i = 0; i < array1.Length; i++)
        {
            if
                (i < index) array1[i] = array[i];
            else if 
                (i == index) array1[i] = P;
            else 
                array1[i] = array[i - 1];
        }
        array = array1;
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
        double max = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (i == index)
                array[i] = index / 1.0;
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
        int num = A.Length + B.Length;
        output = new double[num];

        if (k < A.Length)
        {
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[i + k + 1] = B[i];
            }
            for (int i = A.Length - 1; i >= k + 1; i--)
            {
                output[i + B.Length] = A[i];
            }
        }
        else
        {
            output = A;
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
        double max = -10000000000;
        double min = 10000000000;
        int minNum = 0;
        int maxNum = 0;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxNum = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minNum = i;
            }
        }
        if (maxNum - minNum < 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    counter += 1;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    average += array[i];
                    counter += 1;
                }
            }
        }
        if (average > 0)
        {
            average /= counter;
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
        double max = -10000000000;
        double sum = 0;
        int maxNum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxNum = i;
            }
            sum += array[i];
        }
        if (max - sum > 0)
        {
            array[maxNum] = 0;
        }
        else
        {
            array[maxNum] *= 2;
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
        int cnt = 1;
        double maxNum = -10000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxNum)
                cnt++;
            if (array[i] > maxNum)
            {
                maxNum = array[i];
                cnt = 1;
            }
        }
        int[] output2 = new int[cnt];
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxNum)
            {
                output2[ind] = i;
                ind++;
            }
        }
        output = output2;
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
        int[] indexes = null;

        double curmax = double.MinValue;
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curn = 1;
                indexes = new int[] { i };
            }
            else if (array[i] == curmax)
            {
                curn++;
                int[] curindexes = new int[curn];
                for (int j = 0; j < indexes.Length; j++)
                {
                    curindexes[j] = indexes[j];
                }
                curindexes[curn - 1] = i;
                indexes = curindexes;
            }
        }

        double[] sums = new double[indexes.Length];

        for (int i = 0; i < indexes.Length; i++)
        {
            double cursum = 0.0;
            for (int j = 0; j < indexes[i]; j++)
            {
                cursum += array[j];
            }
            sums[i] = cursum;
        }

        for (int i = 0; i < indexes.Length; i++)
        {
            array[indexes[i]] = sums[i];
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
        double[] otric = null;
        int num = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                num++;
                if (otric != null)
                {
                    double[] curotric = new double[num];
                    for (int j = 0; j < otric.Length; j++)
                    {
                        curotric[j] = otric[j];
                    }
                    curotric[num - 1] = array[i];
                    otric = curotric;
                }
                else
                {
                    otric = new double[] { array[i] };
                }
            }
        }

        double[] curarray = new double[array.Length];
        int curi = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                curarray[curi] = array[i];
                curi++;
            }
        }
        if (otric != null)
        {
            for (int i = 0; i < otric.Length; i++)
            {
                curarray[curi] = otric[i];
                curi++;
            }
        }

        array = curarray;
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
        double[] array1 = new double[array.Length];

        for (int i = 0; i < array.Length / 2; i++)
        {
            array1[i * 2] = array[i];
            array1[i * 2 + 1] = array[i];
        }

        array = array1;
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
        double[] array1 = new double[] { };
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array1.Contains(array[i]) == false)
            {
                curn++;
                if (array1 != null)
                {
                    double[] curotric = new double[curn];
                    for (int j = 0; j < array1.Length; j++)
                    {
                        curotric[j] = array1[j];
                    }
                    curotric[curn - 1] = array[i];
                    array1 = curotric;
                }
                else
                {
                    array1 = new double[] { array[i] };
                }
            }
        }

        array = array1;
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
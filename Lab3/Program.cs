using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            k += array[i];
        }

        for (int a = 0; a < array.Length; a++)
        {
            array[a] = Math.Round(array[a] / k, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double n = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >0) {
                n += array[i];
                k++;
            }
          

        }
        double avg = n / k;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = avg;
            }


        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i<4; i++)
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
        double sum = 0;
        for (int i = 0; i<5; i++) {
            sum += array[i];
       
        }
        sum = sum / 5;
        for (int i = 0;i<5; i++)
        {
            array[i] -= sum;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector2.Length; i++)
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
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = sum / 7;

        for (int i = 0; i < array.Length; i++)
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

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
            // end
        }
            return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = sum / 8;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum)
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
        int a = 0;
        int b = 0;

        foreach (var i in array)
        {
            if (i > 0)
            {
                a += 1;
            }
        }
        output = new double[a];

        foreach (var i in array)
        {
            if (i > 0)
            {
                output[b] = i;
                b += 1;
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
        int a = 0;
        int b = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[a] = array[i];
                a++;
            }
            else
            {
                odd[b] = array[i];
                b++;
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
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                y[i] = 0.5 * Math.Log(x[i]);
            }
            else y[i] = double.NaN;
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
        int maxi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxi]) maxi = i; 
        }
        for (int i = 0; i < maxi; i++)
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
        int maxi = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxi]) maxi = i;
            avg += array[i];
        }
        avg /= array.Length;
        for (int i = maxi + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(avg, 2);
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = sum / array.Length;
        int k = 0;
        double min = 1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sum) < min)
            {
                min = Math.Abs(array[i] - sum);
                k = i;
            }
        }
        double[] a = new double[array.Length + 1];
        for (int i = 0; i <= k; i++)
        {
            a[i] = array[i];
        }
        a[k + 1] = P;
        for (int i = k + 1; i < array.Length; i++)
        {
            a[i + 1] = array[i];
        }
        array = a;
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
        double max = -100, min = 100;
        int inmax = 0, inmin = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > max)
            {
                max = array[i];
                inmax = i;
            }
        }
        for (int i = inmax + 1; i < array.Length; i++) 
        {
            if (array[i] < min)
            {
                min = array[i];
                inmin = i;
            }
        }
        if (inmax > inmin)
        {
            return array;
        }
        else
        {
            double k = array[inmax]; 
            array[inmax] = array[inmin];
            array[inmin] = k;
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
        double min = 100;
        int imin = -100;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] < min && array[i] > 0)
            {
                min = array[i];
                imin = i;
            }
        }
        if (imin != -100) 
        {
            double[] a = new double[array.Length - 1];
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (i != imin)
                {
                    a[k] = array[i];
                    k++;
                }
            }
            array = a;
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
        double max = -100, sum = 0;
        int inmax = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] > max)
            {
                max = array[i];
                inmax = i;
            }
        }
        for (int i = inmax + 1; i < array.Length; i++) 
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) 
            {
                array[i] = sum;
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
        double max = -100, n = 0, k;
        int inmax = 0, inn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                inmax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) 
            {
                n = array[i];
                inn = i;
                break;
            }
        }
        if (n == 0 || max == -100)
            return array;
        k = array[inn];
        array[inn] = array[inmax]; 
        array[inmax] = k;
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
        double sum = 0, avg = 0;
        int k = 0, m = 0, n = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            sum += array[i];
        }
        avg = Math.Round(sum / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                k++;
            };
        }
        output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {


                output[n] = i;
                n++;
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
        double c = -100, n = 0;
        int inc = 0, inn = 0;
        for (int i = 0; i < array.Length; i += 2)   
        {
            if (array[i] > c)
            {
                c = array[i];
                inc = i;
            }
        }
        for (int i = 1; i < array.Length; i += 2) 
        {
            if (array[i] > n)
            {
                n = array[i];
                inn = i;
            }
        }
        int k = array.Length / 2;
        if (c > n)
        {
            for (int i = 0; i < k; i++) array[i] = 0;
        }
        if (c < n)
        {
            for (int i = 0; k < array.Length; k++) array[k] = 0;
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
        double min = 0, n = 0;
        int inmin = 0, inn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) 
            {
                n = array[i];
                inn = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] < min)
            {
                min = array[i];
                inmin = i;
            }
        }
        if (inn < inmin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) sum += array[i]; 
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i];
            }
        }
        if (inn == 0) return sum;
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
        double max = -1000, k = 0;
        int inmax = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                inmax = i;
            }

        }
        for (int i = 0; i < inmax && i+1!=inmax; i += 2)
        {
            k = array[i];
            array[i] = array[i + 1];
            array[i + 1] = k;
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
        int count = 0;

        int l = 1;
        if (array.Length == 0)
        {
            return count;
        }

        if (array.Length == 1)
        {
            return count;
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) 
            {
                l++;
                if (l > count) count = l;
            }
            else
            {
                l = 1; 
            }
        }

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
        int l = 1;
        if (array.Length == 0)
        {
            return count;
        }

        if (array.Length == 1)
        {
            return count;
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                l++;
                if (l > count) count = l;
            }
            else
            {
                l = 1;
            }

        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                l++;
                if (l > count) count = l;
            }
            else
            {
                l = 1;
            }

        }


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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }
        double[] k = new double[count];
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                k[ind] = array[i];
                ind++;
            }
        }
        array = k; 
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
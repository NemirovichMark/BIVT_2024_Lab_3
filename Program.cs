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
            array[i] = array[i] / s;
            array[i] = Math.Round(array [i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0; 
        double n = 0; 
        double a = 0;
        for (int i = 0; i < array.Length; i++) 
        { 
            if ( array[i] > 0) 
            { 
                s += array[i]; 
                n ++; 
            } 
        }
        a = Math.Round(s / n , 2);
        for (int i = 0; i < array.Length; i++) 
        {  
            if (array[i] > 0 ) 
            { 
                array[i] = a; 
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
            sum [i] = Math.Round(first[i] + second [i], 2);
            dif [i] = Math.Round(first[i] - second [i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        double n = 0;
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            n ++;
        }
        sr = s / n;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
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
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = sr / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                array [i] = 0;
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
                count ++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = sr / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                count ++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > P && array[i] < Q)
            {
                count ++;
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
        int b = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                n++;
        }
        output = new double[n];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                output[b++] = array[i];
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        double a = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                a = array[i];
                index = i;
            }
        }
        value = a;
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[count1] = array[i];
                count1 ++;
            }
            else if (i % 2 != 0)
            {
                odd[count2] = array[i];
                count2 ++;
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
            if (0.5 * Math.Log(x[i]) >= 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
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
        double a = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (a > array[i])
            {
                a = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == a)
            {
                if (a < 0)
                {
                    array[i] /= 2;
                }
                else
                {
                    array[i] *= 2;
                }
            }
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
        double a = array[0];
        double n = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (a > array[i])
            {
                a = array[i];
                n = i;
            }
        }
        for (int i = 0; i < n; i ++)
        {
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
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
        double min = array[0];
        double max = array[0];
        int n = 0, m = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
            if (max < array[i])
            {
                max = array[i];
                m = i;
            }
        }
        int st = 0, fin = 0;
        if(n < m)
        {
            st = n;
            fin = m;
        }
        else if (m < n)
        {
            st = m;
            fin = n;
        }
        int index = 0;
        for (int i = st + 1; i < fin; i++)
        {
            if (array[i] < 0)
            {
                index ++;
            }
        }
        double[] array1 = new double[index];
        index = 0;
        for (int i = st + 1; i < fin; i++)
        {
            if (array[i] < 0)
            {
                array1[index] = array[i];
                index ++;
            }
        }
        return array1;
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
        double Max = array[0];
        int n = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (Max < array[i])
            {
                Max = array[i];
                n = i;
            }
        }
        if (n < array.Length - 1)   
        {   
            if (array[n+1] < 0)
            {
                array[n+1] /= 2;
            }
            else if (array[n+1] > 0)
            {
                array[n+1] *= 2;
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
        double max = array[0];
        int s = 0;
        int n = 0, m = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
            if (max < array[i])
            {
                max = array[i];
                m = i;
            }
        }
        int st = 0, fin = 0;
        if(n < m)
        {
            st = n;
            fin = m;
        }
        else if (m < n)
        {
            st = m;
            fin = n;
        }
        double sum = 0;
        for (int i = st + 1; i < fin; i++)
        {
            sum += array[i];
            s ++;
        }
        if (s == 0)
            return 0;
        average = sum / s;
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
        double pol = 0;
        int ipol = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0)
            {
                pol = array[i];
                ipol = i ;
            }
        }

        double[] array1 = new double [array.Length + 1];

        if (pol != 0)
        {
            for (int i = 0; i <= ipol; i++)
            {
                if (i <= ipol)
                array1[i] = array[i];
            }
            array1[ipol + 1] = P;
            for (int i = ipol + 2; i < array.Length + 1; i++)
            {
                array1[i] = array[i - 1];
            }
        }
        if (pol != 0)
        {
            return array1;
        }
        else
        {
            return array;
        }

        for(int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine(array1[i]);
        }
        System.Console.WriteLine(" ");
        return array1;
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
        int n = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > max)
            {
                n = i;
                max = array[i];
            }
        }
        array[n] = n;
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
        output = new double[A.Length + B.Length];
        if (k >= A.Length)
            return A;
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        int n = 0;
        for (int i = k + 1; i < B.Length + k + 1; i++)
        {
            output[i] = B[n];
            n ++;
        }
        for (int i = B.Length + k + 1; i < A.Length + B.Length; i++)
        {
            output[i] = A[i - B.Length];
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
        double min = array[0];
        double max = array[0];
        int n = 0, m = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
            if (max < array[i])
            {
                max = array[i];
                m = i;
            }
        }
        double polsum = 0, otsum = 0;
        int indexpol = 0, indexot = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                polsum += array[i];
                indexpol ++;
            }
            else if (array[i] < 0)
            {
                otsum += array[i];
                indexot ++;
            }
        }
        if (m < n)
        {
            average = polsum / indexpol;
        }
        else if (n < m)
        {
            average = otsum / indexot;
            if (indexot == 0)
                return 0;
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
        double max = array[0];
        double sum = array[0];
        int n = 0;
        for (int i = 1; i < array.Length; i ++)
        {
            if (max < array[i])
            {
                max = array[i];
                n = i;
            }
            sum += array[i];
        }
        sum = sum - max;
        if (sum < 0)
        {
            array [n] = 0;
        }
        else 
        {
            max *= 2;
            array[n] = max;
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
        double max = double.MinValue;
        int n = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
                max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == max)
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
        for(int i = 2; i < array.Length; i += 2)
        {
            double n = array[i];
            int j = i - 2;
            while(j >= 0 && array[j] > n)
            {
                array[j + 2] = array[j];
                j -= 2;
            }
            array[j + 2] = n; 
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
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                count++;
            }
        }
        double [] arrayNeg = new double[count];
        count = 0;  
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                arrayNeg[count] = array[i];
                count++;
            }
        }

        for (int i = 0; i < arrayNeg.Length; i++)
        {
            double key = arrayNeg[i];
            int j = i - 1;
            while (j >= 0 && arrayNeg[j] < key)
            {
                arrayNeg[j + 1] = arrayNeg[j];
                j --;
            }
            arrayNeg[j + 1] = key;
        }
        count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                array[i] = arrayNeg[count];
                count++;
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
        globalMax = double.MinValue; globalMin = double.MaxValue;
        X = new double[n]; Y = new double[n];
        double step = (b - a) / (n - 1);
        int count = 0;
        for (double i = a; i <= b; i += step)
        {
            double v = Math.Cos(i) + i * Math.Sin(i);
            X[count] = Math.Round(i, 2);
            Y[count] = Math.Round(v, 2);
            count++;
            if (v > globalMax)
                globalMax = v;
            if (v < globalMin)
                globalMin = v;
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
        double[] normalizedArray = null;

        // code here
        double max = array[0], min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
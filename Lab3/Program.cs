using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, a = 0;
        int k = 0;
        for(int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        a = Math.Round(s / k * 1.0, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        a = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - a, 2);
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
            product += vector1[i]* vector2[i];
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

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, a = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        a = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > a)
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
        double s = 0, a = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        a = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
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
        // code here
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                a++;
            }
        }
        double[] output = new double[a];
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[m] = array[i];
                m++;
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
        int a = 0, b = 0;
        for(int i = 0; i < array.Length; i++)
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
            if (array[i] >=0)
            {
               sum += array[i] * array[i];
            }
            else
            {
                return sum;
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
            if (0.5 * Math.Log(x[i]) >= 0)
            {
                y[i] += Math.Round(0.5 * Math.Log(x[i]), 2);
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
        int a = 0;
        double c = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < c)
            {
                c = array[i];
                a = i;
            }
        }
        if (array[a] > 0)
        {
            array[a] *= 2;
        }
        else
        {
            array[a] /= 2;
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
        int a = 0;
        double c = 10000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < c)
            {
                c = array[i];
                a = i;
            }
        }
        for (int n = 0; n < a; n++)
        {
            if (array[n] > 0)
            {
                array[n] *= 2;
            }
            else
            {
                array[n] /= 2;
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
        int a = 0, b = 0, c = 0, s = 0;
        double maxi = -100000, mini = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                a = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                b = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                if (i > b || i > a)
                {
                    c++;
                }
            }
        }
        double[] array1 = new double[c];
        if (c==0)
        {
            return array1;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && (i > b || i > a))
            {
                array1[s] = array[i];
                s++;
            }
        }
        // end

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
        int a = 0;
        double maxi = -10000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                a = i;
            }
        }
        if (a != array.Length-1)
        {
            if (array[a + 1] > 0)
            {
                array[a + 1] *= 2;
            }
            else
            {
                array[a + 1] /= 2;
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
        int a = 0, b = 0, c = 0, s = 0;
        double maxi = -100000, mini = 100000, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                a = i;
            }
            if (array[i] < mini)
            {
                mini = array[i];
                b = i;
            }
        }
        if (b > a)
        {
            for (int i = a+1; i < b; i++)
            {
                sum += array[i];
                c++;
            }
        }
        else if (a > b)
        {
            for (int i = b + 1; i < a; i++)
            {
                sum += array[i];
                c++;
            }
        }
        if (c == 0)
        {
            return 0;
        }
        average = sum / c;
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
        int a = -1, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                a = i;
            }
        }
        if (a != -1)
        {
            double[] answer = new double[array.Length+1];
            for (int i = 0; i < answer.Length; i++)
            {
                if (a+1 != i)
                {
                    answer[i] = array[s];
                    s++;
                }
                else
                {
                    answer[i] = P;
                }
            }
            return answer;
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
        double maxi = -10000;
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    a = i;
                }
            }
        }
        array[a] = a;
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
        int s = 0, t = 0;

        // code here
        if (k == 7)
        {
            return A;
        }
        else
        {
            for (int i = 0; i <= k; i++)
            {
                output[s] = A[i];
                s++;
                t++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[s] = B[i];
                s++;
            }
            for (; t < A.Length; t++)
            {
                output[s] = A[t];
                s++;
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
        double average = 0, maxi = -10000, mini = 10000, k = 0, p = 0, sum = 0;
        int a = 0, b = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                b = i;
            }
            if (array[i] > maxi)
            {
                maxi = array[i];
                a = i;
            }
        }
        if (a < b)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    p++;
                }
                if (sum != 0)
                {
                    average = sum / p;
                }
            }
            average = sum / p;
        }
        else if (b > a)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                    k++;
                }
            }
            if (sum != 0)
            {
                average = sum/k;
            }
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
        double maxi = -10000, sum = 0;
        int a = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > maxi)
            {
                maxi = array[i];
                a = i;
            }
        }
        if (array[a] > sum)
        {
            array[a] = 0;
        }
        else
        {
            array[a] *= 2;
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
        // code here
        double f = -999, r = 0;
        int a = 0;
        for (int i = array.Length - 1;i >= 0; i--)
        {
            if (array[i] >= f)
            {
                f = array[i];
                a = i;
            }
        }
        for (int i = 0; i < a-1; i+=2)
        {
            r = array[i + 1];
            array[i + 1] = array[i];
            array[i] = r;
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
        // eecode here

        // end

        return array;
    }
    public int Task_3_6(double[] array)
    {
        int count = 0, k = 0;

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                k++;
            }
            else
            {
                if (k > count)
                {
                    count = k;
                }
                k = 1;
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
        int count = 0, a = 1, b = 1, c = 1, d = 1;

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                b++;
            }
            else
            {
                if (b > d)
                {
                    d = b;
                }
                b = 1;
            }
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] > array[i])
            {
                a++;
            }
            else
            {
                if (a > c)
                {
                    c += a;
                }
                a = 1;
            }
        }
        if (c > d)
        {
            count += c;
        }
        else
        {
            count += d;
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
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                a++;
            }
        }
        double[] otvet = new double[a]; 
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                otvet[j] = array[i];
                j++;
            }
        }
        array = otvet;
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
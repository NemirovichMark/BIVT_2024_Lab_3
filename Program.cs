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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0;i<6; i++)
        {
            sum += array[i];
        }
        for (int i = 0;i<6; i++)
        {
            array[i] = array[i]/sum;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int counter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                counter++;
            }
        }
        sum = sum/counter;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sum;
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
        int counter = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += array[i];
            counter++;
        }
        sum = sum/counter;
        for(int i = 0; i < 5; i++)
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

        // code here
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += vector[i] * vector[i];
        }
        length = Math.Sqrt(sum);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int counter = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
            counter++;
        }
        sum = sum/counter;
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

        // code here
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
        double sum = 0;
        int counter = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
            counter++;
        }
        sum = sum / counter;
        for (int i = 0; i < 8; i++)
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
        for (int i = 0; i < 10; i++)
        {
            if (P < array[i] & array[i] < Q)
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
        int num = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                n++;
            }
        }
        output = new double[n];
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[num] = array[i];
                num++;
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
        for (int i = 0; i < 8; i++)
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
        int e = 0;
        int o = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i%2 == 0)
            {
                even[e] = array[i];
                e++;
            }
            else
            {
                odd[o] = array[i];
                o++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ind = i;
                break;
            }
            else
                ind = i + 1;

        }
        for (int i = 0; i < ind; i++)
        {
            sum += (array[i] * array[i]);
        }
        sum = Math.Round(sum, 2);
        //int i = 0;
        //while (array[i] >= 0 & i<=10) 
        //{
        //    Console.WriteLine(i);
        //    Console.WriteLine("!");
        //    Console.WriteLine(array[i]);
        //    if (array[i] != 0)
        //    {
        //        sum += array[i] * array[i];
        //    }
        //    Console.WriteLine(sum);
        //    i++;
        //}
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
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
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                num = i;
            }
        }
        if (min< 0)
        {
            min /= 2;
        }
        else
        {
            min *= 2;
        }
        array[num] = min;
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
        double min = double.MaxValue;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                num = i;
                min = array[i];
            }
        }
        for (int j = 0; j < num; j++)
        {
            if (array[j] < 0)
            {
                array[j] /= 2;
            }
            else
            {
                array[j] *= 2;
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
        double min = double.MaxValue;
        double max = double.MinValue;
        int minNum = 0;
        int maxNum = 0;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minNum = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxNum = i;
            }
        }
        if (minNum > maxNum)
        {
            num = minNum;
            minNum = maxNum;
            maxNum = num;
            num = maxNum - minNum - 1;
        }
        else
        {
            num = maxNum-minNum-1;
        }
        Console.WriteLine(minNum);
        Console.WriteLine(maxNum);
        double[] answer = new double[num];
        for (int i = 0; i < num; i++)
        {
            
            if (array[minNum + 1 + i] < 0)
            {
                Console.WriteLine(array[minNum + 1 + i]);
                answer[i] = array[minNum + 1 + i];
            }
            else
            {
                answer = new double[0];
            }
        }
        // end
        Console.WriteLine(answer);
        return answer;
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
        double max = double.MinValue;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                num = i;
            }
        }
        if (num < array.Length-1)
        {
            if (array[num + 1] < 0)
            {
                array[num + 1] /= 2;
            }
            else
            {
                array[num + 1] *= 2;
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
        int minNum = 0;
        int maxNum = 0;
        double max = double.MinValue;
        double min = double.MaxValue;
        int num = 0;
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
        if (minNum > maxNum)
        {
            num = minNum;
            minNum = maxNum;
            maxNum = num;
            num = maxNum - minNum-1;
        }
        else
        {
            num = maxNum - minNum - 1;
        }
        for (int i = minNum+1; i < maxNum; i++)
        {
            average += array[i];
        }
        if (num > 0) 
        {
            average /= num;
        }
        else
        {
            average = 0;
        }
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
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                num = i;
            }
        }
        if (num > 0)
        {
            double[] answer = new double[array.Length+1];
            for (int i = array.Length - 1; i >= num + 1; i--)
            {
                answer[i+1] = array[i];
            }
            answer[num+1] = P;
            for (int i = 0;i < num + 1; i++)
            {
                answer[i] = array[i];
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
        double max = double.MinValue;
        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2 == 0 & array[i] > max)
            {
                max = array[i];
                num = i;
            }
        }
        array[num] = num;
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
        double max = double.MinValue;
        double min = double.MaxValue;
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
            for(int i = 0;i < array.Length; i++)
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
        double max = double.MinValue;
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double max = double.MinValue;
        int num = 1;
        for(int i = 0;i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += num;
                num++;
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
        int num = 0;
        if (array.Length % 2 == 0)
        {
            double[] even = new double[array.Length / 2];
            for (int i = 0; i < array.Length; i += 2)
            {
                even[num] = array[i];
                num++;
            }
            for (int i = 0; i < even.Length - 1; i++)
            {
                double min = even[i];
                int imin = i;
                for (int j = i+1; j < even.Length; j++)
                {
                    if (even[j] < min)
                    {
                        min = even[j];
                        imin = j;
                    }
                }
                even[imin] = even[i];
                even[i] = min;
            }
            //Array.Sort(even);
            num = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = even[num];
                num++;
            }
        }
        else
        {
            double[] even = new double[(array.Length / 2) + 1];
            for (int i = 0; i < array.Length; i += 2)
            {
                even[num] = array[i];
                num++;
            }
            for (int i = 0; i < even.Length - 1; i++)
            {
                double min = even[i];
                int imin = i;
                for (int j = i + 1; j < even.Length; j++)
                {
                    if (even[j] < min)
                    {
                        min = even[j];
                        imin = j;
                    }
                }
                even[imin] = even[i];
                even[i] = min;
            }
            //Array.Sort(even);
            num = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = even[num];
                num++;
            }
        }
        
        //for (int i = 0; i < array.Length - 1; i++)
        //{
        //    if (i%2 == 0)
        //    {
        //        double min = array[i];
        //        int imin = i;
        //        for (int j = 0; j < array.Length; j++)
        //        {
        //            if (array[j]<min )
        //            {
        //                min = array[j];
        //                imin = j;
        //            }
        //        }
        //        array[imin] = array[i];
        //        array[i] = min;
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}
        //Console.WriteLine();
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
        //const int n = 7;
        //int[] a = new int[n] { 4, -7, 9, -12, -3, -10, -8 };
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < 0)
            {
                double amax = array[i];
                int imax = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > amax & array[j]<0)
                    {
                        amax = array[j];
                        imax = j;
                    }
                }
                array[imax] = array[i];
                array[i] = amax;
            }
        }
        //for (int i = 0; i < array.Length; i++)
           // Console.Write("{0:d} ", array[i]);
        //Console.WriteLine();
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
        X = new double[n];
        Y = new double[n];
        double step = (b - a) / (n-1);
        double max = double.MinValue;
        double min = double.MaxValue;
        for(int i = 0; i < n; i++)
        {
            X[i] = a + i*step;
            Y[i] = Math.Cos(X[i]) + X[i]*Math.Sin(X[i]);
        }
        for(int i = 1; i < n - 1; i++)//локальные экстремумы
        {
            if (Y[i] > Y[i+1] & Y[i] > Y[i - 1])
            {
                Console.WriteLine($"Точка максимума:{X[i]},{Y[i]}");
            }
            else if (Y[i] < Y[i-1] & Y[i] < Y[i + 1])
            {
                Console.WriteLine($"Точка минимума:{X[i]},{Y[i]}");
            }
        }
        for (int i = 0;i < n; i++)
        {
            if (Y[i] > max)
            {
                max = Y[i];
            }
            if (Y[i] < min)
            {
                min = Y[i];
            }
        }
        globalMax = max;
        globalMin = min;

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
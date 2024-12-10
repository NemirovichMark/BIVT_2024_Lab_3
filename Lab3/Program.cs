using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        foreach (double i in array)
        {
            sum += i;
        }
        for (int i=0; i<= 5; i++)
        {
            array[i] /= sum;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double av = 0;
        int cnt = 0;
        foreach (double i in array)
        {
            if (i > 0)
            {
                av += i;
                cnt++;
            }
        }
        av /= cnt;
        av = Math.Round(av, 2);
        
        for (int i = 0; i<= 7; i++)
        {
            if (array[i] > 0)
            {
                array[i] = av;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i<= 3; i++)
        {
            sum[i] = first[i]+second[i];
            dif[i] = first[i]-second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double av = 0;
        foreach (double i in array)
        {
            
            av += i/5;
        }
        av = Math.Round(av, 2);

        for (int i = 0; i <= 4; i++)
        {
            array[i] -= av;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i<=3; i++)
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
        foreach (double i in vector)
        {
            length += i * i;
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double av = 0;
        foreach (double i in array)
        {
            av += i / 7;
        }
        //av = Math.Round(av, 2);
        for (int i = 0; i<= 6; i++)
        {
            if (array[i] > av)
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
        foreach(double i in array)
        {
            if (i<0)
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
        double av = 0;
        foreach (double i in array)
        {
            av += i / 8;
        }
        for (int i = 0; i<= 7; i++)
        {
            if (array[i] > av)
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
        foreach (double i in array)
        {
            if (i > P && i < Q)
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
        int cnt = 0;
        // code here
        foreach (double i in array)
        {
            if (i>0)
            {
                cnt++;
            }
        }
        output = new double[cnt];
        int num = 0;
        foreach (double j in array)
        {
            if (j > 0)
            {
                output[num] = j;
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
        for (int i = 1; i<= 8; i++)
        {
            if (array[8-i] < 0)
            {
                index = 8 - i;
                value = array[8-i];
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
        int c = 0;
        // code here
        for (int i = 0; i<= 9; i++)
        {
            if (i%2 == 0)
            {
                even[c] = array[i];
            }
            else
            {
                odd[c] = array[i];
                c++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double i in array)
        {
            if (i>= 0)
            {
                sum += i * i;
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
        for (int i = 0;i <= 9; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int j=0; j<=9; j++)
        {
            Console.WriteLine(x[j] + " " + y[j]);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min = double.PositiveInfinity;
        int index = 0;
        // code here
        for (int i = 0; i<= array.Length-1; i++)
        {
            if (array[i]< min)
            {
                min = array[i];
                index = i;
            }
         
        }
        if (array[index] > 0)
        {
            array[index] *= 2;
        }
        else
        {
            array[index] /= 2;
        }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;
        double min = double.PositiveInfinity;
        // code here
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        for (int i = 0; i<= array.Length - 1; i++)
        {
            if (array[i] == min)
            {
                break;
            }
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] /= 2;
            }
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        
        double sum = 0;
        double min = double.PositiveInfinity;
        // code here
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] == min)
            {
                break;
            }
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] /= 2;
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
        double min = double.PositiveInfinity;
        double max = double.NegativeInfinity;
        int cnt = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        bool fl = false;
        foreach (double i in array)
        {
            if (i == min)
            {
                fl = true;
                continue;
            }
            if (fl == true)
            {
                if (i == max)
                {
                    break;
                }
                if (i < 0)
                {
                    cnt += 1;
                }
            }
        }
        fl = false;
        double[] array2 = new double[cnt];
        int c = 0;
        foreach (double i in array)
        {
            if (i == min)
            {
                fl = true;
                continue;
            }
            if (fl == true)
            {
                if (i == max)
                {
                    break;
                }
                if (i < 0)
                {
                    array2[c] = i;
                    c++;
                }
            }
        }
        // end

        return array2;
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
        double max = double.NegativeInfinity;
        foreach (double i in array)
        {
            if (i>max)
            {
                max = i;
            }
        }
        for (int i = 1; i <= array.Length - 1; i++)
        {
            if (array[i - 1] == max)
            {
                if (array[i] > 0)
                {
                    array[i] *= 2;
                }
                else
                {
                    array[i] /= 2;
                }
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
        double min = double.PositiveInfinity;
        double max = double.NegativeInfinity;
        int cnt = 0;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        bool fl = false;
        double sum = 0;
        foreach (double i in array)
        {
            if (fl == true)
            {
                if (i == min || i == max)
                {
                    break;
                }
                cnt++;
                sum += i;
            }

            if (i == min || i == max)
            {
                fl = true;
                continue;
            }
        }
        if (cnt != 0)
        {
            average = sum / cnt;
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
        double[] x = new double[array.Length + 1];
        for (int i= 1; i<= array.Length; i++)
            if (array[array.Length-i] >0)
            {
                x[array.Length - i + 1] = P;
                break;
            }
        bool fl = false;
        for (int i = 0; i<= array.Length - 1; i++)
        {
            if (x[i] == P)
            {
                fl = true;
            }
            if (fl == false)
            {
                x[i] = array[i];
            }
            else
            {
                x[i+1] = array[i];
            }
        }
        bool P_check = false;
        foreach (double i in x)
        {
            if (i == P)
            {
                P_check = true;
            }
        }
        if (!P_check)
        {
            return array;
        }
        else
        {
            return x;
        }
        // end

        
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
        double max = double.NegativeInfinity;
        int max_index = 0;

        for (int i = 0; i<= array.Length-1; i+=2)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        array[max_index] = max_index;
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
        if (A.Length-1 < k)
        {
            return A;
        }
        
        double[] output = new double[A.Length + B.Length];
        bool fl = false;
        for (int i = 0; i <= A.Length-1; i++)
        {
            if (i==k+1)
            { 
                for (int j = 0; j <= B.Length-1; j++)
                {
                    output[i+j] = B[j];
                }
                fl = true;
            }
            if (fl == false)
            {
                output[i] = A[i];
            }
            else
            {
                output[i+B.Length] = A[i];
            }
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

        // code here
        double min = double.PositiveInfinity;
        double max = double.NegativeInfinity;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        bool fl = true;
        foreach (double i in array)
        {
            if (i==max)
            {
                break;
            }
            if (i==min)
            {
                fl = false;
                break;
            }
        }
        int cnt = 0;
        foreach (double i in array)
        {
            if (fl)
            {
                if (i>0)
                {
                    average += i;
                    cnt++;
                }
            }
            else
            {
                if (i<0)
                {
                    average += i;
                    cnt++;
                }
            }
        }
        if (cnt==0)
        {
            return 0;
        }
        average /= cnt;
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
        double sum = 0;
        double max = double.NegativeInfinity;
        int max_index = 0;
        for (int i = 0; i<= array.Length-1; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        if (max>sum)
        {
            array[max_index] = 0;
        }
        else
        {
            array[max_index] *= 2;
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
        double max = double.NegativeInfinity;
        // code here
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        int cnt = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] == max)
            {
                array[i] += cnt;
                cnt++;
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
        double max = double.NegativeInfinity;
        for (int i = 2; i <= array.Length - 1; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        double a;
        for (int j = 1; j <= array.Length/2; j++)
        {
            for (int i = 2; i <= array.Length - 1; i += 2)
            {
                if (array[i] < array[i - 2])
                {
                    a = array[i - 2];
                    array[i - 2] = array[i];
                    array[i] = a;
                }
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
        int last_index = -1;
        double a;
        for (int j = 1; j<= array.Length; j++)
        {
            last_index = -1;
            for (int i = 0; i<= array.Length - 1; i++)
            {
                if (array[i]<0)
                {
                    if (last_index == -1)
                    {
                        last_index = i;
                        continue;
                    }
                    else
                    {
                        if (array[i] > array[last_index])
                        {
                            a = array[i];
                            array[i] = array[last_index];
                            array[last_index] = a;
                        }
                        last_index = i;
                    }
                }
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
        double globalMax = double.NegativeInfinity, globalMin = double.PositiveInfinity;

        // code here
        X = new double[n];
        Y = new double[n];
        int j = 0;
        
        
        for (double i = a; i <= b; i += ((b-a) / (n-1)))
        {
            X[j] = Math.Round(i, 2);
            Y[j] = Math.Round(Math.Cos(i) + i*Math.Sin(i), 2);
            j++;
        }

        if (Y[0] < globalMin)
        {
            globalMin = Y[0];
        }
        if (Y[0] > globalMax)
        {
            globalMax = Y[0];

        }
        if (Y[n - 1] < globalMin)
        {
            globalMin = Y[n - 1];
        }
        if (Y[n - 1] > globalMax)
        {
            globalMax = Y[n - 1];
        }


            for (int i = 1; i <= n - 2; i++)
            {
                if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]))
                {
                    Console.WriteLine("x = " + X[i] + ", " + "y = " + Y[i] + ", максимум");
                    if (Y[i] > globalMax)
                    {
                        globalMax = Y[i];
                    }
                }
                if ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1]))
                {
                    Console.WriteLine("x = " + X[i] + ", " + "y = " + Y[i] + ", минимум");
                    if (Y[i] < globalMin)
                    {
                        globalMin = Y[i];
                    }
                }
            }

            // end

            return (X, Y, globalMax, globalMin);
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
        normalizedArray = new double[array.Length];
        double max = double.NegativeInfinity;
        double min = double.PositiveInfinity;
        foreach (double i in array)
        {
            if (i > max)
            {
                max = i;
            }
            if (i < min)
            {
                min = i;
            }
        }
        for (int i = 0; i <= array.Length- 1; i++)
        {
            normalizedArray[i] = (array[i] - min) * 2/(max - min) - 1;
        }
        // end

        return normalizedArray;
    }
    #endregion
}
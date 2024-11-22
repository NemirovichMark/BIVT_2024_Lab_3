using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        for (int i = 0; i < 6; i++)
            s += array[i];
        for (int i = 0; i < 6; i++)
        {
            array[i] = array[i] / s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double n = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                n++;
            }
             
        }
        s = Math.Round ( s/ n, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i]>0)
            {
                array[i] = s;
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i <5; i++)
        {
            sum += array[i];
        }
        sum = Math.Round((sum / 5), 2);
        for (int i = 0; i<5; i++)
        {
            array[i] = Math.Round(array[i] - sum,2);
        }
        // end
        
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i<4;i++)
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
        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for ( int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        for (int  i= 0; i < 7; i++)
        {
            if (array[i] > (s / 7))
                array[i] = 0;
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
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double s = 0;
        // code here
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 8; i++)
        {
            if ((array[i] > (s / 8)))
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i<10; i++)
        {
            if (array[i] < Q && array[i] > P)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int a = 0;
        int n = 0;
        // code here
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
                a++;
        output = new double[a];
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
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
        int chet = 0;
        int nechet = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2==0)
            {
                even[chet] = array[i];
                chet++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                odd[nechet] = array[i];
                nechet++;
            }
        }
            
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        int index = 0;
        // code here
        for (int i = 0; i<11; i++)
        {
            if (array[i] < 0) 
            {
                index = i;
                break;
            }
            else
            {
                index = 11;
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
            if (x[i] == 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            Console.WriteLine("{x[i]} {y[i]}");
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
        double k = -99999;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > k)
            {
                k = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == k)
                break;
            else
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
        double sum = 0;
        double max = 0;
        int c = 0;
        int z = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            c++;
            if (array[i] > max)
            {
                max = array[i];
                z = i;
            }
        }
        sum = Math.Round(sum / c, 2);
        for (int i = z + 1; i < array.Length; i++)
        {
            array[i] = sum;
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
        double sr = array.Sum() / array.Length;
        int index = -1;
        double min = 10000000;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < min)
            {
                min = Math.Abs(array[i] - sr);
                index = i;
            }
        }
        double[] b = new double[array.Length + 1];
        for (int i = 0; i <= index; i++)
        {
            b[i] = array[i];
        }
        b[index + 1] = P;
        for (int i = index + 1; i < array.Length; i++)
        {
            b[i + 1] = array[i];
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
        double max = -999999; int max_p = 0;
        double min = 999999; int min_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_p = i;
            }
        }
        for (int i = max_p + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                min_p = i;
            }
        }
        if (max_p > min_p)
        {
            return array;
        }
        else
        {
            double temp = array[max_p];
            array[max_p] = array[min_p];
            array[min_p] = temp;
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
        double min = 10000000;
        int index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        if (index != -1)
        {
            double[] b = new double[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    b[j++] = array[i];
                }
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
        double max = -999999;
        double sum = 0;
        int max_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_p = i;
            }
        }
        for (int i = max_p + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);
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
        double max = -999999; int max_p = 0;
        double min = 0; int min_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_p = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min = array[i];
                min_p = i;
                break;
            }
        }
        if (min == 0 || max == -999999)
            return array;
        double temp = array[max_p];
        array[max_p] = array[min_p];
        array[min_p] = temp;
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
        double sum = 0;
        int k = 0;
        int p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                k++;
            }
        }
        int[] output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                output[p] = i;
                p++;

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
        double max_chet = -99999;
        double max_nechet = -99999;
        int k = array.Length / 2;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) 
            {
                if (array[i] > max_chet)
                {
                    max_chet = array[i];
                }
            }
            if (i % 2 != 0)
            {
                if (array[i] > max_nechet)
                {
                    max_nechet = array[i];
                }
            }
        }
        if (max_chet > max_nechet)
        {
            for (int i = 0; i < k; i++)
            {
                array[i] = 0;
            }
        }
        if (max_chet < max_nechet)
        {
            for ( ; k < array.Length; k++)
            {
                array[k] = 0;
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
        double mini = 0;
        double mini_p = 0;
        double nech = 0;
        int nech_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                mini_p = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                nech = array[i];
                nech_p = i;
                break;
            }
        }
        if (nech_p == 0)
            return sum;
        if (mini_p > nech_p)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    sum += array[i];
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
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
        double max = array[0];
        int k = 0;
        for (int i = 1; i < array.Length; i++)
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
                array[i] += k + 1;
                k++;
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
        double k = 0;
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                k = array[i];
                a = i - 2;
                while (a >= 0 && array[a] > k)
                {
                    array[a + 2] = array[a];
                    a -= 2;
                }
                array[a + 2] = k;
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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k <= 1)
        {
            return array;
        }
        double[] mas = new double[k];
        int a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                mas[a] = array[i];
                a++;
            }
        }
        for (int i = 0; i < mas.Length - 1; i++)
        {
            for (int j = i + 1; j < mas.Length; j++)
            {
                if (mas[i] < mas[j])
                {
                    double t = mas[i];
                    mas[i] = mas[j];
                    mas[j] = t;
                }
            }
        }
        int l = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = mas[l];
                l++;
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
        double globalMax = -99999, globalMin = 99999;

        // code here
        X = new double[n];
        Y = new double[n];
        double step = (b - a) / (n - 1);
        int k = 0;
        double c = 0;
        for (double i = a; i <= b; i += step)
        {
            c = Math.Round(Math.Cos(i) + i * Math.Sin(i),2);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(c, 2);
            k++;

            if (c > globalMax)
                globalMax = c;

            if (c < globalMin)
                globalMin = c;
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
        double max = array[0];
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];

            if (array[i] > max) max = array[i];
        }
        for (int k = 0; k < array.Length; k++) normalizedArray[k] = Math.Round(2 * (array[k] - min) / (max - min) - 1, 2);
        foreach (double item in normalizedArray) Console.Write(item.ToString() + " ");
        // end

        return normalizedArray;
    }
    #endregion
}
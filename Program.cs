using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_2_5(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        if (s!=0)
        {
            for (int i = 0; i < 6; i++)
            {
                array[i] = Math.Round(array[i] / s, 2);
            }
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, sr = 0 ;
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k = k + 1;
            }

        }
        sr = Math.Round((s / k),2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) array[i] = sr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        double s = 0;
        for (int i = 0; i < 4; i++)
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
        double s = 0, sr = 0;
        for (int i = 0; i < 5; i++) s += array[i];
        sr = Math.Round((s / 5), 2);
        for (int i = 0; i < 5; i++) array[i] = Math.Round(array[i]-sr,2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++) product = Math.Round(product + vector1[i] * vector2[i], 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double l = 0;
        for (int i = 0; i < 5; i++)  length= length + vector[i] * vector[i];
        length=Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < 7; i++) s += array[i];
        sr = Math.Round((s / 7), 2);
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr) array[i] = 0;
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
            if (array[i] < 0) count= count + 1;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < 8; i++) s += array[i];
        sr = Math.Round((s / 8), 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr) count=count+1;
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
            if (array[i]>P && array[i]<Q) count= count + 1;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0) k = k + 1;
        }
        output = new double[k];
        k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
                k=k+1;
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
        for (int i = 0; i<8; i=i+1)
            if (array[i] < 0)
            {
                value= array[i];
                index = i;
            }

            // end

            return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int ke = 0;
        int ko = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[ke] = array[i];
                ke = ke + 1;
            }
            if (i % 2 != 0)
            {
                odd[ko] = array[i];
                ko = ko + 1;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] >= 0) sum = sum + array[i] * array[i];
            else break;
        }
        sum = Math.Round(sum, 2);
            // end

            return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i = i + 1)
        {
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            else y[i] = double.NaN;
            Console.WriteLine($"{x[i]} {y[i]}");
        }
            // end
            return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        //Минимальный элемент заданного одномерного массива увеличить в два раза.
        double min = 10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i]<= min) min = array[i];
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] == min)
            {
                if (min >= 0) array[i] = 2 * array[i];
                else array[i] = array[i] / 2;
            }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = -10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max) max = array[i];
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] != max) sum = sum + array[i];
            else break;
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = 10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] <= min) min = array[i];
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] != min)
            {
                if (array[i] >= 0) array[i] = 2 * array[i];
                if (array[i] < 0) array[i] = array[i]/2;
            }
            else break;
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        for (int i = 0; i < array.Length; i++) s += array[i];
        sr = Math.Round((s / array.Length), 2);
        double max = -10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max) max = array[i];
        for (int i = array.Length - 1; i >= 0; i--) if (array[i] != max) array[i] = sr; else break;
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        //double[] temp = null;
        int imin = -1, imax = -1;
        //int k = 0;
        double min = 10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] <= min)
            {
                min = array[i];
                imin = i;
            }
        double max = -10000000000;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max)
            {
                max = array[i];
                imax = i;
            }
        int k = 0;
        for (int i = 0; i < array.Length; i=i+1)// считаем количество отрицательных элементов между 
        {
            if (array[i] < 0 && imin < i && imax > i) k=k+1;
        }
        double[] b = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i=i+1)
            {
                if (array[i] < 0 && i > imin && i < imax)
                {
                    b[k] = array[i];
                    k=k+1;
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
        double max = -10000000000;
        int imax = 0;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max)
            {
                max = array[i];
                imax = i;
            }
        for (int i = 0; i < array.Length; i = i + 1)
        {
            if (array[i] == max && imax!=array.Length-1)
            {
                if (array[i + 1] >= 0) array[i + 1] = 2 * array[i + 1];
                else array[i + 1] = array[i + 1]/2;
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
        // в тестах округление везде разное. В 1 ответе получается конечное число 0.575, во втором - 0,(6), но округлено до 2-х знаков после запятой
        int imin = 0, imax = 0, k = 0 ;
        double s = 0;

        double min = 10000000000;
        for (int i = 0; i < array.Length; i = i + 1) 
            if (array[i] <= min)
            {
                min = array[i];
                imin = i;
            }
        double max = -10000000000;
        for (int i = 0; i < array.Length; i = i + 1) 
            if (array[i] >= max)
            {
                max = array[i];
                imax = i;
            }
        if (Math.Abs(imax - imin) <= 1) average = 0;
        else
        {
            if (imin < imax) for (int i = imin + 1; i < imax; i = i + 1)
                {
                    s = s + array[i];
                    k = k + 1;
                }
            else
            {
                if (imin > imax) for (int i = imax + 1; i < imin; i = i + 1)
                    {
                        s = s + array[i];
                        k = k + 1;
                    }
            }
            average = s / k;
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
        //Включить заданный элемент P после последнего положительного элемента массива.
        double poz = 0;
        int index = -1;
        double[] b = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] > 0)
            {
                poz = array[i];
                index = i;
            }
        if (index == -1) return array;
        else
        {
            for (int i = 0; i <= index; i = i + 1) b[i] = array[i];
            b[index + 1] = P;
            for (int i = index + 2; i < array.Length + 1; i = i + 1) b[i] = array[i - 2];
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
        double max = -10000000000;
        int imax = 0;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max && i%2==0)
            {
                max = array[i];
                imax = i;
            }
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] == max) array[i] = imax;
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
        double[] output=new double[A.Length+B.Length];

        // code here
        int l=0, p=k+1;
        if (k >= A.Length) return A;
        for (int i = 0; i <= k; i = i + 1)
        {
            output[i] = A[i];
        }
        for (int i = k+1; i <= k+B.Length; i = i + 1)
        {
            output[i] = B[l];
            l = l + 1;
        }
        for (int i = k + B.Length+1; i < A.Length + B.Length; i = i + 1)
        {
            output[i] = A[p];
            p = p + 1;
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
        double s = 0;
        int imin = 0, imax = 0, k = 0;
        double min = 10000000000;
        for (int i = 0; i < array.Length; i = i + 1)
            if (array[i] <= min)
            {
                min = array[i];
                imin = i;
            }
        double max = -10000000000;
        for (int i = 0; i < array.Length; i = i + 1)
            if (array[i] >= max)
            {
                max = array[i];
                imax = i;
            }
        if (imax < imin)
            for (int i = 0; i < array.Length; i = i + 1) if (array[i] > 0)
                {
                    s = s + array[i];
                    k = k + 1;
                }
        if (imax > imin)
            for (int i = 0; i < array.Length; i = i + 1) if (array[i] < 0)
                {
                    s = s + array[i];
                    k = k + 1;
                }
        if (k==0) average = 0;
        else average = s / k;

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
        double max = -10000000000, s = 0; ;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= max) max = array[i];
        for (int i = 0; i < array.Length; i = i + 1) s=s+ array[i];
        if (max>s)
        {
            for (int i = 0; i < array.Length; i = i + 1) if (array[i] == max) array[i] = 0;
        } else for (int i = 0; i < array.Length; i = i + 1) if (array[i] == max) array[i] = 2 * array[i];
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
        double max = -10000000000;
        int imax = -1;
        double t;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >max)
            {
                max = array[i];
                imax = i;
            }
        if (imax == 0 || imax == 1) return array;
        if (imax%2==0)
        {
            for (int i = 0; i < imax; i = i + 2)
            {
                t = array[i];
                array[i] = array[i + 1];
                array[i + 1] = t;
            }
        }
        if (imax % 2 != 0)
        {
            for (int i = 0; i < imax-1; i = i + 2)
            {
                t = array[i];
                array[i] = array[i + 1];
                array[i + 1] = t;
            }
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
        int count = 1, max=1;

        // code here
        for (int i = 1; i < array.Length; i = i + 1)
        {
            if (array[i] < array[i -1])
            {
                count = count + 1;
                if (count >= max) max = count;
            }
            else count = 1;
        }
        count = max;
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
        int count=0, count1 = 1, count2=1, max1 = 1, max2 = 1;

        // code here
        for (int i = 1; i < array.Length; i = i + 1)
        {
            if (array[i] < array[i - 1])
            {
                count1 = count1 + 1;
                if (count1 >= max1) max1 = count1;
            }
            else count1 = 1;
        }
        for (int i = 1; i < array.Length; i = i + 1)
        {
            if (array[i] > array[i - 1])
            {
                count2 = count2 + 1;
                if (count2 >= max2) max2 = count2;
            }
            else count2 = 1;
        }
        if (max1 > max2) count = max1;
        else count = max2;
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
        int k = 0;
        for (int i = 0; i < array.Length; i = i + 1) if (array[i] >= 0) k = k + 1;
        double[] a = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i = i + 1)
        {
            if (array[i] >=0)
            {
                a[k] = array[i];
                k = k + 1;
            }
        }
        array = a;
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
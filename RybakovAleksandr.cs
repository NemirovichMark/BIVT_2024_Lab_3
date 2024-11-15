using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
        //program.Task_1_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_1_14(new double[] { 2, 5, 3, 0, 7, 9, 1, 4, 6, 10, 8 });
        //program.Task_1_15(new double[] {0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7});
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, -0.1);
        //program.Task_2_12(new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 });
        //program.Task_3_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_5(new double[] { -1, -2, -8, -1, -9, -1, -1, -4, -6, -2 });
        //program.Task_3_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_11(1.5, 3, 4);
        program.Task_3_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
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
        double mid = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                mid += array[i];
                count++;
            }
        }
        mid = Math.Round(mid / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = mid;
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
        double mid = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
            count++;
        }
        mid = mid / count;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - mid, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; vector1.Length > i; i++)
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
        for (int i = 0; vector.Length > i; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double mid = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
            count++;
        }
        mid /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mid)
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
                count += 1;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double mid = 0, count1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
            count1++;
        }
        mid /= count1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mid)
            {
                count += 1;
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
                count += 1;
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
                output[count] = array[i];
                count++;
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
                index = i; 
                value = array[i];
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
        int i1 = 0, i2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[i1] = array[i];
                i1 += 1;
            }
            else
            {
                odd[i2] = array[i];
                i2 += 1;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0;
        while (array[i] >= 0)
        {
            sum += array[i] * array[i];
            i++;
            if (i >= 11) break;
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
            if (x[i] == 0) y[i] = double.NaN;
            else
            {
            y[i] = Math.Round(Math.Log(x[i]) * 0.5, 2);
            System.Console.WriteLine($"{y[i]}  {x[i]}");
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
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double m = 0;
        int mi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                mi = i;
            }
        }
        for (int j = 0; j < mi; j++)
        {
            sum += array[j];
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
        int mi = 0;
        double m = 0, mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                mi = i;
            }
            mid += array[i];
        }
        mid = Math.Round(mid / array.Length, 2);
        for (int j = mi + 1; j < array.Length; j++)
        {
            array[j] = mid;
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
        double mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }
        mid = mid / array.Length;
        int mj = 0;
        double d = 1000000;
        for (int j = 0; j < array.Length; j++)
        {
            if (Math.Abs(array[j] - mid) < d)
            {
                d = Math.Abs(array[j] - mid);
                mj = j;
            }
        }
        double[] array_temp = new double[array.Length + 1];
        for (int _ = 0; _ < mj + 1; _++)
        {
            array_temp[_] = array[_];
        }
        array_temp[mj + 1] = P;
        for (int c = mj + 2; c <= array.Length; c++)
        {
            array_temp[c] = array[c - 1];
        }
        array = array_temp;
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
        double max = 0, min = 1000;
        int max_i = 0, min_i = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
        }
        for (int j = max_i; j < array.Length; j++)
        {
            if (array[j] < min)
            {
                min = array[j];
                min_i = j;
            }
        }
        array[max_i] = min;
        array[min_i] = max;
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
        double min = 1000000;
        double[] array_temp = new double[array.Length - 1];
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                c++;
            }
        }
        if (c != 0)
        {
            int _ = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == min)
                {
                    continue;
                }
                array_temp[_] = array[j];
                _++;
                if (_ == array_temp.Length)
                {
                break;
                }
            }
            array = array_temp;
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
        int neg_i = 0, max_i = 0, f = 0;
        double max = -100000, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && f == 0)
            {
                f = 1;
                neg_i = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
        }
        if (f == 1)
        {for (int j = max_i + 1; j < array.Length; j++)
        {
            sum += array[j];
        }
        array[neg_i] = Math.Round(sum, 2);}
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
        int neg_i = 0, max_i = 0, f = 0;
        double max = -100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && f == 0)
            {
                f = 1;
                neg_i = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                max_i = i;
            }
        }
        if (f == 1)
        {
            array[max_i] = array[neg_i];
            array[neg_i] = max;
        }
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
        int c = 0;
        double mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }
        mid /= array.Length;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < mid)
            {
                c++;
            }
        }
        output = new int[c];
        int c1 = 0;
        for (int _ = 0; _ < array.Length; _++)
        {
            if (array[_] < mid) 
            {
                output[c1] = _;
                c1++;
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
        double max_odd = -100000, max_even = -100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max_even)
                {
                    max_even = array[i];
                }
            }
            else
            {
                if (array[i] > max_odd)
                {
                    max_odd = array[i];
                }
            }
        }
        int mid = array.Length / 2;
        if (max_even > max_odd)
        {
            for (int j = 0; j < mid; j++)
            {
                array[j] = 0;
            }
        }
        else
        {
            for (int j = mid; j < array.Length; j++)
            {
                array[j] = 0;
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

        // code here
        int neg_i = 0, f = 0, min_i = 0;
        double min = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && f == 0)
            {
                neg_i = i;
                f = 1;
            }
            if (array[i] < min)
            {
                min = array[i];
                min_i = i;
            }
        }
        if (min_i > neg_i && f == 1)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (j % 2 == 0)
                {
                    sum += array[j];
                }
            }
        }
        else if (f == 1)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (j % 2 != 0)
                {
                    sum += array[j];
                }
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
        double max = -100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        int c = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] == max)
            {
                array[j] += c;
                c++;
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
        for (int i = 2, j = 4; i < array.Length;)
        {
            if (i == 0 || array[i] >= array[i - 2])
            {
                i = j;
                j += 2;
            }
            else
            {
                double temp = array[i];
                array[i] = array[i - 2];
                array[i - 2] = temp;
                i -= 2;
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
        for (int i = 1, j = 2; i < array.Length;)
        {
            if (i == 0 || array[i] <= array[i - 1] || array[i] > 0 || array[i - 1] > 0)
            {
                i = j;
                j += 1;
            }
            else
            {
                double temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
                i -= 1;
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
        X = new double[n];
        Y = new double[n];
        double f;
        double step;
        globalMax = -10000; 
        globalMin = 10000;
        double i = a;
        step = (b - a) / (n - 1);
        for (int j = 0; Math.Abs(i) <= Math.Abs(b); i += step, j++)
        {
            X[j] = Math.Round(i, 2);
            f = Math.Round(Math.Cos(i) + i * Math.Sin(i), 2);
            Y[j] = f;
            if (j > 0)
            {
                if (j > 1)
                {if (Y[j - 1] > Y[j - 2] && Y[j - 1] > Y[j])
                {
                    if (Y[j - 1] > globalMax)
                    {
                        globalMax = Y[j - 1];
                    }
                }
                if (Y[j - 1] < Y[j - 2] && Y[j - 1] < Y[j])
                {
                    if (Y[j - 1] < globalMin)
                    {
                        globalMin = Y[j - 1];
                    }
                }
                }
                if (j == n - 1)
                {
                    if (Y[j - 1] < Y[j])
                    {
                        if (Y[j] > globalMax)
                        {
                            globalMax = Y[j];
                        }
                    }
                    if (Y[j - 1] > Y[j])
                    {
                        if (Y[j] < globalMin)
                        {
                            globalMin = Y[j];
                        }
                    }
                }
                else
                {
                    if (Y[j - 1] > Y[j])
                    {
                        if (Y[j - 1] > globalMax)
                        {
                            globalMax = Y[j - 1];
                        } 
                    }
                    if (Y[j - 1] < Y[j])
                    {
                        if (Y[j - 1] < globalMin)
                        {
                            globalMin = Y[j - 1];
                        }
                    }
                }
            }
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
        normalizedArray = new double[array.Length];
        double min = 10000, max = -10000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        for (int j = 0; j < normalizedArray.Length; j++)
        {
            normalizedArray[j] = Math.Round(-1 + 2 * (array[j] - min) / (max - min), 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
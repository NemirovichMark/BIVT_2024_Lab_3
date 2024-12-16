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
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] =Math.Round((array[i] / s), 2);
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0, sredarif = 0, j = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                j+=1;
            }
        }
        sredarif = Math.Round(sum / j, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sredarif;
            }
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] one, double[] two)
    {
        double[] plus = new double[4], min = new double[4];
        for (int i = 0; i < 4; i++)
        {
            plus[i] = Math.Round(one[i] + two[i], 2);
            min[i] = Math.Round(one[i] - two[i], 2);
        }
        // end
        return (plus, min);
    }
    public double[] Task_1_4(double[] array)
    {
        double sum = 0, sredarif = 0, j = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += array[i];
            j++;
        }
        sredarif = sum / j;
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sredarif, 2);
        }
        return array;
    }
    public double Task_1_5(double[] v1, double[] v2)
    {
        double skaliar = 0;
        for (int i = 0; i < 4; i++)
        {
            skaliar += v1[i] * v2[i];
        }
        skaliar = Math.Round(skaliar, 2);
        
        return skaliar;
    }
    public double Task_1_6(double[] v)
    {
        double dlin = 0;
        for (int i = 0; i < 5; i++)
        {
            dlin += v[i]*v[i];
        }
        dlin = Math.Sqrt(dlin);

        dlin = Math.Round(dlin, 2);
        // end
        return dlin; ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0, sredarif = 0, j = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
            j++;
        }
        sredarif = sum/j;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sredarif)            
                array[i] = 0;
        }

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        for (int i = 0; i < 6; i++)
        {
            if (array[i] < 0)            
                count ++;           
        }
        // end
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0, sredarif = 0, j = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
            j +=1;
        }
        sredarif = sum/j;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sredarif)
                count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] < Q && array[i] > P)
                count ++;          
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        for (int i = 0, count2 = 0 ; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[count2] = array[i];
                count2++;
            }
        }
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double minus_ch = 0;
        int koor = -1;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] < 0)
            {
                koor = i;
                minus_ch = array[i];
            }
        }
        return (minus_ch, koor);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        int i_1 = 0, i_2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[i_1] = array[i];
                i_1 ++;
            }
            else
            {
                odd[i_2] = array[i];
                i_2 ++;
            }
        }
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < 11; i++)
        { 
            if (array[i] < 0)
                break;
            sum += array[i] * array[i];
        }
        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[10];
        for (int i = 0; i < 10; i++)
        {
            if (x[i] == 0) 
                y[i] = double.NaN;
            else
            {
                y[i] = Math.Round(Math.Log(x[i]) * 0.5, 2);
                Console.WriteLine($"{y[i]}  {x[i]}");
            }
        }
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
        double sum = 0, max = 0;
        int max_i = 0, dlin = array.Length;
        for (int i = 0; i < dlin; i++)
        {
            if (array[i] >= max)
            {
                max_i = i;
                max = array[i];               
            }
        }
        for (int i = 0; i < max_i; i++)
        {
            sum += array[i];
        }
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
        int max_i = 0;
        double max = 0, sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max_i = i;
                max = array[i];
            }
            sr += array[i];
        }
        sr = Math.Round(sr / array.Length, 2);
        for (int i = max_i + 1; i < array.Length; i++)
        {
            array[i] = sr;
        }
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
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr /= array.Length;



        double d = 99999999;
        int elem_i = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < d)
            {
                d = Math.Abs(array[i] - sr);
                elem_i = i;
            }
        }


        double[] array2 = new double[array.Length + 1];
        for (int i = 0; i <= array.Length; i++)
        {
            if (i < elem_i + 1)
                array2[i] = array[i];
            else if (i <= elem_i + 1)
                array2[elem_i + 1] = P;
            else
                array2[i] = array[i - 1];
        }

        return array2;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double x = 0, y = 99999999;
        int x_i = 0, y_i = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > x)
            {
                x = array[i];
                x_i = i;
            }
        }
        for (int j = x_i; j < array.Length; j++)
        {
            if (array[j] < y)
            {
                y = array[j];
                y_i = j;
            }
        }
        array[y_i] = x;
        array[x_i] = y;
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
        //Console.WriteLine(string.Join("\n", array));
        double min = -1;
        int min_i = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && (array[i] < min || min < 0))
            {
                min = array[i];
                min_i = i;
            }
        }
        if (min_i == -1)
            return array;

        double[] array2 = new double[array.Length - 1];

        for (int i = 0; i < array2.Length; i++)
        {
            if (i < min_i)
                array2[i] = array[i];
            else
                array2[i] = array[i + 1];
        }
        //Console.WriteLine("/////////////////");
        //Console.WriteLine(string.Join("\n", array2));
        //Console.WriteLine("/////////////////");

        return array2;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // Первый отрицательный элемент массива заменить суммой элементов, расположенных после максимального
        double maks = -9999, sum = 0;
        int i_minus = -1, i_maks = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && i_minus == -1)
                i_minus = i;

            if (array[i] > maks)
            {
                sum = 0;
                i_maks = i;
                maks = array[i];
            }
            else
            {
                sum += array[i];
            }
        }
        //Console.WriteLine("/////////////////");
        //Console.WriteLine(string.Join("\n", array));

        if (i_minus == -1)
        {
            //Console.WriteLine("/////////////////");
            //Console.WriteLine(string.Join("\n", array));

            return array;
        }
        array[i_minus] = Math.Round(sum, 2);
        //Console.WriteLine("/////////////////");
        //Console.WriteLine(string.Join("\n", array));
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
        // Поменять местами максимальный и первый отрицательный элементы массива.
        double maks = -9999;
        int i_minus = -1, i_maks = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && i_minus == -1)
                i_minus = i;

            if (array[i] > maks)
            {
                i_maks = i;
                maks = array[i];
            }
        }
        //Console.WriteLine("/////////////////");
        //Console.WriteLine(string.Join("\n", array));

        if (i_minus == -1)
        {
            //Console.WriteLine("/////////////////");
            //Console.WriteLine(string.Join("\n", array));

            return array;
        }
        array[i_maks] = array[i_minus];
        array[i_minus] = maks;
        //Console.WriteLine("/////////////////");
        //Console.WriteLine(string.Join("\n", array));
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

        // Определить индексы элементов массива, меньших среднего. Результат получить в виде массива.
        int raz = 0;
        double mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }
        mid = mid/array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mid)
            {
                raz++;
            }
        }
        output = new int[raz];

        for (int out_count = 0, count = 0; count < array.Length; count++)
        {
            if (array[count] < mid)
            {
                output[out_count] = count;
                out_count++;
            }
        }
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
        // Если максимальный среди элементов с четными индексами больше максимального среди элементов с нечетными индексами, то заменить нулями
        // элементы первой половины массива, иначе – элементы второй половины.
        double max_odd = -9999, max_even = -9999;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                if (array[i] > max_odd)
                    max_odd = array[i];
            }
            else
                if (array[i] > max_even)
                max_even = array[i];               
        }
        int mid = array.Length / 2;
        for (int i = 0; i < array.Length; i++)
        {
            if ((max_even > max_odd && i < mid) || (max_even < max_odd && i >= mid))
                array[i] = 0;
        }
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

        //        Если 1 - й отрицательный элемент массива расположен до минимального, то
        //        найти сумму элементов с четными индексами, иначе -с нечетными индексами .

        double min = 9999;
        int i_minus = -1, i_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && i_minus == -1)
                i_minus = i;

            if (array[i] < min)
            {
                i_min = i;
                min = array[i];
            }
        }
        if ((i_minus >= i_min) || (i_minus == -1))
            for (int i = 1; i < array.Length; i+=2)
                sum += array[i];
        else
            for (int i = 0; i < array.Length; i += 2)
                sum += array[i];
        
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
        double max = -9999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        int count = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += count;
                count++;
            }
        }

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
        for (int i = 2, j = 4; i < array.Length;)
        {
            double vrem = 0;
            if (i == 0 || array[i] >= array[i - 2])
            {
                i = j;
                j += 2;
            }
            else
            {
                array[i] += array[i - 2];
                array[i - 2] = array[i]- array[i - 2];
                array[i] -= array[i - 2];
                i -= 2;
            }
        }

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
        for (int i = 1, j = 2; i < array.Length;)
        {
            if (i == 0 || array[i] <= array[i - 1] || array[i] > 0 || array[i - 1] > 0)
            {
                i = j;
                j += 1;
            }
            else
            {
                array[i] += array[i - 1];
                array[i - 1] = array[i] - array[i - 1];
                array[i] -= array[i - 1];
                i -= 1;
            }
        }

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
                {
                    if (Y[j - 1] > Y[j - 2] && Y[j - 1] > Y[j])
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
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
        double sum = 0;
        for (int i = 0; i < 6; i++) sum += array[i];
        for (int j = 0; j < 6; j++)
        {
            array[j] /= sum;
            array[j] = Math.Round(array[j], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        double count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sum / count, 2);
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        double count = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += array[i];
            count++;
        }
        for (int i = 0; i < 5; i++)
        {
            array[i] -= Math.Round(sum / count, 2);
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
        product = Math.Round(product, 2);
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
            sum += Math.Pow(vector[i], 2);
        }
        length = Math.Round(Math.Sqrt(sum), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sum / 7)
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
        double sum = 0;

        // code here      
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sum / 8)
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
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }

        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < 10; i++)
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
        double[] odd = new double[array.Length / 2];

        // code here
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[count1] = array[i];
                count1++;
            }
            else
            {
                odd[count2] = array[i];
                count2++;
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
            if (array[i] >= 0)
            {
                sum += Math.Round(Math.Pow(array[i], 2), 2);
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
        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(Math.Log(x[i]) / 2, 2);
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
        double minim = double.MaxValue;
        int elemIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minim)
            {
                minim = array[i];
                elemIndex = i;
            }
        }
        if (array[elemIndex] <= 0) array[elemIndex] /= 2;
        else array[elemIndex] *= 2;
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
        double minim = double.MaxValue;
        int elemIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minim)
            {
                minim = array[i];
                elemIndex = i;
            }
        }
        for (int i = 0; i < elemIndex; i++)
        {
            if (array[i] <= 0) array[i] /= 2;
            else array[i] *= 2;
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
        int maxIndex = 0, minIndex = 0;
        int count = 0, n = 0;
        double max = double.MinValue, min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        double[] res = new double[count];
        for (int i = minIndex + 1; i < maxIndex; i++)
        {
            if (array[i] < 0)
            {
                res[n] = array[i];
                n++;
            }
        }
        // end

        return res;
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
        int maxIndex = 0;
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                maxIndex = i;
                max = array[i];
            }
        }
        if (maxIndex + 1 < array.Length)
        {
            if (array[maxIndex + 1] < 0) array[maxIndex + 1] /= 2;
            else array[maxIndex + 1] *= 2;
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
        double s = 0;
        int count = 0;
        double max = double.MinValue, min = double.MaxValue;
        int maxIndex = 0, minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        int minIndex2 = Math.Min(maxIndex, minIndex);
        int maxIndex2 = Math.Max(minIndex, maxIndex);
        for (int i = minIndex2 + 1; i < maxIndex2; i++)
        {
            s += array[i];
            count++;
        }
        if (minIndex2 + 1 == maxIndex2) return 0;
        else average = s / count;
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
        int s = -1000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) s = i;
        }
        if (s != -1000)
        {
            double[] answer = new double[array.Length + 1];
            for (int i = 0, j = 0; i < answer.Length; i++)
            {
                if (s + 1 != i)
                {
                    answer[i] = array[j];
                    j++;
                }
                else answer[i] = P;
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
        double max = -1000;
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    s = i;
                }
            }
        }
        array[s] = s;
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
        if (k >= A.Length) return A;
        for (int i = 0; i < B.Length; i++) output[k + i + 1] = B[i];
        for (int i = k + 1; i < A.Length; i++) output[B.Length + i] = A[i];
        for (int i = 0; i <= k; i++) output[i] = A[i];
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
        int maxIndex = 0, minIndex = 0, count1 = 0, count2 = 0;
        double sum1 = 0, sum2 = 0;
        double max = double.MinValue, min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum1 += array[i];
                count1++;
            }
            if (array[i] < 0)
            {
                sum2 += array[i];
                count2++;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        if (maxIndex < minIndex)
        {
            if (count1 == 0) return 0;
            average = sum1 / count1;
        }
        if (minIndex < maxIndex)
        {
            if (count2 == 0) return 0;
            average = sum2 / count2;
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
        int k = 0;
        double max = double.MinValue, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        if (max > sum) array[k] = 0;
        if (max <= sum) array[k] = array[k] * 2;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
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
                array[i] += count + 1;
                count++;
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
        double t = 0;
        int p = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                t = array[i];
                p = i - 2;

                while (p >= 0 && array[p] > t)
                {
                    array[p + 2] = array[p];
                    p -= 2;
                }
                array[p + 2] = t;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }

        if (count <= 1) return array;

        double[] newArr = new double[count];
        int count1 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                newArr[count1] = array[i];
                count1++;
            }
        }

        for (int i = 0; i < newArr.Length - 1; i++)
        {
            for (int j = i+1; j < newArr.Length; j++)
            {
                if (newArr[i] < newArr[j])
                {
                    double promegPer = newArr[i];
                    newArr[i] = newArr[j];
                    newArr[j] = promegPer;
                }
            }
        }

        int count2 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = newArr[count2];
                count2++;
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
        double x;
        globalMax = Y[0];
        globalMin = Y[0];

        double shg = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            x = a + i * shg;
            X[i] = x;
            Y[i] = Math.Cos(x) + x * Math.Sin(x);
        }

        globalMax = Y[0];
        globalMin = Y[0];

        for (int i = 1; i < n; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];
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
        int indexmax = 0, indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[indexmax])
            {
                indexmax = i;
            }
            if (array[i] < array[indexmin])
            {
                indexmin = i;
            }
        }
        double f = 2 / (array[indexmax] - array[indexmin]);
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = (array[i] - array[indexmin]) * f - 1;
        }

        // end

        return normalizedArray;
    }
    #endregion
}
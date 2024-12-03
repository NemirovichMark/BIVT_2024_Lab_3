using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < 6; i++)
        {
            s = s + array[i];
            
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = array[i] / s;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double k = 0;
        double s = 0;
        
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                k++;
                s = s + array[i];
                
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = s / k;
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
        double s = 0;
        for (int i = 0; i < 5; i++)
        {
            s = s + array[i];
        }
        for (int i = 0; i < 5; i++)
        {
            array[i] -= s/5;
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
        for (int i = 0; i < 5; i++)
        {
            length = Math.Sqrt((vector[0] * vector[0])+ (vector[1] * vector[1])+ (vector[2] * vector[2])+ (vector[3] * vector[3])+ (vector[4] * vector[4]));
        }
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
 
        double s = 0;
        for (int i = 0; i < 7; i++)
        {
            s = s + array[i]; 
        }
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > (s / 7))
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
        double s = 0;
        for (int i = 0; i < 8; i++)
        {
            s = s + array[i];
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > (s / 8))
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
            if (array[i]> P && array[i] < Q)
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
        int cnt = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }
        int cnt2 = 0;
        output = new double[cnt];
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[cnt2] = array[i];
                cnt2++;
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
        for (int i = 7; i > 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;

            }
            if (value != 0)
            { 
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

        // code here
        int cnt = 0;
        for (int i = 0; i < 10; i += 2)
        {
            even[cnt] = array[i]; cnt++;
        }
        cnt = 0;
        for (int i = 1; i < 10; i+=2)
        {
            odd[cnt] = array[i]; cnt++;
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
        for (int i = 0; i < 10; i++)
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
        double s = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (s > array[i])
            {
                s = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == s)
            {
                if (s < 0)
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
        double s = array[0];
        double k = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (s > array[i])
            {
                s = array[i];
                k = i;
            }
        }
        for (int i = 0; i < k; i++)
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
        double max = array[0], min = array[0];
        int m = 0, n = 0, k = 0, s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                m = i;
            }
            if (min > array[i])
            {
                min = array[i];
                n = i;
            }
        }
        for (int i = Math.Min(m, n) + 1; i < Math.Max(m, n); i++)
        {
            if (array[i] < 0) k++;
        }
        double[] a = new double[k];
        for (int i = Math.Min(m, n) + 1; i < Math.Max(m, n); i++)
        {
            if (array[i] < 0)
            {
                a[s] = array[i];
                s++;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // end

        return array;
    }
 
    public double[] Task_2_7(double[] array)
    {
        // code here
        double s = array[0];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (s < array[i])
            {
                s = array[i];
                k = i;
            }
        }
        if (k == array.Length - 1)
        {
            return array;
        }
        else if (array[k + 1] > 0)
        {
            array[k + 1] *= 2;
        }
        else
        {
            array[k + 1] = array[k + 1] / 2;
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
        double min = array[0], max = array[0], s = 0;
        int k = 0, t = 0, a = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                k = i;
            }
            if (min > array[i])
            {
                min = array[i];
                t = i;
            }
        }
        for (int i = Math.Min(k, t) + 1; i < Math.Max(k, t); i++)
        {
            s += array[i];
            a++;
        }
        if (a == 0) return 0;
        average = Math.Round(s / a, 4);
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
        double s = 0;
        int t = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) t = i;
        }
        if (t == 0)
        {
            return array;
        }
        double[] a = new double[array.Length + 1];
        for (int j = 0; j < array.Length + 1; j++)
        {
            if (j < t + 1)
            {
                a[j] = array[j];
            }
            else if (j == t + 1)
            {
                a[j] = P;
            }
            else
            {
                a[j] = array[j - 1];
            }
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
        double k = array[0];
        int s = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (k < array[i])
            {
                k = array[i];
                s = i;
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
        int s = 0;
        output = new double[A.Length + B.Length];
        if (k >= A.Length)
        {
            return A;
        }
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        
        for (int i = k + 1; i < B.Length + k + 1; i++)
        {
            output[i] = B[s];
            s++;
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
        int s = 0, k = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                s = i;
            }
            if (max < array[i])
            {
                max = array[i];
                k = i;
            }
        }
        double psum = 0, osum = 0;
        int indexp = 0, indexo = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                psum += array[i];
                indexp++;
            }
            else if (array[i] < 0)
            {
                osum += array[i];
                indexo++;
            }
        }
        if (k < s)
        {
            average = psum / indexp;
        }
        else if (s < k)
        {
            average = osum / indexo;
            if (indexo == 0)
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
        double a = 0;
        double d = array[0];
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (d < array[i])
            {
                d = array[i];
                m = i;
            }
            a += array[i];
        }
        if (array[m] > a) array[m] = 0;
        else array[m] *= 2;
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
        int[] sun = new int[array.Length];
        int b = 0;
        double k = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > k)
            {
                k = array[i];
                b = 0;
            }
            if (array[i] == k)
            {
                sun[b] = i;
                b++;
            }
        }
        int[] bit = new int[b];
        for (int i = 0; i < b; i++)
        {
            bit[i] = sun[i];
            output = bit;
        }
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
        
        // end

        return array;
    }
    public double[] Task_3_4(double[] array)
    {
        // code here
        double a = array[0], s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > a)
            {
                a = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == a)
            {
                array[i] = s;
                s += a;
            }
            else
            {
                s += array[i];
            }
        }
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

        // code here

        // end

        return count;
    }
    public double[] Task_3_7(double[] array)
    {
        // code here
        int a = 0;
        double[] sky = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sky[a] = array[i];
                a++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                sky[a] = array[i];
                a++;
            }
        }
        array = sky;
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

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here
        int a = 0;
        double[] tomato = new double[array.Length];
        double k = array.Length / 2;
        for (int i = 0; i < k; i++)
        {
            tomato[a] = array[i];
            tomato[a + 1] = array[i];
            a += 2;
        }
        array = tomato;
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

        // end

        return array;
    }
    public double[] Task_3_13(double[] array)
    {
        // code here
        int g = 0, s = 0;
        for (int i = array.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    array[j] = 999999;
                    g++;
                }
            }
        }
        double[] apple = new double[array.Length - g];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 999999)
            {
                apple[i - s] = array[i];
            }
            else
            {
                s++;
            }
        }
        array = apple;
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
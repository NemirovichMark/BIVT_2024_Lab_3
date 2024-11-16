using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.Serialization.Formatters;
using System.Timers;
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
            array[i] =Math.Round(array[i]/ s,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        
        double sp = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sp += array[i];
                k++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] =Math.Round( (sp / k),2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        sr = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]- sr,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        product=Math.Round(product,2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int i = 0; i < vector.Length; i++)
        {
            length += vector[i]* vector[i];
        }
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr/=array.Length;
        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr/=array.Length;
        for(int i = 0; i < array.Length; i ++)
        {
            if (array[i] > sr) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0) k++;
        }
        output = new double[k];
        k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) output[k++] = array[i];
        }


        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for(int i = array.Length - 1; i >= 0; i--)
        {
            if(array[i] < 0)
            {
                value = array[i];
                index = i;
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
        int k = 0, c = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
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
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum+= array[i] * array[i];
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
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            else y[i] = double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int imin = 0;
        double min = 1000000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        if (array[imin]<0) array[imin] = min/2;
        else array[imin] = min*2;
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
        int imin = 0;
        double min = 1000000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        for(int i = 0; i < imin; i++)
        {
            if(array[i]>=0) array[i] *= 2;
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
        int imax = 0, imin = 0, k = 0;
        double max = 0, min = 10000000;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        if (imin > imax)
        {
            var p = imin;
            imin = imax;
            imax = p;
        }
        for(int i = imin+1; i < imax; i++)
        {
            if (array[i] < 0) k++;
        }
        double[]b=new double[k];
        k = 0;
        for(int i = imin+1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                b[k] = array[i];
                k++;
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
        int imax = 0;
        double max = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max= array[i];
                imax = i;
            }
        }
        if(imax + 1 < array.Length && array[imax + 1] >= 0) array[imax + 1] *= 2;
        else if( imax + 1 < array.Length && array[imax + 1] <= 0) array[imax + 1] /= 2;
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
        int imax = 0, imin = 0, k = 0;
        double max = 0, min = 10000000, sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        if (imin > imax)
        {
            var p = imin;
            imin = imax;
            imax = p;
        }
        for (int i = imin + 1; i < imax; i++)
        {
            k++;
            sr += array[i];
        }
        
        average = sr / k;
        if (imin + 1 == imax) average = 0;
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
        int index = 0, k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) k++;
        }
        if(k==0) return array;
        for(int i = array.Length - 1; i >= 0; i--)
        {
            if(array[i] > 0)
            {
                index = i;
                break;
            }
        }
        if (index + 1 >= array.Length)
        {
            double[] b = new double[index + 2];
            for(int i = 0; i < b.Length; i++)
            {
                if (i < array.Length) b[i] = array[i];
                else if (i == array.Length) b[i] = P;
            }
            array = b;
        }
        else array[index + 1] = P; 
        

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
        int imax = 0;
        double max = 0;
        for(int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                imax = i;
                max = array[i];
            }
        }
        array[imax] = imax;
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
        int n = A.Length, m = B.Length, c = 0, d = k + 1;
        output = new double[m + n];
        if (k >= n)
        {
            output = A;
            return output;
        }
        for (int i = 0; i < output.Length; i++)
        {
            if (i <= k) output[i] = A[i];
            else if (i <= k + m && c < m)
            {
                output[i] = B[c];
                c += 1;
            }
            else if (i > k + m && d < n)
            {
                output[i] = A[d];
                d++;
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
        double average = 0;

        // code here
        int imax = 0, imin = 0, k = 0, c = 0;
        double max = 0, min = 10000000, pol = 0, otr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                imin = i;
                min = array[i];
        
            }
            if (array[i] > max)
            {
                imax = i;
                max = array[i];
            }
            if (array[i] < 0)
            {
                otr += array[i];
                c++;
            }
            if (array[i] > 0)
            {
                pol += array[i];
                k++;
            }
        }

        if (imax < imin && k > 0)
        {
            average = pol / k;
        }
        //else if (k == 0) return 0; ;
        if (imin < imax && c > 0)
        {
            average = otr / c;
        }
        //else if (c == 0) return 0;


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
        int imax = 0;
        double max = -10000000, s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }
        if (max > s) array[imax] = 0;
        else
        {
            array[imax] *= 2;
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
        int imax = 0, k = 0;
        double max = -100000;

        for(int i = 0; i < array.Length; i++)
        {
            
            if (array[i]>max)
            {
                imax = i;
                max = array[i];
                k = 1;
            }
            else if (array[i] == max)
            {
                k++;
            }
        }
        output = new int[k];
        k = 0;
        for (int i = imax; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                output[k] = i;
                k++;
            }
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
        double max = -100000, s = 0;
        //for(int i = 0; i < array.Length; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //    }
        //}
        //for(int i = 0; i < array.Length; i++)
        //{
        //    s += array[i];
        //    if (array[i] == max)
        //    {
        //        array[i] = s - array[i];
        //    }

        //}

        // 2ой вариант (один проход по массиву)
        double s1 = 0; 
        int imax1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > max)
            {
                max = array[i];
                imax1 = i;
                s1 = s - array[i];
            }
            else if (array[i] == max)
            {
                array[i] = s - array[i];
            }
        }
        array[imax1] = s1;
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
        int k = array.Length;
        for(int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0) 
            {
                k--;
                var p = array[i];
                array[i] = array[k];
                array[k] = p;
            }
        }
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
        int k = array.Length - 1;
        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            array[k] = array[i];
            array[i] = 0;
            array[k - 1] = array[k];
            k -= 2;
        }
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
        int k = 0, fl = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    k++;
                    break;
                }
            }
        }
        double[] array1 = new double[array.Length - k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            fl = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                if (array[i] == array[j])
                {
                    fl += 1;
                    break;
                }
            }
            if (fl == 0)
            {
                array1[k] = array[i];
                k++;
            }
        }

        array = array1;
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
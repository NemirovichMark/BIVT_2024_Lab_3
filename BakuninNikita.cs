using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        if (sum != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] /= sum;
                array[i] = Math.Round(array[i],2);
            }
        }
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        int cnt = 0;
        for (int i = 0;i < array.Length;i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                cnt++;
            }
        }
        double avg = 0;
        if (cnt > 0)
        {
            avg = Math.Round(sum / cnt, 2);
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > 0)
                    array[j] = avg;
            }
        }
       
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; i++)
            {
                sum[i] = Math.Round(first[i] + second[i],2);
                dif[i] = Math.Round(first[i] - second[i],2);
            }
        }
        
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sum = 0;
        int cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        double avg = Math.Round(sum / cnt,2);
        for (int j = 0;j < array.Length; j++)
        {
            array[j] = Math.Round(array[j] - avg,2);
        }
        
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        if (vector1.Length == vector2.Length && vector1.Length == 4)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                product += vector1[i] * vector2[i];
            }
        }
        product = Math.Round(product,2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double sum = 0;
        for (int i = 0;i < vector.Length;i++)
        {
            sum += (vector[i] * vector[i]);
        }
        length = Math.Sqrt(sum);
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        int cnt = 0;
        for (int i = 0;i < 7;i++)
        {
            sum += array[i];
            cnt++;
        }
        double avg = sum / cnt;
        for (int j = 0; j < 7; j++)
        {
            if (array[j] > avg)
                array[j] = 0;
        }
       
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] < 0)
                cnt++;
        }

        return cnt;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0;
        int cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        double avg = sum / cnt;
        for (int j = 0;j < array.Length;j++)
        {
            if (array[j] > avg)
                count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        foreach (double x in array)
        {
            if (x > P && x < Q)
                count++;
        }

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = new double[10];
        int cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[cnt] = array[i];
                cnt++;
            }
        }

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
                even[i / 2] = array[i];
            else
                odd[(i-1)/2] = array[i];
        }

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        bool Negative = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (!Negative)
            {
                if (array[i] < 0)
                    Negative = true;
                else
                    sum += array[i] * array[i]; 
            }
            else
                break; 
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0;i < x.Length; i++)
        {
            if (x[i] > 0)
            {
                y[i] = Math.Round(0.5 * (Math.Log(x[i])),2);
            }
                
            else
            {
                y[i] = double.NaN;
            }
                
        }

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min = double.MaxValue;
        for (int i = 0;i < array.Length;i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        for (int j = 0;j < array.Length; j++)
        {
            if (array[j] == min)
            {
                array[j] *= 2;
                break;
            }
        }

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
        double min = double.MaxValue;
        int minindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minindex = i;
            }     
        }
        for (int j = 0; j < minindex; j++)
        {
            if (array[j] > 0)
            {
                array[j] *= 2;
            }
            else
                array[j] /= 2;

        }

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
        double min = double.MaxValue;
        int minindex = 0;
        double max = double.MinValue;
        int maxindex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minindex = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            }
        }
        int start = 0;
        int end = 0;
        if (minindex < maxindex)
        {
            start = minindex + 1;
            end = maxindex;
        }
        else if (maxindex < minindex)
        {
            start = maxindex + 1;
            end = minindex;
        }
           
        int cnt = 0;
        for (int i = start;i < end; i++)
        {
            if (array[i] < 0)
                cnt++;
        }
        double[] res = new double[cnt];
        int j = 0;
        for (int i = start;i < end; i++)
        {
            if (array[i] < 0)
            {
                res[j] = array[i];
                j++;
            }

        }

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
        double max = double.MinValue;
        int maxindex = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxindex = i;
            } 
        }
        if (maxindex < array.Length - 1)
        {
            if (array[maxindex + 1] > 0)
                array[maxindex + 1] *= 2;
            else
                array[maxindex + 1] /= 2;
        }
        
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

        double min = double.MaxValue;
        int minIndex = -1;
        double max = double.MinValue;
        int maxIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);

        double sum = 0;
        int cnt = 0;
        for (int i = start + 1; i < end; i++)
        {
            sum += array[i];
            cnt++;
        }
        if (cnt == 0)
            return 0.0;
        average = Math.Round(sum / cnt,2);
        
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
        int last = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                last = i;
        }

        double[] res = new double[array.Length + 1];

        if (last == -1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                res[i] = array[i];
            }
            res[res.Length - 1] = P;
        }
        else
        {
            for (int j = 0; j <= last; j++)
            {
                res[j] = array[j];
            }
            res[last + 1] = P;
            for (int i = last + 1; i < array.Length; i++)
            {
                res[i + 1] = array[i];
            }
        }

        return res;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        double max = double.MinValue;
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        array[maxIndex] = maxIndex;


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
        if (k >= A.Length)
            return A;
        output = new double[A.Length + B.Length];
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = k + 1; i < k + 1 + B.Length; i++)
        {
            output[i] = B[i - k - 1];
        }
        for (int i = k + 1 + B.Length; i < A.Length + B.Length; i++)
        {
            output[i] = A[i - B.Length];
        }

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
        double avg = 0;
        double max = double.MinValue;
        int maxIndex = 0;
        double min = double.MaxValue;
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        if (maxIndex < minIndex)
        {
            int cntPos = 0;
            double sumPos = 0;

            foreach (double x in array)
            {
                if (x > 0)
                {
                    sumPos += x;
                    cntPos++;
                }
            }
            avg = Math.Round(sumPos / cntPos,2);

        }     
        else
        {
            int cntNeg = 0;
            double sumNeg = 0;
            foreach (double x in array)
            {
                if (x < 0)
                {
                    sumNeg += x;
                    cntNeg++;
                }
            }
            if (cntNeg == 0)
                return 0.0;
            avg = Math.Round(sumNeg / cntNeg,2);
        }
  
        return avg;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        double max = double.MinValue;
        int maxIndex = 0;
        double sum = 0;
        for (int i = 0;i < array.Length ;i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        if (max > sum)
            array[maxIndex] = 0;
        else
            array[maxIndex] *= 2;

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
        double max = double.MinValue;
        int Ind = 0;
        int cnt = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] == max)
                cnt++;
        }
        int[] output = new int[cnt];
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] == max)
            {
                output[Ind] = i;
                Ind++;
            }
        }

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
        double max = array[0];
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (max <= array[i]) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (max == array[i])
            {
                double sum = 0;
                for (int j = 0; j < i; j++) sum += array[j];
                a[i] = sum;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (max == array[i]) array[i] = a[i];
        }
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
        int Ind = 0;
        double[] res = new double[array.Length];
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                res[Ind] = array[i];
                Ind++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                res[Ind] = array[i];
                Ind++;
            }
        }

        return res;
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
        double[] res = new double[array.Length];
        int Ind = 0;
        for (int i = 0;i < array.Length/2; i++)
        {
            res[Ind++] = array[i];
            res[Ind++] = array[i];
        }
        return res;
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

        double[] res = new double[array.Length];
        int Ind = 0;
        for (int i = 0;i < array.Length; i++)
        {
            bool duplicat = false;
            for (int j = 0;j < Ind; j++)
            {
                if (res[j] == array[i])
                    duplicat = true;
            }
            if (!duplicat)
                res[Ind++] = array[i];
        }
        double[] RES = new double[Ind];
        for (int i = 0;i < Ind; i++)
        {
            RES[i] = res[i];
        }

        return RES;
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
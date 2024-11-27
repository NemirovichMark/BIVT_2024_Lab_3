using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
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
        double summ = 0;
        foreach(double el in array)
        {
            summ += el;
            
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / summ;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        int count = 0;
        foreach (double el in array)
        {
            if (el > 0)
            {
                summ += el;
                count++;
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = summ / count;
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summ = 0;
        foreach (double el in array)
        {
            summ += el;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - summ / array.Length;
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double[] num = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i ++)
        {
            num[i] = vector1[i] * vector2[i];
        }
        product = num[0] + num[1] + num[2] + num[3];
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double summ = 0;
        foreach (double el in vector)
        {
            summ += el*el;
        }
        length = Math.Sqrt(summ);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summ = 0;
        foreach(double el in array)
        {
            summ += el;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > summ / array.Length) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach(double el in array)
        {
            if (el < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double summ = 0;
        foreach(double el in array)
        {
            summ += el;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > summ / array.Length) count++;
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double el in array)
        {
            if ((el > P) && (el < Q)) count++;
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
        int count1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count1] = array[i];
                count1++;
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
        int count1 = 0, count2 = 0;
        for (int i = 0; i < array.Length; i ++)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
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
        for (int i = 0; i < x.Length; i++)
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[index])
            {
                index = i;
            }
        }
        if (array[index] < 0) array[index] /= 2;
        if (array[index] > 0) array[index] *= 2;
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
        int index = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[index])
            {
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] < 0) array[i] /= 2;
            else if (array[i] > 0) array[i] *= 2;
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
        int minindex = 0, maxindex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minindex])
            {
                minindex = i;
            }
            if (array[i] > array[maxindex])
            {
                maxindex = i;
            }
        }
        if (minindex > maxindex)
        {
            int temp = minindex;
            minindex = maxindex;
            maxindex = temp;
        }
        int count = 0;
        for (int i = minindex+1; i < maxindex; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        double[] array2 = new double[count];
        int index = 0;
        for (int i = minindex + 1; i < maxindex; i++)
        {
            if (array[i] < 0)
            {
                array2[index] = array[i];
                index++;
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
        int maxindex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxindex])
            {
                maxindex = i;
            }
        }
        if (maxindex >= 0 && maxindex < array.Length - 1)
        {
            if (array[maxindex + 1] < 0) array[maxindex + 1] /= 2;
            else if (array[maxindex + 1] > 0) array[maxindex + 1] *= 2;
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
        int minindex = 0, maxindex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minindex])
            {
                minindex = i;
            }
            if (array[i] > array[maxindex])
            {
                maxindex = i;
            }
        }
        if (minindex > maxindex)
        {
            int temp = minindex;
            minindex = maxindex;
            maxindex = temp;
        }
        int count = 0;
        double summ = 0;
        for (int i = minindex + 1; i < maxindex; i++)
        {
            if ((i > minindex) && (i < maxindex))
            {
                summ += array[i];
                count++;
            }
        }
        if (count > 0) average = summ / count;
        else average = 0;
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
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) index = i;
        }
        double[] array2 = new double[array.Length + 1];
        if (index != -1)
        {
            for (int i = 0; i <= index; i++)
            {
                array2[i] = array[i];
            }
            array2[index + 1] = P;
            for (int i = index + 1; i < array.Length; i++)
            {
                array2[i + 1] = array[i];
            }
        }
        else return array;
        // end

        return array2;
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
        int index = -1;
        double maxznach = int.MinValue;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxznach)
            {
                index = i;
                maxznach = array[i]; 
            }
        }
        if (index != -1) array[index] = index;
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
        if (k < 0 || k >= A.Length)
        {
            output = new double[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                output[i] = A[i];
            }
        }
        else
        {
            output = new double[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[k + 1 + i] = B[i];
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[i + B.Length] = A[i];
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
        double summpositive = 0, summnegative = 0;
        int maxindex = 0, minindex = 0, count1 = 0, count2 = 0;
        double maxel = array[0];
        double minel = array[0];
        if (array.Length == 0) return 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                maxindex = i;
            }
            if (array[i] < minel)
            {
                minel = array[i];
                minindex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                summpositive += array[i];
                count1++;
            }
            else if (array[i] < 0)
            {
                summnegative += array[i];
                count2++;
            }
        }
        if (maxindex < minindex)
        {
            average = count1 > 0 ? summpositive / count1 : 0; 
        }
        else
        {
            average = count2 > 0 ? summnegative / count2 : 0; 
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
        if (array.Length == 0) return array;
        double maxel = array[0], summ = maxel;
        int maxindex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            summ += array[i];
            if (array[i] > maxel)
            {
                maxel = array[i];
                maxindex = i;
            }
        }
        if (maxel > summ)
        {
            array[maxindex] = 0;
        }
        else
        {
            if (maxel > 0) array[maxindex] *= 2;
            else array[maxindex] /= 2;
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
        if (array.Length == 0) return new int[0];
        double maxel = array[0];
        int count = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                count = 1;
            }
            else if (array[i] == maxel)
            {
                count++;
            }
        }
        output = new int[count]; 
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxel)
            {
                output[index] = i; 
                index++; 
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
        if (array.Length == 0) return array;
        double maxel = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
            }
        }
        double summ = -maxel;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxel)
            {
                summ += array[i];
                array[i] = summ;
            }
            else
            {
                summ += array[i];
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
        if (array.Length == 0) return array;
        int count = 0; //счетчик положителых элементов
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                count++;
            }
        }
        double[] array2 = new double[array.Length];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array2[index++] = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array2[index++] = array[i];
            }
        }
        // end

        return array2;
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
        if (array.Length == 0) return array;
        double[] array2 = new double[array.Length];
        for (int i = 0; i < array.Length/2; i++)
        {
            array2[i * 2] = array[i];
            array2[i * 2 + 1] = array[i];
        }
        // end

        return array2;
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
        if (array.Length == 0) return array;
        double[] array2 = new double[array.Length];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool duplicate = false;
            for (int j = 0; j < index; j++)
            {
                if (array[i] == array2[j])
                {
                    duplicate = true;
                    break;
                }
            }
            if (!duplicate)
            {
                array2[index] = array[i];
                index++;
            }
        }
        double[] array3 = new double[index];
        for (int i = 0; i < index; i++)
        {
            array3[i] = array2[i];
        }
        // end

        return array3;
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
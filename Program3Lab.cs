using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i ++)
        {
            if (sum != 0)
            {
                array[i] = Math.Round(array[i]/sum, 2);
            }
            else 
            {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double posSch = 0;
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                posSch ++;
                sr += array[i];
            }
        }
        if (posSch > 0)
        { 
            sr = Math.Round(sr/posSch, 2);
        }
        else
        {
            sr = 0;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i ++)
        {
            sum[i] = Math.Round(first[i]+ second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum/array.Length, 2);
        for (int i = 0; i < array.Length; i ++)
        {
            array[i] = Math.Round(array[i] - sum, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i ++)
        {
            product += vector1[i]*vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i ++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr/array.Length,2);
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > sr)
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
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                count ++;
            }
        }

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr/array.Length, 2);
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > sr)
            {
                count ++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > P && array[i] < Q)
            {
                count ++;
            }
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        // code here
        int sch = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0)
            {
                sch ++;
            }
        }
        output = new double[sch];
        int outSch = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0)
            {
                output[outSch] = array[i];
                outSch ++;
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
        for (int i = 0; i < array.Length; i ++)
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
        int evenSch = 0, oddSch = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (i % 2 == 0)
            {
                even[evenSch] += array[i];
                evenSch ++;
            }
            else
            {
                odd[oddSch] += array[i];
                oddSch ++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] >= 0)
            {
                sum += array[i]*array[i];
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
        for (int i = 0; i < x.Length; i ++)
        {
            if (0.5 * Math.Log(x[i]) < 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5*Math.Log(x[i]), 2);
            }
        }
        for (int i = 0; i < x.Length; i ++)
        {
            Console.WriteLine($"{x[i] + y[i]}");
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }

        }
        if (array[index] < 0)
            array[index] /= 2;
        else if (array[index] > 0)
        {
            array[index] *= 2;
        }
        Console.WriteLine(array);
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
        double min = 1000*1000;
        int indexMin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexMin = i;
            }
        }
        for (int i = 0;i < indexMin; i++)
        {
            if (array[i] < 0)
            {
                array[i] /= 2;
            }
            else if (array[i] > 0)
            {
                array[i] *= 2;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double max = -10000*1000;
        int indexMax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr/array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (i > indexMax)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double max = -10000*10000, min = 10000*10000;
        int indexMax = -1, indexMin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexMin = i;
            }
            else if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        int indexStart = Math.Min(indexMax, indexMin);
        int indexEnd = Math.Max(indexMax, indexMin);
        int schNeg = 0;
        for (int i = indexStart + 1; i < indexEnd; i++)
        {
            if (array[i] < 0)
            {
                schNeg ++;
            }
        }
        double[] newArray = new double [schNeg];
        int indexNewArray = 0;
        for (int i = indexStart + 1; i < indexEnd; i++)
        {
            if (array[i] < 0)
            {
                newArray[indexNewArray] = array[i];
                indexNewArray ++;
            }
        }
        // end

        return newArray;
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
        int indexMax = -1;
        double max = -1000*1000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        if (indexMax == array.Length - 1)
        {
            return array;
        }
        else if (array[indexMax + 1] < 0)
        {
            array[indexMax + 1] /= 2;
        }
        else if (array[indexMax + 1] > 0)
        {
            array[indexMax + 1] *= 2;
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
        double max = -10000*10000, min = 10000*10000;
        int indexMax = -1, indexMin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexMin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        int indexStart = Math.Min(indexMax, indexMin);
        int indexEnd = Math.Max(indexMax, indexMin);
        int schMinMax = 0;
        double sum = 0;
        for (int i = indexStart + 1; i < indexEnd; i++)
        {
            schMinMax ++;
            sum += array[i];
            
        }
        if (indexStart + 1 == indexEnd)
        {
            return 0;
        }
        else 
        {
            average = sum / schMinMax;
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
        int indexPos = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                indexPos = i;
            }
        }
        if (indexPos == (-1))
        {
            return array;
        }
        double[] newArray = new double[array.Length + 1];
        for (int i = 0; i < newArray.Length; i ++)
        {
            if (i == indexPos + 1)
            {
                newArray[i] = P;
            }
            else if (i < indexPos + 1)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = array[i - 1];
            }
        }
        // end

        return newArray;
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
        int indexChet = 0;
        double max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > max)
            {
                indexChet = i;
                max = array[i];
            }
        }
        array[indexChet] = indexChet;

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
        double[] output = new double[A.Length+B.Length];
        if (k >= A.Length) return A;
        // code here
        for (int i = 0; i <=k; i++)
        {
            output[i] = A[i];
        }
        for (int i = k+1; i<k+1+B.Length; i++)
        {
            output[i] = B[i - k - 1];
        }
        for (int i = k+1+B.Length; i< A.Length + B.Length; i++)
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
        int indexMin = 0, indexMax = 0;
        double max = -1000*1000, min = 1000*1000;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                indexMin = i;
            }
        }
        int sch = 0;
        double sum = 0;
        if (indexMax > indexMin)
        {
            for (int counter = 0; counter < array.Length; counter ++)
            {
                if (array[counter] < 0)
                {
                    sch ++;
                    sum += array[counter];
                }
            }
        }
        else if (indexMax < indexMin)
        {
            for (int counter = 0; counter < array.Length; counter ++)
            {
                if (array[counter] > 0)
                {
                    sch ++;
                    sum += array[counter];
                }
            }
        }
        if (sch == 0)
        {
            return 0;
        }
        average = sum / sch;
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
        double max = -1000*1000;
        int indexMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexMax = i;
            }
        }
        double sum = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
        }
        if (sum > max)
        {
            array[indexMax] = max * 2;
        }
        else 
        {
            array[indexMax]= 0;
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
        int[] newArray = new int[array.Length];
        int k = 0;
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = 0;
            }
            if (array[i] == max)
            {
                newArray[k] = i;
                k++;
            }
            
               
        }
        int[] b = new int[k];
        for (int i = 0; i < k; i++)
        {
            b[i] = newArray[i];
        }
        // end
        return b;
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
        double max = -10000*10000;
        double sum = 0;
        double[] newArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i ++)
        {
            newArray[i] = array[i];
        }
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] == max)
            {
                for (int k = 0; k < i; k ++)
                {
                    sum += newArray[k];
                }
                array[i] = sum;
            } 
            sum = 0;
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
        double[] newArray = new double[array.Length];
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                newArray[counter] = array[i];
                counter++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                newArray[counter] = array[i];
                counter++;
            }
        }
        // end

        return newArray;
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
        double[] newArray = new double[array.Length];
        int counter = 0;
        for (int i = 0; i < array.Length/2; i++)
        {
            newArray[counter] = array[i];
            counter += 1;
            newArray[counter] = array[i];
            counter += 1;
        }

        // end

        return newArray;
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
        int indexUniq = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (j = 0; j < indexUniq; j++)
            {
                if (array[i] == array[j])
                {
                    break;
                }
            }
            if (j == indexUniq)
            {
                array[indexUniq] = array[i];
                indexUniq ++;
            }
        }
        double[] newArray = new double[indexUniq];
        for(int i = 0; i < indexUniq; i++)
        {
            newArray[i] = array[i];
        }

        // end

        return newArray;
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
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.IO.Compression;
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
        double summ = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
            summ += array[i];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= summ;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double average = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                average += array[i];
                count++;
            }
        }
        average /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(average, 2);
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
        double average = 0;
        for (int i = 0; i < array.Length; i++) average += array[i];
        average /= array.Length;
        for (int i = 0; i < array.Length; i++) 
        {
            array[i] -= average;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++) product += vector1[i] * vector2[i];
        // end

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++) length += vector[i]*vector[i];
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) average += array[i];
        average /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average) array[i] = 0;
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
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) average += array[i];
        average /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > average) count++;
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
            if (array[i] > P && array[i] < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
            }
        }
        System.Console.WriteLine(output[0]);
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
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[i/2] = array[i];
            else odd[i/2] = array[i];
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
            if (array[i] >= 0) sum += array[i]*array[i];
            else break;
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
            if (x[i] <= 0) y[i] = double.NaN;
            else
            {
                y[i] = Math.Round(0.5*Math.Log(x[i], Math.E), 2);
                Console.WriteLine($"{x, 5} {y, 5}");
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
        double min = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (min == array[i] && min > 0) array[i] *= 2;
            else if (min == array[i] && min < 0) array[i] /= 2;
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
        double min = array[0];
        int index = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        for(int i = 0; i < array.Length; i++)
        {
            if (i < index && array[i] > 0) array[i] *= 2;
            else if (i < index && array[i] < 0) array[i] /= 2;
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
        double max = 0, min = array[0]; 
        int indexmin = 0, indexmax = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                indexmin = i;
                min = array[i];
            }
            if (array[i] > max)
            {
                indexmax = i;
                max = array[i];
            }
        }
        if (indexmin > indexmax)
        {
            int temp = indexmin;
            indexmin = indexmax;
            indexmax = temp;
        }
        for (int i = indexmin+1; i < indexmax; i++)
        {
            if(array[i] < 0) count++;
        }
        double[] array1 = new double [count];
        for (int i = indexmin + 1; i < indexmax; i++)
        {
            if(array[i] < 0) array1[i - indexmin - 1] = array[i];
        }
        array = array1;
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
        double max = 0, min = array[0]; 
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                index = i;
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i > index && array[i] > 0) 
            {
                array[i] *= 2;
                break;
            }
            else if (i > index && array[i] < 0) 
            {
                array[i] /= 2;
                break;
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
        double max = 0, min = array[0]; 
        int indexmin = 0, indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                indexmin = i;
                min = array[i];
            }
            if (array[i] > max)
            {
                indexmax = i;
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if ((i > indexmin && i < indexmax) || (i > indexmax && i < indexmin)) average += array[i];
        }
        //(Math.Abs(indexmax - indexmin) - 1) – кол-во эл-тов
        if ((Math.Abs(indexmax - indexmin) - 1) == 0) average = 0;
        else average = average/(Math.Abs(indexmax - indexmin) - 1);
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
        double[] array1 = new double [array.Length + 1];
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) index = i;
        }
        if (index == -1) return array;
        index++;
        for (int i = 0; i < array1.Length; i++)
        {
            if (i < index) array1[i] = array[i];
            else if (i == index) array1[i] = P;
            else array1[i] = array[i-1];
        }
        array = array1;
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
        double max = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max) 
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (i == index) array[i] = index/1.0;
        }
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
        // code here
        int index = 0;
        if (k<0) k = 0;
        k++;
        if (k >= A.Length) return A;
        double[] output = new double[A.Length + B.Length];
        for(int i = 0; i < output.Length; i++)
        {
            if (i < k) output[i] = A[i];
            else if (i < k+B.Length) 
            {
                output[i] = B[index];
                index++;
            }
            else output[i] = A[i-B.Length];
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
        double max = array[0], min = array[0];
        int indexmax = 0, indexmin = 0, count1 = 0, count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) 
            {
                max = array[i];
                indexmax = i;
            }
            if (array[i] < min) 
            {
                min = array[i];
                indexmin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (indexmax < indexmin && array[i] > 0) 
            {
                average += array[i];
                count1++;
            }
            else if (indexmax > indexmin && array[i] < 0) 
            {
                average += array[i];
                count2++;
            }
        }
        if (count1 != 0) average /= count1;
        else if (count2 != 0) average /= count2;
        else average = 0;
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
        double max = array[0], summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max && array[i] > summ) array[i] = 0;
            else if (array[i] == max) array[i] *= 2;
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
        double max = double.MinValue;
        int count = 0;
        int[] array1 = new int [array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                count++;
                array1[count] = i;
            }
            if (array[i] > max) 
            {
                max = array[i];
                count = 0;
                array1[count] = i;
            }
        }
        output = new int[count+1];
        for (int i = 0; i < output.Length; i++) output[i] = array1[i];
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
        double max = double.MinValue, summ = 0, temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                temp = array[i];
                array[i] = summ;
                summ += temp;
            }
            else summ += array[i];
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

        int count = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0) 
            {
                for (int j = i; j < array.Length - count - 1; j++)
                {
                    double temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
                count++;
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
        double[] array1 = new double[array.Length];
        for (int i = 0; i < array1.Length/2; i++)
        {
            array1[2*i] = array[i];
            array1[2*i + 1] = array[i];
        }
        array = array1;
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
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int j = 0;
            for (j = 0; j < index; j++)
            {
                if (array[i] == array[j]) break;
            }
            if (j == index)
            {
                array[index] = array[i];
                index++;
            }
        }
        double[] array1 = new double[index];
        for(int i = 0; i < index; i++)
        {
            array1[i] = array[i];
        }
        array = new double[array1.Length];
        for(int i = 0; i < index; i++)
        {
            array[i] = array1[i];
        }
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

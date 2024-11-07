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
        //program.Task_1_1(new int[] { 1, 2, 3, 4, 5, 6 });
        program.Task_2_16(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        foreach (var n in array) { sum += n; } // compute sum

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array) 
    {
        // code here
        double amount = 0, average = 0;

        foreach (double n in array) 
        {
            if (n > 0) { average += n; amount++; } // compute sum and amount of positive elements
        }
        average = Math.Round(average / amount, 2);

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (array[i] > 0) ? average : array[i]; 
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
        foreach (var n in array) { average += n / array.Length; }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - average, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++)
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
        foreach (double n in vector) { length += n*n; }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double average = 0;
        foreach (var n in array) { average += n / array.Length; }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (array[i] > average) ? 0 : array[i];
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double n in array) { if (n < 0) count++; }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double average = 0;
        foreach (var n in array) { average += n / array.Length; }

        foreach (var n in array) { if (n > average) count++; }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double n in array)
        {
            if (n>P && n<Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int amount = 0;
        foreach (var n in array) { if (n>0) amount++; }

        if (amount > 0)
        {
            output = new double[amount];
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { output[k] = array[i]; k++; }
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
        index += array.Length;
        for (; index>=0; index--)
        {
            if (array[index] < 0) {  value = array[index]; break; }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code 
        int i=0, k=0;
        foreach (double n in array) // iterate through original array
        {
            if (k%2!=0) { odd[i] = n; i++; } // when original array index is odd, we increment the even/odd array's index
            else even[i] = n;
            k++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double n in array)
        {
            if (n < 0) break;
            else sum += n * n;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        Console.WriteLine($" x  |  y  \n----|----");

        for (int i = 0; i < y.Length; i++)
        {
            if (x[i] == 0) y[i] = double.NaN; // because in ln(x) it must be x>0
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);

            Console.WriteLine($"{x[i]}{new string(' ', 4 - x[i].ToString().Length)}| {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue; int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; index = i; }
        }
        array[index] *= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = double.MinValue;
        foreach (var n in array) { if (n > max) max = n; } // compute maximal value

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) break;
            else sum += array[i];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = double.MaxValue;
        foreach (var n in array) { if (n < min) min = n; } // compute minimal value

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min) break;
            else if (array[i] > 0) array[i] *= 2;
            else array[i] /= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double max = double.MinValue, average = 0;
        foreach (var n in array)
        {
            if (n > max) max = n; // compute maximal value
            average += n / array.Length; // compute average
        }

        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] == max) break;
            else array[i] = Math.Round(average, 2);
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double[] array2 = array;
        array = new double[array.Length];

        double max = double.MinValue; int iMax = 0;
        double min = double.MaxValue; int iMin = 0;
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] < min) { min = array2[i]; iMin = i; } // compute minimal value
            if (array2[i] > max) { max = array2[i]; iMax = i; } // compute maximal value
        }

        for ( int i=iMin+1, k=0; i<iMax; i++)
        {
            if (array2[i]<0) 
            { array[k] = array2[i]; k++; }
        }
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here
        double average = 0;
        foreach (var n in array) { average += n / array.Length; }

        int index = 0; 
        double comp = double.MaxValue;
        for (int i=0; i<array.Length; i++) 
        {
            if (Math.Abs(average - array[i]) < comp) 
            {
                comp = Math.Abs(average - array[i]);
                index = i; 
            }
        }

        double[] arr2 = array;
        array = new double[array.Length+1];
        for (int i = 0, k = 0; i < arr2.Length; k++)
        {
            if (k == index+1) // the next element of array must be what is the current element of arr2, so we don't increment it here
            {
                array[k] = P;
            }
            else { array[k] = arr2[i]; i++; } 
            
        }
        // end

        return array;
    }
    public double[] Task_2_7(double[] array) 
    {
        // code here
        double max = double.MinValue; int iMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; iMax = i; } // compute maximal value
        }

        if (iMax != array.Length - 1)
        {
            if (array[iMax + 1]>0) array[iMax+1] *= 2;
            else array[iMax + 1] /= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here
        double max = double.MinValue; int iMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; iMax = i; } 
        }

        if (iMax != array.Length - 1)
        {
            double min = double.MaxValue; int iMin = 0;
            for (int i = iMax + 1; i < array.Length; i++)
            {
                if (array[i] < min) { min = array[i]; iMin = i; } 
            }

            array[iMax] = min;
            array[iMin] = max;
        }
        // end

        return array;
    }
    public double Task_2_9(double[] array) // problem: ask Mark how is the first output supposed to work if min is placed after max
    {
        double average = 0;

        // code here
        double max = double.MinValue; int iMax = 0;
        double min = double.MaxValue; int iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; iMin = i; } // compute minimal value
            if (array[i] > max) { max = array[i]; iMax = i; } // compute maximal value
        }

        for (int i=iMin+1; i<iMax;i++)
        {
            average += array[i] / array.Length;
        }
        average = Math.Round(average, 2);
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here
        double min = double.MaxValue; int iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min && array[i]>0) { min = array[i]; iMin = i; } // compute minimal value
        }

        if (array[iMin] > 0) // if the smallest value is negative, it means there are no positives at all, so we don't proceed
        {
            double[] arr2 = array;
            array = new double[arr2.Length - 1];
            for (int i = 0, k = 0; k < array.Length; i++)
            {
                if (i == iMin) i++;
                array[k] = arr2[i];
                k++;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here
        int index=0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0) { index = i; break; }
        }

        if (array[index] > 0)
        {
            double[] arr2 = new double[array.Length + 1];
            for (int i = 0, k = 0; k < arr2.Length; k++)
            {
                if (k == index + 1) arr2[k] = P;
                else { arr2[k] = array[i]; i++; }
            }
            array = arr2;
        }
        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // compute maximal value
        double max = double.MinValue; int iMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; iMax = i; } 
        }

        if (iMax != array.Length - 1) // if max element is last, we can't make a sum of elements after it
        {
            // find sum of elements after max
            double sum = 0;
            for (int i = iMax + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            // replace first negative with sum
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { array[i] = Math.Round(sum,2); break; }
            }
        }

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // compute maximal value
        double max = double.MinValue; int iMax = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > max) { max = array[i]; iMax = i; }
        }

        array[iMax] = iMax;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        // compute maximal value
        double max = double.MinValue; 
        int iMax = 0, iNeg=-1;
        for (int i = array.Length-1; i >= 0; i--)
        {
            if (array[i] < 0) iNeg = i;
            if (array[i] > max) { max = array[i]; iMax = i; }
        }

        if (iNeg > -1)
        {
            array[iMax] = array[iNeg];
            array[iNeg] = max;
        }

        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k) 
    {
        double[] output = null;

        // code here
        output = new double[A.Length + B.Length];
        for (int a = 0, b=0, n=0; a < A.Length; n++)
        {
            if (a==k+1 && b<B.Length)
            {
                output[n] = B[b];
                b++;
            }
            else
            {
                output[n] = A[a];
                a++;
            }
        }
        // end

        return output;
    }
    public int[] Task_2_16(double[] array) 
    {
        int[] output = null;

        // code here
        double average = 0;
        foreach (var n in array) { average += n / array.Length; }
        
        int new_length = 0;
        foreach (var n in array) { if (n < average) new_length++; }
        output = new int[new_length];

        for (int i = 0, k = 0; i < array.Length && k < array.Length; i++)
        {
            if (array[i] < average) { output[k] = i; k++; }
        }
        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here
        double max = double.MinValue; int iMax = 0;
        double min = double.MaxValue; int iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; iMin = i; } // compute minimal value
            if (array[i] > max) { max = array[i]; iMax = i; } // compute maximal value
        }

        int count = 0;
        if (iMax<iMin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { average += array[i]; count++; }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { average += array[i]; count++; }
            }
        }
        if (count != 0) average = Math.Round(average / count, 2);

        // end

        return average;
    }
    public double[] Task_2_18(double[] array)
    {
        // code here
        double maxOdd = double.MinValue; 
        double maxEven = double.MinValue; 
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2!=0 && array[i] > maxOdd) { maxOdd = array[i]; } 
            if (i % 2 == 0 && array[i] > maxEven) { maxEven = array[i]; } 
        }

        if (maxEven>maxOdd)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here
        double max = double.MinValue, sum = 0;
        int iMax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) { max = array[i]; iMax = i; }
            sum += array[i];
        }

        if (max > sum) array[iMax] = 0;
        else array[iMax] *= 2;
        // why the fuck are all the previous ones so complicated and this one is just that?..

        // end

        return array;
    }
    public double Task_2_20(double[] array) 
    {
        double sum = 0;

        // code here
        double min = double.MaxValue; int iMin = 0, iNeg = int.MaxValue;
        bool negFound = false;
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < min) { min = array[k]; iMin = k; } // compute minimal value
            if (!negFound && array[k] < 0) { negFound = true; iNeg = k; }
        }

        if (negFound) // we only find the sum if a negative number is actually present in the array
        {
            int i;
            if (iNeg < iMin) i = 0;
            else i = 1;

            for (; i < array.Length; i += 2)
            {
                sum += array[i];
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

        // end

        return normalizedArray;
    }
    #endregion
}

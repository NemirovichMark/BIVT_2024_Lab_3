using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] { 1, 2, 3, 4, 5, 6 });
        program.Task_2_5(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++) { sum += array[i]; } // compute sum

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

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { average += array[i]; amount++; } // compute sum and amount of positive elements
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
        for (int i = 0; i < array.Length; i++) { average += array[i] / array.Length; }

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
        for (int i = 0; i < vector.Length; i++) { length += vector[i] * vector[i]; }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) { average += array[i] / array.Length; }

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
        for (int i = 0; i < array.Length; i++) { if (array[i] < 0) count++; }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) { average += array[i] / array.Length; }

        for (int i = 0; i < array.Length; i++) { if (array[i] > average) count++; }
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
        int amount = 0;
        for (int i = 0; i < array.Length; i++) { if (array[i] > 0) amount++; }

        output = new double[amount];
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { output[k] = array[i]; k++; }
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
        double[] odd = new double[array.Length / 2];

        // code 
        int i = 0, k = 0;
        foreach (double n in array) // iterate through original array
        {
            if (k % 2 != 0) { odd[i] = n; i++; } // when original array index is odd, we increment the even/odd array's index
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
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[index]) { index = i; }
        }

        if (array[index] < 0) array[index] /= 2;
        else array[index] *= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here

        int iMax = 0; // index of max value in array

        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] > array[iMax]) iMax=i; // find maximal value
        } 

        for (int i = 0; i < iMax; i++) sum += array[i];
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int iMin = 0; // index of min value in array

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[iMin]) iMin = i; // find minimal value
        }

        for (int i = 0; i < iMin; i++)
        {
            if (array[i] > 0) array[i] *= 2; 
            else array[i] /= 2; // we divide if element is negative because multiplying it will make it smaller
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        int iMax = 0; 
        double average = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find maximal value
            average += array[i] / array.Length; // compute average
        }

        for (int i = iMax+1; i < array.Length; i++)
        {
            array[i] = Math.Round(average, 2); // substitute for rounded average
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here

        int iMax = 0, iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find max value
            if (array[i] < array[iMin]) iMin = i; // find min value
        }

        // determine start and end indexes between min and max
        int iStart = (iMin < iMax) ? iMin : iMax;
        int iEnd = (iMin < iMax) ? iMax : iMin;

        // count amount of negatives
        int amount = 0;
        for (int i = iStart+1; i < iEnd; i++)
        {
            if (array[i] < 0) amount++;
        }

        double[] arrNegative = new double[amount];

        if (amount > 0)
        {
            for (int i = iStart + 1, k=0; i < iEnd; i++)
            {
                if (array[i] < 0) { arrNegative[k] = array[i]; k++; } // k is only incremented after we add new element to neg. array
            }
        }

        array = arrNegative;
        // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) { average += array[i] / array.Length; }


        double smallest_dif = double.MaxValue; // smallest found "distance" between average and an array element
        int index = 0; // index of element closest to average
        for (int i = 0; i < array.Length; i++)
        {
            double dif = Math.Abs(average - array[i]); // distance from average to array[i]
            if (dif < smallest_dif)
            {
                smallest_dif = dif;
                index = i;
            }
        }

        double[] arrCopy = new double[array.Length + 1]; // new array with place to insert P
        for (int i = 0, k = 0; i < array.Length; i++)
        {
            arrCopy[k] = array[i];
            if (k == index)
            {
                arrCopy[k+1] = P; // insert P in its place
                k++; // increment to move on to next element in arrCopy
            }
            k++;
        }
        array = arrCopy;
        // end

        return array;
    }
    public double[] Task_2_7(double[] array) 
    {
        // code here
        int iMax = 0; // index of max value in array

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find maximal value
        }

        if (iMax != array.Length - 1)
        {
            if (array[iMax + 1] > 0) array[iMax + 1] *= 2;
            else array[iMax + 1] /= 2;
        }
        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here
        int iMax = 0; // index of max value in array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find maximal value
        }

        if (iMax != array.Length - 1)
        {
            int iMin = 0; // index of min value in array
            for (int i = iMax+1; i < array.Length; i++)
            {
                if (array[i] < array[iMin]) iMin = i; // find minimal value
            }

            // swap max and min
            double max = array[iMax];
            array[iMax] = array[iMin];
            array[iMin] = max;
        }
        // end

        return array;
    }
    public double Task_2_9(double[] array)
    {
        double average = 0;

        // code here
        int iMax = 0, iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find max value
            if (array[i] < array[iMin]) iMin = i; // find min value
        }

        // determine start and end indexes between min and max
        int iStart = (iMin < iMax) ? iMin : iMax;
        int iEnd = (iMin < iMax) ? iMax : iMin;

        int amount = iEnd - iStart - 1; // amount of elements between min and max (we substitute 1 to account for indexes starting from 0)
        for (int i = iStart+1; i < iEnd; i++)
        {
            average += array[i] / amount;
        }
        // end

        return average;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int iMin = 0; // index of min value in array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min) { min = array[i]; iMin = i; } // find minimal value
        }

        if (array[iMin] > 0) // if min is negative or 0, it means there are no positives at all, so we don't proceed
        {
            double[] arrCopy = new double[array.Length-1]; 
            for (int i = 0, k = 0; k < arrCopy.Length; i++)
            {
                if (i == iMin) i++; // if index is iMin, we skip it and don't insert this value
                arrCopy[k] = array[i]; 
                k++;
            }
            array = arrCopy;
        }
        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here
        int iPos = -1;
        for (int i = array.Length - 1; i >= 0; i--) // starting from end of array because we want to find last element
        {
            if (array[i] > 0) { iPos = i; break; }
        }

        if (iPos != -1) // means at least 1 positive element was found
        {
            Console.WriteLine(iPos);
            double[] arrCopy = new double[array.Length + 1]; // new array with place to insert P
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                arrCopy[k] = array[i];
                if (k == iPos)
                {
                    arrCopy[k+1] = P; // insert P in its place
                    k++; // increment to move on to next element in arrCopy
                }
                k++;
            }
            array = arrCopy;
        }
        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        int iMax = 0; // index of max value in array
        int iNeg = 0; // index of first negative
        for (int i = array.Length-1; i >= 0; i--)
        {
            if (array[i] < 0) iNeg = i;
            if (array[i] > array[iMax]) iMax = i; // find maximal value
        }

        if (iMax != array.Length - 1) // if max element is last, we can't make a sum of elements after it
        {
            // find sum of elements after max
            double sum = 0;
            for (int i = iMax + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            array[iNeg] = sum;
        }

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        // code here

        // compute max value
        int iMax = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > array[iMax]) { iMax = i; }
        }

        array[iMax] = iMax;
        // end

        return array;
    }
    public double[] Task_2_14(double[] array)
    {
        // code here

        // compute maximal value
        double max = double.MinValue; // max element
        int iMax = 0, iNeg=-1;
        for (int i = array.Length-1; i >= 0; i--) // starting from end of array because we want to find first negative
        {
            if (array[i] < 0) iNeg = i;
            if (array[i] > max) { max = array[i]; iMax = i; }
        }

        if (iNeg > -1) // means that a negative is found, otherwise we can't proceed
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
        if (k >= A.Length) return A; // if k is outside of A, we can't insert B into it

        output = new double[A.Length + B.Length]; // new array for housing A and B
        int i = 0; // index for the output array

        // insert part of A from start to k
        for (int a=0; a<=k; a++) 
        {
            output[i] = A[a];
            i++;
        }

        // insert B until we reach it's end
        for (int b=0; b < B.Length; b++)
        {
            output[i] = B[b];
            i++;
        }

        // insert part of A from k+1 to end of A
        for (int a=k+1; a < A.Length; a++)
        {
            output[i] = A[a];
            i++;
        }
        // end

        return output;
    }
    public int[] Task_2_16(double[] array)
    {
        int[] output = null;

        // code here
        double average = 0;
        for (int i = 0; i < array.Length; i++) { average += array[i] / array.Length; } // compute average
        
        int new_length = 0;
        for (int i = 0; i < array.Length; i++) { if (array[i] < average) new_length++; } // determine the amount of elements for new array

        output = new int[new_length];
        for (int i = 0, k = 0; i < array.Length && k < array.Length; i++)
        {
            if (array[i] < average) { output[k] = i; k++; } // put the needed elements in ouput array
        }
        // end

        return output;
    }
    public double Task_2_17(double[] array)
    {
        double average = 0;

        // code here
        int iMax = 0, iMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) iMax = i; // find max value
            if (array[i] < array[iMin]) iMin = i; // find min value
        }

        int count = 0;
        double sum = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (iMax < iMin) 
            {
                if (array[i] > 0) { sum += array[i]; count++; } // find sum and amount of positives
            }
            else
            {
                if (array[i] < 0) { sum += array[i]; count++; } // find sum and amount of negatives
            }
        }
        if (count != 0) average = Math.Round(sum / count, 3);

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
            if (i % 2 != 0 && array[i] > maxOdd) { maxOdd = array[i]; } // count for odds
            if (i % 2 == 0 && array[i] > maxEven) { maxEven = array[i]; } // count for evens
        }

        int index = (maxEven > maxOdd) ? 0 : array.Length / 2; 
        int end = (maxEven > maxOdd) ? array.Length / 2 : array.Length;

        for (; index < end; index++)
        {
            array[index] = 0;
        }
        // end

        return array;
    }
    public double[] Task_2_19(double[] array)
    {
        // code here
        double sum = 0; // sum of elements in array
        int iMax = 0; // index of max element
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[iMax]) { iMax = i; } // find max element
            sum += array[i];
        }

        array[iMax] = (array[iMax] > sum) ? 0 : array[iMax] * 2;
        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        int iMin = 0; // index of min element
        int iNeg = -1; // index of first negative

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < array[iMin]) { iMin = i; } // find min element
            if (array[i] < 0) { iNeg = i; }
        }

        int startIndex = (iNeg < iMin) ? 0 : 1;

        for (; startIndex < array.Length; startIndex += 2)
        {
            sum += array[startIndex];
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
    public double[] Task_3_3(double[] array) // mine
    {
        // code here
        int iMax = 0; // index of max element
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] >= array[iMax]) { iMax = i; } // find max element
        }

        for (int i = 0; i < iMax - 1; i += 2)
        {
            double current = array[i]; // current value of array[i] element
            array[i] = array[i + 1];
            array[i + 1] = current;
        }
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
    public int Task_3_6(double[] array) // mine
    {
        int count = 0;

        // code here
        int len = 1; // length of the current element chain

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i-1])
            {
                len++;
                count = (count>len) ? count : len;
            }
            else
            {
                len = 1;
            }
        }
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
    public int Task_3_9(double[] array) // mine
    {
        int count = 0;

        // code here
        int lenD = 1; // length of the current descending element chain
        int lenA = 1 ; // length of the current ascending element chain

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                lenD++;
                count = (count > lenD) ? count : lenD;
            }
            else
            {
                lenD = 1;
            }

            if (array[i] > array[i - 1])
            {
                lenA++;
                count = (count > lenA) ? count : lenA;
            }
            else
            {
                lenA = 1;
            }
        }
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
    public double[] Task_3_12(double[] array) // mine
    {
        // code here
        int amount = 0; // amount of negatives

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) amount++;
        }

        double[] arrCopy = new double[amount];
        for (int i = 0, k = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) { arrCopy[k] = array[i]; k++; }
        }

        array = arrCopy;
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

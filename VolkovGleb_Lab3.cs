using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
        double total = 0;
        for (int i = 0; i < array.Length; i++)
            total += array[i];
        for (int i = 0; i < array.Length; i++)
        {
            if (total != 0)
                array[i] = Math.Round(array[i] / total, 2);
            else
                array[i] = 0;
        }
        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double counter = 0;
        double total = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
            {
                counter += 1;
                total += array[i];
            }
        total /= counter; 
        for (int j = 0; j < array.Length; j++)
            if (array[j] > 0)
                array[j] = total;
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
        double total = 0;
        foreach (double x in array)
            total += x;
        total /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= total;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double total = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            total += vector1[i] * vector2[i];
        }
        product = Math.Round(total, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector)
        {
            length += x * x;
        }
        
        // end

        return Math.Round(Math.Sqrt(length), 4); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avg = 0;
        foreach (double x in array)
        {
            avg += x;
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) array[i] = 0;
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
            if (array[i] < 0) count += 1;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double avg = 0;
        foreach (double x in array)
        {
            avg += x;
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) count += 1;
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
            if (P < array[i] && array[i] < Q) count += 1;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int outputLength = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) outputLength++;
        }
        output = new double[outputLength];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) 
            {
                output[j] = array[i];
                j++;
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
        int index = 0;
        for (int i = 0; i <  array.Length; i++)
        {
            even[index] = array[i];
            i++;
            odd[index] = array[i];
            index++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0; 
        while (i < array.Length)
        {
            if (array[i] >= 0)
            {
                sum += Math.Pow(array[i], 2);
            }
            else break;
            i++;
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
            x[i] = 0.5 * (Math.Log(x[i]));
            if (x[i] >= 0)
                y[i] = Math.Round(x[i], 2);
            else
                y[i] = double.NaN;
        }
        for (int i = 0; i < x.Length; i++)
            Console.WriteLine($"{x[i]} + {y[i]}");
        // end

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
        double sum = 0;

        // code here
        int maxIndex = 0;
        double maxNum = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNum)
            {
                maxNum = array[i];
                maxIndex = i;
            }
        }
        for (int i = 0; i < maxIndex; i++)
        {
            sum += array[i];
        }
        // end

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
        // code here
        int maxIndex = 0, count = 0;
        double maxNum = double.MinValue, avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxNum)
            {
                maxNum = array[i];
                maxIndex = i;
            }
            count++;
            avg += array[i];
        }
        avg /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (i > maxIndex) array[i] = avg;
        }      
        // end

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
        // code here
        double mid = 0;
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }
        mid = mid / array.Length;
        int mj = 0;
        double d = 1000000;
        for (int j = 0; j < array.Length; j++)
        {
            if (Math.Abs(array[j] - mid) < d)
            {
                d = Math.Abs(array[j] - mid);
                mj = j;
            }
        }
        double[] array_temp = new double[array.Length + 1];
        for (int _ = 0; _ < mj + 1; _++)
        {
            array_temp[_] = array[_];
        }
        array_temp[mj + 1] = P;
        for (int c = mj + 2; c <= array.Length; c++)
        {
            array_temp[c] = array[c - 1];
        }
        array = array_temp;
        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        // code here
        double maxEl = double.MinValue, minEl = double.MaxValue;
        int maxIndex = -1, minIndex = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl)
            {
                maxEl = array[i];
                maxIndex = i;
            }
        }
        for (int i = maxIndex; i < array.Length; i++)
        {
            if (array[i] < minEl)
            {
                minEl = array[i];
                minIndex = i;
            }
        }
        array[minIndex] = maxEl;
        array[maxIndex] = minEl;

        // end

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
        // code here
        double mn = -1, mni = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > 0 && (array[i] < mn || mn == -1))
            {
                mn = array[i];
                mni = i;
            }
        }
        if (mni == 0 && mn <= 0) return array;
        double[] array1 = new double[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i ++)
        {
            if (i != mni)
            { 
                array1[j] = array[i];
                j++;
            }
        }
        array = array1;

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here
        double mx = 0, mxi = -1, Si = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[(int)Si] >= 0 && array[i] < 0) Si = i;
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        if (array[(int)Si] >= 0) return array;
        double sm = 0;
        for (int i = (int)mxi + 1; i < array.Length; i++)
        {
            sm += array[i];
        }
        array[(int)Si] = Math.Round(sm, 2);
        // end

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
        // code here
        double mx = 0, mxi = -1, Si = -1;
        for (int i = 0; i < array.Length; i ++)
        {
            if (Si == -1 && array[i] < 0) Si = i;
            if (array[i] > mx || mxi == -1)
            {
                mx = array[i];
                mxi = i;
            }
        }
        if (Si == -1) return array;
        double c = array[(int)Si];
        array[(int)Si] = array[(int)mxi];
        array[(int)mxi] = c;

        // end

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

        // code here
        double avg = 0;
        int count = 0;
        foreach (double x in array) avg += x;
        avg /= array.Length;
        foreach (double x in array) if (x < avg) count += 1;
        int[] answer = new int[count];
        for (int i = 0, c = 0; i < array.Length; i++)
            if (array[i] < avg)
            {
                answer[c] = i;
                c++;
            }
        output = answer;
        // end

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
        // code here
        double maxEven = double.MinValue, maxOdd = double.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxEven) maxEven = array[i];
            if (i % 2 != 0 && array[i] > maxOdd) maxOdd = array[i];
        }
        if (maxEven > maxOdd)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;           
        }
        if (maxEven < maxOdd)
        {
            for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;           
        }
        // end

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

        // code here
        double minEl = double.MaxValue, negEl = 999;
        int negIndex = -1, minIndex = -1;
        bool flag = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minEl)
            {
                minEl = array[i];
                minIndex = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negIndex = i;
                negEl = array[i];
                flag = true;
                break;                
            }
        }

        if (flag == false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1) sum+=array[i];
            }
        }
        else
            if (negIndex > minIndex || negEl == minEl)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 1) sum+=array[i];
                }                            
            }
            else
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0) sum+=array[i];
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
        double maxEl = double.MinValue;
        int counter = 0;
        int[] answer = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl)
            {
                counter = 0;
                maxEl = array[i];
            }
            if (array[i] == maxEl)
            {
                answer[counter] = i;
                counter++;
            }
        }
        output = new int[counter];
        for (int i = 0; i < counter; i++)
        {
            output[i] = answer[i];
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
        double maxEl = double.MinValue, sum = 0;
        double[] array2 = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl)
            {
                maxEl = array[i];
            }
        }      
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != maxEl)
            {
                array2[i] = array[i];
            }
            else
            {
                array2[i] = sum;
            }
            sum += array[i];
        }
        array = array2; 
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
        int negCounter = 0, posIdx = 0;
        double[] answer = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negCounter++;
            }
        }       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                answer[i - posIdx] = array[i];
            }
            else
            {
                answer[answer.Length - negCounter] = array[i];
                negCounter--;
                posIdx++;
            }
        } 
        array = answer;        

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
        double[] answer = new double[array.Length];
        for (int i = 1; i < array.Length; i+=2)
        {
            answer[i - 1] = array[(i - 1) / 2];
            answer[i] = array[(i - 1) / 2];
        }
        array = answer;
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
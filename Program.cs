using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;
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
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= sum;
            array[i] = Math.Round(array[i], 2);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        double sum = 0;
        int count = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count ++;
            }
        }
        sum /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(sum, 2);
            }
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
            sum[i] = Math.Round((first[i] + second[i]), 2);
            dif[i] = Math.Round((first[i] - second[i]), 2);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
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

        for (int i = 0; i < vector.Length; i++)
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

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        sum /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (sum < array[i])
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

        for (int i = 0; i < array.Length; i++)
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

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        sum /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (sum < array[i])
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

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > P) && (array[i] < Q))
            {
                count++;
            }
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output = null;
        // code here

        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count1++;
            }
        }
        double[] output = new double[count1];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count2] = array[i];
                count2++;
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

        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < array.Length; i++)
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
            if (array[i] < 0)
            break;
            sum += array[i] * array[i];
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
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }

            Console.WriteLine($"{x[i]}  {y[i]}");
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here

        int minElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[minElement])
            {
                minElement = i;
            }
        }
        array[minElement] *= 2;

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

        int minElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[minElement])
            {
                minElement = i;
            }
        }
        for (int i = 0; i < minElement; i++)
        {
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] /= 2;
            }
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

        int maxElement = 0;
        int minElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxElement])
            {
                maxElement = i;
            }
            if (array[i] < array[minElement])
            {
                minElement = i;
            }
        }
        int k = 0;
        for (int i = minElement + 1; i < maxElement; i++)
        {
            array[k++] = array[i];
        }

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

        int maxElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxElement])
            {
                maxElement = i;
            }
        }
        if (maxElement + 1 < array.Length)
        {
            if (array[maxElement + 1] > 0)
            {
                array[maxElement + 1] *= 2;
            }
            else
            {
                array[maxElement + 1] /= 2;
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

        int maxElement = 0;
        int minElement = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[minElement])
            {
                minElement = i;
            }
            else if(array[i] > array[maxElement])
            {
                maxElement = i;
            }
        }
        if (minElement > maxElement)
        {
            int k = minElement;
            minElement = maxElement;
            maxElement = k;
        }
        for (int i = minElement + 1; i < maxElement; i++)
        {
            average += array[i];
        }
        if (maxElement - minElement - 1 == 0)
        {
            average = 0;
        }
        else
        {
            average /= (maxElement - minElement - 1);
            average = Math.Round(average, 2);
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

        int lastElement = -1;
        double[] newArray = new double[array.Length + 1];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                lastElement = i;
                break;
            }
        }
        if (lastElement == -1)
        {
            return array;
        }
        for (int i = 0; i <= lastElement; i++)
        {
            newArray[i] = array[i];
            newArray[lastElement + 1] = P;
        }
        for (int i = lastElement + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
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

        double maxElement = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                index = i;
            }
        }
        array[index] = index;

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
        if (k >= A.Length)
        {
            return A;
  
        }
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + i + 1] = B[i];
        }
        for (int i = k + 1; i < A.Length; i++)
        {
            output[B.Length + i] = A[i];
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

        double maxValue = array[0], minValue = array[0];
        int maxIndex = 0, minIndex = 0;

        double avgPlus = 0, avgMinus = 0;
        int countPlus = 0, countMinus = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
            else if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }

            if (array[i] > 0)
            {
                avgPlus += array[i];
                countPlus++;
            }
            else if (array[i] < 0)
            {
                avgMinus += array[i];
                countMinus++;
            }
        }

        if (maxIndex < minIndex && countPlus != 0)
        {
            average = avgPlus / countPlus;
        }
        else if (maxIndex > minIndex && countMinus != 0)
        {
            average = avgMinus / countMinus;
        }
        else
        {
            average = 0;
        }

        // end

        return Math.Round(average, 2);
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

        double maxElement = array[0];
        double answer = 0;
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            answer += array[i];
            if (array[i] > maxElement)
            {
                maxIndex = i;
                maxElement = array[i];
            }
        }
        if (maxElement > answer)
        {
            array[maxIndex] = 0;
        }
        else
        {
            array[maxIndex] = maxElement * 2;
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
        //int[] output = null;

        // code here

        double maxElement = double.MinValue;
        int maxCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxCount = 1;
            }
            else if (array[i] == maxElement)
            {
                maxCount++;
            }
        }
        int[] output = new int[maxCount];
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxElement)
            {
                output[maxIndex] = i;
                maxIndex++;
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

        double maxElement = double.MinValue;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] == maxElement)
            {
                array[i] = sum - array[i];
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

        int length = array.Length;
        int lastIndex = array.Length - 1;
        for (int i = length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                double hold = array[i];
                array[i] = array[lastIndex];
                array[lastIndex] = hold;
                lastIndex--;
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

        int length = array.Length / 2;

        for (int i = length - 1; i >= 0; i--) 
        {
            array[2 * i ] = array[i]; 
            array[2 * i + 1] = array[i]; 
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

        int count = 0;
        bool copy = true;
        for (int i = 0; i < array.Length; i++)
        {
            copy = true;
            for (int k = 0; k < i; k++)
            {
                if (array[i] == array[k])
                {
                    copy = false;
                    break;
                }
            }
            if (copy)
            {
                count++;
            }
        }
        double[] newArray = new double[count];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            copy = true;
            for (int k = 0; k < n; k++)
            {
                if (array[i] == newArray[k])
                {
                    copy = false;
                    break;
                }
            }
            if (copy)
            {
                newArray[n++] = array[i];
            }
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

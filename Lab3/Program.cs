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
        for (int i = 0; i < 6; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = array[i] / sum;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int a = 0;
        double sum = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                a++;
                sum += array[i];
            }
        }
        sum = sum / a;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0) { array[i] = sum; }
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
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += array[i];

        }
        sum = sum / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= sum;
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
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }

        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;

        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }

        sum = sum / 7;

        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sum)
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
        double sum = 0;

        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }

        sum = sum / 7;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sum)
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
            if (array[i] > P && array[i] < Q)
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
        var positiveCount = 0;
        foreach (int i in array)
        {
            if (i > 0) positiveCount++;
        }
        output = new double[positiveCount];
        for (int i = 0, b = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[b] = array[i];
                b++;
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
        for (int i = 0; i < 10; i = i + 2)
        {
            even[i / 2] = array[i];
            odd[i / 2] = array[i + 1];
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
            if (array[i] < 0) break;
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
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length; i++)
            Console.WriteLine($"{x[i]:F4}\t\t{y[i]:F4}");
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
        double max = array[0];

        foreach (var i in array)
        {
            if (i > max) max = i;
        }

        foreach (var i in array)
        {
            if (i == max) break;
            sum += i;
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
        double sum = 0, max = array[0];

        foreach (var item in array)
        {
            if (item > max)
            {
                max = item;
            }

            sum += item;
        }

        bool isAfterMax = false;
        double average = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (isAfterMax)
            {
                array[i] = average;
            }

            if (array[i] == max)
            {
                isAfterMax = true;
            }
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double avg = sum / array.Length;

        double minDiff = Math.Abs(array[0] - avg);
        int closestIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            double diff = Math.Abs(array[i] - avg);
            if (diff < minDiff)
            {
                minDiff = diff;
                closestIndex = i;
            }
        }

        double[] newarray = new double[array.Length + 1];

        for (int i = 0; i <= closestIndex; i++)
        {
            newarray[i] = array[i];
        }

        newarray[closestIndex + 1] = P;

        for (int i = closestIndex + 1; i < array.Length; i++)
        {
            newarray[i + 1] = array[i];
        }
        array = newarray;
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
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
                maxIndex = i;
        }

        if (maxIndex < array.Length - 1)
        {
            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
            }

            var temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
        }
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
        double minPositive = double.PositiveInfinity;
        int minIndex = -1;
        var tempArray = new double[array.Length - 1];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minPositive)
            {
                minPositive = array[i];
                minIndex = i;
            }
        }
        if (minIndex == -1) return array;

        for (int i = 0; i < minIndex; i++)
        {
            tempArray[i] = array[i];
        }

        for (int i = minIndex + 1; i < array.Length; i++)
        {
            tempArray[i - 1] = array[i];
        }
        array = tempArray;
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
        int maxIndex = 0;
        double maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }

        double sumAfterMax = 0.0;
        for (int i = maxIndex + 1; i < array.Length; i++)
        {
            sumAfterMax += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sumAfterMax;
                break; 
            }
        }
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
        int maxIndex = 0; 
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int firstNegativeIndex = -1; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break;
            }
        }

        if (firstNegativeIndex != -1)
        {
            double temp = array[maxIndex];
            array[maxIndex] = array[firstNegativeIndex];
            array[firstNegativeIndex] = temp;
        }
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = sum / array.Length;

        // 2. Считаем количество элементов, меньших среднего
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < average)
            {
                count++;
            }
        }

        // 3. Создаем массив индексов элементов, меньших среднего
        output = new int[count];
        int idx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < average)
            {
                output[idx] = i;
                idx++;
            }
        }
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
        double maxEvenIndexValue = array[0]; 
        double maxOddIndexValue = double.NegativeInfinity;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxEvenIndexValue) maxEvenIndexValue = array[i];
            }
            else
            {
                if (array[i] > maxOddIndexValue) maxOddIndexValue = array[i];
            }
        }

        int halfLength = array.Length / 2;
        if (maxEvenIndexValue > maxOddIndexValue)
        {
 
            for (int i = 0; i < halfLength; i++)
            {
                array[i] = 0;
            }
        }
        else
        {

            for (int i = halfLength; i < array.Length; i++)
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

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        double firstNegativeIndex = -1;
        double minElementIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break;
            }
        }

        double minElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
                minElementIndex = i;
            }
        }

        if (firstNegativeIndex != -1 && firstNegativeIndex < minElementIndex)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }
        else
        {
            for (int i = 1; i < array.Length; i += 2)
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
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        int counter = 0; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                counter++;
                array[i] += counter;
            }
        }
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
        int evenCount = (array.Length + 1) / 2;
        double[] evenElements = new double[evenCount];

        int evenIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            evenElements[evenIndex++] = array[i];
        }

        for (int i = 0; i < evenElements.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < evenElements.Length; j++)
            {
                if (evenElements[j] < evenElements[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                double temp = evenElements[i];
                evenElements[i] = evenElements[minIndex];
                evenElements[minIndex] = temp;
            }
        }

        evenIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = evenElements[evenIndex++];
        }
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
        int negativeCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) negativeCount++;
        }

        double[] negatives = new double[negativeCount];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negatives[index++] = array[i];
            }
        }

        for (int i = 0; i < negatives.Length - 1; i++)
        {
            for (int j = 0; j < negatives.Length - i - 1; j++)
            {
                if (negatives[j] < negatives[j + 1])
                {
                    double temp = negatives[j];
                    negatives[j] = negatives[j + 1];
                    negatives[j + 1] = temp;
                }
            }
        }

        index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = negatives[index++];
            }
        }
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
         X = new double[n];
         Y = new double[n];

        double h = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            X[i] = a + i * h;
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }

        globalMax = Y[0];
        globalMin = Y[0];

        for (int i = 1; i < n; i++)
        {
            if (Y[i] > globalMax)
                globalMax = Y[i];
            if (Y[i] < globalMin)
                globalMin = Y[i];
        }
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
        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        double originalMin = min;
        double originalMax = max;

        normalizedArray = new double[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            double normalized = (array[i] - min) / (max - min); 
            normalizedArray[i] = normalized * 2 - 1;                  
        }
        // end

        return normalizedArray;
    }
    #endregion
}
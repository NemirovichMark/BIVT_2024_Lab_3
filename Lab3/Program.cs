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
        double S = 0;
        foreach (double x in array)
        {
            S += x;
            
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / S, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double avg = 0;
        int k = 0;
        foreach (double x in array)
        {
            if (x > 0) { avg += x; k++; }
        }
        avg = Math.Round(avg / k, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = avg;
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
        double avg = 0;
        foreach (double x in array)
        {
            avg += x;
        }
        Math.Round(avg /= array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - avg, 2);
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
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
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
        foreach (double x in array)
        {
            if (x < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double avg = 0;

        // code here
        foreach (double x in array)
        {
            avg += x;
        }
        avg /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) count++;
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
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        count = 0;////////////
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count] = array[i];
                count++;
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
        for (int i = 0, k = 0; i < array.Length; i += 2)
        {
            even[k] = array[i];
            odd[k] = array[i + 1];
            k++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array)
        {
            if (x >= 0) sum += x * x;
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
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
        }
        Console.WriteLine(string.Join(" ", x));
        Console.WriteLine(string.Join(" ", y));
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
        double amax = 0, elem = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                sum += elem;
                elem = 0; 
            }
            elem += array[i];
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
        double sum = 0;
        double amax = array[0];
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double avg = sum / array.Length;
        avg = Math.Round(avg, 2);
        for (int i = imax + 1; i < array.Length; i++)
        {
            array[i] = avg;
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
        int iclose = 0;
        double aclose = array[0];
        double[] newArray = new double[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double avg = sum / array.Length;
        double mindif = Math.Abs(array[0] - avg);
        for (int i = 0; i < array.Length; i++)
        {
            double dif = Math.Abs(array[i] - avg);
            if (dif < mindif)
            {
                mindif = dif;
                aclose = array[i];
                iclose = i;
            }
        }
        iclose++;
        int flag = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == iclose)
            {
                newArray[i] = P;
                flag = 1;
            }
            newArray[i+flag] = array[i];
        }
        array = newArray;
        Console.WriteLine(string.Join(" ", newArray));
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
        int maxInd = 0, minInd = -1;
        double minVal = double.MaxValue;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxInd])
            {
                maxInd = i;
            }
        }
        for (int i = maxInd + 1; i < array.Length; i++)
        {
            if (array[i] < minVal)
            {
                minVal = array[i];
                minInd = i;
            }
        }
        if (minInd != -1)
        {
            (array[maxInd], array[minInd]) = (array[minInd], array[maxInd]);
        }
        Console.WriteLine(string.Join(" ", array));
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
        double minVal = double.MaxValue;
        int minInd = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minVal)
            {
                minVal = array[i];
                minInd = i;
            }
        }
        if (minInd != -1)
        {
            double[] newArray = new double[array.Length - 1];
            for (int i = 0; i < minInd; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = minInd; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }
            array = newArray;
        }
        Console.WriteLine(string.Join(" ", array));
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
        double sumElem = 0;
        int firstNegElem = -1;
        int maxInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxInd])
            {
                maxInd = i;
            }
        }
        for (int i = maxInd + 1; i < array.Length; i++)
        {
            sumElem += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegElem = i;
                break;
            }
        }
        if (firstNegElem != -1)
        {
            array[firstNegElem] = sumElem;
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
        int firstNegElem = -1;
        int maxInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxInd])
            {
                maxInd = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegElem = i;
                break;
            }
        }
        if (firstNegElem != -1)
        {
            (array[maxInd], array[firstNegElem]) = (array[firstNegElem], array[maxInd]);
        }
        Console.WriteLine(string.Join(" ", array));
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
        int kbelow = 0;
        int ind = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        double avg = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                kbelow++;
            }
        }
        output = new int[kbelow];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                output[ind++] = i;
            }
        }
        Console.WriteLine(string.Join(" ", output));
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
        double maxEven = double.MinValue;
        double maxOdd = double.MinValue;
        int halfLen = array.Length / 2;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxEven)
            {
                maxEven = array[i];
            }
            if (i % 2 != 0 && array[i] > maxOdd)
            {
                maxOdd = array[i];
            }
        }
        if (maxEven > maxOdd)
        {
            for (int i = 0; i < halfLen; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = halfLen; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        Console.WriteLine(string.Join(" ", array));
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
        int negInd = -1;
        double minVal = double.MaxValue;
        int minInd = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && negInd == -1)
            {
                negInd = i;
            }
            if (array[i] < minVal)
            {
                minVal = array[i];
                minInd = i;
            }
        }
        if (negInd != -1)
        {
            if (negInd < minInd)
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
        }
        else
        {
            sum = 14;
        }
        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine(sum);
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
        double maxVal = double.MinValue;
        int maxCount = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxVal)
            {
                maxVal = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxVal)
            {
                array[i] += maxCount;
                maxCount++;
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
        int evenInd = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            evenElements[evenInd++] = array[i];
        }
        for (int i = 0; i < evenCount - 1; i++)
        {
            int minInd = i;
            for (int j = i + 1; j < evenCount; j++)
            {
                if (evenElements[j] < evenElements[minInd])
                {
                    minInd = j;
                }
            }
            if (minInd != i)
            {
                (evenElements[i], evenElements[minInd]) = (evenElements[minInd], evenElements[i]);
            }
        }
        evenInd = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = evenElements[evenInd++];
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
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                int curInd = i;
                double curtMax = array[i];


                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < 0 && array[j] > curtMax)
                    {
                        curtMax = array[j];
                        curInd = j;
                    }
                }


                if (curInd != i)
                {
                    (array[i], array[curInd]) = (array[curInd], array[i]);
                }
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
        double globalMax = double.MinValue, globalMin = double.MaxValue;

        // code here
        X = new double[n];
        Y = new double[n];
        double step = (b - a) / (n - 1);
        int ind = 0;
        for (double i = a; i <= b; i += step)
        {
            double res = Math.Cos(i) + i * Math.Sin(i);
            X[ind] = Math.Round(i, 2);
            Y[ind] = Math.Round(res, 2);
            ind++;

            if (res > globalMax) globalMax = res;
            if (res < globalMin) globalMin = res;
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
        normalizedArray = new double[array.Length];
        double maxVal = array[0], minVal = array[0];
        int n = 0;
        double normal = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxVal) maxVal = array[i];
            if (array[i] < minVal) minVal = array[i];

        }
        for (int i = 0; i < array.Length; i++)
        {
            normal = (array[i] - minVal) * 2 / (maxVal - minVal) - 1;
            normalizedArray[n] = Math.Round(normal, 2);
            n++;
        }
        // end

        return normalizedArray;
    }
    #endregion
}
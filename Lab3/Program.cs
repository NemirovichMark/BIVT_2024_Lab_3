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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sumArray = 0;
        
        for (int i = 0; i < array.Length; i++) {
            sumArray += array[i];
        }

        for (int i = 0; i < array.Length; i++) {
            array[i] /= sumArray;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sumPositive = 0;
        double countPositive = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > 0) {
                sumPositive += array[i];
                countPositive++;
            }
        }

        double avgPositive = sumPositive / countPositive;

        for (int i = 0; i < array.Length; i++) {
            array[i] = (array[i] > 0) ? avgPositive : array[i];
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++) {
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double avgArray = 0;
        
        for(int i = 0; i < array.Length; i++) {
            avgArray += array[i];
        }
        
        for(int i = 0; i < array.Length; i++) {
            array[i] -= (avgArray / 5);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++) {
            product += vector1[i] * vector2[i];
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double i in vector) {
            length += i * i;
        }
        // end
        
        return Math.Round(Math.Sqrt(length), 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sumArray = 0;

        foreach (double item in array) {
            sumArray += item;
        }

        sumArray /= 7;

        for (int i = 0; i < array.Length; i++) {
            array[i] = (array[i] > sumArray) ? 0: array[i];
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double item in array) {
            count += (item < 0)? 1: 0;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double avgArray = 0;

        // code here
        foreach (double item in array) {
            avgArray += item;
        }

        avgArray /= 8;

        foreach (double item in array) {
            count += (item > avgArray)? 1: 0;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double item in array) {
            count += (item > P && item < Q)? 1: 0;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int countPositive = 0;
        foreach (double item in array) {
            countPositive += (item > 0)? 1: 0;
        }

        output = new double[countPositive];

        for (int i = 0, j = 0; i < array.Length; i++) {
            if (array[i] > 0) {
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
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
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
        double[] odd = new double[array.Length/ 2];

        // code here
        for (int i = 0; i < array.Length; i++) {
            if (i % 2 == 0) {
                even[i / 2] = array[i];
            } else {
                odd[i / 2] = array[i];
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double item in array) {
            if (item < 0) {
                break;
            }
            sum += item * item;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++) {
            y[i] = (x[i] > 0) ? Math.Log(x[i]) * 0.5: double.NaN;
        }
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
        double maxValue = 0;

        foreach (double item in array) {
            maxValue = (item > maxValue) ? item: maxValue;
        }

        foreach (double item in array) {
            if (item == maxValue) {
                break;
            }
            sum += item;
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
        double avgArray = 0;
        double maxValue = 0;
        int maxValueIndex = 0;

        for (int i = 0; i < array.Length; i++) {
            avgArray += array[i];
            if (array[i] > maxValue) {
                maxValue = array[i];
                maxValueIndex = i;
            }
        }

        avgArray /= array.Length;
        maxValueIndex++;
        
        for (; maxValueIndex < array.Length; maxValueIndex++) {
            array[maxValueIndex] = avgArray;
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
        double avgArray = 0;
        double difference = 1000000;
        int pushIndex = 0;
        double [] newArray = new double[array.Length + 1];

        foreach (double item in array) {
            avgArray += item;
        }

        avgArray /= array.Length;
        
        for (int i = 0; i < array.Length; i++) {
            if (Math.Abs(array[i] - avgArray) < difference) {
                difference = Math.Abs(array[i] - avgArray);
                pushIndex = i;
            }
        }

        for (int i = 0; i <= pushIndex; i++) {
            newArray[i] = array[i];
        }

        newArray[pushIndex + 1] = P;

        for (int i = pushIndex + 1; i < array.Length; i++) {
            newArray[i + 1] = array[i];
        }
        
        // end

        return newArray;
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
        double minValue = 1000;
        double maxValue = 0;
        int maxValueIndex = 0;
        int minValueIndex = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxValue) {
                maxValue = array[i];
                maxValueIndex = i;
            }
        }

        for (int i = maxValueIndex; i < array.Length; i++) {
            if (array[i] < minValue) {
                minValue = array[i];
                minValueIndex = i;
            }
        }

        if (maxValueIndex != array.Length - 1) {
            array[maxValueIndex] = minValue;
            array[minValueIndex] = maxValue;
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
        double minValue = 1000;
        int minValueIndex = -1;
        double[] newArray = new double[array.Length - 1];

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > 0 && array[i] < minValue) {
                minValue = array[i];
                minValueIndex = i;
            }
        }

        if (minValueIndex == -1) {
            return array;
        }
        
        for (int i = 0; i < minValueIndex; i++) {
            newArray[i] = array[i];
        }
        for (int i = minValueIndex + 1; i < array.Length; i++) {
            newArray[i - 1] = array[i];
        }
        // end

        return newArray;
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
        double maxValue = double.MinValue;
        double sumAfterMaxValue = 0;
        int firstNegativeIndex = -1;
        int maxValueIndex = 0;

        for (int i = 0; i < array.Length; i++) {
            if (firstNegativeIndex == -1 && array[i] < 0) {
                firstNegativeIndex = i;
            }
            if (array[i] > maxValue) {
                maxValue = array[i];
                maxValueIndex = i;
            }
        }
        
        if (firstNegativeIndex == -1) {
            return array;
        }

        for (int i = maxValueIndex + 1; i < array.Length; i++) {
            sumAfterMaxValue += array[i];
        }

        array[firstNegativeIndex] = sumAfterMaxValue;

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
        int maxValueIndex = -1;
        int firstNegativeIndex = -1;
        double maxValue = double.MinValue;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxValue) {
                maxValue = array[i];
                maxValueIndex = i;
            }
            if (firstNegativeIndex == -1 && array[i] < 0) {
                firstNegativeIndex = i;
            }
        }

        if (maxValueIndex != -1 && firstNegativeIndex != -1) {
            double temp = array[maxValueIndex];
            array[maxValueIndex] = array[firstNegativeIndex];
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
        int count = 0;
        int index = 0;

        for (int i = 0; i < array.Length; i++) {
            sum += array[i];
        }

        double avg = sum / array.Length;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < avg) {
                count++;
            }
        }

        output = new int[count];

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < avg) {
                output[index++] = i;
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
        double maxEven = double.MinValue;
        double maxOdd = double.MinValue;
        
        // code here
        for (int i = 0; i < array.Length; i++) {
            if (i % 2 == 0) {
                if (array[i] > maxEven) {
                    maxEven = array[i];
                }
            } else {
                if (array[i] > maxOdd) {
                    maxOdd = array[i];
                }
            }
        }

        if (maxEven > maxOdd) {
            int mid = array.Length / 2;
            for (int i = 0; i < mid; i++) {
                array[i] = 0;
            }
        } else {
            int mid = array.Length / 2;
            for (int i = mid; i < array.Length; i++) {
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
        int firstNegativeIndex = -1;
        int minValueIndex = -1;
        double minValue = double.MaxValue;
        double sum = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0 && firstNegativeIndex == -1) {
                firstNegativeIndex = i;
            }
            if (array[i] < minValue) {
                minValue = array[i];
                minValueIndex = i;
            }
        }

        if (firstNegativeIndex != -1 && firstNegativeIndex < minValueIndex) {
            for (int i = 0; i < array.Length; i++) {
                if (i % 2 == 0) {
                    sum += array[i];
                }
            }
        } else {
            for (int i = 0; i < array.Length; i++) {
                if (i % 2 != 0) {
                    sum += array[i];
                }
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
        double maxValue = double.MinValue;
        int count = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxValue) {
                maxValue = array[i];
                count = 1;
            } else if (array[i] == maxValue) {
                count++;
            }
        }

        output = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] == maxValue) {
                output[index++] = i;
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
        double maxValue = array[0]; 
        double sumBeforeMax = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > maxValue) {
                maxValue = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++) {
            if (array[i] == maxValue) {
                array[i] = sumBeforeMax;
                sumBeforeMax += maxValue;
            }
            else {
                sumBeforeMax += array[i];
            }
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
        // code here
        double[] newArray = new double[array.Length];
        int newArrayLength = 0;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] >= 0) {
                newArray[newArrayLength] = array[i];
                newArrayLength++;
            }
        }
        
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                newArray[newArrayLength] = array[i];
                newArrayLength++;
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
        for (int i = array.Length / 2 - 1; i >= 0; i--) {
            array[2 * i + 1] = array[i]; 
            array[2 * i] = array[i];
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
        double[] uniqueArray = new double[array.Length];
        bool isCount = false;
        int uniqueCount = 0;

        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < uniqueCount; j++) {
                if (array[i] == uniqueArray[j]) {
                    isCount = true;
                    break;
                }
            }
            if (!isCount) {
                uniqueArray[uniqueCount] = array[i];
                uniqueCount++;
            }
            isCount = false;
        }

        double[] newArray = new double[uniqueCount];

        for (int i = 0; i < uniqueCount; i++) {
            newArray[i] = uniqueArray[i];
        }
        // end

        Console.WriteLine(string.Join(" ", newArray));

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
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


// TO DO: 
public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_3_6(new double[] { 3, 2, 1, 0, -1.1 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        //code here
        double S = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            S += array[i];
            S = Math.Round(S, 2);
        }

        for (int i = array.Length - 1; i >= 0; i--) { array[i] = array[i] / S; }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double avg = 0, s = 0;
        int n = 0;
        Console.WriteLine(array.Length);

        for (int i = 0; i <= array.Length - 1; i++)
        {
            if (array[i] > 0) { s += array[i]; n++; }
            Console.WriteLine(i);
        }
        
        avg = s / n;
        avg = Math.Round(avg, 2);
        Console.WriteLine(avg);
        for (int i = 0; i <= array.Length - 1; i++)
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double avg = 0, s = 0;

        for (int i = 0; i < array.Length; i++) s += array[i];
        
        avg = s / array.Length;

        for (int i = 0; i < array.Length; i++) array[i] -= avg;

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length ; i++)
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
        // end

        length = Math.Sqrt(length);
        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        double avg = s / array.Length;

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
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        double avg = s / array.Length;

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
        Console.WriteLine($"P:{P} Q:{Q}");
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]} ");
            if ((array[i] < Q) && (array[i] > P)) { count++; Console.WriteLine("+"); }
            
            //if (array[i] <= P || array[i] >= array[i])

        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int l = 0, j = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { l++; }
        }

        output = new double[l];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) { output[j] = array[i]; j++; }
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
            if (array[i] < 0) { value = array[i]; index = i;}
        }

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int j = 0, k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { even[k] = array[i]; k++; }
            else { odd[j] = array[i]; j++; }
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
            if (x[i] == 0) { y[i] = double.NaN; }
            else { y[i] = 0.5 * Math.Log(x[i], Math.Exp(1)); }
        }

        for (int i = 0; i < x.Length;i++)
        {
            Console.WriteLine($"{x} {y}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int min_el_ind = 0;
        double min_el = double.MaxValue;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_el) { min_el = array[i]; min_el_ind = i; }
        }

        if (array[min_el_ind] > 0) { array[min_el_ind] *= 2; }
        else { array[min_el_ind] = array[min_el_ind] / 2; }

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
        double min_el = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_el) min_el = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min_el) break;
            if (array[i] > 0) { array[i] = array[i] * 2; }
            else { array[i] /= 2 ; }
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
        double MinEl = double.MaxValue, MaxEl = double.MinValue;
        int MinElInd = 0, MaxElInd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < MinEl) { MinEl = array[i]; MinElInd = i; }
            if (array[i] > MaxEl) { MaxEl = array[i]; MaxElInd = i; }
        }
        
        int LenghtArray2 = 0;
        if (MinElInd < MaxElInd)
        {
            for (int i = MinElInd + 1; i < MaxElInd; i++)
            {
                if (array[i] < 0) { LenghtArray2++; Console.WriteLine(array[i]); }
            }
        }
        else
        {
            for (int i = MaxElInd + 1; i < MinElInd; i++)
            {
                if (array[i] < 0) { LenghtArray2++; Console.WriteLine(array[i]); }
            }
        }

        double[] array2 = new double[LenghtArray2];

        if (MinElInd < MaxElInd)
        {
            for (int i = 0, j = MinElInd + 1; i < array2.Length; j++)
            {
                if (array[j] < 0) { array2[i] = array[j]; i++; }
            }
        }
        else
        {
            for (int i = 0, j = MaxElInd + 1; i < array2.Length; j++)
            {
                if (array[j] < 0) { array2[i] = array[j]; i++; }
            }
        }

        if (array2.Length > 0) { array = array2; }
        else { array = new double[0]; }

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

        int maxElInd = 0;
        double maxEl = double.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl) { maxEl = array[i]; maxElInd = i; } 
        }

        if (maxElInd == array.Length - 1) array[maxElInd] *= 1;
        else
        {
            if (array[maxElInd + 1] > 0) { array[maxElInd + 1] *= 2; }
            else { array[maxElInd + 1] /= 2; }
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
        int maxElInd = 0, minElInd = 0;
        double maxEl = double.MinValue, minEl = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl) { maxEl = array[i]; maxElInd = i; }
            if (array[i] < minEl) { minEl = array[i]; minElInd = i; }
        }

        int cnt = 0;
        if (minElInd < maxElInd)
        {
            for (int j = minElInd + 1; j < maxElInd; j++)
            {
                average += array[j];
                cnt++;
            }
        }
        else
        {
            for (int j = maxElInd + 1; j < minElInd; j++)
            {
                average += array[j];
                cnt++;
            }
        }
        
        if (average != 0) { average /= cnt; }

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
        int lastPosInd = -1;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) lastPosInd = i;
        }

        if (lastPosInd != -1)
        {
        double[] array2 = new double[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = array[i];
        }
        for (int j = lastPosInd + 1; j < array.Length + 1; j++)
        {
            if (j == lastPosInd + 1) array2[j] = P;
            else array2[j] = array[j + 1];
        }
        
        array = array2;

        }
        
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

        double maxEl = double.MinValue;
        int maxElInd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > maxEl) { maxEl = array[i]; maxElInd = i; }
        }

        array[maxElInd] = maxElInd;

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
        if (k < A.Length)
        {
        output = new double[A.Length + B.Length];

        for (int i = 0; i < k + 1; i++) { output[i] = A[i]; }
        
        for (int i = k + 1; i < k + 1 + B.Length; i++) { output[i] = B[i - k - 1]; }
        
        for (int i = k + 1 + B.Length, j = k + 1; i < output.Length; i++) { output[i] = A[j]; j++; }
            
        }
        else { output = A; }

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
        double maxEl = double.MinValue, minEl = double.MaxValue;
        int maxElInd = 0, minElInd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl) { maxEl = array[i]; maxElInd = i; }
            if (array[i] < minEl) { minEl = array[i]; minElInd = i; }
        }

        double s = 0;
        int cnt = 0;
        if (maxElInd < minElInd)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { s += array[i]; cnt++; }
            }
            if (cnt > 0) average = s / cnt;
        }
        else
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { s += array[i]; cnt++; }
            }
            if (cnt > 0) average = s / cnt;
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
        double maxEl = double.MinValue, elSum = 0;
        int maxElInd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl) { maxEl = array[i]; maxElInd = i; }
            elSum += array[i];
        }

        if (maxEl > elSum) array[maxElInd] = 0;
        else array[maxElInd] *= 2;

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
        double maxEl = double.MinValue;
        int maxElInd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxEl) { maxEl = array[i]; maxElInd = i; }
        }

        double prevEl = 0;
        for (int i = 0; i < maxElInd; i+=2)
        {
            if (i + 1 == maxElInd) break;
            
            prevEl = array[i];
            array[i] = array[i + 1];
            array[i + 1] = prevEl;
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
    public int Task_3_6(double[] array)
    {
        int count = 0;

        // code here
        double prevEl = array[0];
        int prevCount = -1;

        count++;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < prevEl) { count++; }
            else
            {
                if (prevCount < count) { prevCount = count; }
                count = 1;
            }
            prevEl = array[i];
        }

        if (count < prevCount) count = prevCount;

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
        double prevEl = array[0];
        int prevCountDown = -1, prevCountUp = -1, currCountDown = 1, currCountUp = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < prevEl) { currCountDown++; }
            else
            {
                if (prevCountDown < currCountDown) { prevCountDown = currCountDown; }
                currCountDown = 1;
            }

            if (array[i] > prevEl) { currCountUp++; }
            else
            {
                if (prevCountUp < currCountUp) { prevCountUp = currCountUp; }
                currCountUp = 1;
            }

            prevEl = array[i];
        }

        if (currCountUp < prevCountUp) currCountUp = prevCountDown;
        if (currCountDown < prevCountDown) currCountDown = prevCountDown;

        if (currCountDown < currCountUp) count = currCountUp;
        else count = currCountDown;
        

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
        int negElCnt = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { negElCnt++; }
        }

        double[] array2 = new double[array.Length - negElCnt];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) { array2[j] = array[i]; j++; }
        }

        array = array2;

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

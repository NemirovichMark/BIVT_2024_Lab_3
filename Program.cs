using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double summ = 0;
        foreach (double element in array)
        {
            summ += element;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / summ, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        int c = 0;
        foreach (double element in array)
        {
            if (element > 0)
            {
                summ += element;
                c++;
            }
        }
        summ = summ / c;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(summ, 2);
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
        double summ = 0;
        foreach(double element in array)
        {
            summ += element;
        }
        summ /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - summ, 2);
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
        // end

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double element in vector)
        {
            length += element * element;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summ = 0;
        foreach (double element in array)
        {
            summ += element;
        }
        summ /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > summ) array[i] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double element in array)
        {
            if (element < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double summ = 0;
        foreach (double element in array)
        {
            summ += element;
        }
        summ /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > summ) count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double element in array)
        {
            if (element  > P && element < Q) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int c = 0;
        foreach (double item in array)
        {
            if (item > 0) c++;
        }
        output = new double[c];
        int alblack52 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[alblack52] = array[i];
                alblack52++;
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
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
                break;
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
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) even[i / 2] = array[i];
            else odd[i / 2] = array[i];
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
            else sum += array[i] * array[i];
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
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            int lengthXI = x[i].ToString().Length;
            string st = " ";
            for (int c = 0; c < 6 - lengthXI; c++)
            {
                st += " ";
            }

            Console.WriteLine($"{x[i]}{st}{y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double minn = double.MaxValue;
        foreach (double element in array)
        {
            if (element < minn) minn = element;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == minn)
            {
                array[i] = array[i] < 0 ? array[i] / 2 : array[i] * 2;
            }
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
        double minn = double.MaxValue;
        int minInd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i]; 
                minInd = i;
            }
        }
        for (int i = 0; i < minInd; i++)
        {
            if (array[i] > 0) array[i] *= 2;
            else array[i] /= 2;
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
        double minn = double.MaxValue, maxx = double.MinValue;
        int minI = 0, maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                minI = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
        }
        int rv;
        if (minI > maxI)
        {
            rv = maxI;
            maxI = minI;
            minI = rv;
        }
        minI++;
        int c = 0;
        for (int i = minI; i <= maxI; i++)
        {
            if (array[i] < 0)
            {
                c++;
            }
        }
        var res = new double[c];
        for (int i = 0; minI < maxI; minI++, i++)
        {
            if (array[minI] < 0)
            {
                res[i] = array[minI];
            }
        }
        array = res;
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
        double maxx = double.MinValue;
        int maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
        }
        if (maxI + 1 < array.Length)
        {
            if (array[maxI + 1] >= 0)
            {
                array[maxI + 1] *= 2;
            }
            else array[maxI + 1] /= 2;
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
        double minn = double.MaxValue, maxx = double.MinValue;
        int minI = 0, maxI = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                minI = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
        }
        if (minI == maxI + 1) return 0;
        int rv;
        if (minI > maxI)
        {
            rv = maxI;
            maxI = minI;
            minI = rv;
        }
        minI++;
        int cc = 0;
        for (; minI < maxI; minI++)
        {
            average += array[minI];
            cc++;
        }

        average /= cc;
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
        int ind = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                ind = i;
                break;
            }
        }
        double[] res = new double[array.Length + 1];
        if (ind < 0) res = array;
        else
        {
            for (int i = 0; i <= ind; i++)
            {
                res[i] = array[i];
            }
            res[ind + 1] = P;
            for (int i = ind + 1; i < array.Length; i++)
            {
                res[i + 1] = array[i];
            }
        }
        array = res;
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
        double maxx = double.MinValue;
        int maxI = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxx)
            {
                maxI = i;
                maxx = array[i];
            }
        }
        array[maxI] = maxI;
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
        if (k >= A.Length) return A;
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + i + 1] = B[i];
        }
        for (int i = 0; i < A.Length - k - 1; i++)
        {
            output[k + B.Length + i + 1] = A[k + i + 1];
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
        double minn = double.MaxValue, maxx = double.MinValue, sumO = 0, sumP = 0;
        int minI = -1, maxI = -1, co = 0, cp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minn)
            {
                minn = array[i];
                minI = i;
            }
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
            if (array[i] > 0)
            {
                sumP += array[i];
                cp++;
            }
            else
            {
                sumO += array[i];
                co++;
            }
        }
        if (maxI < minI)
        {
            if (cp == 0)
            {
                average = 0;
            }
            else average = sumP / cp;
        }
        else
        {
            if (co == 0)
            {
                average = 0;
            }
            else average =sumO / co;
        }
        average = Math.Round(average, 3);
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
        double maxx = double.MinValue, summ = 0;
        int maxI = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                maxI = i;
            }
            summ += array[i];
        }
        if (maxx > summ)
        {
            array[maxI] = 0;
        }
        else
        {
            array[maxI] *= 2;
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
        double maxx = array[0];
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxx)
            {
                maxx = array[i];
                c = 1;
            }
            else if (array[i] == maxx)
            {
                c++;
            }
        }
        output = new int[c];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
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
        // code here
        if (array.Length == 0)
        {
            return array;
        }
        double maxx = double.MinValue;
        foreach (double element in array)
        {
            if (element > maxx) maxx = element;
        }
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxx)
            {
                summ += array[i];
                array[i] = summ - array[i];
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
            int pI = 0 ,nI = 0;
            double[] oreshnik = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    oreshnik[pI++] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    oreshnik[pI + nI] = array[i];
                    nI++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = oreshnik[i];
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
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                c = i + 1;
            }
        }
        for (int i = c - 1; i >= 0; i--)
        {
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
        int n = 0; int p = 0;
        double[] newa = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            bool dubl = true;
            for (int j = 0; j < newa.Length; j++)
            {
                if (array[i] == newa[j])
                {
                    dubl = false;
                }
            }
            if (dubl == true)
            {
                newa[i] = array[i];
            }
        }
        for (int i = 0; i < newa.Length; i++)
        {
            if (newa[i] == 0 && newa[i] != array[i])
            {
                n++;
            }
        }
        double[] res = new double[newa.Length - n];

        for (int i = 0; i < newa.Length; i++)
        {
            if (newa[i] == array[i])
            {
                res[p] = newa[i];
                p++;
            }
        }
        array = res;
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
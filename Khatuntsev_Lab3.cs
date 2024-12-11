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
        program.Task_3_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here

        double cursum = 0.0;

        for (int i = 0; i < 6; i++)
        {
            cursum += array[i];
        }

        for (int i = 0; i < 6; i++)
        {
            array[i] = array[i] / cursum;
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        double cursum, curn;
        cursum = 0.0;
        curn = 0.0;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                cursum += array[i];
                curn++;
            }
        }

        double cursz = cursum / curn;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = cursz;
            }
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

        double cursum, curn;
        cursum = 0.0;
        curn = 0.0;

        for (int i = 0; i < 5; i++)
        {
            cursum += array[i];
            curn++;
        }

        double cursz = cursum / curn;

        for (int i = 0; i < 5; i++)
        {
            array[i] -= cursz;
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

        for (int i = 0; i < 5; i++)
        {
            length += vector[i] * vector[i];
        }

        length = Math.Sqrt(length);

        // end

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        double cursum, curn;
        cursum = 0.0;
        curn = 0.0;

        for (int i = 0; i < 7; i++)
        {
            cursum += array[i];
            curn++;
        }

        double cursz = cursum / curn;

        for (int i = 0; i < 7; i++)
        {
            if (array[i] > cursz)
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

        for (int  i = 0; i < 6; i++)
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

        double cursum, curn;
        cursum = 0.0;
        curn = 0.0;

        for (int i = 0; i < 8; i++)
        {
            cursum += array[i];
            curn++;
        }

        double cursz = cursum / curn;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > cursz)
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

        for (int i = 0; i < 10; i++)
        {
            if (P < array[i] && array[i] < Q)
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

        int curn = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                curn++;
            }
        }

        output = new double[curn];
        int curi = 0;

        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[curi] = array[i];
                curi++;
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

        for (int i = 0; i < 8; i++)
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

        int curi = 0;

        for (int i = 0; i < 10; i+=2)
        {
            even[curi] = array[i];
            odd[curi] = array[i+1];
            curi++;
        }

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        Console.WriteLine(array);

        int curi = 0;

        while (curi < 11 && array[curi] >= 0)
        {
            sum += array[curi]*array[curi];
            //Console.WriteLine(array[curi]);
            //Console.WriteLine(sum);
            curi++;
        }

        //Console.WriteLine(sum);

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here

        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
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

        double curmin = double.MaxValue;
        int curi = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < curmin)
            {
                curmin = array[i];
                curi = i;
            }
        }

        if (curmin >= 0)
        {
            curmin *= 2;
        }
        else
        {
            curmin /= 2;
        }

        array[curi] = curmin;

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

        double curmin = double.MaxValue;
        int curi = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < curmin)
            {
                curmin = array[i];
                curi = i;
            }
        }

        for (int i = 0; i < curi; i++)
        {
            if (array[i] >= 0)
            {
                array[i] = array[i] * 2;
            }
            else
            {
                array[i] = array[i] / 2;
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

        double curmin, curmax;
        curmin = double.MaxValue;
        curmax = double.MinValue;
        int curimin, curimax;
        curimin = -1;
        curimax = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < curmin)
            {
                curmin = array[i];
                curimin = i;
            }
            if (array[i] > curmax)
            {
                curmax = array[i];
                curimax = i;
            }
        }

        int curn = 0;
        int start, end;
        if (curimin < curimax)
        {
            start = curimin + 1;
            end = curimax;
        }
        else
        {
            start = curimax + 1;
            end = curimin;
        }

        for (int i = start; i < end; i++)
        {
            if (array[i] < 0)
            {
                curn++;
            }
        }


        double[] curarray = new double[curn];
        int curi = 0;

        for (int i = start; i < end; i++)
        {
            if (array[i] < 0)
            {
                curarray[curi] = array[i];
                curi++;
            }
        }

        array = curarray;

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

        double curmax = double.MinValue;
        int curi = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curi = i;
            }
        }

        if (curi < array.Length - 1)
        {
            if (array[curi + 1] >= 0)
            {
                array[curi + 1] = array[curi + 1] * 2;
            }
            else
            {
                array[curi + 1] = array[curi + 1] / 2;
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

        double curmin, curmax;
        curmin = double.MaxValue;
        curmax = double.MinValue;
        int curimin, curimax;
        curimin = -1;
        curimax = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < curmin)
            {
                curmin = array[i];
                curimin = i;
            }
            if (array[i] > curmax)
            {
                curmax = array[i];
                curimax = i;
            }
        }

        int curn = 0;
        int start, end;
        if (curimin < curimax)
        {
            start = curimin + 1;
            end = curimax;
        }
        else
        {
            start = curimax + 1;
            end = curimin;
        }

        int curlen = 0;

        for (int i = start; i < end; i++)
        {
            average += array[i];
            curlen++;
        }

        if (average != 0)
        {
            average /= curlen;
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

        int curi = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                curi = i;
            }
        }

        if (curi > 0) {

            double[] curarray = new double[array.Length + 1];

            for (int i = 0; i < curi + 1; i++)
            {
                curarray[i] = array[i];
            }
            curarray[curi + 1] = P;
            for (int i = curi + 1; i < array.Length; i++)
            {
                curarray[i + 1] = array[i];
            }

            //Console.WriteLine("[{0}]", string.Join(", ", array));
            //Console.WriteLine("[{0}]", string.Join(", ", curarray));

            array = curarray;
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

        double curmax = double.MinValue;
        int curi = -1;

        for (int i = 0; i < array.Length; i+=2)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curi = i;
            }
        }

        array[curi] = curi;

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
            int curi = k + 1;

            for (int i = 0; i < k + 1; i++)
            {
                output[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[curi] = B[i];
                curi++;
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                output[curi] = A[i];
                curi++;
            }
        }
        else
        {
            output = A;
        }

        Console.WriteLine("[{0}]", string.Join(", ", output));

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

        double curmin, curmax;
        curmin = double.MaxValue;
        curmax = double.MinValue;
        int curimin, curimax;
        curimin = -1;
        curimax = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < curmin)
            {
                curmin = array[i];
                curimin = i;
            }
            if (array[i] > curmax)
            {
                curmax = array[i];
                curimax = i;
            }
        }

        int curn = 0;

        if (curimax < curimin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    curn++;
                    average += array[i];
                    Console.WriteLine(array[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    curn++;
                    average += array[i];
                    Console.WriteLine(array[i]);
                }
            }
        }

        if (average != 0.0)
        {
            average = average / curn;
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

        double curmax = double.MinValue;
        int curi = -1;
        double cursum = 0.0;

        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curi = i;
            }
            cursum += array[i];
        }

        if( curmax > cursum )
        {
            array[curi] = 0;
        }
        else
        {
            array[curi] = array[curi] * 2;
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

        double curmax = double.MinValue;
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curn = 1;
                output = new int[] { i };
            }
            else if (array[i] == curmax)
            {
                curn++;
                int[] curoutput = new int[curn];
                for (int j = 0; j < output.Length; j++)
                {
                    curoutput[j] = output[j];
                }
                curoutput[curn - 1] = i;
                output = curoutput;
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

        int[] indexes = null;

        double curmax = double.MinValue;
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > curmax)
            {
                curmax = array[i];
                curn = 1;
                indexes = new int[] { i };
            }
            else if (array[i] == curmax)
            {
                curn++;
                int[] curindexes = new int[curn];
                for (int j = 0; j < indexes.Length; j++)
                {
                    curindexes[j] = indexes[j];
                }
                curindexes[curn - 1] = i;
                indexes = curindexes;
            }
        }

        double[] sums = new double[indexes.Length];

        for (int i = 0; i < indexes.Length; i++) 
        {
            double cursum = 0.0;
            for (int j = 0; j < indexes[i]; j++)
            {
                cursum += array[j];
            }
            sums[i] = cursum;
        }

        for (int i = 0; i < indexes.Length; i++)
        {
            array[indexes[i]] = sums[i];
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

        double[] otric = null;
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                curn++;
                if( otric != null)
                {
                    double[] curotric = new double[curn];
                    for (int j = 0; j < otric.Length; j++)
                    {
                        curotric[j] = otric[j];
                    }
                    curotric[curn - 1] = array[i];
                    otric = curotric;
                }
                else {
                    otric = new double[] { array[i] };
                }
            }
        }

        double[] curarray = new double[array.Length];
        int curi = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                curarray[curi] = array[i];
                curi++;
            }
        }
        if (otric != null)
        {
            for (int i = 0; i < otric.Length; i++)
            {
                curarray[curi] = otric[i];
                curi++;
            }
        }

        array = curarray;

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

        double[] curarray = new double[array.Length];

        for (int i = 0; i < array.Length / 2; i++)
        {
            curarray[i * 2] = array[i];
            curarray[i * 2 + 1] = array[i];
        }

        array = curarray;

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

        double[] curarray = new double[] { };
        int curn = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (curarray.Contains(array[i]) == false)
            {
                curn++;
                if (curarray != null)
                {
                    double[] curotric = new double[curn];
                    for (int j = 0; j < curarray.Length; j++)
                    {
                        curotric[j] = curarray[j];
                    }
                    curotric[curn - 1] = array[i];
                    curarray = curotric;
                }
                else
                {
                    curarray = new double[] { array[i] };
                }
                //Console.WriteLine("[{0}]", string.Join(", ", curarray));
            }
        }

        array = curarray;

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
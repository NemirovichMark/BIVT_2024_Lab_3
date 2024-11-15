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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (s != 0)

                array[j] = Math.Round(array[j] / s, 2);

            else
            {
                array[j] = 0;
            }
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double avg = 0;
        double s = 0;
        double count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
        }
        if (count > 0)
        {
            avg = s / count;
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > 0)
                array[j] = Math.Round(avg, 2);
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        if (count > 0)
        {
            avg = s / count;
        }

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
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        if (count > 0)
        {
            avg = s / count;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
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
        double s = 0;
        int k = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        if (k > 0)
        {
            avg = s / k;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg)
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
        double[] massiv = new double[array.Length];
        int count = 0; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                massiv[count] = array[i];
                count++; 
            }
        }
        output = new double[count];
        for (int i = 0; i < count; i++)
        {
            output[i] = massiv[i];
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
        int e = 0;
        int o = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[e] = array[i];
                e++;
            }
            else
            {
                odd[o] = array[i];
                o++;
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
            if (array[i] >= 0)
            {
                sum += Math.Pow(array[i], 2);
            }
            else
            {
                break;
            }
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
            if (x[i] != 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = Double.NaN;
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int index = 0;
        double mx = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                index = i;
            }
        }

        for (int j = 0; j < index; j++)
        {
            sum += array[j];
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
        int index = 0;
        double mx = 0;
        double s = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            if (array[i] > mx)
            {
                mx = array[i];
                index = i;
            }
        }
        avg = Math.Round(s / array.Length,2);
        for (int j = index + 1; j < array.Length; j++)
        {
            array[j] = avg;
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
        double min = 1000000000;
        double s = 0;
        double avg = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        avg = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - avg) < min)
            {
                min = Math.Abs(array[i] - avg);
                count = i;
            }
        }
        count++;
        double[] massiv = new double[array.Length + 1];
        for (int i = 0; i < massiv.Length; i++)
        {
            if (i < count) 
                massiv[i] = array[i];
            else
            {
                massiv[i] = P;
                break;
            }
        }
        for (int i = count + 1; i < massiv.Length; i++)
        {
            massiv[i] = array[i - 1];
        }
        array = massiv;
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
        double max = 0;
        int indexmax = 0;
        double min = 100000000;
        int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        for (int i = indexmax; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        array[indexmin] = max;
        array[indexmax] = min;
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
        double[] array1 = new double[array.Length - 1];
        double min = 1000000000;
        int indexmin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        if (indexmin == -1)
            return array;
        else
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexmin)
                {
                    array1[index] = array[i];
                    index++;
                }
            }
        }
        // end

        return array1;
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
        double max = -100;
        int indexmax = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        for (int i = indexmax + 1; i < array.Length; i++)
        {
            s += array[i];
            s = Math.Round(s, 2);
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = s;
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
        double max = -100;
        int indexmax = 0;
        double min = 0;
        int indexmin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                min = array[i];
                indexmin = i;
                break;
            }
        }
        if (indexmin == -1)
            return array;
        else
        {
            double n = array[indexmax];
            array[indexmax] = array[indexmin];
            array[indexmin] = n;
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
        double s = 0;
        double avg = 0;
        int j = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        avg = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
                count++;
        }
        output = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < avg)
            {
                output[j] = i;
                j++;
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
        double maxch = 0;
        double maxnech = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxch) 
                maxch = array[i];
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > maxnech)
                maxnech = array[i];
        }
        if (maxch > maxnech)
        {
            for (int i = 0; i < array.Length / 2; i++)
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

        // end

        return array;
    }
    public double Task_2_20(double[] array)
    {
        double sum = 0;

        // code here
        double otr = -10000000;
        int indexotr = 0;
        double min = 1000000;
        int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                indexotr = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        if (indexotr < indexmin)
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
        double max = -100000;
        int k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += k;
                k++;
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
        double[] chet = new double[(array.Length + 1) / 2];
        int chetindex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            chet[chetindex] = array[i];
            chetindex++;
        }
        for (int i = 0; i < chet.Length - 1; i++)
        {
            for (int j = 0; j < chet.Length - 1 - i; j++)
            {
                if (chet[j] > chet[j + 1])
                {
                    double n = chet[j];
                    chet[j] = chet[j + 1];
                    chet[j + 1] = n;
                }
            }
        }
        chetindex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = chet[chetindex];
            chetindex ++;

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
        int k = 0;
        int otrindex = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0) 
                k ++;
        }
        double[] otr = new double[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr[otrindex] = array[i];
                otrindex ++;
            }
        }
        for (int i = 0; i < otr.Length - 1; i++)
        {
            for (int j = 0; j < otr.Length - 1 - i; j ++)
            {
                if (otr[j] < otr[j + 1])
                {
                    double n = otr[j];
                    otr[j] = otr[j + 1];
                    otr[j + 1] = n;
                }
            }
        }
        otrindex = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                array[i] = otr[otrindex];
                otrindex ++;
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
        double max = -1000000;
        double min = 1000000;
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = a + i * h;
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > max) 
                max = Y[i];
            if (Y[i] < min) 
                min = Y[i];
        }
        globalMax = max;
        globalMin = min;
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
        double max = -1000000;
        double min = 1000000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) 
                max = array[i];
            if (array[i] < min)
                min = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
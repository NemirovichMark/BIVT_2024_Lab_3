using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        //program.Task_2_19(new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 });
        
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;
        for (int i=0; i< array.Length; i++)
        {
            s += array[i];
        }
        for (int j=0; j<array.Length; j++)
        {
            if (s != 0)
                array[j] = Math.Round(array[j] / s, 2);
            else
                array[j] = 0;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int m = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i]>0)
            {
                s += array[i];
                m += 1;
            }
        }
        for (int i = 0; i < 8; i++)
        {
            if (array[i]>0)
            array[i] = Math.Round(s / m, 2);
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0; i < first.Length; i++)
        {
            sum[i] =Math.Round( first[i] + second[i], 2);
            dif[i] =Math.Round( first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr=0, s=0;
        int m=0;
        for (int i=0; i < 5; i++)
        {
            s += array[i];
            m++;
        }
        sr =Math.Round( s / m,2);
        for (int i=0; i < 5; i++)
        {
            array[i] -= Math.Round(sr, 2);
            array[i] = Math.Round(array[i], 2);
        }
        
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0; i< vector1.Length;i++)
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
        for (int i=0; i < vector.Length;i++)
        {
            length += vector[i] * vector[i];
        }
        length=Math.Round(Math.Pow(length, 0.5),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double avg = 0;
        for (int i=0;i< array.Length; i++) avg += array[i];
        avg = Math.Round(avg / array.Length, 2);
        for (int i=0; i < array.Length; i++)
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
        for (int i=0;i<6;i++)
        {
            if (array[i] < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0, s = 0;
        int m = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
            m++;
        }
        sr = Math.Round(s / m, 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int k=0;
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] > 0)
                k++;
        }
        output = new double[k];
        k = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
                k++;
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
        for (int i = 8 - 1; i >= 0; i--)
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
        int k=0, l=0;
        for (int i=0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[l] = array[i];
                l++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i=0; i < 11; i++)
        {
            if (array[i] >= 0)
                sum += Math.Round(array[i] * array[i], 2);
            else break;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        //у = 0.5 * Math.Log(x); double.NaN
        for (int i = 0; i < 10; i++)
        {
            if (x[i] != 0)
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            else
                y[i]=double.NaN;
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double element = 10,k=0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] < element)
            {
                element = array[i];
                k = i;
            }
        }
        for (int i=0; i < array.Length; i++)
        {
            
            if (i==k)
                array[i] = array[i]*2;
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
        int k =0;
        double element = 10;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]<element)
            {
                element = array[i];
                k = i;
            }
        }
        for (int i=0; i<array.Length; i++)
        {
            if (i < k)
            {
                if (array[i] >= 0 )
                    array[i] *= 2;
                if (array[i] < 0 )
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

        int indMax = 0, indMin = 0;
        double elem_Max = array[0], elem_Min = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elem_Max)
            {
                indMax = i;
                elem_Max = array[i];
            }

            if (array[i] < elem_Min)
            {
                indMin = i;
                elem_Min = array[i];
            }
        }

        int cnt = 0;
        for (int k = Math.Min(indMax, indMin); k < Math.Max(indMax, indMin); k++)
        {
            if (array[k] < 0)
                cnt++;
        }

        int indNew = 0;
        double[] newArr = new double[cnt];
        for (int j = Math.Min(indMax, indMin) + 1; j < Math.Max(indMax, indMin); j++)
        {
            if (array[j] < 0)
            {
                newArr[indNew] = array[j];
                indNew++;
            }
        }
        // end

        return newArr;
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
        double ma = 0;
        int l = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > ma)
            {
                ma = array[i];
                l = i;
            }
        }
        for (int i=0; i< array.Length; i++)
        {
            if (i == l+1)
            {
                if (array[i] >0) array[i] *= 2;
                if (array[i] < 0) array[i] /= 2;
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
        int mi = 0, ma = 0;
        double l=0;
        double element = 10, element1 = -10;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < element)
            {
                element = array[i];
                mi = i;
            }
            if (array[i] > element1)
            {
                element1 = array[i];
                ma = i;
            }
        }
        for (int i=0; i < array.Length; i++)
        {
            if ((i > mi && i < ma) || (i < mi && i > ma)) 
            {   
                average += array[i];
                l++;
            }

        }
        if (l!=0) average = Math.Round(average / l, 2);
        else average =0;
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
        int k = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                k = i;
        }

        if (k == -1)
            return array;

        double[] newArr = new double[array.Length + 1];
        for (int j = 0; j < array.Length + 1; j++)
        {
            if (j < k + 1)
                newArr[j] = array[j];
            else if (k + 1 == j)
                newArr[j] = P;
            else
                newArr[j] = array[j - 1];
        }
        // end 

        return newArr;
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
        double element = 0;
        int k = 0;
        for (int i=0; i < array.Length; i+=2)
        {
            if (array[i] > element)
            {
                element = array[i];
                k = i;
            }
        }
        for (int i=0; i < array.Length; i += 2)
        {
            if (i == k)
            {
                array[i] = k;
            }
        }

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
        double[] output = new double[A.Length + B.Length];

        // code here
        if (k < 0)
            k = 0;

        k++;
        output = new double[A.Length + B.Length];

        for (int i = 0; i < A.Length; i++)
        {
            if (i < k)
                output[i] = A[i];
            else if (i == k)
            {
                for (int j = 0; j < B.Length; j++)
                    output[k + j] = B[j];
            }
            output[i + B.Length] = A[i];
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
        double mael = array[0], miel = array[0];
        int ma = 0, mi = 0;
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] < miel)
            {
                miel = array[i];
                mi = i;
            }
            if (array[i] > mael)
            {
                mael = array[i];
                ma = i;
            }
        }
        double ch = 0, nch = 0, zn = 0, nzn = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (ma < mi)
            {
                if (array[i] > 0) 
                {
                    ch += array[i];
                    zn++;
                }
            }
        }
        if (zn!=0) average = Math.Round(ch / zn, 2);
        for (int i=0; i<array.Length; i++)
        {
            if (ma > mi)
            {
                if (array[i] < 0) 
                {
                    nch += array[i];
                    nzn++;
                }
                
            }
        }
        if (nzn != 0) average = Math.Round(nch / nzn, 2);
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
        double elem = array[0], sum = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > elem)
            {
               
                elem = array[i];
                k = i;
            }
        }
        if (elem > sum)
        {
            array[k] = 0;
        }
        else if (sum > elem)
        {
            if (array[k] < 0)
            {
                array[k] /= 2;
            }
            else
            {
                array[k] *= 2;
            }
        }
        Console.WriteLine(array[k]);

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
        double  mael = array[0];
        int ma = 0, k=1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mael)
            {
                mael = array[i];
            }
        }
        for (int i=0; i< array.Length; i++)
        {
            if (array[i] == mael)
            {
                array[i]+=k;
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
        for (int i = 0; i < array.Length; i+=2)
        {
            for (int j=0; j< array.Length-2; j += 2)
            {
                if (array[j]> array[j+ 2])
                {
                    double temp = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = temp;
                }
            }
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
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] <0 && array[j]> array[i])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
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
        double globalMax = 0, globalMin = 0;

        // code here
        globalMax = double.MinValue; globalMin = double.MaxValue;
        X = new double[n]; Y = new double[n];
        double step = (b - a) / (n - 1);
        int k = 0;
        for (double i = a; i <= b; i += step)
        {
            double y =Math.Round( Math.Cos(i) + i * Math.Sin(i),2);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(y, 2);
            k++;

            if (y > globalMax)
                globalMax = y;

            if (y < globalMin)
                globalMin = y;
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
        double max_elem = array[0], min_elem = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_elem)
                min_elem = array[i];

            if (array[i] > max_elem)
                max_elem = array[i];
        }

        normalizedArray = new double[array.Length];
        for (int j = 0; j < array.Length; j++)
        {
            normalizedArray[j] = Math.Round(2 * (array[j] - min_elem) / (max_elem - min_elem) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
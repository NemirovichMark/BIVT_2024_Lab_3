using Microsoft.VisualBasic;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
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
        
        for (int i = 0; i < 6; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round((array[i] / s),2);
            
        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, sr = 0, count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count ++;
            }
        }
        sr = Math.Round((s / count), 2);
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        
        for(int i = 0; i < 4; i++)
        {
            sum[i] += Math.Round((first [i] + second [i]), 2);
            dif[i] += Math.Round(first[i] - second[i], 2);
        }
        
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0, sr = 0, count = 0;
        for (int i = 0; i < 5; i ++)
        {
            s += array[i];
            count ++;
        }
        sr = Math.Round((s/ count), 2);
        for (int i = 0; i < 5; i++)
        {
            array [i] = Math.Round(array[i] - sr, 2);
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
        product = Math.Round(product, 2);
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
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, sr = 0, count = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
            count++;
        }  
        sr = s / count;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
        
        for (int i = 0; i < 6; i++)
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
        double s = 0, sr = 0, c = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
            c++;
        }
        sr = s / c;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
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
        for (int i = 0; i < 10; i ++)
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
        int count = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            if (array [i] > 0)
            {
                count++;
            }
        }
        double[] result = new double[count];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                result[k] = array[i];
                k++;
            }
        }
        output = result;

        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 7; i >= 0; i--)
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
        int k = 0, d = 0;
        for(int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[d] = array[i];
                d++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        
        for (int i = 0; i < 11; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
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
        for (int i = 0; i < 10; i++)
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
        double amin = array[0];
        double imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
           if (imin == i)
           {
                if (array[i] < 0)
                {
                    array[i] /= 2;
                }
                else if (array[i] > 0)
                {
                    array[i] *= 2;
                }
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
        double amin = 15;
        int imin = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = imin - 1; i >= 0; i--)
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
        
        double amax = array[0], amin = array[0];
        int imax = 0, imin = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array [i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        int count = 0;
        for (int i = imin + 1; i < imax; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        double[] a = new double[count];
        for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                if ((i < imax && i > imin) || (i > imax && i < imin))
                {
                    a[k] = array[i];
                    k++;
                }
            }
            
        }
        array = a;
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
        double amax = 0;
        int imax = 0;
        for(int i = 0; i < array.Length; i ++)
        {
            if (array[i] > amax)
            {
                amax = array [i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length-1; i++)
        {
            if (i == imax + 1 && array[i] > 0)
            {
                array[i] *= 2;
            }
            else if (i == imax + 1 && array[i] < 0)
            {
                array[i++] /= 2;
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

        double amax = array[0], amin = array[0];
        int imax = 0, imin = 0;
        double s = 0;
        double count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
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
            if ((i < imax && i > imin) || (i > imax && i < imin))
            {
                s += array[i];
                count++;
            }
        }

        if (count > 0)
        {
            average = s / count;
        }
        else
        {
            average = 0;
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
        
        int ip = 0;
        for (int i = array.Length - 1; i >= 0 ; i--)
        {
            if (array[i] > 0)
            {
                ip = i;
                break;
            }
            else
            {
                return array;
            }
        }
        double[] a = new double[array.Length + 1];
        for (int i = 0; i <= ip; i++)
        {
            if (i <= ip)
            {
                a[i] = array[i];
            }
        }
        a[ip+1] = P;
        for (int i = ip+2; i< array.Length; i++)
        {
            a[i] = array[i];
        }
        array = a;

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
        double amax = -10;
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > amax)
                {
                   amax = array[i];
                   imax = i;
                }
            }
            
        }
        array[imax] = imax;
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

        double[] result;
        if (k >= A.Length || k < 0)
        {
            return A;
        }
        else
        {
            result = new double[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
             {
                 result[i] = A[i];       
             }              

            for (int i = 0; i < B.Length; i++)
            {
                 result[k + 1 + i] = B[i];
            }

            for (int i = k + 1; i < A.Length; i++)
            {
                 result[B.Length + i ] = A[i];
            }        
        }
        output = result;

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
        double amax = array[0], amin = array[0];
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }

        double s = 0, sum = 0;
        int count = 0, counto = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
            }
            else if (array[i] < 0)
            {
                sum += array[i];
                counto++;
            }
        }
          
        if ((imax < imin) && count > 0)
        {
            average = (double)s / count;
        }
        else if ((imax > imin )&& counto > 0) 
        {
            average = (double)sum / counto;
        }
        else if ((imax > imin) && counto == 0)
        {
            average = 0;
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
        double amax = -100;
        int imax = 0;
        double s = 0;
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
            s += array[i];
        }
        if (array[imax] > s)
        {
            array[imax] = 0;
        }
        else if (array[imax] < s) 
        {
            array[imax] *= 2;
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        
        double amax = array[0];
        int imax = 0;
        int count = 0;

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
            if (array[i] == amax)
            {
                count++;
                array[i] += count;
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
            if (i % 2 == 0)
            {
                for (int j = 0; j < array.Length - i - 2; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        double temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
            }
        }
        // end`

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

        double[] negatives = new double[array.Length];
        int negCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negatives[negCount] = array[i];
                negCount++;
            }
        }

        for (int i = 0; i < negCount - 1; i++)
        {
            for (int j = i + 1; j < negCount; j++)
            {
                if (negatives[i] < negatives[j])
                {   
                    double temp = negatives[i];
                    negatives[i] = negatives[j];
                    negatives[j] = temp;
                }
            }
        }

        int negIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = negatives[negIndex];
                negIndex++;
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
        double globalMax = -1000000, globalMin = 1000000;

        // code here
        X = new double[n]; 
        Y = new double[n];
        double step = (b - a) / (n - 1);
        int k = 0;
        double c = 0;
        for (double i = a; i <= b; i += step)
        {
            c = Math.Cos(i) + i * Math.Sin(i);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(c, 2);
            k++;

            if (c > globalMax)
                globalMax = c;

            if (c < globalMin)
                globalMin = c;
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
        double[] normalizedArray = new double[array.Length];

        // code here
        double amax = array[0], amin = array[0];
        int n = 0;
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
            }
            if (array[i] < amin)
            {
                amin = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            k = ((array[i] - amin) * 2 / (amax - amin)) - 1;
            normalizedArray[n] = Math.Round(k, 2);
            n++;
        }
        // end

        return normalizedArray;
    }
    #endregion
}


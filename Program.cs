using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
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
        for(int i = 0; i < 6; i++)
            s += array[i];
        for (int j = 0; j < 6; j++)
        {
            array[j] = array[j] / s;
            array[j] = Math.Round(array[j], 2);
        }
        // end

            return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, n = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                n++;
            }
        } 
        for( int j = 0;j < 8; j++)
        {
            if (array[j] > 0)
                array[j] = s / n;
            array[j] = Math.Round(array[j], 2);
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
            sum[i] = Math.Round(sum[i], 2);
            dif[i] = Math.Round(dif[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here\
        double s = 0;
        for (int i = 0; i < 5; i++)
            s += array[i];
        for(int j = 0; j < 5;j++)
        {
            array[j] -= (s / 5);
            array[j] = Math.Round(array[j], 2);
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
        // end
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double s = 0;
        // code here
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
        }
        for(int j = 0; j < 7; j++)
        {
            if (array[j] > (s / 7))
                array[j] = 0;      
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for(int i = 0; i < 6; i++)
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
        double s = 0;
        for( int i = 0; i < 8; i++)
            s += array[i];
        for( int j = 0; j < 8; j++)
        {
            if ((array[j] > (s / 8)))
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for(int i = 0; i < 10; i++)
        {
            if (array[i] < Q && array[i] > P)
                count++;
            
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int k = 0;
        // code here
        for (int i = 0; i < 10; i++)
            if (array[i] > 0)
                k++;
        output = new double[k];
        int n = 0;
        for(int i = 0; i < 10; i++)
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;
            }
        
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        // code here
        for(int i = 0; i < 8; i++)
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
        int n = 0;
        for(int i = 0; i < array.Length; i++)
            if(i % 2 == 1)
            {
                odd[n] = array[i];
                n++;
            }
        int k = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (i%2==0)
            {
                even[k] = array[i];
                k++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        Console.WriteLine(array);
        // code here
        int index = 0;
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                break;
            }
            else
                index = 11;
                
                
            //Console.WriteLine($"{index} {array[i]}");
        }
        for (int j = 0; j < index; j++)
        {
            Console.WriteLine($"{sum} {array[j]}");
            sum += array[j] * array[j];
        }
            
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i =0; i<x.Length; i++)
        {
            if (x[i] == 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            Console.WriteLine($"{x[i]} {y[i]}");
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
        double max = 0;
        int index = 0;
        // code here
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for(int i =0; i< index; i++)
            sum += array[i];
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
        double max = 0, sum = 0;
        int index = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
            sum += array[i];
        }
        double sred = sum / array.Length;
        sred = Math.Round(sred, 2);
        for(int i = index+1; i < array.Length; i++)
        {
            array[i] = sred;
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
        double sum = 0, razn = 10000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
            sum += array[i];
        double sred = sum/array.Length;
        sred = Math.Round(sred, 2);
        for(int i = 0; i < array.Length;i++)
        {
            if (Math.Abs(array[i] - sred) < razn)
            {
                razn = Math.Abs(array[i] - sred);
                index = i;
            }
                
        }
        double[] array1 = new double[array.Length + 1];
        int k = index + 1;
        for (int i = 0; i <= index; i++)
            array1[i] = array[i];
        array1[index + 1] = P;
        for (int i = index + 2; i < array.Length+1; i++)
        {
            array1[i] = array[k];
            k++;
        }
        array = array1;
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
        double max = 0, min = 10000;
        int index1 = 0, index2 = 0;
        for(int i = 0; i<array.Length;i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index1 = i;
            }
        }
        for (int i = index1;i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index2 = i;
            }
        }
        array[index1] = min;
        array[index2] = max;
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
        double min = 1000;
        int index = 0;
        int n = 0;
        for(int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
                n++;
        }
        if (n == 0)
            return array;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min && array[i] > 0)
            {
                index = i;
                min = array[i];
            }
                
        }

        double[] array1 = new double[array.Length-1];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(i != index)
            {
                array1[k] = array[i];
                k++;
            }
        }
        array = array1;
       
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
        double sum = 0, max = -1000;
        int index2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index2 = i;
            }
                
        }
        for (int j = index2 + 1; j < array.Length; j++)
        {
            sum += array[j];
           
        }
        sum = Math.Round(sum,2);
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < 0)
            {
                array[k] = sum;
                break;
            }
        }
        
        //array[index1] = sum;
        Console.WriteLine($"{max} {index2} {sum}");
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
        double max = -1000, otr = 0;
        int index1 = 0, index2 = 0;
        int k = 0;
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        if (k == 0)
            return array;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
            {
                max = array[i];
                index1 = i;
            }
        for(int i = 0; i < array.Length; i++)
            if(array[i] < 0)
            {
                otr = array[i];
                index2 = i;
                break;
            }
        array[index1] = otr;
        array[index2] = max;
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
        //int[] output = null;

        // code here
        double sred = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
            sred += array[i];
        sred /= array.Length;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < sred)
            {
                //output[k] = i;
                k++;
            }
        int[] output = new int[k];
        int n = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < sred)
            {
                output[n] = i;
                n++;
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
        double m1 = 0, m2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
                if (array[i] > m1)
                    m1 = array[i];
            if (i % 2 == 1)
                if (array[i] > m2)
                    m2 = array[i];
        
        }
        if(m1 > m2)
        {
            for (int i = 0; i < array.Length / 2; i++)
                array[i] = 0;

        }
        else
        {
            for (int i = array.Length/2; i < array.Length; i++)
                array[i] = 0;
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
        int index1 = 0; int index2 = 0;
        double min = 1000000;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                index1 = i;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < 0)
            {
                index2 = i;
                break;
            }
        int k = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < 0)
                k += 1;
        if (k == 0)
            return 0;
        if (index1 > index2)
        {
            for (int i = 0; i < array.Length; i+=2)
                sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i+=2)
                sum += array[i];
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] a = new int[array.Length];
        int k = 0;
        double m = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > m)
            {
                m = array[i];
                k = 0;
            }
            if (array[i] == m)
            {
                a[k] = i;
                k++;
            }
            
               
        }
        int[] b = new int[k];
        for (int i = 0; i < k; i++)
        {
            b[i] = a[i];
        }
        // end
        return b;
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
        double[] temp = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }
        double max = -100000; int schet_maxim = 0; double sum_temp = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) 
                max = array[i];

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                for (int g = 0; g < i; g++)
                {
                    sum_temp += temp[g];
                    Console.WriteLine(array[g]);
                }
                array[i] = sum_temp;
                sum_temp = 0;
            }

        }
        return array;
        //end
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
        int k = 0;
        // code here
        double[] output = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        // end

        return output;
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
        int k = 0;
        double[] output = new double[array.Length];
        for(int i  = 0; i < array.Length/2; i++)
        {
            output[k] = array[i];
            k++;
            output[k] = array[i];
            k++;
        }
        // end

        return output;
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
        int k1 = 0; int k2 = 0;
        double[] array2 = new double[array.Length];
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            bool check = true;
            for (int j = 0; j < array2.Length; j++)
            {
                if (array[i] == array2[j])
                {
                    check = false;
                }
            }
            if (check == true)
            {
                array2[i] = array[i];
            }
        }
        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] == 0 && array2[i] != array[i])
            {
                k1++;
            }
        }
        double[] output = new double[array2.Length - k1];

        for (int i = 0; i < array2.Length; i++)
        {
            if (array2[i] == array[i])
            {
                output[k2] = array2[i];
                k2++;
            }
        }
        return output;
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
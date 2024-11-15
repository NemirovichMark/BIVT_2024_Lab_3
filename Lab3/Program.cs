using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
     // program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < 6; i++)
        {
            sum = sum + array[i];
        }

        for (int i = 0; i < 6; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }


        // end      

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                sum = sum + array[i];
                k++;
                
            }
        }

        sum=Math.Round(sum/k, 2);

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sum;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0; i<4; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
        }
        for (int i=0;i<4; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        int k = 0;
        for (int i=0; i<5; i++)
        {
            sum = sum +array[i];
            k++;
        }
        sum = Math.Round(sum / k, 2);
        for (int i=0; i<5;i++)
        {
            array[i] = Math.Round(array[i] - sum, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0; i<4; i++)
        {
            product+=vector1[i]*vector2[i]; 
        }
       product = Math.Round(product,2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        double sum = 0;
        // code here
        for (int i=0; i<5; i++)
        {
            sum += vector[i] * vector[i];
        }
        length=Math.Round(Math.Sqrt(sum),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int k = 0;
        for (int i=0; i<7;i++)
        {
            sum += array[i];
            k++;
        }
        sum= Math.Round(sum/k,2);
        for (int i=0; i<7;i++)
        {
            if (array[i]>sum)
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
        for (int i=0; i<6; i++)
        {
            if (array[i]<0)
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
        int k = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
            k++;
        }
        sum = Math.Round(sum / k, 2);
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
        for (int i=0; i<10; i++)
        {
            if (array[i]>P && array[i]<Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        // code here
        int len = 0;
        int ind = 0;
        for (int i=0;i<10;i++)
        {
            if (array[i]>0)
            {
                len++;
            }
        }
        double[] output = new double[len];
        for (int i=0;i<array.Length; i++)
        {
            if (array[i]>0)
            {
                output[ind] = array[i];
                ind++;
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
        for (int i=0; i<8; i++)
        {
            if (array[i]<0)
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
        int k1 = 0;
        int k2 = 0;
        for (int i=0; i<10; i++)
        {
            if (i%2==0)
            {
                even[k1]= array[i];
                k1++;
            }
            if (i%2!=0)
            {
                odd[k2]= array[i];
                k2++;
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
            if (array[i] < 0) break;
            if (array[i] > 0)
            {
                sum += array[i] * array[i];
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i=0; i<10; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN; // не число
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
 
            }
        Console.WriteLine($"{x[i]} + {y[i]}");
           
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int Min = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] < array[Min])
            {
                Min = i;
            }
        }
        array[Min] *= 2;
        
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
        int Min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Min])
            {
                Min = i;
            }
        }
        for (int i = 0; i<Min; i++)
        {
            if (array[i]>0)
            {
                array[i] *= 2;
            }
            if (array[i]<0)
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
        int Min = 0;
        int Max = 0;
        int N = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Min])
            {
                Min = i;
            }
            if (array[i] > array[Max])
            {
                Max = i;
            }
        }
        for (int i = Min + 1; i < Max; i++)
        {
            if (array[i]<0)
            { 
                array[N]= array[i];
                N++;
            }
        }
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
        int Max = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > array[Max])
            {
                Max = i;
            }
        }
        if (Max+1 < array.Length)
        {
            if (array[Max+1]>0)
            {
                array[Max+1] *= 2;
            }
            else
            {
                array[Max+1] /= 2;
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
        int Min = 0;
        int Max = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Min])
            {
                Min = i;
            }
            if (array[i] > array[Max])
            {
                Max = i;
            }
        }
        int k = 0;
        double sum = 0;
        for (int j=Math.Min(Min, Max)+1; j< Math.Max(Min, Max); j++)
        {
            sum+= array[j];
            k++;
        }
        if (k == 0) return 0;
        sum = Math.Round((sum / k), 2);
        average = sum;
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
        int last= -1;
        double[] newArray = new double[array.Length + 1];

        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
            {
                last = i;
            }
        }
        if (last== -1)
        {
            return array;
        }
        for (int i = 0; i <= last; i++)
        {
            newArray[i] = array[i];
            newArray[last + 1] = P;
        }
        for (int i = last + 1; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
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
        int Max = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (i%2==0)
            {
                if (array[i]>array[Max])
                {
                    Max = i;
                }
            }
        }
        array[Max] = Max;
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
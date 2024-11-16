using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        // code here
        for(int i = 0; i < 6;i++)
        {
            sum += array[i];
        }
        for(int i = 0;i<6;i++)
        {
            array[i] /= sum;
            array[i] = Math.Round(array[i], 2);
        }
        
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0;
        double sum = 0;
        int count = 0;
        for(int i = 0; i <8;i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        sr = Math.Round((sum / count),2);
        for(int i = 0;i<8;i++)
        {
            if(array[i]> 0)
                array[i] = sr;
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        
        // code here
        for (int i = 0; i < 4; i++)
            sum[i] = Math.Round(first[i] + second[i],2);
        for (int i = 0;i<4;i++)
            dif[i] = Math.Round(first[i]-second[i],2);
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sr = 0;
        double sum = 0;
        double count = 0;
        // code here
        for(int i = 0; i< 5;i++)
        {
            sum += array[i];
            count++;
        }
        sr = Math.Abs(sum / count);
        
        for(int i =0; i<5;i++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i],2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        double[] sum = new double[2];
        // code here
        for(int i = 0;i<4;i++)
        {
            product +=(vector1[i]*vector2[i]);
            product = Math.Round(product,2);

        }

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int i = 0;i<5;i++)
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
        double sr = 0;
        double sum = 0;
        double count = 0;
        for(int i = 0;i<7;i++)
        {
            sum += array[i];
            count++;
        }
        sr = sum / count;
        for(int i = 0; i<7;i++)
        {
            if(array[i] > sr)
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
        for(int i = 0; i<6;i++)
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
        double sr = 0;
        double sum = 0;
        double count2 = 0;
        // code here
        for(int i = 0; i<8;i++)
        {
            sum += array[i];
            count2++;
        }
        sr = sum / count2;
        for(int i = 0; i<8;i++)
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
        for(int i = 0;i<10;i++)
        {
            if ((array[i]<Q) && (array[i] >P))
                count++;
        }

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int count = 0;
        // code here
        for(int i = 0;i<10;i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        int k = 0;
        for (int i = 0; i < 10; i++)
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
        int count = 0;
        // code here
        for(int i= 0;i<8;i++)
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
        int k = 0;
        int m = 0;
        for(int i = 0;i<10;i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[m] = array[i];
                m++;
            }
        }

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int i = 0;
        while (i < 11 && array[i] >= 0)
        {
            sum += array[i] * array[i];
            i++;
        }

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        
        for(int i = 0;i<10;i++)
        {
            if (x[i] == 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E),2);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = 10000*10000;
        int indexmin = 0;
        for(int i = 0;i<array.Length;i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        if (array[indexmin] > 0)
            array[indexmin]*=2;
        else
            array[indexmin] /= 2;
      
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
        double min = 1000000;
        int indexmin = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        for(int i = 0;i<indexmin;i++)
        {
            if (array[i] >= 0)
                array[i] = array[i] * 2;
            else
                array[i] = array[i] /= 2;
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
        double max = -100000; int indexmax = 0;
        double min = 1000000;int indexmin = 0;
        for(int i =0;i<array.Length;i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
            else if(array[i]<min)
            {
                min =array[i];
                indexmin = i;
            }
        }
        int k = 0;
        int indexmins =Math.Min(indexmax, indexmin);
        int indexmaxe = Math.Max(indexmin, indexmax);
        for(int i = indexmins + 1;i<indexmaxe;i++)
        {
            if (array[i] < 0)
                k++;
        }
        double[] newarray = new double[k];
        int index2 = 0;
        for(int i = indexmins + 1;i < indexmaxe;i++)
        {
            if (array[i] < 0)
            {
                newarray[index2] = array[i];
                index2++;
            }
        }
      
        // end

        return newarray;
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
        double max = -1000000;
        int indexmax = -1;
        for(int i = 0;i<array.Length;i++)
        {
            if (array[i] > max)
            {
                max=array[i];
                indexmax = i;
            }
        }
        if (indexmax == array.Length-1)
        {
            return array;
        }
        else if (array[indexmax + 1] > 0)
            array[indexmax + 1] *= 2;
        else if (array[indexmax + 1] < 0)
            array[indexmax + 1] /= 2;
       

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
        double sum = 0;
        int count = 0;
        // code here
        double max =-10000;int indexmax = 0;
        double min = 10000;int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        int indexmins = Math.Min(indexmax, indexmin);
        int indexmaxe = Math.Max(indexmin, indexmax);
        for(int i = indexmins + 1;i< indexmaxe;i++)
        {
            sum+= array[i];
            count++;
        }
        if (indexmins + 1 == indexmaxe)
            return 0;
        else

            average =sum/count;
        
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
        int ilast = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                ilast = i;
                break;
            }
        }
        if (ilast == -1)
        {
            return array;
        }
        double[] b = new double[array.Length + 1];
        for (int i = 0; i <= ilast; i++)
        {
            b[i] = array[i];
        }
        b[ilast + 1] = P;
        for (int i = ilast + 1; i < array.Length; i++)
        {
            b[i + 1] = array[i];
        }
        array = b;


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
        double max = -100000;
        int indexmax = 0;
        for(int i =0;i<array.Length;i+=2)
        {
          if(array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        array[indexmax] = indexmax;

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
        if (k >= A.Length)
        {
            return A;
        }
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + 1 + i] = B[i];
        }
        for (int i = k + 1; i < A.Length; i++)
        {
            output[B.Length + i] = A[i];
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
        double max = -1000;
        int indexmax = 0;
        double min = 1000000;
        int indexmin = 0;
        double sum = 0;
        int count = 0;
        double sr = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            if(array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
       if(indexmax < indexmin)
        {
            for(int i = 0; i<array.Length;i++)
            {
                if(array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
           
        }
        else if(indexmin < indexmax)
        {
            for (int i = 0;i<array.Length ; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                    count++;
                }
            }
           
        }
        if (count == 0)
            return 0;
        sr = Math.Round(sum / count,3);
        
        // end

        return sr;
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
        double max = -100000;
        int indexmax = 0;
        double sum = 0;
        for(int i = 0;i < array.Length;i++)
        {
            sum += array[i];
        }
        for(int i =0;i<array.Length;i++)
        {
            if(array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        for(int i = 0; i<array.Length;i++)
        {
            if(max>sum)
            {
                array[indexmax]=0;
            }
            else if(max<sum)
            {
                if (max>0)
                    array[indexmax] = max * 2;
                else if (max<0)
                    array[indexmax] = max /2;
            }
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


        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here
        double maxel = -100000000;
        int indma = -1;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        for (int i = 0; i < indma - 1;i+=2)
        {
            double t = array[i];
            array[i] = array[i + 1];
            array[i + 1] = t;
           
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

        int sch = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1]) sch++;
            else
            {
                if (sch > count) { count = sch; }
                sch = 1;
            }
        }
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
        
        int ind = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1])
                ind++;
            else
            {
                count = Math.Max(count, ind);
                ind = 1;
            }
        }
        count = Math.Max(count, ind);
        ind = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
                ind++;
            else
            {
                count = Math.Max(count, ind);
                ind = 1;
            }
        }
        count = Math.Max(count, ind);
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
        int k = 0;
        for (int i = 0; i < array.Length; i = i + 1)
        {
            if (array[i] >= 0)
                k ++;
        }
        double[] a = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i = i + 1)
        {
            if (array[i] >= 0)
            {
                a[k] = array[i];
                k = k + 1;
            }
        }
        array = a;
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
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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
        foreach (double elem in array)
        { 
            s+= elem;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i]/=s;
            Math.Round(array[i],2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0,sr=0;
        int k = 0;
        foreach (double elem in array)
        {
            if (elem > 0)
            {
                s += elem;
                k++;
            }
        }
        sr = Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < first.Length; i++)
        { 
            sum[i] = first[i]+second[i];
            dif[i] = first[i]-second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0,sr=0;
        int k = 0;
        foreach (double elem in array)
        {
            s += elem;
            k++;
        }
        sr=Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= sr;
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

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double s = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            s += vector[i] * vector[i];
           
        }
        length = Math.Sqrt(s);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0, sr = 0;
        int k = 0;
        foreach (double elem in array)
        {
            s += elem;
            k++;
        }
        sr=Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                array[i] = 0;

        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        
        foreach (double elem in array)
        {
            if (elem < 0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0, sr = 0;
        int k = 0;
        foreach (double elem in array)
        {
            s += elem;
            k++;
        }
        sr = Math.Round(s / k, 2);
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] >P)&& array[i]<Q)
                count++;

        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach (double elem in array)
        {
            if (elem > 0)
                count++;
        }
        output =new double[count];
        for (int i = 0,j=0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j++] = array[i];
                
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            { 
                value=array[i];
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
        for(int i=0,j=0,k=0;i<array.Length; i++)
        { 
            if(i%2==0)
                even[j++] = array[i];
            else
                odd[k++] = array[i];

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
                sum += array[i] * array[i];
            else
                break;

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
            if (x[i]<=0)
                y[i] = double.NaN;
            else
                y[i] = 0.5*Math.Log(x[i],double.E);
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine(x[i] + "   " + y[i]);
        }
            // end

            return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = double.MaxValue;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        if (array[index] >= 0)
            array[index] *= 2;
        else
            array[index] /= 2;
       
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
        double min = double.MaxValue;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index; i++)
        {
            if (array[i] >= 0)
                array[i] *= 2;
            else
                array[i] /= 2;
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
        int indexmin= -1,indexmax=-1,count=0;
        double max = double.MinValue;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (indexmin < indexmax)
        {
            var p = indexmin;
            indexmin = indexmax;
            indexmax =p;
        }
        for (int i = indexmax + 1; i < indexmin; i++)
        {
            if (array[i] < 0)
                count++;
        }
        double[] output=new double[count];
        for (int i = indexmax + 1,j=0; i < indexmin; i++)
        {
            if (array[i] < 0)
                output[j++]=array[i];
            
        }

        return output;
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
        int indexmax = -1;
        double max = double.MinValue;
      
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (indexmax + 1 < array.Length)
        {
            if (array[indexmax + 1] >= 0)
                array[indexmax + 1] *= 2;
            else
                array[indexmax + 1] /= 2;

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
        int indexmin = -1, indexmax = -1, count = 0;
        double max = double.MinValue,sum=0;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (indexmax < indexmin)
        {
            var p = indexmax;
            indexmax = indexmin;
            indexmin = p;
        }
        for (int i = indexmin+1; i < indexmax; i++)
        { 
            sum+= array[i];
            count++;
        }
        if (count == 0)
            return 0;
        average = sum/count;
        Console.WriteLine(average);
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
        int indexpos = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>0)
            {
                indexpos = i;
            }
            
        }
        double[] copy=new double[array.Length+1];
        for (int i = 0; i <= indexpos; i++)
        {
            copy[i] = array[i];
        }
        if (indexpos == -1)
            return array;
        if (indexpos == array.Length)
        {
            copy[indexpos + 1] = P;
            return copy;
        }
        copy[indexpos+1] = P;
        for (int i = indexpos + 2; i < copy.Length; i++)
            copy[i] = array[i - 1];
        // end

        return copy;
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
        int index = -1;
        double max = double.MinValue;
        for ( int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max=array[i];
                    index = i;
                
                }
            }

        }
        
        array[index] = index;
        
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
        if (k >= A.Length)
            return A;
        output = new double[A.Length + B.Length];
        for(int i=0;i<=k;i++)
            output[i]= A[i];    
        for (int i=k+1,j=0;i<k+1+B.Length;i++)
            output[i]= B[j++];  
        for(int i=k+1+B.Length,j=k+1;i<output.Length;i++)
            output[i]= A[j++];
        
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
        int indexmin = -1, indexmax = -1, count = 0;
        double max = double.MinValue, sum = 0;
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (indexmax < indexmin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            
        }
        if (indexmax > indexmin)
        {
            for (int i = 0; i < array.Length; i++)
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
        average = sum / count;
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
        int indexmax = -1;
        double max = double.MinValue, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (max > sum)
            array[indexmax] = 0;
        else
        {
            if (array[indexmax] >= 0)
                array[indexmax] *= 2;
            else
                array[indexmax] /= 2;

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
        int indexmax = -1;
        double max = double.MinValue, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        if (indexmax == 0)
            return array;
        for (int i = 0; i < indexmax; i += 2)
        {
            if (i + 1 != indexmax)
            {
                var p = array[i];
                array[i]=array[i+1];
                array[i+1]=p;
            }
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
        int len = 1;
        int maxlen=1;
        // code here
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1])
                len++;
            
           
            else
            {
                if (len > maxlen)
                    maxlen = len;
                len = 1;
                
            }
        
        }
        if (maxlen < len)
        {
            maxlen = len;
        }

        count = maxlen;
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
        int len = 1;
        int maxlen = 1;
        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if ((array[i] > array[i + 1]))
                len++;


            else
            {
                if (len > maxlen)
                    maxlen = len;
                len = 1;

            }

        }
        len = 1;
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            if ((array[i] < array[i + 1]))
                len++;


            else
            {
                if (len > maxlen)
                    maxlen = len;
                len = 1;

            }

        }
        if (maxlen < len)
        {
            maxlen = len;
        }

        count = maxlen;
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
        int count = 0;
        foreach (double elem in array)
        {
            if (elem < 0)
                count++;
        }
        double[] copy= new double[array.Length-count];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
                copy[j++] = array[i];
        }
        // end
        array = copy;
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
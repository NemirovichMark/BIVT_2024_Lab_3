using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        // code hereз
        
        double sum=0;
        for (int i=0; i<array.Length; i++)
        {
            sum=sum + array[i];
        }
        for(int i=0; i<array.Length; i++)
        {
            array[i]/=sum;
            array[i] = Math.Round(array[i], 2);
            
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr= 0;
        double count =0;
        for (int i =0; i < array.Length; i++)
        {
            if ( array[i]>0 )
            {
                sr+= array[i];
                count ++;
            }
        }
        sr = Math.Round(sr/count, 2);
        for (int i =0; i < array.Length; i++)
        {
            if ( array[i]>0 )
            {
                array[i]=sr;
            }
    
            
        }
        
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i =0; i<sum.Length; i++)
        {
            sum[i] = Math.Round(first[i]+second[i], 2);
            dif[i]= Math.Round(first[i]-second[i], 2);
        }
        // end
        
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr =0;
        for (int i =0; i<array.Length; i++)
        {
            sr+=array[i];
        }
        sr=Math.Round(sr/5, 2);
        for(int i =0; i<array.Length; i++)
        {
            array[i]=Math.Round(array[i]-sr, 2);
        }
        
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double [] pip = new double [4] ;
        for (int i = 0; i<4; i++)
        {
            pip[i] = vector1[i]*vector2[i];
        }
        for (int i = 0; i <4; i++)
        {
            product += pip[i];
        }
        product= Math.Round(product, 2);
        // end
        

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i =0; i<vector.Length; i++)
        {
            length= length+vector[i]*vector[i];
        }
        length=Math.Round(Math.Sqrt(length),2);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr=0;
        int count=0;
        for (int i=0; i<7; i++)
        {
            sr+=array[i];
            count++;
        }
        sr =sr/count;
        for (int i=0; i<7; i++)
        {
            if (array[i]>sr)
            {
                array[i]=0;
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
        double sr=0;
        int y=0;
        for (int i=0; i<7; i++)
        {
            sr+=array[i];
            y++;
        }
        sr =sr/y;
        for (int i=0; i<8; i++)
        {
            if (array[i]>sr)
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
            if (P<array[i] && Q>array[i])
            {
                count++;
            }
            
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        //double[] output = null;

        // code here
        int count =0;
        int j = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]>0)
            {
                count++;
            }
        }
        double[] output = new double[count];
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
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
        for (int i =0;i<array.Length; i++)
        {
            if (array[i]< 0)
            {
                index = i;
                value = array[i];
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
        int k1=0;
        int k2=0;
        for ( int i=0; i<array.Length; i++)
        {
        if (i%2==0)
        {
            even[k1]=array[i];
            k1++;
        }
        else
        {
           odd[k2]=array[i];
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
        for ( int i=0; i<array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum+= array[i]*array[i];
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
        for ( int i=0; i<x.Length; i++)
        {
            if (x[i]<=0)
            {
                y[i]=double.NaN;
            }
            else
            {
                y[i]=Math.Round(0.5*Math.Log(x[i]),2);
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
        double min=10;
        int k=0;
        for ( int i=0; i<array.Length; i++)
        {
            if (array[i]<min)
            {
                min=array[i];
                k = i;
            }  
        }
        array[k]*=2;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double min=10;
        int count =0;
        for ( int i =0; i<array.Length; i++)
        {
            if ( array[i]< min)
            {
                min=array[i];
                count =i;
            }
        }

        for (int i =0; i<count; i++)
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
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double min=1000;
        double max=-1000;
        int nmax=0; 
        int nmin=0;
        int countotr=0;
        for ( int i =0; i<array.Length; i++)
        {
            if ( array[i]< min)
            {
                min=array[i];
                nmin =i;
            }
            if (array[i]>max)
            {
                max=array[i];
                nmax =i;
            }
        }
        
        double [] nov = new double[array.Length]; 

        for (int i = nmin+1; i<nmax; i++)
        {
            if (array[i]<0)
            {
                nov[countotr]=array[i];
                countotr++;
            }
        }
        array = new double[countotr];
        array = nov;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        
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
        double max=-100;
        int nmax =100;
        for ( int i =0; i<array.Length; i++)
        {
            if ( array[i]>max)
            {
                max=array[i];
                nmax =i;
            }
        }
        if (nmax!=array.Length-1)
        {
            if (array[nmax+1] >0)
            {
                array[nmax+1]*=2;
            }
            else
            {
                array[nmax+1]/=2;
            }
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double min=100;
        double max=-100;
        int nmax=0;
        int nmin=0;
        double sum=0;
        int count=0;
        for ( int i =0; i<array.Length; i++)
        {
            if ( array[i]< min)
            {
                min=array[i];
                nmin =i;
            }
            if ( array[i]>max)
            {
                max=array[i];
                nmax =i;
            }
        }
        if (nmin<nmax)
        {
            for( int i =nmin+1; i<nmax; i++)
            {
                sum+=array[i];
                count++;
            }
        }
        else
        {
            for( int i =nmax+1; i<nmin; i++)
            {
                sum+=array[i];
                count++;
            }
        }
        sum=sum/count;
        System.Console.WriteLine(count);
        System.Console.WriteLine(sum);
        Console.WriteLine();
        foreach (double item in array) 
        {
            Console.Write(item.ToString()+ " ");
        }
        if (double.IsNaN(sum))
        {
            average=0;
            return average;
        }
        
        average=Math.Round(sum, 2);
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
        
        double polozgiteliniy=0;
        int npp=-100;
        for ( int I =0; I<array.Length; I++)
        {
            if ( I>0)
            {
                polozgiteliniy =array[I];
                npp=I;
            }
        }
        double[] array1 = new double [array.Length+1];
        for ( int I =0; I<array1.Length; I++)
        {
            if ( I<=npp)
            {
                array1[I]=array[I];
            }
            else if (I==npp+1)
            {
                array1[I]=P;
            }
            else
            {
                array1[I]=array[I-1];
            }
            
        }
        array = array1; 
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double max=0;
        int nm=0;
        for (int I =0; I<array.Length; I+=2)
        {
            if ( array[I]>max)
            {
                max =array[I];
                nm=I;
            }
        }

        array[nm]=nm;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        //double[] output = null;

        // code here
        
        double [] output = new double[A.Length + B.Length];
        if (A.Length > k)
        {
            for (int i = 0; i< output.Length; i++)
            {
                if (i <= k)
                {
                    output[i] = A[i];
                }
                else if(i <= k+B.Length)
                {
                    output[i] = B[i-k-1];
                }
                else
                {
                    output[i] = A[i-B.Length];
                }
            }
        }
        else
        {
            output=A;
        }
        
        foreach (double item in output) Console.Write(item.ToString()+ " ");
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
        double sum = 0;
        int count = 0;
        double min= 100;
        int nmin= 0;
        double max= -100;
        int nmax= 0;
        for ( int i =0; i<array.Length; i++)
        {
            if ( array[i]< min)
            {
                min=array[i];
                nmin =i;
            }
            if ( array[i]>max)
            {
                max=array[i];
                nmax =i;
            }
        }
        if (nmax < nmin)
        {
            for (int i =0; i<array.Length; i++)
            {
                if (array[i]>0)
                {
                    sum+=array[i];
                    count++;
                }
            }
        }
        else
        {
            for (int i =0; i<array.Length; i++)
            {
                if (array[i]<0)
                {
                    sum+=array[i];
                    count++;
                }
            }
        }
        if (count ==0) average=0;
        else sum =Math.Round(sum/count, 2);
        System.Console.WriteLine(sum);
        System.Console.WriteLine(count);
        average=sum;
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
        double max= -100;
        double sum = 0;
        int nom= 0;
        for (int i =0; i<array.Length; i++)
        {
            sum += array[i];
            if (array[i]>max)
            {
                max= array[i];
                nom =i;
            }
        }
        if (max>sum)
        {
            array[nom]=0;
        }
        else
        {
            array[nom]*=2;
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
       double max = -100;
       int r = 1;
        for ( int i = 0; i< array.Length; i++)
        {
            if (array[i]>max)
            {
                max= array[i];
            }
        }
        for ( int i = 0; i< array.Length; i++)
        {
            if (array[i]==max)
            {
                array[i]=array[i]+r;
                r++;
            }
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double spare = 0;
        for (int i = 0; i < array.Length-2; i++)
            for (int k = i; k < array.Length-2; k++)
            {
                if (i % 2 == 0 && k % 2 == 0)
                    if (array[i] > array[k+2])
                    {
                        spare = array[k+2]; 
                        array[k+2] = array[i]; 
                        array[i] = spare;
                    }
                System.Console.WriteLine();
                foreach (double item in array) Console.Write(item.ToString()+ " ");
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
        double[] array1 = new double[array.Length];
        int arrayIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) {array1[arrayIndex] = array[i]; arrayIndex++;}
        }
        double[] array2 = new double[arrayIndex];
        for (int i = 0; i < array2.Length; i++) array2[i] = array1[i];
        double spare = 0;
        for (int i = 0; i < array2.Length; i++)
            for (int k = i; k < array2.Length; k++)
                {
                    if (array2[i] < array2[k]){
                        spare = array2[k];
                        array2[k] = array2[i];
                        array2[i] = spare;}
                    System.Console.WriteLine();
                    foreach (double item in array2) Console.Write(item.ToString()+ " ");
                }
        arrayIndex = 0;
        for (int i = 0; i < array.Length; i++)  
            if (array[i] < 0) {array[i] = array2[arrayIndex]; arrayIndex++;}
        System.Console.WriteLine();
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        
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
        double[] X = new double[n];
        double[] Y = new double[n];
        double globalMax = 0, globalMin = 0;

        // code here
        double shag =(b-a)/(n-1);
        double max = -2000;
        double min = 2999;
        for (int i = 0; i < n; i++){
            X[i] = Math.Round(a+i*shag, 2);
            Y[i] = Math.Round(Math.Cos(X[i]) + X[i] * Math.Sin(X[i]), 2);
        }
        for (int i = 0; i < X.Length; i++){
            if (Y[i] > max) max = Y[i];
        }
        for (int i = 0; i < X.Length; i++){
            if (Y[i] < min){
                min = Y[i];
            }
        }
        globalMin = min;
        globalMax = max;
        foreach (double item in X) Console.Write(item.ToString()+ " ");
        foreach (double item in Y) Console.Write(item.ToString()+ " ");
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
        double[] normalizedArray = new double[array.Length];;
        // code here
        double max = array[0];
        double min = array[0];
        for (int i = 0; i < array.Length; i++){
            if (array[i] < min) min = array[i];

            if (array[i] > max) max = array[i];
        }
        for (int k = 0; k <array.Length; k++) normalizedArray[k] = Math.Round(2*(array[k]-min)/(max-min)-1, 2);
        foreach (double item in normalizedArray) Console.Write(item.ToString()+ " ");
        // end

        return normalizedArray;
    }
    #endregion
}
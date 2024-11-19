using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
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
        double suma=0;
        for (int i=0; i <array.Length; i++)
        {
            suma+=array[i];
        }
        for (int i=0; i <array.Length; i++)
        {
            array[i]=Math.Round(array[i]/suma,2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double suma=0;
        int count=0;
        for (int i=0; i <array.Length;i++)
        {
            if (array[i]>0)
            {
                suma+=array[i];
                count++;
            }
        }
        double srzn=Math.Round(suma/count,2);
        for (int i=0; i <array.Length;i++)
        {
            if (array[i]>0)
            {
                array[i]=srzn;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i=0;i<first.Length;i++)
        {
            sum[i]=Math.Round(first[i]+second[i],1);
            dif[i]=Math.Round(first[i]-second[i],1);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double suma=0;
        double count=0;
        for (int i=0; i<array.Length;i++)
        {
            suma+=array[i];
            count++;
        }
        double srzn=suma/count;
        for (int i=0; i<array.Length;i++)
        {
            array[i]=Math.Round(array[i]-srzn,2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i=0; i<vector1.Length;i++)
        {
            product+=(vector1[i]*vector2[i]);
        }
        product=Math.Round(product,2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i=0; i<vector.Length;i++)
        {
            length+=vector[i]*vector[i];
        }
        length = Math.Round(Math.Sqrt(length),2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double suma=0;
        double count=0;
        for (int i=0; i<array.Length; i++)
        {
            suma+=array[i];
            count++;
        }
        double srzn= suma/count;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]>srzn)
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
        for (int i=0; i<array.Length; i++)
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
        double suma=0;
        int n=0;
        for (int i=0; i<array.Length; i++)
        {
            suma+=array[i];
            n++;
        }
        double srzn=suma/n;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]>srzn)
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
        for (int i=0; i<array.Length; i++)
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
        int n=0;
        for (int i=0; i <array.Length;i++)
        {
            if (array[i]>0)
            {
                n++;
            }
        }
        output = new double[n];
        int k=0;
        for (int i=0; i <array.Length;i++)
        {
            if (array[i]>0)
            {
                output[k]=array[i];
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
        for (int i=0; i<array.Length; i++)
        {
            if (array[i]<0)
            {
                index=i;
                value=array[i];
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
        int n=0;
        for (int i=0; i <array.Length;i++)
        {
            if (i%2==0)
            {
                even[n]=array[i];
                n++;
            }
        }
        n=0;
        for (int i=0; i <array.Length;i++)
        {
            if (i%2!=0)
            {
                odd[n]=array[i];
                n++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i=0; i <array.Length;i++)
        {
            if (array[i]>=0)
            {
                sum+=array[i]*array[i];
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
        for (int i = 0; i<x.Length;i++)
        {
            if (x[i]==0)
            {
                y[i]=double.NaN;
            }
            else
            {
                y[i]=Math.Round(0.5 * Math.Log(x[i]),2);
            }
            System.Console.WriteLine($"{x[i]} {y[i]}");
        }

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double minarray=10000;
        int index = 0;
        for (int i = 0; i<array.Length;i++)
        {
            if ( array[i]<minarray)
            {
                minarray=array[i];
                index=i;
            }
        }
        if (minarray<0)
        {
            array[index]=minarray/2;
        }
        else
        {
            array[index]=minarray*2;
        }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double maxarray=-100000;
        int index=0;
        for (int i=0; i<array.Length; i++)
        {
            if ( array[i]>=maxarray)
            {
                maxarray=array[i];
                index=i;
            }
        }
        for (int j=0; j<= (index-1);j++)
        {
            sum+=array[j];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double minarray=10000;
        int index = 0;
        for (int i = 0; i<array.Length;i++)
        {
            if ( array[i]<minarray)
            {
                minarray=array[i];
                index=i;
            }
        }
        for (int j=0; j<=(index-1); j++)
        {
            if (array[j]>=0)
            {
                array[j]=array[j]*2;
            }
            else
            {
                array[j]=array[j]/2;
            }
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double suma=0;
        int count=0;
        for(int i=0;i<array.Length;i++)
        {
            count++;
            suma+=array[i];
        }
        double srzn=Math.Round(suma/count,2);
        double maxarray=-100000;
        int index=0;
        for (int i=0; i<array.Length; i++)
        {
            if ( array[i]>=maxarray)
            {
                maxarray=array[i];
                index=i;
            }
        }
        for (int j=(index+1);j<array.Length;j++)
        {
            array[j]=srzn;
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        double maxi=-10000, mini=10000;
        int inmax=0, inmin=0;
        int k=0;
        for (int i=0; i<array.Length;i++)
        {
            if (array[i]<mini)
            {
                mini=array[i];
                inmin=i;
            }
            if (array[i]>maxi)
            {
                maxi=array[i];
                inmax=i;
            }
        }
        double[] newarray= new double[k];
        if (inmax<inmin)
        {
            for (int i=inmax+1;i<inmin;i++)
            {
                if (array[i]<0)
                {
                    k++;
                }
            }
            newarray= new double[k];
            int n=0;
            for(int i=inmax+1;i<inmin;i++)
            {
                if (array[i]<0)
                {
                    newarray[n]=array[i];
                    n++;
                }
            }
        }
        else if(inmin<inmax)
        {
            for (int i=inmin+1;i<inmax;i++)
            {
                if (array[i]<0)
                {
                    k++;
                }
            }
            newarray= new double[k];
            int n=0;
            for(int i=inmin+1;i<inmax;i++)
            {
                if (array[i]<0)
                {
                    newarray[n]=array[i];
                    n++;
                }
            }
        }
        else if(mini==0) return array;
        array=newarray;
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
        double maxi=-10000;
        int inmax=0;
        for(int i=0;i<array.Length;i++)
        {
            if (array[i]>=maxi)
            {
                maxi=array[i];
                inmax=i;
            }
        }
        inmax++;
        if (inmax>=(array.Length-1))
        {
            return array;
        }
        else if (array[inmax]<0)
        {
            double a=array[inmax];
            array[inmax]= -1*(Math.Abs(a)/2);
        }
        else if(array[inmax]>0)
        {
            double a=array[inmax];
            array[inmax]=a*2;
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
        double maxi=-10000, mini=1000;
        int inmax=0,inmin=0;
        int k=0;
        double suma=0;
        for (int i=0;i<array.Length;i++)
        {
            if(array[i]>maxi)
            {
                maxi=array[i];
                inmax=i;
            }
            if(array[i]<mini)
            {
                mini=array[i];
                inmin=i;
            }
        }
        if(inmax==(inmin-1) || inmin==(inmax-1))
        {
            average=0;
        }
        else if (inmin>inmax)
        {
            for (int i=inmax+1;i<inmin;i++)
            {
                suma+=array[i];
                k++;
            }
            average=suma/k;
            //average=Math.Round(average,3);
        }
        else if (inmin<inmax)
        {
            for (int i=inmin+1;i<inmax;i++)
            {
                suma+=array[i];
                k++;
            }
            average=suma/k;
            //average=Math.Round(average,3);
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
        int n=array.Length+1;
        int index=0, k=0;
        double[] newarray = new double[n];
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]>0)
            {
                index=i;
                k++;
            }
        }
        if (k==0)
        {
            return array;
        }
        else
        {
            for (int i=0;i<n;i++)
            {
                if(i==index+1)
                {
                    newarray[i]=P;
                }
                else if(i<index+1)
                {
                    newarray[i]=array[i];
                }
                else if (i>index+1)
                {
                    newarray[i]=array[i+1];
                }
            }
        }
        if (k>=1)
        {
            array=newarray;
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
        double maxi=-10000;
        int inmax=0;
        for (int i=0;i<array.Length;i++)
        {
            if (i%2==0)
            {
                if (array[i]>maxi)
                {
                    maxi=array[i];
                    inmax=i;
                }
            }
        }
        array[inmax]=inmax;
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
        int schet = 0, temp = 0;
        if (k == 7)
        {
            return A;
        }
        else
        { 
            for (int i = 0; i <= k; i++)
            {
                output[schet]=A[i];
                schet++;
                temp++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[schet] = B[i];
                schet++;

            }
            for (; temp < A.Length; temp++)
            {
                output[schet] = A[temp];
                schet++;

            }
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
        double szp=0, szm=0;
        double maxi=-10000,mini=10000;
        int inmax=0,inmin=0;
        int p=0,m=0;
        double sumap=0,sumam=0;
        for (int i=0;i<array.Length;i++)
        {
            if(array[i]>maxi)
            {
                maxi=array[i];
                inmax=i;
            }
            if (array[i]<mini)
            {
                mini=array[i];
                inmin=i;
            }
            if (array[i]>0)
            {
                sumap+=array[i];
                p++;
            }
            if (array[i]<0)
            {
                sumam+=array[i];
                m++;
            }
        }
        szp=sumap/p;
        if (m==0)
        {
            szm=0;
        }
        else
        {
            szm=sumam/m;
        }
        
        if (inmax<inmin)
        {
            average=szp;
        }
        else
        {
            average=szm;
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
        double maxi=-10000;
        int inmax=0;
        double suma=0;
        for (int i=0;i<array.Length;i++)
        {
            suma+=array[i];
            if (array[i]>=maxi)
            {
                maxi=array[i];
                inmax=i;
            }
        }
        if (maxi>suma)
        {
            array[inmax]=0;
        }
        else
        {
            array[inmax]=maxi*2;
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
        double maxi=-10000;
        int k=1;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]>maxi)
            {
                maxi=array[i];
            }
        }
        for (int i=0; i<array.Length;i++)
        {
            if (array[i]==maxi)
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
        int k=0;
        if (array.Length%2==0)
        {
            k=array.Length/2;
        }
        else
        {
            k=array.Length/2 + 1;
        }
        double[] newarray = new double[k];
        int c=0;
        for (int i=0;i<array.Length;i+=2)
        {
            newarray[c]=array[i];
            c++;
        }
        for (int i = 0; i < newarray.Length; i++)
        {
            for (int j = 0; j < newarray.Length - i - 1; j++)
            {
                if (newarray[j] > newarray[j + 1])
                {
                    double temp = newarray[j];
                    newarray[j] = newarray[j + 1];
                    newarray[j + 1] = temp;
                }
            }
        }
        c=0;
        for (int i=0;i<array.Length;i+=2)
        {
            array[i]=newarray[c];
            c++;
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
        double[] newarray=new double[array.Length];
        int k=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<0)
            {
                newarray[k]=array[i];
                k++;
            }
        }
        for (int i=0;i<k-1;i++)
        {
            for (int j=i+1;j<k;j++)
            {
                if (newarray[i]<newarray[j])
                {
                    double t=newarray[i];
                    newarray[i]=newarray[j];
                    newarray[j]=t;
                }
            }
        }
        int index=0;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]<0)
            {
                array[i]=newarray[index];
                index++;
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
        globalMax = Double.MinValue; globalMin = Double.MaxValue;
        X=new double[n];
        Y=new double[n];
        double hod=(b-a)/(n-1);
        int index=0;
        for (double i=a;i<=b;i+=hod)
        {
            double value=Math.Cos(i)+i*Math.Sin(i);
            X[index]=Math.Round(i,2);
            Y[index]=Math.Round(value,2);
            index++;
            if (value > globalMax)
                globalMax = value;
            if (value < globalMin)
                globalMin = value;
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
        double maxi=-10000, mini=10000;
        for (int i=0;i<array.Length;i++)
        {
            if (array[i]>maxi)
            {
                maxi=array[i];
            }
            if (array[i]<mini)
            {
                mini=array[i];
            }
        }
        normalizedArray=new double[array.Length];
        double f=0;
        for (int i=0;i<array.Length;i++)
        {
            f=2*(array[i]-mini)/(maxi-mini)-1;
            normalizedArray[i]=Math.Round(f,2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
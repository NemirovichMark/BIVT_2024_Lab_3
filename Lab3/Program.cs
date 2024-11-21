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
        if (array[Min]>0)
        {
            array[Min] *= 2;
        }
        if (array[Min] < 0)
        {
            array[Min] /= 2;
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
        int M = 0;
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
                N++;
            }
        }
        double[] newArray = new double[N];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                if ((i > Min && i < Max) || (i > Max && i < Min))
                {
                    newArray[M] = array[i];
                    M++;
                }
            }
        }
        array = newArray;
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
        for (int i=Math.Min(Min, Max)+1; i< Math.Max(Min, Max); i++)
        {
            sum+= array[i];
            k++;
        }
        if (k == 0) return 0;
        sum = sum / k;
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
        int last = 0;
        double[] newArray = new double[array.Length + 1];

        for (int i = array.Length-1; i>=0; i--)
        {
            if (array[i] > 0)
            {
                last = i;
                break;
            }
            else return array;
            
        }
        
        for (int i = 0; i <= last; i++)
        {
            if (i<=last)
                newArray[i] = array[i];
           
        }
        newArray[last + 1] = P;
        for (int i = last + 2; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        array= newArray;
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
        output= new double [A.Length+B.Length];
        // code here
        if (k >= A.Length) return A;

        for (int i=0; i<=k; i++)
        {
           output [i] = A[i];
        }
        for(int i=0; i<B.Length;i++)
        {
            output[i+k+1] = B[i];
        }
        for (int i=k+1; i<A.Length; i++)
        {
            output[i+B.Length] = A[i];
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
        int Max = 0;
        int Min = 0;
        double arrayMin = array[0];
        double arrayMax = array[0];

        for (int i=1; i<array.Length;i++)
        {
            if (array[i] < array[Min])
            {
                arrayMin = array[i];
                Min = i;
            }
            if (array[i] > array[Max])
            {
                arrayMax = array[i];
                Max = i;
            }
        }
        double s = 0, sum = 0;
        int count1 = 0, count2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count1++;
            }
            else if (array[i] < 0)
            {
                sum += array[i];
                count2++;
            }
        }

        if ((Max < Min) && count1 > 0)
        {
            average = s / count1;
        }
        if ((Max > Min) && count2 > 0)
        {
            average = sum / count2;
        }
        if ((Max > Min) && count2 == 0)
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
        int Max = 0;
        double sum = 0;
        for (int i=0; i<array.Length; i++)
        {
            if (array[i] > array[Max])
            {
                Max = i;
            }
        }
        for (int i=0; i<array.Length; i++)
        {
            sum += array[i];
        }
        if (array[Max]>sum)
        {
            array[Max] = 0;
        }
        if (array[Max]<sum)
        {
            array[Max] *= 2;
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
        double Max = array[0];
        int c = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > Max)
            {
                Max = array[i];
                c = 0;
            }
            if (array[i] == Max)
            {
                c++;
            }
        }
        output = new int[c];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == Max)
            {
                output[n] = i;
                n++;
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
        double Max = array[0];
        double sum = 0;
        int imax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > Max)
            {
                Max = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == Max)
            {
                array[i] = sum;
                sum += Max;
            }
            else
            {
                sum += array[i];
            }
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
        double[] output = new double[array.Length];
        int pol = 0;
        int otr = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>=0)
            {
                pol++;
            }
            if (array[i]<0)
            {
                otr++;
            }
        }
        double[] mpol = new double[pol];
        double[] motr = new double[otr];
        int p = 0, o = 0, c = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>=0)
            {
                mpol[p] = array[i];
                p++;
            }
            if (array[i]<0)
            {
                motr[o] = array[i];
                o++;
            }
        }
        
        for (int i = 0; i < mpol.Length; i++)
        {
            array[c] = mpol[i];
            c++;
        }
        for (int i = 0; i < motr.Length; i++)
        {
            array[c] = motr[i];
            c++;
        }
       
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

        double[] a = new double[array.Length];
        for (int i = 1; i < array.Length; i ++)
        {
            a[i-1] = array[(i - 1) / 2];
            a[i] = array[(i - 1) / 2];
        }
        array = a;
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
        bool f = false;
        int k = 0;
        double[] a = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            f = false;
            for (int j = 0; j < k; j++)
            {
                if (Math.Abs(array[i] - a[j]) < 0.0001)
                {
                    f = true;
                }
            }
            if (!f)
            {
                a[k] = array[i];
                k++;
            }
        }
        array = new double[k];
        for (int i = 0; i < k; i++)
        {
            array[i] = a[i];
        }
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
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
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
        foreach (double x in array)
        {
            s+= x;
        }
        double[] b = array;
        int k = 0;
        foreach (double x in b)
        {
            array[k] = Math.Round(x/s, 2);
            k++;
        }
        // end
        return array;

    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s+= array[i];
                k++;
            }
        }
        double sr = Math.Round(s/k, 2);
        for (int i = 0; i< array.Length; i++)
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
        int k = 0;
        foreach (double x in sum)
        {
            sum[k] = Math.Round(first[k]+ second[k], 2);
            dif[k] = Math.Round(first[k]- second[k], 2);
            k++;
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s+= x;
        }
        double[] b = array;
        int k = 0;
        double sr = s/5;
        foreach (double x in b)
        {
            array[k] = Math.Round(array[k]- sr, 2);
            k++;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double[] a = new double[4];
        for (int i = 0; i<4; i++)
        {
            a[i] = vector1[i]*vector2[i];
        }
        foreach (double x in a) { product += x; }
        // end
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double s = 0;
        foreach (double x in vector)
        {
            s+= x*x;
        }

        length = Math.Sqrt(s);

        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        double sr = s/7;
        double[] b = array;
        int k = 0;
        foreach (double x in b)
        {
            if (x>sr) { array[k]=0; }
            k++;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (x<0) { count++; }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
        }
        double sr = s/8;
        foreach (double x in array)
        {
            if (x >sr) { count++; }
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double x in array)
        {
            if (P < x && x < Q) { count++; }
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
        for (int i = 0; i < 10; i++)
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
        int k = 0;
        // code here
        foreach (double x in array)
        {
            if (x<0)
            {
                value = x;
                index = k;
            }
            k++;
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int k1 = 0;
        int k2 = 0;
        int k = 0;
        // code here
        foreach (double x in array)
        {
            if (k%2==0) { even[k1] = x; k1++; }
            else if (k%2==1) { odd[k2] = x; k2++; }
            k++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array)
        {
            if (x>=0) { sum += x*x; }
            else { break; }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[10];

        // code here
        for (int i = 0; i< 10; i++)
        {
            if (x[i]<=0)
            {
                y[i] = double.NaN;
            }
            else { y[i] = (0.5*Math.Log(x[i])); }
            Console.WriteLine($"{x[i]}{y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double minel = 100000000;
        int indm = -70;
        // code here
        for(int i = 0; i< array.Length; i++)
        {
            if (array[i] < minel)
            {
                minel = array[i];
                indm = i; 
            }
        }
        for (int i = 0; i< array.Length; i++)
        { 
            if (i==indm)
            {
                if (array[i]> 0) { array[i] = 2 * array[i]; }
                else if (array[i]< 0) { array[i] =  array[i]/2; }
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
        double minel = 100000000;
        int indm = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] <= minel)
            {
                minel = array[i];
                indm = i;
            }
        }
        for (int i = 0; i< indm; i++)
        {
            if (array[i] >= 0) { array[i]= array[i] * 2;}
            else if (array[i]<0) { array[i] = array[i]/2; }  
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
        double minel = 100000000;
        double maxel = -100000000;
        int indmi = -70;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] <= minel)
            {
                minel = array[i];
                indmi = i;
            }
            if (array[i] >= maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        int k = 0;
        for (int i = indmi + 1; i< indma; i++)
        {
            if (array[i] < 0) { k+=1; }
        }
        double[] array2 = new double[k];
        int count = 0;
        for (int i = indmi + 1; i < indma; i++)
        {
            if (array[i]<0)
            {
                array2[count] = array[i];
                count++;
            }
        }
        // end
        array = array2;
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
        double maxel = -100000000;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] >= maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        if ((array.Length - 1) > indma) 
        {
            if (array[indma + 1]>=0) { array[indma + 1] *=2; }
            else if (array[indma+1]<0) { array[indma + 1] /=2; }
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
        double minel = 100000000;
        double maxel = -100000000;
        int indmi = -70;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < minel)
            {
                minel = array[i];
                indmi = i;
            }
            if (array[i] >= maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        int k = 1;
        double ind = Math.Abs(indma-indmi)-1;
        double s = 0;
       
        for (int j = (Math.Min(indmi, indma)+1); j< Math.Max(indmi, indma); j++)
        {
            s+=array[j];
            average = s/k;
            k+=1;
        }

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
        
        int indp = -1;
        int kp = 0;
        for (int i= 0; i< array.Length; i++) 
        { 
            if (array[i] >0){ indp = i; kp++; }
        }
        if (indp == -1) { return array; }
        double[] array2 = new double[array.Length + 1];
        
        int k = 0;
        for (int i = 0; i< array2.Length;)
        {
            if (i == indp+1) { array2[i] = P; i++; }
            else if (i < indp + 1) { array2[i] = array[i]; i++; }
            else { array2[i] = array[i - 1]; }
        }

        return array2;
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
        double minel = 100000000;
        double maxel = -100000000;
        int indmi = -70;
        int indma = -70;
        for (int i = 0; i< array.Length;)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                indma = i;
            }
            i+=2;
        }
        // end
        array[indma]=indma;
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
        if (k > A.Length - 1)
            return A;
        output = new double[A.Length + B.Length];
        int j = 0;
        for (int i = 0; i < k + 1; i++)
            output[j++] = A[i];
        for (int i = 0; i < B.Length; i++)
            output[j++] = B[i];
        for (int i = k + 1; i < A.Length; i++)
            output[j++] = A[i];
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
        double minel = 100000000;
        double maxel = -100000000;
        int indmi = -70;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] < minel)
            {
                minel = array[i];
                indmi = i;
            }
            if (array[i] >= maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        double s = 0;
        int k = 0;
        if (indma<indmi)
        { 
            foreach (double x in array)
                if (x>0){ s+= x;k+=1; } 
        }
        else if (indma>indmi) 
        {
            foreach (double x in array) 
                if (x<0) { s+= x; k+=1;}}
        if (k>0)
        {
            average = s/k;
        }
        else { average = 0; }
            
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
        double maxel = -100000000;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length; i++)
        {
            if (array[i] >= maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        double s = 0;
        int k = 0;
        foreach (double x in array)
            s+= x;
        if (maxel>s) { array[indma] = 0; }
        else { array[indma] *= 2; }
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
        double maxel = -100000000;
        int indma = -70;
        // code here
        for (int i = 0; i< array.Length;i++)
        {
            if (array[i] > maxel)
            {
                maxel = array[i];
                indma = i;
            }
        }
        for (int i = 0; i< indma-1;)
        { 
            double f = array[i];
            array[i]= array[i+1];
            array[i+1]= f;
            i+=2;
        }
        
        // end
        foreach (double x in array) { Console.WriteLine(x); }
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
            if (array[i] > array[i+1]) sch++;
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
        int tmp = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] <= array[i - 1])
                tmp++;
            else
            {
                count = Math.Max(count, tmp);
                tmp = 1;
            }
        }
        count = Math.Max(count, tmp);
        tmp = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] >= array[i - 1])
                tmp++;
            else
            {
                count = Math.Max(count, tmp);
                tmp = 1;
            }
        }
        count = Math.Max(count, tmp);
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

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array)
    {
        // code here
        int k = 0;
        for (int i = 0; i < array.Length;i++)
        {
            if (array[i]>=0) { k++;}

        }
        double[] array2 = new double[k];
        int k2 = 0;
        foreach (double x in array)
        {
            if (x>=0) { array2[k2] = x; k2++; }

        }
        // end
        return array2;
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
//23var
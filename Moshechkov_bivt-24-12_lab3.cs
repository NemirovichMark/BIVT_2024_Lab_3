using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
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
        // code here
        double s = 0;
        foreach (double x in array)
        {
            s += x;
            Console.WriteLine(x);
        }
        for (int i = 0; i < array.Length; i++)
       
        {
           array[i] = Math.Round( array[i] / s, 2);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                count++;
                Console.Write($"{array[i]} ");
            }
        }
        s=s/count;
        for (int i = 0; i < array.Length; i++)

        {
            if (array [i] > 0)
            array[i] = Math.Round(s, 2);
            
            Console.Write($"{array[i]} ");
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
            sum[i]= Math.Round(first[i] + second[i] , 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int count = 0;
        foreach (double i in array)
        {
            s += i;
            count++;
        }
        s = s / count;
        for (int i = 0; i <  array.Length; i++)
        { 
            array[i] = Math.Round(array[i] - s, 2); 
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
            product = Math.Round(product+vector1[i] * vector2[i], 2);
        }
            // end
        
            return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        
        foreach(double i in vector)
            length += i*i;
        length = Math.Sqrt(length);
        // end
        
        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        foreach (double i in array)
        {
            sum += i;
            count++;
        }
        sum = sum / count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum) 
                array[i] = 0;
                
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double i in array)
        {
            if (i<0)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        
        foreach (double i in array)
        {
            sum += i;
            count++;
        }
        sum = sum / count;
        count = 0;
        foreach (double i in array)
        {
            if (i > sum)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double i in array)
        {
            if (i > P && i < Q)
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
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[count] = array[i];
                count++;
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
        for (int i = 7; i >= 0; i--)
        {
            if (array[i] < 0)
            { 
                value = array[i];
                index=i;
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
        int index_1 = 0;
        int index_2 = 0;
        for (int i = 0; i < array.Length; i++)
            if (i%2==0)
            { 
                even[index_1] = array[i];
                index_1++;
            }
                
            else 
            {
                odd[index_2] = array[i];
                index_2++;
            }
            // end

            return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double i in array)
        {
            
            if (i < 0)
                break;
            else
                sum += i * i;
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
            if (x[i]== 0)
                y[i] = double.NaN;
            else
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
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

        // code here
        double amax = array[0];
        int imax = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }

        for (int i = 0; i < imax; i++)
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
        // code here
        double amax = array[0];
        int imax = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        sum = Math.Round(sum / array.Length, 2);
        for (int i = imax+1; i < array.Length; i++)
            array[i] = sum;
            

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
        double min = double.MaxValue;
        double clos = 0;
        int iclos = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            
        }
        
        sum = (sum )/ (array.Length);

        for (int i = 0; i < array.Length; i++)
        {
             if (Math.Abs(array[i]-sum) <= min)
            {
                min = Math.Abs(array[i] - sum);
                clos = array[i];
                iclos = i;
                
            }
            
        }
        
        double[] a = new double[array.Length + 1];

        for (int i = 0; i <=iclos; i++)
            a[i] = array[i];

        a[iclos + 1] = P;

        for (int i = iclos+2; i <= array.Length; i++)
            a[i] = array[i-1];
        foreach ( double i in a)
        Console.Write($"{i} ");
         Console.WriteLine();
        

        // end

        return a;
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
        double amax = array[0];
        double amin = amax;
        int imax = 0;
        int imin = 0;
        int c = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
            c=i;
        }
        Console.WriteLine(imax);
        Console.WriteLine(c);
        for (int i = imax+1; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        Console.WriteLine(amin);
        if (c!=imax)
        {
            array[imax] = amin;
            array[imin] = amax;
        }
        
        foreach (double i in array)
            Console.Write($"{i} ");
        Console.WriteLine();
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
        double amin = double.MaxValue;
        int imin = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (0 < array[i] && array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        
        double[] a = new double[array.Length - 1];
        if (imin!=0)
        {
             for (int i = 0; i < imin; i++)
             {
                a[i] = array[i];
             }

             for (int i = imin; i < a.Length; i++)
             {
                a[i] = array[i+1];
             }
            return a;
        }
        else

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
        double amax = array[0];
        double negative = 0;
        int imax = 0;
        int inegative = -1;
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }

        for (int i = imax+1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negative = array[i];
                inegative = i;
                break;
            }
           
        }

        if (inegative != -1) 
        array[inegative] = sum;

        foreach (double i in array)

        Console.Write($"{i} ");
        Console.WriteLine();

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
        double amax = array[0];
        double negative = 0;
        int imax = 0;
        int inegative = -1;

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
            if (array[i] < 0)
            {
                negative = array[i];
                inegative = i;
                break;
            }

        }

        if (inegative != -1)
        {
            array[imax] = negative;
            array[inegative] = amax;

        }
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
        double sum = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

        }

        sum = (sum) / (array.Length);
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<sum)
            {
                n++;    
            }
        }
        output = new int[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                output[n]=i;
                n++;
            }
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
        double amax1 = array[1];
        int imax1 = 0;
        double amax2 = array[0];
        int imax2 = 0;
        int count = 0;

        for (int i = 1; i < array.Length; i+=2)
        {
            if (array[i] > amax1)
            {
                amax1 = array[i];
                imax1 = i;
            }
        }
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > amax1)
            {
                amax2 = array[i];
                imax2 = i;
            }
        }
        
        count = array.Length / 2;

        if (amax2 > amax1)
        {
            for (int i = 0; i < count; i++)
            {
                array[i] = 0;
            }
        }
        else 
        {
            for (int i = count; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        foreach (double i in array)

        Console.Write($"{i} ");
        Console.WriteLine();

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

        double amin = array[0];
        double negative = 0;
        int imin = 0;
        int inegative = -1;

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
            if (array[i] < 0)
            {
                negative = array[i];
                inegative = i;
                break;
            }

        }
        if (inegative != -1)
        {
            if (inegative < imin)
                for (int i = 0; i < array.Length; i+=2)
                {
                    sum += array[i];
                }
            else
                for (int i = 1; i < array.Length; i += 2)
                {
                    sum += array[i];
                }
            sum = Math.Round(sum, 2);
        }
        else
        sum = 0;

        Console.Write($"{amin} {inegative} {sum}");
        Console.WriteLine();
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double max = array[0];
        int[] ind = new int[array.Length];
        int count = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= max)
            {
                
                if (array[i] == max)
                    count++;
                else
                    count = 0;
                max = array[i];
                ind[count] = i;
            }
        }
        Console.WriteLine(count);
        output = new int[count+1];
        for (int i = 0; i < output.Length; i++)
            output[i] = ind[i];

            foreach (double i in output)
            Console.Write($"{i} ");
        Console.WriteLine();
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
        double max = double.MinValue;
        double sum = 0;
        double[] temp = new double[array.Length];
        

        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                for (int n = 0; n < i; n++)
                    sum += temp[n];
           
            array[i] = sum;
            sum = 0;
            }
        }


            foreach (double i in array)
        Console.Write($"{i} ");
        Console.WriteLine();
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
        int count = 0;
        double[] temp = new double[array.Length];
         for (int i=0; i<array.Length; i++ )
        {
            if (array[i]>=0)
            {
                temp[count]=array[i];
                count++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                temp[count] = array[i];
                count++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = temp[i];
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
        int count = 0;
        double[] temp = new double[array.Length];
        for (int i = 0; i < array.Length/2; i++)
        { 
           temp[count] = array[i];
           count++;
           temp[count] = array[i];
           count++;

        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = temp[i];
        }
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
        int count = 0; 
        double[] a = new double[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            bool c = true;
            for (int j = 0; j < a.Length; j++)
            {
                if (array[i] == a[j])
                {
                    c = false;
                }
            }
            if (c == true)
            {
                a[i] = array[i];
            }
        }
       
          
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0 && a[i] != array[i])
            {
                count++;
            }
        }
        
        double[] output = new double[a.Length - count];
        int count_temp = 0;
        for (int i = 0; i < a.Length; i++)
        {
            
            if (a[i] == array[i])
            {
                output[count_temp] = a[i];
                count_temp++;
            }
        }
        // end

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
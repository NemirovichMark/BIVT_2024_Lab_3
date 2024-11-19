using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Transactions;
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / sum;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0, cnt = 0, plus = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                plus += array[i];
                cnt++;
            }
        }
        sr = plus / cnt;

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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];
        }



        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0, sr = 0, cnt = 0; 
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        sr = sum / cnt;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - sr;
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
        double sum = 0;
        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            sum += vector[i] * vector[i];
        }
        length = Math.Sqrt(sum);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0, cnt = 0, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        sr = sum / cnt;
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < array.Length; i++)
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
        double sr = 0, sum = 0, cnt = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;

        }
        sr = sum / cnt;
        for (int i = 0; i < array.Length; i++)
        {
            if ( array[i] > sr)
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
        for ( int i  = 0; i < array.Length; i++ )
        {
            if (array[i] > P &&  array[i] < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        
        int cnt = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }
        double[] output = new double[cnt];
        cnt = 0;
       
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[cnt++] = array[i];
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
        for (int i = array.Length - 1; i >= 0; i--)
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
        int index1 = 0, index2 = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[index1] = array[i];
                index1++;
            }
            else
            {
                odd[index2] = array[i];
                index2++;
            }
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
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0) 
            {
                y[i] = 0.5 * Math.Log(x[i]);
            }
            else
            {
    
                y[i] = double.NaN; 
            }
        }

        Console.WriteLine("x\t\ty");
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]:0.00}\t\t{y[i]:0.00}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double p = array[0];
        int imin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < p)
            {
                p = array[i];
                imin = i;
            }
        }
        if (array[imin] >= 0)
        {
            array[imin] *= 2.0;
        }
        else
        {
            array[imin] /= 2.0;
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
        double p = array[0];
        int imin = 0;
        // code here
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < p)
            {
                p = array[i];
                imin = i;
            }
        }

        for (int i = 0; i<imin; i++ )
        {
            if (array[i] > 0)
            {
                array[i] *= 2.0;
            }
            else
            {
                array[i] /= 2.0;
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
        double min = array[0], max = array[0];
        int imax = 0, imin = 0, cnt = 0 ;
        double[] vr = new double[array.Length];
        vr = array;

        // code here
        for (int i = 1; i < array.Length; i ++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }

        int min1 = Math.Min(imin, imax); 
        int max1 = Math.Max(imin, imax);

        for (int i = min1 + 1; i < max1; i++)
        {
            if (array[i] < 0) cnt++;
        }
        array = new double[cnt];
        for (int i = min1 + 1, k = 0; i < max1; i++, k++)
        {
            if (vr[i] < 0)
            { 
                array[k] = vr[i];
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
        double max = array[0];
        int imax = 0;
        // code here
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
        }


        if (imax+1 != array.Length)
        {
            if (array[imax+1] > 0)
            {
                array[imax + 1] *= 2;
            }
            else
            {
                array[imax + 1] /= 2;
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
        double min = array[0], max = array[0], sum = 0;
        int imax = 0, imin = 0, cnt = 0;
        double[] vr = new double[array.Length];
        vr = array;

        // code here
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }

        int min1 = Math.Min(imin, imax);
        int max1 = Math.Max(imin, imax);
        cnt = max1 - min1 - 1;
        if (cnt != 0)
        {
            for (int i = min1 + 1; i < max1; i++)
            {
                sum += array[i];
            }
        }
        else
        {
            return 0;
        }
        average = sum / cnt;
      

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
        int plus = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                plus = i;
            }
        }

        if (plus != -1)
        {
            
            double[] vr = new double[array.Length + 1];

           
            for (int i = 0; i <= plus; i++)
            {
                vr[i] = array[i];
            }

           
            vr[plus + 1] = P;

           
            for (int i = plus + 1; i < array.Length; i++)
            {
                vr[i + 1] = array[i];
            }

            
            array = vr;
        }
        else
        {
            
            return array;
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

        double max = array[0];
        int imax = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
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
        if (k >= A.Length) return A;
        output = new double[A.Length + B.Length];
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = k + 1, c = 0; i < k + B.Length + 1; i++, c++)
        {
            output[i] = B[c];
        }
        for (int i = B.Length + k + 1, c = k + 1; i < B.Length + A.Length; i++, c++)
        {
            output[i] = A[c];
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
        double max = array[0], min = array[0], sum = 0;
        double imax = 0, imin = 0, cnt = 0;


        // code here
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                { 
                    sum += array[i]; 
                    cnt++; 
                }
            }
                
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                { 
                    sum += array[i]; 
                    cnt++; 
                }
                if (cnt == 0) return 0;
            }
                
        }
        average = sum / cnt;
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
        double max = array[0], sum = 0;
        int imax = 0;


        for (int i = 1; i < array.Length; i++)
        {
            if (array [i] > max)
            {
                max= array [i];
                imax = i;
            }
            sum += array[i];
        }
        if (max > sum)
        {
            array[imax] = 0;
        }
        else
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
        double max = array[0];
        
        // code here
        for (int i = 1; i<array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array [i];
                
            }

        }
        
        for (int i = 0, j = 1; i < array.Length; i++)
        {
            if (array [i] == max)
            {
                array[i] += j;
                j++;
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
        

        
        for (int i = 2; i < array.Length; i += 2)
        {
            double key = array[i];
            int j = i - 2;

            while (j >= 0 && j % 2 == 0 && array[j] > key)
            {
                array[j + 2] = array[j];
                j -= 2;
            }
            
            array[j + 2] = key;
        }

        return array;
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
        
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                cnt++;
            }
        }

        
        if (cnt <= 1)
        {
            return array;
        }

     
        double[] vr = new double[cnt];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                vr[j] = array[i];
                j++;
            }
        }

        
        for (int i = 1; i < vr.Length; i++)
        {
            double key = vr[i];
            int k = i - 1;
            while (k >= 0 && vr[k] < key)
            {
                vr[k + 1] = vr[k];
                k--;
            }
            vr[k + 1] = key;
        }


        int l = 0;
        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] < 0)
            {
                array[i] = vr[l];
                l++;
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
        X = new double[n];
        Y = new double[n];
        double x;
        globalMax = Y[0];
        globalMin = Y[0];
        double temp = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            x = a + i * temp;
            Y[i] = Math.Cos(x) + x * Math.Sin(x);
            X[i] = x;
        }
        globalMax = Y[0];
        globalMin = Y[0];
        foreach (double y in Y)
        {
            if (y > globalMax) globalMax = y;
            if (y < globalMin) globalMin = y;
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

        normalizedArray = new double[array.Length];
        int imax = 0;
        int imin = 0;
        int l = array.Length;
        double temp;
        for (int i = 0; i < l; i++)
        {
            if (array[i] > array[imax]) imax = i;
            if (array[i] < array[imin]) imin = i;
        }
        temp = 2 / (array[imax] - array[imin]);
        for (int i = 0; i < l; i++)
        {
            normalizedArray[i] = (array[i] - array[imin]) * temp - 1;
        }
        // end

        return normalizedArray;
    }
    #endregion
}


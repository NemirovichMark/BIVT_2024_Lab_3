using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
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
        double n = 0;

        for (int i = 0; i < array.Length; i+=1)
        {
            n += array[i];
        }
        
        for (int j = 0; j < array.Length; j+=1)
        {
            array[j] = Math.Round(array[j] / n, 2);
        }
        // code here


        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double n = 0;
        double sred = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > 0)
            {
                n = n + array[i];
                k += 1;
            }
        }
        sred = n / k;
        for (int i = 0; i < array.Length; i += 1)
        {
            if(array[i] > 0)
            {
                array[i] = sred;
                array[i] = Math.Round(array[i],2);
            }
        }
                // code here


                // end

                return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; i += 1)
            {
                sum[i] = first[i] + second[i];
                dif[i] = first[i] - second[i];
                sum[i] = Math.Round(sum[i],2);
                dif[i] = Math.Round(dif[i],2);
            }        
        }
        // code here

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sred = 0;
        double sum = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            k += 1;
        }
        sred = sum / k;
        for (int i = 0; i < array.Length; i += 1)
        {
            array[i] -= sred;
            array[i] = Math.Round(array[i],2);
        }

            // code here

            // end

            return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        for (int i = 0; i < vector2.Length; i += 1)
        {
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product,2);

            // code here    

            // end

            return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        for (int i = 0; i < vector.Length; i += 1)
        {
            length = length + vector[i] * vector[i];
        }
        //length = Math.Round(Math.Sqrt(length),2);
        length = Math.Sqrt(length);

            // code here

            // end

            return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        double sred = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            k += 1;
        }
        sred = sum / k;

        for (int i = 0; i < array.Length; i += 1)
        {
            if ( array[i] > sred)
            {
                array[i] = 0;
            }
        }

            // code here

            // end

            return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                count += 1;
            }
        }
            // code here

            // end

            return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sum = 0;
        double sred = 0;
        double k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            k += 1;
        }
        sred = sum / k;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > sred)
            {
                count += 1;
            }
        }

        // code here



        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > P && array[i] < Q)
            {
                count += 1;
            }
        }


            // end

            return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        int x = 0;
        int y = 0;

        foreach (var i in array)
        {
            if (i > 0)
            {
                x += 1;
            }
        }
        output = new double[x];

        foreach (var i in array)
        {
            if (i > 0)
            {
                output[y] = i;
                y += 1;
            }
        }
        // code here

        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }
        // code here

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        int chetnie = 0;
        int nechetnie = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (i % 2 == 0)
            {
                even[chetnie] = array[i];
                chetnie+=1;
            }
            else
            {
                odd[nechetnie] = array[i];
                nechetnie += 1;
            }
        }
            // code here


            // end

            return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
            // code here


            // end

            return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        for (int i = 0; i < x.Length; i += 1)
        {
            if (x[i] > 0)
            {
                y[i] = 0.5 * Math.Log(x[i]);
            }
            else y[i] = double.NaN;
        }
        
            // code here

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
        double max = -9999;
        int k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        for (int i = 0; i < k; i += 1)
        {
            sum += array[i];
        }
        // code here

        Console.WriteLine(sum);

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
        double max = 0;
        int k = 0;
        double sred = 0;
        double sum = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }

            sum += array[i];
        }
        
        sred = sum/ array.Length;

        for (int i = 1 + k; i < array.Length; i+=1)
        {
            sred = Math.Round(sred, 1);
            array[i] = sred;
        }
            // code here


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
        double sum = 0;
        double sred = 0;
        double razniza = 0;
        int k = -1;
        double MinRazniza = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        sred = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            razniza = Math.Abs(array[i] - sred);
            if (razniza < MinRazniza)
            {
                MinRazniza = razniza;
                k = i;
            }
        }

        double[] newarray = new double[array.Length + 1];

        for (int i = 0; i <= k; i++)
        {
            newarray[i] = array[i];
        }

        newarray[k + 1] = P;

        for (int i = k + 1; i < array.Length; i++)
        {
            newarray[i + 1] = array[i];
        }

        
        array = newarray;
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
        double max = -100000; 
        double min = 100000;
        int k = -1;
        int r = -1;
        double hehehe = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        for (int i = k; i < array.Length; i += 1)
        {
            if (array[i] < min)
            {
                min = array[i];
                r = i;
            }
        }
        if (k != -1)
        {
            hehehe = array[k];
            array[k] = array[r];
            array[r] = hehehe;
        }
            // code here


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
        double min = 100000;
        int k = -1;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                k = i;
            }
        }
        if (k == -1) return array;

        double[] b = new double[array.Length - 1];

        for (int i =0; i<k; i += 1)
        {
            b[i]= array[i];
        }

        for(int i = k; i < array.Length - 1; i+= 1)
        {
            b[i]= array[i + 1];
        }

        // code here
        array = b;

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
        double sum = 0;
        double max = -10000;
        int k = -1;

        for (int i = 0; i < array.Length; i+=1)
        {
            if (array[i]>max)
            {
                max = array[i];
                k = i;
            }
        }

        for( int i  = k+1; i < array.Length; i +=1)
        {
            sum += array[i];
        }

        sum = Math.Round(sum, 1);

        for(int i =0; i < array.Length; i+=1)
        {
            if(array[i]<0)
            {
                array[i] = sum;
                break;
            }
        }
        // code here


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
        double otrizatel = 0;
        double max = -100000;
        int k = 0;
        int q = -1;


        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
            if (array[i] < 0 && q == -1)
            {
                otrizatel = array[i];
                q = i;
            }
        }

        if (q != -1)
        {
            array[q] = max;
            array[k] = otrizatel;
        }
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
        double sum = 0;
        double sred = 0;
        int k = 0;
        int q = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
        }
        sred = sum/array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < sred)
            {
                q += 1;
            }
        }

        output = new int[q];

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < sred)
            {
                output[k] = i;
                k += 1;
            }
        }

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

        double max_1 = -999999;
        double max_2 = -9999999999;

        for (int i = 0; i < array.Length; i+=1)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max_1)
                {
                    max_1 = array[i];
                }
            }
            else
            {
                if (array[i] > max_1)
                {
                    max_2 = array[i];
                }
            }
        }
        
        if (max_1 > max_2)
        {

            for (int i = 0; i < array.Length / 2; i += 1)
            {
                array[i] = 0;
            }
        }
        if (max_2 > max_1)
        {
            for (int i = array.Length / 2; i < array.Length; i += 1)
            {
                array[i] = 0;
            }
        }

        // code here
  ;
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
        double min = 1000000;
        double k = 0;
        int q = 0; 
        int m = 0;
        for (int i = 0; i < array.Length; i+=1)
        {
            if (array[i] < min)
            {
                min = array[i];
                q = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                m = i;
                k = array[i];
                
                break;
            }
        }
        for (int i = 0; i < array.Length; i+=1)
        {
            if (k == 0)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            else if (m < q)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            }
            else
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }      
            }
        }
        // code here

        Console.Write(sum);

            // end

            return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;
        double max = -1000000;
        int k = 0;
        int q = 0;
        int m = 0;

        for(int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = 0;
                q = i;
            }
            if (array[i] ==  max)
            {
                k += 1;
            }
        }
        output = new int[k];

        for (int i = q; i < array.Length; i += 1)
        {
            if (array[i] == max)
            {
                output[m] = i;
                m += 1;
            }
        }

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
        double max = -100000;
        double sum = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] >= max)
            {
                max = array[i];
            }
        }

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] != max)
            {
                sum += array[i];
            }
            else
            {
                array[i] = sum;
                sum += max;
            }
        }

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
        double[] output = new double[array.Length];
        int k = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i]>= 0)
            {
                output[k] = array[i];
                k += 1;
            }
        }

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                output[k] = array[i];
                k += 1;
            }
        }

        array = output;
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }

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
        int k = array.Length - 1;

        for (int i = array.Length / 2 - 1; i >= 0; i = i - 1)
        {
            array[k] = array[i];
            array[i] = 0;
            array[k - 1] = array[k];
            k = k - 2;
        }
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
        int k = 0;
    double[] mas = new double[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        bool c = true;

        for (int l = 0; l < k; l++)
        {
            if (array[i] == mas[l])
            {
                c = false;
                break;
            }
        }

        if (c == true)
        {
            mas[k] = array[i];
            k++;
        }
    }

    double[] output = new double[k];
    for (int i = 0; i < k; i++)
    {
        output[i] = mas[i];
    }

    array = output;
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
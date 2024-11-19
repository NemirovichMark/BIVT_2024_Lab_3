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
        //program.Task_2_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 },new double[] { 5, 2, 8, 1, 9, 10 },1);
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double S = 0;
        for (int i = 0; i < array.Length ; i++)
        {
            S += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / S, 2);
        }
        

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sr = 0, S = 0;
        int col = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                S += array[i];
                col++;
            }
        }
        sr = Math.Round(S / col, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = sr;
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            
        }
        for (int i = 0; i < dif.Length; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sm = 0;
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            
        }
        sr = Math.Round(sm / 5.0, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        // end
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double sm = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sm += vector[i] * vector[i];
        }
        sm = Math.Round(sm, 2);
        length = Math.Round(Math.Sqrt(sm), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        double sm = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
        }
        sr = Math.Round(sm / 7.0, 2);
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
                count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sm = 0, sr;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
        }
        sr = Math.Round(sm / 8.0, 2);
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
            if (array[i] > P && array[i] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                n++;
            } 
        }
        output = new double[n];
        int n1 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[n1] = array[i];
                n1++;
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
        int index_even = 0, index_odd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[index_even] = array[i];
                index_even++;
            } else if (i % 2 != 0)
            {
                odd[index_odd] = array[i];
                index_odd++;
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
            if (array[i] < 0)
                break;
            sum += Math.Round(array[i] * array[i], 2);
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
            if (0.5 * Math.Log(x[i]) < 0)
            {
                y[i] = double.NaN;
            }
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

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;
        double max = array[0];
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != max)
            {
                sum += array[i];
            } else
            {
                break;
            }
        }
        sum = Math.Round(sum, 2);
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
        double sum = 0, sr = 0, max = array[0];
        int col = 0;
        bool z = false;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            col++;
            if (array[i] > max)
                max = array[i];
        }
        sr = Math.Round(sum / col * 1.0, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (z == true)
                array[i] = sr;

            if (array[i] == max)
                z = true;
        }
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
        double sum = 0, sr = 0;
        int col = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            col++;
        }
        sr = Math.Round(sum / col * 1.0, 2);
        
        double[] array2 = new double[array.Length + 1];
        double dlina = 100000, vrem = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                if (array[i] - sr < dlina)
                {
                    vrem = array[i];
                    dlina = array[i] - sr;
                }
            }
            else
            {
                if (sr - array[i] < dlina)
                {
                    vrem = array[i];
                    dlina = sr - array[i];

                }
            }
        }
        col = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == vrem)
            {
                array2[col] = array[i];
                array2[col + 1] = P;
                col += 2;
            }
            else
            {
                array2[col] = array[i];
                col++;
            }
        }
        // end

        return array2;

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
        double max = 0, min = 100000;
        int max_index = 0, min_index = 0;
        bool z = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        if (max_index == array.Length - 1)
        {
            return array;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (z == true)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    min_index = i;
                }
            }
            if (array[i] == max)
                z = true;
        }
        array[max_index] = min;
        array[min_index] = max;
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
        double min = 100000;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < min)
                    min = array[i];
            }
        }
        double[] a = new double[array.Length - 1];
        int schet = 0;

        if (min == 100000) 
            return array;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != min)
            {
                a[schet] = array[i];
                schet++;
            }
        }
       
        // end

            return a;
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
        double max = -10000, sum = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                index = i;
            }
            
        }
        if (index == array.Length - 1)
        {
            sum = max;
        }
        for (int i = index+1; i < array.Length; i++)
        {
            sum += array[i];
            sum = Math.Round(sum, 2);
        }
        Console.WriteLine(sum);

        for (int i = 0; i < array.Length; i++)
        { 
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
        }
        
        
        
        
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
        double max = -10000, otr = 0, vrem = 0;
        int index_max = 0, index_otr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                index_otr = i;
                break;
            }
        }
        
        if (otr == 0)
            return array;

        vrem = array[index_max];
        array[index_max] = array[index_otr];
        array[index_otr] = vrem;
        Console.WriteLine(max);
        Console.WriteLine(otr);
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
        double sr = 0, sm = 0;
        int c = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sm += array[i];
            c++;
        }
        sr = Math.Round(sm / c*1.0, 2);
        int col = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
                col++;
        }
        output = new int[col];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[k] = i;
                k++;
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
        double max_even = -10000, max_odd = -10000;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max_even)
                {
                    max_even = array[i];
                }
            } else if (i % 2 != 0)
            {
                if (array[i] > max_odd)
                {
                    max_odd = array[i];
                }
            }
        }
        
        if (array.Length % 2 != 0)
        {
            for (int i = 0; i <= array.Length / 2; i++)
            {
                array[i + array.Length / 2] = 0;
            }

        }
        else
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (max_even > max_odd)
                {
                    array[i] = 0;
                }
                else
                {
                    array[i + array.Length / 2] = 0;
                }
            }
        }
        
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
        double otr = 0, min = 100000;
        int index_otr = 0, index_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                index_otr = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index_min = i;
            }
        }
        //Console.WriteLine(min);
        
        //Console.WriteLine(otr);
        
        if (otr == 0)
            return 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (index_otr < index_min)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            } else if (index_otr >= index_min)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
        }

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
        double max = -100000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        //Console.WriteLine(index);
        double vrem = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            if (i < index-1)
            {
                vrem = array[i];
                array[i] = array[i + 1];
                array[i + 1] = vrem;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
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
        int count = 1;

        // code here
        int max_c = -10000;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i+1])
            {
                count++;
            }
            else
            {
                if (count > max_c)
                {
                    max_c = count;
                }
                count = 1;
            }
  
        }
        Console.WriteLine(max_c);
        // end

        return max_c;
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
        int count1 = 1, count2 = 1;

        // code here
        int max_yb = -100000, max_voz = -100000, max = -100000 ;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i+1])
            {
                count1++;
            }
            else
            {
                if (count1 > max_yb)
                {
                    max_yb = count1;
                }
                count1 = 1;
            }

            if (array[i] < array[i + 1])
            {
                count2++;
                //Console.WriteLine(array[i+1]);
            }
            else
            {
                if (count2 > max_voz)
                {
                    max_voz = count2;
                    //Console.WriteLine(max_voz);
                }
                count2 = 1;
            }

        }
        if (count1 > max_yb)
        {
            max_yb = count1;
        }
        if (count2 > max_voz)
        {
            max_voz = count2;
        }
        //Console.WriteLine(max_voz);
        //Console.WriteLine(max_yb);
        if (max_yb > max_voz)
        {
            max = max_yb;
        }
        else
        {
            max = max_voz;
        }
        // end
        Console.WriteLine(max);
        return max;
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
        int col = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                col++;
            }
        }
        if (col == 0)
            return array;
        
        double[] x = new double[array.Length-col];
        int schet = 0;
        for (int i = 0 ; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                x[schet] = array[i];
                schet++;
            }
        }
        // end

        return x;
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
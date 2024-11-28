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
        double summ = 0;
        for(int i = 0; i < 6; i++)
        {
            summ = summ + array[i];
        }
        for (int j = 0; j < 6; j++)
        {
            array[j] = array[j] / summ;
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sred = 0; int z = 0;
        for(int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                sred += array[i];
                z++;
            }
        }
        sred = sred / z;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sred;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < 4; i++)
        {
            sum[i] = (first[i] + second[i]);
            dif[i] = (first[i] - second[i]);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sred = 0; int z = 0;
        for (int i = 0; i < 5; i++)
        {
            sred = sred + array[i];
            z++;
        }
        sred = sred / z;
        for (int j = 0; j < 5; j++)
        {
            array[j] = array[j] - sred;
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
            product += (vector1[i] * vector2[i]);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0; double l = 0;

        // code here
        for(int i = 0; i < 5; i++)
        {
            l += vector[i] * vector[i];
        }
        length = Math.Sqrt(l);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0; int z = 0;
        for (int i = 0; i < 7; i++)
        {
            sred = sred + array[i];
            z++;
        }
        sred = sred / z;
        for (int j = 0; j < 7; j++)
        {
            if (array[j] > sred)
            {
                array[j] = 0;
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < 6; i++)
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

        // code here
        double sred = 0; int z = 0;
        for (int i = 0; i < 8; i++)
        {
            sred = sred + array[i];
            z++;
        }
        sred = sred / z;
        for (int j = 0; j < 8; j++)
        {
            if (array[j] > sred)
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
        for(int i = 0; i < 10;i++)
        {
            if ((array[i] > P) && (array[i] < Q))
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
        int col = 0; int i = 0;
        for (int a = 0; a < 10; a++)
        {
            if (array[a] > 0)
            {
                col++;
            }
        }
        double [] output = new double[col];
        for (int a = 0; a < 10; a++)
        {
            if (array[a] > 0)
            {
                output[i] = array[a];
                i++;
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
        for (int a = 0; a < 8; a++)
        {
            if (array[a] < 0)
            {
                value = array[a];
                index = a;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length/2];
        double[] odd = new double[array.Length/2];

        // code here
        int z = 0, nach = 0;
        for (int a = 0; a < 10; a++)
        {
            if (a % 2 == 0)
            {
                even[nach] = array[a];
                nach++;
            }
            else
            {
                odd[z] = array[a];
                z++;
            }
            
        }

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int a = 0; a < 11; a++)
        {
            if (array[a] >= 0)
            {
                sum += array[a] * array[a];
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
        int z = 0; double sch = 0;
        for (int a = 0; a < 10; a++)
        {
            if (x[a] <= 0)
            {
                y[z] = double.NaN;
                z++;
            }
            else
            {
                sch = 0.5 * (Math.Log(x[a]));
                y[z] = Math.Round(sch, 2);
                z++;
            }
        }
        for(int b = 0; b < 10; b++)
        {
            Console.WriteLine($"{x[b]}+ {y[b]}");
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
        double maxi = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxi)
            {
                maxi = array[i];
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] != maxi)
            {
                sum += array[j];
            }
            else
            {
                break;
            }
        }
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
        int maxi = 0; double sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sred += array[i];
            if (array[i] > array[maxi])
            {
                maxi = i;
            }
        }
        sred = sred/ array.Length;
        for (int j = maxi+1; j < array.Length; j++)
        {
            array[j] = sred;
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
        double sred = 0; int need_in = 0; double min_ab = 10000;
        for (int i = 0; i < array.Length; i++) { sred += array[i]; }
        sred = sred / array.Length;
        for (int j = 0; j < array.Length; j++)
        {
            if (Math.Abs(array[j] - sred) < min_ab) { need_in = j; min_ab = Math.Abs(array[j] - sred); }

        }
        double[] array2 = new double[array.Length + 1];
        for (int k = 0, l = 0; k < array.Length + 1; k++, l++)
        {
            array2[k] = array[l];
            if (k == need_in) { k++; array2[k] = P; }
        }
        array = array2;
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
        // code here
        double maxi = -10000; double mini = 10000; int in1 = 0; int in2 = 0; double zag = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                in1 = i;
            }
        }
        for (int j = in1+1; j < array.Length; j++)
        {
            if (array[j] < mini)
            {
                mini = array[j];
                in2 = j;
            }
        }
        if (in1 > in2)
        {
            return array;
        }
        else
        {
            zag = array[in1];
            array[in1] = array[in2];
            array[in2] = zag;
        }
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
        double mini = 10000;int a = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if ((array[i] > 0) && (array[i] < mini))
            {
                mini = array[i];
            }
        }
        double[] array_n = new double[array.Length-1];
        if (mini == 10000)
        {
            return array;
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] != mini)
            {
                array_n[a] = array[j];
                a++;
            }
        }
        // end

        return array_n;
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
        double sum = 0; double maxi = -10000; int m_in = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] > maxi)
            {
                maxi = array[j];
                m_in = j;
            }
        }
        for (int k = m_in + 1; k < array.Length; k++)
        {
            sum += array[k];
        }

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
        double maxi = -10000; int m_in = 0; int ot_in = 0; double zag = 0; double otr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                m_in = i;
            }
        }
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0)
            {
                otr = array[j];
                ot_in = j;
                break;
            }
        }
        if ((otr == 0)||(maxi == -10000))
        {
            return array;
        }
        zag = array[m_in];
        array[m_in] = array[ot_in];
        array[ot_in] = zag;
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

        // code here
        double sred = 0; int a = 0; int count = 0; int count1 = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sred += array[i];
            count++;
        }
        sred = sred / count;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] < sred)
            {
                count1++;
            }
        }
        int[] output = new int[count1];
        for (int k = 0; k < array.Length; k++)
        {
            if (array[k] < sred)
            {
                output[a] = k;
                a++;

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
        double maxi1 = -10000; double maxi2 = -100000; int a = array.Length/2;
        for (int i = 0; i < array.Length; i++)
        {
            if ((i % 2 == 0) || (i == 0))
            {
                if (array[i] > maxi1) { maxi1 = array[i]; }
            }
            else
            {
                if (array[i] > maxi2) { maxi2 = array[i]; }
            }
        }
        if (maxi1 > maxi2)
        {
            for(int j = 0; j < a; j++) { array[j] = 0; }

        }
        else
        {
            for (; a < array.Length; a++) { array[a] = 0; }
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

        // code here
        double mini = 10000; int min_in = 0;  double ot = 0; int ot_in = 0; double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini) { mini = array[i]; min_in = i; }
        }
        for(int j = 0; j < array.Length; j++)
        {
            if (array[j] < 0){ ot = array[j]; ot_in = j; break; }
        }
        for (int k = 0; k < array.Length; k++)
        {

            if (ot == 0)
            {
                if (k % 2 != 0) { sum += array[k]; }
            }
            else if (ot_in < min_in)
            {
                if (k % 2 == 0) { sum += array[k]; }
            }

            else
            {
                if (k % 2 != 0) { sum += array[k]; }
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
        double maxi = -10000; int m_in = 0; double zag = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi) { maxi = array[i]; m_in = i; }
        }
        for (int j = 1; j < m_in; j+=2)
        { 
           zag = array[j];
           array[j] = array[j-1];
           array[j-1] = zag;
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
        // code here
        int m_try = -10000; int count = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i-1]) { count++; }
            else { count = 0; }

            if (count > m_try) { m_try = count; }
        }
        count = m_try + 1;
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

        // code here
        int m_try = -10000; int count = 0; int m_try1 = -10000; int count1 = 1; int count2 = 1;
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < array[i + 1]) { count2++; }
            else { count2 = 1; }

            if (count2 > m_try) { m_try = count2; }
        }
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j + 1]) { count1++; }
            else { count1 = 1; }

            if (count1 > m_try1) { m_try1 = count1; }
        }
        if (m_try > m_try1) { count = m_try; }
        else { count = m_try1; }
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
        int ot_count = 0; int k = 0;
        for (int i = 0; i < array.Length; i++) { if (array[i] < 0) { ot_count++; } }
        double[] array2 = new double[array.Length-ot_count];
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j] >= 0)
            {
                array2[k] = array[j];
                k++;
            }
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

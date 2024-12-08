using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] {1, 2, 3, 4, 5, 6});
       
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double S = 0;

        foreach (double x in array)
        {
            S += x;
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= S;
            //Console.WriteLine(array[i]);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double k = 0;
        foreach(double x in array)
        {
            if (x > 0)
            {
                s += x;
                k++;
            }
        }
        s = Math.Round(s / k,2);
        for(int i  = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = s;
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
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double k = 0;
        double sred = 0;
        foreach(double x in array)
        {
            sred += x;
            k++;
        }
        sred = sred / k;
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - sred;
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++)
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
        for(int i = 0; i < vector.Length; i++)
        {
            length += (vector[i])* (vector[i]);
        }
        length=Math.Sqrt(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sred = 0;
        foreach(double x in array)
        {
            sred += x;
        }
        sred = sred / 7;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > sred)
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
        foreach(double x in array)
        {
            if(x < 0)
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
        double sred = 0;
        foreach (double x in array)
        {
            sred += x;
        }
        sred = sred / 8;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > sred)
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
        foreach(double x in array)
        {
            if((x>P) && (x < Q))
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
        int k = 0;
        foreach (double x in array)
        {
            if (x > 0) k++;
        }
        //Console.WriteLine(k);
        //Console.WriteLine(array);
        output = new double[k];
        for (int i = 0, j = 0; i < array.Length; i++)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i]; index = i;
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
        for(int i =0,j=0,l=0;i<array.Length;i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[l] = array[i];
                l++;
            }
                    
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
            if (x >= 0)
            {
                sum += x * x;
            }
            else { break; }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i] = 0.5 * Math.Log(x[i]);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        //code here
        double min = 1000000;
        int id = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                id = i;
            }
        }
        if (array[id] < 0)
        {
            array[id] = min / 2;
        }
        else
        {
            array[id] = min * 2;
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
        double min = 1000000;
        int id = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                id = i;
            }
        }
        for (int i = 0; i < id; i++)
        {
            if (array[i] < 0)
            {
                array[i] /= 2;
            }
            else if (array[i]>=0)
            {
                array[i] *= 2;
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
        double min = 1000000;
        double max = -1000000;
        int idmin = -1;
        int idmax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }
        }
        int zamena;
        if(idmin > idmax) { 
            zamena = idmin;
            idmin = idmax;
            idmax = zamena;
        }
        
        int k = 0;
        for (int i = idmin+1; i <= idmax; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        
        var r = new double[k];
        
            for(int i = 0; idmin < idmax;idmin++, i++)
            {
                if(array[idmin+1] < 0)
                {
                    r[i] = array[idmin+1];
                    
                }

            }
        array = r;
        
        
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
        double max = -1000000;
        int id = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                id = i;
            }
        }
        if (id + 1 != array.Length)
        {
            if (array[id + 1] > 0) { array[id + 1] *= 2; }
            else { array[id + 1] /= 2; }
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
        double min = 1000000;
        double max = -1000000;
        int idmin = -1;
        int idmax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }
        }
        int zamena;
        if (idmin > idmax)
        {
            zamena = idmin;
            idmin = idmax;
            idmax = zamena;
        }
        int k = 0;
        double sum = 0;
        for (int i = idmin+1; i < idmax; i++)
        {
            sum += array[i];
            k++;
        }
        if (k > 0)
        {
            average = sum / k;
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
        int ind = -1;
        for(int i = array.Length-1; i >= 0; i--)
        {
            if(array[i] > 0)
            {
                ind = i;
                break;
            }
        }
        double[] s = new double[array.Length+1];
        if (ind < 0) s = array;
        else
        {
            for (int i = 0; i <= ind; i++) { s[i] = array[i]; }
            s[ind + 1] = P;
            for (int i = ind + 1; i < array.Length; i++) { s[i + 1] = array[i]; }
        }
        array = s;
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
        double max = -100000;
        int idmax = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if(array[i] > max)
                {
                    max=array[i];
                    idmax = i;
                }
            }
        }
        array[idmax] = idmax;
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
        int Al = A.Length, Bl = B.Length;
        output = new double[Al + Bl];

        if (k >= Al)
            return A;

        if (k < 0)
            k = 0;

        k++;
        for (int i = 0; i < A.Length; i++)
        {
            if (i < k)
                output[i] = A[i];
            else if (i == k)
            {
                for (int j = 0; j < Bl; j++)
                    output[k + j] = B[j];
            }
            output[i + Bl] = A[i];
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
        double min = 1000000;
        double max = -1000000;
        int idmin = -1;
        int idmax = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }
        }
        double s = 0;
        int k = 0;
        if (idmax < idmin)
        {
            foreach(double x in array)
            {
                if (x > 0)
                {
                    s += x;
                    k++;
                }
            }
        }
        else {
            foreach (double x in array)
            {
                if (x < 0)
                {
                    s += x;
                    k++;
                }
            }
        }
        if (k == 0) return 0;
        average = Math.Round(s / k,3);
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
        double max = -1000000;
        int id = -1;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                id = i;
            }
        }
        if (max > sum)
        {
            array[id] = 0;
        }
        else
        {
            if (array[id] > 0) { array[id] *= 2; }
            else { array[id] /= 2; }
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
        double max = -10000;
        int k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += k;
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
        double s = 0;
        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int k = i; k < array.Length - 2; k++)
            {
                if (i % 2 == 0 && k % 2 == 0)
                    if (array[i] > array[k + 2])
                    {
                        s = array[k + 2];
                        array[k + 2] = array[i];
                        array[i] = s;
                    }
            }
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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                k++;
            }
        }
        double[] second = new double[k];
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                second[k] = array[i];
                k++;
            }
        }

        for (int i = 0; i < second.Length; i++)
        {
            double key = second[i];
            int j = i - 1;
            while (j >= 0 && second[j] < key)
            {
                second[j + 1] = second[j];
                j--;
            }
            second[j + 1] = key;
        }
        k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] =second[k];
                k++;
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
        double sdv = (b - a) / (n - 1);
        double max = -1000000;
        double min =  1000000;
        X = new double[n]; Y = new double[n];
        int zn = 0;
        for (double i = a; i <= b; i += sdv)
        {
            double k = Math.Cos(i) + i * Math.Sin(i);
            X[zn] = Math.Round(i, 2);
            Y[zn] = Math.Round(k, 2);
            zn++;
            if (k > max)
                max = k;
            if (k < min)
                min = k;
        }
        globalMin = min;
        globalMax = max;

        //foreach (double item in X) Console.Write(item.ToString() + " ");
        //foreach (double item in Y) Console.Write(item.ToString() + " ");
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
        double max = -100000000, min = 100000000;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
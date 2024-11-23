using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
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
        double sam = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sam += array[i];
            Console.Write("{0,4:f} ", array[i]);
        }
        Console.WriteLine();
        //Console.WriteLine(sam);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i] / sam), 2);
            Console.Write("{0,4:f} ", array[i]);

        }
        Console.WriteLine();
        return array;

    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sam = 0;
        int k = 0;
        foreach (double i in array)
        {
            if (i > 0)
            {
                sam += i;
                k++;
            }
        }
        double srar = sam / k;
        srar = Math.Round(srar, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = srar;
            }

            Console.Write("{0,4:f} ", array[i]);

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
            sum[i] = Math.Round(first[i] + second[i], 2);
        }
        for (int i = 0; i < first.Length; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double srar = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            srar += array[i];
        }
        srar = Math.Round((srar / array.Length), 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i] - srar), 2);
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
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // c de here
        foreach (double i in vector)
        {
            length += i * i;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);

    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sam = 0;
        foreach (double i in array)
        {
            sam += i;
        }
        double srar = sam / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > srar)
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
        foreach (double i in array)
        {
            if (i < 0)
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
        double sam = 0, srar = 0;

        // code here
        foreach (double i in array)
        {
            sam += i;
        }
        srar = sam / array.Length;
        foreach (double i in array)
        {
            if (i > srar)
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
        foreach (double i in array)
        {
            if (i > P && i < Q)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int len = 0, len2 = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                len++;
            }
        }
        double[] output = new double[len];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[len2] = array[i];
                len2++;
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
        double[] odd = new double[array.Length / 2];
        int len1 = 0, len2 = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[len1] = array[i];
                len1++;
            }
            else
            {
                odd[len2] = array[i];
                len2++;
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
            if (array[i] > 0)
            {
                sum += array[i] * array[i];
            }
            if (array[i] < 0) break;
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
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        // end
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]} + {y[i]}");
        }

        return y;
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = 1000000;
        int znach = 0;
       
        for (int i = 0; i<array.Length; i++)
        {
            Console.Write("{0,4:f} ", array[i]);
            if (array[i] < min)
            {
                min = array[i];
                znach = i;
            }
        }
        Console.WriteLine();
        if (array[znach]>0)
        {
            array[znach] = min * 2;
        }
        else if (array[znach]<0)
        {
            array[znach] = min / 2;
        }
        for (int i = 0; i<array.Length; i++)
        {
            Console.Write("{0,4:f} ", array[i]);
        }
        Console.WriteLine();

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
        int znach = 0;
        double min = 1000000;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]<min)
            {
                min = array[i];
                znach = i;
            }
        }
        for (int i = 0; i<znach; i++)
        {
            if (array[i] > 0)
                array[i] = Math.Round(array[i] * 2, 2);
            else
                array[i] = Math.Round(array[i] / 2, 2);
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
        double min = 1000000000, max = -10000000000;
        int znach1 = 0, znach2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0,4:f} ", array[i]);
            if (array[i] < min)
            {
                min = array[i];
                znach1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                znach2 = i;
            }
        }
        Console.WriteLine(znach1);
        Console.WriteLine(znach2);
        Console.WriteLine();
        int c = 0;
        for (int k = Math.Min(znach1, znach2); k<Math.Max(znach1, znach2); k++)
        {
            if (array[k+1] < 0) c++;
        }
        int schet = 0;
        Console.WriteLine(c);
        double[] array2 = new double[c];
        for (int k = Math.Min(znach1, znach2)+1; k < Math.Max(znach1, znach2); k++)
        {
            if (array[k]<0)
            {
                array2[schet] = array[k];
                schet++;
            }
            Console.Write("{0,4:f} ", array[k]);
        }
        Console.WriteLine();
        // end

        return array2;
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
        double max = -10000000;
        int znach = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                znach = i;
            }
        }
        if (znach == array.Length - 1)
            return array;
        else if (array[znach + 1] > 0)
            array[znach+ 1] = array[znach + 1] * 2;
        else
            array[znach + 1] = array[znach + 1] / 2;
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
        double min = 1000000000, max = -10000000000;
        int znach1 = 0, znach2 = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                znach1 = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                znach2 = i;
            }
        }
        double sum = 0;
        int c = 0;

        for (int k = Math.Min(znach1, znach2)+1; k < Math.Max(znach1, znach2); k++)
        {
            sum += array[k];
            c++;
        }

        
        if (c == 0)
            return 0;

        average = sum / c;
        

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
        double[] array2 = new double[array.Length+1];
        int znach = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                znach = i;
            }
        }
        if (znach == -1)
            return array;

        for (int j = 0; j < array.Length + 1; j++)
        {
            if (j < znach + 1)
                array2[j] = array[j];
            else if (znach + 1 == j)
                array2[j] = P;
            else
                array2[j] = array[j - 1];
        }
        // end

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
        double max = -1000000000;
        int index = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (i%2==0)
            {
                if (array[i]>max)
                {
                    max = array[i];
                    index = i;
                }
            }
        }
        array[index] = index;
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
        if (k>A.Length-1)
        {
            return A;
        }
        double[] array = new double[A.Length+B.Length];
       
        for (int i = 0; i<k+1 && i<A.Length; i++)
        {
            array[i] = A[i];
        }
        for (int i = 0; i<B.Length; i++)
        {
            array[i + k + 1] = B[i];
        }
        for (int i = k+1; i<A.Length; i++)
        {
            array[i+B.Length]= A[i];
        }
        // end

        return array;
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
        int pol = 0, otr = 0;
        double sampol = 0, samotr = 0;
        double max = -100000000, min = 100000000;
        int indexmax = 0, indexmin = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>0)
            {
                sampol += array[i];
                pol++;
            }
            if (array[i] < 0)
            {
                samotr += array[i];
                otr++;
            }
            if (array[i]>max)
            {
                max = array[i];
                indexmax = i;
            }
            if (array[i]<min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        if (indexmax<indexmin)
        {
            if (pol==0)
            {
                return 0;
            }
            average = sampol / pol;
            
        }
        if (indexmin<indexmax)
        {
            if (otr == 0)
            {
                return 0;
            }
            average = samotr / otr;
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
        int index = 0;
        double max = -1000000;
        double sum = 0;
        for (int i =0; i<array.Length; i++)
        {
            sum+= array[i];
            if (array[i]>max)
            {
                max = array[i];
                index = i;
            }
        }
        if (max > sum) array[index] = 0;
        if (max <= sum) array[index] = array[index] * 2;
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
        // code here
        double max = -10000;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 1; i<index; i+=2)
        {
            double f = array[i];
            array[i] = array[i - 1];
            array[i - 1] = f;
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
        int count = 0;
        int max = -1000000;
        // code here
        for (int i = 1; i<array.Length; i++)
        {
            if (array[i] < array[i - 1]) count++;
            else count = 0;
            if (count > max) max = count;
        }
        count = max + 1;
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
        int lt = 1;
        int max = -10000000;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < (array[i - 1])) lt++;
            else lt = 1;
            if (lt > max) max = lt;
        }

        int lt2 = 1;
        int max2 = -10000000;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > (array[i - 1])) lt2++;
            else lt2 = 1;
            if (lt2 > max2) max2 = lt2;
        }
        if (max > max2) count = max;
        else count = max2;
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
        int k = 0;
        // code here
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>=0)
            {
                k++;
            }
        }
        double[] mass = new double[k];
        int j = 0;
        for (int i = 0; i<array.Length; i++)
        {
            if (array[i]>=0)
            {
                mass[j] = array[i];
                j++;
            }
        }




        // end

        return mass;
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
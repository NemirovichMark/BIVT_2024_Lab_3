using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
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

        for (int i = 0; i < 6; i++)
        {
            sum += array[i];
        }

        for (int j = 0; j < 6; j++)
        {
            array[j] = Math.Round(array[j] / sum, 2);
        }

        // end

        return (array);
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i < 8; i++)
        { 
            if (array[i] > 0)
            {
                sum += array[i];
                cnt++;
            }
        }

        double srar = sum / cnt;

        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = Math.Round(srar, 2);
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
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        foreach (double i in array)
        {
            sum += i;
        }

        double khurma = sum / 5;

        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - khurma, 2);
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
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector)
        {
            length += x * x;
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        foreach (double dolma in array)
        {
            sum += dolma;
        }

        double barashka = sum / 7;

        for (int i = 0; i < 7; i++)
        {
            if (array[i] > barashka)
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

        // code here
        double sum = 0;
        foreach(double dolma in array)
        {
            sum += dolma;
        }
        double nagets = sum / 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > nagets)
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
        //double[] output = null;

        // code here
        int cnt = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }

        double[] output = new double[cnt];
        int n = 0;

        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n] = array[i];
                n++;

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

        // code here
        int eeven = 0;
        int oodd = 0;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[eeven++] = array[i];
            }

            else if (i % 2 != 0)
            {
                odd[oodd++] = array[i];
            }

        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double chivapchich in array)
        {
            if (chivapchich < 0)
            {
                break;
            }
            sum += chivapchich * chivapchich;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[0];

        // code here
        foreach (var i in x)
        {
            if (i <= 0)
            {
                y = y.Append(double.NaN).ToArray();
                continue;
            }
            y = y.Append(Math.Round(0.5 * Math.Log(i), 2)).ToArray();
        }
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"{x[j]:F3} \t {y[j]:F3}");
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
        int maxind = 0; 

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxind])
                maxind = i;
        }

        for (int i = 0; i < maxind; i++)
        {
            sum += array[i];
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
        double sum = 0;
        int maxind = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxind])
                maxind = i;
        }

        foreach (double dolma in array)
        {
            sum += dolma;
        }

        double sr = Math.Round(sum / array.Length, 1);

        for (int i = maxind + 1; i < array.Length; i++)
        {
            array[i] = sr;
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
        double sum = 0;

        foreach (double dolma in array)
        {
            sum += dolma;
        }

        double sr = Math.Round(sum / array.Length, 2);

        int clostInd = 0;

        double pik = Math.Abs(array[0] - sr);

        for (int i = 1; i < array.Length; i++)
        {
            double curva = Math.Abs(array[i] - sr);
            if (curva < pik)
            {
                pik = curva;
                clostInd = i;
            }
        }

        int newSize = array.Length + 1;
        double[] newArr = new double[newSize];

        for (int i = 0; i <= clostInd; i++)
        {
            newArr[i] = array[i];
        }

        newArr[clostInd + 1] = P;

        for (int i = clostInd + 1; i < array.Length; i++)
        {
            newArr[i + 1] = array[i];
        }
        // end

        return newArr;
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
        int mxm = 0;
        int minm = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[mxm])
            {
                mxm = i;
            }
        }

        for (int i = mxm + 1; i < array.Length; i++)
        {
            if (minm == -1 || array[i] < array[minm])
            {
                minm = i;
            }
        }

        if (minm != -1)
        {
            double a = array[mxm];
            array[mxm] = array[minm];
            array[minm] = a;
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
        double minm = 100;
        int minind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minm)
            {
                minm = array[i];
                minind = i;
            }
        }

        if (minind == 0) return array;

        double[] newms = new double[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != minind)
            {
                newms[j++] = array[i];
            }
        }
        // end

        return newms;
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
        double mxm = -100000;
        int mxind = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mxm)
            {
                mxm = array[i];
                mxind = i;
            }
        }

        double sum = 0;
        for (int i = mxind + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 1);


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
        int mnind = -1;
        int mxind = -1;
        double mxm = -10000;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mxm)
            {
                mxind = i;
                mxm = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                mnind = i;
                break;
            }
        }

        if (mnind != -1 && mxind != -1)
        {
            double a = array[mxind];
            array[mxind] = array[mnind];
            array[mnind] = a;
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

        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double sr = sum / array.Length;

        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                count++;
            }
        }

        output = new int[count];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[index++] = i;
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
        double mxch = 0;
        double mxnch = 0;

        if (array.Length == 0)
        {
            return array;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > mxch)
                {
                    mxch = array[i];
                }
            }
            else
            {
                if (array[i] > mxnch)
                {
                    mxnch = array[i];
                }
            }

        }

        if (mxch > mxnch)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                array[i] = 0;
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
        int fot = -1;
        int mnm = -1;
        double mnim = 1000;

        if (array.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i<array.Length; i++)
        {
            if (array [i] < mnim)
            {
                mnim = array [i];
                mnm = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                fot = i;
                break;
            }
        }

        if (fot == -1)
        {
            fot = array.Length;
        }

        if (fot < mnm)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
        }

        else
        {
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
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
        double khinkali = -1;
        int cnt = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > khinkali)
            {
                khinkali = array[i];
                cnt = 1;
            }
            else if (array[i] == khinkali)
            {
                cnt++;
            }
        }

        if (cnt == 0)
            return output;

        output = new int[cnt];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == khinkali)
            {
                output[index++] = i; 
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
        if (array.Length == 0)
        {
            return array;
        }

        double pikmi = double.MinValue;
        foreach (double x in array)
        {
            if (x > pikmi)
            {
                pikmi = x;
            }
        }

        double khurma = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == pikmi)
            {
                khurma += array[i];
                array[i] = Math.Round(khurma, 2) - array[i];
            }
            
            else
            {
                khurma += array[i];
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
        int poloj = 0;
        int otric = 0;

        foreach (double num in array)
        {
            if (num >= 0)
            {
                poloj++;
            }
            else
            {
                otric++;
            }
        }

        double[] polnumbers = new double[poloj];
        double[] otrnumbers = new double[otric];

        int polojind = 0;
        int otricind = 0;

        foreach (double num in array)
        {
            if (num >= 0)
            {
                polnumbers[polojind++] = num;
            }
            else
            {
                otrnumbers[otricind++] = num;
            }
        }

        double[] result = new double[array.Length];
        int index = 0;

        foreach (double num in polnumbers)
        {
            result[index++] = num;
        }

        foreach (double num in otrnumbers)
        {
            result[index++] = num;
        }

        // end

        return result;
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

        double[] chukcha = new double[array.Length];

        for (int i = 0; i < array.Length / 2; i++)
        {
            chukcha[i * 2] = array[i];
            chukcha[i * 2 + 1] = array[i];
        }
        // end

        return chukcha;
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
        double[] dora = new double[array.Length];
        int uniq = 0;

        for (int i = 0; i < array.Length; i++)
        {
            bool shelli = false;

            for (int j = 0; j < uniq; j++)
            {
                if (array[i] == dora[j])
                {
                    shelli = true;
                    break;
                }
            }

            if (!shelli)
            {
                dora[uniq] = array[i];
                uniq++;
            }
        }

        double[] result = new double[uniq];

        for (int i = 0; i < uniq; i++)
        {
            result[i] = dora[i];
        }

        // end

        return result;
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
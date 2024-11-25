using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
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
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        for(int i = 0; i < array.Length; i++)
        {
            array[i] /= s;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0; 
        double n =0 ; 
        double a = 0;
        for (int i = 0; i < array.Length; i++) 
        { 
            if ( array[i] > 0) 
            { 
                s += array[i]; 
                n ++; 
            } 
        }
        a = Math.Round(s / n, 2);
        for (int i = 0; i < array.Length; i++) 
        {  
            if (array[i] > 0 ) 
            { 
                array[i] = a; 
            } 
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
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
        double s = 0;
        double sr = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        sr = s / array.Length;
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
        for(int i = 0; i < vector1.Length; i++)
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
        for(int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        double sr = 0;
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
            count++;
        }
        sr = Math.Round(s / count, 2);
        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < array.Length;i++)
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
        double s = 0;
        double sr = 0;
        int count2 = 0;
        for(int i = 0; i < array.Length;i++)
        {
            s += array[i];
            count2++;
        }
        sr = Math.Round(s / count2, 2);
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] > sr)
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
        for(int i =0; i < array.Length;i++)
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
        int count = 0;
        int count2 = 0;
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] > 0)
                count++;
        }
        output = new double[count];
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i]>0)
                output[count2++] = array[i];
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] <0)
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
        int count = 0;
        int count2 = 0;
        for(int i = 0; i < array.Length;i++)
        {
            if (i % 2 == 0)
            {
                even[count] = array[i];
                count++;
            }
            else
            {
                odd[count2] = array[i];
                count2++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for(int i = 0;i < array.Length;i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
            {
                return sum;
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
            if (0.5 * Math.Log(x[i]) >= 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = double.NaN;
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

        // code here
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) break;
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
        double sr = 0;
        double max = array[0];
        int k = 0;
        for(int i = 0; i < array.Length;i++)
        {
            sr += array[i];
            if (array[i] >= max)
            {
                max = array[i];
                k = i;
            }
        }
        k++;
        sr = Math.Round(sr / array.Length, 2);
        for (;k < array.Length;k++)
            array[k] = sr;
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
        double sr = 0;
        double bliz = double.MaxValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr / array.Length, 2);

        double closestdiff = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            double diff = Math.Abs(sr - array[i]);
            if (diff < closestdiff)
            {
                closestdiff = diff;
                bliz = array[i];
                index = i;
            }
        }

        double[] answer = new double[array.Length + 1];

        for (int i = 0; i <= index; i++)
        {
            answer[i] = array[i];
        }

        answer[index + 1] = P;

        for (int i = index + 1; i < array.Length; i++)
        {
            answer[i + 1] = array[i];
        }
        return answer;
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
        double maxelem = 0, minelem = 999;
        int maxIndex = 0, minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxelem)
            {
                maxelem = array[i];
                maxIndex = i;
            }
        }
        for (int j = maxIndex; j < array.Length; j++)
        {
            if (array[j] < minelem)
            {
                minelem = array[j];
                minIndex = j;
            }
        }
        array[maxIndex] = minelem;
        array[minIndex] = maxelem;
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
        double minpolozh = 10000;
        int Index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minpolozh && array[i] > 0)
            {
                minpolozh = array[i];
                Index = i;
            }
        }
        if (minpolozh != 10000)
        {
            double[] newarray = new double[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i < Index)
                    newarray[i] = array[i];
                else
                    newarray[i] = array[i + 1];
            }
            array = newarray;
        }
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
        double maxelem = -999, s = 0;
        int maxIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxelem)
            {
                maxelem = array[i];
                maxIndex = i;
            }
        }
        for (int i = maxIndex + 1; i < array.Length; i++)
        {
            s += array[i];
        }
        s = Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = s;
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
        double maxelem = double.MinValue, minelem = double.MaxValue, temp = 0;
        int maxIndex = 0, minIndex = -1;
        
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] > maxelem)
            {
                maxelem = array[i];
                maxIndex = i;
            }
        }
        for(int i = 0; i < array.Length;i++)
        {
            if (array[i] < 0)
            {
                minelem = array[i];
                minIndex = i;
                break;
            }
        }

        if(minIndex == -1)
        {
            return array;
        }

        temp = maxelem;
        array[maxIndex] = minelem;
        array[minIndex] = temp;

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
        double s = 0, avg = 0;
        int count = array.Length;
        for(int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        if(count == 0)
        avg = 0;

        else
        avg = Math.Round(s/count, 2);

        count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < avg)
            {
                count++;
            }
        }

        output = new int[count];
        count = 0;  

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < avg)
            {
                output[count] = i;
                count++;
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
        double maxElemCh = double.MinValue, maxElemNech = double.MinValue;
        for(int i = 0; i < array.Length; i++)
        {
            if(i % 2 == 0)
            {
                if(array[i] > maxElemCh)
                {
                    maxElemCh = array[i];
                }
            }
            else if(i % 2 != 0)
            {
                if (array[i] > maxElemNech)
                {
                    maxElemNech = array[i];
                }
            }
        }
        if(maxElemCh > maxElemNech)
        {
            for(int i = 0; i < array.Length/2 ;i++)
            {
                array[i] = 0;
            }
        }
        else if (maxElemNech > maxElemCh)
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
        double negElem = double.MinValue, minElem = double.MaxValue;
        int indexNegElem = -1, indexMinElem = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0 && indexNegElem == -1)
            {
                negElem = array[i];
                indexNegElem = i;
            }
            if (array[i] < minElem)
            {
                minElem = array[i];
                indexMinElem = i;
            }
        }
        if (indexNegElem < indexMinElem && indexNegElem != -1)
        {
            for (int i = 0; i < array.Length; i ++)
            {
                if(i % 2 == 0)
                sum += array[i];
            }
        }
        else 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(i % 2 != 0)
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

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double maxElem = double.MinValue;
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > maxElem)
                maxElem = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == maxElem)
            {
                count++;
                array[i] += count;
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
        int n = array.Length;
        for(int i = 2; i < n; i+=2)
        {
            double key = array[i];
            int j = i - 2;
            while(j >= 0 && array[j] > key)
            {
                array[j + 2] = array[j];
                j -= 2;
            }
            array[j + 2] = key; 
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
        int n = array.Length;
        int count = 0;
        for(int i = 0; i < n; i++)
        {
            if(array[i] < 0)
            {
                count++;
            }
        }
        double [] arrayNeg = new double[count];
        count = 0;  

        for(int i = 0; i < n; i++)
        {
            if(array[i] < 0)
            {
                arrayNeg[count] = array[i];
                count++;
            }
        }

        for (int i = 0; i < arrayNeg.Length; i++)
        {
            double key = arrayNeg[i];
            int j = i - 1;
            while (j >= 0 && arrayNeg[j] < key)
            {
                arrayNeg[j + 1] = arrayNeg[j];
                j --;
            }
            arrayNeg[j + 1] = key;
        }
        count = 0;
        for(int i = 0; i < n; i++)
        {
            if(array[i] < 0)
            {
                array[i] = arrayNeg[count];
                count++;
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
        globalMax = double.MinValue; globalMin = double.MaxValue;
        X = new double[n]; Y = new double[n];
        double step = (b - a) / (n - 1);

        int k = 0;
        for (double i = a; i <= b; i += step)
        {
            double value = Math.Cos(i) + i * Math.Sin(i);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(value, 2);
            k++;

            if (value > globalMax)
                globalMax = value;

            if (value < globalMin)
                globalMin = value;
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
        double maxElem = array[0], minElem = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minElem)
            {
                minElem = array[i];
            }
        }
        normalizedArray = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - minElem) / (maxElem - minElem) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
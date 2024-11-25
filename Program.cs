using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
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
        for(int i = 0;i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0;i<array.Length; i++)
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
        int m = 0;
        for(int i = 0;i<array.Length; i++)
        {
            if(array[i] > 0)
            {
                s += array[i];
                m += 1;
            }
        }
        double sr = Math.Round(s / m, 2);
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
        for (int i = 0;i < first.Length; i++)
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
        for (int i = 0;i < array.Length; i++)
        {
            s += array[i];
        }
        // end
        double sr = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i], 2);
        }

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0;i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
            product = Math.Round(product, 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double s = 0;
        for(int i = 0;i<vector.Length; i++)
        {
            s += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(s), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        for (int i = 0;i<array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr/7, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                array[i] = 0;
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
                count += 1;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr / 8, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
                count += 1;
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
                count += 1;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                count += 1;

        }
        output = new double[count];
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                output[count++] = array[i];
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
        int n = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {

                even[n] = array[i];
                n += 1;
            }

            else if (i % 2 != 0) 
            {
                
                odd[m] = array[i];
                m += 1;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int ind = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                ind = i;
                break;
            }
            else
                ind = i + 1;
                
        }
        for(int i = 0; i < ind; i++)
        {
            sum += (array[i] * array[i]);
        }
        sum = Math.Round(sum, 2);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];  

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
                y[i] = Math.Round((0.5 * Math.Log(x[i])), 2);

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
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
                maxi = array[i];
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == maxi)
                index = i;

        }
        for (int i = 0; i < index; i++)
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
        double sr = 0;
        double maxi = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
                maxi = array[i];
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == maxi)
                index = i;
        }
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr / array.Length, 2);
        for(int i = index + 1; i < array.Length; i++)
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
        double sr = 0;
        double bliz = double.MaxValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }
        sr = Math.Round(sr / array.Length, 2);

        double closestdiff = double.MaxValue;

        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
        }
        Console.WriteLine(" ");
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
        double maxi = double.MinValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }

        double mini = double.MaxValue;
        int index2 = 0;
        for(int i = index + 1; i < array.Length; i++)
        {

            if (array[i] < mini)
            {
                mini = array[i];
                index2 = i;
            }
        }

        if(index != array.Length - 1)
        {
            array[index] = mini;
            array[index2] = maxi;
        }    

        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
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
        double mini = double.MaxValue;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < mini)
                {
                    mini = array[i];
                    index = i;
                }
            }
        }
        double[] answer = new double[array.Length - 1];
        for(int i = 0; i < index; i++)
        {
            answer[i] = array[i];
        }
        for(int i = array.Length - 1; i > index; i--)
        {
            answer[i - 1] = array[i];
        }
        for(int i = 0; i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
        }
        Console.WriteLine(" ");
        if (mini == double.MaxValue)
            return array;
        else
            return answer;

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
        double sum = 0;
        double max = double.MinValue;
        double otr = 0;
        int index = 0;
        int index2 = 0;

        for(int i = 0; i< array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                index = i;
                break;
            }
        }

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index2 = i;
            }
        }
        
        for(int i = index2 + 1; i < array.Length; i++)
        {
            sum += array[i];
        }

        sum = Math.Round(sum, 2);
        
        if (otr != 0)
            array[index] = sum;


        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine(" ");
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
        double max = double.MinValue;
        double otr = 0;
        int index = 0;
        int index2 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                index = i;
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index2 = i;
            }
        }

        if (otr != 0)
        {
            array[index] = max;
            array[index2] = otr;
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
        double sr = 0;
        int kol = 0;
        int i2 = 0;

        for(int i = 0; i < array.Length; i++)
        {
            sr += array[i];
        }

        sr = Math.Round(sr / array.Length, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                kol += 1;
            }
        }

        output = new int[kol];

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[i2] = i;
                i2 += 1;
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
        double maxch = double.MinValue;
        double maxnech = double.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxch)
                {
                    maxch = array[i];
                }
            }

            else if( i % 2 != 0)
            {
                if (array[i] > maxnech)
                {
                    maxnech = array[i];
                }
            }
        }

        if (maxch > maxnech)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                array[i] = 0;
            }
        }
        else if(maxch < maxnech)
        {
            for(int i = array.Length / 2; i < array.Length; i++)
                array[i] = 0;
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
        double min = double.MaxValue;
        double otr = 0;
        int index = 0;
        int index2 = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otr = array[i];
                index = i;
                break;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index2 = i;
            }
        }

        if (index < index2 && otr != 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            }
        }
        else if (index >= index2 || otr == 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
        }
        
        sum = Math.Round(sum, 2);
        Console.WriteLine(sum);
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
        int length = array.Length;
        bool[] prov = new bool[length];
        double kol = 0;

        double max = array[0];
        for (int i = 1; i < length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        for (int i = 0; i < length; i++)
        {
            if (array[i] == max)
            {
                prov[i] = true;
                kol++;
            }
        }

        int index = 1; 
        for (int i = 0; i < length; i++)
        {
            if (prov[i])
            {
                array[i] += index;
                index++;
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
        double[] m2 = new double[0];
        if (array.Length % 2 == 0)
            m2 = new double[array.Length / 2];
        else if (array.Length % 2 != 0)
            m2 = new double[(array.Length / 2) + 1];

        int num = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                m2[num] = array[i];
                num++;
            }
        }

        for (int i = 0; i < m2.Length - 1; i++)
        {
            double amax = m2[i];
            int imax = i;
            for (int j = i + 1; j < m2.Length; j++)
            {
                if (m2[j] < amax)
                {
                    amax = m2[j];
                    imax = j;
                }
            }
            m2[imax] = m2[i];
            m2[i] = amax;
        }

        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ( i% 2 == 0)
            {
                array[i] = m2[index];
                index++;
            }
        }

        for (int i = 0; i < m2.Length; i++)
        {
            Console.WriteLine(m2[i]);
        }
        Console.WriteLine(" ");
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }

        double[] m2 = new double[0];

        if (count != 0)
            m2 = new double[count];
        else
            return array;

        int index = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                m2[index] = array[i];
                index++;
            }
        }

        for (int i = 0; i < m2.Length - 1; i++)
        {
            double amax = m2[i];
            int imax = i;
            for (int j = i + 1; j < m2.Length; j++)
            {
                if (m2[j] > amax)
                {
                    amax = m2[j];
                    imax = j;
                }
            }
            m2[imax] = m2[i];
            m2[i] = amax;
        }

        int num = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = m2[num];
                num++;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine(" ");
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

        int count = 0;
        for (double i = a; i <= b; i += step)
        {
            double value = Math.Cos(i) + i * Math.Sin(i);
            X[count] = Math.Round(i, 2);
            Y[count] = Math.Round(value, 2);
            count++;

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
        double max = array[0], min = array[0];
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
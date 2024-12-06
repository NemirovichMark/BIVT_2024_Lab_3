using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            s = s + x;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] / s;
            array[i] = Math.Round(array[i], 2);

        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        int c = 0;
        foreach (double x in array)
        {
            if (x > 0)
            {
                s = s + x;
                c++;
            }
        }
        s = s / c;
        s = Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++)
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
            sum[i] = first[i] + second[i];
            dif[i] = first[i] - second[i];

        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;
        foreach (double x in array)
        {
            s = s + x;
            k++;

        }
        s = s / k;
        s = Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - s;
            array[i] = Math.Round(array[i], 2);

        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        double[] sum = { 0, 0, 0, 0 };
        for (int i = 0; i < vector1.Length; i++)
        {
            sum[i] = vector1[i] * vector2[i];
            sum[i] = Math.Round(sum[i], 2);
        }
        foreach (double x in sum)
        {
            product = product + x;
        }

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double s = 0;
        foreach (double x in vector)
        {

            s = s + (x * x);
            s = Math.Round(s, 2);
        }
        length = Math.Sqrt(s);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int k = 0;

        foreach (double x in array)
        {
            s = s + x;
            k++;
        }
        s = s / k;
        Math.Round(s, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > s)
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
        foreach (double x in array)
        {
            if (x < 0)
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
        int k = 0;
        double s = 0;
        foreach (double x in array)
        {
            s = s + x;
            k++;

        }
        s = s / k;
        foreach (double x in array)
        {
            if (x > s)
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
        foreach (double x in array)
        {
            if (x > P && x < Q)
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
        int size = 0;
        foreach (double i in array)
            if (i > 0) size++;

        output = new double[size];
        int j = 0;
        foreach (double i in array)
            if (i > 0)
            {
                output[j] = i;
                j++;
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
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0, j = 0; i < array.Length; i += 2)
        {
            even[j] = array[i];
            odd[j] = array[i + 1];
            j++;
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
            if (i < 0) break;
            sum += i * i;
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
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length; i++)
            Console.WriteLine($"{x[i]:F4}\t\t{y[i]:F4}");


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
        foreach (var i in array)
            if (i > max) max = i;

        foreach (var i in array)
        {
            if (i == max) break;
            sum += i;
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
        double average = 0, max = array[0];
        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
            if (array[i] >= max)
            {
                max = array[i];
                j = i;
            }
        }
        j++;
        average /= array.Length;
        average = Math.Round(average, 2);

        for (; j < array.Length; j++)
            array[j] = average;

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

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double sr = sum / array.Length;
        sr = Math.Round(sr, 2);

        double[] array2 = new double[array.Length + 1];
        int index = 0;
        double minDiff = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            double diff = Math.Abs(array[i] - sr);
            if (diff < minDiff)
            {
                minDiff = diff;
                index = i;
            }
        }
        for (int i = 0; i <= index; i++)
        {
            array2[i] = array[i];
        }
        array2[index + 1] = P;
        for (int i = index + 1; i < array.Length; i++)
        {
            array2[i + 1] = array[i];
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
        double max = array[0];
        int j = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                j = i;
            }
        }

        double min = array[j];
        int g = j;

        for (int i = j + 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                g = i;
            }
        }

        if (j == g) return array;

        double temp = array[j];
        array[j] = array[g];
        array[g] = temp;

        return array;




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
        double min = 10000;
        int index = -1;
        var res = new double[array.Length-1];

        for (int i = 0;i<array.Length;i++)
        {
            if (  array[i] > 0 && array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        if (index == -1) return array;

        for (int i = 0; i<index; i++)
        {
            res[i] = array[i];
        }

        for (int i = index + 1 ;i<array.Length; i++)
        {
            res[i-1] = array[i];
        }
        array = res;
        

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
        double x;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                x = array[i];
                index = i;
                break;
            }
        }
        double max = array[0];
        int max_index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                max_index = i;
            }
        }
        double sum = 0;
        for (int i = max_index + 1; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        if (index != -1)
        {
            array[index] = Math.Round(sum, 2);
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
        double s = -11111;
        double temp = 0;
        int y = 0;
        int j = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && j == -1)
            {
                j = i; 
            }
            if (array[i] > s) 
            {
                s = array[i]; y = i; 
            }
        }
        if (j == -1) 
        {
            return array; 
        }
        temp = array[j];
        array[j] = array[y];
        array[y] = temp;
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
        output = new int[array.Length];
        int count = 0;
        double sum = 0;
        double sr = 0;

        foreach (double x in array)
        {
            sum += x;
        }
        sr = sum / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[count] = i;
                count++;
            }
        }

        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = output[i];
        }
        output = result; 



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
        double nechet = array[0];
        double chet = array[1];

        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > nechet)
            {
                nechet = array[i];
            }
        }

        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > chet)
            {
                chet = array[i];
            }
        }

        if (nechet > chet)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
            
        }
        else for (int i = array.Length / 2; i < array.Length; i++)
            {array[i] = 0;}



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
        double min = 100000;
        int min_index = 0;
        for (int i = 0; i<array.Length ;i++)
        {
            if (array[i]< min)
            {
                min = array[i];
                min_index = i;
            }
        }
        int first = -1;
        for (int i =0;i<array.Length;i++)
        {
            if (array[i] < 0)
            {
                first = i; break;   
            }
        }
        if (first < min_index)
        {
            for (int i =0;i<array.Length;i=i+2)
            {
                sum = sum+array[i];
            }
        }
        else
        {
            for (int i = 1;i<array.Length;i = i +2)
            {
                sum = sum + array[i];




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
        double max = -10000;
        int counter = 1;

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
                array[i] += counter;
                counter++;
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

        int evenCount = (array.Length + 1) / 2;
        double[] evens = new double[evenCount];
        int evenIndex = 0;

        for (int i = 0; i < array.Length; i += 2)
        {
            evens[evenIndex] = array[i];
            evenIndex++;
        }

        for (int i = 0; i < evens.Length - 1; i++)
        {
            for (int j = i + 1; j < evens.Length; j++)
            {
                if (evens[i] > evens[j])
                {
                    double temp = evens[i];
                    evens[i] = evens[j];
                    evens[j] = temp;
                }
            }
        }

        evenIndex = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            array[i] = evens[evenIndex];
            evenIndex++;
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
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                int currentIndex = i;
                double currentMax = array[i];

                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < 0 && array[j] > currentMax)
                    {
                        currentMax = array[j];
                        currentIndex = j;
                    }
                }

                
                if (currentIndex != i)
                {
                    double temp = array[i];
                    array[i] = array[currentIndex];
                    array[currentIndex] = temp;
                }
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
        double globalMax = -99999, globalMin = 9999999;

        // code here
        X = new double[n];
        Y = new double[n];
        double step = (b - a) / (n - 1);
        int index = 0;
        for (double i = a; i <= b; i += step)
        {
            double result = Math.Cos(i) + i * Math.Sin(i);
            X[index] = Math.Round(i, 2);
            Y[index] = Math.Round(result, 2);
            index++;

            if (result > globalMax) globalMax = result;

            if (result < globalMin) globalMin = result;
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
        double[] normalizedArray = new double[array.Length];

        // code here
        double max = array[0], min = array[0];
        int n = 0;
        double normal = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
            
        }
        for (int i = 0; i < array.Length; i++)
        {
            normal = (array[i] - min) * 2 / (max - min) - 1;
            normalizedArray[n] = Math.Round(normal, 2);
            n++;
        }

        // end

        return normalizedArray;
    }
    #endregion
}
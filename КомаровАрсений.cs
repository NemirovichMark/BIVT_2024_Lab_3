using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] { 1, 2, 3, 4, 5, 6 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double summa = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summa += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (summa == 0)
            {
                array[i] = double.NaN;
                continue;
            }
            array[i] = array[i] / summa;
            array[i] = Math.Round(array[i], 2);
        }
        Console.WriteLine(array);
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double arifm = 0;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                arifm += array[i];
                counter++;
            }
        }
        arifm = Math.Round(arifm / counter, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = arifm;
        }
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        Console.WriteLine($"{sum}, {dif}");
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double med_mean = 0;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            med_mean += array[i];
            counter++;
        }
        med_mean /= counter;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - med_mean, 2);
        }
        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;
        double[] array = new double[4];
        for (int i = 0; i < vector1.Length; i++)
        {
            array[i] = vector1[i] * vector2[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            product += array[i];
        }
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;
        foreach (double x in vector) { length += x * x; }
        length = Math.Sqrt(length);
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        foreach (double x in array) sum += x;
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum) array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0;
        foreach (double x in array) sum += x;
        sum /= array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum) count++;
        }
        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q) count++;
        }
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) index++;
        }
        double[] massiv = new double[index];
        index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                massiv[index] = array[i];
                index++;
            }
        }
        output = massiv;
        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
            }
        }
        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];
        int index1 = 0, index2 = 0;
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
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else break;
        }

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] > 0) y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
            else y[i] = double.NaN;
        }
        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        double min_element = 99999999999;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_element)
            {
                min_element = array[i];
                counter = i;
            }
        }
        if (min_element < 0) min_element /= 4;
        min_element *= 2;
        array[counter] = min_element;
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
        double min_element = 99999999999;
        int counter = 0;
        double[] x = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_element)
            {
                min_element = array[i];
                counter = i;
            }
        }
        for (int i1 = 0; i1 < counter; i1++)
        {
            if (array[i1] < 0) array[i1] /= 2;
            else array[i1] *= 2;
        }
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
        double min_el = 9999999, max_el = -999999999;
        int left_flag = 0, right_flag = 0, i1 = 0;
        int index = 0, counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_el)
            {
                min_el = array[i];
                left_flag = i;
            }
            if (array[i] > max_el)
            {
                max_el = array[i];
                right_flag = i;
                i1 = i;
            }
        }
        if (right_flag < left_flag)
        {
            right_flag = left_flag;
            left_flag = i1;
        }
        double[] a = new double[right_flag - (left_flag + 1)];
        if (right_flag == left_flag + 1)
        {
            a = new double[0];
            return a;
        }
        for (int i = left_flag + 1; i < right_flag; i++)
        {
            if (array[i] < 0)
            {
                a[index] = array[i];
                index++;
            }
        }
        if (index == 0) a = new double[0];
        return a;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        double mx = -99999999;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
                counter = i;
            }
        }
        if (counter + 1 == array.Length) return array;
        else if (array[counter + 1] < 0) array[counter + 1] /= 2;
        else array[counter + 1] *= 2;
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
        double min_el = 9999999, max_el = -999999999;
        int left_flag = 0, right_flag = 0, zam = left_flag;
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min_el)
            {
                min_el = array[i];
                left_flag = i;
                zam = i;
            }
            if (array[i] > max_el)
            {
                max_el = array[i];
                right_flag = i;

            }
        }
        if (right_flag < left_flag)
        {
            left_flag = right_flag;
            right_flag = zam;
        }
        double[] a = new double[right_flag - (left_flag + 1)];
        if (a.Length > 0)
        {
            for (int i = left_flag + 1; i < right_flag; i++)
            {
                a[counter] = array[i];
                average += a[counter];
                counter++;
            }
            average /= a.Length;
            return average;
        }
        else return 0;
    }
    public double[] Task_2_10(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) counter = i;
        }
        if (counter == 0) return array;
        double[] a = new double[array.Length + 1];
        for (int i = 0; i < a.Length; i++)
        {
            if (i == counter)
            {
                a[i] = array[i];
                a[i + 1] = P;
                break;
            }
            a[i] = array[i];
        }
        return a;
    }
    public double[] Task_2_12(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_13(double[] array)
    {
        double mx = -9999999999;
        int index = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > mx) { mx = array[i]; index = i; }
        }
        array[index] = index;
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
        int index = 0;
        double[] output = new double[A.Length + B.Length];
        if (k + 1 > A.Length) return A;
        for (int i = 0; i <= k; i++)
        {
            output[index] = A[i];
            index++;
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[index] = B[i];
            index++;
        }
        for (int i = k + 1; i < A.Length; i++)
        {
            output[index] = A[i];
            index++;
        }
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
        int counter = 0;
        double mx = -9999999999999999, min = 9999999999999;
        int index_mx = 0, index_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx) { mx = array[i]; index_mx = i; }
            if (array[i] < min) { min = array[i]; index_min = i; }
        }
        if (index_mx < index_min)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) { average += array[i]; counter++; }
            }
            if (counter == 0) { return 0; }
            average = average / counter;
        }
        else
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { average += array[i]; counter++; }
            }
            if (counter == 0) { return 0; }
            average = average / counter;
        }

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
        double mx = -99999999, summa = 0;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summa += array[i];
            if (array[i] > mx) { mx = array[i]; index = i; }
        }
        if (mx > summa) { array[index] = 0; }
        else { array[index] *= 2; }
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
        int counter = 1;
        double mx = -99999999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mx)
            {
                mx = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == mx)
            {
                array[i] += counter;
                counter++;
            }
        }

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
        double el = 0;
        int counter = 0;
        for (; ; )
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && (i + 2) < array.Length && array[i] > array[i + 2])
                {
                    el = array[i + 2];
                    array[i + 2] = array[i];
                    array[i] = el;
                    counter++;
                }
            }
            if (counter == 0) return array;
            else counter = 0;
        }
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
        double el = 0;
        int counter = 0;
        for (; ; )
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < 0 && array[j] > array[i])
                        {
                            el = array[j];
                            array[j] = array[i];
                            array[i] = el;
                            counter++;
                        }
                    }

                }
            }
            if (counter == 0) return array;
            else counter = 0;
        }
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
        double[] X = new double[n], Y = new double[n];
        double globalMax = -999999999, globalMin = 9999999999;
        for (int i = 0; i < n; i++)
        {
            X[i] = a+(i*(b-a))/(n-1);
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
        }
        for (int i = 0; i < Y.Length; i++)
        {
            if (Y[i] > globalMax) globalMax = Y[i];
            if (Y[i] < globalMin) globalMin = Y[i];            
        }        
        return (X, Y, globalMax, globalMin);
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
        double mx = -99999999, min = 99999999999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > mx) mx = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = ((2 * (array[i] - min)) / (mx - min)) - 1;
        }
        return normalizedArray;
    }
    #endregion
}
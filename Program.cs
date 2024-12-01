using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        // code here
        var ishod = string.Join(" ", array);

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        var result = string.Join(" ", array);
        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        var ishod = string.Join(" ", array);

        double sum = 0, kol = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                kol += 1;
            }
        }
        double sred_arif = Math.Round(sum / kol, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sred_arif;
            }
        }

        var result = string.Join(" ", array);
        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        var ishod1 = string.Join(" ", first);
        var ishod2 = string.Join(" ", second);
        double k = 0, kol = 0;

        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        var result_sum = string.Join(" ", sum);
        var result_dif = string.Join(" ", dif);
        Console.WriteLine("исходные данные: 1) {0}  2) {1}", ishod1, ishod2);
        Console.WriteLine("результат: 1) {0}  2) {1}", result_sum, result_dif);
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        var ishod1 = string.Join(" ", array);

        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double sred = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sred, 2);
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", result);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        var ishod1 = string.Join(" ", vector1);
        var ishod2 = string.Join(" ", vector2);

        for (int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }

        product = Math.Round(product, 2);

        Console.WriteLine("исходные данные: 1) {0}  2) {1}", ishod1, ishod2);
        Console.WriteLine("результат: {0}", product);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        var ishod1 = string.Join(" ", vector);

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }

        length = Math.Sqrt(length);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", Math.Round(length, 2));
        // end

        return Math.Round(length, 4);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        var ishod1 = string.Join(" ", array);
        double sum = 0, sred = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sred = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred)
            {
                array[i] = 0;
            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", result);
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        var ishod1 = string.Join(" ", array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count += 1;
            }
        }

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        var ishod1 = string.Join(" ", array);
        double sum = 0, sred = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sred = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sred)
            {
                count += 1;
            }
        }

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", count);
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        var ishod1 = string.Join(" ", array);

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] > P) && (array[i] < Q))
            {
                count += 1;
            }
        }
        
        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", count);
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        var ishod1 = string.Join(" ", array);
        int kol = 0;

        foreach (var item in array)
        {
            if (item > 0)
            {
                kol += 1;
            }
        }
        output = new double[kol];
        kol = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[kol] = array[i];
                kol += 1;
            }
        }
        var result = string.Join(" ", output);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", result);
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        var ishod1 = string.Join(" ", array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                value = array[i];
                index = i;
            }
        }
        //var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: 1)значение {0}  2)номер {1}", value, index);
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        var ishod1 = string.Join(" ", array);
        int chet = 0, nechet = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[chet] = array[i];
                chet++;
            }
            else
            {
                odd[nechet] = array[i];
                nechet++;
            }
        }
        var result_even = string.Join(" ", even);
        var result_odd = string.Join(" ", odd);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: 1)четные {0}  2)нечетные {1}", result_even, result_odd);
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        var ishod1 = string.Join(" ", array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else { break; }
        }
        
        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", sum);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        var ishod1 = string.Join(" ", x);

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * (Math.Log(x[i], Math.E)), 2);
            }
        }
        var result = string.Join(" ", y);

        Console.WriteLine("исходные данные: {0}", ishod1);
        Console.WriteLine("результат: {0}", result);
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here

        var ishod = string.Join(" ", array);
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (min == array[i])
            {
                if (array[i] < 0)
                {
                    array[i] *= 0.5;
                }
                else
                {
                    array[i] *= 2;
                }
            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
        
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
        
        var ishod = string.Join(" ", array);
        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (min == array[i])
            {
                break;
            }
            else
            {
                if (array[i] < 0)
                {
                    array[i] *= 0.5;
                }
                else
                {
                    array[i] *= 2;
                }

            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);

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
        var ishod = string.Join(" ", array);
        double max = -1000, min = 1000, kol = 0;
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] == max) || (array[i] == min))
            {
                kol++;
            }
            else if (kol > 0 && kol < 2 && array[i] < 0)
            {
                count++;
            }
        }
        double[] new_array = new double[count];
        kol = 0;
        count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] == max) || (array[i] == min))
            {
                kol++;
            }
            else if (kol > 0 && kol < 2)
            {
                if (array[i] < 0)
                {
                    new_array[count] = array[i];
                    count++;
                }
                
            }
        }
        array = new_array;
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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
        var ishod = string.Join(" ", array);
        double max = -1000;
        

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max && ((i+2) < array.Length))
            {
                if (array[i + 1] < 0)
                {
                    array[i + 1] = array[i + 1] * 0.5;
                    break;
                }
                else
                {
                    array[i + 1] = array[i + 1] * 2;
                    break;
                }
            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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
        var ishod = string.Join(" ", array);
        double max = -1000, min = 1000, kol = 0;
        double count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] == max) || (array[i] == min))
            {
                kol++;
            }
            else if (kol > 0 && kol < 2)
            {
                average += array[i];
                count++;
            }
        }
        var result = string.Join(" ", array);
        if (count > 0)
        {
            average /= count;
        }

        Console.WriteLine("исходные данные: {0}", ishod);
        
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
        var ishod = string.Join(" ", array);
        int count = 0, kol = 0;
        double index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index = array[i];
                kol++;
            }
        }
        if (kol > 0)
        {
            double[] new_array = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == index)
                {
                    new_array[i] = array[i];
                    new_array[i + 1] = P;
                    count++;
                }
                else
                {
                    new_array[i + count] = array[i];
                }
            }
            array = new_array;
        }
        
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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
        var ishod = string.Join(" ", array);
        int index = 0;
        double max = -1000;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 && array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        array[index] = index;
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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
        var ishodA = string.Join(" ", A);
        var ishodB = string.Join(" ", B);
        output = new double[A.Length + B.Length];
        int countB = 0, countA = 0;


        for (int i = 0; i < output.Length; i++)
        {
            if (k+1 < A.Length)
            {
                if (i <= k)
                {
                    output[i] = A[countA];
                    countA++;
                }
                else if (i > k && i <= (k + B.Length))
                {
                    output[i] = B[countB];
                    countB++;
                }
                else
                {
                    output[i] = A[countA];
                    countA++;
                }
            }
            else
            {
                output = A;
                break;
            }
        }

        var result = string.Join(" ", output);

        Console.WriteLine("исходные данные:A {0}", ishodA);
        Console.WriteLine("исходные данные:B {0}", ishodB);
        Console.WriteLine("результат: {0}", result);
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
        var ishod = string.Join(" ", array);
        double max = -1000, min = 1000, sumplus = 0, summinus = 0, kolplus = 0, kolminus = 0;
        int indexmax = 0, indexmin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sumplus += array[i];
                kolplus++;
            }
            if (array[i] < 0)
            {
                summinus += array[i];
                kolminus++;
            }
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        if (indexmax < indexmin && kolplus != 0)
        {
            average = sumplus / kolplus;
        }
        else if (indexmax > indexmin && kolminus != 0)
        {
            average = summinus / kolminus;
        }
        else
        {
            average = 0;    
        }
        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", average);
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
        var ishod = string.Join(" ", array);
        int index = 0;
        double max = -1000, sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];    
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        if (max > sum)
        {
            array[index] = 0;
        }
        else
        {
            if (max > 0)
            {
                array[index] = max * 2;
            }
            else
            {
                array[index] = max * 0.5;
            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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
        var ishod = string.Join(" ", array);
        int index = 0;
        double max = -1000, posrednik = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i+1 < index && i % 2 == 0)
            {
                posrednik = array[i];
                array[i] = array[i + 1];
                array[i + 1] = posrednik;
            }
        }
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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

        // code here
        count = 1;
        var ishod = string.Join(" ", array);
        double posl = array[0];
        int max = 0;
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < posl)
            {
                count++;
                posl = array[i];
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                posl = array[i];    
                if (count > max)
                {
                    max = count;
                }
                count = 1;
            }
        }
        if (max == 1)
        {
            count = 0;
        }
        else
        {
            count = max;
        }
        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", count);
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
        count = 1;
        var ishod = string.Join(" ", array);
        double posl = array[0];
        int max = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (posl > array[i])
            {
                count++;
                posl = array[i];
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                posl = array[i];
                if (count > max)
                {
                    max = count;
                }
                count = 1;
            }
        }
        posl = array[0];
        count = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (posl < array[i])
            {
                count++;
                posl = array[i];
                if (count > max)
                {
                    max = count;
                }
            }
            else
            {
                posl = array[i];    
                if (count > max)
                {
                    max = count;
                }
                count = 1;
            }
        }
        if (max == 1)
        {
            count = 0;
        }
        else
        {
            count = max;
        }
        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", count);
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
        var ishod = string.Join(" ", array);
        int count = 0, j = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                count++;
            }
        }
        double[] new_array = new double[array.Length - count];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                new_array[j] = array[i];
                j++;
            }
            
        }
        array = new_array;
        var result = string.Join(" ", array);

        Console.WriteLine("исходные данные: {0}", ishod);
        Console.WriteLine("результат: {0}", result);
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

        // end

        return normalizedArray;
    }
    #endregion
}
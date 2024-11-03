using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        //program.Task_3_6(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double suma = 0;
        for (int i = 0; i < 6; i++)
        {
            suma += array[i];
        }
        for (int i = 0; i < 6; i++)
        {
            array[i] /= suma;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int k = 0;
        double suma = 0, sr = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                suma += array[i];
                k++;
            }
        }
        sr = suma / k;
        sr = Math.Round(sr, 2);
        for (int i = 0; i < 8; i++)
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
        double suma = 0, sr = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += array[i];
        }
        sr = suma / 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
            product += vector1[i] * vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        double suma = 0;
        for (int i = 0; i < 5; i++)
            suma += vector[i] * vector[i];
        length = Math.Sqrt(suma);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0, suma = 0;
        for (int i = 0; i < 7; i++)
            suma += array[i];
        sr = suma / 7;
        for (int i = 0; i < 7; i++)
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
        for (int i = 0; i < 6; i++)
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
        double sr = 0, suma = 0;
        for (int i = 0; i < 8; i++)
            suma += array[i];
        sr = suma / 8;
        for (int i = 0; i < 8; i++)
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
        for (int i = 0; i < 10; i++)
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
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
                k++;
        }
        output = new double[k];
        k = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[k] = array[i];
                k++;
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
        for (int i = 0; i < 8; i++)
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
        int k = 0, c = 0;
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[c] = array[i];
                c++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++)
        {
            if (array[i] < 0) break;
            sum += array[i] * array[i];
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++)
        {
            if (x[i] <= 0)
                y[i] = double.NaN;
            else
            {
                y[i] = 0.5 * Math.Log(x[i]);
                y[i] = Math.Round(y[i], 2);
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
        double maxi = -1;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
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
        double maxi = -1, suma = 0, sr = 0;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
            suma += array[i];
        }
        sr = suma / array.Length;
        for (int i = index + 1; i < array.Length; i++)
        {
            array[i] = sr;
            array[i] = Math.Round(array[i], 2);
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
        double suma = 0, sr = 0, mini = 100000000;
        int index = -1;
        for (int i = 0; i < array.Length; i++)
                suma += array[i];
        sr = suma / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) <= mini)
            {
                mini = Math.Abs(array[i] - sr);
                index = i;
            }
        }
        double[] b = new double[array.Length + 1];
        for (int i = 0; i <= index; i++) // <= тк вставить новое число нужно после
            b[i] = array[i];
        b[index + 1] = P;
        for (int i = index + 1; i < array.Length; i++)
            b[i+1] = array[i]; // i+1 тк у массива b на 1 число больше, значит и индекс на 1 больше
        array = b;
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
        double maxi = -1, mini = 10000000, p;
        int indexmaxi = -1, indexmini = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxi)
            {
                maxi = array[i];
                indexmaxi = i;
            }
        }
        for (int i = indexmaxi + 1; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                indexmini = i;
            }
        }
        if (indexmaxi + 1 != array.Length) // проверка на то, что maxi не стоит последним элементом
        {
            array[indexmaxi] = mini;
            array[indexmini] = maxi;
        }
        Console.WriteLine(array[indexmaxi]);
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
        double mini = 100000000;
        int index = -1, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 0) k++;// считаем отрицательные элементы
            if (array[i] > 0 && array[i] < mini)
            {
                index = i;
                mini = array[i];
            }
        }
        Console.WriteLine(index);
        double[] b = new double[array.Length - 1];
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i < index)
                b[i] = array[i];
            else
                b[i] = array[i + 1];
        }
        if (k != array.Length) array = b; // проверяем не все ли элементы в массиве отрицательные, если не все то заменяем на новый массив, иначе останется исходный
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
        double maxi = -10000000, suma = 0 ;
        int indexmaxi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                indexmaxi = i;
                maxi = array[i];
            }
        }
        for (int i = indexmaxi + 1; i < array.Length; i++)
        {
            suma += array[i];
        }
        suma = Math.Round(suma, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = suma;
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
        double maxi = -10000000 , a = 1;
        int indexmaxi = -1, indexfirst = -1, k = 0;
        for (int i = 0; i < array.Length; i++)
        {       
            if (array[i] > maxi)
            {
                indexmaxi = i;
                maxi = array[i];
            }
            if (array[i] > 0) k++; //считаем количество положительных элементов

        }
        for (int i = 0; i < array.Length; i++)// 2 цикла потому что если break включить в первый цикл, мы не найдем максимальное число
        {
            if (array[i] < 0)
            {
                indexfirst = i;
                a = array[i];
                break;
            }
        }
        if (k != array.Length)
        {
            array[indexmaxi] = a;
            array[indexfirst] = maxi;
        }
        //end

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
        double sr = 0,  suma = 0, mini = 100000000000, a;
        int indexsr = -1, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }
        sr = suma / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]!= 0 && Math.Abs(array[i] - sr) < mini)// != 0 тк если мы вычтем 0 из среднего значения, то получим, что оно будет ему равно, и что 0 и будет самым ближайшим к среднему,хотя это не так
            {
                mini = array[i] - sr;
                indexsr = i;
            }
        }
        a = array[indexsr];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) k++;
        }
        output = new int[k];
        k = 0;
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
        double maxich = -1, maxinch = -1; 
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > maxich)
                {
                    maxich = array[i];
                }
            }
            else
            {
                if (array[i] > maxinch)
                {
                    maxinch = array[i];
                }
            }
        }
        if (maxich > maxinch)
        {
            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    array[i] = 0;
                }
            }
            else
            {
                for (int i = 0; i < array.Length / 2 - 1; i++)
                {
                    array[i] = 0;
                }
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
        double mini = 10000000, indexmini = -1, indexfirst = -1;
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                indexmini = i;
            }
            if (array[i] < 0) k++;// считаем количество отрицательных элементов

        }
        if (k == 0) sum = 0;
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indexfirst = i;
                    break;
                }
            }
            if (indexfirst < indexmini)
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
        double maxi = -1000000, c;
        int indexmaxi = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                indexmaxi = i;
            }
        }
        if (indexmaxi != 0)
        {
            for (int i = 0; i < indexmaxi - 1; i += 2)
            {
                c = array[i];
                array[i] = array[i + 1];
                array[i + 1] = c;
            }
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

        // code here
        int maxicount = -1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                count++;
            }
            if (count > maxicount)
            {
                maxicount = count;
            }
            if (array[i] <= array[i + 1]) count = 0;
            //Console.WriteLine($"i = {i}, {array[i]} ? {array[i+1]}, count = {count}, maxi = {maxicount}");
        }
        count = maxicount + 1;// +1 см вывод выше
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
        int maxicount_up = -1, c_up = 0,maxicount_down = -1, c_down = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                c_up++;
            }
            if (c_up > maxicount_up)
            {
                maxicount_up = c_up;
            }
            if (array[i] >= array[i + 1]) c_up = 0;
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                c_down++;
            }
            if (c_down > maxicount_down)
            {
                maxicount_down = c_down;
            }
            if (array[i] <= array[i + 1]) c_down = 0;
        }
        if (maxicount_down > maxicount_up) count = maxicount_down + 1;
        else count = maxicount_up + 1;
        // +1 в ответ, также как и в 3_6 задаче

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
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) k++;
        }
        if (k != 0)
        {
            double[] b = new double[array.Length - k];
            k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    b[k] = array[i];
                    k++;
                }
            }
            array = b;
        }
        else
        {
            double[] b = new double[0];
            array = b;
        }

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
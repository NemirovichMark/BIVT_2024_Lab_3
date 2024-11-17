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
        //program.Task_1_1(new double[] { 1, 2, 3, 4, 5, 6 });
        //program.Task_1_2(new double[] { 1, 2, 3, 4, -5, -6, -7, -8 });
        //program.Task_1_3(new double[] { 1, -2, 3, -4 }, new double[] { -1, 2, -3, 4 });
        //program.Task_1_4(new double[] { 1, 2, 3, 4, 5 });
        //program.Task_1_5(new double[] { 1, -2, 3, -4 }, new double[] { -1, 2, -3, 4 });
        //program.Task_1_6(new double[] { 1, 2, 3, 4, 5 });
        //program.Task_1_7(new double[] { 1, 2, 3, 4, 5, 6, 7 });
        //program.Task_1_8(new double[] { 1, 2, 3, 4, 5, 6 });
        //program.Task_1_9(new double[] { 1, 2, 3, 4, -5, -6, -7, -8 });
        //program.Task_1_10(new double[] { 2, 1, 3, 3, 5, 6, 3, 4, 5, 0 }, 3, 4);
        //program.Task_1_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_1_12(new double[] { 1, 2, 3, 4, -5, -6, -7, 8 });
        //program.Task_1_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1.9, 3.9, -0.1 });
        //program.Task_1_14(new double[] { 1, 2, 3, 4, 5, -6, 1, 2, 3, 4, 5 });
        //program.Task_1_15(new double[] { 2, -1, 3, -3, 5, 6, -3, 4, 5, 10 });
        //program.Task_2_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_2_4(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        //program.Task_2_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_8(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_10(new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 });
        //program.Task_2_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_16(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_18(new double[] { 15, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        program.Task_2_20(new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 });
        //program.Task_3_3(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_6(new double[] { 0, 1.5, 1, -1.3, -2.2, -0.5, 2 });
        //program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_3_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double s = 0;

        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / s, 2);
            Console.WriteLine(array[i]);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0, m = 0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s = s + array[i];
                m += 1;
            }
        }
        double sr = s / m;
        sr = Math.Round(sr, 2);
        
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
            }
            Console.WriteLine(array[i]);
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
            dif[i] = Math.Round(first[i] - second[i], 2);
            Console.WriteLine(sum[i] + "  " + dif[i]);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);        

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - sr, 2);
            Console.WriteLine(array[i]);
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
        product = Math.Round(product, 2);
        Console.WriteLine(product);

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        Console.WriteLine(length);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here

        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                array[i] = 0;                
            }
            Console.WriteLine(array[i]);
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
            {
                count++;
            }            
        }
        Console.WriteLine(count);

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        double sr = 0, k = 0;
        foreach (double i in array)
        {
            sr += i;
            k++;
        }
        sr = Math.Round(sr / k, 2);

        foreach (double i in array)
        {
            if (i > sr)
            {
                count++;
            }            
        }
        Console.WriteLine(count);

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here

        foreach (double i in array)
        {
            if ((i > P) && (i < Q))
            {
                count++;
            }
        }
        Console.WriteLine(count);

        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7
        int k = 0, j = 0;
        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                k++;
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        output = new double[k];
        Console.Write(" Новый массив: ");
        for (int i = 0; j < k; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                Console.Write(output[j] + " ");
                j++;
            }            
        }
        Console.WriteLine();

        // end 1.5, 1, 3, 2, 2, 3.1

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1, k = 0;

        // code here

        foreach (double i in array)
        {
            if (i < 0)
            {
                value = i;
                index = k;
            }
            k++;
        }
        Console.WriteLine(value + " " + index);

        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        int j = 0, k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if ((i % 2) == 1)
            {
                odd[j] = array[i];
                Console.WriteLine($"\t {odd[j]}");
                j++;
            }
            else
            {
                even[k] = array[i];
                Console.WriteLine(even[k]);
                k++;
            }
        }

        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here

        for (int i = 0; ((array.Length > i) && (array[i] >= 0)); i++)
        {
            sum += array[i] * array[i];
        }
        Console.WriteLine(sum);

        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here

        for (int i = 0; i < x.Length; i++)
        {
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            if (x[i] <= 0)
                y[i] = double.NaN;
            Console.WriteLine($"{x[i]}\t  {y[i]}");
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
        double elemax = array[0];
        int indexmax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
        }

        for (int i = 0; i < indexmax; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Сумма элементов = " + sum + " до элемента " + elemax + " под индексом " + indexmax);
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
        double sum = 0, elemax = array[0], sr = 0;
        int indexmax = 0;

        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {            
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            sum += array[i];            
            Console.Write(array[i] + "  ");
            
        }
        Console.WriteLine();
        sr = Math.Round(sum / array.Length, 2);

        for (int i = indexmax + 1; i < array.Length; i++)
        {
            array[i] = sr;
        }

        Console.Write(" Новый массив: ");
        for (int i = 0; i < array.Length; i++)
        {            
            Console.Write(array[i] + "  ");
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
        double sum = 0, elemax = array[0], sr = 0, blizost = 999;
        int indexmax = 0, indexbliz = 0;
        double[] a = new double[array.Length + 1];

        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            sum += array[i];
            Console.Write(array[i] + "  ");

        }
        Console.WriteLine();
        sr = Math.Round(sum / array.Length, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(sr - array[i]) < blizost)
            {
                blizost = Math.Abs(sr - array[i]);
                indexbliz = i;
            }
        }

        Console.Write(" Новый массив: ");
        for (int i = 0; i <= indexbliz; i++)
        {
            a[i] = array[i];
            Console.Write(a[i] + "  ");
        } // первая часть нового массива

        a[indexbliz + 1] = P; // новый элемент
        Console.Write(P + "  ");

        for (int i = indexbliz + 2, j = indexbliz + 1; i < a.Length; i++, j++)
        {
            a[i] = array[j];
            Console.Write(a[i] + "  ");
        } // вторая часть нового массива
        Console.WriteLine();
        Console.WriteLine();
        array = a;

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
        // code here { 0, 1.5, 1, 3, -2.2, -0.5, 2 }
        double elemax = -999,  elemin = 999, reserv = 0;
        int indexmax = 0, indexmin = 999;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            Console.Write(array[i] + " ");
        }
        for (int i = (indexmax + 1); i < array.Length; i++)
        {
            if (array[i] < elemin)
            {
                elemin = array[i];
                indexmin = i;
            }
        }        
        if (indexmax == (array.Length - 1))
        {
            elemin = elemax;
            indexmin = indexmax;
        }
        for (int i = 0; i < array.Length; i++)
        {
            reserv = elemax;
            if (i == indexmax)
            {
                array[i] = elemin;
            }
            if (i == indexmin)
            {
                array[i] = elemax;
            }
            //Console.WriteLine(array[i]);
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
        // code here  0, 1.5, 1, 3, -2.2, -0.5, 2
        double[] a = new double[array.Length - 1];
        double elemin = 999;
        int indexmin = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < elemin)
            {
                elemin = array[i];
                indexmin = i;
            }
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        if (indexmin == -1)
            return array; 

        for (int i = 0; i < indexmin; i++)
        {
            a[i] = array[i];
            Console.Write(a[i] + " ");
        }
        for (int i = indexmin; i < a.Length; i++)
        {
            a[i] = array[i + 1];
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        array = a;
        // end  0, 1.5, 3, -2.2, -0.5, 2

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
        // code here 0, 1.5, 1, 3, -2.2, -0.5, 2
        double elemax = -999, sum = 0;
        int indexmax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        for (int i = indexmax + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = sum;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
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
        // code here 0, 1.5, 1, 3, -2.2, -0.5, 2
        double elemax = -999, elemin = 0;
        int indexmax = 0, indexmin = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                elemin = array[i];
                indexmin = i;
                break;
            }
        }

        if (indexmin == -1)
            return array;

        array[indexmax] = elemin;
        array[indexmin] = elemax;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

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

        double sum = 0, srednee = 0;
        int dlina = 0, j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        srednee = sum / array.Length;
        Console.WriteLine("Среднее арифметическое: " + srednee);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < srednee)
            {
                dlina++;
            }
        }
        output = new int[dlina];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < srednee)
            {
                output[j] = i;
                j++;
            }
        }
        for (int i = 0; i < output.Length; i++)
        {
            Console.Write(output[i] + " ");
        }
        Console.WriteLine();
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

        double chetmax = 0, nechetmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1 && array[i] > chetmax) 
                chetmax = array[i];
            if (i % 2 == 0 && array[i] > nechetmax) 
                nechetmax = array[i];
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(chetmax + " " + nechetmax);
        if (nechetmax > chetmax)
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
        for (int i = 0; i < array.Length; i++)
        { 
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
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

        // code here   0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1

        double elemin = 999;
        int indexotriz = 999, indexmin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < elemin)
            {
                elemin = array[i];
                indexmin = i;                
            }
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                indexotriz = i;
                break;
            }
        }
        Console.WriteLine("индекс мин = " + indexmin + ", индекс отриц = " + indexotriz);

        //if (indexotriz == -1)
        //{
        //    Console.WriteLine("сумма = 0");
        //    return 0;
        //}

        if (indexotriz < indexmin)
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
        Console.WriteLine("сумма = " + sum);
        // end 14

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
        // code here 0, 1.5, 1, 3, -2.2, -0.5, 3
        double elemax = -999, reserv = 0;
        int indexmax = 0;

        //Console.Write("Развернутый массив: ");
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] >= elemax)
            {
                elemax = array[i];
                indexmax = i;
            }
            //Console.Write(array[i] + " ");
        }
        //Console.WriteLine();

        Console.Write("Новый массив: ");
        for (int i = 0; i < indexmax-1; i += 2)
        {
            reserv = array[i + 1];
            array[i + 1] = array[i];
            array[i] = reserv;
        }
        for (int i = 0; i < array.Length; i++)
        {            
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // end 1.5, 0, 1, 3, -2.2, -0.5, 3

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
        int count = 0, k = 0;

        // code here 0, 1.5, 1, -1.3, -2.2, -0.5, 2

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            { 
                k++;
            }
            else
            {
                if (k > count)
                {
                    count = k;
                }
                k = 1;
            }
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Длина наибольшей упорядоченной последовательности = " + count);

        // end = 4

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

        // code here  5, 2, 8, 1, 9, 3, 7, 4, 6, 10
        int Kvozr = 1, KyBblv = 1, Cvozr = 1, CyBblv = 1;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] < array[i])
            {
                KyBblv++;
            }
            else
            {
                if (KyBblv > CyBblv)
                {
                    CyBblv = KyBblv;
                }
                KyBblv = 1;
            }
        }
        for (int i = 0; i < array.Length - 1; i++)
        { 
            if (array[i + 1] > array[i])
                {
                    Kvozr++;
                }                                    
            else
            {           
                if (Kvozr > Cvozr)
                {
                    Cvozr += Kvozr;
                }
                Kvozr = 1;
            }            
        }
        
        if (Cvozr > CyBblv)
            count += Cvozr;
        else
            count += CyBblv;
        Console.WriteLine("Длина наибольшей упорядоченной последовательности = " + count);

        // end 4

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
        // code here 0, 1.5, 1, 3, -2.2, -0.5, 3
        int dlina = 0;

        Console.Write("Старый массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                dlina++;
            }
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        double[] otvet = new double[dlina];

        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                otvet[j] = array[i];
                j++;
            }
        }
        array = otvet;
        Console.Write(" Новый массив: ");
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        // end 0, 1.5, 1, 3, 3

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
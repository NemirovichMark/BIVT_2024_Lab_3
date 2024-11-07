using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.IO.IsolatedStorage;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;


public class MyArray
{
    public double[] Insert(double[] array, int index, double element)
    {
        double[] tmp = new double[array.Length + 1];

        for (int i = 0; i < tmp.Length; i++)
        {
            if (i < index) tmp[i] = array[i];
            else if (i == index) tmp[i] = element;
            else tmp[i] = array[i - 1];
        }

        return tmp;
    }

    public double[] Append(double[] array, double element)
    {
        if (Equals(array, null)) return [element];

        double[] tmp = new double[array.Length + 1];

        for (int i = 0; i < array.Length; i++) tmp[i] = array[i];
        tmp[tmp.Length - 1] = element;

        return tmp;
    }

    public int[] Append(int[] array, int element)
    {
        if (Equals(array, null)) return [element];

        int[] tmp = new int[array.Length + 1];

        for (int i = 0; i < array.Length; i++) tmp[i] = array[i];
        tmp[tmp.Length - 1] = element;

        return tmp;
    }

    public double[] Delete(double[] array, int index)
    {
        double[] tmp = new double[array.Length - 1];
        
        for(int i = 0; i < array.Length; i++)
        {
            if (i < index) tmp[i] = array[i];
            else if (i > index) tmp[i - 1] = array[i];
        }

        return tmp;
    }

    public double[] Replace(double[] array, int first_elem_idx, int second_elem_idx)
    {
        if (first_elem_idx < 0 || first_elem_idx >= array.Length ||
             second_elem_idx < 0 || second_elem_idx >= array.Length) return array;

        double tmp = array[first_elem_idx];
        array[first_elem_idx] = array[second_elem_idx];
        array[second_elem_idx] = tmp;

        return array;
    }

    public double Avg(double[] array)
    {
        double avg = 0;
        foreach (int i in array) avg += i;
        
        return avg / array.Length;
    }

    public double Max(double[] array)
    {
        double maximum = array[0];
        foreach (int i in array) if (i > maximum) maximum = i;

        return maximum;
    }

    public int MaxIdx(double[] array)
    {
        double maximum = array[0];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                index = i;
            }
        }

        return index;
    }

    public double Min(double[] array)
    {
        double minimum = array[0];
        foreach (int i in array) if (i < minimum) minimum = i;

        return minimum;
    }

    public int MinIdx(double[] array)
    {
        double minimum = array[0];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
                index = i;
            }
        }

        return index;
    }

    public double[] CutBefore(double[] array, int marker_idx)
    {
        if (marker_idx < 0 || marker_idx >= array.Length) return array;

        double[] tmp = new double[marker_idx];
        for (int i = 0, j = 0; i < marker_idx; i++, j++) tmp[j] = array[i];

        return tmp;
    }
    
    public double[] CutAfter(double[] array, int marker_idx)
    {
        if (marker_idx < 0 || marker_idx >= array.Length - 1) return array;

        double[] tmp = new double[array.Length - marker_idx - 1];
        for (int i = marker_idx + 1, j = 0; i < array.Length; i++, j++) tmp[j] = array[i];

        return tmp;
    }

    public double[] CutBetween(double[] array, int first_marker_idx, int second_marker_idx)
    {
        if (first_marker_idx < 0 || first_marker_idx >= array.Length ||
            second_marker_idx < 0 || second_marker_idx >= array.Length) return array;

        double[] tmp = new double[second_marker_idx - first_marker_idx + 2];
        for (int i = first_marker_idx + 1, j = 0; i < second_marker_idx; i++, j++) tmp[j] = array[i];
        
        return tmp;
    }


    public int PositiveElemCount(double[] array)
    {
        int count = 0;        
        foreach(double i in array) if (i > 0) count++;

        return count;
    }
    public int NegativeElemCount(double[] array)
    {
        int count = 0;
        foreach (double i in array) if (i < 0) count++;

        return count;
    }

    public double[] PositiveElemArray(double[] array)
    {
        double[] tmp = new double[PositiveElemCount(array)];

        for (int i = 0, j = 0; (i < array.Length && j < tmp.Length); i++)
        {
            if (array[i] > 0)
            {
                tmp[j] = array[i];
                j++;
            }
        }        

        return tmp;
    }

    public double[] NegativeElemArray(double[] array)
    {
        double[] tmp = new double[NegativeElemCount(array)];

        for (int i = 0, j = 0; (i < array.Length && j < tmp.Length); i++)
        {
            if (array[i] < 0)
            {
                tmp[j] = array[i];
                j++;
            }
        }

        return tmp;
    }

    public double Sum(double[] array)
    {
        double summary = 0;
        foreach (double i in array) summary += i;
        
        return summary;
    }
}



public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_1(new double[] { 0, 1.5, 1, 3, -2.2, -0.5 });
        
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here

        double summary = 0;

        foreach (double i in array) 
        {
            summary += i;    
        }      

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] / summary, 2);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        double avg = 0;
        int positive_number_count = 0;

        foreach (double i in array) 
        {
            if (i > 0)
            {
                avg += i;
                positive_number_count++;
            }
        }

        avg = Math.Round(avg / positive_number_count, 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = avg;
        }

        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here

        for (int i = 0; i < sum.Length; i++)
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

        double avg = 0;

        foreach (double i in array) { avg += i;}

        avg = avg / array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i] - avg, 2);
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

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        
        foreach(double i in vector)
        {
            length += i*i;
        }

        length = Math.Round(Math.Pow(length, 0.5), 2);

        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        MyArray myArray = new MyArray();
        double avg = Math.Round(myArray.Avg(array),2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > avg) array[i] = 0;
        }

        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        MyArray myArray = new MyArray();
        count = myArray.NegativeElemCount(array);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        MyArray myArray = new MyArray();
        double avg = Math.Round(myArray.Avg(array),2);

        foreach (double i in array) { if (i > avg) count++;}
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        if (P < 0 || Q > 10) return 0;

        foreach (double i in array) if (P < i && i < Q) count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        MyArray myArray = new MyArray();
        Console.WriteLine(myArray.PositiveElemCount(array));
        output = myArray.PositiveElemArray(array);
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] < 0) { 
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
        for (int i = 0, even_idx = 0, odd_idx = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) { even[even_idx] = array[i]; even_idx++; }
            else { odd[odd_idx] = array[i]; odd_idx++; }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        int first_negative_elem_idx = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { first_negative_elem_idx = i; break; }
        }

        if (first_negative_elem_idx == -1) first_negative_elem_idx = array.Length;

        for (int i = 0; i < first_negative_elem_idx; i++) sum += array[i] * array[i];
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] < 1) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);            
        }

        for(int i = 0; i < x.Length; i++) Console.WriteLine($"x = {x[i]}, y = {y[i]}");            
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
        MyArray myArray = new MyArray();
        int maximum_elem_idx = myArray.MaxIdx(array);

        for (int i = 0; i < maximum_elem_idx; i++) sum += array[i];
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
        MyArray myArray = new MyArray();
        int maximum_elem_idx = myArray.MaxIdx(array);
        double avg = Math.Round(myArray.Avg(array), 1);

        for (int i = maximum_elem_idx + 1; i < array.Length; i++) array[i] = avg;
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
        double avg = 0, minimum_difference = double.MaxValue;
        int close_to_avg_index = 0;

        foreach (double i in array) avg += i;
        avg /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - avg) < minimum_difference)
            {
                minimum_difference = Math.Abs(array[i] - avg);
                close_to_avg_index = i;
            }
        }

        close_to_avg_index++;

        MyArray myArray= new MyArray();
        array = myArray.Insert(array, close_to_avg_index, P);
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
        if (array.Length < 2) return array;

        int maximux_elem_idx = 0, minimum_idx_after_max = 0;
        double maximum = array[0], minimum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maximum) { 
                maximum = array[i]; maximux_elem_idx = i; 
                minimum = array[i]; minimum_idx_after_max = i;
            }
            if (array[i] < minimum) { minimum = array[i]; minimum_idx_after_max = i; }
        }

        MyArray myArray= new MyArray();
        array = myArray.Replace(array, maximux_elem_idx, minimum_idx_after_max);

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
        int minimum_elem_idx = -1;
        double minimum = double.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < minimum)
            {
                minimum = array[i];
                minimum_elem_idx = i;
            }
        }

        if (minimum_elem_idx == -1) return array;

        MyArray myArray = new MyArray();
        array = myArray.Delete(array, minimum_elem_idx);                

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
        int first_negative_elem_idx = -1;

        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                first_negative_elem_idx = i;
                break;
            }
        }
        if (first_negative_elem_idx == -1) return array;

        //double maximum = double.MinValue, summary_after_maximum = 0;
        //int maximum_elem_idx = 0;

        //for(int i = 0;i < array.Length; i++)
        //{
        //    summary_after_maximum += array[i];
        //    if (array[i] > maximum)
        //    {
        //        maximum = array[i];
        //        maximum_elem_idx = i;
        //        summary_after_maximum = 0;
        //    }            
        //}

        MyArray myArray = new MyArray();
        int maximum_idx = myArray.MaxIdx(array);

        double summary_after_maximum = 0;
        for (int i = maximum_idx + 1; i < array.Length; i++) summary_after_maximum += array[i];

        array[first_negative_elem_idx] = Math.Round(summary_after_maximum, 1);

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
        int first_negative_elem_idx = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                first_negative_elem_idx = i;
                break;
            }
        }

        if (first_negative_elem_idx == -1) return array;

        MyArray myArray = new MyArray();
        array = myArray.Replace(array, first_negative_elem_idx, myArray.MaxIdx(array));
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
        MyArray myArray = new MyArray();
        double avg = myArray.Avg(array);

        for (int i = 0; i < array.Length; i++) if (array[i] < avg) output = myArray.Append(output, i);
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
        double maximum_even = array[0], maximum_odd = array[1];
        int max_even_idx = 0, max_odd_idx = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                if (array[i] > maximum_odd) { maximum_odd = array[i]; max_odd_idx = i; }
            }
            else 
            {                
                if (array[i] > maximum_even) { maximum_even = array[i]; max_even_idx = i; }
            }
        }

        if (maximum_even > maximum_odd) for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        else for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;

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
        MyArray myArray = new MyArray();
        int minimum_idx = myArray.MinIdx(array);

        int first_negative_elem_idx = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) { first_negative_elem_idx = i; break; }
        }

        if (first_negative_elem_idx == -1) return 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (first_negative_elem_idx < minimum_idx && i % 2 == 0)  sum += Math.Round(array[i], 2); 
            else if (first_negative_elem_idx >= minimum_idx && i % 2 != 0) sum += Math.Round(array[i], 2);            
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
        MyArray myArray = new MyArray();
        int maximum_idx = myArray.MaxIdx(array);

        for (int i = 0; i < maximum_idx - 1; i += 2)
        {
            double tmp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = tmp;
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
        int start_idx = 0, end_idx = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] <= array[i + 1])
            {
                end_idx = i;
                if (end_idx - start_idx > count) count = end_idx - start_idx;
                start_idx = end_idx;
            }
        }
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
        int increases_count = 0, decreases_count = 0;
        int start_inc_idx = 0, end_inc_idx = 0, start_dec_idx = 0, end_dec_idx = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                end_inc_idx = i;               
            } else
            {

            }
        }

        if (increases_count > decreases_count) count = increases_count;
        else count = decreases_count;

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
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
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
        double answer = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            answer += array[i];
        }
        for (int i = 0; i < array.Length; i += 1)
        {
            array[i] /= answer;
            array[i] = Math.Round(array[i],2);
        }
        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        double sum = 0;
        double av = 0;
        double n = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                n += 1;
            }
        }
        av = sum / n;
        for (int s = 0; s < array.Length; s+= 1)
        {
            if (array[s] > 0) 
            {
                array[s] = av;
                array[s] = Math.Round(array[s],2);
            }
        }
        
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        if (first.Length == second.Length)
        {
            for (int i = 0; i < first.Length; i++)
            {
                sum[i] = first[i] + second[i];    
                dif[i] = first[i] - second[i];  
                sum[i] = Math.Round(sum[i],2);   
                dif[i] = Math.Round(dif[i],2);   
            
            // end
            }
        }
            return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sum = 0;
        double n = 0;
        double av = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            n += 1;
        }
        av = sum / n;
        for (int s = 0; s < array.Length; s += 1)
        {
            array[s] -= av;
            array[s] = Math.Round(array[s],2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i += 1)
        {
            //for (int j = 0; i < vector1.Length; i += 1)
            //{
            product += vector1[i] * vector2[i];
            //}

        }
        // end
        product = Math.Round(product,2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i += 1)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double sum = 0;
        double n = 0;
        double av = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            n += 1;
        }
        av = sum / n;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > av)
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
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < 0)
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        double sum = 0;
        double n = 0;
        double av = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            n += 1;
        }
        av = sum / n;
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > av)
            {
                count += 1;
            }
        }

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (P < array[i] && array[i] < Q)
            {
                count += 1;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        int a = 0;
        int b = 0;

        // code here
        foreach (var i in array)
        {
            if (i > 0) 
            {
                a += 1;
                //output.Add(i); 
            }
        }
        output = new double[a];
        foreach (var i in array)
        {
            if (i > 0)
            {
                output[b] = i;
                b += 1;
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
        for (int i = 0; i < array.Length; i+= 1)
        {
            if(array[i] < 0)
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
        int eveni = 0;
        int oddi = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (i % 2 == 0)
            {
                even[eveni] = array[i];
                eveni += 1;
            }
            else
            {
                odd[oddi] = array[i];
                oddi += 1;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        double a = 0;

        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] >= 0)
            {
                //a = array[i] * array[i];
                sum += array[i] * array[i];
            }
            else
            {
                break;
            }
            
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];
        double sign = 0;
        // code here
        for (int i = 0; i < x.Length; i +=1)
        {
            if (x[i] <= 0)
            {
                y[i] = double.NaN;
            }
            else
            {   
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            }
            //Console.WriteLine(y[i]);
            Console.WriteLine($"{x[i]:F4}\t\t{y[i]:F4}");
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
        double maxi = -9999;
        int index = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
            else
            {
                maxi = maxi;
            }
        }
        for (int i = 0; i < index; i += 1)
        {
            //if (array[i] < maxi)
            //{
            sum += array[i];
            //}

        }
        // end
        //foreach (int i in array)
        //{
            //Console.Write($"{i} ");
        //}
        Console.WriteLine(sum);
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
        int index = 0;
        double maxi = 0;
        double avr = 0;
        double sum = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
            
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
            else
            {
                maxi = maxi;
            }
        }
        //foreach (int i in array)
        //{
            //sum += array[i];
        //}
        avr = sum / array.Length;
        for (int i = index + 1; i < array.Length; i++)
        {
            avr = Math.Round(avr,1);
            array[i] = avr;
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
        double sum = 0;
        double avr = 0;
        double difference = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            sum += array[i];
        }
        avr = sum / array.Length;
        double minDifference = 99999999; 
        int index = -1; 
        
        for (int i = 0; i < array.Length; i++)
        {
            difference = Math.Abs(array[i] - avr);
            if (difference < minDifference)
            {
                minDifference = difference;
                index = i; 
            }
        }
       double[] result = new double[array.Length + 1];
        for (int i = 0; i <= index; i++)
        {
            result[i] = array[i];
        }

        result[index + 1] = P;

        for (int i = index + 1; i < array.Length; i++)
        {
            result[i + 1] = array[i];
        }
            //if ()
            //{
                //P = array[i + 1];
            //}
        
        // end

        return result;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double maxi = -999999;
        double mini = 999999;
        int index1 = -1;
        int index2 = -1;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index1 = i;
            }
            
        }
        for (int i = index1 + 1; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                index2 = i;
            }
        }

        if (index2 != -1)
        {
            double temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
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
        double mini = 99999;
        int index = -1;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > 0 && array[i] < mini)
            {
                mini = array[i];
                index = i;
            }
        }
        if (index == -1) 
        {
            return array;        
        }
        for (int i = index; i < array.Length-1; i++)        
        {
            array[i] = array[i + 1];        
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
        int index = -1;
        double maxi = -99999;
        double sum = 0;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }

        for (int i = index + 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum,1);

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
        double maxi = -999999;
        int index1 = -1;
        double otr = 0;
        int index2 = -1;
        // code here
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index1 = i;
            }
            if (array[i] < 0 && index2 == -1)
            {
                index2 = i;
            }
        }
        // end
        if (index1 != -1 && index2 != -1)
        {
            double temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
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
        double avr = 0;
        int index = 0;
        int count = 0;
        // code here
        foreach (double i in array)
        {
            sum += i;
        }
        avr = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < avr)
        {
            count+= 1; 
        }
    }
        output = new int[count];
        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] < avr)
            {
                output[index] = i; 
                index++;
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
        double maxi1 = -999999; 
        double maxi2 = -9999999999;  

        
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0) 
            {
                if (array[i] > maxi1)
                {
                    maxi1 = array[i];
                }
            }
            else 
            {
                if (array[i] > maxi2)
                {
                    maxi2 = array[i];
                }
            }
        }
        
        if (maxi1 > maxi2)
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
        int otrindex = -1; 
        int minindex = -1; 
        double mini = 9999999999999; 

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && otrindex == -1)
            {
                otrindex = i; 
            }

            if (array[i] < mini)
            {
                mini = array[i];
                minindex = i; 
            }
        }

        if (otrindex == -1)
        {
            return 0;
        }

        if (otrindex < minindex)
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
        double maxi = -99999999;
        int index = 0;

        for (int i = 0; i < array.Length; i += 1)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                index = i;
            }
        }
        for (int i = 0; i < index - 1; i += 2)
        {
            double temp = array[i];
            array[i] = array[i + 1];
            array[i + 1] = temp;
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
        int count = 1;
        int current = 1;

        // code here
        for (int i = 0; i < array.Length - 1; i += 1)
        {   
            if (array[i] > array[i + 1])
            {
                current += 1;
            }
            else
            {
                if (current > count)
                {
                    count = current;
                }
                current = 1;
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
        // code here
        int count = 1;
        int currentplus = 1;
        int currentminus = 1;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                currentplus += 1;
                currentminus = 1; 
            }

            else if (array[i] < array[i + 1])
            {
                currentminus++;
                currentplus = 1; 
            }
            else // если эл равны то сброс
            {
                currentplus = 1;
                currentminus = 1;
            }

            count = Math.Max(count, Math.Max(currentplus, currentminus));
        }
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
        double[] result = new double[array.Length];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0) 
            {
                result[index] = array[i]; 
                index += 1; 
            }
        }

        // переносим полож эл в новый массив с определенным размером
        double[] final = new double[index];
        for (int i = 0; i < index; i++)
        {
            final[i] = result[i];
        }

        // end

        return final;
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
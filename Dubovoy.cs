using Microsoft.VisualBasic;
using System;
using System.Collections;
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
        program.Task_3_13(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 10, 10 });
        //program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        double sum = 0;
        // code here
        for (int i = 0; i<array.Length; i++)
        {
            sum += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i] / sum),2);
        }
        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0; int chet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                chet++;
            }
        }
        sum = Math.Round((sum/chet),2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = sum;
        
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
            dif[i] = Math.Round((first[i] - second[i]), 2);
        
        }
        // end
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round((first[i] + second[i]),2);

        }
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        double sr_arifm = 0;
        // code here
        for(int i = 0;i<array.Length;i++)
        {
            sr_arifm += array[i];
        }
        sr_arifm = Math.Round((sr_arifm/array.Length),2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round((array[i]-sr_arifm),2);
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
        // end
        product = Math.Round(product, 2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += Math.Pow((vector[i]),2);
        }
        // end
        length = Math.Sqrt(length);
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        double sr_arifm = 0;
        double schet = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sr_arifm += array[i];
            schet++;
        }
        // end
        sr_arifm = Math.Round((sr_arifm/schet), 2);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= sr_arifm)
                array[i] = 0;
        }
        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        // code here
        int count = 0;
        double sr_arifm = 0;
        double schet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sr_arifm += array[i];
            schet++;
        }
        sr_arifm = Math.Round((sr_arifm / schet), 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr_arifm)
                count++;

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
            if (array[i] > P && array[i] < Q) count++;
        
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int schet = 0;
        int schet1 = 0;



        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                schet++;
        }
        double[] output = new double[schet];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[schet1] = array[i];
                schet1++;
            
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

        int schet1 = 0;
        int schet2 = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[schet1] = array[i];
                schet1++;
            }
            else
            {
                odd[schet2] = array[i];
                schet2++;
            }
        }
        // end
        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) break;
            sum += Math.Pow(array[i],2);
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
            if (0.5 * Math.Log(x[i]) < 0)
                y[i] = double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
        }
        // end
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]} + {y[i]}");
        }

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
        double max = -99999;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) break;
            else sum += array[i];
        
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
        double sr_arifm = 0; int schet = 0;
        double max = 0; bool flag = false;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            sr_arifm += array[i];
            schet++;
        }
        sr_arifm = Math.Round((sr_arifm / schet), 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (flag == true) array[i] = sr_arifm;
            if (array[i] == max) flag = true;
            
            Console.WriteLine($"{array[i]} and {sr_arifm} and {max}");

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
        double[] array2 = new double[array.Length+1];
        int schet = 0; double lenght = 99999; double chisl = 0; double sr_arifm = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sr_arifm += array[i];
            schet++;
        }
        sr_arifm = Math.Round((sr_arifm / schet), 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr_arifm)
            {
                if (array[i] - sr_arifm < lenght)
                {
                    chisl = array[i];
                    lenght = array[i] - sr_arifm;
                }
            }
            else
            { 
                if (sr_arifm-array[i] < lenght)
                {
                    chisl = array[i];
                    lenght = sr_arifm - array[i];

                }


            }


        }
        // end
        schet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == chisl)
            {
                array2[schet] = array[i];
                array2[schet + 1] = P;
                schet += 2;
            }
            else
            {
                array2[schet] = array[i];
                schet++;
            }
        }
        Console.WriteLine($"{array2[0]} and {array2[1]} and {array2[2]} and {array2[3]} and {array2[4]} and {array2[5]} and {array2[6]} and {array2[7]}");
        return array2;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double max = -111111; int max_ind = 0; bool flag = false;
        double min = 999999; int min_ind = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        { 
            if (array[i]>max)
            {
                max = array[i];
                max_ind = i;
            }
        }
        Console.WriteLine($"{max_ind} and {array.Length}");
        if (max_ind == array.Length-1)
        {
            return array;
        } 
        for (int i = 0; i < array.Length; i++)
        {
            if (flag == true)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    min_ind = i;
                }
            }
            if (array[i] == max)
            { 
                flag = true;
            }
        }
        Console.WriteLine(min);
        array[max_ind] = min;
        array[min_ind] = max;
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
        double[] array2 = new double[array.Length-1];
        double min = 99999; int ind = 0;
        int schet = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    ind = i;
                }
            }
        }
        if(min==99999) return array;
        // end
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min)
            {
                continue;

            }
            else
            {
                array2[schet] = array[i];
                schet++;
            } 
        }
        for(int i=0; i<array2.Length;i++)
        {
            Console.WriteLine(array2[i]);
        }
        return array2;
    }
    public double[] Task_2_11(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array)
    {
        double max = -100000; bool flag = false; double sum = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        Console.WriteLine(max);
        for (int i = 0; i < array.Length; i++)
        {
            if (flag == true) sum += array[i];
            else if (array[i] == max) flag = true;
        }
        Console.WriteLine(sum);
        sum = Math.Round(sum, 2);
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
        double otric = 0; double temp = 0;
        double max = -100000; int max_ind = 0; int otric_ind = 0; bool flag = false;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max_ind = i;
                max = array[i];
            }
            if (array[i] < 0 && flag == false)
            {
                flag = true;
                otric = array[i];
                otric_ind = i;
            }
        }

        if (otric == 0) return array;

        Console.WriteLine($"{otric} and {max}");
        temp = array[max_ind];
        array[max_ind] = array[otric_ind];
        array[otric_ind] = temp;
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
        double sum = 0; double schet = 0; int lenght = 0; int schet_massiv = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            schet++;
            sum += array[i];
        
        }
        sum = Math.Round((sum / schet), 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum) lenght++;
        }
        int[] output = new int[lenght];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                output[schet_massiv] = i;
                schet_massiv++;
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
        double max_chet = -100000; double max_nechet = -100000;
        int schet = array.Length/2;
        // code here
        Console.WriteLine(schet);
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                if (array[i]>max_nechet)
                {
                    max_nechet = array[i];
                }
            }
            else
            {
                if (array[i] > max_chet)
                {
                    max_chet = array[i];
                }
            }
        }
        // end
        Console.WriteLine($"{max_nechet} and {max_chet}");

        if (max_chet > max_nechet)
        {
            for (int i = 0; i < schet; i++)
            {
                array[i] = 0;
            }
        }
        else 
        {
            for (;schet<array.Length; schet++)
            {
                array[schet] = 0;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        
        }
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
        double sum = 0; double min = 99999; int otric_ind = 0; bool flag = false; int min_ind = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && flag == false)
            {
                otric_ind = i;
                flag = true;
            }
            if (array[i] < min)
            {
                min = array[i];
                min_ind = i;
            }
        }
        // end
        if (otric_ind == 0) return sum = 0;
        if (otric_ind < min_ind)
        {
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0) sum += array[i];
                }
            }
        }
        else
        {
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 1) sum += array[i];
                }
            }

        }
        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        double max = -100000; int schet = 0; int schet_massiv = 0;

        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max) schet++;
        }
        int[] output = new int[schet];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]==max)
            {
                output[schet_massiv] = i;
                schet_massiv++;
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
        double[] temp = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }
        double max = -100000; int schet_maxim = 0; double sum_temp = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];

        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                for (int g = 0; g < i; g++)
                {
                    sum_temp += temp[g];
                    Console.WriteLine(array[g]);
                }
                array[i] = sum_temp;
                sum_temp = 0;
            }

        }
        for (int i = 0; i < array.Length; i++)
        {
            //Console.WriteLine(array[i]);
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
        int schet = 0;
        // code here
        double[] itog = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                itog[schet] = array[i];
                schet++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                itog[schet] = array[i];
                schet++;
            }
        }
        // end

        return itog;
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
        int schet = 0;
        double[] itog = new double[array.Length];
        // code here
        for (int i = 0; i < array.Length/2; i++)
        {
            itog[schet] = array[i];
            schet++;
            itog[schet] = array[i];
            schet++;
        }
        Console.WriteLine(itog.Length);
        for (int i = 0; i < itog.Length; i++)
        {
            Console.WriteLine(itog[i]);
        }
        // end

        return itog;
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
        bool flazhok = true;int schet_temp = 0; int schet_itog = 0;
        double[] massiv = new double[array.Length]; 
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            bool prov = true;
            for (int j = 0; j < massiv.Length; j++)
            {
                if (array[i] == massiv[j])
                {
                    prov = false;
                }
            }
            if (prov == true)
            {
                massiv[i] = array[i];
            }
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] == 0 && massiv[i] != array[i])
            {
                schet_temp++;
            }
        }
        //Console.WriteLine(schet_temp);
        double[] itog = new double[massiv.Length - schet_temp];

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] == array[i])
            {
                itog[schet_itog] = massiv[i];
                schet_itog++;
            }
        }
        return itog;
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
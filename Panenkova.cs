using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Numerics;
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
        double S = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            S += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/S, 2);
        }
        // end
        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0; int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        s = Math.Round(s/ k*1.0, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = s;
        }
        // end
        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], 
            dif = new double[first.Length];
        // code here
        for (int i = 0; i < first.Length; i++)
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
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s  = Math.Round(s / array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-s, 2);
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
            product += vector1[i]*vector2[i];
            product = Math.Round(product,2);
        }
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
        length = Math.Sqrt(length);
        // end
        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if ( array[i] > s)
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
                count++;
        }
        // end
        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0; double s = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        s = s / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if ((double)array[i] > s)
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
            if (array[i] < Q && array[i] > P)
                count++;
        }
        // end
        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        int s = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                s++;
        }
        double[] output = new double[s]; int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[k]= array[i];
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
        double[] even = new double[array.Length/2];
        double[] odd = new double[array.Length/2];
        // code here
        int k = 0, p = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i%2==0)
            {
                even[k] = array[i];
                k++;
            }
            else
            {
                odd[p] = array[i];
                p++;
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
            if (array[i] >= 0)
            {
                sum += array[i] * array[i];
            }
            else
                return sum;
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
            x[i] = 0.5 * (Math.Log(x[i]));
            if (x[i] >= 0)
            {
                y[i] = Math.Round(x[i],2);
            }
            else
            {
                y[i] = double.NaN;
            }
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]} + {y[i]}");
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
        double sum = 0, k = -99999;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > k)
            {
                k = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == k) 
                break;
            else
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
        double sum = 0, maxi = 0; int k = 0, p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            k++;
            if (array[i] > maxi)
            {
                maxi = array[i];
                p = i;
            }
        }
        sum = Math.Round(sum / k, 2);
        for (int i = p+1; i < array.Length; i++)
        {
            array[i] = sum;
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
        double[] output = new double[array.Length + 1];
        double sum = 0; int k = 0; double dl = 999999, g = 0; 
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            k++;
        }
        sum = Math.Round((sum / k), 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sum)
            {
                if (array[i] - sum < dl)
                {
                    g = array[i];
                    dl = array[i] - sum;
                }
            }
            else
            {
                if (sum - array[i] < dl)
                {
                    g = array[i];
                    dl = sum - array[i];
                }
            }
        }
        int h = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == g)
            {
                output[h] = array[i];
                output[h+1] = P;
                h = h + 2;
            }
            else
            {
                output[h] = array[i];
                h++;
            }
        }
        // end
        return output;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array)
    {
        double maxi = -999999; int maxi_p = 0;
        double mini = 999999; int mini_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                maxi_p = i;
            }
        }
        for (int i = maxi_p + 1; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                mini_p = i;
            }
        }
        if (maxi_p > mini_p)
        {
            return array;
        }
        else
        {
            double temp = array[maxi_p];
            array[maxi_p] = array[mini_p];
            array[mini_p] = temp;
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
        // code here
        double mini = 99999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini && array[i] > 0)
            {
                mini = array[i];
            }
        }
        double[] sum = new double[array.Length - 1];
        int k = 0;
        if (mini == 99999)
            return array;
        for (int i = 0; i < array.Length; i++)
        {
            if (mini!= array[i])
            {
                sum[k] = array[i];
                k++;
            }
        }
        // end
        return sum;
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
        double maxi = -999999; int maxi_p = 0; double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                maxi_p = i;
            }
        }
        for (int i = maxi_p+1; i < array.Length; i++)
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
        double maxi = -999999; int maxi_p = 0;
        double mini = 0; int mini_p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
            {
                maxi = array[i];
                maxi_p = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                mini = array[i];
                mini_p = i;
                break;
            }
        }
        if (mini == 0 || maxi == -999999)
            return array;
        double temp = array[maxi_p];
        array[maxi_p] = array[mini_p];
        array[mini_p] = temp;
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
        double sum = 0; int k = 0; int p = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        sum = Math.Round(sum/ array.Length, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                k++;
            }
        }
        int[] output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sum)
            {
                output[p] = i;
                p++;

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
        double max_p = -99999, max_ne = -99999; int k = array.Length / 2;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0 || i == 0)
            {
                if (array[i] > max_p)
                {
                    max_p = array[i];
                }
            }
            if (i % 2 != 0)
            {
                if (array[i] > max_ne)
                {
                    max_ne = array[i];
                }
            }
        }
        if (max_p > max_ne)
        {
            for (int i = 0; i < k; i ++)
            {
                array[i] = 0;
            }
        }
        if (max_p < max_ne)
        {
            for (; k < array.Length; k++)
            {
                array[k] = 0;
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
        double sum = 0, mini = 99999, nech = 0; int mini_p = 0, nech_p = 0; 
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < mini)
            {
                mini = array[i];
                mini_p = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                nech = array[i];
                nech_p = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (nech == 0)
            {
                if (i % 2 != 0)
                    sum += array[i];
            }
            else if (nech_p < mini_p)
            {
                if (i % 2 == 0)
                    sum += array[i];
            }
            else
            {
                if (i % 2 != 0)
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
        double maxi = -99999; int k = 0;
        // code here
        int[] output = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi)
            {
                k++;
                output[k] = i;
            }
            if (array[i] > maxi)
            {
                maxi = array[i];
                k = 0;
                output[k] = i;
            }
        }
        int [] itog = new int[k + 1];
        for (int i = 0; i < itog.Length; i++)
        {
            itog[i] = output[i];
        }
        // end
        return itog;
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
        // code here
        double maxi = -99999; double sum = 0;
        double[] output = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            output[i] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxi)
                maxi = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxi )
            {
                for (int j = 0; j < i; j++)
                {
                    sum += output[j];
                }
                array[i] = sum;
                sum = 0;
            }
        }
        //end
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
        // code here
        double[] output = new double[array.Length]; int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                output[k] = array[i];
                k++;
            }
        }
        // end
        return output;
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
        // code here
        double[] output = new double[array.Length]; int k = 0;
        for (int i = 0; i < array.Length/2; i++)
        {
            output[k] = array[i];
            output[k+1] = array[i];
            k+=2;
        }
        // end
        return output;
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
        int p = 0; int kon = 0;
        double[] outk = new double[array.Length];
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            bool k = true;
            for (int j = 0; j < outk.Length; j++)
            {
                if (array[i] == outk[j])
                {
                    k = false;
                }
            }
            if (k == true)
            {
                outk[i] = array[i];
            }
        }
        for (int i = 0; i < outk.Length; i++)
        {
            if (outk[i] == 0 && outk[i] != array[i])
            {
                p++;
            }
        }
        double[] output = new double[outk.Length - p];
        for (int i = 0; i < outk.Length; i++)
        {
            if (outk[i] == array[i])
            {
                output[kon] = outk[i];
                kon++;
            }
        }
        // end
        return output;
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
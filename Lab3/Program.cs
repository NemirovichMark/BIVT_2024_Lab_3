using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
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
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
        }
        for (int i = 0; i < array.Length; i++)
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
        double s = 0, n=0;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                n += 1;
            }
        }
        double sr_ar = s / n;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i]=sr_ar;
                array[i] = Math.Round(array[i], 2);
            }
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
            sum[i] = first[i] + second[i];
            sum[i] = Math.Round(sum[i], 2);
        }
        for (int i = 0; i < 4; i++)
        {
            dif[i] = first[i] - second[i];
            dif[i] = Math.Round(dif[i], 2);
        }
        // end
        
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double s = 0;
        int n = 0;
        for (int i = 0; i < 5; i++)
        {
            s += array[i];
            n++;
        }
        double sr_ar = s / n;
        for (int i = 0; i < 5; i++)
        {
            array[i] -= sr_ar;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i+=2)
        {
            product += vector1[i] * vector2[i] + vector1[i+1] * vector2[i+1];
            product = Math.Round(product, 2);
        }
            // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i ++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double s = 0;
        int n = 0;
        for (int i = 0; i < 7; i++)
        {
            s += array[i];
            n++;
        }
        double sr_ar = s / n;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr_ar)
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
        for (int i = 0; i < 6; i++)
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

        // code here
        double s = 0;
        int n = 0;
        for (int i = 0; i < 8; i++)
        {
            s += array[i];
            n++;
        }
        double sr_ar = s / n;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr_ar)
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
        for (int i = 0; i < 10; i++)
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

        // code here
        int n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i]>0)
            {
                n += 1;
            }
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                output[n++]=array[i];
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
        int n = 0;
        for (int i = 0; i < array.Length; i+=2)
        {
            even[n] = array[i];
            n +=1;
        }
        n = 0;
        for (int i = 1; i <array.Length; i += 2)
        {
            odd[n] = array[i];
            n +=1;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i ++)
        {
            if (array[i] >= 0)
            {
                sum += (array[i] * array[i]);
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

        // code here
        for (int i = 0; i < y.Length; i++)
        {
            if (x[i] == 0)
            {
                y[i] = double.NaN;
            }
            else
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]),2);
            }
            
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]: F4}\\t {y[i]:F4}"); 
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int m = 0;
        double x =array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                x =array[i];
                m = i;
            }
        }
        if (x > 0)
        {
            array[m] *= 2;
        }
        else
        {
            array[m] /= 2;
        }
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[m])
            {
                m = i; //запоминаем индекс максимума
            }
        }
        for (int i = 0; i < m; i++)
        {
            sum += array[i];       
        }
            // end

            return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[m])
            {
                m = i;
            }
        }
        for ( int i=0; i < m; i++)
        {
            if (array[i] > 0)
            {
                array[i] *= 2;
            }
            else
            {
                array[i] /= 2;
            }
        }
            // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        int m = 0, n=0;
        double sr_ar = 0;
        for (int i = 0; i < array.Length; i++)// ИДЁМ С 0!
        {
            if (array[i] > array[m])
            {
                m = i;
            }
            sr_ar += array[i] / array.Length; //считаем среднее значение 
        }
        
        for (int i=m+1; i < array.Length; i++)
        {
            array[i]= Math.Round(sr_ar, 2);
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        int max = 0, min=0, n=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max])
            {
                max = i;
            }
            if (array[i] < array[min])
            {
                min = i;
            }
        }
        for (int i = min+1; i < max; i++)
        {
            if (array[i] < 0)
            {
                n += 1;
            }
        }
        double[] array2 = new double[n];
        for (int i = min+1, k=0; i < max; i++)
        {
            if (array[i] < 0)
            {
                array2[k] = array[i];
                k++;
            }
        }
        array = array2;
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
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[m])
            {
                m = i;
            }
        }
        if (m != array.Length-1)
        {
            if (array[m+1] > 0)
            {
                array[m+1] *= 2;
            }
            else
            {
                array[m+1] /= 2;
            }
        }
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
        double max = array[0], min = array[0];
        int imax = 0, imin = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                imax = i;
            }
            else if (array[i] < min)
            {
                min = array[i];
                imin = i;
            }
        }
        int istart = 0, iend = 0;
        if (imin < imax)
        {
            istart = imin;
        }
        else
        {
            istart = imax;
        }
        if (imin > imax)
        {
            iend = imin;
        }
        else
        {
            iend = imax;
        }
        double sum = 0;
        int count = 0;
        for (int k = istart + 1; k < iend; k++) // [max, min]
        {
            sum += array[k];
            count++;
        }
        if (count == 0)
        {
            return 0;
        }
        average = sum / count;
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
        int index = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                index = i; 
                break;
            }
        }

        if (array[index] > 0)
        {
            double[] array2 = new double[array.Length + 1];
            for (int i = 0, k = 0; k < array2.Length; k++)
            {
                if (k == index + 1)
                {
                    array2[k] = P;
                } 
                else
                { 
                    array2[k] = array[i];
                    i++;
                }
            }
            array = array2;
        }
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
        double max = double.MinValue;
        int n = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max) 
            { 
                max = array[i];
                n = i;
            }
        }

        array[n] = n;
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

        // code here
        k = k + 1;
        if (k < 0) k = 0;
        if (k > A.Length)
            return A;

        double[] output = new double[A.Length + B.Length];

        for (int i = 0; i < k && i < A.Length; i++)
        {
            output[i] = A[i];
        }

        for (int i = 0; i < B.Length; i++)
        {
            output[i + k] = B[i];
        }

        for (int i = k; i < A.Length; i++)
        {
            output[i + B.Length] = A[i];
        }

        return output;
            


        // end

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
        int imax = 0, imin = 0, k = 0; 
        double min = double.MaxValue, max = double.MinValue; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) 
            { 
                min = array[i]; 
                imin = i; 
            } 
            if (array[i] > max) 
            {
                max = array[i]; 
                imax = i; 
            } 
        }
        if (imax < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                { 
                    average += array[i];
                    k++;
                }
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                { 
                    average += array[i];
                    k++;
                }
            }
        }
        if (k != 0)
        {
            average = average/k;
        } 
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
        double max = double.MinValue, sum = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) 
            { 
                max = array[i]; 
                m = i;
            }
            sum += array[i];
        }
        if (max > sum)
        {
            array[m] = 0;
        }
        else
        {
            array[m] *= 2;
        } 
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
        //int[] output = null;

        // code here
        double maxElem = array[0];
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElem)
            {
                maxElem = array[i];
                cnt = 1;
            }
            else if (array[i] == maxElem)
            {
                cnt++;
            }
        }
        int[] output = new int[cnt];
        cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxElem)
            {
                output[cnt] = i;
                cnt++;
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
        // code here
        double sum = 0;
        double imax = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > imax)
            {
                imax = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (imax != array[i])
            {
                sum += array[i];
            }
            else
            {
                sum += array[i];
                array[i] = sum - array[i];
            }
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
        // code here
        int n = 0;
        double[] array2 = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array2[n] = array[i];
                n++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array2[n] = array[i];
                n++;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array2[i];
        }
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

        // end

        return count;
    }
    public double[] Task_3_10(double[] array)
    {
        // code here
        int n = 0;
        double[] array2 = new double[array.Length];
        for (int i = 0; i < array.Length / 2; i++)
        {
            array2[n] = array[i];
            n++;
            array2[n] = array[i];
            n++;

        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array2[i];
        }
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
        int cnt = 0;
        bool isUnique;

        for (int i = 0; i < array.Length; i++)
        {
            isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
                cnt++;
        }

        double[] arrayNew = new double[cnt];
        cnt = 0;

        for (int i = 0; i < array.Length; i++)
        {
            isUnique = true;
            for (int j = 0; j < cnt; j++)
            {
                if (array[i] == arrayNew[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                arrayNew[cnt] = array[i];
                cnt++;
            }
        }
        // end
        return arrayNew;
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

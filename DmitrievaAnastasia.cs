using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text.RegularExpressions;
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

        double sum = 0;
        for (int i = 0; i < array.Length; i++) sum += array[i];
        for (int i = 0; i < array.Length; i++) array[i] = Math.Round(array[i] / sum, 2);

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here

        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                count++;
            }
        }
        sum /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = Math.Round(sum, 2);
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
        }
        for (int i = 0; i < 4; i++)
        {
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here

        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
                sum += array[i];
        }
        sum /= 5;
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Round(array[i] - sum, 2);
        }

        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here

        for (int i = 0; i < 4; i++)
        {
            product += vector1[i]* vector2[i];
        }
        product = Math.Round(product, 2);

        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here

        for (int i = 0; i < 5; i++)
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
        // code here

        double sum = 0;
        for (int i = 0; i < 7; i++)
        {
            sum += array[i];
        }
        sum /= 7;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sum) array[i] = 0;
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
            if (array[i] < 0) count++;
        }

        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here

        double sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
        }
        sum /= 8;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sum) count++;
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
            if ((array[i] < Q) && (array[i] > P))
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        output = new double[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[j] = array[i];
                j++;
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

        // code here

        int j = 0;
        int k = 0;
        for (int i = 0; i < 10; i++)
        {
            if ((i % 2) == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[k] = array[i];
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
        int i = 0;
        while (i < 11 && array[i] >= 0)
        {
            sum += array[i]*array[i];
            i++;
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
            y[i] = Math.Round(0.5 * Math.Log(x[i], Math.E), 2);
            if (x[i] == 0) y[i] = double.NaN;
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

        double max = -100;
        foreach (double i in array)
        {
            if (i > max) max = i;
            
        }
        foreach (double i in array)
        {
            if (i != max) sum += i;
            else break;
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

        double crznach = 0;
        double sum = 0;
        foreach (double i in array)
        {
            sum += i;
        }
        crznach = sum / array.Length;
        double max = -100;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                count = i;
            }
        }
        for (int i = count+1; i < array.Length; i++) 
        {
            array[i] = Math.Round(crznach, 1);
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

        double crznach = 0;
        double sum = 0;

        foreach (double i in array) sum += i;
        crznach = sum / array.Length;

        double minus = 100000000;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - crznach) < minus)
            {
                minus = Math.Abs(array[i] - crznach);
                count = i;
            }
        }
        count++;

        double[] array1 = new double[array.Length + 1];

        for (int i = 0; i < array1.Length; i++)
        {
            if (i < count) array1[i] = array[i];
            else
            {
                array1[i] = P;
                break;
            }
        }
        for (int i = count+1; i < array1.Length; i++)
        {
            array1[i] = array[i - 1];
        }
        array = array1;


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

        double max = -10000000;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        double min = 100000000;
        int indexmin = 0;
        for (int i = indexmax; i < array.Length; i++) 
        { 
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        array[indexmin] = max;
        array[indexmax] = min;

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
        double sum = 0;
        foreach (double value in array)
        {
            sum+= value;
        }
        if (sum < 0) return array; 
        double min = 1000000000000;
        int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 && array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }
        double[] array1 = new double[array.Length - 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < indexmin)
            {
                array1[i] = array[i];
            }
            else if (i >= indexmin)
            {
                indexmin = i;
                break;
            }
        }
        for (int i = indexmin; i < array1.Length; i++)
        {
            array1[i] = array[i+1];
        }
        array = array1;

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
        double exc = 1000;
        foreach (double i in array)
        {
            if (i < 0) exc = i;
        }
        if (exc == 1000) return array;

        int otrNum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otrNum = i;
                break;
            }
        }
        double max = -100000;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        double sum = 0;
        for (int i = indexmax + 1; i < array.Length; i++) sum += array[i];
        array[otrNum] = Math.Round(sum, 1);

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

        double exc = 1000;
        foreach (double i in array)
        {
            if (i < 0) exc = i;
        }
        if (exc == 1000) return array;
        double otrNum = 0;
        int indexotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                otrNum = array[i];
                indexotr = i;
                break;
            }
        }
        double max = -100000;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        array[indexotr] = max;
        array[indexmax] = otrNum;

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

        double srznach = 0;
        foreach (double i in array) srznach += i;
        srznach /= array.Length;

        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < srznach) count++;
        }

        output = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] < srznach)
            {
                output[j] = i; 
                j++;
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

        double maxCh = -100000;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > maxCh) maxCh = array[i];
        }
        double maxNch = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > maxNch) maxNch = array[i];
        }

        if (maxCh > maxNch)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        }
        else
        {
            for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) count++;
        }
        if (count == 0) return sum = 0;

        int indexotr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                indexotr = i;
                break;
            }
        }

        double min = 10000;
        int indexmin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                indexmin = i;
            }
        }

        if (indexotr < indexmin )
        {
            for (int i = 0; i < array.Length; i+=2) sum += array[i];
        }
        else
        {
            for (int i = 1; i < array.Length; i+=2) sum += array[i];
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

        double max = -10000;
        int indexmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                indexmax = i;
            }
        }
        for (int i = 1; i < indexmax; i += 2)
        {
            double k = array[i];
            array[i] = array[i-1];
            array[i-1] = k;
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

        int countMax = -100;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < (array[i - 1])) count++;
            else count = 0;
            if (count > countMax) countMax = count;
        }
        count = countMax + 1;

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
        int lengthUB = 1;
        int countMax1 = -100;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < (array[i - 1])) lengthUB++;
            else lengthUB = 1;
            if (lengthUB > countMax1) countMax1 = lengthUB;
        }

        int lengthVOZ = 1;
        int countMax2 = -100;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > (array[i - 1])) lengthVOZ++;
            else lengthVOZ = 1;
            if (lengthVOZ > countMax2) countMax2 = lengthVOZ;
        }
        if (countMax1 > countMax2) count = countMax1;
        else count = countMax2;
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
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)  count++;
        }

        double[] array1 = new double[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array1[j] = array[i];
                j++;
            }
        }
        array = array1;


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
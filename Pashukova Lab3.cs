using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Security;
using System.Numerics;
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
            array[i] = Math.Round(array[i]/s,2);
            
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double s = 0;
        double sr = 0;
        int k = 0;
        for (int i=0; i<array.Length; i++)
        {   if (array[i] > 0)
            {
                s += array[i];
                k++;
            }
        }
        sr = Math.Round(s / k*1.0,2);
        for (int i = 0; i < array.Length; i++)
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
        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i],2);
            dif[i] = Math.Round(first[i] - second[i],2);
        }
        // end
        
        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sr = 0;
        double s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];  
        }
        sr= s/array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-sr,2);
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
        product= Math.Round(product,2);
        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i]*vector[i];
        }
        length = Math.Sqrt(length);
            // end

            return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sr = 0;
        double s = 0;
        double k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;   
        }
        sr = Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
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
        int count = 0;
        double s = 0;
        double sr = 0;
        double k = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            k++;
        }
        sr= Math.Round(s / k,2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>sr)
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
            if (array[i]>P && array[i]<Q)
                count++;
        }
            // end

            return count;
    }
    public double[] Task_1_11(double[] array)
    {
        // code here
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                k++;
        }
        double[] output = new double[k];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[index] = array[i];
                index++;
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

        int k1 = 0;
        int k2 = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[k1] = array[i];
                k1++;
            }
            else
            {
                odd[k2] = array[i];
                k2++;
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
                sum += array[i] * array[i];
            else return sum;
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
            if (0.5 * Math.Log(x[i]) >= 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else y[i] = double.NaN;

        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = 99999;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }

        }
        if (array[index] > 0)
            array[index] *= 2;
        else array[index] /= 2;
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
        double min = 9999;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }

        }
        for (int n = 0; n < index; n++)
        {
            if (array[n] > 0)
                array[n] *= 2;
            else array[n] /= 2;
        }
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
        double max = -100000, min = 100000;
        int index_max = 0, index_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                index_min = i;
            }
        }
        int col = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                if (i > index_min || i > index_max)
                {
                    col++;
                }
            }
        }

        double[] array1 = new double[col];
        if (col == 0)
            return array1;
        int schet = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0 && (i > index_min || i > index_max))
            {
                array1[schet] = array[i];
                schet++;
            }
        }

        // end

        return array1;
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
        double max = -9999;
        int ind = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                ind = i;
            }
        }
       if (ind != array.Length-1)
        {
            if (array[ind + 1] > 0)
                array[ind + 1] *= 2;
            else array[ind + 1] /= 2;
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
        // code here
        double max = -100000, min = 100000;
        int index_max = 0, index_min = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                index_max = i;
            }
            if (array[i] < min)
            {
                min = array[i];
                index_min = i;
            }
        }
        int col = 0; double sum = 0;
        if (index_min > index_max)
        {
            for (int i = index_max + 1; i < index_min; i++)
            {
                sum += array[i];
                col++;
            }
        }
        else if (index_max > index_min)
        {
            for (int i = index_min + 1; i < index_max; i++)
            {
                sum += array[i];
                col++;
            }
        }
        if (col == 0)
        {
            return 0;
        }

        double answer = sum / col;
        //end
        return answer;
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
        int ind = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                ind = i;
            }
        }
        if (ind != -1)
        {
            double[] answer= new double[array.Length+1];
            int k = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (ind + 1 != i)
                {
                    answer[i] = array[k];
                    k++;
                }
                else
                {
                    answer[i] = P;
                }
            }
            return answer;
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
        double max = -9999;
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
        }
        array[index] = index;
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
        double[] output = new double[A.Length + B.Length];
        int schet = 0, temp_schet = 0;

        //code here
        if (k == 7)
        {
            return A;
        }
        else
        {
            for (int i = 0; i <= k; i++)
            {
                output[schet] = A[i];
                schet++;
                temp_schet++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                output[schet] = B[i];
                schet++;

            }
            for (; temp_schet < A.Length; temp_schet++)
            {
                output[schet] = A[temp_schet];
                schet++;

            }
        }

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
        double max = -9999;
        double min = 9999;
        int maxin=0, minin=0;
        double otr = 0;
        double pol=0;
        double sum= 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxin = i;
            }
        } 
        if (maxin < minin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum+=array[i] ;
                    pol++;
                }
                if (sum != 0)
                {
                    average = sum / pol;
                }
            }
            average = sum / pol;
        }
        else if (minin > maxin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)                       
                {                                       
                    sum += array[i];
                    otr++;
                }
            }
            if (sum != 0)
            {
                average = sum / otr;
            }
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
        double max = -9999;
        int maxin = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > max)
            {
                max = array[i];
                maxin = i;
            }

        }
        if (array[maxin] > sum)
        {
            array[maxin] = 0;
        }
        else
        {
            array[maxin] *= 2;
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
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array)
    {
        // code here
        double max = -9999;
        int k = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] += k;
                k++;
            }
        }

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

        // end

        return array;
    }
    public double[] Task_3_5(double[] array)
    {
            // code here
            double[] itog = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    itog[i] = array[i];
                    array[i] = 99999;
                }
            }
            for (int i = 0; i < itog.Length; i++)
            {
                if (i % 2 == 0)
                {
                    double minim = 99999;
                    int minim_ind = 0;
                    for (int g = 0; g < array.Length; g++)
                    {
                        if (array[g] < minim)
                        {
                            minim = array[g];
                            minim_ind = g;
                        }
                    }
                    itog[i] = minim;
                    array[minim_ind] = 99999;
                }
                Console.WriteLine(itog[i]);
            }
            Console.WriteLine();
            // end

     return itog;
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
        // code here
        double[] itog = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            itog[i] = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                double maxim = -99999;
                int maxim_ind = 0;
                for (int f = 0; f < array.Length; f++)
                {
                    if (array[f] < 0 && array[f] > maxim)
                    {
                        maxim = array[f];
                        maxim_ind = f;
                    }
                }
                Console.WriteLine(array[maxim_ind]);
                array[maxim_ind] = -99999;
                itog[i] = maxim;
            }
        }
        //end
        return itog;
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
        double[] X = null, Y = null;
        double[] ixs = new double[n];
        double[] ygr = new double[n];
        double globalMax = -99999, globalMin = 99999;
        double sum = 0;

        // code here
        double step = (b - a) / (n - 1);

        int schet = 0;
        for (double i = a; i <= b; i += step)
        {
            sum = Math.Cos(i) + i * Math.Sin(i);
            ixs[schet] = Math.Round(i, 2);
            ygr[schet] = Math.Round(sum, 2);
            schet++;

            if (sum > globalMax)
                globalMax = sum;

            if (sum < globalMin)
                globalMin = sum;
        }
        // end
        return (ixs, ygr, Math.Round(globalMax, 2), Math.Round(globalMin, 2));
       
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
        double max = -99999, min = 99999;
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
        normalizedArray = new double[array.Length];
        double formula = 0;
        for (int i = 0; i < array.Length; i++)
        {
            formula = 2 * (array[i] - min) / (max - min) - 1;
            normalizedArray[i] = Math.Round(formula, 2);
        }
        // end
        return normalizedArray;
    }
    #endregion
}
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
        //program.Task_1_1(new double[] { 2, 1, 3, 3, 5, 6 });
        //program.Task_1_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_2_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, new double[] { 5, 2, 8, 1, 9, 10 }, 1);
        //Console.WriteLine();
        //Console.WriteLine("1");
        //program.Task_2_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, new double[] { 5, 2, 8, 1, 9, 10 }, 7);
        //Console.WriteLine();
        //Console.WriteLine("2");

        //program.Task_2_15(new double[] { -5, -2, -8, -1, -6, -2 }, new double[] { 5, 2, 8, 1, 9, 10 }, 1);
        //Console.WriteLine();
        //Console.WriteLine("3");
        //program.Task_2_15(new double[] { -5, -2, -8, -1, -6, -2 }, new double[] { 5, 2, 8, 1, 9, 10 }, 7);
        //program.Task_3_3(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });

    }

    public void Draw(double[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}  ");
        }
        
        Console.WriteLine();
    }


    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]/sum,2);
            Console.Write($"{array[i]} ");
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sumP = 0;
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sumP += array[i];
                count++;
            }
        }
        double mid = Math.Round(sumP / count, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) array[i] = mid;
            Console.Write($"{array[i]} ");
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
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        double mid = sum / array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(array[i]-mid,2);
            Console.Write($"{array[i]} ");
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

        return Math.Round(product,2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        // end

        return Math.Round(Math.Sqrt(length), 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        double mid = 0;
        // code here
        for (int i = 0;i<array.Length;i++)
        {
            mid += array[i];
        }

        mid /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (mid < array[i]) array[i] = 0;
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
            if (array[i] < 0) count++;
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double mid = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            mid += array[i];
        }

        mid /= array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > mid) count++;
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
            if ((array[i] > P) && (array[i] < Q)) count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {

        int count = 0,k=0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>0) count++;
        }
        double[] output = new double[count];

        for (int i = 0; i < array.Length; i++)
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
        for (int i = array.Length - 1; i > -1; i--)
        {
            if (array[i] < 0) 
            {
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
        for (int i = 0; i<array.Length; i+=2)
        {
            even[i/2] = array[i];
            odd[i/2] = array[i+1];
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
            sum += array[i] * array[i];
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
            if (x[i] <= 0) y[i] = double.NaN;
            else y[i]= Math.Round(0.5 * Math.Log(x[i]),2);
            Console.WriteLine($"{x[i]}   {y[i]}");
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int Imin = 0;
        for (int i = 0; i < array.Length; i++) 
        { 
            if (array[i] < array[Imin]) Imin = i;
        }
        // end
        array[Imin] *= 2;

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
        int Imin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Imin]) Imin = i;
        }
        for (int i = 0; i < Imin; i++)
        {
            if (array[i]>0)
                array[i] *= 2;
            else array[i] /= 2;
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
        int Imax = 0, Imin = 0, count = 0, k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Imin]) Imin = i;
            if (array[i] > array[Imax]) Imax = i;
        }
        
        if (Imin > Imax)
        {
            int temp = Imax;
            Imax = Imin;
            Imin = temp;
        }

        for (int i = Imin+1;i<Imax;i++)
            if (array[i] < 0)
                count++;

        double[] array2 = new double[count];

        for (int i = Imin + 1; i < Imax; i++)
            if (array[i] < 0)
            {
                array2[k]=array[i];
                k++;
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
        int Imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[Imax]) Imax = i;
        }
        if (Imax+1 < array.Length)
        {
            if (array[Imax + 1] > 0)
                array[Imax + 1] *= 2;
            else
                array[Imax + 1] /= 2;
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
        int Imax = 0, Imin = 0, count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[Imin]) Imin = i;
            if (array[i] > array[Imax]) Imax = i;
        }

        if (Imin > Imax)
        {
            int temp = Imax;
            Imax = Imin;
            Imin = temp;
        }

        for (int i = Imin + 1; i < Imax; i++)
        {
            average += array[i];
            count++;
        }
        // end
        if (count == 0) return 0;
        return Math.Round(average/count,2);
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
        double[] temp = new double[array.Length+1];   
        int Index = -1;
        for (int i = array.Length - 1;i>-1; i--)
        {
            if (array[i] > 0) 
            {
                Index = i;
                break;
            }

        }
        if (Index == -1) return array;
        for (int i = 0; i <= Index; i++)
        {
            temp[i] = array[i];
        }
        temp[Index+1] = P;

        for (int i = Index+1; i < array.Length; i++)
        {
            temp[i+1] = array[i];
        }
        array = temp;
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
        int Imax = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > array[Imax]) Imax = i;
        }
        // end
        array[Imax] = Imax;
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
        if (k >  A.Length) return A;
        double[] output = new double[A.Length+B.Length];

        
        if (k == A.Length)
        {
            for (int i = 0; i<A.Length; i++)
            {
                output[i] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                output[i + A.Length] = B[i];
            }
            Draw(output);
            return output;
        }

        // code here
        for (int i = 0; i <= k; i++)
        {
            output[i] = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            output[k + 1 + i]= B[i];
        }
        for (int i = k+1; i < A.Length; i++)
        {
            output[B.Length + i] = A[i];
        }
        // end

        Draw(output);
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
        int Imax = 0, Imin = 0, count = 0;
        // code here
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] > array[Imax]) Imax = i;
            if (array[i] < array[Imin]) Imin = i;
        }
        if (Imax< Imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    count++;
                }
            }
        }
        else{
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    average += array[i];
                    count++;
                }
            }
        }
        // end
        if (count == 0) return 0;
        return Math.Round(average/count,2);
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
        double sum = 0;
        int Imax = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[Imax]) Imax = i;
            sum += array[i];
        }
        if (sum < array[Imax]) array[Imax] = 0;
        else if (array[Imax] < 0) array[Imax] /= 2;
        else array[Imax] *= 2;
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
        Draw(array);
        int Imax = 0;
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] > array[Imax]) Imax = i;
        }
        for (int i = 0; i < Imax/2*2; i += 2)
        {
            double temp = array[i];
            array[i] = array[i+1];
            array[i+1] = temp;
        }
        // end
        Draw(array);
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
        int count = 1, Mcount = 0;

        // code here
        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] >= array[i+1]) count++;
            else
            {
                if (Mcount < count) Mcount = count;
                count = 1;
            }
        }
        // end

        return Mcount;
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
        int count = 1, Mcount = 0;

        // code here

        // code here
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1]) count++;
            else
            {
                if (Mcount < count) Mcount = count;
                count = 1;
            }
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] <= array[i + 1])count++;
            
            else
            {
                if (Mcount < count) Mcount = count;
                count = 1;
            }
        }
        if (Mcount < count) Mcount = count;
        // end
        Draw(array);
        Console.WriteLine(Mcount);
        return Mcount;
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
        int count = 0,k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>=0) count++;
        }
        double[] ray = new double[count];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                ray[k] = array[i];
                k++;
            }
        }
        // end
        array = ray;
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

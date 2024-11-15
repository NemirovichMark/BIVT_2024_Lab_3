using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Serialization;
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
        for (int i=0; i<6; i++)
        {
            s+=array[i];
        }
        for (int i = 0; i < 6; i++)
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
        double s = 0, m = 0;
        for (int i=0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                s += array[i];
                m++;
            }
        }
        double sr = s / m;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
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
        for (int i = 0; i<4; i++)
        {
            sum[i] = first[i] + second[i];
            sum[i] = Math.Round(sum[i], 2);
        }
        for (int i = 0; i <4; i++)
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
        int cnt = 0;
        for(int i=0; i<5; i++)
        {
            s += array[i];
            cnt++;
        }
        double sr = s / cnt;
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
        for (int i=0; i<4; i+=2)
        {
            product += vector1[i] * vector2[i] + vector1[i + 1] * vector2[i + 1];
            product = Math.Round(product, 2);
        }
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i =0; i < 5; i++)
        {
            length += vector[i]* vector[i];
        }
        length = Math.Sqrt(length);
        length = Math.Round(length, 2);
        // end

        return Math.Round(length, 4); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0,cnt=0;

        for (int i = 0; i<7; i++)
        {
            sum += array[i];
            cnt++;
        }
        double sr = sum / cnt;
        for (int i = 0; i < 7; i++)
        {
            if (array[i] > sr)
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
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;
        double sum = 0,cnt=0;

        // code here
        for (int i = 0; i < 8; i++)
        {
            sum += array[i];
            cnt++;
        }
        double sr = sum / cnt;
        for (int i = 0; i < 8; i++)
        {
            if (array[i] > sr)
            {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i=0; i < 10; i++)
        {
            if (P<array[i]&& array[i] < Q)
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
        int cnt=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                cnt++;
            }
        }
        output = new double[cnt];
        cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                output[cnt++] = array[i];
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
        for (int i=0; i < array.Length; i++)
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
        int k = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            even[k]=array[i];
            k++;
        }
        k = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[k] = array[i];
            k++;
           
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
        for (int i = 0; i < x.Length; i++)
        {   
            if (x[i] > 0)
            {
                y[i] = Math.Round(Math.Log(x[i]) / 2,2);
            }
            else
            {
                y[i]=double.NaN;
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
        int k=0;
        double amin = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < amin)
            {
                amin = array[i];
                k=i;
            }
        }
        array[k] *= 2;
        
        
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int k=0;
        double amax = array[0];
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                k = i;
            }
        }
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] < array[k])
            {
                sum += array[i];
            }
            else
            {
                break;
            }
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
        int k = 0;
        double amax = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > amax)
            {
                amax = array[i];
                k = i;
            }
        }
        double s = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            s += array[i];
            cnt++;
        }
        double sr = s / cnt;
        sr = Math.Round(sr, 2);
        
        for (k++; k< array.Length; k++)
        {
            array[k] = sr;
            
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
        double sum = 0, cnt=0;
        
        for (int i=0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        double sr = sum / cnt;
        sr = Math.Round(sr, 0);

        double[] array2 = new double[array.Length + 1];
        double pi=0;
        for (int i = 0; i < array.Length; i++)
        {

            if (sr == array[i])
            {
                pi = i+1;
            }
        }
        for (int i = 0; i < array2.Length; i++)
        {
            if (pi > i)
            {
                array2[i] = array[i];
            }
            if (pi == i)
            {
                array2[i] = P;
            }
            if (pi < i)
            {
                array2[i] = array[i-1];
            }
        }
        // end

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
        // code here
        double max = array[0];
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        double min = array[k];
        int k1 = k;
        for (int i = k; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                k1 = i;
            }
        }
        if (k == k1) return array;

        double max2 = array[k];
        array[k] = array[k1];
        array[k1] = max2;



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
        double min = double.MaxValue;

        int k=-1;
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] < min && array[i]>0)
            {   
                 min = array[i];
                 k = i;
            }
        }
        if (k == -1)
        {
            return array;
        }

        double[] array2 = new double[array.Length - 1];
        for (int i=0; i < array2.Length; i++)
        {
            if (i < k)
            {
                array2[i] = array[i];
            }
            if (i == k)
            {
                array2[i] = array[i + 1];
            }
            if (i > k)
            {
                array2[i] = array[i + 1];
            }
        }
        // end

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
        // code here
        double minus;
        int k = 0,k2=0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                minus = array[i];
                k = i;
                break;
            }
        }
        double max = array[0];
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k2 = i;
            }
        }
        int s = k2 + 1;
        if (array[k2] == array.Length) return array;
        for (;s < array.Length; s++)
        {
            sum += array[s];
            
        }
        sum = Math.Round(sum, 2);
        array[k] = sum;
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
        double max = array[0], minus =0;
        int k=0,m = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                k = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                minus = array[i];
                m = i;
                break;
            }
        }
        if (m == -1)
        {
            return array;
        }
        double max2 = array[k];
        array[k] = array[m];
        array[m] = max2;
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
        

        // code here
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        double sr =Math.Round( sum / cnt,2);
        int cnt2 = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                cnt2++;
            }
        }
        int[] output = new int[cnt2];
        cnt2 = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[cnt2] = i;
                cnt2++;
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
        double max = array[0], max2 = array[1];
        
        for (int i = 0; i < array.Length; i += 2)
        {
            if (array[i] > max)
            {
                max =array[i];
                
            }
        }
        for (int i = 1; i < array.Length; i += 2)
        {
            if (array[i] > max2)
            {
                max2 = array[i];
                
            }
        }
        
        if (max > max2)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                array[i] = 0;
            }
        }
        else
        {
            for (int i=array.Length/2; i < array.Length; i++)
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
        double min = array[0], minus = 0;
        int kmin = 0, kminus = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                kmin = i;
            }
            
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                minus = array[i];
                kminus = i;
                break;
            }

        }
        if (kminus == -1) return 0;
        if (kminus < kmin)
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
        double max = array[0];
        int cnt = 0;
        for(int i = 0; i < array.Length; i++)
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
                cnt++;
                array[i] += cnt;
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
        for (int i = 2; i < array.Length; i+=2)
        {
            double key = array[i]; int j = i - 2;
            while (j>=0 && array[j] > key)
            {
                array[j + 2] = array[j];
                j-=2;
            }
            array[j + 2] = key;
        }
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

        // end

        return array;
    }
    public double[] Task_3_8(double[] array)
    {
        // code here
        int cnt = 0;
        for (int i=0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                cnt++;
            }
        }
        double[] nov = new double[cnt];
        cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
            {
                nov[cnt] = array[i];
                cnt++;

            }
        }
        for (int i = 1; i < nov.Length; i++)
        {
            double key = nov[i]; int j = i-1;
            while (j >= 0 && nov[j] < key)
            {
                nov[j+1] = nov[j];
                j --;
            }
            nov[j +1] = key;
        }
        cnt = 0;
        for (int i =0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = nov[cnt];
                cnt++;
            }
        }

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

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n)
    {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here
        globalMax = Double.MinValue; globalMin = Double.MaxValue;
        X = new double[n]; Y = new double[n];
        double shag = (b - a) / (n - 1);
        
        int k= 0;
        for (double i = a; i <= b; i += shag)
        {
            double value = Math.Cos(i) + i * Math.Sin(i);
            X[k] = Math.Round(i, 2);
            Y[k] = Math.Round(value, 2);
            k++;

            if (value > globalMax)
                globalMax = value;

            if (value < globalMin)
                globalMin = value;
        }
        // end

        return (X, Y, Math.Round(globalMax, 2), Math.Round(globalMin, 2));
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
        double max = array[0], min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        normalizedArray = new double [array.Length];
        for ( int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = Math.Round(2 * (array[i] - min) / (max - min) - 1, 2);
        }

        // end

        return normalizedArray;
    }
    #endregion
}

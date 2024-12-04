using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
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
        // code here
        
        double sum = 0;
        for ( int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for (int d = 0; d < array.Length; d++)
        {
            array[d] = Math.Round(array[d] / sum, 2);
        }

// end

return array;
}
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum += array[i];
                cnt++;
            }
        }
        double srar = sum / cnt;
        for (int t = 0; t < array.Length; t++)
        {
            if (array[t] > 0)
            {
                array[t] = Math.Round(srar, 2);

            }
        }

    // end

    return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
    double[] sum = new double[first.Length], dif = new double[first.Length];

    // code here
    for (int i = 0; i< 4; i++)
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
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i< array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        double srznach = sum / cnt;
        for ( int t = 0; t < array.Length; t++)
        {
            array[t] = Math.Round(array[t] - srznach, 2);
        }

    // end

    return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
    double product = 0;

        // code here
       
        for ( int i = 0; i < 4; i ++)
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
        for ( int i = 0; i < vector.Length; i ++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
    
    // end

    return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {

        // code here
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
            cnt++;
        }
        double srznach = sum / cnt;
        for ( int t = 0; t < array.Length; t++)
        {
            if (array[t] > srznach)
            {
                array[t] = 0;
            }
        }

    // end

    return array;
    }
    public int Task_1_8(double[] array)
    {
    int count = 0;

    // code here
    for (int i = 0; i < array.Length; i ++)
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

        // code here
        double sum = 0;
        int cnt = 0;
        for (int i = 0; i < array.Length; i ++)
        {
            sum += array[i];
            cnt++;
        }
        double srznach = sum / cnt;
        for ( int t = 0; t < array.Length; t ++ )
        {
            if (array[t] > srznach)
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
        foreach (double elem in array)
        {
            if (elem > P && elem < Q)
            {
                count ++;
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
        for (int i = 0; i < 10; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }
        }
        output = new double[count];
        int с = 0;
        for (int t = 0; t < 10; t++)
        {
            if (array[t] > 0)
            {
                output[с] = array[t];
                с++;

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
        for (int i = array.Length - 1; i >= 0; i--)
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
        int idev = 0;
        int idod = 0;
for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[idev++] = array[i];
            }
            else
            {
                odd[idod++] = array[i];
            }
               
        }
// end

return (even, odd);
}
public double Task_1_14(double[] array)
{
double sum = 0;

// code here
for (int i = 0; i < array.Length; i ++)
        {
            if (array[i] < 0)
            {
                break;
                
            }
            else
            {
                sum += array[i] * array[i];
            }
        }
// end

return sum;
}
    public double[] Task_1_15(double[] x)
    {
    double[] y = new double[x.Length];

        // code here
        int lengthArr = x.Length;

        for (int i = 0; i < lengthArr; i++)
        {
            if (x[i] == 0)
                y[i] = Double.NaN;
            else
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        // end

        return y;
    }
#endregion

#region Level 2
public double[] Task_2_1(double[] array)
{
        // code here
       ;
        double minValue = Double.MaxValue;
        int idMin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                idMin = i;
            }
        }
        if (array[idMin] < 0)
        {
            array[idMin] = minValue / 2;
        }
        else
        {
            array[idMin] = minValue * 2;
        }

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
        double min = array[0];
        int n = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                n = i;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i < n && array[i] >= 0)
                array[i] *= 2;
            else if (i < n && array[i] < 0)
                array[i] /= 2;
            
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
        double min = double.MaxValue, max = double.MinValue;
        int idmin = 0, idmax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }
        }
        int rv;
        if (idmin > idmax)
        {
            rv = idmax;
            idmax = idmin;
            idmin = rv;
        }
        idmin++;
        int cnt = 0;
        for (int i = idmin; i <= idmax; i++)
        {
            if (array[i] < 0)
            {
                cnt++;
            }
        }
        var res = new double[cnt];
        for (int i = 0; idmin < idmax; idmin++, i++)
        {
            if (array[idmin] < 0)
            {
                res[i] = array[idmin];
            }
        }
        array = res;
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
        
        int idMax = 0;
        double valMax = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valMax)
            {
                
                valMax = array[i];
                idMax = i;
            }
        }

        if (idMax == array.Length - 1)
            return array;
        else if (array[idMax + 1] > 0)
            array[idMax + 1] = array[idMax + 1] * 2;
        else
            array[idMax + 1] = array[idMax + 1] / 2;
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
       
        double min = array[0];
        double max = array[0];
        int idmin = 0, idmax = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                idmax = i;
            }

            if (array[i] < min)
            {
                min = array[i];
                idmin = i;
            }
        }


        if (idmin > idmax)
        {
            int temp = idmin;
            idmin = idmax;
            idmax = temp;
        }


        double sum = 0;
        int cnt = 0;
        for (int i = idmin + 1; i < idmax; i++)
        {
            sum += array[i];
            cnt++;
        }


        if (cnt > 0)
            average = sum / cnt;

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
        int id = -1;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] > 0)
            {
                id = i;
                break;
            }
        }
        double[] result = new double[array.Length + 1];
        if (id < 0) result = array;
        else
        {
            for (int i = 0; i <= id; i++)
            {
                result[i] = array[i];
            }
            result[id + 1] = P;
            for (int i = id + 1; i < array.Length; i++)
            {
                result[i + 1] = array[i];
            }
        }
        array = result;
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
     
        int idMax = 0;
        double valMax = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valMax && i % 2 == 0)
            {
              
                valMax = array[i];
                idMax = i;
            }
        }
        array[idMax] = idMax;
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
double[] output = null;

        // code here
        int lengthA = A.Length, lengthB = B.Length;
        output = new double[lengthA + lengthB];

        if (k == lengthA || k > lengthA)
            return A;

        if (k < 0)
            k = 0;

        k++;

        for (int i = 0; i < A.Length; i++)
        {
            if (i < k)
                output[i] = A[i];
            else if (i == k)
            {
                for (int j = 0; j < lengthB; j++)
                    output[k + j] = B[j];
            }
            output[i + lengthB] = A[i];
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

        // code here
     
        int idMax = 0, idMin = 0;
        double valMax = array[0], valMin = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > valMax)
            {
                
                valMax = array[i];
                idMax = i;
            }

            if (array[i] < valMin)
            {
                
                valMin = array[i];
                idMin = i;
            }
        }

        if (idMax < idMin)
        {
            double sumP = 0;
            int cntP = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > 0)
                {
                    cntP++;
                    sumP += array[j];
                }
            }

            if (cntP == 0)
                return 0;
            average = Math.Round(sumP / cntP, 3);
        }
        else
        {
            double sumD = 0;
            int cntD = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < 0)
                {
                    cntD++;
                    sumD += array[k];
                }
            }

            if (cntD == 0)
                return 0;
            average = Math.Round(sumD / cntD, 3);
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
        int idMax = 0;
        double sum = 0, valMax = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];

            if (array[i] > valMax)
            {
                idMax = i;
                valMax = array[i];
            }
        }

        if (valMax > sum)
            array[idMax] = 0;
        else
            array[idMax] = valMax * 2;
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
        double id = -1;
        int cnt = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > id)
            {
                id = array[i];
                cnt = 1;
            }
            else if (array[i] == id)
            {
                cnt++;
            }
        }

        if (cnt == 0)
            return output;

        output = new int[cnt];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == id)
            {
                output[index++] = i;
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
        if (array.Length == 0)
        {
            return array;
        }

        double max = double.MinValue;
        foreach (double x in array)
        {
            if (x > max)
            {
                max = x;
            }
        }

        double n = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                n += array[i];
                array[i] = Math.Round(n, 2) - array[i];
            }

            else
            {
                n += array[i];
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
        int p = 0;
        int o = 0;

        foreach (double n in array)
        {
            if (n >= 0)
            {
                p++;
            }
            else
            {
                o++;
            }
        }

        double[] polnumbers = new double[p];
        double[] otrnumbers = new double[o];

        int pid = 0, oid = 0;

        foreach (double num in array)
        {
            if (num >= 0)
            {
                polnumbers[pid++] = num;
            }
            else
            {
                otrnumbers[oid++] = num;
            }
        }

        double[] result = new double[array.Length];
        int index = 0;

        foreach (double num in polnumbers)
        {
            result[index++] = num;
        }

        foreach (double num in otrnumbers)
        {
            result[index++] = num;
        }
        array = result;

       
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
       
        for (int i = array.Length-1; i >=0; i-=2)
        {
            array[i] = array[i/2];
            array[i-1] = array[i];
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
        int n = 0; int p = 0;
        double[] nov = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            bool d = true;
            for (int j = 0; j < nov.Length; j++)
            {
                if (array[i] == nov[j])
                {
                    d = false;
                }
            }
            if (d == true)
            {
                nov[i] = array[i];
            }
        }
        for (int i = 0; i < nov.Length; i++)
        {
            if (nov[i] == 0 && nov[i] != array[i])
            {
                n++;
            }
        }
        double[] res = new double[nov.Length - n];

        for (int i = 0; i < nov.Length; i++)
        {
            if (nov[i] == array[i])
            {
                res[p] = nov[i];
                p++;
            }
        }
        array = res;
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
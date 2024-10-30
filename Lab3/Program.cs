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
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        for(int j = 0; j < array.Length; j++)
        {
            if (sum != 0)

            array[j] = Math.Round(array[j] / sum, 2);

            else 
            {
                array[j] = 0;
            }
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double avg = 0;
        double sum = 0;
        double cnt = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                sum += array[i];
                cnt++;
            }
        }
        if(cnt > 0)
        {
            avg = sum / cnt;
        }
        else
        {
            avg = 0;
        }
        for(int j = 0; j < array.Length; j++)
        {
            if(array[j] > 0)
            array[j] = Math.Round(avg, 2);
        }


        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++)
        {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }
        // end

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        int cnt = 0;
        double avg = 0;
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        if(cnt != 0)
        {
            avg = sum / cnt;
        }

        for(int i = 0; i < array.Length; i++)
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
        for(int i = 0; i < vector1.Length; i++)
        {
            product += vector1[i] * vector2[i];
        }

        // end

        return Math.Round(product, 2);
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for(int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);

        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int cnt = 0;
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        if (cnt!= 0)
        {
            avg = sum / cnt;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > avg)
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
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < 0)
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
        double avg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            cnt++;
        }
        if (cnt!= 0)
        {
            avg = sum / cnt;
        }
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > avg)
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
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > P && array[i] < Q)
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
        int j = 0;
  
        // code here
        for (int i = 0; i < array.Length; i++)
        {
           if(array[i] > 0)
           j++;
        }
        output = new double[j];
        j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
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
        double[] odd = new double[array.Length / 2];

        // code here
        int j = 0;
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[j] = array[i];
                j++;
            }
            else
            {
                odd[s] = array[i];
                s++;
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
                sum += Math.Pow(array[i], 2);
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
            if (x[i] != 0)
            {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
            else
            {
                y[i] = Double.NaN;
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
        int j = 0;
        double x = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < x)
            {
                x = array[i];
                j = i;
            }
        }
        array[j] = array[j] * 2;

        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double x = array[0];
        int s = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > x)
            {
                x = array[i];
                s = i;
            }
        }
        for(int j = 0; j < s; j++)
        {
            sum += array[j];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int j = 0;
        double x = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < x)
            {
                x = array[i];
                j = i;
            }
        }
        for (int s = 0; s < j; s++)
        {
            if(array[s] > 0)
            {
                array[s] *= 2;
            }    
            else if(array[s] < 0)
            {
                array[s] /=2;
            }
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
        double arrMax = array[0];
        double arrMin = array[0];
        int count = 0;
        int indArrMax = 0;
        int indArrMin = 0;
        int startIndex = 0;
        int endIndex = 0;
        
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > arrMax)
            {
                arrMax = array[i];
                indArrMax = i;
            }
            else if (array[i] < arrMin)
            {
                arrMin = array[i];
                indArrMin = i;
            }
        }
        startIndex = Math.Min(indArrMin, indArrMax);
        endIndex = Math.Max(indArrMin, indArrMax);
        for(int j = startIndex + 1; j < endIndex; j++)
        {
            if (array[j] < 0)
            {
                count++;
            }
        }
        double[] arr = new double[count];
        count = 0;
         for(int j = startIndex + 1; j < endIndex; j++)
        {
            if (array[j] < 0)
            {
                arr[count] = array[j];
                count++;
               
            }
        }

        // end

        return arr;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here

        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code 
        int indMax = 0;
        double maxElem = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if(maxElem < array[i])
            {
                maxElem = array[i];
                indMax = i;
            }
        }
        if (indMax == array.Length - 1)
        {
            return array;
        }
        else if(array[indMax + 1] > 0)
        {
            array[indMax + 1] *= 2;
        }
        else if(array[indMax + 1] < 0)
        {
            array[indMax + 1] /= 2;
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
        double arrMax = array[0];
        double arrMin = array[0];
        int indArrMax = 0;
        int indArrMin = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > arrMax)
            {
                arrMax = array[i];
                indArrMax = i;
            }
            else if (array[i] < arrMin)
            {
                arrMin = array[i];
                indArrMin = i;
            }
        }

        int startIndex = Math.Min(indArrMin, indArrMax);
        int endIndex = Math.Max(indArrMin, indArrMax);
    
        double sum = 0;
        int count = 0;

        for (int j = startIndex + 1; j < endIndex; j++)
        {
            sum += array[j];
            count++;
        }

        if(count == 0)
        {
            return 0;
        }
        average = sum / count;
        return Math.Round(average, 2);
        // end
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
        int index = -1;
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                index = i;
            }
        }
        if (index < 0)
        {
            return array;
        }
        double[] array2 = new double[array.Length + 1];
        for (int j = 0; j < array.Length + 1; j++)
        {
            if (j < index + 1)
            {
                array2[j] = array[j];
            }
            else if (j == index + 1)
            {
                array2[j] = P;
            }
            else
            {
                array2[j] = array[j - 1];
            }
        }

        // end

        return array2;
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
        int indexMax = 0;
        double x = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > x && i % 2 == 0)
            {
                x = array[i];
                indexMax = i;
            }
        }
        array[indexMax] = indexMax;

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
        k = k + 1;
        if (k < 0) k = 0; 
        if (k > A.Length) k = A.Length;

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
        double sum = 0;
        int count = 0;
        double maxElements = array[0];
        double minElements = array[0];
        int indArrMax = 0;
        int indArrMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxElements)
            {
                maxElements = array[i];
                indArrMax = i;
            }
            if (array[i] < minElements)
            {
                minElements = array[i];
                indArrMin = i;
            }
        }
        if(indArrMin < indArrMax)
        {
            for(int j = 0; j < array.Length; j++)
            {
                if(array[j] < 0)
                {
                    sum += array[j];
                    count++;
                }
            }
        }
        else if (indArrMax < indArrMin)
        {
            for(int s = 0; s < array.Length; s++)
            {
                if(array[s] > 0)
                {
                    sum += array[s];
                    count++;
                }
            }
        }
        if (count == 0)
        return 0;
        average = sum / count;
        return Math.Round(average, 2);

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
        double sum = 0;
        int indexMaxElements = 0;
        double maxElements = array[0];
        for(int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (array[i] > maxElements)
            {
                maxElements = array[i];
                indexMaxElements = i;
            }
        }
        if(maxElements > sum)
        {
            array[indexMaxElements] = 0;
        }
        else if(maxElements < sum)
        {
            if(maxElements > 0)
            {
                array[indexMaxElements] *= 2;
            }
            else if(maxElements < 0)
            {
                array[indexMaxElements] /= 2;
            }
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

        // end

        return array;
    }
    public double[] Task_3_3(double[] array)
    {
        // code here
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }   
        }

        for (int i = 0; i < maxIndex - 1; i += 2)
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
        int count = 0;

        // code here
        int currentLength = 1; 

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) 
            {
                currentLength++; 
                count = Math.Max(count, currentLength); 
            }
            else
            {
                currentLength = 1; 
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
        int descending = 0;
        int currentLength = 1; 

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) 
            {
                currentLength++; 
                descending = Math.Max(descending, currentLength); 
            }
            else
            {
                currentLength = 1; 
            }
        }
        
        currentLength = 1; 
        int increase = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1]) 
            {
                currentLength++; 
                increase = Math.Max(increase, currentLength); 
            }
            else
            {
                currentLength = 1; 
            }
        }

        count = Math.Max(increase, descending);
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
        double[] normalizedArray = new double[array.Length];
        for(int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = array[i];
        }
        for(int i = 0; i < normalizedArray.Length; i++)
        {
            if(array[i] >= 0)
            {
                count++;
            }
        }
        array = new double[count];
        count = 0;
        for(int i = 0; i < normalizedArray.Length; i++)
        {
            if(normalizedArray[i] >= 0)
            {
                array[count] = normalizedArray[i];
                count++;
            }
        }
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
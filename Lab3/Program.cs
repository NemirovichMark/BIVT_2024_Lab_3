using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Globalization;
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
        //program.Task_3_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        int lengthArray = array.Length;

        for (int i = 0; i < lengthArray; i++)
            sum += array[i];

        for (int j = 0; j < lengthArray; j++)
        {
            if (sum != 0)
                array[j] = Math.Round(array[j] / sum, 2);
            else
                array[j] = 0;
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        int lengthArray = array.Length;
        double sumPos = 0;
        int cntPos = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            if (array[i] > 0)
            {
                cntPos++;
                sumPos += array[i];
            } 
        }

        for (int j = 0; j < lengthArray; j++)
        {
            if (array[j] > 0)
                array[j] = Math.Round(sumPos / cntPos, 2);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        int lengthArray = first.Length;

        for (int i = 0; i < lengthArray; i++)
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
        double sumArray = 0;
        int lengthArray = array.Length;

        for (int i = 0; i < lengthArray; i++)
            sumArray += array[i];

        for (int j = 0; j < lengthArray; j++)
        {
            array[j] = Math.Round(array[j] - sumArray / lengthArray, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        int lengthArray = vector1.Length;
        double p = 1, sum = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            sum += vector1[i] * vector2[i];
        }
        product = Math.Round(sum, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        int lengthArray = vector.Length;

        for (int i = 0; i < lengthArray; i++)
        {
            length += vector[i] * vector[i];
        }
        // end

        return Math.Round(Math.Sqrt(length), 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        int lengthArray = array.Length;
        double Avg = 0, sumArray = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            sumArray += array[i];
        }

        Avg = sumArray / lengthArray;

        for (int j = 0; j < lengthArray; j++)
        {
            if (array[j] > Avg)
                array[j] = 0;
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        int lengthArray = array.Length, cntNegativeNum = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            if (array[i] < 0)
                cntNegativeNum++;
        }
        count = cntNegativeNum;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        int lengthArray = array.Length;
        double avg = 0, sumArr = 0;

        for (int i = 0; i < lengthArray; i++)
        {
            sumArr += array[i];
        }

        avg = sumArr / lengthArray;

        for (int j = 0; j < lengthArray; j++)
        {
            if (array[j] > avg)
                count++;
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        int lengthArr = array.Length;

        if (P < 0 && Q > lengthArr)
            return 0;
        
        for (int i = P; i < lengthArr; i++)
        {
            if (array[i] > P && array[i] < Q)
                count++;
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int lengthArr = array.Length;
        int cntPos = 0;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > 0)
                cntPos++;
        }

        int lengthNewArr = cntPos;
        output = new double[lengthNewArr];
        int indexNewArr = 0;
        for (int j = 0; j < lengthArr; j++)
        {
            if (array[j] > 0)
            {
                output[indexNewArr] = array[j];
                indexNewArr++;
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
        int lengthArr = array.Length;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < 0)
            {
                index = i;
                value = array[i];
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];
        int indEven = 0, indOdd = 0;
        // code here
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                even[indEven] = array[i];
                indEven++;
            }
            else
            {
                odd[indOdd] = array[i];
                indOdd++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;
        // code here
        int lengthArr = array.Length;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < 0)
                break;
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
        int lengthArr = array.Length;
        double minValue = Double.MaxValue;
        int indMin = 0;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                indMin = i;
            }        
        }
        array[indMin] = minValue * 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int lengthArr = array.Length, indMax = 0;
        double valueMax = double.MinValue;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valueMax)
            {
                valueMax = array[i];
                indMax = i;
            }
        }

        for (int j = 0; j < indMax; j++)
        {
            sum += array[j];
        }
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int lengthArr = array.Length, indMin = 0;
        double valueMin = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < valueMin)
            {
                valueMin = array[i];
                indMin = i;
            }
        }

        for (int j = 0; j < indMin; j++)
        {
            if (array[j] > 0)
                array[j] = Math.Round(array[j] * 2, 2);
            else 
                array[j] = Math.Round(array[j] / 2, 2);
        }
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        int lengthArr = array.Length, indMax = 0;
        double valueMax = array[0], sum = 0, avg = 0;

        for (int i = 0; i < lengthArr; i++)
        { 
            sum += array[i];

            if (array[i] > valueMax)
            {
                valueMax = array[i];
                indMax = i;
            }
        }

        avg = Math.Round(sum / lengthArr, 2);

        for (int j = indMax + 1; j < lengthArr; j++)
        {
            array[j] = avg;
        }
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        int lengthArr = array.Length;
        int indMax = 0, indMin = 0;
        double valMax = array[0], valMin = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax)
            {
                indMax = i;
                valMax = array[i];
            }
            
            if (array[i] < valMin)
            {
                indMin = i;
                valMin = array[i];
            }
        }

        int cnt = 0;
        for (int k = Math.Min(indMax, indMin); k < Math.Max(indMax, indMin); k++)
        {
            if (array[k] < 0)
                cnt++;
        }

        int indNew = 0;
        double[] newArr = new double [cnt];
        for (int j = Math.Min(indMax, indMin) + 1; j < Math.Max(indMax, indMin); j++)
        {
            if (array[j] < 0)
            {
                newArr[indNew] = array[j];
                indNew++;
            }
        }

        // end

        return newArr;
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
        int lengthArr = array.Length;
        int indMax = 0;
        double valMax = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax)
            {
                indMax = i;
                valMax = array[i];
            }
        }

        if (indMax == lengthArr - 1)
            return array;
        else if (array[indMax + 1] > 0)
            array[indMax + 1] = array[indMax + 1] * 2;
        else 
            array[indMax + 1] = array[indMax + 1] / 2;
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
        int lengthArr = array.Length;
        int indMax = 0, indMin = 0;
        double valMax = array[0], valMin = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax)
            {
                indMax = i;
                valMax = array[i];
            }
            
            if (array[i] < valMin)
            {
                indMin = i;
                valMin = array[i];
            }
        }

        double sum = 0;
        int cnt = 0;

        for (int j = Math.Min(indMax, indMin) + 1; j < Math.Max(indMax, indMin); j++)
        {
            sum += array[j];
            cnt++;
        }

        if (cnt == 0)
            return 0;

        average = Math.Round(sum / cnt, 2);
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
        int indPos = -1;
        int lengthArr = array.Length;

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > 0)
                indPos = i;
        }

        if (indPos == -1)
            return array;

        double[] newArr = new double [lengthArr + 1];
        for (int j = 0; j < lengthArr + 1; j++)
        {
            if (j < indPos + 1)
                newArr[j] = array[j];
            else if (indPos + 1 == j)
                newArr[j] = P;
            else
                newArr[j] = array[j - 1];
        }
        // end

        return newArr;
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
        int lengthArr = array.Length;
        int indMax = 0;
        double valMax = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax && i % 2 == 0)
            {
                indMax = i;
                valMax = array[i];
            }
        }
        array[indMax] = indMax;
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
        if (k < 0)
            k = 0;
        
        k++;
        int lengthArrA = A.Length, lengthArrB = B.Length;
        output = new double [lengthArrA + lengthArrB];

        for (int i = 0; i < A.Length; i++)
        {
            if (i < k)
                output[i] = A[i];
            else if (i == k)
            {
                for (int j = 0; j < lengthArrB; j++)
                    output[k + j] = B[j];
            }
            output[i + lengthArrB] = A[i];
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
        int lengthArr = array.Length;
        int indMax = 0, indMin = 0;
        double valMax = array[0], valMin = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax)
            {
                indMax = i;
                valMax = array[i];
            }
            
            if (array[i] < valMin)
            {
                indMin = i;
                valMin = array[i];
            }
        }

        if (indMax < indMin)
        {
            double sumPos = 0;
            int cntPos = 0;
            for (int j = 0; j < lengthArr; j++)
            {
                if (array[j] > 0)
                {
                    cntPos++;
                    sumPos += array[j];
                }
            }
            
            if (cntPos == 0)
                return 0;
            average = Math.Round(sumPos / cntPos, 2);
        }
        else
        {
            double sumDif = 0;
            int cntDif = 0;
            for (int k = 0; k < lengthArr; k++)
            {
                if (array[k] < 0)
                {
                    cntDif++;
                    sumDif += array[k];
                }
            }

            if (cntDif == 0)
                return 0;
            average = Math.Round(sumDif / cntDif, 2);
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
        int lengthArr = array.Length, indMax = 0;
        double sum = 0, valMax = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            sum += array[i];

            if (array[i] > valMax)
            {
                indMax = i;
                valMax = array[i];
            }
        }

        if (valMax > sum)
            array[indMax] = 0;
        else
            array[indMax] = valMax * 2;
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
        int lengthArr = array.Length;
        double valMax = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] > valMax)
                valMax = array[i];
        }

        int cntMax = 1;
        for (int j = 0; j < lengthArr; j++)
        {
            if (array[j] == valMax)
            {
                array[j] = valMax + cntMax;
                cntMax++;
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
        int lengthArr = array.Length;
        double[] arrayB = null;

        if (lengthArr % 2 == 0)
            arrayB = new double[lengthArr / 2];
        else
            arrayB = new double[lengthArr / 2 + 1];

        int indB = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            if (i % 2 == 0)
            {
                arrayB[indB] = array[i];
                indB++;
            }
        }

        for (int k = 1; k < arrayB.Length; k++)
        {
            double key = arrayB[k];
            int j = k - 1;
            while(j >= 0 && arrayB[j] > key)
            {
                arrayB[j + 1] = arrayB[j];
                j--;
            }
            arrayB[j + 1] = key;
        }

        indB = 0;
        for (int j = 0; j < lengthArr; j++)
        {
            if (j % 2 == 0)
            {
                array[j] = arrayB[indB];
                indB++;
            }
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
        int lengthArr = array.Length;

        int cntDif = 0;
        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < 0)
                cntDif++;
        }

        double[] arrayB = new double [cntDif];

        int indB = 0;
        for (int p = 0; p < lengthArr; p++)
        {
            if (array[p] < 0)
            {
                arrayB[indB] = array[p];
                indB++;
            }
        }

        for (int k = 1; k < arrayB.Length; k++)
        {
            double key = arrayB[k];
            int j = k - 1;
            while(j >= 0 && arrayB[j] < key)
            {
                arrayB[j + 1] = arrayB[j];
                j--;
            }
            arrayB[j + 1] = key;
        }

        indB = 0;
        for (int y = 0; y < lengthArr; y++)
        {
            if (array[y] < 0)
            {
                array[y] = arrayB[indB];
                indB++;
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
        X = new double [n]; Y = new double [n];
        double step = (b - a) / (n - 1);
        //double step = Math.Round((b - a) / (n - 1), 2);
        
        

        int ind = 0;
        for(double i = a; i <= b; i += step)
        {
            double value = Math.Cos(i) + i * Math.Sin(i);
            X[ind] = Math.Round(i, 2);
            Y[ind] = Math.Round(value, 2);
            ind++;

            if (value > globalMax)
                globalMax = value;
            
            if ( value < globalMin)
                globalMin = value;
        }

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

        // end

        return array;
    }
    public double[] Task_3_14(double[] array)
    {
        double[] normalizedArray = null;

        // code here
        int lengthArr = array.Length;
        double maxVal = array[0], minVal = array[0];

        for (int i = 0; i < lengthArr; i++)
        {
            if (array[i] < minVal)
                minVal = array[i];

            if (array[i] > maxVal)
                maxVal = array[i];
        }

        normalizedArray = new double [lengthArr];
        for (int j = 0; j < lengthArr; j++)
        {
            normalizedArray[j] = Math.Round(2 * (array[j] - minVal) / (maxVal - minVal) - 1, 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}

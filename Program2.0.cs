using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
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
        foreach (double el in array) 
            s += el;
        
        for (int i = 0; i < array.Length; i++) {
            Math.Round(array[i] /= s, 2); 
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double average = 0;
        int k = 0;
        foreach (double el in array)
            if (el > 0) {average += el; k++;}
            
            
        average /= k;
        average = Math.Round(average, 2);

        for (int i = 0; i < array.Length; i++) 
            if (array[i] > 0) array[i] = average;
        
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++) {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = first[i] - second[i];
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double average = 0;
        foreach (double i in array)
            average += i;

        average /= array.Length;
        average = Math.Round(average, 2);
        for (int i = 0; i < array.Length; i++)
            array[i] = Math.Round(array[i] - average, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < vector1.Length; i++) 
            product += vector1[i] * vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double i in vector) 
            length += i * i;
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double average = 0;
        foreach (double i in array)
            average += i;
        average /= array.Length; 
        for (int i = 0; i < array.Length; i++)
            if (array[i] > average) array[i] = 0;
        

        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach (double i in array) 
            if (i < 0) count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double average = 0;
        foreach (double i in array)
            average += i;
        average /= array.Length;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > average) count++;

        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach (double i in array)
            if (P < i && i < Q) count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int size = 0;
        foreach (double i in array)
            if (i > 0) size++;
        
        output = new double[size];
        int j = 0;
        foreach (double i in array)
            if (i > 0) {
                output[j] = i;
                j++;
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
            if (array[i] < 0) {
                value = array[i];
                index = i;
            }
        
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        for (int i = 0, j = 0; i < array.Length; i += 2) {
            even[j] = array[i];
            odd[j] = array[i+1];
            j++;
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double i in array) {
            if (i < 0) break;
            sum += i*i;
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < x.Length; i++) {
            if (x[i] <= 0) {
                y[i] = double.NaN;
                continue;
            }
            y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }
        for (int i = 0; i < x.Length; i++) 
            Console.WriteLine($"{x[i]:F4}\t\t{y[i]:F4}");

        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        double min = array[0];
        int j = 0;
        for (int i = 1; i < array.Length; i++) 
            if (array[i] < min) {
                min = array[i];
                j = i;
                }
        
        if (array[j] >= 0) array[j] *= 2;
        else array[j] /= 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        double max = array[0];
        foreach (var i in array) 
            if (i > max) max = i;
    
        foreach (var i in array) {
            if (i == max) break;
            sum += i;
        }

        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        double min = array[0];
        int j = 0;
        for (int i = 1; i < array.Length; i++) 
            if (array[i] < min) {
                min = array[i];
                j = i;
                }
        
        for (int i = 0; i < j; i++)
            if (array[i] >= 0) array[i] *= 2;
            else array[i] /= 2;
        
        
        
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double average = 0, max = array[0];
        int j = 0;
        
        for (int i = 0; i < array.Length; i++) {
            average += array[i];
            if (array[i] >= max) {
                max = array[i];
                j = i;
            }
        }
        j++;
        average /= array.Length;
        average = Math.Round(average, 2);

        for (; j < array.Length; j++) 
            array[j] = average;
        
            
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        int iMin = 0, iMax = 0;
        double vMin = array[0], vMax = array[0];
        for (int j = 1; j < array.Length; j++) {
            if (array[j] < vMin) {
                vMin = array[j];
                iMin = j;
            }
            if (array[j] > vMax) {
                vMax = array[j];
                iMax = j;
            }
        }
        int tmp;
        if (iMin > iMax) {
            tmp = iMax;
            iMax = iMin;
            iMin = tmp;
        }

        ++iMin;
        int size = 0;
        for (int i = iMin; i <= iMax; i++) 
            if (array[i] < 0) size++;

        var a = new double[size];

        for (int i = 0; iMin < iMax; iMin++, i++)
            if (array[iMin] < 0) 
                a[i] = array[iMin];
            
        array = a;
        
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
        double max = array[0];
        int j = 0;

        for (int i = 1; i < array.Length; i++)
            if (array[i] > max) {
                max = array[i];
                j = i;
            }
        if (j != array.Length-1) 
            if (array[j+1] >= 0) array[j+1] += array[j+1];
                else array[j+1] += Math.Abs(array[j+1] / 2);
                
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
        int iMin = 0, iMax = 0;
        double vMin = array[0], vMax = array[0];
        for (int j = 1; j < array.Length; j++) {
            if (array[j] < vMin) {
                vMin = array[j];
                iMin = j;
            }
            if (array[j] > vMax) {
                vMax = array[j];
                iMax = j;
            }
        }
        if (iMin == iMax+1) return 0;
        int tmp;
        if (iMin > iMax) {
            tmp = iMax;
            iMax = iMin;
            iMin = tmp;
        }
        ++iMin;
        int k = iMax - iMin;
        for (; iMin < iMax; iMin++)
            average += array[iMin];
        
        average /= k;

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
        int last = 0;
        double[] result = new double[array.Length+1];
        for (int i = 1; i < array.Length; i++) 
            if (array[i] > 0) last = i;
        
        if (last == 0 && array[last] < 0) return array;

        for (int i = 0; i <= last; i++) 
            result[i] = array[i];

        result[last+1] = P;
        ++last;

        for (; last < array.Length; last++) 
            result[last+1] = array[last];

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
        double max = array[0];
        int j = 0;
        for (int i = 2; i < array.Length; i += 2)
            if (array[i] > max) {
                max = array[i];
                j = i;
            }
        array[j] = j;
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
        if (k >= A.Length) return A;
        output = new double[A.Length+B.Length];
        for (int i = 0; i <= k; i++) 
            output[i] = A[i];
        ++k;
        int j = k;
        for (int i = 0; i < B.Length; i++)
            output[i+j] = B[i];
        for (; k < A.Length; k++)
            output[k+B.Length] = A[k];
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
        int iMin = 0, iMax = 0, k1 = 0, k2 = 0;
        double vMin = array[0], vMax = array[0], minusAverage = 0, plusAverage = 0;
        for (int j = 0; j < array.Length; j++) {
            if (array[j] < vMin) {
                vMin = array[j];
                iMin = j;
            }
            if (array[j] > vMax) {
                vMax = array[j];
                iMax = j;
            }
            if (array[j] > 0) {
                plusAverage += array[j];
                k1++;
            }
            if (array[j] < 0) {
                minusAverage += array[j];
                k2++;
            }
        }
        if (iMax < iMin && k1 > 0) average = plusAverage / k1;
        else if (iMax > iMin && k2 > 0) average = minusAverage / k2;
        else return 0;
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
        double s = 0, max = array[0];
        int j = 0;
        for (int i = 0; i < array.Length; i++) {
            s += array[i];
            if (array[i] > max) {
                max = array[i];
                j = i;
            }
        }
        double test = array[j] > s ? array[j] = 0: array[j] *= 2;
    
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
        double max = array[0];
        int j = 0;
        var result = new double[array.Length];
        for (int i = 1; i < array.Length; i++) 
            if (array[i] > max) {
                max = array[i];
                j = i;
            }
        for (int i = 0; i < j; i += 2) {
            result[i] = array[i+1];
            result[i+1] = array[i];
        }
        if (j % 2 != 0) result[j-1] = array[j-1];
        for (; j < array.Length; j++) 
            result[j] = array[j];
        array = result;
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
        ++count;
        int max = count;
        for (int i = 0; i < array.Length-1; i++) 
            if (array[i] > array[i+1]) count++;
            else { if (count > max) max = count; count = 1; }

        if (count > max) return count;
        count = max;
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

        int c1 = 1, c2 = 1, max1 = c1, max2 = c2;
        
        for (int i = 0; i < array.Length-1; i++) {
            if (array[i] > array[i+1]) c1++;
            else { if (c1 > max1) max1 = c1; c1 = 1; }
            
            if (array[i] < array[i+1]) c2++;
            else { if (c2 > max2) max2 = c2; c2 = 1; }
        }
        if (c1 > max1) max1 = c1;
        if (c2 > max2) max2 = c2;

        if (max1 > max2) count = max1;
        else count = max2;
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
        int l = 0;
        foreach (var i in array) 
            if (i >= 0) l++;
        var result = new double[l];
        
        for (int i = 0, j = 0; i < array.Length; i++) 
            if (array[i] >= 0) { 
                result[j] = array[i];
                ++j;
            }
        array = result;
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
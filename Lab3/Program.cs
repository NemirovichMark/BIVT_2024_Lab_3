using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(new double[] {0, 1.5, 1, 3, -2.2, -0.5});
        //program.Task_1_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double sum = 0;
        for (int i = 0; i <= 5; i++) sum += array[i];
        for (int i = 0; i <= 5; i++) {array[i] = Math.Round(array[i]/sum,2);System.Console.WriteLine(array[i].ToString());}
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        for (int i = 0; i <= 7; i++) if (array[i] > 0) {sum+=array[i]; count++;}
        sum = Math.Round(sum/count, 2);
        for (int i = 0; i <= 7; i++) {if (array[i] > 0) array[i] = sum; System.Console.WriteLine(array[i].ToString());}
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i<=3; i++) {sum[i]= Math.Round(first[i] + second[i], 2); dif[i]= Math.Round(first[i] - second[i], 2);}

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        for (int i = 0; i <= 4; i++) {sum+=array[i]; count++;}
        sum = Math.Round(sum/count, 2);
        for (int i = 0; i <= 4; i++) array[i] = Math.Round(array[i] - sum, 2);
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i <= 3; i++) product += vector1[i] * vector2[i];
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i <= 4; i++) length += vector[i] * vector[i];
        length = Math.Round(Math.Sqrt(length), 2);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double sum = 0;
        int count = 0;
        for (int i = 0; i <= 6; i++) {sum+=array[i]; count++;}
        sum = Math.Round(sum/count, 2);
        for (int i = 0; i <= 6; i++) if (array[i] > sum) array[i] = 0;
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        for (int i = 0; i <= 5; i++) if (array[i] < 0) count++;
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double sum = 0;
        int num = 0;
        for (int i = 0; i <= 7; i++) {sum+=array[i]; num++;}
        sum = Math.Round(sum/num, 2);
        for (int i = 0; i <= 7; i++) if (array[i] > sum) count++;
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        for (int i = 0; i <= 9; i++) if (P < array[i] && Q > array[i]) count++;
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        for (int i = 0; i <= 9; i++) if (array[i] > 0) count++;
        output = new double[count];
        for (int i = 0, index = 0; i <= 9; i++) if (array[i] > 0) {output[index]=array[i]; index++;}
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i <= 7; i++) if (array[i]<0) {value = array[i]; index = i;}
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i <= 9; i++) if (i % 2.0 > 0.01) {odd[index2] = array[i]; index2++;} else {even[index1] = array[i]; index1++;}
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        for (int i = 0; i <= 10; i++){if (array[i] < 0) break; sum+=array[i]*array[i];}
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i <= 9; i++) if (x[i]>0) y[i]=Math.Round(0.5*Math.Log(x[i]),2); else y[i] = double.NaN;
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
        double maxValue = double.MinValue;
        int maxValueIndex = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > maxValue) {maxValueIndex = i; maxValue = array[i];}
        for (int i= 0; i < maxValueIndex; i++ ) sum += array[i];
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        System.Console.WriteLine(sum.ToString() + " Poyasnyayushii text");
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
        double maxValue = double.MinValue;
        int maxValueIndex = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++) {if (array[i] > maxValue) {maxValueIndex = i; maxValue = array[i];} sum += array[i];}
        sum = Math.Round(sum / array.Length, 2);
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        for (int i= maxValueIndex + 1; i < array.Length; i++ ) array[i] = sum;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double diff = double.MaxValue;
        double index = 0;
        double sum = 0;
        double[] array2 = new double[array.Length+1];
        for (int i = 0; i < array.Length; i++) sum+= array[i];
        sum = sum/array.Length;
        for (int i = 0; i < array.Length; i++) if (Math.Abs(sum - array[i]) < diff) { diff = Math.Abs(sum - array[i]); index = i+1;}
        for (int i = 0; i < array.Length; i++) {if (i < index) array2[i] = array[i]; if (i == index) {array2[i] = P; array2[i+1] = array[i];}; if (i> index) array2[i+1] = array[i];}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        array = array2;
        foreach (double item in array2) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double min = double.MaxValue;
        double max = double.MinValue;
        int indexMin = 0;
        int indexMax = 0;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        for (int i = 0; i < array.Length; i++) {if (array[i] > max) {max = array[i]; indexMax = i;}}
        if (indexMax == array.Length - 1) {
            foreach (double item in array) Console.Write(item.ToString()+ " ");
            System.Console.WriteLine(" Poyasnyayushii text");
            return array;}
        for (int i = indexMax+1; i < array.Length; i++) {if (array[i] < min) {min = array[i]; indexMin = i;}}
        array[indexMin] = max;
        array[indexMax] = min;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double indexMin = -1;
        for (int i = 0; i < array.Length; i++) { if (array[i] > 0) if (array[i] < min) {min = array[i]; indexMin = i;}}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        if (indexMin != -1){ 
            for (int i = 0; i < array.Length; i++){if (i > indexMin) array[i-1] = array[i];}
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        int firstIndex = -1;
        double max = double.MinValue;
        int maxIndex = -1;
        double sum = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) {firstIndex = i; break;}
        for (int i = 0; i < array.Length; i++)  if (array[i] > max) {max = array[i]; maxIndex = i;}
        for (int i = maxIndex + 1; i < array.Length; i++) sum += array[i];
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        if (firstIndex != -1) array[firstIndex] = Math.Round(sum, 1);
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double first = 0;
        int firstIndex = -1;
        double max = double.MinValue;
        int maxIndex = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) {firstIndex = i; first = array[i]; break;}
        for (int i = 0; i < array.Length; i++)  if (array[i] > max) {max = array[i]; maxIndex = i;}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        if (firstIndex != -1)
        {
            array[firstIndex] = max;
            array[maxIndex] = first;
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++) sum+= array[i];
        sum = sum / array.Length;
        for (int i = 0; i < array.Length; i++) if (array[i] < sum) count++;
        output = new int[count];
        count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] < sum) {output[count] = i; count++;}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double max1 = double.MinValue;
        double max2 = max1;
        for (int i = 0; i < array.Length; i++) {if (i % 2 == 0) if (array[i] > max1) max1 = array[i]; if (i % 2 != 0) if (array[i] > max2) max2 = array[i];}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        if (max1 > max2)
        {
            for (int i = 0; i < array.Length / 2; i++) array[i] = 0;
        }
        else for (int i = array.Length / 2; i < array.Length; i++) array[i] = 0;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        int firstIndex = -1;
        double min = double.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) {firstIndex = i; break;}
        for (int i = 0; i < array.Length; i++)  if (array[i] < min) {min = array[i]; minIndex = i;}
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        if (firstIndex == -1) {System.Console.WriteLine(sum.ToString() + " Poyasnyayushii text"); return sum;}
        if (firstIndex < minIndex) {for (int i = 0; i < array.Length; i++) {if (i % 2 == 0) {sum += array[i];}}}
        else for (int g = 0; g < array.Length; g++) if (g % 2 != 0) sum += array[g];
        System.Console.WriteLine(sum.ToString() + " Poyasnyayushii text");
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array)
    {
        int[] output = null;

        // code here
        double max = double.MinValue;
        int[] massiv = new int[100];
        int count = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] == max) {count++; massiv[count] = i;}
            if (array[i] > max) {max = array[i]; count = 0; massiv[count] = i;}
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        output = new int[count+1];
        for (int i = 0; i < count+1; i++) output[i] = massiv[i];
        foreach (double item in output) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double max = double.MinValue;
        int[] massiv = new int[100];
        int count = 0;
        for (int i = 0; i < array.Length; i++){
            if (array[i] == max) {count++; massiv[count] = i;}
            if (array[i] > max) {max = array[i]; count = 0; massiv[count] = i;}
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        double[] ans = new double[count+1];
        for (int i = 0; i < count+1; i++){
            double sum = 0;
            for (int k = 0; k < massiv[i]; k++) {sum += array[k];}
            ans[i] = sum;
        }
        for (int i = 0; i < count+1; i++){
            array[massiv[i]] = ans[i];
        }
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        
        int count = 0;
        int count2 = 0;
        int count3 = 0;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) count++;
        double[] inter = new double[count];
        double[] inter2 = new double[array.Length-count];
        for (int i = 0; i < array.Length; i++) if (array[i] < 0) {inter[count2] = array[i]; count2++;} else {inter2[count3] = array[i]; count3++;}
        for (int i = 0; i < array.Length; i++)  if (i <= array.Length-count-1) array[i] = inter2[i]; else array[i] = inter[i-(array.Length-count)];
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        double[] inter = new double[array.Length];
        for (int i = 0; i < array.Length/2; i++) {inter[2*i] = array[i]; inter[2*i+1] = array[i];}
        array = inter;
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
        double[] inter = new double[array.Length];
        foreach (double item in inter) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine();
        int count = 0;
        for (int i = 0; i < array.Length; i++) 
        {
            int check = 0;
            for (int k = 0; k < array.Length; k++) {if (array[i] == inter[k] && !((i==0) && array[i]==0)) check++;}
            if (check == 0) {inter[count] = array[i]; count++;}

        }
        array = new double[count];
        for (int i=0; i < count; i++) array[i] = inter[i];
        foreach (double item in array) Console.Write(item.ToString()+ " ");
        System.Console.WriteLine(" Poyasnyayushii text");
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
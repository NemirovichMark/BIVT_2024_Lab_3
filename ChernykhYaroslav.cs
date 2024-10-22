using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        //--------------------------LEVEL 1--------------------------\\

        //program.Task_1_1(new double[] { 0, 1.5, 1, 3, -2.2, -0.5 });
        //program.Task_1_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_1_3(new double[] { -2.2, -0.5, 2, -1 }, new double[] { 0, 1.5, 4, 3 });
        //program.Task_1_4(new double[] { 0, 1.5, 1, 3, -2.2 });
        //program.Task_1_5(new double[] { 2, 1, 3, 3 }, new double[] { 0, 1.5, 4, 3 });
        //program.Task_1_6(new double[] { 1.5, 1, 3, -2.2, -0.5 });
        //program.Task_1_7(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_1_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5 });
        //program.Task_1_9(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
        //program.Task_1_10(new double[] { 2, 1, 3, 3, 5, 6, 3, 4, 5, 0 }, 3, 4);
        //program.Task_1_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, 2, 3.1, -0.7 });
        //program.Task_1_12(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
        //program.Task_1_13(new double[] { 2, 1, 3, 3, 5, 6, 0, 2, 7, 1 });
        //program.Task_1_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1, 2, 2.5, -1.4 });
        //program.Task_1_15(new double[] { 2, 1, 3, 3, 5, 6, 0, 1, 2, 3 });

        //--------------------------LEVEL 2--------------------------\\

        //program.Task_2_1(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_2(new double[] { 2, 1, 3, 3, 5, 6, 3, 4 });
        //program.Task_2_3(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        //program.Task_2_4(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        //program.Task_2_5(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 }, 2.3);
        //program.Task_2_7(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_9(new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 });
        //program.Task_2_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, 7.77);
        //program.Task_2_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_13(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_15(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 }, new double[] { 5, 2, 8, 1, 9, 10 }, 7);
        //program.Task_2_16(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_17(new double[] { 0, 1.5, 4, 3, -2.2, -0.5, 2, -3.1 });
        //program.Task_2_18(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_2_19(new double[] { -5, -2, -8, -1, -9, -3, -7, -4, -6, -2 });
        //program.Task_2_20(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });

        //--------------------------LEVEL 3--------------------------\\
        //program.Task_3_1(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_2(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_3(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_4(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_5(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_6(new double[] { 0, 1.5, 1, -1.3, -2.2, -0.5, 2 });
        //program.Task_3_7(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_8(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_3_10(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_11(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        program.Task_3_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 3 });
        //program.Task_3_13(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        //program.Task_3_14(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });

    }
    #region Level 1
    public double[] Task_1_1(double[] array)
    {
        // code here
        double S = 0;

        foreach(double x in array){
            S += x;
        }
        for(int i = 0; i < array.Length; i++){
            array[i] /= S;
            array[i] = Math.Round(array[i], 2);
            Console.WriteLine(array[i]);
        }

        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double S = 0, number = 0;
        foreach(double x in array){
            if(x > 0){
                number++;
                S += x;
            }
        }
        S = Math.Round(S/number, 2);
        for(int i = 0; i < array.Length; i++){
            if(array[i] > 0)
                array[i] = S;
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for(int i = 0; i < first.Length; i++){
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
    }

        for(int i = 0; i < first.Length; i++){
            Console.WriteLine($"Sum: {sum[i]}  Dif: {dif[i]}");
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double S = 0, num = 0;

        foreach(double x in array){
            S += x;
            num++;
        }
        S = Math.Round(S/num, 2);
        for(int i = 0; i < array.Length; i++){
            array[i] = Math.Round(array[i] - S, 2);
            Console.WriteLine(array[i]);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for(int i = 0; i < vector1.Length; i++){
            product += vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2); 
        Console.WriteLine(product);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        foreach (double x in vector){
            length += x*x;
        }
        length = Math.Sqrt(length);
        Console.WriteLine(Math.Round(length, 2));
        // end

        return Math.Round(length, 2); 
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double S = 0, num = 0;
        foreach (double x in array){
            S += x;
            num++;
        }
        S /= num;
        for(int i = 0; i < array.Length; i++){
            if (array[i] > S)
                array[i] = 0;
            Console.Write(array[i] + " ");
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        foreach(double x in array)
            if(x < 0)count++;
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double S = 0, num = 0;
        foreach (double x in array)
        {
            S += x;
            num++;
        }
        S /= num;

        foreach(double x in array)
            if(x > S) count++;
        Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q)
    {
        int count = 0;

        // code here
        foreach(double x in array)
            if(x > P && x < Q)count++;
        Console.WriteLine(count);
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int count = 0;
        foreach (double x in array)
            if (x > 0) count++;
        output = new double[count];

        for (int i = 0, j = 0; i < array.Length; i++)
            if (array[i] > 0){ output[j] = array[i]; j++;  }

        foreach (double x in output)
            Console.Write(x + " ");
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array)
    {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i < array.Length; i++){
            if(array[i] < 0) {  value = array[i]; index = i; }
        }

        Console.WriteLine(value + " " + index);
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array)
    {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length/2];

        // code here
        for (int i = 0, j = 0, m = 0; i < array.Length; i++){
            if(i%2 == 0) { even[j] = array[i]; j++; }
            else { odd[m] = array[i]; m++; }
        }
        for (int i = 0; i < even.Length; i++) {
            Console.Write(even[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < odd.Length; i++){
            Console.Write(odd[i] + " ");
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array)
    {
        double sum = 0;

        // code here
        foreach (double x in array) {
            if (x >= 0) sum += x * x;
            else break;
        };

        Console.WriteLine(sum);
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x)
    {
        double[] y = new double[x.Length];

        // code here
        for(int i = 0; i < x.Length; i++){
            if(x[i] <= 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
        }

        for (int i = 0; i < x.Length; i++){
            Console.WriteLine(x[i] + " " + y[i]);
        }
        // end

        return y;
    }
    #endregion
    #region Level 2
    public double[] Task_2_1(double[] array)
    {
        // code here
        int index = -1;
        double min = 999999;
        for(int i = 0; i < array.Length; i++){
            if(array[i] < min) { min = array[i]; index = i; }
        }
        array[index] *= 2;

        foreach(double x in array) Console.Write(x + " ");
        // end

        return array;
    }
    public double Task_2_2(double[] array)
    {
        double sum = 0;

        // code here
        int index = -1;
        double max = -999999;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max){ max = array[i]; index = i; }
        }
        for(int i = 0; i < index; i++) sum += array[i];

        Console.WriteLine(sum);
        // end

        return sum;
    }
    public double[] Task_2_3(double[] array)
    {
        // code here
        int index = -1;
        double min = 999999;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; index = i; }
        }
        for (int i = 0; i < index; i++) 
            if(array[i] > 0) array[i] *= 2;
            else array[i] /= 2;

        foreach(double x in array) Console.Write(x + " ");
        // end

        return array;
    }
    public double[] Task_2_4(double[] array)
    {
        // code here
        double sum = 0, max = -999999;
        int index = -1;

        for (int i = 0; i < array.Length; i++) { 
            sum += array[i];
            if (array[i] > max){ max = array[i]; index = i; }
        }
        sum = Math.Round(sum/array.Length, 2);
        for(int i = index+1; i < array.Length; i++) { 
            array[i] = sum;
        }

        foreach(double x in array) Console.Write(x + " ");
        // end

        return array;
    }
    public double[] Task_2_5(double[] array)
    {
        // code here
        int indexMax = -1, indexMin = -1, count = 0;
        double max = -999999, min = -max; 
        double[] numbers = new double[array.Length];
        numbers = array;

        for (int i = 0; i < array.Length; i++){
            if (array[i] > max) { max = array[i]; indexMax = i; }
            if (array[i] < min) { min = array[i]; indexMin = i; }
        }
        if(indexMax < indexMin) { array = new double[0]; return array; }
        for(int i = indexMin+1; i < indexMax; i++){
            if (array[i] < 0) count++;
        }
        array = new double[count];
        for (int i = indexMin+1, j = 0; i < indexMax; i++){
            if (numbers[i] < 0){ array[j] = numbers[i]; j++; }
        }
        foreach(double x in array) Console.Write(x + " ");
            // end

        return array;
    }
    public double[] Task_2_6(double[] array, double P)
    {
        // code here
        int index = -1;
        double min = 999999, sum = 0, count = 0;
        for(int i = 0; i < array.Length; i++){
            sum += array[i];
            count++;
        }
        sum /= count;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] - sum < min) min = array[i] - sum;
        }
        // end

        return array;
    }
    public double[] Task_2_7(double[] array)
    {
        // code here
        double max = -999999;
        int index = -1;
        for (int i = 0; i < array.Length; i++){
            if (array[i] > max) { max = array[i]; index = i; }
        }
        if (index+1 != array.Length)
            if (array[index+1] > 0)
                array[index+1] *= 2;
            else
                array[index+1] /= 2;

        foreach (double x in array)
            Console.Write(x + " ");
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
        int indexMax = -1, indexMin = -1, count = 0, swap = 0;
        double max = -999999, min = -max;

        for (int i = 0; i < array.Length; i++){
            if (array[i] > max) { max = array[i]; indexMax = i; }
            if (array[i] < min) { min = array[i]; indexMin = i; }
        }
        
        if (indexMax < indexMin) { swap = indexMax; indexMax = indexMin; indexMin = swap; };
        for (int i = indexMin+1; i < indexMax; i++){
            average += array[i];
            count++;
        }
        if (count == 0) return 0.0;
        average = Math.Round(average / count, 2);
        Console.Write(average);
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
        int index = -1;

        //ищем последний +элемент
        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0) index = i;

        //создаём новый массив для чисел с длинной + 1
        double[] numbers = new double[array.Length+1];

        //перекопируем элементы до последнего положительного включительно
        for(int i = 0; i <= index; i++)
            numbers[i] = array[i];

        //проверяем, существует ли этот положительный элемент
        if (index == -1){
            foreach (double x in array)
                Console.Write(x + " ");
            Console.WriteLine();
            return array;
        }

        //проверяем, является ли он последним, чтобы не вылететь за рамки копирования в последующем шаге
        if (index == array.Length){
            numbers[index + 1] = P;
            return numbers;
        }

        //вставляем элемент в нужное место
        numbers[index + 1] = P;

        //копируем оставщуюся часть
        for (int i = index+2; i < numbers.Length; i++)
            numbers[i] = array[i-1];

        array = new double[numbers.Length];
        array = numbers;

        foreach(double x in array)
            Console.Write(x + " ");
        Console.WriteLine();
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
        int index = -1;
        double max = -999999;
        for (int i = 0; i < array.Length; i++)
            if (i % 2 == 0 && max < array[i]) { max = array[i]; index = i; }

        if(max < 0){ array[0] = 0;  return array; }

        array[index] = index;
        foreach(double x in array)
            Console.Write(x + " ");
        Console.WriteLine();
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
        if (k > A.Length) return A;
        output = new double[A.Length + B.Length];
        for (int i = 0; i < k; i++){
            output[i] = A[i];
        }
        for(int i = k, j = 0; i < B.Length+k; i++, j++){
            output[i] = B[j];
        }
        for (int i = B.Length + k, j = k; i < B.Length + A.Length; i++, j++){
            output[i] = A[j];
        }

        foreach(double x in output)
            Console.Write(x + " ");
        Console.WriteLine();
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
        int indexMax = -1, indexMin = -1;
        double max = -999999, min = -max, count = 0, sum = 0;

        for (int i = 0; i < array.Length; i++){
            if (array[i] > max) { max = array[i]; indexMax = i; }
            if (array[i] < min) { min = array[i]; indexMin = i; }
        }
        if (indexMax < indexMin){
            for(int i = 0;i < array.Length;i++)
                if(array[i] > 0) { sum += array[i]; count++;  }
        }else{
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { sum += array[i]; count++; }
            if (count == 0) return 0.0;
        }

        average = Math.Round(sum / count, 2);
        Console.WriteLine(average);
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
        int indexMax = -1;
        double max = -999999, sum = 0;
        for(int i = 0; i < array.Length; i++) {
            if (array[i] > max) { max = array[i]; indexMax = i; }
            sum += array[i];
        }
        if (array[indexMax] > sum) array[indexMax] = 0;
        else array[indexMax] *= 2;
        // end
        foreach(double x in array)
            Console.Write(x + " ");
        Console.WriteLine();
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
        double max = -999999, swap = 0;
        int index = -1;

        for(int i = 0; i < array.Length; i++){
            if (array[i] > max) { max = array[i]; index = i; }
        }
        for(int i = 0; i < index; i+=2)
            if(i+1 != index) { swap = array[i]; array[i] = array[i+1]; array[i + 1] = swap; }
        foreach(double x in array)
            Console.Write(x + " ");
        Console.WriteLine();
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
        int[] countArr = new int[5];
        int max = 0;
        for (int i = 0, j = 0; i < array.Length - 1; i++)
            if (array[i] > array[i + 1]){
                count++;
            }
            else{
                countArr[j] = count + 1;
                count = 0;
                j++;
            }
        for (int i = 0; i < countArr.Length; i++)
            if (countArr[i] > max) max = countArr[i];
        count = max;
        Console.WriteLine(max);
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
        int[] countLowerArr = new int[5];
        int[] countUpperArr = new int[5];
        int max = 0;
        for (int i = 0, j = 0; i < array.Length-1; i++)
            if (array[i] > array[i + 1]){
                count++;
                if (array[i] > array[i + 1] && i == array.Length - 2) { countUpperArr[j] = count + 1; count = 0; j++; }
            }
            else{
                countLowerArr[j] = count + 1;
                count = 0;
                j++;
            }

        count = 0;

        for (int i = 0, j = 0; i < array.Length - 1; i++)
            if (array[i] < array[i + 1]) {
                count++;
                if(array[i] < array[i + 1] && i == array.Length - 2) {countUpperArr[j] = count + 1; count = 0; j++;}
            }else{
                countUpperArr[j] = count + 1;
                count = 0;
                j++;
            }
        Console.WriteLine($"-------{count}");
        foreach (int i in countLowerArr)
            if (i > max) max = i;
        foreach (int i in countUpperArr)
            if (i > max) max = i;

        count = max;
        foreach(int i in countUpperArr)
            Console.WriteLine(i);
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
        foreach (double x in array)
            if (x < 0) count++;

        double[] numbers = new double[array.Length - count];
        for (int i = 0, j = 0;i<array.Length; i++)
            if (array[i] >= 0) { numbers[j] = array[i]; j++; }

        array = new double[numbers.Length];
        array = numbers;

        foreach(double x in array)
            Console.Write(x + " ");
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
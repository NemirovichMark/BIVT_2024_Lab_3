using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program {
    public static void Main() {
        Program program = new Program();
        //program.Task_1_1(new int[] {1, 2, 3, 4, 5, 6});
        //program.Task_1_3(new double[] { -2.2, -0.5, 2, -1 }, new double[] { 0, 1.5, 4, 3 });
        //program.Task_1_12(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2, -1 });
        //program.Task_2_4(new double[] { 0, 1.5, -1, 3, -2.2, -0.5, 2 });
        //program.Task_2_6(new double[] { 0, 1.5, -1, -3, -2.2, -0.5, 6 },2.3);
        //program.Task_2_8(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        //program.Task_2_18(new double[] { 0, 1.5, 1, 3, -2.2, -0.5, 2 });
        program.Task_3_9(new double[] { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 });
        
    }
    #region Level 1
    public double[] Task_1_1(double[] array) {
        // code here
        double sum = 0;
        for (int i = 0; i < 6; i++) {
            sum = sum + array[i];
        }

        for (int i = 0; i < 6; i++) {
            array[i] = Math.Round(array[i] / sum, 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array) {
        // code here
        int n = 0;
        double sum = 0;
        for (int i = 0; i < 8; i++) {
            if (array[i] > 0) {
                n++;
                sum = sum + array[i];
            }
        }
        double sr = Math.Round(sum / n, 2);

        for (int i = 0; i < 8; i++) {
            if (array[i] > 0) {
                array[i] = sr;
            }
        }
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second) {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        for (int i = 0; i < first.Length; i++) {
            sum[i] = Math.Round(first[i] + second[i], 2);
            dif[i] = Math.Round(first[i] - second[i], 2);
        }

        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array) {
        // code here
        double sum = 0;
        for (int i = 0; i < 5; i++) {
            sum += array[i];
        }
        double sr = Math.Round(sum / array.Length, 2);
        for (int i = 0; i < 5; i++) {
            array[i] = Math.Round(array[i] - sr, 2);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2) {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++) {
            product = product + vector1[i] * vector2[i];
        }
        product = Math.Round(product, 2);
        // end

        return product;
    }
    public double Task_1_6(double[] vector) {
        double length = 0;

        // code here
        for (int i = 0; i < 5; i++) {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        // end

        return Math.Round(length, 2);
    }
    public double[] Task_1_7(double[] array) {
        // code here
        double sum = 0;
        for (int i = 0; i < 7; i++) {
            sum = sum + array[i];
        }
        double sr = Math.Round(sum / array.Length, 2);

        for (int i = 0; i < 7; i++) {
            if (array[i] > sr) {
                array[i] = 0;
            }
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array) {
        int count = 0;

        // code here
        int n = 0;
        for (int i = 0; i < 6; i++) {
            if (array[i] < 0) {
                n++;
            }
        }
        count = n;
        // end

        return count;
    }
    public int Task_1_9(double[] array) {
        int count = 0;

        // code here
        double sum = 0;
        for (int i = 0; i < 8; i++) {
            sum = sum + array[i];
        }
        double sr = Math.Round(sum / array.Length, 2);

        for (int i = 0; i < 8; i++) {
            if (array[i] > sr) {
                count++;
            }
        }
        // end

        return count;
    }
    public int Task_1_10(double[] array, int P, int Q) {
        int count = 0;

        // code here
        for (int i = P + 1; i < Q; i++) {
            if (array[i] > 0) {
                count++;
            }
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array) {
        double[] output = null;

        // code here
        int n = 0;
        for (int i = 0; i < 10; i++) {
            if (array[i] > 0) {
                n++;
            }
        }
        output = new double[n];
        int r = 0;
        for (int i = 0; i < 10; i++) {
             if (array[i] > 0) {
                    output[r] = array[i];
                    r++;
                }
            
        }
        // end

        return output;
    }
    public (double, int) Task_1_12(double[] array) {
        double value = 0;
        int index = -1;

        // code here
        for (int i = 0; i < 8; i++) {
            if (array[i] < 0) {
                value = array[i];
                index = i;
            }
        }
        // end

        return (value, index);
    }
    public (double[], double[]) Task_1_13(double[] array) {
        double[] even = new double[array.Length / 2];
        double[] odd = new double[array.Length / 2];

        // code here
        int f = 0;
        int s = 0;
        for (int i = 0; i < 10; i++) {
            if (i%2 == 0) {
                even[f] = array[i];
                f ++;
            }
            else {
                odd[s] = array[i];
                s ++;
            }
        }
        // end

        return (even, odd);
    }
    public double Task_1_14(double[] array) {
        double sum = 0;

        // code here
        for (int i = 0; i < 11; i++) {
            if (array[i] < 0) {
                break;
            }
            else {
                sum = sum + array[i] * array[i];
            }
        }
        // end

        return sum;
    }
    public double[] Task_1_15(double[] x) {
        double[] y = new double[x.Length];

        // code here
        for (int i = 0; i < 10; i++) {
            if (x[i] == 0) {
                y[i] = double.NaN;
            }
            else {
                y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            }
        }
        for (int i = 0; i < 10; i++) {
            Console.WriteLine(x[i] + "   " + y[i]);
        }
        // end

        return y;
    }
    #endregion

    #region Level 2
    public double[] Task_2_1(double[] array) {
        // code here
        double min = double.MaxValue;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                n = i;
            }
        }
        array[n] = array[n] * 2;
        // end

        return array;
    }
    public double Task_2_2(double[] array) {
        double sum = 0;

        // code here
        double max = double.MinValue;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
                n = i;
            }
        }
        for (int i = 0; i < n; i++) {
            sum = sum + array[i];
        }

        // end

        return sum;
    }
    public double[] Task_2_3(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_2_4(double[] array) {
        // code here
        double max = double.MinValue;
        int n = 0;
        double sum = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
                n = i;
            }
            sum = sum + array[i];
            
        }
        double sr = Math.Round(sum/(array.Length),2);
        for (int i = n+1; i < array.Length; i++) {
            array[i] = sr;
        }

        // end

        return array;
    }
    public double[] Task_2_5(double[] array) {
        // code here

        // end

        return array;
    }
    //{ 5, 2, -8, 1, 9, 3, 7, 4, 6 },2.3
    public double[] Task_2_6(double[] array, double P) {
        // code here
        double sum = 0;
        for (int i = 0; i < array.Length; i++) {
            sum = array[i] + sum;
        }
        double sr = Math.Round(sum/array.Length,2);
        double min = double.MaxValue;
        double sr_el = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (Math.Abs(sr - array[i]) < min) {
                min = Math.Abs(sr - array[i]);
                sr_el = array[i];
                n = i;
            }
        }
        double[] a = new double[array.Length+1];
        for (int i = 0; i <= n; i++) {
            a[i] = array[i];
        }
        a[n+1] = P;
        for (int i = n+2; i < a.Length; i++) {
            a[i] = array[i-1];
        }
        // end

        return a;
    }
    public double[] Task_2_7(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_2_8(double[] array) {
        // code here
        double max = double.MinValue;
        int max_n = 0;
        double min = double.MaxValue;
        int min_n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
                max_n = i;
            }
        }
        for (int i = max_n+1; i < array.Length; i++) {
            if (array[i] < min) {
                min = array[i];
                min_n = i;
            }
        }
        if (min_n != 0) {
            array[max_n] = min;
            array[min_n] = max;
        }

        // end

        return array;
    }
    public double Task_2_9(double[] array) {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_10(double[] array) {
        // code here
        double min = double.MaxValue;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < min && array[i] > 0) {
                min = array[i];
                n = i;
            }
        }
        double[] a = new double[array.Length - 1];
        for (int i = 0; i < n; i++) {
            a[i] = array[i];
        }
        for (int i = n; i < a.Length; i++) {
            a[i] = array[i+1];
        }
        // end
        if (min == double.MaxValue) {
            return array;
        }
        else {
            return a;
        }
    }
    public double[] Task_2_11(double[] array, double P) {
        // code here

        // end

        return array;
    }
    public double[] Task_2_12(double[] array) {
        // code here
        double max = double.MinValue;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (max < array[i]) {
                max = array[i];
                n = i;
            }
        }
        int n_1 = -1;
        for (int i = 0; i < array.Length; i++) { 
            if (array[i] < 0) {
                n_1 = i;
                break;
            }
        }
        double sum = 0;
        for (int i = n + 1; i < array.Length; i++) {
            sum = sum + array[i];
        }
        if (n_1 != -1) {
            array[n_1] = Math.Round(sum,2);
        }
        // end

        return array;
    }
    public double[] Task_2_13(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_2_14(double[] array) {
        // code here
        double max = double.MinValue;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            if (max < array[i]) {
                max = array[i];
                n = i;
            }
        }
        double min = 0;
        int n_1 = -1;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                n_1 = i;
                min = array[i];
                break;
            }
        }
        if (n_1 != -1) {
            array[n_1] = max;
            array[n] = min;
        }
        // end

        return array;
    }
    public double[] Task_2_15(double[] A, double[] B, int k) {
        double[] output = null;

        // code here

        // end

        return output;
    }
    public int[] Task_2_16(double[] array) {
        int[] output = null;

        // code here
        double sum = 0;
        int n = 0;
        for (int i = 0; i < array.Length; i++) {
            sum = sum + array[i];
        }
        double sr = Math.Round(sum/array.Length,2);
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < sr) {
                n++;
            }
        }
        int b = 0;
        int[] a = new int[n];
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < sr) {
                a[b] = i;
                b++;
            }
        }
        // end

        return a;
    }
    public double Task_2_17(double[] array) {
        double average = 0;

        // code here

        // end

        return average;
    }
    public double[] Task_2_18(double[] array) {
        // code here
        double mx_r = double.MinValue;
        double mx_l = double.MinValue;
        for (int i = 0; i < array.Length; i = i + 2) {
            if (mx_r < array[i]) {
                mx_r = array[i];
            }
        }
        for (int i = 1; i < array.Length; i = i + 2) {
            if (mx_l < array[i]) {
                mx_l = array[i];
            }
        }
        int v = Convert.ToInt32(Math.Round((double)array.Length / 2));
        if (mx_r > mx_l) {
            for (int i = 0; i < Math.Round( (double)array.Length/2); i++) {
                array[i] = 0;
            }
        }       
        else {
            for (int i = Convert.ToInt32(array.Length / 2); i < array.Length ; i++) {
                array[i] = 0;
            }
        }

        // end

        return array;
    }
    public double[] Task_2_19(double[] array) {
        // code here

        // end

        return array;
    }
    public double Task_2_20(double[] array) {
        double sum = 0;

        // code here
        double min = double.MaxValue;
        int n = 0;
        int n_1 = 0;
        for (int i = 0; i < array.Length; i++) {
            if (min > array[i]) {
                min = array[i];
                n = i;
            }
        }
        for (int i = 0; i < array.Length; i++) {
            if (array[i] < 0) {
                n_1 = i;
                break;
            }
        }
        if (n > n_1) {
            for (int i = 0; i < array.Length; i = i + 2) {
                sum += array[i];
            }
        }
        else {
            for (int i = 1; i < array.Length; i = i + 2) {
                sum += array[i];
            }
        }
        // end

        return sum;
    }
    #endregion
    #region Level 3
    public int[] Task_3_1(double[] array) {
        int[] output = null;

        // code here

        // end

        return output;
    }
    public double[] Task_3_2(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_3_3(double[] array) {
        // code here
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] > max) {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i += 2) {
            if (array[i+1] == max || array[i] == max) {
                break;
            }
            double x = array[i];
            array[i] = array[i + 1];
            array[i+1] = x;
        }
            // end

            return array;
    }
    public double[] Task_3_4(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_3_5(double[] array) {
        // code here

        // end

        return array;
    }
    public int Task_3_6(double[] array) {
        int count = 0;

        // code here       
        int Maxc = 0;
        double cur = Double.MaxValue;
        for (int i = 0; i < array.Length; i++) {
            if (cur > array[i]) {
                count += 1;
                cur = array[i];
            }
            else {
                if (count > Maxc) {
                    Maxc = count;
                }
                count = 1;
                cur = array[i];
            }
        }
        count = Maxc;
        // end

        return count;
    }
    public double[] Task_3_7(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_3_8(double[] array) {
        // code here

        // end

        return array;
    }
    public int Task_3_9(double[] array) {
        int count = 0;

        // code here
        int Maxc = 0;
        double cur = Double.MaxValue;
        for (int i = 0; i < array.Length; i++) {
            if (cur > array[i]) {
                count += 1;
                cur = array[i];
            }
            else {
                if (count > Maxc) {
                    Maxc = count;
                }
                count = 1;
                cur = array[i];
            }
        }
        if (count > Maxc) {
            Maxc = count;
        }

        count = 0;
        int Minc = 0;
        cur = Double.MinValue;
        for (int i = 0; i < array.Length; i++) {
            if (cur < array[i]) {
                count += 1;
                cur = array[i];
            }
            else {
                if (count > Minc) {
                    Minc = count;
                }
                count = 1;
                cur = array[i];
            }
        }
        if (count > Minc) {
            Minc = count;
        }

        if (Maxc > Minc) {
            count = Maxc;
        }
        else {
            count = Minc;
        }
        // end

        return count;
    }
    public double[] Task_3_10(double[] array) {
        // code here

        // end

        return array;
    }
    public (double[], double[], double, double) Task_3_11(double a, double b, int n) {
        double[] X = null, Y = null;
        double globalMax = 0, globalMin = 0;

        // code here

        // end

        return (X, Y, globalMax, globalMin);
    }
    public double[] Task_3_12(double[] array) {
        // code here
        int c = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] >= 0) {
                c += 1;
            }
        }
        double[] a = new double[c];
        int j = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] >= 0) {
                a[j] = array[i];
                j++;
            }
        }
        // end

        array = a;
        return array;
    }
    public double[] Task_3_13(double[] array) {
        // code here

        // end

        return array;
    }
    public double[] Task_3_14(double[] array) {
        double[] normalizedArray = null;

        // code here

        // end

        return normalizedArray;
    }
    #endregion
}
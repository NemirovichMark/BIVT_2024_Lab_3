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
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] /= summ;
            array[i] = Math.Round(array[i], 2);
        }
        // end

        return array;
    }
    public double[] Task_1_2(double[] array)
    {
        // code here
        double summ = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)  // сумма +
            {
                summ += array[i];
                m += 1;
            }
        }
        double sr = summ / m; //среднее среди +
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                array[i] = sr;
                array[i] = Math.Round(array[i], 2);
            }
            //Console.Write("{0}  ", array[i]);
        }
        //Console.WriteLine(sr);
        // end

        return array;
    }
    public (double[], double[]) Task_1_3(double[] first, double[] second)
    {
        double[] sum = new double[first.Length], dif = new double[first.Length];

        // code here
        //Console.Write("Сумма: ");
        for (int i = 0; i < 4; i++)
        {
            sum[i] = first[i] + second[i];
            sum[i] = Math.Round(sum[i], 2);
            Console.Write("{0}  ", sum[i]);
        }
        //Console.WriteLine("Разность: ");
        for (int i = 0; i < 4; i++)
        {
            dif[i] = first[i] - second[i];
            dif[i] = Math.Round(dif[i], 2);
            Console.Write("{0}  ", dif[i]);
        }
        // end

        return (sum, dif);
    }
    public double[] Task_1_4(double[] array)
    {
        // code here
        double summ = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
            m += 1;
        }
        double sr = summ / m; //среднее знач
        for (int i = 0; i < array.Length; i++)
        {
            array[i] -= sr;
            array[i] = Math.Round(array[i], 2);
            //Console.Write("{0}  ", array[i]);
        }
        // end

        return array;
    }
    public double Task_1_5(double[] vector1, double[] vector2)
    {
        double product = 0;

        // code here
        for (int i = 0; i < 4; i++)
        {
            product += vector1[i] * vector2[i];
        }
        //Console.Write(product);
        // end

        return product;
    }
    public double Task_1_6(double[] vector)
    {
        double length = 0;

        // code here
        for (int i = 0; i < vector.Length; i++)
        {
            length += vector[i] * vector[i];
        }
        length = Math.Sqrt(length);
        //Console.Write(length);
        // end

        return Math.Round(length, 4); ;
    }
    public double[] Task_1_7(double[] array)
    {
        // code here
        double summ = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
            m += 1;
        }
        double sr = summ / m; //среднее знач
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                array[i] = 0;
            }
            //Console.Write("{0}  ", array[i]);
        }
        // end

        return array;
    }
    public int Task_1_8(double[] array)
    {
        int count = 0;

        // code here
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)  // сумма -
            {
                summ += array[i];
                count += 1;
            }
        }
        //Console.WriteLine(count);
        // end

        return count;
    }
    public int Task_1_9(double[] array)
    {
        int count = 0;

        // code here
        double summ = 0;
        int m = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
            m += 1;
        }
        double sr = summ / m; //среднее знач
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > sr)
            {
                count++;
            }
            //Console.Write(count);
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
            //Console.Write(count);
        }
        // end

        return count;
    }
    public double[] Task_1_11(double[] array)
    {
        double[] output = null;

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) n++;
        }
        output = new double[n];
        n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) output[n++] = array[i];
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

        // code here
        int n = 0;
        for (int i = 0; i < array.Length; i += 2)
        {
            even[n] = array[i];
            n++;
        }
        n = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            odd[n] = array[i];
            n++;
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
            if (x[i] == 0) y[i] = double.NaN;
            else y[i] = Math.Round(0.5 * Math.Log(x[i]), 2);
            y[i] = Math.Round(y[i], 2);
        }
        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"{x[i]: F2}\\t {y[i]:F2}");
        }
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
        int imax = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax]) imax = i; //max index
        }
        for (int i = 0; i < imax; i++)
        {
            sum += array[i];
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
        int imax = 0;
        double sr = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[imax]) imax = i; //max index
            sr += array[i] / array.Length;
        }
        for (int i = imax + 1; i < array.Length; i++)
        {
            array[i] = Math.Round(sr, 2);
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
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            summ += array[i];
        }
        double sr = summ / array.Length; //среднее знач
        int k = -1;
        double min = 100;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - sr) < min)
            {
                min = Math.Abs(array[i] - sr);
                k = i;
            }
        }
        double[] b = new double[array.Length + 1]; //новый массив с эллементом р
        for (int i = 0; i <= k; i++)
        {
            b[i] = array[i];
        }
        b[k + 1] = P;
        for (int i = k + 1; i < array.Length; i++)
        {
            b[i + 1] = array[i];
        }
        array = b;
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
        double amax = -100, amin = 100;
        int imax = 0, imin = 0;
        for (int i = 0; i < array.Length; i++) //ищем максимальное
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = imax + 1; i < array.Length; i++) //ищем минимальное после макс.
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (imax > imin)
        {
            return array;
        }
        else
        {
            double t = array[imax]; //меняем местами
            array[imax] = array[imin];
            array[imin] = t;
        }
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
        double amin = 100;
        int imin = -1;
        for (int i = 0; i < array.Length; i++) //ищем минимальное
        {
            if (array[i] < amin && array[i] > 0)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (imin != -1) //если минимальное нашлось
        {
            double[] b_array = new double[array.Length - 1]; //создаем new массив меньше
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != imin) b_array[j++] = array[i]; //добавляем все элементы в new массив кроме минимального
            }
            array = b_array;
        }//если imin == -1 то возвращаем array
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
        double amax = -100, summ = 0;
        int imax = 0;
        for (int i = 0; i < array.Length; i++) //ищем максимальное
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = imax + 1; i < array.Length; i++) //сумма после максимального
        {
            summ += array[i];
        }
        summ = Math.Round(summ, 2);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) //ищем 1 отрицательное
            {
                array[i] = summ;
                break;
            }
        }
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
        double amax = -100, aneg = 0, t;
        int imax = 0, ineg = 0;
        for (int i = 0; i < array.Length; i++) //ищем максимальное
        {
            if (array[i] > amax)
            {
                amax = array[i];
                imax = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) //первое отрицательное
            {
                aneg = array[i];
                ineg = i;
                break;
            }
        }
        if (aneg == 0 || amax == -100)
            return array;
        t = array[ineg]; array[ineg] = array[imax]; array[imax] = t;
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
        double summ = 0, sr = 0;
        int k = 0, m = 0, j = 0;
        for (int i = 0; i < array.Length; i++) //сумма
        {
            summ += array[i];
            m++;
        }
        sr = Math.Round(summ / m, 2); //среднее значение
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr) k++;
        }
        output = new int[k];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < sr)
            {
                output[j] = i;
                j++;
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
        double ch = -100, nech = 0;
        int ich = 0, inech = 0;
        for (int i = 0; i < array.Length; i += 2) //ищем максимальное четное
        {
            if (array[i] > ch)
            {
                ch = array[i];
                ich = i;
            }
        }
        for (int i = 1; i < array.Length; i += 2) //ищем максимальное нечетное
        {
            if (array[i] > nech)
            {
                nech = array[i];
                inech = i;
            }
        }
        int j = array.Length / 2;
        if (ch > nech)
        {
            for (int i = 0; i < j; i++) array[i] = 0;
        }
        if (ch < nech)
        {
            for (; j < array.Length; j++) array[j] = 0;
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
        double amin = 0, aneg = 0;
        int imin = 0, ineg = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) //первое отрицательное
            {
                aneg = array[i];
                ineg = i;
                break;
            }
        }
        for (int i = 0; i < array.Length; i++) //ищем минимальное
        {
            if (array[i] < amin)
            {
                amin = array[i];
                imin = i;
            }
        }
        if (ineg < imin)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) sum += array[i]; //четное
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) sum += array[i]; //нечетное
            }
        }
        if (ineg == 0) return sum;
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
        double amax = -1000;
        int j = 1;
        for (int i = 0; i < array.Length; i++) //ищем максимальное
        {
            if (array[i] > amax) amax = array[i];
        }
        for (int i = 0; i < array.Length; i++) //заменяем максимальное
        {
            if (array[i] == amax)
            {
                array[i] += j;
                j++;
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
        for (int i = 2; i < array.Length; i += 2) // вставками
        {
            double key = array[i]; int j = i - 2;
            while (j >= 0 && array[j] > key)
            {
                array[j + 2] = array[j];
                j -= 2;
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
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < 0)
            {
                double amax = array[i];
                int imax = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > amax && array[j] < 0)
                    {
                        amax = array[j];
                        imax = j;
                    }
                }
                array[imax] = array[i];
                array[i] = amax;
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
        X = new double[n];
        Y = new double[n];
        double amax = -100, amin = 100;
        double p = (b - a) / (n - 1); //тк включительно а и б
        for (int i = 0; i < X.Length; i++) //заполняем массивы с округлением
        {
            X[i] = a + i * p; 
            X[i] = Math.Round(X[i], 3);
            Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            Y[i] = Math.Round(Y[i], 3);
        }
        for (int i = 0; i < Y.Length; i++) //ищем глобальные экстремумы
        {
            if (Y[i] > amax) amax = Y[i];
            if (Y[i] < amin) amin = Y[i];
        }
        globalMax = amax;
        globalMin = amin;
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
        normalizedArray = new double[array.Length];
        double amax = -100, amin = 100;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > amax) amax = array[i];
            if (array[i] < amin) amin = array[i];
        }
        for (int i = 0; i < array.Length; i++)
        {
            normalizedArray[i] = 2 * (array[i] - amin) / (amax - amin) - 1;
            normalizedArray[i] = Math.Round(normalizedArray[i], 2);
        }
        // end

        return normalizedArray;
    }
    #endregion
}
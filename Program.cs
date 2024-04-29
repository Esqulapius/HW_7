// // Задача 1: Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа в промежутке 
// // от M до N. Использовать рекурсию, не использовать циклы.

// void FromMtoN(int m, int n)
// {
//     if (m > n)
//     {
//         FromMtoN(m - 1, n);
//         System.Console.Write(m + " ");
//     }
//     else if (n > m)
//     {
//         FromMtoN(m, n - 1);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }
// FromMtoN(1, 5);





// // Задача 2: Напишите программу вычисления функции 
// // Аккермана с помощью рекурсии. Даны два неотрицательных 
// // числа m и n.

// static int Ackermann(int n, int m)
// {
//     if (n == 0)
//     {
//         Console.WriteLine($"если n == 0 - {n}, {m}");
//         return m+=1;
//     }
//     else if (m == 0)
//     {
//         Console.WriteLine($"если m == 0 - {n}, {m}");
//         return Ackermann(n - 1, 1);
//     }
//     else
//     {
//         Console.WriteLine($"иначе - {n}, {m}");
//         return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }

// System.Console.WriteLine(Ackermann(2,2));






// Задача 3: Задайте произвольный массив. Выведете его 
// элементы, начиная с конца. Использовать рекурсию, 
// не использовать циклы.


int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];
int i = 0;
void ReverseArray(int[] array, int i)
{
    System.Console.Write(array[array.Length - i - 1] + " ");
    i++;
    if (i != array.Length)
    {
        ReverseArray(array, i);
    }
}
ReverseArray(array, i);
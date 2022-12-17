public class MyMethodArray
{
    /// <summary>
    /// Метод инициализации одномерного массива типа int.
    /// </summary>
    /// <param name="number">Количество элементов массива.</param>
    /// <returns>Одномерный массив типа int.</returns>
    public static int[] CreatyArray(int number)
    {
        return new int[number];
    }
    /// <summary>
    /// Метод заполнения массива типа int случайными целыми числами.
    /// </summary>
    /// <param name="arry">Одномерный массив типа int.</param>
    /// <param name="min">Нижняя граница диапазона значений целых случайных чисел.</param>
    /// <param name="max">Верхняя граница диапазона значений целых случайных чисел.</param>
    public static void FillArray(int[] arry, int min, int max)
    {
        for (int i = 0; i < arry.Length; i++)
        {
            arry[i] = Random.Shared.Next(min, max + 1);
        }
    }
    /// <summary>
    /// Метод заполнения одномерного массива типа int с помощью ввода значений в консоль.
    /// </summary>
    /// <param name="arry">Одномерный массив типа int.</param>
    public static void UserFill(int[] arry)
    {
        int count = 0;
        while (count < arry.Length)
        {
            Console.WriteLine($"Введите значение для элемента под номером {count}:");
            arry[count] = int.Parse(Console.ReadLine());
            count++;
        }
    }
    /// <summary>
    /// Метод записи одномерного массива типа int в переменную типа string.
    /// </summary>
    /// <param name="arry">Одномерный массив типа int.</param>
    /// <returns>Переменная типа string.</returns>
    public static string Print(int[] arry)
    {
        string Print = String.Join(" , ", arry);
        Console.Write("Массив: ");
        return $"[{Print}]";
    }
    /// <summary>
    /// Метод подсчета натуральных чисел в одномерном массиве типа int.
    /// </summary>
    /// <param name="arry">Одномерный массив типа int.</param>
    /// <returns>Переменная типа string.</returns>
    public static string dictionary(int[] arry)
    {
        int count = 1; // мы пропускаем первый элемент, и т.к. как он у нас есть в массиве значит его значение в таблице 1шт.
        string s = String.Empty;
        int j = 1;// номер второго элемента. arry [0] сравниваем с arry [1].
        int a = 2;// переменная нужна для того, чтобы после каждого прохода по j, мы начили проход не с j = 1 а с следующего элемента.
        // Пример: {1,2,3,4,5,6,6,7,8}
        //          0 1 2 3 4 5 6 7 8
        //            j
        //              a
        //в конце цикла for мы в переменную j записываем значение переменной a, а к переменной a прибавляем единицу. 
        //         {1,2,3,4,5,6,6,7,8}
        //          0 1 2 3 4 5 6 7 8
        //              j
        //                a       
        // и т.д шагаем по массиву
        for (int i = 0; i < arry.Length; i++)
        {
            while (j < arry.Length)
            {
                if (arry[i] != -1)
                {
                    if (arry[j] == arry[i])
                    {
                        arry[j] = -1;
                        count++;
                    }
                }
                j++;
            }
            if (arry[i] != -1)
            {
                s += $"{arry[i]} --> {count} шт. \n";
            }
            count = 1;
            j = a;
            a++;
        }
        return s;
    }
}
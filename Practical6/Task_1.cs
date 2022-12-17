public class Task_1
{
    /// <summary>
    /// Подсчет одинаковых чисел в массиве.
    /// </summary>
    public static void Task01()
    {
        Console.WriteLine("Введите количество элементов в массиве: ");
        int number = int.Parse(Console.ReadLine());
        int[] arry = MyMethodArray.CreatyArray(number);
        while (true)
        {
            Console.WriteLine("Введите 1, если хотите заполнить массив вручную или введите 0, если хотите заполнить массив случайными числами: ");
            int number1 = int.Parse(Console.ReadLine());
            if (number1 == 1)
            {
                MyMethodArray.UserFill(arry);
                break;
            }
            else if (number1 == 0)
            {
                MyMethodArray.FillArray(arry, 0, 10);
                break;
            }
            else Console.WriteLine("ОШИБКА!!!");
        }
        Console.WriteLine(MyMethodArray.Print(arry));
        string s = MyMethodArray.dictionary(arry);
        Console.WriteLine(s);
    }
}
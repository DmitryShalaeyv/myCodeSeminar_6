/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

void Task_41()
{
    Console.Write("Введите через пробел целые числа -> ");
    string str = Console.ReadLine();

    string[] StringToArray(string str)
    {
        string[] result = str.Split(' ');
        return result;
    }

    int[] StringArrayToIntArray(string[] str)
    {
        int[] result = new int[str.Length];
        for (int i = 0; i < result.Length; i++) result[i] = int.Parse(str[i]);
        return result;
    }

    int[] StringToIntArray(string str)
    {
        string[] input_str = StringToArray(str);
        return StringArrayToIntArray(input_str);
    }

    uint Count(int[] array)
    {
        uint count = 0;
        for (int i = 0; i < array.Length; i++) if (array[i] > 0) count++;
        return count;
    }

    uint countOfPositive = Count(StringToIntArray(str));
    Console.Write($"Количество положительных чисел -> {countOfPositive}");
}

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

void Task_43()
{
    Console.Write("Введите через пробел коэффициенты первой прямой: k1 и b1 -> ");
    string strOne = Console.ReadLine();
    

    Console.Write("Введите через пробел коэффициенты второй прямой: k2 и b2 -> ");
    string strTwo = Console.ReadLine();
    

    string[] StringToArray(string str)
    {
        string[] result = str.Replace('.', ',').Split(' ');
        return result;
    }

    double[] StringArrayToIntArray(string[] str)
    {
        double[] result = new double[str.Length];
        for (int i = 0; i < result.Length; i++) result[i] = double.Parse(str[i]);
        return result;
    }

    double[] StringToIntArray(string str)
    {
        string[] input_str = StringToArray(str);
        return StringArrayToIntArray(input_str);
    }

    (double x, double y, string msg) intersectionPoint(double[] y1, double[] y2)
    {
        string msg = "";
        if (y1[0] - y2[0] == 0.0)
        {
            msg = "Нет точек пересечения";
            double x0 = 0;
            double y0 = 0;
            return (x0, y0, msg);
        }
        double x = (y2[1] - y1[1]) / (y1[0] - y2[0]);
        double y = y1[0] * x + y1[1];
        return (x, y, msg);
    }

    double[] y1 = StringToIntArray(strOne);
    double[] y2 = StringToIntArray(strTwo);

    var point = intersectionPoint(y1, y2);

    Console.WriteLine($"Точка пересечения прямых : {point.msg} {point.x}, {point.y}");
}

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);
if(num == 41)
{
    Task_41();
    return;
} 
if(num == 43)
{
    Task_43();
    return;
} 
else Console.WriteLine("Неверный номер задачи");


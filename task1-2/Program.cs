#nullable disable


Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Задание 1 (введите 1)");
        System.Console.WriteLine("Задание 2 (введите 2)");
        System.Console.WriteLine("End (если введено - 0)");
        int numTask = Convert.ToInt32(Console.ReadLine());

        switch (numTask)
        {
            case 0: return; 
            case 1: CountingNumbers(); break;
            case 2: IntersectionLines(); break;
            default: System.Console.WriteLine("Ошибка ввода"); break;
        }
    }
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountingNumbers()
{
   Console.Clear();
   Console.Write("Введите элементы массива через пробел: ");
   string str = Console.ReadLine();
   int[] mArray = GetArrayFromString(str);
   System.Console.WriteLine("массив: ");
   System.Console.WriteLine(string.Join(" ", mArray));
   
   int[] GetArrayFromString(string stringArray)
   {    
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    
    int[] res = new int[nums.Length];
    
    int sum = 0;
    for(int i=0; i<nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
         
        if (res[i] > 0)
        {
            sum++;
        }
    }
        Console.WriteLine();
        Console.WriteLine($"количество значений больше 0 в массиве = {sum}");
      return res;
     }       
}
// End

// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionLines()
{
    Console.Clear();
    Console.WriteLine("введите значение b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k1");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число k2");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 != k2){
        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"точка пересечения прямых X: {x}, Y: {y}");
    }
    else 
    {
       Console.WriteLine("две прямые не пересекаются"); 
    } 
}
       
// End
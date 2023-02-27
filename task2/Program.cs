/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/



int[] fromIntToArray(int num)
{
    int[] array = new int[num.ToString().Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num % 10;
        num /= 10;
    }
    Array.Reverse(array);
    return array;
}


void print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        else Console.Write(", ");
        Console.Write(array[i]);
        if (i == array.Length - 1) Console.Write("]");
    }
}

bool thirdNumExist(int[] array)
{
   if(array.Length >= 3)return true;
   else return false;
}
int thirdNumbGetter(int[] array)
{
    return array[2];
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int[] array = fromIntToArray(num);

if(thirdNumExist(array)) 
{

    Console.Write("Третье число есть! ");
    Console.WriteLine($"->{thirdNumbGetter(array)}");

}
else Console.WriteLine("Третьего числа нет!");





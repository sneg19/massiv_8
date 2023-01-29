/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*
1. Задать массив из 8 элементов
2. Вывод массива
*/

int[] get_array(int size, int min_value, int max_value)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min_value, max_value + 1);
    }
    return res;
}

void print_array()
{
    int[] our_array = get_array(8, 1, 99);
    Console.WriteLine(string.Join (",", our_array));
}

print_array();

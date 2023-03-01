Console.Clear();
link1:
Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

int FindRaznica(int[] mass)
{
    int min = mass[0];
    int max = 0;
    int r = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        if (min > mass[i])
        {
            min = mass[i];
        }
        else
        {
            if (max < mass[i]) max = mass[i];
        }
    }
    return r = max - min;
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];

    for(int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
if (baseArray.Length >= 2)
{
    Console.WriteLine(FindRaznica(baseArray));
}
else
{
    Console.WriteLine("Вы ввели слишком короткий массив - повторите");
    goto link1;
}
Console.Clear();
Console.WriteLine("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

int FindRaznica(int[] mass)
{
    int min = 0;
    int max = 0;
    foreach (var item in mass)
    {
        if (min > item) min = mass[i];
        if (max < item) max = mass[i];
    }
    return false;
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
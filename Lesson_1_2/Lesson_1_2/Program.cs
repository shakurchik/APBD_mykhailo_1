// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("So the second project per day !");
Console.WriteLine("So the  ");
Console.WriteLine("second ");
Console.WriteLine("project per day !");

static double GetAverage(int[] nums)
{
    double sum = 0.0;
    foreach (var n in nums)
    {
        sum += n;
    }
    return sum / nums.Length;
}

int[] nums={1,2,4,5,6,7};
double avg=GetAverage(nums);
Console.WriteLine(avg);
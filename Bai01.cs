/*
 Bài 1: Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng
 */
class Bai01
{
    public void TimTongCacSoChan(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        Console.WriteLine($"Tổng các số chẵn trong mảng là: {sum} ");
    }
}
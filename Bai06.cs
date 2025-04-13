//Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
class Bai06
{
    public void SapXepMang()
    {
        Console.WriteLine("Nhập vào n: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("N không hợp lệ, vui lòng nhập lại n: ");
            n = int.Parse(Console.ReadLine());
        }
        //Nhập các phần tử của mảng
        double[] Arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            Arr[i] = double.Parse(Console.ReadLine());
        }
        //Sắp xếp mảng
        Array.Sort(Arr);
        //Hiển thi kết quả
        Console.WriteLine("Mảng sau khi sắp xếp theo chiều tăng dần:");
        foreach (double num in Arr)
        {
            Console.Write(num + " ");
        }
    }
}
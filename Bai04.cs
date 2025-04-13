class Bai04
{
    //Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
    public void TimSoLonThuHai()
    {
        Console.WriteLine("Nhập vào n: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("N không hợp lệ, vui lòng nhập lại n: ");
            n = int.Parse(Console.ReadLine());
        }
        //Nhập các phần tử của mảng
        int[] Arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            Arr[i] = int.Parse(Console.ReadLine());
        }
        //Sắp xếp mảng
        Array.Sort(Arr);
        //Hiển thi kết quả
        Console.WriteLine($"Số lớn thứ hai trong mảng là: {Arr[n - 2]}");
    }
}
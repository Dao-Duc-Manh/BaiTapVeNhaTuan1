//Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập
//từ bàn phím.
class Bai03
{    public void KiemTraSoAmHayDuong()
    {
        Console.WriteLine("Nhập vào n:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("N không hợp lệ, vui lòng nhập lại n:");
            n = int.Parse(Console.ReadLine());  
        }
        //Nhập các phần tử của mảng
        int[] Arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            Arr[i] = int.Parse(Console.ReadLine());
        }
        //Đếm số lượng số âm và số dương
        int countPositive = 0;
        int countNegative = 0;
        for (int i = 0; i < n; i++)
        {
            if (Arr[i] > 0)
            {
                countPositive++;
            }
            else if (Arr[i] < 0)
            {
                countNegative++;
            }
        }
        //Hiển thi kết quả
        Console.WriteLine($"Số lượng số dương trong mảng: {countPositive}");
        Console.WriteLine($"Số lượng số âm trong mảng: {countNegative}");
    }}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tính tổng và tích của hai số nhập từ bàn phím
class Lesson5()
{
    public void TinhTongVaTich()
    {
        int so1, so2, tong, tich;
        Console.WriteLine("Nhập số thứ nhất: ");
        so1 = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Nhập số thứ hai: ");
        so2 = int.Parse(Console.ReadLine() ?? "0");
        tong = so1 + so2;
        tich = so1 * so2;
        Console.WriteLine($"Tổng là: {tong}");
        Console.WriteLine($"Tích là: {tich}");
    }
}
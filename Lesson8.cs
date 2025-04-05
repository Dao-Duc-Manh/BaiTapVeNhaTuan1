using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viết chương trình in ra bảng cửu chương từ 1 đến 10.
class Lesson8
{
    public void BangCuuChuong()
    {
        Console.WriteLine("Bảng cửu chương từ 1 đến 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bảng cửu chương {i}");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//viết ra chương trình tính giai thừa của 1 số nguyên dương
class Lesson9
{
    public void TinhGiaiThua()
    {
        int so;
        Console.WriteLine("Nhập số nguyên dương: ");
        if (int.TryParse(Console.ReadLine(), out so))
        {
            if (so < 0)
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ");
            }
            else
            {
                int giaiThua = 1;
                for (int i = 1; i <= so; i++)
                {
                    giaiThua *= i;
                }
                Console.WriteLine($"Giai thừa của {so} là: {giaiThua}");
            }
        }
        else
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ");
        }
    }
}
 

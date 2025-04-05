using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Lesson10
{
    //Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
    public void KiemTraSoNguyenTo()
    {
        int so;
        Console.WriteLine("Nhập số nguyên: ");
        if (int.TryParse(Console.ReadLine(), out so))
        {
            if (so < 2)
            {
                Console.WriteLine($"{so} không phải là số nguyên tố");
            }
            else
            {
                bool laNguyenTo = true;
                for (int i = 2; i <= Math.Sqrt(so); i++)
                {
                    if (so % i == 0)
                    {
                        laNguyenTo = false;
                        break;
                    }
                }
                if (laNguyenTo)
                {
                    Console.WriteLine($"{so} là số nguyên tố");
                }
                else
                {
                    Console.WriteLine($"{so} không phải là số nguyên tố");
                }
            }
        }
        else
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ");
        }
    }
}
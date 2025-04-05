using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
400)*/
class Lesson7
{
    public void KiemTraNamNhuan()
    {
        int nam;
        Console.WriteLine("Nhập năm: ");
        if (int.TryParse(Console.ReadLine(), out nam))
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
            {
                Console.WriteLine($"{nam} là năm nhuận");
            }
            else
            {
                Console.WriteLine($"{nam} không phải là năm nhuận");
            }
        }
        else
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ");
        }
    }
}

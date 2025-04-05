using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lesson6
{
    //Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
    public void KiemTraSo()
    {
        double so;
        Console.WriteLine("Nhập số: ");
        if (double.TryParse(Console.ReadLine(), out so))
        {
            if (so > 0)
            {
                Console.WriteLine($"{so} là số dương");
            }
            else if (so < 0)
            {
                Console.WriteLine($"{so} là số âm");
            }
            else
            {
                Console.WriteLine($"{so} là số không nguyên dương và không phải nguyên âm");
            }
        }
        else
        {
            Console.WriteLine("Giá trị nhập vào không hợp lệ");
        }
    }

}
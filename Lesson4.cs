using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//viết chương trình kiểm tra số nguyên và kiểm tra co0s phải số chẵn hay không
class Lesson4
{
    public void KiemTraSoNguyenVaChan()
    {
        int so;
        Console.WriteLine("nhập số nguyên: ");
        if (int.TryParse(Console.ReadLine(), out so))
        {
            Console.WriteLine($"{so} là số nguyên");
            //kiểm tra số chẵn hay lẻ
            if (so % 2 == 0)
            {
                Console.WriteLine($"{so} là số chẵn");
            }
            else
            {
                Console.WriteLine($"{so} là số lẻ");
            }
        }
        else
        {
            Console.WriteLine($"{so} không phải là số nguyên");
        }

    }
}


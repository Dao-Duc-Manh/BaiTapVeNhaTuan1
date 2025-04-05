using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lesson3
{
    public void ChuyenDoiDoCSangDoF()
    {
        double doC, doF;
        Console.WriteLine("Nhập nhiệt độ C: ");
        doC = double.Parse(Console.ReadLine() ?? "0");
        doF = (doC * 9 / 5) + 32;
        Console.WriteLine($"Nhiệt độ F là: {doF}");
    }
 
}
class Bai05
{
    //Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
    public void HoanViHaiSo()
    {
        Console.WriteLine("Nhập vào a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào b: ");
        int b = int.Parse(Console.ReadLine());
        //Hoán vị
        int temp = a;
        a = b;
        b = temp;
        //Hiển thi kết quả
        Console.WriteLine($"Sau khi hoán vị, a = {a}, b = {b}");
    }
}
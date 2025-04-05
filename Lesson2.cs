class Lesson2
{
    public void TinhDienTichHinhChuNhat()
    {
        double chieudai, chieurong, dientich;
        Console.WriteLine("Nhập chiều dài: ");
        chieudai = double.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Nhập chiều rộng: ");
        chieurong = double.Parse(Console.ReadLine() ?? "0");
        dientich = chieudai * chieurong;
        Console.WriteLine($"Diện tích hình chư nhật là: {dientich}");
    }
}
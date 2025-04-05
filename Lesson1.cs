class Lesson1
{
    public void NhapTenTuoi()
    {
        int tuoi;
        string ten;
        Console.WriteLine("Nhập tên: ");
        ten = Console.ReadLine() ?? "Unknown";
        Console.WriteLine("Nhập tuổi: ");
        tuoi = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"Xin chào : {ten}, bạn: {tuoi} tuổi!");
    }
}
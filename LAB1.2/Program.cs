//Bai 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Khởi tạo mảng
//        int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8 };

//        // Gọi hàm để tính tổng số chẵn
//        int tongSoChan = TinhTongSoChan(mang);

//        // Hiển thị kết quả
//        Console.WriteLine($"Tong cac so chan trong mang la: {tongSoChan}");
//    }

//    static int TinhTongSoChan(int[] mang)
//    {
//        int tong = 0;

//        // Duyệt qua từng phần tử trong mảng
//        foreach (int so in mang)
//        {
//            if (so % 2 == 0) // Kiểm tra số chẵn
//            {
//                tong += so;
//            }
//        }

//        return tong;
//    }
//}

// Bai 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập số phần tử của mảng
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] mang = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            mang[i] = int.Parse(Console.ReadLine());
//        }

//        // Kiểm tra và hiển thị các số nguyên tố trong mảng
//        Console.WriteLine("Cac phan tu la so nguyen to trong mang:");
//        for (int i = 0; i < n; i++)
//        {
//            if (LaSoNguyenTo(mang[i]))
//            {
//                Console.WriteLine($"chi so: {i},Gia tri {mang[i]}");
//            }
//        }
//    }

//    // Hàm kiểm tra một số có phải là số nguyên tố hay không
//    static bool LaSoNguyenTo(int so)
//    {
//        if (so < 2)
//        {
//            return false;
//        }
//        for (int i = 2; i <= Math.Sqrt(so); i++)
//        {
//            if (so % i == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}

// Bai 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập số phần tử của mảng
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        // Khởi tạo mảng
//        int[] mang = new int[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            mang[i] = int.Parse(Console.ReadLine());
//        }

//        // Gọi hàm để đếm số âm và số dương
//        (int soDuong, int soAm) = DemSoDuongVaSoAm(mang);

//        // Hiển thị kết quả
//        Console.WriteLine($"So luong so duong: {soDuong}");
//        Console.WriteLine($"So luong so am: {soAm}");
//    }

//    // Hàm đếm số lượng số âm và số dương trong mảng
//    static (int, int) DemSoDuongVaSoAm(int[] mang)
//    {
//        int soDuong = 0, soAm = 0;

//        // Duyệt qua các phần tử trong mảng
//        foreach (int so in mang)
//        {
//            if (so > 0)
//            {
//                soDuong++;
//            }
//            else if (so < 0)
//            {
//                soAm++;
//            }
//        }

//        return (soDuong, soAm); // Trả về số lượng số dương và số âm
//    }
//}

// Bai 4
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Khởi tạo mảng
//        int[] mang = { 5, 1, 9, 3, 7, 4, 32 };

//        // Gọi hàm tìm số lớn thứ hai
//        int soLonThuHai = TimSoLonThuHai(mang);

//        // Hiển thị kết quả
//        if (soLonThuHai != int.MinValue)
//        {
//            Console.WriteLine($"So lon thu hai trong mang la: {soLonThuHai}");
//        }
//        else
//        {
//            Console.WriteLine("Mang khong du so de tim so lon thu hai.");
//        }
//    }

//    static int TimSoLonThuHai(int[] mang)
//    {
//        int lonNhat = int.MinValue;
//        int lonThuHai = int.MinValue;

//        // Duyệt qua mảng để tìm số lớn nhất và lớn thứ hai
//        foreach (int so in mang)
//        {
//            if (so > lonNhat)
//            {
//                lonThuHai = lonNhat;
//                lonNhat = so;
//            }
//            else if (so > lonThuHai && so != lonNhat)
//            {
//                lonThuHai = so;
//            }
//        }

//        return lonThuHai; // Trả về số lớn thứ hai
//    }
//}

// Bai 5
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập số nguyên a
//        Console.Write("Nhap so nguyen a: ");
//        int a = int.Parse(Console.ReadLine());

//        // Nhập số nguyên b
//        Console.Write("Nhap so nguyen b: ");
//        int b = int.Parse(Console.ReadLine());

//        // Hiển thị giá trị trước khi hoán vị
//        Console.WriteLine($"Truoc khi hoan vi
//        // Hoán vị a và b
//        HoanVi(ref a, ref b);

//        // Hiển thị giá trị sau khi hoán vị
//        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
//    }

//    // Hàm hoán vị hai số nguyên
//    static void HoanVi(ref int x, ref int y)
//    {
//        int temp = x;
//        x = y;
//        y = temp;
//    }
//}

// Bai 6
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Nhập số phần tử của mảng
//        Console.Write("Nhap so phan tu cua mang: ");
//        int n = int.Parse(Console.ReadLine());

//        // Khởi tạo mảng
//        double[] mang = new double[n];

//        // Nhập các phần tử của mảng
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhap phan tu thu {i + 1}: ");
//            mang[i] = double.Parse(Console.ReadLine());
//        }

//        // Gọi hàm sắp xếp
//        SapXepTangDan(mang);

//        // Hiển thị mảng sau khi sắp xếp
//        Console.WriteLine("Mnag sau khi săp xep tang dan:");
//        foreach (double so in mang)
//        {
//            Console.Write(so + " ");
//        }
//    }

//    // Hàm sắp xếp mảng theo chiều tăng dần
//    static void SapXepTangDan(double[] mang)
//    {
//        Array.Sort(mang); // Sử dụng hàm có sẵn trong C# để sắp xếp
//    }
//}


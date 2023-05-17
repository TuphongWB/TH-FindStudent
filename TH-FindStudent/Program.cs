using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_FindStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] danhSachSinhVien = { "Hoa", "Lan", "Mai", "Trang", "Huong" };

            // Nhập tên sinh viên cần tìm
            Console.Write("Nhập tên sinh viên cần tìm: ");
            string tenSinhVien = Console.ReadLine();

            // Tìm vị trí của sinh viên trong danh sách
            int viTri = -1; // Khởi tạo giá trị mặc định là -1 (không tìm thấy)
            for (int i = 0; i < danhSachSinhVien.Length; i++)
            {
                if (danhSachSinhVien[i] == tenSinhVien)
                {
                    viTri = i;
                    break;
                }
            }

            // Kiểm tra kết quả tìm kiếm và hiển thị thông báo tương ứng
            if (viTri != -1)
            {
                Console.WriteLine("Sinh viên '{0}' được tìm thấy tại vị trí {1}.", tenSinhVien, viTri);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên '{0}' trong danh sách.", tenSinhVien);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laptrinhApc4.session14;
namespace laptrinhApc4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QLsinhvien qlsinhvien = new QLsinhvien();
            while (true)
            {
                Console.WriteLine("QUAN LI SINH VIEN");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1.Them sinh vien");
                Console.WriteLine("2.Cap nhat sinh vien theo ID");
                Console.WriteLine("3.Xoa sinh vien boi ID");
                Console.WriteLine("4.Tim kiem sinh vien theo ten");
                Console.WriteLine("5.Sap xep sinh vien theo diem trung binh(GPA)");
                Console.WriteLine("6.Sap xep sinh vien theo ten");
                Console.WriteLine("7.Sap xep sinh vien theo ID");
                Console.WriteLine("8.Hien thi danh sach sinh vien");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("----------------------------------------------");
                Console.Write("Chon phuong an:");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        qlsinhvien.NhapSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 2:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            qlsinhvien.UpdateSinhVien(id);
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!!");
                        }
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 3:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xoa sinh vien.");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (qlsinhvien.DeleteById(id))
                            {
                                Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!!");
                        }
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 4:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                            Console.Write("\nNhap ten de tim kiem: ");
                            string name = Convert.ToString(Console.ReadLine());
                            List<SinhVien> searchResult = qlsinhvien.FindByName(name);
                            qlsinhvien.ShowSinhVien(searchResult);
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!!");
                        }
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 5:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                            qlsinhvien.SortByDiemTB();
                            qlsinhvien.ShowSinhVien(qlsinhvien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!");
                        }
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 6:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                            qlsinhvien.SortByName();
                            qlsinhvien.ShowSinhVien(qlsinhvien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!");
                        }
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 7:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                            qlsinhvien.SortByID();
                            qlsinhvien.ShowSinhVien(qlsinhvien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!");
                        }
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 8:
                        if (qlsinhvien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                            qlsinhvien.ShowSinhVien(qlsinhvien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach trong!");

                        }
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong hop le! Yeu cau chon lai.");
                        Console.WriteLine("=============================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                
            
                }
            }
        }
    }
}
            

        
    


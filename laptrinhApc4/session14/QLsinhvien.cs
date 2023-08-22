using System;
using System.Collections.Generic;
using System.Configuration;

namespace laptrinhApc4.session14
{
    public class QLsinhvien
    {
        private List<SinhVien> ListSinhVien = null;
        public QLsinhvien()
        {
            ListSinhVien = new List<SinhVien>();
        }      

        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }

        public void NhapSinhVien()
        {
            SinhVien sv = new SinhVien();
            Console.Write("Nhap ID:");
            sv.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Gioitinh = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.Diemtoan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.Diemly = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            sv.Diemhoa = Convert.ToDouble(Console.ReadLine());

            TinhDTB(sv);
            XepLoaiHocLuc(sv);
            ListSinhVien.Add(sv);
        }
        public SinhVien FindByID(int Id)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.Id == Id)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }


        public void UpdateSinhVien(int ID)
        {            
            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                string name = Convert.ToString(Console.ReadLine());
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

                Console.Write("Nhap gioi tinh sinh vien: ");
                string gioitinh = Convert.ToString(Console.ReadLine());
                if (gioitinh != null && gioitinh.Length > 0)
                {
                    sv.Gioitinh = gioitinh;
                }

                Console.Write("Nhap tuoi sinh vien: ");
                string ageStr = Convert.ToString(Console.ReadLine());
                
                if (ageStr != null && ageStr.Length > 0)
                {
                    sv.Age = Convert.ToInt32(ageStr);
                }

                Console.Write("Nhap diem toan: ");
                string diemToanStr = Convert.ToString(Console.ReadLine());
               
                if (diemToanStr != null && diemToanStr.Length > 0)
                {
                    sv.Diemtoan = Convert.ToDouble(diemToanStr);
                }

                Console.Write("Nhap diem ly: ");
                string diemLyStr = Convert.ToString(Console.ReadLine());
                
                if (diemLyStr != null && diemLyStr.Length > 0)
                {
                    sv.Diemly = Convert.ToDouble(diemLyStr);
                }

                Console.Write("Nhap diem hoa: ");
                string diemHoaStr = Convert.ToString(Console.ReadLine());
                
                if (diemHoaStr != null && diemHoaStr.Length > 0)
                {
                    sv.Diemhoa = Convert.ToDouble(diemHoaStr);
                }

               
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", ID);
            }
        }

        public List<SinhVien> FindByName(String keyword)
        {
            List<SinhVien> searchResult = new List<SinhVien>();
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }

        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;

            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListSinhVien.Remove(sv);
            }
            return IsDeleted;
        }



        public void SortByID()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Id.CompareTo(sv2.Id);
            });
        }

        
        public void SortByName()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }

        
        public void SortByDiemTB()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2) {
                return sv1.Diemtb.CompareTo(sv2.Diemtb);
            });
        }

        
        
        public void TinhDTB(SinhVien sv)
        {
            double DiemTB = (sv.Diemtoan + sv.Diemly + sv.Diemhoa) / 3;
            sv.Diemtb = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }

        
        public void XepLoaiHocLuc(SinhVien sv)
        {
            if (sv.Diemtb >= 8)
            {
                sv.Hocluc = "Gioi";
            }
            else if (sv.Diemtb >= 6.5)
            {
                sv.Hocluc = "Kha";
            }
            else if (sv.Diemtb >= 5)
            {
                sv.Hocluc = "Trung Binh";
            }
            else
            {
                sv.Hocluc = "Yeu";
            }
        }

        
        public void ShowSinhVien(List<SinhVien> listSV)
        {         
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("Thong tin sinh vien co ID:"+sv.Id);
                    Console.WriteLine("Ho va ten:"+sv.Name);
                    Console.WriteLine("Tuoi:"+sv.Age);
                    Console.WriteLine("Gioi tinh:"+sv.Gioitinh);
                    Console.WriteLine("Diem toan:" + sv.Diemtoan);
                    Console.WriteLine("Diem ly:" + sv.Diemly);
                    Console.WriteLine("Diem hoa:" + sv.Diemhoa);
                    Console.WriteLine("Diem tb:" + sv.Diemtb);
                    Console.WriteLine("Hoc luc:"+sv.Hocluc);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        
        public List<SinhVien> getListSinhVien()
        {
            return ListSinhVien;
        }
    }
}

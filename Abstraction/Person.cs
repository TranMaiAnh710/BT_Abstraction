using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction.Abstraction
{
    public class Person
    {
        int ID { get; set; }
        string? HoTen { get; set; }
        int NamSinh { get; set; }
        string? GioiTinh { get; set; }
        string? SDT { get; set; }
        string? DiaChi { get; set; }

        public Person(int id, string hoTen, int namSinh, string gioiTinh)
        {
            ID = id;
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
        }
        public void HienThiTTin()
        {
            Console.OutputEncoding = Encoding.UTF8; // chữa lỗi encoding của Console

            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Năm sinh: " + NamSinh);
            Console.WriteLine("Giới tính: " + GioiTinh);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction.Abstraction
{
    public class PersonChild : Person
    {
        public PersonChild(int ID, string HoTen, int NamSinh, string GioiTinh)
        {
            this.ID = ID;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.GioiTinh = GioiTinh;
        }
        public override void HienThiTTin()
        {
            Console.OutputEncoding = Encoding.UTF8; // chữa lỗi encoding của Console

            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Năm sinh: " + NamSinh);
            Console.WriteLine("Giới tính: " + GioiTinh);
        }
    }
}

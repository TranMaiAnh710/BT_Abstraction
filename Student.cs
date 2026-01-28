using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction
{
    public abstract class Student
    {
        protected int MaSV { get; set; }
        protected string? HoTenSV { get; set; }
        protected string? GioiTinh { get; set; }
        protected int Khoa { get; set; }
        protected string? Lop { get; set; }

        public abstract void DangKyHP();
    }
}

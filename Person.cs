using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction
{
    public abstract class Person
    {
        protected int ID { get; set; }
        protected string? HoTen { get; set; }
        protected int NamSinh { get; set; }
        protected string? GioiTinh { get; set; }
        protected string? SDT { get; set; }
        protected string? DiaChi { get; set; }

        public abstract void HienthiTTin();
    }
}

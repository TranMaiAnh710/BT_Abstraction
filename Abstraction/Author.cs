using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction.Abstraction
{
    public abstract class Author
    {
        protected int MaTacGia { get; set; }
        protected string? HoTenTG { get; set; }
        protected int NamSinhTG { get; set; }
        protected string? QueQuan { get; set; }
        protected int SLTacPham { get; set; }

        public abstract void UpdateTTin();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Abstraction
{
    public abstract class Person
    {
        protected String? ID;
        protected String? HoTen;
        protected String? GioiTinh;
        protected String? SDT;

        public abstract void HienthiTTin();
    }
}

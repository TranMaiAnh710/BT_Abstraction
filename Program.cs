using BT_Abstraction.Abstraction;

namespace BT_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonChild sv = new PersonChild(1, "Nguyễn Văn A", 2004, "Nam");
            sv.HienThiTTin();

            Console.ReadLine();
        }
    }
}

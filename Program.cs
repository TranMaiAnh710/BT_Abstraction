using BT_Abstraction.Abstraction;

namespace BT_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person pr = new Person (1, "Nguyễn Văn A", 2004, "Nam");
            pr.HienThiTTin();

            Console.ReadLine();
        }
    }
}

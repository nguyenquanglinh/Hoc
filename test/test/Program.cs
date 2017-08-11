using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static bool soNguyenTo(int k)
        {
            if (k < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
            {
                if (k % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
            static bool sôChinhPhương(int k)
        {
            if (k < 1)
                return false;

            if (Math.Sqrt(k) - (int)Math.Sqrt(k) == 0)
                return true;
            return false;
        }
        static bool sochan(int d)
        {
            if (d % 2 == 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            //bang so nhan
            Console.WriteLine("nhap so cân viet a=");
            int a = int.Parse(Console.ReadLine());

            int b = 2;
            while (b < a)
            {
                int c1 = 1;
                while (c1 <= 10)
                {
                    Console.WriteLine("{0}x{1}={2}", b, c1, b * c1);
                    c1++;
                }
                Console.WriteLine();
                b++;
            }
            //bieu dien so

            Console.WriteLine("nhap so can bieu dien n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i < 16)
                    Console.Write("0");

                Console.Write("{0} ", Convert.ToString(i, 16));
                if (i % 16 == 15)
                    Console.WriteLine();
            }
            //tinh tong chan le
            Console.WriteLine("nhap so bat dau a");
            int batdau = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ket thuc b");
            int ketthuc = int.Parse(Console.ReadLine());
            int TongChan = 0, TongLe = 0, demchan = 0, demle = 0;
            for (int c2 = batdau; c2 <= ketthuc; c2++)
            {
                if (sochan(c2) == true)
                {
                    TongChan = TongChan + c2;
                    demchan++;
                }
                if (sochan(c2) == false)
                {
                    TongLe = TongLe + c2;
                    demle++;
                }
            }
            Console.WriteLine("tong cac so chăn trong day la {0}", TongChan);
            Console.WriteLine("so chăn trong day la {0}", demchan);
            Console.WriteLine("tong cac so le trong day la {0}", TongLe);
            Console.WriteLine("so le trong day la {0}", demle);
            //so ching phuong
            Console.WriteLine("nhâp vao sô bat đâu a la");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao sô kêt thuc b la");
            int b1 = int.Parse(Console.ReadLine());
            if (a1 < 0) a1 = 0;
            if (b1 < 0) b1 = 0;
            int c = 0, dem = 0;
            for (c = a1; c <= b1; c++)
            {
                if (sôChinhPhương(c) == true)
                {
                    dem++;
                    Console.WriteLine("sô chinh phuong la {0}", c);
                }
            }
            Console.WriteLine("sô cac sô chinh phương trong day la {0}", dem++);
            //so nguyen to

            Console.WriteLine("nhap so bat dau a=");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ket thuc b=");
            int b3 = int.Parse(Console.ReadLine());
            if (a < 0) a = 0;
            if (b < 0) b = 0;
            int dem6 = 0;
            for (int c4 = a3; c4 <= b3; c4++)
            {
                if (soNguyenTo(c) == true)
                {
                    dem6++;
                    Console.WriteLine("sô nguyên tô trong day la {0}", c4);
                }
            }
            Console.WriteLine("sô cac so nguyen to la {0}", dem++);


        }
    }
}

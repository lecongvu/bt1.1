using System;
using System.Text;
namespace bt1._1
{
    class Program
    {
        // bai 1: tính tổng 2 số a,b nhập từ bán phím
        //  bai2 : tính cộng trừ nhân chia 2 số a,b nhập từ bàn phím 
        // bài 3:  tính căn bậc 2 của số a
        static void Main(string[] args)
        {

            int a = 4, b = 6;
            Console.WriteLine("Tong cua {0} va {1} la:{2}", a, b, a + b);
            //nhập năm sinh từ bàn phím 
            Console.WriteLine("Nhap nam sinh: ");
            // chuyển đổi dạng chuỗi sang số 
            int namsinh = Convert.ToInt32(Console.ReadLine());
            //hiển thịn số tuổi hiện tại và tính năm sinh
            Console.WriteLine("tuoi hien tai cua nam sinh  la:{0} ", 2022 - namsinh);
            //khai báo biến tuổi
            int tuoi = 2022 - namsinh;
            //hiển thị năm về hưu bẳng cách lấy 60-tuổi
            Console.WriteLine("nam ve huu cua nam sinh : {1}", namsinh, 60 - tuoi);


            Console.WriteLine("nhap so tien");
            double sotien = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tien bang anh sau khi chuyen doi:{0} ", sotien*0.8144);
            Console.WriteLine("Tien nhat sau khi chuyen doi:{0} ", sotien * 105.407);
            Console.WriteLine("Tien vnd sau khi chuyen doi:{0} ", sotien * 23.160);


        }
    }
}

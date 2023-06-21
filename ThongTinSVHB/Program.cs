using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinSVHB
{
    internal class Program
    {
        struct SinhVien
        {
            public string name;
            public string gender;
            public DateTime birthday;
            public string address;
          
        }
        public enum Hobbies
        {
            Code = 1,
            Sleep = 2,
            PlayingSports = 4,
            WatchingTv = 5,
            ReadingBook = 6,
            Animal = 7,
        }

        public enum Talent
        {
            PlayingFootball = 1,
            PlayingGame = 2,
            PlayMusic = 3,
            Code = 4,
            Singging = 5
        }
        static void Main(string[] args)
        {
         
            SinhVien SV1 = new SinhVien();
            SV1.name = "Bùi Văn Phát";
            SV1.gender = "male";
            SV1.birthday = DateTime.Parse("01/01/2002");
            SV1.address = "Thanh Oai, Ha Noi";

            SinhVien SV2 = new SinhVien();
            SV2.name = "Dao Minh Phu";
            SV2.gender = "male";
            SV2.birthday = DateTime.Parse("01/01/1997");
            SV2.address = "Cau Giay, Ha Noi";

            SinhVien SV3 = new SinhVien();
            SV3.name = "Chuong Huy Hoang";
            SV3.gender = "male";
            SV3.birthday = DateTime.Parse("01/01/2001");
            SV3.address = "Cau Giay, Ha Noi";

            SinhVien SV4 = new SinhVien();
            SV4.name = "Vo Nang";
            SV4.gender = "male";
            SV4.birthday = DateTime.Parse("01/01/2000");
            SV4.address = "Dong Anh, Ha Noi";

            SinhVien SV5 = new SinhVien();
            SV5.name = "Nguyen Van Truong";
            SV5.gender = "Female";
            SV5.birthday = DateTime.Parse("01/01/2002");
            SV5.address = "Ha Dong, Ha Noi";

            SinhVien SV6 = new SinhVien();
            SV6.name = "Ngo Quan";
            SV6.gender = "Female";
            SV6.birthday = DateTime.Parse("01/01/1991");
            SV6.address = "Bac Tu Liem, Ha Noi";

            Console.WriteLine("-----------------------------------------------***Thong tin hoc vien***-----------------------------------------------");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", "Ho ten", "Gioi tinh", "Ngay Sinh", "Dia chi", "So Thich", "So Truong");
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV1.name, SV1.gender, SV1.birthday.ToShortDateString(), SV1.address , Hobbies.Code + "," + Hobbies.Animal , Talent.Code + "," + Talent.PlayingFootball);
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV2.name, SV2.gender, SV2.birthday.ToShortDateString(), SV2.address, Hobbies.Sleep + "," + Hobbies.PlayingSports, Talent.Code + "," + Talent.PlayMusic);
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV3.name, SV3.gender, SV3.birthday.ToShortDateString(), SV3.address, Hobbies.PlayingSports + "," + Hobbies.Animal, Talent.Singging + "," + Talent.PlayMusic);
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV5.name, SV4.gender, SV4.birthday.ToShortDateString(), SV4.address, Hobbies.ReadingBook + "," + Hobbies.Code, Talent.PlayMusic + "," + Talent.Singging);
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV5.name, SV5.gender, SV5.birthday.ToShortDateString(), SV5.address, Hobbies.Sleep + "," + Hobbies.PlayingSports, Talent.PlayMusic + "," + Talent.PlayingGame);
            Console.WriteLine("{0, -20} {1, -12} {2, -12} {3, -22} {4, -22} {5, -15}", SV6.name, SV6.gender, SV6.birthday.ToShortDateString(), SV6.address, Hobbies.Animal + "," + Hobbies.Code, Talent.Singging + "," + Talent.PlayingFootball);

            Console.ReadKey();



            //Console.WriteLine("{0}",SV1.birthday.ToShortDateString());
        }
    }
}

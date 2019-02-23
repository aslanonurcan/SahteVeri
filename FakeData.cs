using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    
    class FakeData
    {
        public int id { get; set; }
        public string isim { get; set; }

        public string soyİsim { get; set; }
        public int yas { get; set; }
        public int number { get; set; }

        Random rnd = new Random();
        public static string[] isimlst = { "Onur" , "Serkan" , "Yusuf" , "Nükhet"  , "Selcen" , "Hasan" , "Ahmet" , "Günışığı" , "Gülşah" ,"Gülcan" };
        public static string[] soyİsimlst = { "Atan", "Tutan", "Bakan", "Koç", "Sabancı", "Gençoğlu" , "Karaca" , "Manço" , "Koray" , "Kenter"};
        public static int[] yaslst = new int[10];
        public static int[] numberlst = new int[10];

         
        //public void _number()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        numberlst[i] = rnd.Next(0, 100);
        //    }

        //}

        //public void _yas()
        //{


    //}


    public static object Karma()
        {
            List<FakeData> olist = new List<FakeData>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            { 
                numberlst[i] = rnd.Next(0, 100);
            }

            for (int i = 0; i < 10; i++)
            {
                yaslst[i] = rnd.Next(18, 30);
            }

            for (int i = 1; i <= 100; i++)
            {
                FakeData o = new FakeData();
                string x, y;
                o.id = i;
                x = isimlst[rnd.Next(0, 10)];
                o.isim = x;
                y = soyİsimlst[rnd.Next(0, 10)];
                o.soyİsim = y;
                o.yas = yaslst[rnd.Next(0, 10)];
                o.number= numberlst[rnd.Next(0, 10)];
                olist.Add(o);
            }

            return olist;
        }

        //public static string Karmaisim(int i)
        //{

        //    string x;
        //    x = isimlst[i];
        //    return x;
        //}   

        //public static int Karmayas(int i)
        //{
            
        //    int x;
        //    x = yaslst[i];
        //    return x;
        //}

        //public static int Karmanumber(int i)
        //{
            
        //    int x;
        //    x = numberlst[i];
        //    return x;
        //}

    }
}

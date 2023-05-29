using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Project
{
    class Program
    {
        class banka
        {
            string isim = "umut";
            string sifre = "123";
            double bakiye;
            double altin;
            public banka()
            {
                
                while (true)
                {
                    Console.WriteLine("Bankamıza hoşgeldiniz. giriş yapmak için 1'e kaydolmak için 2'ye basınız;");
                    var secim = Console.ReadKey().KeyChar;
                    if (secim == '1')
                    {
                        Console.Clear();
                        giris();
                        break;
                    }
                    else if (secim == '2')
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adınızı giriniz.");
                        string yeni_isim = Console.ReadLine();
                        Console.WriteLine("Şifrenizi giriniz.");
                        string yeni_sifre = Console.ReadLine();
                        kayit(yeni_isim, yeni_sifre);
                        giris();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli komut giriniz.");
                    }
                }
            }


            public void giris()
            {
                while (true) 
                {
                    Console.WriteLine("Kullanıcı isminizi giriniz");
                    string girilen_isim = Console.ReadLine();
                    Console.WriteLine("Şifrenizi giriniz.");
                    string girilen_sifre = Console.ReadLine();
                    if (girilen_isim == isim) 
                    {
                        if (girilen_sifre == sifre)
                        {
                            Console.Clear();
                            Console.WriteLine("Hosgeldiniz.");
                            break;                           
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Yanlış şifre");
                        }
                    }
                    else if (girilen_sifre == sifre)
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı adınız yanlış");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Kullanıcı bilgileriniz yanlış");
                    }
                }
            }
            public void kayit(string yeni_isim, string yeni_sifre)
            {                
                this.isim = yeni_isim;
                this.sifre = yeni_sifre;
                Console.Clear();
                Console.WriteLine("Kayıt olma işleminiz başarıyla tamamlanmıştır.");               
            }           
            public double bakiyemi_belirle
            {
                get { return bakiye; }
                set { bakiye = value; }
            }
            public void para_cek(int miktar)
            {
                bakiye -= miktar;
                Console.WriteLine("Kalan bakiyeniz: {0}", bakiye);
            }
            public void para_yatir(int miktar)
            {
                bakiye += miktar;
                Console.WriteLine("Kalan bakiyeniz {0}", bakiye);
            }           
            public double altinimi_belirle
            {
                get { return altin; }
                set {  altin = value; }
            }
            public void altin_al(double bakiye)
            {
                altin += bakiye / 99;
                Console.WriteLine("Kalan altın miktarınız: {0}.",altin);
                this.bakiye -= bakiye;
            }
            public void altin_bozdur(double bakiye)
            {
                altin -= bakiye / 99;
                Console.WriteLine("Kalan altın miktarınız: {0}.", altin);
                this.bakiye += bakiye;
            }


        }
        static void Main(string[] args)
        {
            banka i1 = new banka();
            Console.WriteLine("Bankanızdaki bakiye miktarınız kaç olsun.");
            i1.bakiyemi_belirle = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Bankanızdaki altın miktarınız kaç olsun.");
            i1.altinimi_belirle =Convert.ToDouble(Console.ReadLine()) ;
            Console.WriteLine("Bakiye miktarınız: {0}", i1.bakiyemi_belirle);
            Console.WriteLine("Altın miktarınız: {0}", i1.altinimi_belirle);
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz. (1: para çekme 2: para yatırma 3: altın alma");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Kaç para çekmek istiyorsunuz.");
                int miktar = Convert.ToInt32(Console.ReadLine());
                i1.para_cek(miktar);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kaç para yatırmak istiyorsunuz.");
                int miktar = Convert.ToInt32(Console.ReadLine());
                i1.para_yatir(miktar);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Altın almak için 1'i altın bozdurmak için 2'yi seçiniz");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("kaç bakiye miktarında altın almak istiyorsunuz.");
                    double y = Convert.ToInt32(Console.ReadLine());
                    i1.altin_al(y);
                }
                else if (x == 2)
                {
                    Console.WriteLine("kaç bakiye miktarında altın bozdurmak istiyorsunuz.");
                    double z = Convert.ToInt32(Console.ReadLine());
                    i1.altin_bozdur(z);
                }
                else
                    Console.WriteLine("Yanlış komut verdiniz.");

            }
            else
                Console.WriteLine("Yanlış komut verdiniz.");
            //Console.WriteLine("Bakiye miktarınız: {0}", i1.bakiyemi_goster());
            //Console.WriteLine("Altın miktarınız: {0}", i1.altinimi_goster());
            Console.ReadLine();
        }
    }
}

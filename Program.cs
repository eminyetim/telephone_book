using System;

namespace telefon_rehberi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int okunanDeger = 6;           
            while(okunanDeger != 0)
            {
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayi Silmek");
                System.Console.WriteLine("(3) Varolan Numarayi Güncelle");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");
                System.Console.WriteLine("(0) Çikis Yapmak İçin");
                System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");

                okunanDeger = int.Parse(Console.ReadLine());
                switch (okunanDeger)
                {
                    case 1 : Rehberim.KayitEkle(); break;
                    case 2 : Rehberim.NumaraSilme(); break;
                    case 3 : Rehberim.NumarGuncelle(); break;
                    case 4 : Rehberim.Listele(); break;
                    case 5 : Rehberim.NuamarArama(); break;
                    case 0 : break;
                    default:
                        System.Console.WriteLine("Lütfen 1 - 5 arası değer giriniz.");
                    break;
                }
            }
             
    
        }

            
    }
}
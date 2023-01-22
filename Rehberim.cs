using System;

namespace telefon_rehberi
{
    public static class Rehberim{
        
        public static List<Person> my_list = new List<Person>();
        
        public static  void KayitEkle()
        {
            string gelen_soyisim;
            string gelen_isim;
            string gelen_numara = "";

            System.Console.WriteLine("Lütfen isim giriniz :");    
            gelen_isim =  Convert.ToString(Console.ReadLine());
           
            System.Console.WriteLine("Lütfen soyisim giriniz :"); 
            gelen_soyisim = Convert.ToString(Console.ReadLine());
            
            do
            {
                System.Console.WriteLine("Lütfen numara giriniz :5xx xxx xxxx"); 
                gelen_numara =  Convert.ToString(Console.ReadLine());

            } while(gelen_numara.Length > 12);
           
            

            Person prs = new Person();
            prs.Isim1 = gelen_isim;
            prs.Soyisim1 = gelen_soyisim;
            prs.Numara1 = gelen_numara;

           my_list.Add(prs);
        }

        public static void Listele()
        {
            System.Console.WriteLine("\n** Rehberim **");
            foreach (var item in my_list)
            {
                System.Console.WriteLine(item.Isim1 + " " + item.Soyisim1 + " " + item.Numara1);
            }
            System.Console.WriteLine();
        }

        public static void NumaraSilme()
        {
            System.Console.WriteLine("Lütfen silmek istediğiniz kişinin ismini ya da soyisminiz giriniz.");
            string aranacakDeger = Convert.ToString(Console.ReadLine());

            bool res = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == aranacakDeger || item.Soyisim1 == aranacakDeger)
                {
                    my_list.Remove(item);
                    res = true;
                    break;
                }
            }   
            if(res)
                System.Console.WriteLine( aranacakDeger + " silinidi");
            else
            {
                System.Console.WriteLine("Numara bulunamadi tekrar denemek istermisin Evet = 1 Hayir = 0");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                {
                    NumaraSilme();
                }
            }
        }

        public static void NumarGuncelle()
        {
            System.Console.WriteLine("Lütfen guncellemek istediğiniz kişinin ismini ya da soyisminiz giriniz.");
            string aranacakDeger = Convert.ToString(Console.ReadLine());

            bool res = false;
            foreach (var item in my_list)
            {
                if(item.Isim1 == aranacakDeger || item.Soyisim1 == aranacakDeger)
                {
                    System.Console.WriteLine( aranacakDeger + " nin yeni numaraysini giriniz.");
                    item.Numara1 = Convert.ToString(Console.ReadLine());
                    res = true;
                    break;
                }
            }
            if(res)
                System.Console.WriteLine( aranacakDeger + " Guncellendi ");
            else
            {
                System.Console.WriteLine("Numara bulunamadi tekrar denemek istermisin Evet = 1 Hayir = 0");
                int islem = int.Parse(Console.ReadLine());
                if(islem == 1)
                {
                    NumarGuncelle();
                }
            }
            

        }

        public static void NuamarArama()
        {

            System.Console.WriteLine("İsmi Soyisime göre arama yapmak için 1");
            System.Console.WriteLine("Numaraya Göre arama yapmak için 2");

            int neIleArama = int.Parse(Console.ReadLine());

            if(neIleArama == 1)
            {
                System.Console.WriteLine("Lütfen listemek istediğiniz kişinin ismini ya da soyisminiz giriniz.");
                string aranacakDeger = Convert.ToString(Console.ReadLine());

                bool res = false;
                foreach (var item in my_list)
                {
                    if(item.Isim1 == aranacakDeger || item.Soyisim1 == aranacakDeger)
                    {
                        System.Console.WriteLine( "\n" + item.Isim1 + " " + item.Soyisim1 + " " + item.Numara1);
                        res = true;
                        break;
                    }
                }
                if(res)
                    System.Console.WriteLine( aranacakDeger + " Listelendi ");
                else
                {
                    System.Console.WriteLine("Numara bulunamadi tekrar denemek istermisin Evet = 1 Hayir = 0");
                    int islem = int.Parse(Console.ReadLine());
                    if(islem == 1)
                    {
                        NuamarArama();
                    }
                }
            }
            else if(neIleArama == 2)
            {
                System.Console.WriteLine("Lütfen listemek istediğiniz kişinin numarasini giriniz.");
                string aranacakDeger = Convert.ToString(Console.ReadLine());

                bool res = false;
                foreach (var item in my_list)
                {
                    if(item.Numara1 == aranacakDeger)
                    {
                        System.Console.WriteLine("\n" +item.Isim1 + " " + item.Soyisim1 + " " + item.Numara1);
                        res = true;
                        break;
                    }
                }
                if(res)
                    System.Console.WriteLine( aranacakDeger + " Listelendi ");
                else
                {
                    System.Console.WriteLine("Numara bulunamadi tekrar denemek istermisin Evet = 1 Hayir = 0");
                    int islem = int.Parse(Console.ReadLine());
                    if(islem == 1)
                    {
                        NuamarArama();
                    }
                }
            }

        }
      
    }

}
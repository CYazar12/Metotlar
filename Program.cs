using System;

namespace metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Erişim_belirteçleri Geri_dönüştipi Metot_adi(parametrelerListesi/arguman)
            {
                komutlar
                return
            } */

            int a = 2;
            int b = 3;

            int sonuc = Topla(a,b);

            //Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.Yazdir(Convert.ToString(sonuc));
            int sonuc2 = ornek.ArttırVeTopla(a,b) ;//int sonuc2 = ornek.ArttırVeTopla(ref a,ref b)
        }   

        static int Topla(int deger1, int deger2) //ilk metotumuz ayni class icinde
        {
            return(deger1+deger2);
        }
    }

    class Metotlar // 2. metot  farkli bir class dan metot cagir
    {
        public void Yazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int deger1, int deger2)
        {
            deger1 +=1;
            deger2 +=1;

            return deger1 + deger2;
        }

        public int ArttırVeTopla(ref int deger1,ref  int deger2) //------> ref olduğunda değerlerin bellekteki karşılıklarını,(adreslerini) veriyor. Fonksiyona a ve b yi değilde adreslerini veriyoruz.
        {                                                           //------> kopyalar üzerinde değişim yapmak yerine orijinal adresteki yerleri üzerinde değişiklik yapıyor.
            deger1 +=1;
            deger2 +=1;

            return deger1 + deger2;
        }
    }
}